namespace ExpenseTrackerGUI
{
    partial class ChangeWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeWallet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tpnlTotal = new System.Windows.Forms.TableLayoutPanel();
            this.totalWallet = new ExpenseTrackerGUI.WalletCard();
            this.selectWallet1 = new ExpenseTrackerGUI.SelectWallet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.tpnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 50);
            this.panel1.TabIndex = 2;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(11, 13);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 25);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.OnBackBtnClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(49, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 40);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Select Wallet";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(509, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 487);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 487);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(12, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 12);
            this.panel4.TabIndex = 6;
            // 
            // tpnlTotal
            // 
            this.tpnlTotal.ColumnCount = 3;
            this.tpnlTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTotal.Controls.Add(this.totalWallet, 1, 1);
            this.tpnlTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlTotal.Location = new System.Drawing.Point(12, 50);
            this.tpnlTotal.Name = "tpnlTotal";
            this.tpnlTotal.RowCount = 3;
            this.tpnlTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnlTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tpnlTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnlTotal.Size = new System.Drawing.Size(497, 100);
            this.tpnlTotal.TabIndex = 8;
            // 
            // totalWallet
            // 
            this.totalWallet.BackColor = System.Drawing.Color.White;
            this.totalWallet.CardBackColor = System.Drawing.Color.White;
            this.totalWallet.CardBalance = "10000";
            this.totalWallet.CardName = "Total";
            this.totalWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalWallet.IsWallet = false;
            this.totalWallet.Location = new System.Drawing.Point(23, 33);
            this.totalWallet.Name = "totalWallet";
            this.totalWallet.Radius = 20;
            this.totalWallet.Size = new System.Drawing.Size(451, 64);
            this.totalWallet.TabIndex = 0;
            this.totalWallet.Click += new System.EventHandler(this.OnTotalClicked);
            // 
            // selectWallet1
            // 
            this.selectWallet1.AddMode = true;
            this.selectWallet1.BackColor = System.Drawing.Color.GhostWhite;
            this.selectWallet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectWallet1.EditMode = false;
            this.selectWallet1.Location = new System.Drawing.Point(12, 150);
            this.selectWallet1.Name = "selectWallet1";
            this.selectWallet1.Radius = 10;
            this.selectWallet1.Size = new System.Drawing.Size(497, 375);
            this.selectWallet1.TabIndex = 9;
            this.selectWallet1.WalletSelect += new System.EventHandler<ExpenseTrackerDS.Wallet>(this.OnWalletSelected);
            // 
            // ChangeWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.selectWallet1);
            this.Controls.Add(this.tpnlTotal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeWallet";
            this.Size = new System.Drawing.Size(521, 537);
            this.VisibleChanged += new System.EventHandler(this.OnVisibilityChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.tpnlTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tpnlTotal;
        private SelectWallet selectWallet1;
        private WalletCard totalWallet;
    }
}
