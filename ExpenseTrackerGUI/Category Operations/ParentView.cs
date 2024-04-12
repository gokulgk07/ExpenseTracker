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
    public partial class ParentView : UserControl
    {
        public ParentView()
        {
            InitializeComponent();
        }
        
        public event EventHandler ParentCategoryClose;
        public event EventHandler<Category> ParentCategorySelect;

        private bool type = false;
        private CategoryMode mode = CategoryMode.AddMode;
        private Category parentCategory = new Category();
        private List<BranchControl> expenseBranch = new List<BranchControl>();
        private List<BranchControl> incomeBranch = new List<BranchControl>();
        private List<Category> data = new List<Category>();
        
        public bool Type
        {
            get => type;
            set
            {
                type = value;
                ShowCategory();
                if (type == false)
                {
                    pnlExpense.Show();
                    pnlExpense.Dock = DockStyle.Fill;
                    pnlExpense.BringToFront();
                    pnlIncome.Hide();
                    pnlIncome.Dock = DockStyle.Left;
                }
                else
                {
                    pnlExpense.Dock = DockStyle.Right;
                    pnlExpense.Hide();
                    pnlIncome.Dock = DockStyle.Fill;
                    pnlIncome.BringToFront();
                    pnlIncome.Show();
                }
            }
        }

        public CategoryMode Mode
        {
            get => mode;
            set
            {
                mode = value;
            }
        }

        public Category ParentCategory
        {
            get => parentCategory;
            set
            {
                if (value == null) return;
                parentCategory = value;
            }
        }

        public enum CategoryMode
        {
            AddMode,
            EditMode
        };

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            GetBranches(true);
            GetBranches(false);
            ShowCategory();
            if (type == false)
            {
                pnlExpense.Show();
                pnlExpense.Dock = DockStyle.Fill;
                pnlExpense.BringToFront();
                pnlIncome.Hide();
                pnlIncome.Dock = DockStyle.Left;
            }
            else
            {
                pnlExpense.Dock = DockStyle.Right;
                pnlExpense.Hide();
                pnlIncome.Dock = DockStyle.Fill;
                pnlIncome.BringToFront();
                pnlIncome.Show();
            }
        }
        
        public void GetBranches(bool b)
        {
            data.Clear();
            data = Communicator.Manager.FetchParentCategories();
            if (data==null ||data.Count == 0) return;
            List<Category> list = data.Where(c => c.Type == b).ToList();
            if (list == null || list.Count == 0) return;
            if (b)
            {
                foreach(BranchControl branch in incomeBranch)
                {
                    branch.Click -= OnBranchClicked;
                    branch.Dispose();
                }
                incomeBranch.Clear();
                pnlIncome.Controls.Clear();

                int xPos = 25, yPos = 20, branchSpace = 10;
                foreach (Category category in list)
                {
                    BranchControl branchControl = new BranchControl();
                    branchControl.Name = category.ID.ToString();
                    branchControl.BranchText = category.CategoryName;

                    branchControl.Click += OnBranchClicked;

                    pnlIncome.Controls.Add(branchControl);
                    branchControl.Width = this.Width - 75;
                    branchControl.Location = new Point(xPos, yPos);
                    yPos += (branchControl.Height + branchSpace);

                    incomeBranch.Add(branchControl);
                }
                
            }
            else
            {
                foreach (BranchControl branch in expenseBranch)
                {
                    branch.Click -= OnBranchClicked;
                    branch.Dispose();
                }
                expenseBranch.Clear();
                pnlExpense.Controls.Clear();
                int xPos = 25, yPos = 20, branchSpace = 10;
                foreach (Category category in list)
                {
                    BranchControl branchControl = new BranchControl();
                    branchControl.Name = category.ID.ToString();
                    branchControl.BranchText = category.CategoryName;

                    branchControl.Click += OnBranchClicked;

                    pnlExpense.Controls.Add(branchControl);
                    branchControl.Width = this.Width - 75;
                    branchControl.Location = new Point(xPos, yPos);
                    yPos += (branchControl.Height + branchSpace);

                    expenseBranch.Add(branchControl);
                }
            }
            
        }

        private void ShowCategory()
        {
            int xPos = 25, yPos = 20, branchSpace = 10, id=0;

            if (Type)
            {
                pnlIncome.VerticalScroll.Value = 0;
                if(Mode == CategoryMode.AddMode)
                {
                    foreach (BranchControl b in pnlIncome.Controls)
                    {
                        b.Visible = true;
                        b.Location = new Point(xPos, yPos);
                        yPos += (b.Height + branchSpace);
                    }
                }
                else
                {
                    foreach (BranchControl b in pnlIncome.Controls)
                    {
                        id = int.Parse(b.Name);
                        if (ParentCategory != null && id == ParentCategory.ID) b.Visible = false;
                        else
                        {
                            b.Visible = true;
                            b.Location = new Point(xPos, yPos);
                            yPos += (b.Height + branchSpace);
                        }
                    }
                }
            }
            else
            {
                pnlExpense.VerticalScroll.Value = 0;
                if (Mode == CategoryMode.AddMode)
                {
                    foreach (BranchControl b in pnlExpense.Controls)
                    {
                        b.Visible = true;
                        b.Location = new Point(xPos, yPos);
                        yPos += (b.Height + branchSpace);
                    }
                }
                else
                {
                    foreach (BranchControl b in pnlExpense.Controls)
                    {
                        id = int.Parse(b.Name);
                        if (ParentCategory != null && id == ParentCategory.ID) b.Visible = false;
                        else
                        {
                            b.Visible = true;
                            b.Location = new Point(xPos, yPos);
                            yPos += (b.Height + branchSpace);
                        }
                    }
                }
            }
            
        }

        private void OnBranchClicked(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                ParentCategorySelect?.Invoke(null, Communicator.Manager.FetchCategoryName(int.Parse(control.Name)));
            }
        }

        private void OnBackBtnClicked(object sender, EventArgs e)
        {
            ParentCategoryClose?.Invoke(this, EventArgs.Empty);
        }

        private void OnSearchBarClicked(object sender, EventArgs e)
        {
            parentSearchBar.Width = this.Width;
        }

        private void OnSearchBackClicked(object sender, EventArgs e)
        {
            parentSearchBar.Width = 50;
            ShowCategory();
        }

        private void OnVisibilityChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                GetBranches(true);
                GetBranches(false);
                ShowCategory();
            }
        }

        private void OnSearchBarTextChanged(object sender, string e)
        {
            if (e == "")
            {
                ShowCategory();
            }
            else
            {
                List<Category> list = Communicator.Manager.FetchCategories(e);
                ShowCategory(list);
            }
        }

        private void ShowCategory(List<Category> list)
        {
            int xPos = 25, yPos = 20, branchSpace = 10, id = 0;

            if (list == null || list.Count == 0) return;

            list = list.FindAll(i => i.Type == Type).ToList();

            List<int> listOfId = list.Select(i => i.ID).ToList();
            if (listOfId == null) return;

            if (Type)
            {
                pnlIncome.VerticalScroll.Value = 0;
                
                foreach (BranchControl b in pnlIncome.Controls)
                {
                    id = int.Parse(b.Name);
                    if (!listOfId.Contains(id)) b.Visible = false;
                    else
                    {
                        b.Visible = true;
                        b.Location = new Point(xPos, yPos);
                        yPos += (b.Height + branchSpace);
                    }
                }
            }
            else
            {
                pnlExpense.VerticalScroll.Value = 0;

                foreach (BranchControl b in pnlExpense.Controls)
                {
                    id = int.Parse(b.Name);
                    if (!listOfId.Contains(id)) b.Visible = false;
                    else
                    {
                        b.Visible = true;
                        b.Location = new Point(xPos, yPos);
                        yPos += (b.Height + branchSpace);
                    }
                }
            }

        }
    }
}
