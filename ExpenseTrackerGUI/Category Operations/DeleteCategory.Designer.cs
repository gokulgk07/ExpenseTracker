namespace ExpenseTrackerGUI
{
    partial class DeleteCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCategoryForm));
            this.lblText = new System.Windows.Forms.Label();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.btnDelete1 = new ExpenseTrackerGUI.CurveButton();
            this.lblDeleteDescription = new System.Windows.Forms.Label();
            this.lblMergeDescription = new System.Windows.Forms.Label();
            this.lblDeleteTitle = new System.Windows.Forms.Label();
            this.lblMergeTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new ExpenseTrackerGUI.CurveButton();
            this.btnMergeDel = new ExpenseTrackerGUI.CurveButton();
            this.pnlMsg.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(24, 70);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(350, 50);
            this.lblText.TabIndex = 0;
            // 
            // pnlMsg
            // 
            this.pnlMsg.Controls.Add(this.btnDelete1);
            this.pnlMsg.Controls.Add(this.lblDeleteDescription);
            this.pnlMsg.Controls.Add(this.lblMergeDescription);
            this.pnlMsg.Controls.Add(this.lblDeleteTitle);
            this.pnlMsg.Controls.Add(this.lblMergeTitle);
            this.pnlMsg.Location = new System.Drawing.Point(24, 123);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(350, 97);
            this.pnlMsg.TabIndex = 4;
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnDelete1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnDelete1.ButtonForeColor = System.Drawing.Color.White;
            this.btnDelete1.ButtonText = "Delete";
            this.btnDelete1.ForeColor = System.Drawing.Color.White;
            this.btnDelete1.Location = new System.Drawing.Point(53, 39);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Radius = 20;
            this.btnDelete1.Size = new System.Drawing.Size(238, 40);
            this.btnDelete1.TabIndex = 52;
            this.btnDelete1.Visible = false;
            this.btnDelete1.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // lblDeleteDescription
            // 
            this.lblDeleteDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteDescription.Location = new System.Drawing.Point(168, 72);
            this.lblDeleteDescription.Name = "lblDeleteDescription";
            this.lblDeleteDescription.Size = new System.Drawing.Size(174, 23);
            this.lblDeleteDescription.TabIndex = 3;
            this.lblDeleteDescription.Text = "Delete all transactions.";
            // 
            // lblMergeDescription
            // 
            this.lblMergeDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMergeDescription.Location = new System.Drawing.Point(168, 13);
            this.lblMergeDescription.Name = "lblMergeDescription";
            this.lblMergeDescription.Size = new System.Drawing.Size(174, 42);
            this.lblMergeDescription.TabIndex = 2;
            this.lblMergeDescription.Text = "Move all transactions to another category.";
            // 
            // lblDeleteTitle
            // 
            this.lblDeleteTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTitle.Location = new System.Drawing.Point(12, 72);
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(145, 23);
            this.lblDeleteTitle.TabIndex = 1;
            this.lblDeleteTitle.Text = "2. Delete:";
            // 
            // lblMergeTitle
            // 
            this.lblMergeTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMergeTitle.Location = new System.Drawing.Point(12, 13);
            this.lblMergeTitle.Name = "lblMergeTitle";
            this.lblMergeTitle.Size = new System.Drawing.Size(150, 23);
            this.lblMergeTitle.TabIndex = 0;
            this.lblMergeTitle.Text = "1. Merge category:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.pbDelete);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 37);
            this.panel2.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(354, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnCloseBtnClicked);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbDelete.Image")));
            this.pbDelete.Location = new System.Drawing.Point(14, 7);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(25, 25);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 18;
            this.pbDelete.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(45, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 23);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Delete Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 278);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(385, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 278);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(15, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 15);
            this.panel5.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnDelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnDelete.ButtonForeColor = System.Drawing.Color.White;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(217, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnMergeDel
            // 
            this.btnMergeDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnMergeDel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnMergeDel.ButtonForeColor = System.Drawing.Color.White;
            this.btnMergeDel.ButtonText = "Merge";
            this.btnMergeDel.ForeColor = System.Drawing.Color.White;
            this.btnMergeDel.Location = new System.Drawing.Point(61, 243);
            this.btnMergeDel.Name = "btnMergeDel";
            this.btnMergeDel.Radius = 20;
            this.btnMergeDel.Size = new System.Drawing.Size(110, 40);
            this.btnMergeDel.TabIndex = 50;
            this.btnMergeDel.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // DeleteCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 315);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMergeDel);
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Category";
            this.pnlMsg.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.Label lblDeleteDescription;
        private System.Windows.Forms.Label lblMergeDescription;
        private System.Windows.Forms.Label lblDeleteTitle;
        private System.Windows.Forms.Label lblMergeTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.Button btnClose;
        private CurveButton btnMergeDel;
        private CurveButton btnDelete;
        private CurveButton btnDelete1;
    }
}