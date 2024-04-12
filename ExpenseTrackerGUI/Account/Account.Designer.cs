namespace ExpenseTrackerGUI.Account
{
    partial class Account
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.accountPanel = new System.Windows.Forms.Panel();
            this.cross1 = new System.Windows.Forms.PictureBox();
            this.resultShowPanel = new System.Windows.Forms.Panel();
            this.resultShowLbl = new System.Windows.Forms.Label();
            this.nextPicture = new System.Windows.Forms.PictureBox();
            this.newEyeShow = new System.Windows.Forms.PictureBox();
            this.oldEyeShow = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newLbl = new System.Windows.Forms.Label();
            this.oldLbl = new System.Windows.Forms.Label();
            this.changePassword = new System.Windows.Forms.Button();
            this.newTextbox = new System.Windows.Forms.TextBox();
            this.oldTextBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changePicture = new System.Windows.Forms.PictureBox();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountDetailsPanel = new ExpenseTrackerGUI.Home.CardPanel();
            this.OldEyeClose = new System.Windows.Forms.PictureBox();
            this.newEyeHide = new System.Windows.Forms.PictureBox();
            this.passwordPanel = new ExpenseTrackerGUI.Home.CardPanel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.info3 = new System.Windows.Forms.Label();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.info2 = new System.Windows.Forms.Label();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.info1 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoPanel = new ExpenseTrackerGUI.Home.CardPanel();
            this.cross2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross1)).BeginInit();
            this.resultShowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEyeShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldEyeShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldEyeClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEyeHide)).BeginInit();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross2)).BeginInit();
            this.SuspendLayout();
            // 
            // accountPanel
            // 
            this.accountPanel.Controls.Add(this.cross1);
            this.accountPanel.Controls.Add(this.resultShowPanel);
            this.accountPanel.Controls.Add(this.nextPicture);
            this.accountPanel.Controls.Add(this.newEyeShow);
            this.accountPanel.Controls.Add(this.oldEyeShow);
            this.accountPanel.Controls.Add(this.panel2);
            this.accountPanel.Controls.Add(this.panel1);
            this.accountPanel.Controls.Add(this.newLbl);
            this.accountPanel.Controls.Add(this.oldLbl);
            this.accountPanel.Controls.Add(this.changePassword);
            this.accountPanel.Controls.Add(this.newTextbox);
            this.accountPanel.Controls.Add(this.oldTextBox);
            this.accountPanel.Controls.Add(this.changeLabel);
            this.accountPanel.Controls.Add(this.changePicture);
            this.accountPanel.Controls.Add(this.signOutBtn);
            this.accountPanel.Controls.Add(this.deleteBtn);
            this.accountPanel.Controls.Add(this.changeBtn);
            this.accountPanel.Controls.Add(this.emailLabel);
            this.accountPanel.Controls.Add(this.userNameLabel);
            this.accountPanel.Controls.Add(this.pictureBox1);
            this.accountPanel.Controls.Add(this.accountDetailsPanel);
            this.accountPanel.Controls.Add(this.OldEyeClose);
            this.accountPanel.Controls.Add(this.newEyeHide);
            this.accountPanel.Controls.Add(this.passwordPanel);
            this.accountPanel.Controls.Add(this.deletePanel);
            this.accountPanel.Controls.Add(this.cross2);
            this.accountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountPanel.Location = new System.Drawing.Point(0, 0);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(278, 717);
            this.accountPanel.TabIndex = 9;
            // 
            // cross1
            // 
            this.cross1.BackColor = System.Drawing.Color.White;
            this.cross1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross1.Image = ((System.Drawing.Image)(resources.GetObject("cross1.Image")));
            this.cross1.Location = new System.Drawing.Point(249, 9);
            this.cross1.Name = "cross1";
            this.cross1.Size = new System.Drawing.Size(20, 20);
            this.cross1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cross1.TabIndex = 43;
            this.cross1.TabStop = false;
            this.cross1.Click += new System.EventHandler(this.accountDetailsPanel_Click);
            this.cross1.MouseEnter += new System.EventHandler(this.cross1_MouseEnter);
            this.cross1.MouseLeave += new System.EventHandler(this.cross1_MouseLeave);
            // 
            // resultShowPanel
            // 
            this.resultShowPanel.Controls.Add(this.resultShowLbl);
            this.resultShowPanel.Location = new System.Drawing.Point(15, 193);
            this.resultShowPanel.Name = "resultShowPanel";
            this.resultShowPanel.Size = new System.Drawing.Size(247, 190);
            this.resultShowPanel.TabIndex = 42;
            // 
            // resultShowLbl
            // 
            this.resultShowLbl.AutoSize = true;
            this.resultShowLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultShowLbl.Location = new System.Drawing.Point(50, 86);
            this.resultShowLbl.Name = "resultShowLbl";
            this.resultShowLbl.Size = new System.Drawing.Size(0, 16);
            this.resultShowLbl.TabIndex = 44;
            this.resultShowLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextPicture
            // 
            this.nextPicture.BackColor = System.Drawing.Color.White;
            this.nextPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPicture.Image = ((System.Drawing.Image)(resources.GetObject("nextPicture.Image")));
            this.nextPicture.Location = new System.Drawing.Point(242, 59);
            this.nextPicture.Name = "nextPicture";
            this.nextPicture.Size = new System.Drawing.Size(20, 20);
            this.nextPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextPicture.TabIndex = 41;
            this.nextPicture.TabStop = false;
            this.nextPicture.Click += new System.EventHandler(this.nextPicture_Click);
            // 
            // newEyeShow
            // 
            this.newEyeShow.BackColor = System.Drawing.Color.White;
            this.newEyeShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEyeShow.Image = ((System.Drawing.Image)(resources.GetObject("newEyeShow.Image")));
            this.newEyeShow.Location = new System.Drawing.Point(237, 288);
            this.newEyeShow.Name = "newEyeShow";
            this.newEyeShow.Size = new System.Drawing.Size(20, 20);
            this.newEyeShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newEyeShow.TabIndex = 28;
            this.newEyeShow.TabStop = false;
            this.newEyeShow.Click += new System.EventHandler(this.newEyeShow_Click);
            // 
            // oldEyeShow
            // 
            this.oldEyeShow.BackColor = System.Drawing.Color.White;
            this.oldEyeShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oldEyeShow.Image = ((System.Drawing.Image)(resources.GetObject("oldEyeShow.Image")));
            this.oldEyeShow.Location = new System.Drawing.Point(237, 244);
            this.oldEyeShow.Name = "oldEyeShow";
            this.oldEyeShow.Size = new System.Drawing.Size(20, 20);
            this.oldEyeShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oldEyeShow.TabIndex = 27;
            this.oldEyeShow.TabStop = false;
            this.oldEyeShow.Click += new System.EventHandler(this.oldEyeShow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(29, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 2);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(29, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 25;
            // 
            // newLbl
            // 
            this.newLbl.BackColor = System.Drawing.Color.White;
            this.newLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLbl.ForeColor = System.Drawing.Color.Gray;
            this.newLbl.Location = new System.Drawing.Point(25, 289);
            this.newLbl.Name = "newLbl";
            this.newLbl.Size = new System.Drawing.Size(206, 22);
            this.newLbl.TabIndex = 24;
            this.newLbl.Text = "New Password";
            this.newLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newLbl.Click += new System.EventHandler(this.newLbl_Click);
            // 
            // oldLbl
            // 
            this.oldLbl.BackColor = System.Drawing.Color.White;
            this.oldLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldLbl.ForeColor = System.Drawing.Color.Gray;
            this.oldLbl.Location = new System.Drawing.Point(25, 244);
            this.oldLbl.Name = "oldLbl";
            this.oldLbl.Size = new System.Drawing.Size(206, 22);
            this.oldLbl.TabIndex = 23;
            this.oldLbl.Text = "Old Password";
            this.oldLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oldLbl.Click += new System.EventHandler(this.oldLbl_Click);
            // 
            // changePassword
            // 
            this.changePassword.BackColor = System.Drawing.Color.White;
            this.changePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.Location = new System.Drawing.Point(15, 332);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(247, 46);
            this.changePassword.TabIndex = 22;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // newTextbox
            // 
            this.newTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newTextbox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTextbox.Location = new System.Drawing.Point(25, 289);
            this.newTextbox.Multiline = true;
            this.newTextbox.Name = "newTextbox";
            this.newTextbox.PasswordChar = '*';
            this.newTextbox.Size = new System.Drawing.Size(206, 25);
            this.newTextbox.TabIndex = 21;
            // 
            // oldTextBox
            // 
            this.oldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldTextBox.Location = new System.Drawing.Point(25, 244);
            this.oldTextBox.Multiline = true;
            this.oldTextBox.Name = "oldTextBox";
            this.oldTextBox.PasswordChar = '*';
            this.oldTextBox.Size = new System.Drawing.Size(206, 25);
            this.oldTextBox.TabIndex = 19;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.White;
            this.changeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(61, 200);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(137, 18);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change Password";
            // 
            // changePicture
            // 
            this.changePicture.BackColor = System.Drawing.Color.White;
            this.changePicture.Image = ((System.Drawing.Image)(resources.GetObject("changePicture.Image")));
            this.changePicture.Location = new System.Drawing.Point(25, 193);
            this.changePicture.Name = "changePicture";
            this.changePicture.Size = new System.Drawing.Size(30, 30);
            this.changePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changePicture.TabIndex = 17;
            this.changePicture.TabStop = false;
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.Color.White;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutBtn.Location = new System.Drawing.Point(191, 104);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(71, 46);
            this.signOutBtn.TabIndex = 15;
            this.signOutBtn.Text = "SignOut";
            this.signOutBtn.UseVisualStyleBackColor = false;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(104, 104);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(71, 46);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete Account";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.White;
            this.changeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.Location = new System.Drawing.Point(15, 104);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(71, 46);
            this.changeBtn.TabIndex = 11;
            this.changeBtn.Text = "Change Password";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.White;
            this.emailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(62, 57);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(10);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Padding = new System.Windows.Forms.Padding(5);
            this.emailLabel.Size = new System.Drawing.Size(120, 25);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "name@gmail.com";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.White;
            this.userNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(62, 29);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.userNameLabel.Size = new System.Drawing.Size(63, 29);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // accountDetailsPanel
            // 
            this.accountDetailsPanel.CardBackColor = System.Drawing.Color.White;
            this.accountDetailsPanel.CardBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.accountDetailsPanel.CardFlickerColor = System.Drawing.Color.White;
            this.accountDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.accountDetailsPanel.Name = "accountDetailsPanel";
            this.accountDetailsPanel.Size = new System.Drawing.Size(278, 166);
            this.accountDetailsPanel.TabIndex = 7;
            this.accountDetailsPanel.Click += new System.EventHandler(this.accountDetailsPanel_Click);
            // 
            // OldEyeClose
            // 
            this.OldEyeClose.BackColor = System.Drawing.Color.White;
            this.OldEyeClose.Image = ((System.Drawing.Image)(resources.GetObject("OldEyeClose.Image")));
            this.OldEyeClose.Location = new System.Drawing.Point(237, 244);
            this.OldEyeClose.Name = "OldEyeClose";
            this.OldEyeClose.Size = new System.Drawing.Size(20, 20);
            this.OldEyeClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OldEyeClose.TabIndex = 29;
            this.OldEyeClose.TabStop = false;
            this.OldEyeClose.Click += new System.EventHandler(this.OldEyeClose_Click);
            // 
            // newEyeHide
            // 
            this.newEyeHide.BackColor = System.Drawing.Color.White;
            this.newEyeHide.Image = ((System.Drawing.Image)(resources.GetObject("newEyeHide.Image")));
            this.newEyeHide.Location = new System.Drawing.Point(237, 287);
            this.newEyeHide.Name = "newEyeHide";
            this.newEyeHide.Size = new System.Drawing.Size(20, 20);
            this.newEyeHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newEyeHide.TabIndex = 30;
            this.newEyeHide.TabStop = false;
            this.newEyeHide.Click += new System.EventHandler(this.newEyeHide_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.CardBackColor = System.Drawing.Color.White;
            this.passwordPanel.CardBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.passwordPanel.CardFlickerColor = System.Drawing.Color.White;
            this.passwordPanel.Location = new System.Drawing.Point(0, 179);
            this.passwordPanel.Margin = new System.Windows.Forms.Padding(20);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Padding = new System.Windows.Forms.Padding(20);
            this.passwordPanel.Size = new System.Drawing.Size(278, 219);
            this.passwordPanel.TabIndex = 16;
            // 
            // deletePanel
            // 
            this.deletePanel.Controls.Add(this.deleteAccount);
            this.deletePanel.Controls.Add(this.info3);
            this.deletePanel.Controls.Add(this.picture3);
            this.deletePanel.Controls.Add(this.info2);
            this.deletePanel.Controls.Add(this.picture2);
            this.deletePanel.Controls.Add(this.info1);
            this.deletePanel.Controls.Add(this.picture1);
            this.deletePanel.Controls.Add(this.infoLabel);
            this.deletePanel.Controls.Add(this.infoPanel);
            this.deletePanel.Location = new System.Drawing.Point(3, 410);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(275, 254);
            this.deletePanel.TabIndex = 40;
            // 
            // deleteAccount
            // 
            this.deleteAccount.BackColor = System.Drawing.Color.White;
            this.deleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAccount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccount.Location = new System.Drawing.Point(13, 192);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(247, 46);
            this.deleteAccount.TabIndex = 48;
            this.deleteAccount.Text = "Delete Account";
            this.deleteAccount.UseVisualStyleBackColor = false;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // info3
            // 
            this.info3.AutoSize = true;
            this.info3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info3.Location = new System.Drawing.Point(39, 159);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(232, 16);
            this.info3.TabIndex = 47;
            this.info3.Text = "Delete all your account information";
            // 
            // picture3
            // 
            this.picture3.BackColor = System.Drawing.Color.White;
            this.picture3.Image = ((System.Drawing.Image)(resources.GetObject("picture3.Image")));
            this.picture3.Location = new System.Drawing.Point(13, 157);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(20, 20);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture3.TabIndex = 46;
            this.picture3.TabStop = false;
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.Location = new System.Drawing.Point(39, 123);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(144, 16);
            this.info2.TabIndex = 45;
            this.info2.Text = "Logout on all devices";
            // 
            // picture2
            // 
            this.picture2.BackColor = System.Drawing.Color.White;
            this.picture2.Image = ((System.Drawing.Image)(resources.GetObject("picture2.Image")));
            this.picture2.Location = new System.Drawing.Point(13, 120);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(20, 20);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 44;
            this.picture2.TabStop = false;
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.Location = new System.Drawing.Point(40, 85);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(197, 16);
            this.info1.TabIndex = 43;
            this.info1.Text = "Won\'t be able to retrieve data\r\n";
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.Color.White;
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(14, 83);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(20, 20);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 42;
            this.picture1.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(19, 22);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(234, 38);
            this.infoLabel.TabIndex = 41;
            this.infoLabel.Text = "Deleting your account will do \r\nthe following :";
            // 
            // infoPanel
            // 
            this.infoPanel.CardBackColor = System.Drawing.Color.White;
            this.infoPanel.CardBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.infoPanel.CardFlickerColor = System.Drawing.Color.White;
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(20);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(20);
            this.infoPanel.Size = new System.Drawing.Size(275, 254);
            this.infoPanel.TabIndex = 40;
            // 
            // cross2
            // 
            this.cross2.BackColor = System.Drawing.Color.White;
            this.cross2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross2.Image = ((System.Drawing.Image)(resources.GetObject("cross2.Image")));
            this.cross2.Location = new System.Drawing.Point(249, 9);
            this.cross2.Name = "cross2";
            this.cross2.Size = new System.Drawing.Size(20, 20);
            this.cross2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cross2.TabIndex = 44;
            this.cross2.TabStop = false;
            this.cross2.Click += new System.EventHandler(this.accountDetailsPanel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountPanel);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(278, 717);
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross1)).EndInit();
            this.resultShowPanel.ResumeLayout(false);
            this.resultShowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEyeShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldEyeShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldEyeClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEyeHide)).EndInit();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Home.CardPanel accountDetailsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newLbl;
        private System.Windows.Forms.Label oldLbl;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.TextBox newTextbox;
        private System.Windows.Forms.TextBox oldTextBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.PictureBox changePicture;
        private Home.CardPanel passwordPanel;
        private System.Windows.Forms.PictureBox oldEyeShow;
        private System.Windows.Forms.PictureBox newEyeShow;
        private System.Windows.Forms.PictureBox OldEyeClose;
        private System.Windows.Forms.PictureBox newEyeHide;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.Label info3;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label infoLabel;
        private Home.CardPanel infoPanel;
        private System.Windows.Forms.Panel resultShowPanel;
        private System.Windows.Forms.Label resultShowLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox cross1;
        private System.Windows.Forms.PictureBox nextPicture;
        private System.Windows.Forms.PictureBox cross2;
    }
}
