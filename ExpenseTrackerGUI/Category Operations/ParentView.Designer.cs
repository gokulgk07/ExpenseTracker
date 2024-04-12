namespace ExpenseTrackerGUI
{
    partial class ParentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentView));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.parentSearchBar = new ExpenseTrackerGUI.CategorySearchBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.pnlExpense = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlTop.Controls.Add(this.parentSearchBar);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pbBack);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(400, 45);
            this.pnlTop.TabIndex = 4;
            // 
            // parentSearchBar
            // 
            this.parentSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.parentSearchBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.parentSearchBar.Location = new System.Drawing.Point(355, 0);
            this.parentSearchBar.Name = "parentSearchBar";
            this.parentSearchBar.Size = new System.Drawing.Size(45, 45);
            this.parentSearchBar.TabIndex = 2;
            this.parentSearchBar.SearchBackClick += new System.EventHandler(this.OnSearchBackClicked);
            this.parentSearchBar.SearchBarClick += new System.EventHandler(this.OnSearchBarClicked);
            this.parentSearchBar.TextChange += new System.EventHandler<string>(this.OnSearchBarTextChanged);
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
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 45);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 544);
            this.pnlLeft.TabIndex = 5;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(390, 45);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 544);
            this.pnlRight.TabIndex = 6;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 579);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(380, 10);
            this.pnlBottom.TabIndex = 7;
            // 
            // pnlIncome
            // 
            this.pnlIncome.AutoScroll = true;
            this.pnlIncome.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIncome.Location = new System.Drawing.Point(10, 45);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(170, 516);
            this.pnlIncome.TabIndex = 8;
            // 
            // pnlExpense
            // 
            this.pnlExpense.AutoScroll = true;
            this.pnlExpense.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExpense.Location = new System.Drawing.Point(216, 45);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(174, 516);
            this.pnlExpense.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 18);
            this.panel1.TabIndex = 9;
            // 
            // ParentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.pnlExpense);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "ParentView";
            this.Size = new System.Drawing.Size(400, 589);
            this.VisibleChanged += new System.EventHandler(this.OnVisibilityChanged);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBack;
        public System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.Panel pnlRight;
        public System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlExpense;
        private CategorySearchBar parentSearchBar;
    }
}
