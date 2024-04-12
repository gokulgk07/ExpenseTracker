namespace ExpenseTrackerGUI.Home
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(32, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 25);
            this.textBox1.TabIndex = 1;
            // 
            // searchPicture
            // 
            this.searchPicture.Image = ((System.Drawing.Image)(resources.GetObject("searchPicture.Image")));
            this.searchPicture.Location = new System.Drawing.Point(332, 5);
            this.searchPicture.Name = "searchPicture";
            this.searchPicture.Size = new System.Drawing.Size(35, 35);
            this.searchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPicture.TabIndex = 2;
            this.searchPicture.TabStop = false;
            this.searchPicture.MouseEnter += new System.EventHandler(this.searchPicture_MouseEnter);
            this.searchPicture.MouseLeave += new System.EventHandler(this.searchPicture_MouseLeave);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPicture);
            this.Controls.Add(this.textBox1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(380, 46);
            ((System.ComponentModel.ISupportInitialize)(this.searchPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox searchPicture;
    }
}
