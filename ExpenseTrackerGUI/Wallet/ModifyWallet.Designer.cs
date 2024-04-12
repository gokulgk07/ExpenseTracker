namespace ExpenseTrackerGUI
{
    partial class ModifyWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyWallet));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tcWallet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.lblExist = new System.Windows.Forms.Label();
            this.btnSave = new ExpenseTrackerGUI.CurveButton();
            this.tbWalletName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new ExpenseTrackerGUI.CurveButton();
            this.btnCancel = new ExpenseTrackerGUI.CurveButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblDeleteTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.tcWallet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(400, 40);
            this.pnlTop.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(364, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnCancelClickTriggered);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 23);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Add Wallet";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(390, 40);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 360);
            this.pnlRight.TabIndex = 6;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 40);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 360);
            this.pnlLeft.TabIndex = 7;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 390);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(380, 10);
            this.pnlBottom.TabIndex = 8;
            // 
            // tcWallet
            // 
            this.tcWallet.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcWallet.Controls.Add(this.tabPage1);
            this.tcWallet.Controls.Add(this.tabPage2);
            this.tcWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcWallet.ItemSize = new System.Drawing.Size(0, 1);
            this.tcWallet.Location = new System.Drawing.Point(10, 40);
            this.tcWallet.Name = "tcWallet";
            this.tcWallet.SelectedIndex = 0;
            this.tcWallet.Size = new System.Drawing.Size(380, 350);
            this.tcWallet.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcWallet.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.tbBalance);
            this.tabPage1.Controls.Add(this.lblExist);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.tbWalletName);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(73, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 31);
            this.panel1.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 78;
            this.label1.Text = "   Delete This Wallet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.OnDeleteClickTriggered);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.OnDeleteClickTriggered);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // tbBalance
            // 
            this.tbBalance.BackColor = System.Drawing.Color.GhostWhite;
            this.tbBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalance.ForeColor = System.Drawing.Color.Gray;
            this.tbBalance.Location = new System.Drawing.Point(107, 124);
            this.tbBalance.Multiline = true;
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(234, 34);
            this.tbBalance.TabIndex = 82;
            this.tbBalance.Text = "Enter your current balance";
            this.tbBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnBalanceKeyPressed);
            // 
            // lblExist
            // 
            this.lblExist.AutoSize = true;
            this.lblExist.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExist.ForeColor = System.Drawing.Color.Red;
            this.lblExist.Location = new System.Drawing.Point(113, 69);
            this.lblExist.Name = "lblExist";
            this.lblExist.Size = new System.Drawing.Size(147, 14);
            this.lblExist.TabIndex = 81;
            this.lblExist.Text = "This category already exists.";
            this.lblExist.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnSave.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.ButtonForeColor = System.Drawing.Color.Black;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Enabled = false;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(72, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 20;
            this.btnSave.Size = new System.Drawing.Size(215, 46);
            this.btnSave.TabIndex = 80;
            this.btnSave.Click += new System.EventHandler(this.OnSaveBtnClickTriggered);
            // 
            // tbWalletName
            // 
            this.tbWalletName.BackColor = System.Drawing.Color.GhostWhite;
            this.tbWalletName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWalletName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWalletName.ForeColor = System.Drawing.Color.Gray;
            this.tbWalletName.Location = new System.Drawing.Point(107, 35);
            this.tbWalletName.Multiline = true;
            this.tbWalletName.Name = "tbWalletName";
            this.tbWalletName.Size = new System.Drawing.Size(199, 34);
            this.tbWalletName.TabIndex = 79;
            this.tbWalletName.Text = "Wallet Name";
            this.tbWalletName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextBoxKeyPressed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.lblMsg);
            this.tabPage2.Controls.Add(this.lblDeleteTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(372, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnDelete.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnDelete.ButtonForeColor = System.Drawing.Color.White;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(243, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(108, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteBtnClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnCancel.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.btnCancel.ButtonForeColor = System.Drawing.Color.White;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(116, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 20;
            this.btnCancel.Size = new System.Drawing.Size(108, 46);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Click += new System.EventHandler(this.OnCancelBtnClicked);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(16, 46);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(334, 74);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Do you want to delete this wallet?";
            // 
            // lblDeleteTitle
            // 
            this.lblDeleteTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTitle.Location = new System.Drawing.Point(16, 15);
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(294, 32);
            this.lblDeleteTitle.TabIndex = 0;
            this.lblDeleteTitle.Text = "Do you want to delete this wallet?";
            // 
            // ModifyWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tcWallet);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Name = "ModifyWallet";
            this.Size = new System.Drawing.Size(400, 400);
            this.pnlTop.ResumeLayout(false);
            this.tcWallet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TabControl tcWallet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label lblExist;
        private CurveButton btnSave;
        private System.Windows.Forms.TextBox tbWalletName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private CurveButton btnDelete;
        private CurveButton btnCancel;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblDeleteTitle;
    }
}
