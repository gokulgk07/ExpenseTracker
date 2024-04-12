namespace ExpenseTrackerGUI
{
    partial class CreateTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTransaction));
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.paddtransaction = new System.Windows.Forms.Panel();
            this.pborder = new System.Windows.Forms.Panel();
            this.padd = new System.Windows.Forms.Panel();
            this.walletbt = new System.Windows.Forms.Button();
            this.walletlb = new System.Windows.Forms.Label();
            this.lresult = new System.Windows.Forms.Label();
            this.Clearbt = new System.Windows.Forms.Button();
            this.categoryselectbt = new System.Windows.Forms.Button();
            this.savebt = new System.Windows.Forms.Button();
            this.descriptiontb = new System.Windows.Forms.RichTextBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionlb = new System.Windows.Forms.Label();
            this.datelb = new System.Windows.Forms.Label();
            this.categorylb = new System.Windows.Forms.Label();
            this.amounttb = new System.Windows.Forms.TextBox();
            this.amountlb = new System.Windows.Forms.Label();
            this.pback = new System.Windows.Forms.Panel();
            this.pup = new System.Windows.Forms.Panel();
            this.pdown = new System.Windows.Forms.Panel();
            this.pright = new System.Windows.Forms.Panel();
            this.pleft = new System.Windows.Forms.Panel();
            this.ptop = new System.Windows.Forms.Panel();
            this.lhead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.paddtransaction.SuspendLayout();
            this.pborder.SuspendLayout();
            this.padd.SuspendLayout();
            this.ptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // paddtransaction
            // 
            this.paddtransaction.BackColor = System.Drawing.Color.MidnightBlue;
            this.paddtransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paddtransaction.Controls.Add(this.pborder);
            this.paddtransaction.Controls.Add(this.pup);
            this.paddtransaction.Controls.Add(this.pdown);
            this.paddtransaction.Controls.Add(this.pright);
            this.paddtransaction.Controls.Add(this.pleft);
            this.paddtransaction.Controls.Add(this.ptop);
            this.paddtransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paddtransaction.Location = new System.Drawing.Point(0, 0);
            this.paddtransaction.Name = "paddtransaction";
            this.paddtransaction.Size = new System.Drawing.Size(1170, 747);
            this.paddtransaction.TabIndex = 10;
            // 
            // pborder
            // 
            this.pborder.BackColor = System.Drawing.Color.GhostWhite;
            this.pborder.Controls.Add(this.padd);
            this.pborder.Controls.Add(this.pback);
            this.pborder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pborder.Location = new System.Drawing.Point(12, 51);
            this.pborder.Name = "pborder";
            this.pborder.Size = new System.Drawing.Size(1146, 684);
            this.pborder.TabIndex = 10;
            // 
            // padd
            // 
            this.padd.BackColor = System.Drawing.Color.MidnightBlue;
            this.padd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.padd.Controls.Add(this.walletbt);
            this.padd.Controls.Add(this.walletlb);
            this.padd.Controls.Add(this.lresult);
            this.padd.Controls.Add(this.Clearbt);
            this.padd.Controls.Add(this.categoryselectbt);
            this.padd.Controls.Add(this.savebt);
            this.padd.Controls.Add(this.descriptiontb);
            this.padd.Controls.Add(this.datepicker);
            this.padd.Controls.Add(this.descriptionlb);
            this.padd.Controls.Add(this.datelb);
            this.padd.Controls.Add(this.categorylb);
            this.padd.Controls.Add(this.amounttb);
            this.padd.Controls.Add(this.amountlb);
            this.padd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padd.Location = new System.Drawing.Point(184, 41);
            this.padd.Name = "padd";
            this.padd.Size = new System.Drawing.Size(770, 519);
            this.padd.TabIndex = 1;
            this.padd.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaddPaint);
            // 
            // walletbt
            // 
            this.walletbt.BackColor = System.Drawing.Color.Gainsboro;
            this.walletbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.walletbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.walletbt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletbt.Location = new System.Drawing.Point(509, 357);
            this.walletbt.Name = "walletbt";
            this.walletbt.Size = new System.Drawing.Size(235, 29);
            this.walletbt.TabIndex = 35;
            this.walletbt.Text = "Select Wallet                          ➤";
            this.walletbt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.walletbt.UseVisualStyleBackColor = false;
            this.walletbt.Click += new System.EventHandler(this.OnWalletBtClick);
            // 
            // walletlb
            // 
            this.walletlb.AutoSize = true;
            this.walletlb.BackColor = System.Drawing.Color.Transparent;
            this.walletlb.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletlb.ForeColor = System.Drawing.Color.White;
            this.walletlb.Location = new System.Drawing.Point(130, 357);
            this.walletlb.Name = "walletlb";
            this.walletlb.Size = new System.Drawing.Size(194, 32);
            this.walletlb.TabIndex = 34;
            this.walletlb.Text = "Choose Wallet";
            this.walletlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lresult
            // 
            this.lresult.AutoSize = true;
            this.lresult.BackColor = System.Drawing.Color.Transparent;
            this.lresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lresult.ForeColor = System.Drawing.Color.Red;
            this.lresult.Location = new System.Drawing.Point(266, 436);
            this.lresult.Name = "lresult";
            this.lresult.Size = new System.Drawing.Size(0, 24);
            this.lresult.TabIndex = 33;
            this.lresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clearbt
            // 
            this.Clearbt.BackColor = System.Drawing.Color.GhostWhite;
            this.Clearbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearbt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clearbt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.Clearbt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Clearbt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Clearbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Clearbt.Location = new System.Drawing.Point(308, 478);
            this.Clearbt.Name = "Clearbt";
            this.Clearbt.Size = new System.Drawing.Size(89, 36);
            this.Clearbt.TabIndex = 32;
            this.Clearbt.Text = "Clear";
            this.Clearbt.UseVisualStyleBackColor = false;
            this.Clearbt.Click += new System.EventHandler(this.OnClearBtClick);
            // 
            // categoryselectbt
            // 
            this.categoryselectbt.BackColor = System.Drawing.Color.Gainsboro;
            this.categoryselectbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryselectbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryselectbt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryselectbt.Location = new System.Drawing.Point(509, 138);
            this.categoryselectbt.Name = "categoryselectbt";
            this.categoryselectbt.Size = new System.Drawing.Size(235, 29);
            this.categoryselectbt.TabIndex = 31;
            this.categoryselectbt.Text = "Select Category                     ➤";
            this.categoryselectbt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryselectbt.UseVisualStyleBackColor = false;
            this.categoryselectbt.Click += new System.EventHandler(this.OnCategoryBtSelect);
            // 
            // savebt
            // 
            this.savebt.BackColor = System.Drawing.Color.GhostWhite;
            this.savebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.savebt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.savebt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.savebt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.savebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.savebt.Location = new System.Drawing.Point(519, 478);
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(89, 36);
            this.savebt.TabIndex = 25;
            this.savebt.Text = "Save";
            this.savebt.UseVisualStyleBackColor = false;
            this.savebt.Click += new System.EventHandler(this.OnSaveBtClick);
            // 
            // descriptiontb
            // 
            this.descriptiontb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontb.Location = new System.Drawing.Point(509, 281);
            this.descriptiontb.Name = "descriptiontb";
            this.descriptiontb.Size = new System.Drawing.Size(235, 34);
            this.descriptiontb.TabIndex = 30;
            this.descriptiontb.Text = "";
            // 
            // datepicker
            // 
            this.datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datepicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Location = new System.Drawing.Point(509, 212);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(235, 26);
            this.datepicker.TabIndex = 29;
            // 
            // descriptionlb
            // 
            this.descriptionlb.AutoSize = true;
            this.descriptionlb.BackColor = System.Drawing.Color.Transparent;
            this.descriptionlb.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlb.ForeColor = System.Drawing.Color.White;
            this.descriptionlb.Location = new System.Drawing.Point(130, 280);
            this.descriptionlb.Name = "descriptionlb";
            this.descriptionlb.Size = new System.Drawing.Size(152, 32);
            this.descriptionlb.TabIndex = 28;
            this.descriptionlb.Text = "Description";
            this.descriptionlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datelb
            // 
            this.datelb.AutoSize = true;
            this.datelb.BackColor = System.Drawing.Color.Transparent;
            this.datelb.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelb.ForeColor = System.Drawing.Color.White;
            this.datelb.Location = new System.Drawing.Point(130, 207);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(146, 32);
            this.datelb.TabIndex = 27;
            this.datelb.Text = "Enter Date";
            this.datelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categorylb
            // 
            this.categorylb.AutoSize = true;
            this.categorylb.BackColor = System.Drawing.Color.Transparent;
            this.categorylb.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylb.ForeColor = System.Drawing.Color.White;
            this.categorylb.Location = new System.Drawing.Point(130, 138);
            this.categorylb.Name = "categorylb";
            this.categorylb.Size = new System.Drawing.Size(228, 32);
            this.categorylb.TabIndex = 26;
            this.categorylb.Text = "Choose Category";
            this.categorylb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amounttb
            // 
            this.amounttb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttb.Location = new System.Drawing.Point(509, 68);
            this.amounttb.Multiline = true;
            this.amounttb.Name = "amounttb";
            this.amounttb.Size = new System.Drawing.Size(235, 26);
            this.amounttb.TabIndex = 24;
            this.amounttb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnAmountKeyPress);
            // 
            // amountlb
            // 
            this.amountlb.AutoSize = true;
            this.amountlb.BackColor = System.Drawing.Color.Transparent;
            this.amountlb.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlb.ForeColor = System.Drawing.Color.White;
            this.amountlb.Location = new System.Drawing.Point(130, 68);
            this.amountlb.Name = "amountlb";
            this.amountlb.Size = new System.Drawing.Size(180, 32);
            this.amountlb.TabIndex = 23;
            this.amountlb.Text = "Enter Amount";
            this.amountlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pback
            // 
            this.pback.BackColor = System.Drawing.Color.GhostWhite;
            this.pback.Location = new System.Drawing.Point(238, 21);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(694, 592);
            this.pback.TabIndex = 2;
            // 
            // pup
            // 
            this.pup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pup.Location = new System.Drawing.Point(12, 46);
            this.pup.Name = "pup";
            this.pup.Size = new System.Drawing.Size(1146, 5);
            this.pup.TabIndex = 9;
            // 
            // pdown
            // 
            this.pdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pdown.Location = new System.Drawing.Point(12, 735);
            this.pdown.Name = "pdown";
            this.pdown.Size = new System.Drawing.Size(1146, 12);
            this.pdown.TabIndex = 8;
            // 
            // pright
            // 
            this.pright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pright.Location = new System.Drawing.Point(1158, 46);
            this.pright.Name = "pright";
            this.pright.Size = new System.Drawing.Size(12, 701);
            this.pright.TabIndex = 7;
            // 
            // pleft
            // 
            this.pleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pleft.Location = new System.Drawing.Point(0, 46);
            this.pleft.Name = "pleft";
            this.pleft.Size = new System.Drawing.Size(12, 701);
            this.pleft.TabIndex = 6;
            // 
            // ptop
            // 
            this.ptop.Controls.Add(this.lhead);
            this.ptop.Controls.Add(this.pictureBox1);
            this.ptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(1170, 46);
            this.ptop.TabIndex = 5;
            // 
            // lhead
            // 
            this.lhead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lhead.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhead.ForeColor = System.Drawing.Color.White;
            this.lhead.Location = new System.Drawing.Point(53, 0);
            this.lhead.Name = "lhead";
            this.lhead.Size = new System.Drawing.Size(1117, 46);
            this.lhead.TabIndex = 5;
            this.lhead.Text = "Create Transaction";
            this.lhead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CreateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paddtransaction);
            this.MinimumSize = new System.Drawing.Size(784, 747);
            this.Name = "CreateTransaction";
            this.Size = new System.Drawing.Size(1170, 747);
            this.Load += new System.EventHandler(this.OnCreateTransactionLoad);
            this.Resize += new System.EventHandler(this.OnCreateTransactionResize);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.paddtransaction.ResumeLayout(false);
            this.pborder.ResumeLayout(false);
            this.padd.ResumeLayout(false);
            this.padd.PerformLayout();
            this.ptop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel paddtransaction;
        private System.Windows.Forms.Panel ptop;
        private System.Windows.Forms.Label lhead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pup;
        private System.Windows.Forms.Panel pdown;
        private System.Windows.Forms.Panel pright;
        private System.Windows.Forms.Panel pleft;
        private System.Windows.Forms.Panel pborder;
        private System.Windows.Forms.Panel padd;
        private System.Windows.Forms.Button walletbt;
        private System.Windows.Forms.Label walletlb;
        private System.Windows.Forms.Label lresult;
        private System.Windows.Forms.Button Clearbt;
        private System.Windows.Forms.Button categoryselectbt;
        private System.Windows.Forms.Button savebt;
        private System.Windows.Forms.RichTextBox descriptiontb;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label descriptionlb;
        private System.Windows.Forms.Label datelb;
        private System.Windows.Forms.Label categorylb;
        private System.Windows.Forms.TextBox amounttb;
        private System.Windows.Forms.Label amountlb;
        private System.Windows.Forms.Panel pback;
    }
}
