namespace ExpenseTrackerGUI.Rating
{
    partial class Rating
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
            this.star1 = new System.Windows.Forms.Panel();
            this.star2 = new System.Windows.Forms.Panel();
            this.star3 = new System.Windows.Forms.Panel();
            this.star4 = new System.Windows.Forms.Panel();
            this.star5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Location = new System.Drawing.Point(10, 10);
            this.star1.Margin = new System.Windows.Forms.Padding(10);
            this.star1.Name = "star1";
            this.star1.Padding = new System.Windows.Forms.Padding(10);
            this.star1.Size = new System.Drawing.Size(70, 70);
            this.star1.TabIndex = 1;
            this.star1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star1_MouseClick);
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Location = new System.Drawing.Point(106, 10);
            this.star2.Margin = new System.Windows.Forms.Padding(10);
            this.star2.Name = "star2";
            this.star2.Padding = new System.Windows.Forms.Padding(10);
            this.star2.Size = new System.Drawing.Size(70, 70);
            this.star2.TabIndex = 2;
            this.star2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star2_MouseClick);
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.Location = new System.Drawing.Point(204, 10);
            this.star3.Margin = new System.Windows.Forms.Padding(10);
            this.star3.Name = "star3";
            this.star3.Padding = new System.Windows.Forms.Padding(10);
            this.star3.Size = new System.Drawing.Size(70, 70);
            this.star3.TabIndex = 2;
            this.star3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star3_MouseClick);
            // 
            // star4
            // 
            this.star4.BackColor = System.Drawing.Color.Transparent;
            this.star4.Location = new System.Drawing.Point(302, 10);
            this.star4.Margin = new System.Windows.Forms.Padding(10);
            this.star4.Name = "star4";
            this.star4.Padding = new System.Windows.Forms.Padding(10);
            this.star4.Size = new System.Drawing.Size(70, 70);
            this.star4.TabIndex = 3;
            this.star4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star4_MouseClick);
            // 
            // star5
            // 
            this.star5.BackColor = System.Drawing.Color.Transparent;
            this.star5.Location = new System.Drawing.Point(400, 10);
            this.star5.Margin = new System.Windows.Forms.Padding(10);
            this.star5.Name = "star5";
            this.star5.Padding = new System.Windows.Forms.Padding(10);
            this.star5.Size = new System.Drawing.Size(70, 70);
            this.star5.TabIndex = 4;
            this.star5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star5_MouseClick);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Name = "Rating";
            this.Size = new System.Drawing.Size(478, 88);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel star1;
        private System.Windows.Forms.Panel star2;
        private System.Windows.Forms.Panel star3;
        private System.Windows.Forms.Panel star4;
        private System.Windows.Forms.Panel star5;
    }
}
