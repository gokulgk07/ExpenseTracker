namespace ExpenseTrackerGUI
{
    partial class CategoryView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryView));
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.pnlExpenseCategory = new System.Windows.Forms.Panel();
            this.pnlIncomeCategory = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.categorySearchBar = new ExpenseTrackerGUI.CategorySearchBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblLine = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.pnlExpense = new System.Windows.Forms.Panel();
            this.tblType = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLine.SuspendLayout();
            this.tblType.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BackColor = System.Drawing.Color.White;
            this.lblIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIncome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.Black;
            this.lblIncome.Location = new System.Drawing.Point(208, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(199, 39);
            this.lblIncome.TabIndex = 3;
            this.lblIncome.Text = "Income";
            this.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIncome.Click += new System.EventHandler(this.OnIncomeBtnClicked);
            this.lblIncome.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.lblIncome.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.BackColor = System.Drawing.Color.White;
            this.lblExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpense.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.Black;
            this.lblExpense.Location = new System.Drawing.Point(3, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(199, 39);
            this.lblExpense.TabIndex = 2;
            this.lblExpense.Text = "Expense";
            this.lblExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExpense.Click += new System.EventHandler(this.OnExpenseButtonClicked);
            this.lblExpense.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.lblExpense.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // pnlExpenseCategory
            // 
            this.pnlExpenseCategory.AutoScroll = true;
            this.pnlExpenseCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlExpenseCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExpenseCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlExpenseCategory.Name = "pnlExpenseCategory";
            this.pnlExpenseCategory.Size = new System.Drawing.Size(127, 449);
            this.pnlExpenseCategory.TabIndex = 2;
            // 
            // pnlIncomeCategory
            // 
            this.pnlIncomeCategory.AutoScroll = true;
            this.pnlIncomeCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlIncomeCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIncomeCategory.Location = new System.Drawing.Point(279, 0);
            this.pnlIncomeCategory.Name = "pnlIncomeCategory";
            this.pnlIncomeCategory.Size = new System.Drawing.Size(131, 449);
            this.pnlIncomeCategory.TabIndex = 3;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlTop.Controls.Add(this.categorySearchBar);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pbBack);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(470, 50);
            this.pnlTop.TabIndex = 3;
            // 
            // categorySearchBar
            // 
            this.categorySearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.categorySearchBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.categorySearchBar.Location = new System.Drawing.Point(398, 0);
            this.categorySearchBar.Name = "categorySearchBar";
            this.categorySearchBar.SearchBarShow = false;
            this.categorySearchBar.Size = new System.Drawing.Size(72, 50);
            this.categorySearchBar.TabIndex = 2;
            this.categorySearchBar.SearchBackClick += new System.EventHandler(this.OnSearchBackClicked);
            this.categorySearchBar.SearchBarClick += new System.EventHandler(this.OnSearchBarClicked);
            this.categorySearchBar.TextChange += new System.EventHandler<string>(this.OnSeachBarTextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(10, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 25);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 0;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.OnBackBtnClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnBackBtnClicked);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(12, 602);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(458, 50);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(12, 602);
            this.pnlRight.TabIndex = 5;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(12, 640);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(446, 12);
            this.pnlBottom.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tblLine, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tblType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlCategory, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 590);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tblLine
            // 
            this.tblLine.ColumnCount = 2;
            this.tblLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLine.Controls.Add(this.pnlIncome, 1, 0);
            this.tblLine.Controls.Add(this.pnlExpense, 0, 0);
            this.tblLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLine.Location = new System.Drawing.Point(13, 58);
            this.tblLine.Name = "tblLine";
            this.tblLine.RowCount = 1;
            this.tblLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLine.Size = new System.Drawing.Size(410, 9);
            this.tblLine.TabIndex = 0;
            // 
            // pnlIncome
            // 
            this.pnlIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIncome.Location = new System.Drawing.Point(208, 3);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(199, 3);
            this.pnlIncome.TabIndex = 1;
            // 
            // pnlExpense
            // 
            this.pnlExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExpense.Location = new System.Drawing.Point(3, 3);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(199, 3);
            this.pnlExpense.TabIndex = 0;
            // 
            // tblType
            // 
            this.tblType.ColumnCount = 2;
            this.tblType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblType.Controls.Add(this.lblExpense, 0, 0);
            this.tblType.Controls.Add(this.lblIncome, 1, 0);
            this.tblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblType.Location = new System.Drawing.Point(13, 13);
            this.tblType.Name = "tblType";
            this.tblType.RowCount = 1;
            this.tblType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblType.Size = new System.Drawing.Size(410, 39);
            this.tblType.TabIndex = 8;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.lblAddCategory);
            this.pnlAdd.Controls.Add(this.pictureBox2);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd.Location = new System.Drawing.Point(13, 78);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(410, 34);
            this.pnlAdd.TabIndex = 1;
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.BackColor = System.Drawing.Color.White;
            this.lblAddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddCategory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.lblAddCategory.Location = new System.Drawing.Point(32, 0);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(378, 34);
            this.lblAddCategory.TabIndex = 0;
            this.lblAddCategory.Text = "  Add Category";
            this.lblAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddCategory.Click += new System.EventHandler(this.OnAddCategoryBtnClicked);
            this.lblAddCategory.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.lblAddCategory.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.OnAddCategoryBtnClicked);
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.pnlExpenseCategory);
            this.pnlCategory.Controls.Add(this.pnlSearch);
            this.pnlCategory.Controls.Add(this.pnlIncomeCategory);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(13, 128);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(410, 449);
            this.pnlCategory.TabIndex = 9;
            // 
            // pnlSearch
            // 
            this.pnlSearch.AutoScroll = true;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSearch.Location = new System.Drawing.Point(212, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(67, 449);
            this.pnlSearch.TabIndex = 4;
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "CategoryView";
            this.Size = new System.Drawing.Size(470, 652);
            this.VisibleChanged += new System.EventHandler(this.OnVisibilityChanged);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblLine.ResumeLayout(false);
            this.tblType.ResumeLayout(false);
            this.tblType.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Panel pnlExpenseCategory;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Panel pnlExpense;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TableLayoutPanel tblType;
        public System.Windows.Forms.TableLayoutPanel tblLine;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.Panel pnlRight;
        public System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBack;
        //private CategorySearchBar categorySearchBar1;
        public System.Windows.Forms.Panel pnlAdd;
        private CategorySearchBar categorySearchBar;
        private System.Windows.Forms.Panel pnlIncomeCategory;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Panel pnlSearch;
        //private CategorySearchBar categorySearchBar;
    }
}
