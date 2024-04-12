using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrackerDS;
using ExpenseTracker;

namespace ExpenseTrackerGUI
{
    public partial class CategoryView : UserControl
    {
        public CategoryView()
        {
            InitializeComponent();

            data = new List<Category>();
            data = Communicator.Manager.FetchCategories();

            expenseTrees = new List<TreeControl>();
            incomeTrees = new List<TreeControl>();
            modifyCategory = new ModifyCategory();
            this.Controls.Add(modifyCategory);
            modifyCategory.Hide();
            modifyCategory.CategoryChange += OnCategoryChanged;
            modifyCategory.CategoryClose += OnCategoryClosed;
            modifyCategory.WalletChange += OnWalletChanged;

            wallet = new Wallet();

            TreeWidth = this.Width - 120;
            pnlExpenseCategory.Hide();
            GetTreeControls(true);
            GetTreeControls(false);
            pnlExpense.Show();

            inactiveIncomeCategory = new List<BranchControl>();
            inactiveExpenseCategory = new List<BranchControl>();
        }

        private bool categoryType = false, editMode= false, addMode=false;
        private string searchText = "";
        private int width = 460, borderWidth = 12;
        private Wallet wallet;
        private List<TreeControl> incomeTrees;
        private List<TreeControl> expenseTrees;
        private List<BranchControl> inactiveIncomeCategory;
        private List<BranchControl> inactiveExpenseCategory;

        private List<Category> data;
        private ModifyCategory modifyCategory;

        public event EventHandler<Category> CategorySelect;

        public event EventHandler CategoryClose;
        public event EventHandler SearchBar;

        #region Properties

        public int TreeWidth
        {
            get => width;
            set
            {
                width = value;
            }
        }

        public bool EditMode
        {
            get => editMode;
            set => editMode = value;
        }

        public int BorderWidth
        {
            get => borderWidth;
            set
            {
                borderWidth = value;
                pnlTop.Height = pnlBottom.Height = pnlRight.Width = pnlLeft.Width = borderWidth;
            }
        }

        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                if (searchText.Length > 0)
                {
                    OnSeachBarTextChanged(this, searchText);
                }
                else
                {
                    OnSearchBackClicked(this, EventArgs.Empty);
                }
            }
        }

        public Wallet Wallet
        {
            get => wallet;
            set
            {
                wallet = value;
            }
        }

        public Wallet WalletChange
        {
            get => Wallet;
            set
            {
                Wallet = value;
                ShowCategory(true, Wallet);
                ShowCategory(false, Wallet);
            }
        }

        #endregion

        #region GetTreeControls

        public void GetTreeControls(bool b)
        {
            data.Clear();
            data = Communicator.Manager.FetchCategories();
            if (data == null || data.Count == 0) return;
            List<Category> list = data.Where(c => c.Type == b).ToList();
            if (list == null) return;
            if (b)
            {
                foreach(TreeControl tree in incomeTrees)
                {
                    foreach (BranchControl branch in tree.Controls)
                    {
                        branch.Dispose();
                        branch.Click -= OnBranchClicked;
                    }
                    tree.Dispose();
                }
                incomeTrees.Clear();
                pnlIncomeCategory.Controls.Clear();
                
                foreach (Category c in list)
                {
                    int id, parentId;
                    id = c.ID;
                    parentId = c.ParentId;
                    if (parentId == 0)
                    {
                        TreeControl treeControl = new TreeControl();
                        BranchControl branchControl = new BranchControl();

                        branchControl.Click += OnBranchClicked;

                        treeControl.Name = branchControl.Name = id.ToString();
                        branchControl.BranchText = c.CategoryName;
                        branchControl.ImagePath = c.ImagePath;
                        branchControl.Category = c;
                        branchControl.Font = new Font("Arial", 12, FontStyle.Bold);
                        
                        treeControl.Controls.Add(branchControl);


                        foreach (Category c1 in list)
                        {
                            int subId, subParentId;
                            subId = c1.ID;
                            subParentId = c1.ParentId;

                            if (id == subParentId)
                            {
                                BranchControl child = new BranchControl();

                                child.Click += OnBranchClicked;

                                child.Name = subId.ToString();
                                child.ImagePath = c1.ImagePath;
                                child.BranchText = c1.CategoryName;
                                child.Category = c1;
                                treeControl.Controls.Add(child);
                            }
                        }
                        pnlIncomeCategory.Controls.Add(treeControl);
                        treeControl.Width = TreeWidth;

                        incomeTrees.Add(treeControl);
                    }
                }

                ShowCategory(true, Wallet);
            }
            else
            {
                foreach (TreeControl tree in expenseTrees)
                {
                    foreach (BranchControl branch in tree.Controls)
                    {
                        branch.Dispose();
                        branch.Click -= OnBranchClicked;
                    }
                    tree.Dispose();
                }
                expenseTrees.Clear();
                pnlExpenseCategory.Controls.Clear();
                
                foreach (Category c in list)
                {
                    int id, parentId;
                    id = c.ID;
                    parentId = c.ParentId;
                    if (parentId == 0)
                    {
                        TreeControl treeControl = new TreeControl();
                        BranchControl branchControl = new BranchControl();

                        branchControl.Click += OnBranchClicked;

                        treeControl.Name = branchControl.Name = id.ToString();
                        branchControl.ImagePath = c.ImagePath;
                        branchControl.BranchText = c.CategoryName;
                        branchControl.Category = c;
                        branchControl.Font = new Font("Arial", 12, FontStyle.Bold);
                        
                        treeControl.Controls.Add(branchControl);
                        
                        foreach (Category c1 in list)
                        {
                            int subId, subParentId;
                            subId = c1.ID;
                            subParentId = c1.ParentId;

                            if (id == subParentId)
                            {
                                BranchControl child = new BranchControl();

                                child.Click += OnBranchClicked;

                                child.Name = subId.ToString();
                                child.ImagePath = c1.ImagePath;
                                child.BranchText = c1.CategoryName;
                                child.Category = c1;
                                treeControl.Controls.Add(child);
                            }
                        }
                        pnlExpenseCategory.Controls.Add(treeControl);

                        expenseTrees.Add(treeControl);
                    }
                }
                ShowCategory(false, Wallet);
            }
        }
        
        private void ShowCategory(bool b, Wallet w)
        {
            int xPos1 = 25, yPos1 = 10, branchSpace = 10, childSpace = 60, xPos2 = 25, yPos2 = 10, treeSpace = 10;
            bool walletCheck = false;
            if (b)
            {
                foreach (TreeControl tree in pnlIncomeCategory.Controls)
                {
                    walletCheck = false;
                    yPos1 = 10;
                    tree.Height = 0;
                    tree.Width = TreeWidth;
                    foreach (BranchControl branch in tree.Controls)
                    {
                        if (w != null && branch.Category.WalletId != null && (branch.Category.WalletId.Contains(w.WalletID) || w.WalletID == 0))
                        {
                            if (branch.Category.WalletId.Count!=0 || EditMode)
                            {
                                tree.Height += branch.Height + branchSpace;
                                if (branch.Category.ParentId == 0) branch.Location = new Point(xPos1, yPos1);
                                else branch.Location = new Point(xPos1 + childSpace, yPos1);
                                yPos1 += (branch.Height + branchSpace);

                                branch.Show();
                                walletCheck = true;
                            }
                        }
                        else
                        {
                            branch.Hide();
                        }
                    }
                    if (walletCheck)
                    {
                        tree.Height += (branchSpace);
                        tree.Location = new Point(xPos2, yPos2);
                        yPos2 += (tree.Height + treeSpace);
                    }
                }
            }
            else
            {
                foreach (TreeControl tree in pnlExpenseCategory.Controls)
                {
                    walletCheck = false;
                    yPos1 = 10;
                    tree.Height = 0;
                    tree.Width = TreeWidth;
                    foreach (BranchControl branch in tree.Controls)
                    {
                        if (w != null && branch.Category.WalletId != null && (branch.Category.WalletId.Contains(w.WalletID) || w.WalletID == 0))
                        {
                            if (branch.Category.WalletId.Count != 0 || EditMode)
                            {
                                tree.Height += branch.Height + branchSpace;
                                if (branch.Category.ParentId == 0) branch.Location = new Point(xPos1, yPos1);
                                else branch.Location = new Point(xPos1 + childSpace, yPos1);
                                yPos1 += (branch.Height + branchSpace);

                                branch.Show();
                                walletCheck = true;
                            }
                        }
                        else
                        {
                            branch.Hide();
                        }
                    }
                    if (walletCheck)
                    {
                        tree.Height += (branchSpace);
                        tree.Location = new Point(xPos2, yPos2);
                        yPos2 += (tree.Height + treeSpace);
                    }
                }
            }
        }

        private void ShowCategory(string e)
        {
            int xPos = 25, yPos = 10, branchSpace = 10;

            List<Category> list = Communicator.Manager.FetchCategories(e);
            if (list == null || list.Count == 0) return;
            list = list.FindAll(i => i.Type == categoryType).ToList();

            foreach (Control c in pnlSearch.Controls) c.Dispose();
            pnlSearch.Controls.Clear();

            foreach (Category c in list)
            {
                BranchControl branch = new BranchControl();
                branch.BranchText = c.CategoryName;
                branch.Name = c.ID.ToString();

                pnlSearch.Controls.Add(branch);
                branch.Location = new Point(xPos, yPos);
                yPos += (branch.Height + branchSpace);
                branch.Width = pnlSearch.Width - 50;

                branch.Click += OnBranchClicked;
            }

        }

        private void ChangeTreeWidth()
        {
            if (incomeTrees != null && expenseTrees != null)
            {
                foreach (TreeControl t in incomeTrees) t.Width = TreeWidth;
                foreach (TreeControl t in expenseTrees) t.Width = TreeWidth;
            }
        }

        #endregion

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            pnlIncomeCategory.Hide();
            pnlExpenseCategory.Show();
            pnlExpenseCategory.Dock = DockStyle.Fill;
            pnlExpenseCategory.BringToFront();
            pnlIncomeCategory.Dock = DockStyle.Right;
            pnlSearch.Hide();


            pnlExpense.BackColor = GUIStyles.primaryColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            TreeWidth = this.Width - 120;
            ChangeTreeWidth();
        }

        private void OnMouseEntered(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Name != "lblAddCategory")
            {
                control.BackColor = GUIStyles.secondaryColor;
                control.ForeColor = Color.White;
            }
            control.Cursor = Cursors.Hand;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Name != "lblAddCategory")
            {
                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
            }
            control.Cursor = Cursors.Arrow;
        }

        private void OnVisibilityChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                if (categoryType) pnlIncomeCategory.Hide();
                else pnlExpenseCategory.Hide();
                GetTreeControls(true);
                GetTreeControls(false);
                if (categoryType) pnlIncomeCategory.Show();
                else pnlExpenseCategory.Show();

                TreeWidth = this.Width - 120;
                ChangeTreeWidth();
            }
        }

        #endregion

        #region Expense&Income

        private void OnExpenseButtonClicked(object sender, EventArgs e)
        {
            if (!categorySearchBar.SearchBarShow)
            {
                pnlExpense.BackColor = GUIStyles.primaryColor;
                pnlIncome.BackColor = Color.Transparent;
                pnlIncomeCategory.Hide();
                pnlExpenseCategory.Show();
                pnlExpenseCategory.Dock = DockStyle.Fill;
                pnlExpenseCategory.BringToFront();
                pnlIncomeCategory.Dock = DockStyle.Right;
                pnlSearch.Hide();
                categoryType = false;
            }
            categorySearchBar.SearchBarShow = false;
            SearchBar?.Invoke(this, EventArgs.Empty);
        }

        private void OnIncomeBtnClicked(object sender, EventArgs e)
        {
            if (!categorySearchBar.SearchBarShow)
            {
                pnlExpense.BackColor = Color.Transparent;
                pnlIncome.BackColor = GUIStyles.primaryColor;
                pnlIncomeCategory.Show();
                pnlExpenseCategory.Hide();
                pnlIncomeCategory.Dock = DockStyle.Fill;
                pnlIncomeCategory.BringToFront();
                pnlExpenseCategory.Dock = DockStyle.Left;
                pnlSearch.Hide();
                categoryType = true;
            }
            categorySearchBar.SearchBarShow = false;
            SearchBar?.Invoke(this, EventArgs.Empty);
        }

        #endregion
        
        #region SearchBar

        private void OnSearchBackClicked(object sender, EventArgs e)
        {
            categorySearchBar.Width = 50;
            if (categoryType)
            {
                pnlIncomeCategory.Show();
                pnlExpenseCategory.Hide();
                pnlIncomeCategory.Dock = DockStyle.Fill;
                pnlIncomeCategory.BringToFront();
                pnlExpenseCategory.Dock = DockStyle.Left;
            }
            else
            {
                pnlIncomeCategory.Hide();
                pnlExpenseCategory.Show();
                pnlExpenseCategory.Dock = DockStyle.Fill;
                pnlExpenseCategory.BringToFront();
                pnlIncomeCategory.Dock = DockStyle.Right;
            }
            pnlSearch.Hide();
        }

        private void OnSearchBarClicked(object sender, EventArgs e)
        {
            categorySearchBar.Width = this.Width;
        }
        
        private void OnSeachBarTextChanged(object sender, string e)
        {
            if (e == "")
            {
                if (categoryType)
                {
                    pnlIncomeCategory.Show();
                    pnlExpenseCategory.Hide();
                    pnlIncomeCategory.Dock = DockStyle.Fill;
                    pnlIncomeCategory.BringToFront();
                    pnlExpenseCategory.Dock = DockStyle.Left;
                    pnlSearch.Hide();
                }
                else
                {
                    pnlIncomeCategory.Hide();
                    pnlExpenseCategory.Show();
                    pnlExpenseCategory.Dock = DockStyle.Fill;
                    pnlExpenseCategory.BringToFront();
                    pnlIncomeCategory.Dock = DockStyle.Right;
                    pnlSearch.Hide();
                }
            }
            else
            {
                pnlIncomeCategory.Hide();
                pnlExpenseCategory.Hide();
                pnlSearch.Show();
                pnlIncomeCategory.Dock = DockStyle.Right;
                pnlExpenseCategory.Dock = DockStyle.Left;
                pnlSearch.Dock = DockStyle.Fill;
                
                ShowCategory(e);
            }
        }

        #endregion

        #region AddCategory

        private void OnAddCategoryBtnClicked(object sender, EventArgs e)
        {
            if (!modifyCategory.Visible)
            {
                if (categoryType) pnlIncomeCategory.Hide();
                else pnlExpenseCategory.Hide();
                
                categorySearchBar.SearchBarShow = false;
                SearchBar?.Invoke(this, EventArgs.Empty);

                modifyCategory.GetData(new Category { Type = categoryType, WalletId= new List<int>() { 1} }, ModifyCategory.CategoryMode.AddMode);
                modifyCategory.Show();
                modifyCategory.BringToFront();
                modifyCategory.Location = new Point(((Width / 2) - (modifyCategory.Width / 2)), ((Height / 2) - (modifyCategory.Height / 2)));
                addMode = true;

                pnlSearch.Hide();
                if (categoryType) pnlIncomeCategory.Show();
                else pnlExpenseCategory.Show();
            }
        }

        #endregion

        #region Category Change

        private void OnCategoryClosed(object sender, EventArgs e)
        {
            modifyCategory.Hide();
            if (addMode) addMode = false;
        }
        
        private void OnCategoryChanged(object sender, Category e)
        {
            if (e.Type)
            {
                pnlIncomeCategory.Hide();
                GetTreeControls(e.Type);
                pnlIncomeCategory.Show();
                pnlExpenseCategory.Hide();
                pnlIncomeCategory.Dock = DockStyle.Fill;
                pnlIncomeCategory.BringToFront();
                pnlExpenseCategory.Dock = DockStyle.Left;
            }
            else
            {
                pnlExpenseCategory.Hide();
                GetTreeControls(e.Type);
                pnlIncomeCategory.Hide();
                pnlExpenseCategory.Show();
                pnlExpenseCategory.Dock = DockStyle.Fill;
                pnlExpenseCategory.BringToFront();
                pnlIncomeCategory.Dock = DockStyle.Right;
            }
            if (addMode) addMode = false;
            modifyCategory.Hide();
            categorySearchBar.SearchBarShow = false;
            SearchBar?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Wallet change

        private void OnWalletChanged(object sender, EventArgs e)
        {
            if (categoryType)
            {
                pnlIncomeCategory.Hide();
                GetTreeControls(true);
                pnlIncomeCategory.Show();
            }
            else
            {
                pnlExpenseCategory.Hide();
                GetTreeControls(false);
                pnlExpenseCategory.Show();
            }
        }

        #endregion

        #region Category Events

        private void OnBranchClicked(object sender, EventArgs e)
        {
            if (!addMode && !modifyCategory.deleteMode && !modifyCategory.Visible)
            {
                if (sender is Control control)
                {
                    Category category = Communicator.Manager.FetchCategoryName(int.Parse(control.Name));
                    if (EditMode)
                    {
                        modifyCategory.GetData(category, ModifyCategory.CategoryMode.EditMode);
                        modifyCategory.Location = new Point(((Width / 2) - (modifyCategory.Width / 2)), ((Height / 2) - (modifyCategory.Height / 2)));
                        modifyCategory.Show();
                        modifyCategory.BringToFront();
                    }
                    else CategorySelect?.Invoke(null, category);
                }
                
            }
        }
        
        private void OnBackBtnClicked(object sender, EventArgs e)
        {
            CategoryClose?.Invoke(this, EventArgs.Empty);
        }

        #endregion

    }
}
