namespace ExpenseTrackerGUI
{
    partial class CategorySearchBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorySearchBar));
            this.tbText = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tblBack = new System.Windows.Forms.TableLayoutPanel();
            this.tblText = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.tblSearch.SuspendLayout();
            this.tblBack.SuspendLayout();
            this.tblText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.ForeColor = System.Drawing.Color.White;
            this.tbText.Location = new System.Drawing.Point(3, 12);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(230, 34);
            this.tbText.TabIndex = 1;
            this.tbText.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // pbSearch
            // 
            this.pbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(10, 10);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(28, 28);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 2;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.OnSearchBarClicked);
            // 
            // pbBack
            // 
            this.pbBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(9, 10);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(25, 28);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 0;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.OnBackClicked);
            // 
            // tblSearch
            // 
            this.tblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.tblSearch.ColumnCount = 3;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblSearch.Controls.Add(this.pbSearch, 1, 1);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.tblSearch.Location = new System.Drawing.Point(281, 0);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 3;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblSearch.Size = new System.Drawing.Size(49, 49);
            this.tblSearch.TabIndex = 3;
            this.tblSearch.Click += new System.EventHandler(this.OnSearchBarClicked);
            // 
            // tblBack
            // 
            this.tblBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.tblBack.ColumnCount = 3;
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblBack.Controls.Add(this.pbBack, 1, 1);
            this.tblBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblBack.Location = new System.Drawing.Point(0, 0);
            this.tblBack.Name = "tblBack";
            this.tblBack.RowCount = 3;
            this.tblBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblBack.Size = new System.Drawing.Size(45, 49);
            this.tblBack.TabIndex = 4;
            this.tblBack.Click += new System.EventHandler(this.OnBackClicked);
            // 
            // tblText
            // 
            this.tblText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.tblText.ColumnCount = 1;
            this.tblText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblText.Controls.Add(this.tbText, 0, 1);
            this.tblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblText.Location = new System.Drawing.Point(45, 0);
            this.tblText.Name = "tblText";
            this.tblText.RowCount = 2;
            this.tblText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblText.Size = new System.Drawing.Size(236, 49);
            this.tblText.TabIndex = 5;
            // 
            // CategorySearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.tblText);
            this.Controls.Add(this.tblBack);
            this.Controls.Add(this.tblSearch);
            this.Name = "CategorySearchBar";
            this.Size = new System.Drawing.Size(330, 49);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.tblSearch.ResumeLayout(false);
            this.tblBack.ResumeLayout(false);
            this.tblText.ResumeLayout(false);
            this.tblText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TableLayoutPanel tblSearch;
        private System.Windows.Forms.TableLayoutPanel tblBack;
        private System.Windows.Forms.TableLayoutPanel tblText;
    }
}
