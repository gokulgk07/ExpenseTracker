namespace ExpenseTrackerGUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ratingTimer = new System.Windows.Forms.Timer(this.components);
            this.ratingLbl = new System.Windows.Forms.Label();
            this.mayBeLaterBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.ratingPanel = new ExpenseTrackerGUI.Home.CardPanel();
            this.rating1 = new ExpenseTrackerGUI.Rating.Rating();
            this.loginPage1 = new ExpenseTrackerGUI.LoginPage();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ratingLbl
            // 
            this.ratingLbl.AutoSize = true;
            this.ratingLbl.BackColor = System.Drawing.Color.White;
            this.ratingLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.ratingLbl.Location = new System.Drawing.Point(643, 411);
            this.ratingLbl.Name = "ratingLbl";
            this.ratingLbl.Size = new System.Drawing.Size(546, 64);
            this.ratingLbl.TabIndex = 7;
            this.ratingLbl.Text = "Please rate your overall experience with \r\nour Expense Tracker Application";
            this.ratingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mayBeLaterBtn
            // 
            this.mayBeLaterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.mayBeLaterBtn.FlatAppearance.BorderSize = 0;
            this.mayBeLaterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mayBeLaterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.mayBeLaterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mayBeLaterBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mayBeLaterBtn.ForeColor = System.Drawing.Color.White;
            this.mayBeLaterBtn.Location = new System.Drawing.Point(855, 630);
            this.mayBeLaterBtn.Name = "mayBeLaterBtn";
            this.mayBeLaterBtn.Size = new System.Drawing.Size(111, 39);
            this.mayBeLaterBtn.TabIndex = 8;
            this.mayBeLaterBtn.Text = "Maybe Later !";
            this.mayBeLaterBtn.UseVisualStyleBackColor = false;
            this.mayBeLaterBtn.Click += new System.EventHandler(this.mayBeLaterBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.submitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(1038, 630);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(111, 39);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // ratingPanel
            // 
            this.ratingPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.ratingPanel.CardBackColor = System.Drawing.Color.White;
            this.ratingPanel.CardBorderColor = System.Drawing.Color.Transparent;
            this.ratingPanel.CardFlickerColor = System.Drawing.Color.White;
            this.ratingPanel.Location = new System.Drawing.Point(533, 360);
            this.ratingPanel.Name = "ratingPanel";
            this.ratingPanel.Size = new System.Drawing.Size(745, 340);
            this.ratingPanel.TabIndex = 6;
            // 
            // rating1
            // 
            this.rating1.BackColor = System.Drawing.Color.White;
            this.rating1.Location = new System.Drawing.Point(664, 502);
            this.rating1.Name = "rating1";
            this.rating1.Size = new System.Drawing.Size(485, 100);
            this.rating1.TabIndex = 10;
            // 
            // loginPage1
            // 
            this.loginPage1.CornerRadius = 10;
            this.loginPage1.ForeColor = System.Drawing.Color.White;
            this.loginPage1.Location = new System.Drawing.Point(0, 0);
            this.loginPage1.MaximumSize = new System.Drawing.Size(1174, 775);
            this.loginPage1.MinimumSize = new System.Drawing.Size(1174, 775);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(1174, 775);
            this.loginPage1.TabIndex = 11;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(664, 630);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(111, 39);
            this.close.TabIndex = 12;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 775);
            this.Controls.Add(this.close);
            this.Controls.Add(this.ratingLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.ratingPanel);
            this.Controls.Add(this.loginPage1);
            this.Controls.Add(this.rating1);
            this.Controls.Add(this.mayBeLaterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ratingTimer;
        private Home.CardPanel ratingPanel;
        private System.Windows.Forms.Label ratingLbl;
        private System.Windows.Forms.Button mayBeLaterBtn;
        private System.Windows.Forms.Button submitBtn;
        private Rating.Rating rating1;
        private LoginPage loginPage1;
        private System.Windows.Forms.Button close;
        //private HomeDashboard homeDashboard1;
    }
}