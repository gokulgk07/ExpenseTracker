namespace ExpenseTrackerGUI
{
    partial class ViewTransaction
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
            this.rupeelb = new System.Windows.Forms.Label();
            this.pcategory = new System.Windows.Forms.Panel();
            this.monthlb = new System.Windows.Forms.Label();
            this.daylb = new System.Windows.Forms.Label();
            this.datelb = new System.Windows.Forms.Label();
            this.pback.SuspendLayout();
            this.pbottom.SuspendLayout();
            this.ptop.SuspendLayout();
            this.pamount.SuspendLayout();
            this.pcategory.SuspendLayout();
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
            this.pback.TabIndex = 3;
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
            this.pamount.Controls.Add(this.rupeelb);
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
            this.amountlb.ForeColor = System.Drawing.Color.DarkBlue;
            this.amountlb.Location = new System.Drawing.Point(29, 0);
            this.amountlb.Name = "amountlb";
            this.amountlb.Size = new System.Drawing.Size(109, 45);
            this.amountlb.TabIndex = 3;
            this.amountlb.Text = "500";
            this.amountlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rupeelb
            // 
            this.rupeelb.Dock = System.Windows.Forms.DockStyle.Left;
            this.rupeelb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rupeelb.ForeColor = System.Drawing.Color.DarkBlue;
            this.rupeelb.Location = new System.Drawing.Point(0, 0);
            this.rupeelb.Name = "rupeelb";
            this.rupeelb.Size = new System.Drawing.Size(29, 45);
            this.rupeelb.TabIndex = 1;
            this.rupeelb.Text = "₹";
            this.rupeelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcategory
            // 
            this.pcategory.Controls.Add(this.monthlb);
            this.pcategory.Controls.Add(this.daylb);
            this.pcategory.Controls.Add(this.datelb);
            this.pcategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcategory.Location = new System.Drawing.Point(0, 0);
            this.pcategory.Name = "pcategory";
            this.pcategory.Size = new System.Drawing.Size(562, 45);
            this.pcategory.TabIndex = 0;
            // 
            // monthlb
            // 
            this.monthlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlb.ForeColor = System.Drawing.Color.Black;
            this.monthlb.Location = new System.Drawing.Point(71, 26);
            this.monthlb.Name = "monthlb";
            this.monthlb.Size = new System.Drawing.Size(491, 19);
            this.monthlb.TabIndex = 2;
            this.monthlb.Text = "June, 2024";
            this.monthlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daylb
            // 
            this.daylb.Dock = System.Windows.Forms.DockStyle.Top;
            this.daylb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylb.ForeColor = System.Drawing.Color.Black;
            this.daylb.Location = new System.Drawing.Point(71, 0);
            this.daylb.Name = "daylb";
            this.daylb.Size = new System.Drawing.Size(491, 26);
            this.daylb.TabIndex = 1;
            this.daylb.Text = "Monday";
            this.daylb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datelb
            // 
            this.datelb.Dock = System.Windows.Forms.DockStyle.Left;
            this.datelb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelb.ForeColor = System.Drawing.Color.Black;
            this.datelb.Location = new System.Drawing.Point(0, 0);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(71, 45);
            this.datelb.TabIndex = 0;
            this.datelb.Text = "25";
            this.datelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pback);
            this.Name = "ViewTransaction";
            this.Size = new System.Drawing.Size(700, 100);
            this.Load += new System.EventHandler(this.OnViewTransactionLoad);
            this.pback.ResumeLayout(false);
            this.pbottom.ResumeLayout(false);
            this.ptop.ResumeLayout(false);
            this.pamount.ResumeLayout(false);
            this.pcategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pback;
        private System.Windows.Forms.Panel pbottom;
        private System.Windows.Forms.Panel pmiddle;
        private System.Windows.Forms.Panel ptop;
        private System.Windows.Forms.Panel pamount;
        private System.Windows.Forms.Label amountlb;
        private System.Windows.Forms.Label rupeelb;
        private System.Windows.Forms.Panel pcategory;
        private System.Windows.Forms.Label monthlb;
        private System.Windows.Forms.Label daylb;
        private System.Windows.Forms.Label datelb;
        private System.Windows.Forms.Panel padd;
        private System.Windows.Forms.Panel pup;
        private System.Windows.Forms.Panel pdown;
        private System.Windows.Forms.Panel pright;
        private System.Windows.Forms.Panel pleft;
    }
}
