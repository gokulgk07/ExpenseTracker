namespace ExpenseTrackerGUI
{
    partial class SingleWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleWallet));
            this.pwalletmid1 = new System.Windows.Forms.Panel();
            this.walletpb = new System.Windows.Forms.PictureBox();
            this.pwalletmid = new System.Windows.Forms.Panel();
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.walletpb)).BeginInit();
            this.SuspendLayout();
            // 
            // pwalletmid1
            // 
            this.pwalletmid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pwalletmid1.Location = new System.Drawing.Point(0, 0);
            this.pwalletmid1.Name = "pwalletmid1";
            this.pwalletmid1.Size = new System.Drawing.Size(13, 26);
            this.pwalletmid1.TabIndex = 10;
            this.pwalletmid1.Click += new System.EventHandler(this.OnClicked);
            this.pwalletmid1.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.pwalletmid1.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // walletpb
            // 
            this.walletpb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("walletpb.BackgroundImage")));
            this.walletpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.walletpb.Dock = System.Windows.Forms.DockStyle.Left;
            this.walletpb.Location = new System.Drawing.Point(13, 0);
            this.walletpb.Name = "walletpb";
            this.walletpb.Size = new System.Drawing.Size(35, 26);
            this.walletpb.TabIndex = 11;
            this.walletpb.TabStop = false;
            this.walletpb.Click += new System.EventHandler(this.OnClicked);
            this.walletpb.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.walletpb.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // pwalletmid
            // 
            this.pwalletmid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pwalletmid.Location = new System.Drawing.Point(48, 0);
            this.pwalletmid.Name = "pwalletmid";
            this.pwalletmid.Size = new System.Drawing.Size(13, 26);
            this.pwalletmid.TabIndex = 12;
            this.pwalletmid.Click += new System.EventHandler(this.OnClicked);
            this.pwalletmid.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.pwalletmid.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // nameLbl
            // 
            this.nameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(61, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(137, 26);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Total";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLbl.Click += new System.EventHandler(this.OnClicked);
            this.nameLbl.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.nameLbl.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // SingleWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.pwalletmid);
            this.Controls.Add(this.walletpb);
            this.Controls.Add(this.pwalletmid1);
            this.Name = "SingleWallet";
            this.Size = new System.Drawing.Size(198, 26);
            this.Click += new System.EventHandler(this.OnClicked);
            ((System.ComponentModel.ISupportInitialize)(this.walletpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pwalletmid1;
        private System.Windows.Forms.PictureBox walletpb;
        private System.Windows.Forms.Panel pwalletmid;
        private System.Windows.Forms.Label nameLbl;
    }
}
