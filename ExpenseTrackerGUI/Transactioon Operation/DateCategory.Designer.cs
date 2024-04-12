namespace ExpenseTrackerGUI
{
    partial class DateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateCategory));
            this.pback = new System.Windows.Forms.Panel();
            this.amtlb = new System.Windows.Forms.Label();
            this.rupeelb = new System.Windows.Forms.Label();
            this.datalb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deletelb = new System.Windows.Forms.Label();
            this.deletebt = new System.Windows.Forms.Button();
            this.Editlb = new System.Windows.Forms.Label();
            this.editbt = new System.Windows.Forms.Button();
            this.pback.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pback
            // 
            this.pback.BackColor = System.Drawing.Color.Transparent;
            this.pback.Controls.Add(this.amtlb);
            this.pback.Controls.Add(this.rupeelb);
            this.pback.Controls.Add(this.datalb);
            this.pback.Controls.Add(this.panel1);
            this.pback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pback.Location = new System.Drawing.Point(0, 0);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(600, 25);
            this.pback.TabIndex = 1;
            this.pback.MouseEnter += new System.EventHandler(this.OnDateCategoryMouseEnter);
            this.pback.MouseLeave += new System.EventHandler(this.OnDateCategoryMouseLeave);
            // 
            // amtlb
            // 
            this.amtlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amtlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtlb.Location = new System.Drawing.Point(305, 0);
            this.amtlb.Name = "amtlb";
            this.amtlb.Size = new System.Drawing.Size(146, 25);
            this.amtlb.TabIndex = 5;
            this.amtlb.Text = "30";
            this.amtlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amtlb.MouseEnter += new System.EventHandler(this.OnDateCategoryMouseEnter);
            this.amtlb.MouseLeave += new System.EventHandler(this.OnDateCategoryMouseLeave);
            // 
            // rupeelb
            // 
            this.rupeelb.Dock = System.Windows.Forms.DockStyle.Left;
            this.rupeelb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rupeelb.Location = new System.Drawing.Point(276, 0);
            this.rupeelb.Name = "rupeelb";
            this.rupeelb.Size = new System.Drawing.Size(29, 25);
            this.rupeelb.TabIndex = 4;
            this.rupeelb.Text = "₹";
            this.rupeelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rupeelb.MouseEnter += new System.EventHandler(this.OnDateCategoryMouseEnter);
            this.rupeelb.MouseLeave += new System.EventHandler(this.OnDateCategoryMouseLeave);
            // 
            // datalb
            // 
            this.datalb.Dock = System.Windows.Forms.DockStyle.Left;
            this.datalb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.datalb.Location = new System.Drawing.Point(0, 0);
            this.datalb.Name = "datalb";
            this.datalb.Size = new System.Drawing.Size(276, 25);
            this.datalb.TabIndex = 3;
            this.datalb.Text = "January, 31, 2024";
            this.datalb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.datalb.MouseEnter += new System.EventHandler(this.OnDateCategoryMouseEnter);
            this.datalb.MouseLeave += new System.EventHandler(this.OnDateCategoryMouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Deletelb);
            this.panel1.Controls.Add(this.deletebt);
            this.panel1.Controls.Add(this.Editlb);
            this.panel1.Controls.Add(this.editbt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(451, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 25);
            this.panel1.TabIndex = 2;
            // 
            // Deletelb
            // 
            this.Deletelb.Dock = System.Windows.Forms.DockStyle.Left;
            this.Deletelb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletelb.Location = new System.Drawing.Point(101, 0);
            this.Deletelb.Name = "Deletelb";
            this.Deletelb.Size = new System.Drawing.Size(49, 25);
            this.Deletelb.TabIndex = 6;
            this.Deletelb.Text = "Delete";
            this.Deletelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deletelb.MouseEnter += new System.EventHandler(this.OnDateCategoryMouseEnter);
            this.Deletelb.MouseLeave += new System.EventHandler(this.OnDateCategoryMouseLeave);
            // 
            // deletebt
            // 
            this.deletebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebt.BackgroundImage")));
            this.deletebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.deletebt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebt.FlatAppearance.BorderSize = 0;
            this.deletebt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deletebt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deletebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebt.Location = new System.Drawing.Point(75, 0);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(26, 25);
            this.deletebt.TabIndex = 5;
            this.deletebt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deletebt.UseVisualStyleBackColor = true;
            this.deletebt.Click += new System.EventHandler(this.OnDeleteBtClick);
            this.deletebt.MouseEnter += new System.EventHandler(this.OnDeleteBtMouseEnter);
            this.deletebt.MouseLeave += new System.EventHandler(this.OnDeletebtMouseLeave);
            // 
            // Editlb
            // 
            this.Editlb.Dock = System.Windows.Forms.DockStyle.Left;
            this.Editlb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editlb.Location = new System.Drawing.Point(26, 0);
            this.Editlb.Name = "Editlb";
            this.Editlb.Size = new System.Drawing.Size(49, 25);
            this.Editlb.TabIndex = 4;
            this.Editlb.Text = "Edit";
            this.Editlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Editlb.MouseEnter += new System.EventHandler(this.OnDateCategoryMouseEnter);
            this.Editlb.MouseLeave += new System.EventHandler(this.OnDateCategoryMouseLeave);
            // 
            // editbt
            // 
            this.editbt.BackColor = System.Drawing.Color.Transparent;
            this.editbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editbt.BackgroundImage")));
            this.editbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.editbt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editbt.FlatAppearance.BorderSize = 0;
            this.editbt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editbt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbt.Location = new System.Drawing.Point(0, 0);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(26, 25);
            this.editbt.TabIndex = 3;
            this.editbt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editbt.UseVisualStyleBackColor = false;
            this.editbt.Click += new System.EventHandler(this.OnEditBtClick);
            this.editbt.MouseEnter += new System.EventHandler(this.OnEditbtMouseEnter);
            this.editbt.MouseLeave += new System.EventHandler(this.OnEditBtMouseLeave);
            // 
            // DateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pback);
            this.Name = "DateCategory";
            this.Size = new System.Drawing.Size(600, 25);
            this.pback.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pback;
        private System.Windows.Forms.Label datalb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Deletelb;
        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.Label Editlb;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Label amtlb;
        private System.Windows.Forms.Label rupeelb;
    }
}
