namespace ExpenseTrackerGUI
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.pback = new System.Windows.Forms.Panel();
            this.pdeleteshow = new System.Windows.Forms.Panel();
            this.Yesbt = new System.Windows.Forms.Button();
            this.Nobt = new System.Windows.Forms.Button();
            this.ltext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lhead = new System.Windows.Forms.Label();
            this.logopb = new System.Windows.Forms.PictureBox();
            this.pback.SuspendLayout();
            this.pdeleteshow.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            this.SuspendLayout();
            // 
            // pback
            // 
            this.pback.BackColor = System.Drawing.Color.Transparent;
            this.pback.Controls.Add(this.pdeleteshow);
            this.pback.Controls.Add(this.panel2);
            this.pback.Controls.Add(this.panel1);
            this.pback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pback.Location = new System.Drawing.Point(0, 0);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(452, 267);
            this.pback.TabIndex = 16;
            // 
            // pdeleteshow
            // 
            this.pdeleteshow.BackColor = System.Drawing.Color.Transparent;
            this.pdeleteshow.Controls.Add(this.Yesbt);
            this.pdeleteshow.Controls.Add(this.Nobt);
            this.pdeleteshow.Controls.Add(this.ltext);
            this.pdeleteshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdeleteshow.Location = new System.Drawing.Point(0, 51);
            this.pdeleteshow.Name = "pdeleteshow";
            this.pdeleteshow.Size = new System.Drawing.Size(452, 216);
            this.pdeleteshow.TabIndex = 18;
            this.pdeleteshow.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDeleteShowPaint);
            // 
            // Yesbt
            // 
            this.Yesbt.BackColor = System.Drawing.Color.GhostWhite;
            this.Yesbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yesbt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.Yesbt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Yesbt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Yesbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yesbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesbt.Location = new System.Drawing.Point(263, 137);
            this.Yesbt.Name = "Yesbt";
            this.Yesbt.Size = new System.Drawing.Size(75, 34);
            this.Yesbt.TabIndex = 2;
            this.Yesbt.Text = "Yes";
            this.Yesbt.UseVisualStyleBackColor = false;
            this.Yesbt.Click += new System.EventHandler(this.OnYesBtClick);
            // 
            // Nobt
            // 
            this.Nobt.BackColor = System.Drawing.Color.GhostWhite;
            this.Nobt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nobt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.Nobt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Nobt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Nobt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nobt.Location = new System.Drawing.Point(95, 137);
            this.Nobt.Name = "Nobt";
            this.Nobt.Size = new System.Drawing.Size(75, 34);
            this.Nobt.TabIndex = 1;
            this.Nobt.Text = "No";
            this.Nobt.UseVisualStyleBackColor = false;
            this.Nobt.Click += new System.EventHandler(this.OnNoBtClick);
            // 
            // ltext
            // 
            this.ltext.BackColor = System.Drawing.Color.Transparent;
            this.ltext.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltext.ForeColor = System.Drawing.Color.DarkBlue;
            this.ltext.Location = new System.Drawing.Point(36, 28);
            this.ltext.Name = "ltext";
            this.ltext.Size = new System.Drawing.Size(362, 93);
            this.ltext.TabIndex = 0;
            this.ltext.Text = "Do You Want to Delete Transaction ?";
            this.ltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 6);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lhead);
            this.panel1.Controls.Add(this.logopb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 45);
            this.panel1.TabIndex = 16;
            // 
            // lhead
            // 
            this.lhead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lhead.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhead.ForeColor = System.Drawing.Color.White;
            this.lhead.Location = new System.Drawing.Point(42, 0);
            this.lhead.Name = "lhead";
            this.lhead.Size = new System.Drawing.Size(410, 45);
            this.lhead.TabIndex = 1;
            this.lhead.Text = "Delete Transaction";
            this.lhead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logopb
            // 
            this.logopb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logopb.BackgroundImage")));
            this.logopb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logopb.Dock = System.Windows.Forms.DockStyle.Left;
            this.logopb.Location = new System.Drawing.Point(0, 0);
            this.logopb.Name = "logopb";
            this.logopb.Size = new System.Drawing.Size(42, 45);
            this.logopb.TabIndex = 0;
            this.logopb.TabStop = false;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(452, 267);
            this.Controls.Add(this.pback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteView";
            this.Load += new System.EventHandler(this.OnNotificationLoad);
            this.pback.ResumeLayout(false);
            this.pdeleteshow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pback;
        private System.Windows.Forms.Panel pdeleteshow;
        private System.Windows.Forms.Button Yesbt;
        private System.Windows.Forms.Button Nobt;
        private System.Windows.Forms.Label ltext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lhead;
        private System.Windows.Forms.PictureBox logopb;
    }
}