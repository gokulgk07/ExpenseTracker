namespace ExpenseTrackerGUI
{
    partial class Form4
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
            this.transactionManager1 = new ExpenseTrackerGUI.TransactionManager();
            this.SuspendLayout();
            // 
            // transactionManager1
            // 
            this.transactionManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionManager1.Location = new System.Drawing.Point(0, 0);
            this.transactionManager1.Name = "transactionManager1";
            this.transactionManager1.Size = new System.Drawing.Size(1304, 828);
            this.transactionManager1.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 828);
            this.Controls.Add(this.transactionManager1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CreateTransaction createTransaction1;
        private TransactionManager transactionManager1;
    }
}