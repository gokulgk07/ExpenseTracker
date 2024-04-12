namespace ExpenseTrackerGUI
{
    partial class CountryData
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
            this.pback = new System.Windows.Forms.Panel();
            this.namelb = new System.Windows.Forms.Label();
            this.symbollb = new System.Windows.Forms.Label();
            this.flagpb = new System.Windows.Forms.PictureBox();
            this.pback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagpb)).BeginInit();
            this.SuspendLayout();
            // 
            // pback
            // 
            this.pback.Controls.Add(this.namelb);
            this.pback.Controls.Add(this.symbollb);
            this.pback.Controls.Add(this.flagpb);
            this.pback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pback.Location = new System.Drawing.Point(0, 0);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(227, 34);
            this.pback.TabIndex = 2;
            // 
            // namelb
            // 
            this.namelb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namelb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(103, 0);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(124, 34);
            this.namelb.TabIndex = 2;
            this.namelb.Text = "India";
            this.namelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.namelb.Click += new System.EventHandler(this.OnCountryDataClick);
            this.namelb.MouseEnter += new System.EventHandler(this.OnCountryDataMouseEnter);
            this.namelb.MouseLeave += new System.EventHandler(this.OnCountryDataMouseLeave);
            // 
            // symbollb
            // 
            this.symbollb.Dock = System.Windows.Forms.DockStyle.Left;
            this.symbollb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbollb.Location = new System.Drawing.Point(41, 0);
            this.symbollb.Name = "symbollb";
            this.symbollb.Size = new System.Drawing.Size(62, 34);
            this.symbollb.TabIndex = 1;
            this.symbollb.Text = "₹";
            this.symbollb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.symbollb.Click += new System.EventHandler(this.OnCountryDataClick);
            this.symbollb.MouseEnter += new System.EventHandler(this.OnCountryDataMouseEnter);
            this.symbollb.MouseLeave += new System.EventHandler(this.OnCountryDataMouseLeave);
            // 
            // flagpb
            // 
            this.flagpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagpb.Dock = System.Windows.Forms.DockStyle.Left;
            this.flagpb.Location = new System.Drawing.Point(0, 0);
            this.flagpb.Name = "flagpb";
            this.flagpb.Size = new System.Drawing.Size(41, 34);
            this.flagpb.TabIndex = 0;
            this.flagpb.TabStop = false;
            this.flagpb.Click += new System.EventHandler(this.OnCountryDataClick);
            this.flagpb.MouseEnter += new System.EventHandler(this.OnCountryDataMouseEnter);
            this.flagpb.MouseLeave += new System.EventHandler(this.OnCountryDataMouseLeave);
            // 
            // CountryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pback);
            this.MaximumSize = new System.Drawing.Size(227, 34);
            this.MinimumSize = new System.Drawing.Size(227, 34);
            this.Name = "CountryData";
            this.Size = new System.Drawing.Size(227, 34);
            this.pback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flagpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pback;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Label symbollb;
        private System.Windows.Forms.PictureBox flagpb;
    }
}
