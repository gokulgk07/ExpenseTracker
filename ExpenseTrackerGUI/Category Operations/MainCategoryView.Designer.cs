namespace ExpenseTrackerGUI
{
    partial class MainCategoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCategoryView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWalletName = new System.Windows.Forms.Label();
            this.pbWalletIamge = new System.Windows.Forms.PictureBox();
            this.mainCategoryViewSearch = new ExpenseTrackerGUI.CategorySearchBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tcCategory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWalletIamge)).BeginInit();
            this.tcCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.mainCategoryViewSearch);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblWalletName);
            this.panel5.Controls.Add(this.pbWalletIamge);
            this.panel5.Location = new System.Drawing.Point(1129, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 38);
            this.panel5.TabIndex = 6;
            // 
            // lblWalletName
            // 
            this.lblWalletName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWalletName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalletName.ForeColor = System.Drawing.Color.White;
            this.lblWalletName.Location = new System.Drawing.Point(36, 0);
            this.lblWalletName.Name = "lblWalletName";
            this.lblWalletName.Size = new System.Drawing.Size(84, 38);
            this.lblWalletName.TabIndex = 1;
            this.lblWalletName.Text = "  Total";
            this.lblWalletName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWalletName.Click += new System.EventHandler(this.OnWalletChangeClicked);
            // 
            // pbWalletIamge
            // 
            this.pbWalletIamge.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbWalletIamge.Image = ((System.Drawing.Image)(resources.GetObject("pbWalletIamge.Image")));
            this.pbWalletIamge.Location = new System.Drawing.Point(0, 0);
            this.pbWalletIamge.Name = "pbWalletIamge";
            this.pbWalletIamge.Size = new System.Drawing.Size(36, 38);
            this.pbWalletIamge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWalletIamge.TabIndex = 0;
            this.pbWalletIamge.TabStop = false;
            this.pbWalletIamge.Click += new System.EventHandler(this.OnWalletChangeClicked);
            // 
            // mainCategoryViewSearch
            // 
            this.mainCategoryViewSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.mainCategoryViewSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainCategoryViewSearch.Location = new System.Drawing.Point(1237, 0);
            this.mainCategoryViewSearch.Name = "mainCategoryViewSearch";
            this.mainCategoryViewSearch.SearchBarShow = false;
            this.mainCategoryViewSearch.Size = new System.Drawing.Size(63, 50);
            this.mainCategoryViewSearch.TabIndex = 5;
            this.mainCategoryViewSearch.SearchBackClick += new System.EventHandler(this.OnSearchBackClicked);
            this.mainCategoryViewSearch.SearchBarClick += new System.EventHandler(this.OnSearchBarClicked);
            this.mainCategoryViewSearch.TextChange += new System.EventHandler<string>(this.OnSearchBarTextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 40);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "My Categories";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 850);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1288, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 850);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(12, 888);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1276, 12);
            this.panel4.TabIndex = 3;
            // 
            // tcCategory
            // 
            this.tcCategory.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcCategory.Controls.Add(this.tabPage1);
            this.tcCategory.Controls.Add(this.tabPage2);
            this.tcCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCategory.ItemSize = new System.Drawing.Size(0, 1);
            this.tcCategory.Location = new System.Drawing.Point(12, 50);
            this.tcCategory.Name = "tcCategory";
            this.tcCategory.SelectedIndex = 0;
            this.tcCategory.Size = new System.Drawing.Size(1276, 838);
            this.tcCategory.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcCategory.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1268, 829);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1268, 829);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tcCategory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainCategoryView";
            this.Size = new System.Drawing.Size(1300, 900);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWalletIamge)).EndInit();
            this.tcCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle;
        private CategorySearchBar mainCategoryViewSearch;
        private System.Windows.Forms.TabControl tcCategory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWalletName;
        private System.Windows.Forms.PictureBox pbWalletIamge;
        //private CategoryView categoryView1;
    }
}
