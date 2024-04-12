namespace ExpenseTrackerGUI
{
    partial class ViewIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIndividual));
            this.pt1 = new System.Windows.Forms.Panel();
            this.pb1 = new System.Windows.Forms.Panel();
            this.pback = new System.Windows.Forms.Panel();
            this.pbottom = new System.Windows.Forms.Panel();
            this.Descriptionlb = new System.Windows.Forms.Label();
            this.pr5 = new System.Windows.Forms.Panel();
            this.pl5 = new System.Windows.Forms.Panel();
            this.pmd2 = new System.Windows.Forms.Panel();
            this.pm2 = new System.Windows.Forms.Panel();
            this.pr4 = new System.Windows.Forms.Panel();
            this.pl4 = new System.Windows.Forms.Panel();
            this.pdate = new System.Windows.Forms.Panel();
            this.datelb = new System.Windows.Forms.Label();
            this.pr3 = new System.Windows.Forms.Panel();
            this.pl3 = new System.Windows.Forms.Panel();
            this.pmd1 = new System.Windows.Forms.Panel();
            this.pm1 = new System.Windows.Forms.Panel();
            this.pr2 = new System.Windows.Forms.Panel();
            this.pl2 = new System.Windows.Forms.Panel();
            this.ptop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletelb = new System.Windows.Forms.Label();
            this.Deletebt = new System.Windows.Forms.PictureBox();
            this.pedit = new System.Windows.Forms.Panel();
            this.editlb = new System.Windows.Forms.Label();
            this.Editbt = new System.Windows.Forms.PictureBox();
            this.Amountlb = new System.Windows.Forms.Label();
            this.rupeelb = new System.Windows.Forms.Label();
            this.Categorynamelb = new System.Windows.Forms.Label();
            this.categoryicon = new System.Windows.Forms.PictureBox();
            this.pr1 = new System.Windows.Forms.Panel();
            this.pl1 = new System.Windows.Forms.Panel();
            this.pback.SuspendLayout();
            this.pbottom.SuspendLayout();
            this.pmd2.SuspendLayout();
            this.pdate.SuspendLayout();
            this.pmd1.SuspendLayout();
            this.ptop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deletebt)).BeginInit();
            this.pedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editbt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryicon)).BeginInit();
            this.SuspendLayout();
            // 
            // pt1
            // 
            this.pt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pt1.Location = new System.Drawing.Point(0, 0);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(700, 7);
            this.pt1.TabIndex = 1;
            this.pt1.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pt1.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pb1
            // 
            this.pb1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb1.Location = new System.Drawing.Point(0, 93);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(700, 7);
            this.pb1.TabIndex = 2;
            this.pb1.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pb1.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pback
            // 
            this.pback.BackColor = System.Drawing.Color.Transparent;
            this.pback.Controls.Add(this.pbottom);
            this.pback.Controls.Add(this.pmd2);
            this.pback.Controls.Add(this.pdate);
            this.pback.Controls.Add(this.pmd1);
            this.pback.Controls.Add(this.ptop);
            this.pback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pback.ForeColor = System.Drawing.Color.Black;
            this.pback.Location = new System.Drawing.Point(0, 7);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(700, 86);
            this.pback.TabIndex = 5;
            // 
            // pbottom
            // 
            this.pbottom.Controls.Add(this.Descriptionlb);
            this.pbottom.Controls.Add(this.pr5);
            this.pbottom.Controls.Add(this.pl5);
            this.pbottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbottom.Location = new System.Drawing.Point(0, 57);
            this.pbottom.Name = "pbottom";
            this.pbottom.Size = new System.Drawing.Size(700, 29);
            this.pbottom.TabIndex = 16;
            // 
            // Descriptionlb
            // 
            this.Descriptionlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Descriptionlb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionlb.ForeColor = System.Drawing.Color.Black;
            this.Descriptionlb.Location = new System.Drawing.Point(18, 0);
            this.Descriptionlb.Name = "Descriptionlb";
            this.Descriptionlb.Size = new System.Drawing.Size(664, 29);
            this.Descriptionlb.TabIndex = 17;
            this.Descriptionlb.Text = "Electricity Expense (Description)";
            this.Descriptionlb.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.Descriptionlb.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pr5
            // 
            this.pr5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pr5.Location = new System.Drawing.Point(682, 0);
            this.pr5.Name = "pr5";
            this.pr5.Size = new System.Drawing.Size(18, 29);
            this.pr5.TabIndex = 16;
            this.pr5.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pr5.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pl5
            // 
            this.pl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl5.Location = new System.Drawing.Point(0, 0);
            this.pl5.Name = "pl5";
            this.pl5.Size = new System.Drawing.Size(18, 29);
            this.pl5.TabIndex = 15;
            this.pl5.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pl5.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pmd2
            // 
            this.pmd2.Controls.Add(this.pm2);
            this.pmd2.Controls.Add(this.pr4);
            this.pmd2.Controls.Add(this.pl4);
            this.pmd2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pmd2.Location = new System.Drawing.Point(0, 56);
            this.pmd2.Name = "pmd2";
            this.pmd2.Size = new System.Drawing.Size(700, 1);
            this.pmd2.TabIndex = 15;
            // 
            // pm2
            // 
            this.pm2.BackColor = System.Drawing.Color.Black;
            this.pm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pm2.Location = new System.Drawing.Point(8, 0);
            this.pm2.Name = "pm2";
            this.pm2.Size = new System.Drawing.Size(684, 1);
            this.pm2.TabIndex = 17;
            this.pm2.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pm2.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pr4
            // 
            this.pr4.BackColor = System.Drawing.Color.Black;
            this.pr4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pr4.Location = new System.Drawing.Point(692, 0);
            this.pr4.Name = "pr4";
            this.pr4.Size = new System.Drawing.Size(8, 1);
            this.pr4.TabIndex = 16;
            this.pr4.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pr4.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pl4
            // 
            this.pl4.BackColor = System.Drawing.Color.Black;
            this.pl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl4.Location = new System.Drawing.Point(0, 0);
            this.pl4.Name = "pl4";
            this.pl4.Size = new System.Drawing.Size(8, 1);
            this.pl4.TabIndex = 15;
            this.pl4.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pl4.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pdate
            // 
            this.pdate.Controls.Add(this.datelb);
            this.pdate.Controls.Add(this.pr3);
            this.pdate.Controls.Add(this.pl3);
            this.pdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pdate.Location = new System.Drawing.Point(0, 30);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(700, 26);
            this.pdate.TabIndex = 14;
            // 
            // datelb
            // 
            this.datelb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datelb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelb.ForeColor = System.Drawing.Color.Black;
            this.datelb.Location = new System.Drawing.Point(18, 0);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(664, 26);
            this.datelb.TabIndex = 17;
            this.datelb.Text = "January,31,2024";
            this.datelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.datelb.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.datelb.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pr3
            // 
            this.pr3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pr3.Location = new System.Drawing.Point(682, 0);
            this.pr3.Name = "pr3";
            this.pr3.Size = new System.Drawing.Size(18, 26);
            this.pr3.TabIndex = 16;
            this.pr3.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pr3.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pl3
            // 
            this.pl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl3.Location = new System.Drawing.Point(0, 0);
            this.pl3.Name = "pl3";
            this.pl3.Size = new System.Drawing.Size(18, 26);
            this.pl3.TabIndex = 15;
            this.pl3.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pl3.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pmd1
            // 
            this.pmd1.Controls.Add(this.pm1);
            this.pmd1.Controls.Add(this.pr2);
            this.pmd1.Controls.Add(this.pl2);
            this.pmd1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pmd1.Location = new System.Drawing.Point(0, 29);
            this.pmd1.Name = "pmd1";
            this.pmd1.Size = new System.Drawing.Size(700, 1);
            this.pmd1.TabIndex = 13;
            // 
            // pm1
            // 
            this.pm1.BackColor = System.Drawing.Color.Black;
            this.pm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pm1.Location = new System.Drawing.Point(8, 0);
            this.pm1.Name = "pm1";
            this.pm1.Size = new System.Drawing.Size(684, 1);
            this.pm1.TabIndex = 17;
            this.pm1.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pm1.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pr2
            // 
            this.pr2.BackColor = System.Drawing.Color.Black;
            this.pr2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pr2.Location = new System.Drawing.Point(692, 0);
            this.pr2.Name = "pr2";
            this.pr2.Size = new System.Drawing.Size(8, 1);
            this.pr2.TabIndex = 16;
            this.pr2.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pr2.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pl2
            // 
            this.pl2.BackColor = System.Drawing.Color.Black;
            this.pl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl2.Location = new System.Drawing.Point(0, 0);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(8, 1);
            this.pl2.TabIndex = 15;
            this.pl2.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pl2.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.Transparent;
            this.ptop.Controls.Add(this.panel1);
            this.ptop.Controls.Add(this.pedit);
            this.ptop.Controls.Add(this.Amountlb);
            this.ptop.Controls.Add(this.rupeelb);
            this.ptop.Controls.Add(this.Categorynamelb);
            this.ptop.Controls.Add(this.categoryicon);
            this.ptop.Controls.Add(this.pr1);
            this.ptop.Controls.Add(this.pl1);
            this.ptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(700, 29);
            this.ptop.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deletelb);
            this.panel1.Controls.Add(this.Deletebt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(572, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 29);
            this.panel1.TabIndex = 22;
            // 
            // deletelb
            // 
            this.deletelb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletelb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletelb.Location = new System.Drawing.Point(32, 0);
            this.deletelb.Name = "deletelb";
            this.deletelb.Size = new System.Drawing.Size(78, 29);
            this.deletelb.TabIndex = 5;
            this.deletelb.Text = "Delete";
            this.deletelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletelb.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.deletelb.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // Deletebt
            // 
            this.Deletebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Deletebt.BackgroundImage")));
            this.Deletebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Deletebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Deletebt.Location = new System.Drawing.Point(0, 0);
            this.Deletebt.Name = "Deletebt";
            this.Deletebt.Size = new System.Drawing.Size(32, 29);
            this.Deletebt.TabIndex = 3;
            this.Deletebt.TabStop = false;
            this.Deletebt.Click += new System.EventHandler(this.OnDeleteBtClick);
            this.Deletebt.MouseEnter += new System.EventHandler(this.OnDeleteBtMouseEnter);
            this.Deletebt.MouseLeave += new System.EventHandler(this.OnDeleteBtMouseLeave);
            // 
            // pedit
            // 
            this.pedit.Controls.Add(this.editlb);
            this.pedit.Controls.Add(this.Editbt);
            this.pedit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pedit.Location = new System.Drawing.Point(482, 0);
            this.pedit.Name = "pedit";
            this.pedit.Size = new System.Drawing.Size(90, 29);
            this.pedit.TabIndex = 21;
            // 
            // editlb
            // 
            this.editlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editlb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlb.Location = new System.Drawing.Point(32, 0);
            this.editlb.Name = "editlb";
            this.editlb.Size = new System.Drawing.Size(58, 29);
            this.editlb.TabIndex = 5;
            this.editlb.Text = "Edit";
            this.editlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editlb.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.editlb.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // Editbt
            // 
            this.Editbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Editbt.BackgroundImage")));
            this.Editbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Editbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Editbt.Location = new System.Drawing.Point(0, 0);
            this.Editbt.Name = "Editbt";
            this.Editbt.Size = new System.Drawing.Size(32, 29);
            this.Editbt.TabIndex = 2;
            this.Editbt.TabStop = false;
            this.Editbt.Click += new System.EventHandler(this.OnEditBtClick);
            this.Editbt.MouseEnter += new System.EventHandler(this.OnEditBtMouseEnter);
            this.Editbt.MouseLeave += new System.EventHandler(this.OnEditBtMouseLeave);
            // 
            // Amountlb
            // 
            this.Amountlb.Dock = System.Windows.Forms.DockStyle.Left;
            this.Amountlb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlb.ForeColor = System.Drawing.Color.Black;
            this.Amountlb.Location = new System.Drawing.Point(350, 0);
            this.Amountlb.Name = "Amountlb";
            this.Amountlb.Size = new System.Drawing.Size(132, 29);
            this.Amountlb.TabIndex = 20;
            this.Amountlb.Text = "5000";
            this.Amountlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Amountlb.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.Amountlb.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // rupeelb
            // 
            this.rupeelb.Dock = System.Windows.Forms.DockStyle.Left;
            this.rupeelb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rupeelb.Location = new System.Drawing.Point(320, 0);
            this.rupeelb.Name = "rupeelb";
            this.rupeelb.Size = new System.Drawing.Size(30, 29);
            this.rupeelb.TabIndex = 19;
            this.rupeelb.Text = "₹";
            this.rupeelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rupeelb.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.rupeelb.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // Categorynamelb
            // 
            this.Categorynamelb.Dock = System.Windows.Forms.DockStyle.Left;
            this.Categorynamelb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorynamelb.ForeColor = System.Drawing.Color.Black;
            this.Categorynamelb.Location = new System.Drawing.Point(55, 0);
            this.Categorynamelb.Name = "Categorynamelb";
            this.Categorynamelb.Size = new System.Drawing.Size(265, 29);
            this.Categorynamelb.TabIndex = 18;
            this.Categorynamelb.Text = "CategoryName";
            this.Categorynamelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categorynamelb.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.Categorynamelb.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // categoryicon
            // 
            this.categoryicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryicon.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryicon.Location = new System.Drawing.Point(18, 0);
            this.categoryicon.Name = "categoryicon";
            this.categoryicon.Size = new System.Drawing.Size(37, 29);
            this.categoryicon.TabIndex = 17;
            this.categoryicon.TabStop = false;
            this.categoryicon.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.categoryicon.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pr1
            // 
            this.pr1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pr1.Location = new System.Drawing.Point(682, 0);
            this.pr1.Name = "pr1";
            this.pr1.Size = new System.Drawing.Size(18, 29);
            this.pr1.TabIndex = 15;
            this.pr1.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pr1.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // pl1
            // 
            this.pl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl1.Location = new System.Drawing.Point(0, 0);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(18, 29);
            this.pl1.TabIndex = 14;
            this.pl1.MouseEnter += new System.EventHandler(this.OnViewIndividualMouseEnter);
            this.pl1.MouseLeave += new System.EventHandler(this.OnViewIndividualMouseLeave);
            // 
            // ViewIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pback);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pt1);
            this.DoubleBuffered = true;
            this.Name = "ViewIndividual";
            this.Size = new System.Drawing.Size(700, 100);
            this.pback.ResumeLayout(false);
            this.pbottom.ResumeLayout(false);
            this.pmd2.ResumeLayout(false);
            this.pdate.ResumeLayout(false);
            this.pmd1.ResumeLayout(false);
            this.ptop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Deletebt)).EndInit();
            this.pedit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Editbt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pt1;
        private System.Windows.Forms.Panel pb1;
        private System.Windows.Forms.Panel pback;
        private System.Windows.Forms.Panel pmd1;
        private System.Windows.Forms.Panel pm1;
        private System.Windows.Forms.Panel pr2;
        private System.Windows.Forms.Panel pl2;
        private System.Windows.Forms.Panel ptop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label deletelb;
        private System.Windows.Forms.PictureBox Deletebt;
        private System.Windows.Forms.Panel pedit;
        private System.Windows.Forms.Label editlb;
        private System.Windows.Forms.PictureBox Editbt;
        private System.Windows.Forms.Label Amountlb;
        private System.Windows.Forms.Label rupeelb;
        private System.Windows.Forms.Label Categorynamelb;
        private System.Windows.Forms.PictureBox categoryicon;
        private System.Windows.Forms.Panel pr1;
        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.Panel pbottom;
        private System.Windows.Forms.Label Descriptionlb;
        private System.Windows.Forms.Panel pr5;
        private System.Windows.Forms.Panel pl5;
        private System.Windows.Forms.Panel pmd2;
        private System.Windows.Forms.Panel pm2;
        private System.Windows.Forms.Panel pr4;
        private System.Windows.Forms.Panel pl4;
        private System.Windows.Forms.Panel pdate;
        private System.Windows.Forms.Label datelb;
        private System.Windows.Forms.Panel pr3;
        private System.Windows.Forms.Panel pl3;
    }
}
