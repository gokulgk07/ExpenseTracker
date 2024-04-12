namespace ExpenseTrackerGUI
{
    partial class SelectWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectWallet));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddWallet = new System.Windows.Forms.Panel();
            this.lblAddWallet = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlAddWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlAddWallet, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlShow, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 523);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pnlAddWallet
            // 
            this.pnlAddWallet.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddWallet.Controls.Add(this.lblAddWallet);
            this.pnlAddWallet.Controls.Add(this.pbAdd);
            this.pnlAddWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddWallet.Location = new System.Drawing.Point(23, 23);
            this.pnlAddWallet.Name = "pnlAddWallet";
            this.pnlAddWallet.Size = new System.Drawing.Size(435, 44);
            this.pnlAddWallet.TabIndex = 8;
            // 
            // lblAddWallet
            // 
            this.lblAddWallet.BackColor = System.Drawing.Color.White;
            this.lblAddWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddWallet.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.lblAddWallet.Location = new System.Drawing.Point(49, 0);
            this.lblAddWallet.Name = "lblAddWallet";
            this.lblAddWallet.Size = new System.Drawing.Size(386, 44);
            this.lblAddWallet.TabIndex = 11;
            this.lblAddWallet.Text = "  Add Wallet";
            this.lblAddWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddWallet.Click += new System.EventHandler(this.OnAddWalletClickTriggered);
            this.lblAddWallet.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.lblAddWallet.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.White;
            this.pbAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(0, 0);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(49, 44);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 10;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.OnAddWalletClickTriggered);
            this.pbAdd.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.pbAdd.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // pnlShow
            // 
            this.pnlShow.AutoScroll = true;
            this.pnlShow.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(23, 93);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(435, 407);
            this.pnlShow.TabIndex = 9;
            // 
            // SelectWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectWallet";
            this.Size = new System.Drawing.Size(481, 523);
            this.VisibleChanged += new System.EventHandler(this.OnVisibilityChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlAddWallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlAddWallet;
        private System.Windows.Forms.Label lblAddWallet;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Panel pnlShow;
    }
}
