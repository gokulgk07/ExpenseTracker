namespace ExpenseTrackerGUI
{
    partial class ViewCategory
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
            this.pbottom = new System.Windows.Forms.Panel();
            this.padd = new System.Windows.Forms.Panel();
            this.pup = new System.Windows.Forms.Panel();
            this.pdown = new System.Windows.Forms.Panel();
            this.pright = new System.Windows.Forms.Panel();
            this.pleft = new System.Windows.Forms.Panel();
            this.pmiddle = new System.Windows.Forms.Panel();
            this.ptop = new System.Windows.Forms.Panel();
            this.pamount = new System.Windows.Forms.Panel();
            this.amountlb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcategory = new System.Windows.Forms.Panel();
            this.transactioncountlb = new System.Windows.Forms.Label();
            this.Categorynamelb = new System.Windows.Forms.Label();
            this.pimg = new System.Windows.Forms.Panel();
            this.categoryicon = new System.Windows.Forms.PictureBox();
            this.pimgtop = new System.Windows.Forms.Panel();
            this.pcorner = new System.Windows.Forms.Panel();
            this.pback.SuspendLayout();
            this.pbottom.SuspendLayout();
            this.ptop.SuspendLayout();
            this.pamount.SuspendLayout();
            this.pcategory.SuspendLayout();
            this.pimg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryicon)).BeginInit();
            this.SuspendLayout();
            // 
            // pback
            // 
            this.pback.Controls.Add(this.pbottom);
            this.pback.Controls.Add(this.pmiddle);
            this.pback.Controls.Add(this.ptop);
            this.pback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pback.Location = new System.Drawing.Point(0, 0);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(700, 100);
            this.pback.TabIndex = 1;
            // 
            // pbottom
            // 
            this.pbottom.Controls.Add(this.padd);
            this.pbottom.Controls.Add(this.pup);
            this.pbottom.Controls.Add(this.pdown);
            this.pbottom.Controls.Add(this.pright);
            this.pbottom.Controls.Add(this.pleft);
            this.pbottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbottom.Location = new System.Drawing.Point(0, 47);
            this.pbottom.Name = "pbottom";
            this.pbottom.Size = new System.Drawing.Size(700, 53);
            this.pbottom.TabIndex = 3;
            // 
            // padd
            // 
            this.padd.AutoScroll = true;
            this.padd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padd.Location = new System.Drawing.Point(40, 10);
            this.padd.Name = "padd";
            this.padd.Size = new System.Drawing.Size(620, 33);
            this.padd.TabIndex = 5;
            // 
            // pup
            // 
            this.pup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pup.Location = new System.Drawing.Point(40, 0);
            this.pup.Name = "pup";
            this.pup.Size = new System.Drawing.Size(620, 10);
            this.pup.TabIndex = 4;
            // 
            // pdown
            // 
            this.pdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pdown.Location = new System.Drawing.Point(40, 43);
            this.pdown.Name = "pdown";
            this.pdown.Size = new System.Drawing.Size(620, 10);
            this.pdown.TabIndex = 3;
            // 
            // pright
            // 
            this.pright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pright.Location = new System.Drawing.Point(660, 0);
            this.pright.Name = "pright";
            this.pright.Size = new System.Drawing.Size(40, 53);
            this.pright.TabIndex = 2;
            // 
            // pleft
            // 
            this.pleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pleft.Location = new System.Drawing.Point(0, 0);
            this.pleft.Name = "pleft";
            this.pleft.Size = new System.Drawing.Size(40, 53);
            this.pleft.TabIndex = 1;
            // 
            // pmiddle
            // 
            this.pmiddle.BackColor = System.Drawing.Color.Black;
            this.pmiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pmiddle.Location = new System.Drawing.Point(0, 45);
            this.pmiddle.Name = "pmiddle";
            this.pmiddle.Size = new System.Drawing.Size(700, 2);
            this.pmiddle.TabIndex = 2;
            // 
            // ptop
            // 
            this.ptop.Controls.Add(this.pamount);
            this.ptop.Controls.Add(this.pcategory);
            this.ptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(700, 45);
            this.ptop.TabIndex = 0;
            // 
            // pamount
            // 
            this.pamount.Controls.Add(this.amountlb);
            this.pamount.Controls.Add(this.label2);
            this.pamount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pamount.Location = new System.Drawing.Point(562, 0);
            this.pamount.Name = "pamount";
            this.pamount.Size = new System.Drawing.Size(138, 45);
            this.pamount.TabIndex = 1;
            // 
            // amountlb
            // 
            this.amountlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountlb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlb.Location = new System.Drawing.Point(29, 0);
            this.amountlb.Name = "amountlb";
            this.amountlb.Size = new System.Drawing.Size(109, 45);
            this.amountlb.TabIndex = 3;
            this.amountlb.Text = "500";
            this.amountlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "₹";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcategory
            // 
            this.pcategory.Controls.Add(this.transactioncountlb);
            this.pcategory.Controls.Add(this.Categorynamelb);
            this.pcategory.Controls.Add(this.pimg);
            this.pcategory.Controls.Add(this.pcorner);
            this.pcategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcategory.Location = new System.Drawing.Point(0, 0);
            this.pcategory.Name = "pcategory";
            this.pcategory.Size = new System.Drawing.Size(562, 45);
            this.pcategory.TabIndex = 0;
            // 
            // transactioncountlb
            // 
            this.transactioncountlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactioncountlb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactioncountlb.ForeColor = System.Drawing.Color.DarkBlue;
            this.transactioncountlb.Location = new System.Drawing.Point(68, 28);
            this.transactioncountlb.Name = "transactioncountlb";
            this.transactioncountlb.Size = new System.Drawing.Size(494, 17);
            this.transactioncountlb.TabIndex = 8;
            this.transactioncountlb.Text = "(Transaction count)";
            // 
            // Categorynamelb
            // 
            this.Categorynamelb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Categorynamelb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorynamelb.ForeColor = System.Drawing.Color.Black;
            this.Categorynamelb.Location = new System.Drawing.Point(68, 0);
            this.Categorynamelb.Name = "Categorynamelb";
            this.Categorynamelb.Size = new System.Drawing.Size(494, 28);
            this.Categorynamelb.TabIndex = 7;
            this.Categorynamelb.Text = "Food";
            this.Categorynamelb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pimg
            // 
            this.pimg.Controls.Add(this.categoryicon);
            this.pimg.Controls.Add(this.pimgtop);
            this.pimg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pimg.Location = new System.Drawing.Point(29, 0);
            this.pimg.Name = "pimg";
            this.pimg.Size = new System.Drawing.Size(39, 45);
            this.pimg.TabIndex = 6;
            // 
            // categoryicon
            // 
            this.categoryicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryicon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryicon.Location = new System.Drawing.Point(0, 14);
            this.categoryicon.Name = "categoryicon";
            this.categoryicon.Size = new System.Drawing.Size(39, 31);
            this.categoryicon.TabIndex = 4;
            this.categoryicon.TabStop = false;
            // 
            // pimgtop
            // 
            this.pimgtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pimgtop.Location = new System.Drawing.Point(0, 0);
            this.pimgtop.Name = "pimgtop";
            this.pimgtop.Size = new System.Drawing.Size(39, 14);
            this.pimgtop.TabIndex = 0;
            // 
            // pcorner
            // 
            this.pcorner.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcorner.Location = new System.Drawing.Point(0, 0);
            this.pcorner.Name = "pcorner";
            this.pcorner.Size = new System.Drawing.Size(29, 45);
            this.pcorner.TabIndex = 2;
            // 
            // ViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pback);
            this.Name = "ViewCategory";
            this.Size = new System.Drawing.Size(700, 100);
            this.Load += new System.EventHandler(this.OnViewCategoryLoad);
            this.pback.ResumeLayout(false);
            this.pbottom.ResumeLayout(false);
            this.ptop.ResumeLayout(false);
            this.pamount.ResumeLayout(false);
            this.pcategory.ResumeLayout(false);
            this.pimg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pback;
        private System.Windows.Forms.Panel ptop;
        private System.Windows.Forms.Panel pamount;
        private System.Windows.Forms.Label amountlb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pcategory;
        private System.Windows.Forms.Panel pbottom;
        private System.Windows.Forms.Panel pmiddle;
        private System.Windows.Forms.Panel pcorner;
        private System.Windows.Forms.Label transactioncountlb;
        private System.Windows.Forms.Label Categorynamelb;
        private System.Windows.Forms.Panel pimg;
        private System.Windows.Forms.PictureBox categoryicon;
        private System.Windows.Forms.Panel pimgtop;
        private System.Windows.Forms.Panel padd;
        private System.Windows.Forms.Panel pup;
        private System.Windows.Forms.Panel pdown;
        private System.Windows.Forms.Panel pright;
        private System.Windows.Forms.Panel pleft;
    }
}
