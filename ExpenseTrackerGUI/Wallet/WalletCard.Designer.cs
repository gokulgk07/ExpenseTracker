namespace ExpenseTrackerGUI
{
    partial class WalletCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalletCard));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(14, 9);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(47, 45);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.OnCardClicked);
            this.pbImage.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.pbImage.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(84, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(220, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Total";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.OnCardClicked);
            this.lblName.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.lblName.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(95, 31);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(166, 27);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "10000";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmount.Click += new System.EventHandler(this.OnCardClicked);
            this.lblAmount.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.lblAmount.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "₹";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WalletCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAmount);
            this.Name = "WalletCard";
            this.Size = new System.Drawing.Size(320, 70);
            this.MouseEnter += new System.EventHandler(this.OnMouseEntered);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeaved);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label1;
    }
}
