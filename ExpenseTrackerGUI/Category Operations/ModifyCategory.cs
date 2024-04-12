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
using System.Drawing.Drawing2D;
using System.IO;

namespace ExpenseTrackerGUI
{
    public partial class ModifyCategory : UserControl
    {
        public ModifyCategory()
        {
            InitializeComponent();
            
            category = new Category();
            mergeCategory = new Category();
            temp = new Category();

            parentView = new ParentView();
            this.Controls.Add(parentView);
            parentView.ParentCategoryClose += OnParentCategoryClosed;
            parentView.ParentCategorySelect += OnParentCategorySelected;
            parentView.Hide();

            pnlMerge.Hide();

            GetSelectUI();
        }

        public event EventHandler CategoryClose;
        public event EventHandler<Category> CategoryChange;
        public event EventHandler WalletChange;

        private ParentView parentView;
        private Color backcolor = GUIStyles.backColor;
        private int borderWidth = 10;
        private CategoryMode categoryMode = CategoryMode.AddMode;
        private Category category, mergeCategory, temp;
        private bool mergeMode = false, validationCheck1= false, validationCheck2 = false;
        public bool deleteMode = false;
        private List<Wallet> wallets = new List<Wallet>();
        private List<WalletCard> walletCards = new List<WalletCard>();
        private List<PictureBox> selectImage = new List<PictureBox>();

        public Color ModifyCategoryBackColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public int BorderWidth
        {
            get => borderWidth;
            set
            {
                if (value < 0) return;
                borderWidth = value;
                pnlBottom.Height = pnlLeft.Width = pnlRight.Width = borderWidth;
            }
        } 
        
        public enum CategoryMode
        {
            AddMode,
            EditMode
        };

        #region GetData

        public void GetData(Category e, CategoryMode mode)
        {
            if (e == null) return;

            temp = category = e;
            categoryMode = mode;

            if (category.Type) lblType.Text = "Income";
            else lblType.Text = "Expense";

            if (mode == CategoryMode.AddMode)
            {
                BorderWidth = 10;
                Title = "Add Category";
                pbDelete.Hide();
                pnlWallet.Hide();
                this.Size = new Size(400, 370);
                btnSave.ButtonColor= Color.WhiteSmoke;
                btnSave.Show();

                pbImage.Image = ExpenseTrackerGUI.Properties.Resources.QuestionMark;
                category.WalletId = Communicator.Manager.FetchWallet().Select(i => i.WalletID).ToList();

                pnlWallet.Hide();
            }
            else if (mode == CategoryMode.EditMode)
            {
                BorderWidth = 5;
                Title = "Edit Category";
                pbDelete.Show();
                pnlWallet.Show();
                this.Size = new Size(400, 560);
                btnSave.Hide();
                pnlWallet.Show();

                pbImage.Image = Image.FromFile(e.ImagePath);
                tbCategoryName.Text = category.CategoryName;
                
                if (category.ParentId != 0) ChangeParentSelectUI(Communicator.Manager.FetchCategoryName(category.ParentId));
                else ChangeParentSelectUI(null);
                
                lblExist.Hide();

                validationCheck1 = validationCheck2 = true;
            }
        }

        #endregion

        #region ParentView

        private void OnParentViewClicked(object sender, EventArgs e)
        {
            parentView.Size = this.Size;
            parentView.BringToFront();
            parentView.Mode = (ExpenseTrackerGUI.ParentView.CategoryMode)categoryMode;
            parentView.ParentCategory = category;
            parentView.Type = category.Type;
            parentView.Show();
        }

        private void OnParentCancelBtnClicked(object sender, EventArgs e)
        {
            ChangeParentSelectUI(null);
        }

        private void OnParentCategorySelected(object sender, Category e)
        {
            if (e == null) return;

            if (mergeMode) mergeCategory = e;
            ChangeParentSelectUI(e);
            parentView.Hide();
        }

        private void OnParentCategoryClosed(object sender, EventArgs e)
        {
            parentView.Hide();
        }

        private void ChangeParentSelectUI(Category e)
        {
            if (e == null)
            {
                lblSelect.Show();
                lblParent.Show();
                pbRightArrow.Show();

                category.ParentId = 0;
                lblParentCategory.Text = "";
                lblParentCategory.Hide();
                pbCross.Hide();

                if (categoryMode == CategoryMode.AddMode)
                {
                    category.WalletId = Communicator.Manager.FetchWallet().Select(i => i.WalletID).ToList();
                }
                else if (categoryMode == CategoryMode.EditMode) category.WalletId = Communicator.Manager.FetchCategoryName(category.ID).WalletId;
                GetWallets();
            }
            else
            {
                if (mergeMode == true)
                {
                    lblSelectCategory.Hide();
                    secondCategory.BranchText = e.CategoryName;
                    secondCategory.Visible = true;

                    btnContinue.ButtonColor = GUIStyles.primaryColor;
                    btnContinue.ButtonForeColor = Color.White;
                    btnContinue.Enabled = true;
                }
                else
                {
                    lblSelect.Hide();
                    lblParent.Hide();
                    pbRightArrow.Hide();
                    category.ParentId = e.ID;
                    lblParentCategory.Text = e.CategoryName;
                    lblParentCategory.Show();
                    pbCross.Show();

                    if(categoryMode== CategoryMode.AddMode) category.WalletId = e.WalletId;
                    else if(categoryMode == CategoryMode.EditMode)
                    {
                        //bool check = false;
                        List<int> listOfId = new List<int>();
                        foreach(int id in category.WalletId)
                        {
                            if (e.WalletId.Contains(id))
                            {
                                //check = true;
                            }
                            else
                            {
                                listOfId.Add(id);
                            }
                        }
                        foreach (int id in listOfId) category.WalletId.Remove(id);
                        //if (check == false) category.WalletId = e.WalletId;
                    }
                    GetWallets();
                }
            }
        }

        #endregion

        #region Database Change

        private void OnSaveBtnClicked(object sender, EventArgs e)
        {
            category.CategoryName = tbCategoryName.Text;

            if (categoryMode == CategoryMode.AddMode)
            {
                Communicator.Manager.AddData(category);
            }
            else if (categoryMode == CategoryMode.EditMode)
            {
                Communicator.Manager.EditData(category);
            }

            if (temp.ParentId == 0)
            {
                parentView.GetBranches(category.Type);
            }

            CategoryChange?.Invoke(this, category);
            RebuildEditUI();
            Rebuild();
        }

        #endregion

        #region MergeCategory

        private void GetMergeUI()
        {
            if (temp == null) return;

            lblTitle.Text = "Merge Category";
            pbDelete.Hide();
            btnClose.Hide();
            pbLeft.Show();
            
            firstCategory.BranchText = temp.CategoryName;
            mergeMode = true;

            tcMerge.SelectedTab = tabPage1;
            pnlMerge.Dock = DockStyle.Fill;
            pnlMerge.BringToFront();
            pnlMerge.Show();

            this.Size = new Size(400, 560);
        }

        private void OnContinueBtnClicked(object sender, EventArgs e)
        {
            if (mergeCategory == null || finalCategory==null) return;
            finalCategory.BranchText = mergeCategory.CategoryName;
            CreateMergeTree(temp, mergeCategory);
            tcMerge.SelectedTab = tabPage2;
        }

        private void OnMergeBackClicked(object sender, EventArgs e)
        {
            if (tcMerge.SelectedTab == tabPage2)
            {
                tcMerge.SelectedTab = tabPage1;
            }
            else if (tcMerge.SelectedTab == tabPage1)
            {
                RebuildEditUI();
            }
            else if (tcMerge.SelectedTab == tabPage4)
            {
                GetWallets();
                RebuildEditUI();
            }
            else if (tcMerge.SelectedTab == tabPage5) CloseSelectIcon();
        }

        private void OnMergeClickTriggered(object sender, EventArgs e)
        {
            deleteMode = false;
            GetMergeUI();
        }

        private void OnMergeCategoryBtnClicked(object sender, EventArgs e)
        {
            Communicator.Manager.Merge(category.ID, mergeCategory.ID);
            CategoryChange(this, mergeCategory);
            RebuildEditUI();
            Rebuild();
        }

        private void CreateMergeTree(Category c1, Category c2)
        {
            int xPos1 = 10, xPos2 = 30, yPos = 10, branchSpace = 10, cnt = 0;

            if (c1 == null || c2 == null) return;

            pnlMergeShow.Controls.Clear();

            BranchControl branchControl = new BranchControl();
            branchControl.BranchText = c2.CategoryName;
            branchControl.Width = 200;
            branchControl.Location = new Point(xPos1, yPos);
            pnlMergeShow.Controls.Add(branchControl);
            yPos += (branchControl.Height + branchSpace);

            foreach (Category c in Communicator.Manager.FetchCategories(c1.ID))
            {
                BranchControl b = new BranchControl();
                b.BranchText = c.CategoryName;
                b.Width = 200;
                b.Location = new Point(xPos2, yPos);
                pnlMergeShow.Controls.Add(b);
                yPos += (branchControl.Height + branchSpace);
                cnt++;
            }

            foreach (Category c in Communicator.Manager.FetchCategories(c2.ID))
            {
                BranchControl b = new BranchControl();
                b.BranchText = c.CategoryName;
                b.Width = 200;
                b.Location = new Point(xPos2, yPos);
                pnlMergeShow.Controls.Add(b);
                yPos += (branchControl.Height + branchSpace);
                cnt++;
            }

            lblChildCnt.Text = $"{mergeCategory.CategoryName} will have {cnt} child category";
        }

        #endregion

        #region DeleteCategory

        private void OnDeleteCategory(object sender, EventArgs e)
        {
            if (category == null) return;
            Communicator.Manager.RemoveData(category);
            CategoryChange?.Invoke(this, category);

            if (category.ParentId == 0)
            {
                parentView.GetBranches(category.Type);
            }

            deleteMode = false;
            RebuildEditUI();
            Rebuild();
        }

        private void GetDeleteUI(bool hasTransaction, bool hasChild, int cnt, Category e)
        {
            if (e == null) return;
            if (hasTransaction == true && hasChild == true)
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = true;
                if (cnt == 1)
                {
                    lblText.Text = $"There is 1 transaction in the {e.CategoryName} category and childern categories.";
                }
                else
                {
                    lblText.Text = $"There are {cnt} transaction in the {e.CategoryName} category and childern categories.";
                }
                pnlDelete.Dock = DockStyle.Fill;
                this.Size = new Size(400, 315);
                btnDelete1.Hide();
            }
            else if (hasTransaction == true && hasChild == false)
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = true;
                if (cnt == 1)
                {
                    lblText.Text = $"There is 1 transaction in the {e.CategoryName} category.";
                }
                else
                {
                    lblText.Text = $"There are {cnt} transaction in the {e.CategoryName} category.";
                }
                pnlDelete.Dock = DockStyle.Fill;
                this.Size = new Size(400, 315);
                btnDelete1.Hide();
            }
            else if (hasTransaction == false && hasChild == true)
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = false;
                pnlDelete.Dock = DockStyle.Top;
                pnlDelete.Size = new Size(400, 186);
                this.Size = new Size(400, 273);
                btnDelete1.Show();
                lblText.Text = $"Are you sure you want to delete {e.CategoryName} category and children?";
            }
            else
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = false;
                pnlDelete.Dock = DockStyle.Top;
                pnlDelete.Size = new Size(400, 186);
                this.Size = new Size(400, 273);
                btnDelete1.Show();
                lblText.Text = $"Are you sure you want to delete {e.CategoryName} category?";
            }

            lblTitle.Text = "Delete Category";
            pbDelete.Hide();
            btnClose.Show();
            pbLeft.Hide();

            tcMerge.SelectedTab = tabPage3;
            pnlMerge.Dock = DockStyle.Fill;
            pnlMerge.BringToFront();
            pnlMerge.Show();
        }

        private void OnDeleteClickTriggered(object sender, EventArgs e)
        {
            bool b1 = false, b2 = false;
            int cnt = Communicator.Manager.HasTransaction(category);
            b2 = Communicator.Manager.HasChild(category);
            if (cnt > 0) b1 = true;
            GetDeleteUI(b1, b2, cnt, category);

            deleteMode = true;
        }

        #endregion
        
        #region WalletChange

        private void OnWalletEditClicked(object sender, EventArgs e)
        {
            tcMerge.SelectedTab = tabPage4;

            lblTitle.Text = "Edit Wallet";
            pbDelete.Hide();
            btnClose.Hide();
            pbLeft.Show();
            
            pnlMerge.Dock = DockStyle.Fill;
            pnlMerge.BringToFront();
            pnlMerge.Show();

            this.Size = new Size(400, 560);
        }

        private void OnToggleButtonStatusChanged(object sender, bool e)
        {
            ToggleButton btn = (ToggleButton)sender;
            int id = int.Parse(btn.Name);
            bool walletCheck = false;
            if (e)
            {
                if (!category.WalletId.Contains(id))
                {
                    
                    if (category.ParentId == 0)
                    {
                        foreach (Category c in Communicator.Manager.FetchCategories(category.ID))
                        {
                            if (!c.WalletId.Contains(id))
                            {
                                c.WalletId.Add(id);
                                Communicator.Manager.EditData(c);
                            }
                        }
                    }
                    else
                    {
                        Category c = Communicator.Manager.FetchParentCategories(category.ParentId);
                        if (c != null && !c.WalletId.Contains(id))
                        {
                            DialogResult dialogResult = MessageBox.Show($"This category belongs to {c.CategoryName}. Please Click OK to activate this wallet to {c.CategoryName} before activating this category.", "Wallet Activation", MessageBoxButtons.OKCancel);
                            if (dialogResult == DialogResult.OK)
                            {
                                c.WalletId.Add(id);
                                Communicator.Manager.EditData(c);
                            }
                            else
                            {
                                btn.ChangeStatus= false;
                                return;
                            }
                        }
                    }
                    category.WalletId.Add(id);
                    walletCheck = true;
                }
            }
            else
            {
                if (category.WalletId.Contains(id))
                {
                    category.WalletId.Remove(id);
                    walletCheck = true;

                    if (category.ParentId == 0)
                    {
                        foreach (Category c in Communicator.Manager.FetchCategories(category.ID))
                        {
                            if (c.WalletId.Contains(id))
                            {
                                c.WalletId.Remove(id);
                                Communicator.Manager.EditData(c);
                            }
                        }
                    }
                }
            }
            if (walletCheck == true)
            {
                Communicator.Manager.EditData(category);
                WalletChange?.Invoke(this, EventArgs.Empty);
            }
        }
        
        private void GetWallets()
        {
            int xPos = 5, yPos = 0, cardSpace= 5;

            if (category.WalletId == null) return;

            Wallet wallet = new Wallet();
            pnlWalletShow.Controls.Clear();
            
            foreach(int id in category.WalletId)
            {
                WalletCard card = new WalletCard();
                wallet = Communicator.Manager.FetchWallet(id);
                card.CardName = wallet.WalletName;
                card.CardBalance = wallet.Amount.ToString();

                pnlWalletShow.Controls.Add(card);
                card.Location = new Point(xPos, yPos);
                card.Width = pnlWalletShow.Width - 40;
                yPos += (card.Height + cardSpace);
            }

            if (category.WalletId.Count == 0)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(101, 13);
                pb.Size = new Size(80, 73);
                pb.Image = Image.FromFile(".\\Gif\\ExptyBoxGif.gif");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pnlWalletShow.Controls.Add(pb);

                lblWalletTitile.Text = "This category is inactive for all the wallets";
            }
            else lblWalletTitile.Text = "This category is active in following Wallets";
        }

        #endregion

        #region SelectIcon

        private void GetSelectUI()
        {
            string folderPath = @".\ResourceImages";
            List<string> imageFiles = GetImageFiles(folderPath);
            if (imageFiles == null) return;
            int xPos = 25, yPos = 5, space = 30;
            pnlSelectImage.Controls.Clear();
            selectImage.Clear();

            foreach (string file in imageFiles)
            {
                PictureBox pb = new PictureBox();
                pb.Name = file;
                pb.Size = new Size(50, 50);

                pb.Location = new Point(xPos, yPos);
                xPos += (pb.Width + space);
                if (xPos + pb.Width >= pnlSelectImage.Width)
                {
                    xPos = 25;
                    yPos += (pb.Height + space);
                }

                pb.Image = Image.FromFile(file);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BorderStyle = BorderStyle.FixedSingle;

                pnlSelectImage.Controls.Add(pb);
                selectImage.Add(pb);

                pb.Click += OnImageSelected;
                pb.MouseEnter += OnImageMouseEntered;
                pb.MouseLeave += OnImageMouseLeaved;
            }

        }

        private void ArrangeImages()
        {
            int xPos = 25, yPos = 5, space = 30;
            foreach(PictureBox pb in selectImage)
            {
                pb.Location = new Point(xPos, yPos);
                xPos += (pb.Width + space);
                if (xPos + pb.Width >= pnlSelectImage.Width)
                {
                    xPos = 25;
                    yPos += (pb.Height + space);
                }
            }
        }

        private void OnSelectIamgeClickTriggered(object sender, EventArgs e)
        {
            lblTitle.Text = "Select Icon";
            pbDelete.Hide();
            btnClose.Hide();
            pbLeft.Show();

            tcMerge.SelectedTab = tabPage5;
            pnlMerge.Dock = DockStyle.Fill;
            pnlMerge.BringToFront();
            pnlMerge.Show();

            ArrangeImages();
        }

        private void OnImageSelected(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pbImage.Image = Image.FromFile(pb.Name);
            category.ImagePath = pb.Name;

            if (categoryMode == CategoryMode.AddMode)
            {
                validationCheck2 = true;

                if (validationCheck1 && validationCheck2)
                {
                    btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = GUIStyles.primaryColor;
                    btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = true;
                }
                else
                {
                    btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = Color.WhiteSmoke;
                    btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = false;
                }
            }

            CloseSelectIcon();
        }

        private void CloseSelectIcon()
        {
            if (categoryMode == CategoryMode.EditMode)
            {
                btnDelete.Show();
                lblTitle.Text = "Edit Category";
            }
            else lblTitle.Text = "Add Category";

            pbLeft.Hide();
            btnClose.Show();

            pnlMerge.Width = 1;
            pnlMerge.Dock = DockStyle.Right;
            pnlMerge.Hide();
        }

        private List<string> GetImageFiles(string folderPath)
        {
            List<string> imageFiles = new List<string>();

            // Get all files in the current folder that have image extensions
            string[] files = Directory.GetFiles(folderPath)
                .Where(file => IsImageFile(file)).ToArray();

            imageFiles.AddRange(files);

            // Recursively search through subfolders
            string[] subDirectories = Directory.GetDirectories(folderPath);
            foreach (string subDir in subDirectories)
            {
                List<string> subDirImages = GetImageFiles(subDir);
                imageFiles.AddRange(subDirImages);
            }

            return imageFiles;
        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

            return imageExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }

        private void OnImageMouseLeaved(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Size = new Size(pb.Width - 4, pb.Height - 4);
        }

        private void OnImageMouseEntered(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Size = new Size(pb.Width + 4, pb.Height + 4);
        }

        #endregion

        #region Paint

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color borderColor = GUIStyles.primaryColor;

            base.OnPaint(e); base.OnPaint(e);
            int borderWidth = 5;
            int borderRadius = 10;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                this.DoubleBuffered = true;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath borderPath = CreateRoundedRectanglePath(new Rectangle(borderWidth / 2, borderWidth / 2, panel.Width - borderWidth, panel.Height - borderWidth), borderRadius);
                e.Graphics.DrawPath(borderPen, borderPath);
                e.Graphics.FillPath(new SolidBrush(backcolor), borderPath);
            }
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rectangle, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (cornerRadius == 0)
            {
                path.AddRectangle(rectangle);
                return path;
            }
            // Top left arc
            path.AddArc(arc, 180, 90);
            // Top right arc
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            // Bottom right arc
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // Bottom left arc
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        #endregion
        
        private void OnCancelClickTriggered(object sender, EventArgs e)
        {
            if (!deleteMode)
            {
                CategoryClose?.Invoke(this, EventArgs.Empty);
                Rebuild();
            }
            else
            {
                RebuildEditUI();
                deleteMode = false;
            }
        }

        private void OnTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                if (tbCategoryName.Text == "" || (tbCategoryName.Text.Length == 1 && e.KeyChar == 8))
                {
                    tbCategoryName.Text = "Category Name";
                    tbCategoryName.ForeColor = Color.Gray;

                    validationCheck1 = false;
                    //btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = Color.WhiteSmoke;
                    //btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = false;
                }
                else if (tbCategoryName.Text == "Category Name" && e.KeyChar != 8)
                {
                    tbCategoryName.Text = "";
                    tbCategoryName.ForeColor = Color.Black;

                    validationCheck1 = true;
                    //btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = GUIStyles.primaryColor;
                    //btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = true;
                }
                else if (tbCategoryName.Text == "Category Name" && e.KeyChar == 8)
                {
                    e.Handled = true;
                }
                else
                {
                    tbCategoryName.ForeColor = Color.Black;
                    validationCheck1 = true;
                }
            }
            else e.Handled = true;

            if (validationCheck1 == true && validationCheck2 == true)
            {
                btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = GUIStyles.primaryColor;
                btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = true;
            }
            else
            {
                btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = Color.WhiteSmoke;
                btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = false;
            }
        }

        private void OnMouseEntered(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.Size = new Size(control.Width + 4, control.Height + 4);
            backcolor = GUIStyles.terenaryColor;
            control.Invalidate();
        }

        private void OnMouseLeaved(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.Size = new Size(control.Width - 4, control.Height - 4);
            backcolor = GUIStyles.backColor;
            control.Invalidate();
        }

        private void Rebuild()
        {
            tbCategoryName.Text = "Category Name";
            tbCategoryName.ForeColor = Color.Gray;
            btnSave.ButtonColor = Color.WhiteSmoke;
            btnSave.Enabled = false;

            lblParentCategory.Text = "";
            lblParentCategory.Hide();
            pbCross.Hide();

            lblSelect.Show();
            lblParent.Show();
            pbRightArrow.Show();

        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (categoryMode == CategoryMode.AddMode)
            {
                if (Communicator.Manager.IsCategory(tbCategoryName.Text))
                {
                    lblExist.Text = "This category already exists";
                    lblExist.Show();
                    validationCheck1 = false;
                    btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = Color.WhiteSmoke;
                    btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = false;
                }
                else if (tbCategoryName.Text == "")
                {
                    lblExist.Text = "Empty string unable to add";
                    lblExist.Show();
                }
                else
                {
                    lblExist.Hide();
                    if (validationCheck1 && validationCheck2)
                    {
                        btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = GUIStyles.primaryColor;
                        btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = true;
                    }
                }
            }
            else
            {
                if (temp.CategoryName != tbCategoryName.Text && Communicator.Manager.IsCategory(tbCategoryName.Text))
                {
                    lblExist.Text = "This category already exists";
                    lblExist.Show();
                    validationCheck1 = false;
                    btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = Color.WhiteSmoke;
                    btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = false;
                }
                else if (tbCategoryName.Text == "")
                {
                    lblExist.Text = "Empty string unable  to add";
                    lblExist.Show();
                }
                else
                {
                    lblExist.Hide();
                    if (validationCheck1 && validationCheck2)
                    {
                        btnEdit.ButtonColor = btnSave.ButtonColor = btnMerge.ButtonColor = GUIStyles.primaryColor;
                        btnEdit.Enabled = btnSave.Enabled = btnMerge.Enabled = true;
                    }
                }
            }
        }

        private void RebuildEditUI()
        {
            lblTitle.Text = "Edit Category";
            pbDelete.Show();
            btnClose.Show();
            pbLeft.Hide();

            firstCategory.BranchText = "";
            mergeCategory = null;
            secondCategory.Hide();
            lblSelectCategory.Show();
            mergeMode = false;

            deleteMode = false;

            pnlMerge.Dock = DockStyle.Right;
            pnlMerge.Width = 1;
            pnlMerge.Hide();
            this.Size = new Size(400, 560);

            btnContinue.ButtonColor = Color.WhiteSmoke;
            btnContinue.Enabled = false;

            validationCheck1 = validationCheck2 = false;
        }

        private void OnVisibilityChanged(object sender, EventArgs e)
        {
            int xPos = 20, yPos = 20, cardSpace = 20;
            if (pnlWalletEdit.Visible)
            {
                foreach (WalletCard card in walletCards) card.Dispose();

                wallets.Clear();
                walletCards.Clear();
                pnlWalletEdit.Controls.Clear();

                wallets = Communicator.Manager.FetchWallet();
                foreach (Wallet w in wallets)
                {
                    WalletCard card = new WalletCard();
                    card.CardName = w.WalletName;
                    card.CardBalance = w.Amount.ToString();
                    card.Name = w.WalletID.ToString();

                    ToggleButton toggleButton = new ToggleButton();
                    toggleButton.Name = w.WalletID.ToString();

                    card.Controls.Add(toggleButton);
                    toggleButton.BringToFront();

                    toggleButton.Location = new Point((card.Width - (toggleButton.Width + 20)), ((card.Height / 2) - (toggleButton.Height / 2)));

                    toggleButton.StatusChange += OnToggleButtonStatusChanged;

                    if (category.WalletId.Contains(w.WalletID)) toggleButton.ChangeStatus = true;
                    else toggleButton.ChangeStatus = false;

                    //if (w.WalletID == 1)
                    //{
                    //    toggleButton.ChangeStatus = true;
                    //    toggleButton.EditMode = false;
                    //}
                    //else
                    //{
                    //    if (category.WalletId.Contains(w.WalletID)) toggleButton.ChangeStatus = true;
                    //    else toggleButton.ChangeStatus = false;
                    //}

                    pnlWalletEdit.Controls.Add(card);
                    card.Location = new Point(xPos, yPos);
                    yPos += (card.Height + cardSpace);
                }
            }
        }
    }
}
