namespace ExpenseTrackerGUI
{
    partial class BudgetSquare
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.progressBarUserControl = new ExpenseTrackerGUI.ProgressBarUserControl();
            this.amountLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(77, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(42, 34);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.OnBudgetSquareClicked);
            // 
            // progressBarUserControl
            // 
            this.progressBarUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.progressBarUserControl.Location = new System.Drawing.Point(23, 160);
            this.progressBarUserControl.MaximumSize = new System.Drawing.Size(150, 13);
            this.progressBarUserControl.MinimumSize = new System.Drawing.Size(150, 13);
            this.progressBarUserControl.Name = "progressBarUserControl";
            this.progressBarUserControl.Size = new System.Drawing.Size(150, 13);
            this.progressBarUserControl.TabIndex = 6;
            this.progressBarUserControl.Value = 0;
            this.progressBarUserControl.Click += new System.EventHandler(this.OnBudgetSquareClicked);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.amountLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(68, 129);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(63, 16);
            this.amountLbl.TabIndex = 7;
            this.amountLbl.Text = "AMOUNT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryLbl);
            this.panel1.Location = new System.Drawing.Point(23, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 40);
            this.panel1.TabIndex = 8;
            // 
            // categoryLbl
            // 
            this.categoryLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(0, 0);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(150, 40);
            this.categoryLbl.TabIndex = 3;
            this.categoryLbl.Text = "B";
            this.categoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BudgetSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.progressBarUserControl);
            this.Controls.Add(this.pictureBox);
            this.MaximumSize = new System.Drawing.Size(210, 210);
            this.MinimumSize = new System.Drawing.Size(200, 180);
            this.Name = "BudgetSquare";
            this.Size = new System.Drawing.Size(200, 200);
            this.Click += new System.EventHandler(this.OnBudgetSquareClicked);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private ProgressBarUserControl progressBarUserControl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label categoryLbl;
    }
}
