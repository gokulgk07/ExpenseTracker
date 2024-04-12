namespace ExpenseTrackerGUI
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.pback = new System.Windows.Forms.Panel();
            this.p5 = new System.Windows.Forms.Panel();
            this.backbt = new System.Windows.Forms.Button();
            this.savebt = new System.Windows.Forms.Button();
            this.zero1bt = new System.Windows.Forms.Button();
            this.dotbt = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Panel();
            this.equaltobt = new System.Windows.Forms.Button();
            this.threebt = new System.Windows.Forms.Button();
            this.twobt = new System.Windows.Forms.Button();
            this.onebt = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Panel();
            this.addbt = new System.Windows.Forms.Button();
            this.sixbt = new System.Windows.Forms.Button();
            this.fivebt = new System.Windows.Forms.Button();
            this.fourbt = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.subtractbt = new System.Windows.Forms.Button();
            this.ninebt = new System.Windows.Forms.Button();
            this.eightbt = new System.Windows.Forms.Button();
            this.sevenbt = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.deletebt = new System.Windows.Forms.Button();
            this.multiplybt = new System.Windows.Forms.Button();
            this.dividebt = new System.Windows.Forms.Button();
            this.clearbt = new System.Windows.Forms.Button();
            this.pdata = new System.Windows.Forms.Panel();
            this.datatb = new System.Windows.Forms.TextBox();
            this.rupeelb = new System.Windows.Forms.Label();
            this.pright = new System.Windows.Forms.Panel();
            this.pleft = new System.Windows.Forms.Panel();
            this.pbottom = new System.Windows.Forms.Panel();
            this.ptop = new System.Windows.Forms.Panel();
            this.calctimer = new System.Windows.Forms.Timer(this.components);
            this.pback.SuspendLayout();
            this.p5.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.pdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // pback
            // 
            this.pback.BackColor = System.Drawing.Color.Transparent;
            this.pback.Controls.Add(this.p5);
            this.pback.Controls.Add(this.p4);
            this.pback.Controls.Add(this.p3);
            this.pback.Controls.Add(this.p2);
            this.pback.Controls.Add(this.p1);
            this.pback.Controls.Add(this.pdata);
            this.pback.Controls.Add(this.pright);
            this.pback.Controls.Add(this.pleft);
            this.pback.Controls.Add(this.pbottom);
            this.pback.Controls.Add(this.ptop);
            this.pback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pback.Location = new System.Drawing.Point(0, 0);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(272, 261);
            this.pback.TabIndex = 0;
            // 
            // p5
            // 
            this.p5.Controls.Add(this.backbt);
            this.p5.Controls.Add(this.savebt);
            this.p5.Controls.Add(this.zero1bt);
            this.p5.Controls.Add(this.dotbt);
            this.p5.Dock = System.Windows.Forms.DockStyle.Top;
            this.p5.Location = new System.Drawing.Point(10, 211);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(252, 40);
            this.p5.TabIndex = 13;
            // 
            // backbt
            // 
            this.backbt.BackColor = System.Drawing.Color.GhostWhite;
            this.backbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbt.BackgroundImage")));
            this.backbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbt.Location = new System.Drawing.Point(189, 0);
            this.backbt.Name = "backbt";
            this.backbt.Size = new System.Drawing.Size(63, 40);
            this.backbt.TabIndex = 4;
            this.backbt.UseVisualStyleBackColor = false;
            this.backbt.Click += new System.EventHandler(this.OnBackBtClick);
            // 
            // savebt
            // 
            this.savebt.BackColor = System.Drawing.Color.GhostWhite;
            this.savebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebt.BackgroundImage")));
            this.savebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.savebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebt.Location = new System.Drawing.Point(126, 0);
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(63, 40);
            this.savebt.TabIndex = 3;
            this.savebt.UseVisualStyleBackColor = false;
            this.savebt.Click += new System.EventHandler(this.OnSaveBtClick);
            // 
            // zero1bt
            // 
            this.zero1bt.BackColor = System.Drawing.Color.GhostWhite;
            this.zero1bt.Dock = System.Windows.Forms.DockStyle.Left;
            this.zero1bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero1bt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero1bt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.zero1bt.Location = new System.Drawing.Point(63, 0);
            this.zero1bt.Name = "zero1bt";
            this.zero1bt.Size = new System.Drawing.Size(63, 40);
            this.zero1bt.TabIndex = 2;
            this.zero1bt.Text = "0";
            this.zero1bt.UseVisualStyleBackColor = false;
            this.zero1bt.Click += new System.EventHandler(this.OnZeroBtClick);
            // 
            // dotbt
            // 
            this.dotbt.BackColor = System.Drawing.Color.GhostWhite;
            this.dotbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.dotbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotbt.Location = new System.Drawing.Point(0, 0);
            this.dotbt.Name = "dotbt";
            this.dotbt.Size = new System.Drawing.Size(63, 40);
            this.dotbt.TabIndex = 1;
            this.dotbt.Text = ".";
            this.dotbt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dotbt.UseVisualStyleBackColor = false;
            this.dotbt.Click += new System.EventHandler(this.OnDotBtClick);
            // 
            // p4
            // 
            this.p4.Controls.Add(this.equaltobt);
            this.p4.Controls.Add(this.threebt);
            this.p4.Controls.Add(this.twobt);
            this.p4.Controls.Add(this.onebt);
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Location = new System.Drawing.Point(10, 171);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(252, 40);
            this.p4.TabIndex = 12;
            // 
            // equaltobt
            // 
            this.equaltobt.BackColor = System.Drawing.Color.GhostWhite;
            this.equaltobt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equaltobt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equaltobt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equaltobt.Location = new System.Drawing.Point(189, 0);
            this.equaltobt.Name = "equaltobt";
            this.equaltobt.Size = new System.Drawing.Size(63, 40);
            this.equaltobt.TabIndex = 4;
            this.equaltobt.Text = "=";
            this.equaltobt.UseVisualStyleBackColor = false;
            this.equaltobt.Click += new System.EventHandler(this.OnEqualToBtClick);
            // 
            // threebt
            // 
            this.threebt.BackColor = System.Drawing.Color.GhostWhite;
            this.threebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.threebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threebt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threebt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.threebt.Location = new System.Drawing.Point(126, 0);
            this.threebt.Name = "threebt";
            this.threebt.Size = new System.Drawing.Size(63, 40);
            this.threebt.TabIndex = 3;
            this.threebt.Text = "3";
            this.threebt.UseVisualStyleBackColor = false;
            this.threebt.Click += new System.EventHandler(this.OnThreeBtClick);
            // 
            // twobt
            // 
            this.twobt.BackColor = System.Drawing.Color.GhostWhite;
            this.twobt.Dock = System.Windows.Forms.DockStyle.Left;
            this.twobt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twobt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twobt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.twobt.Location = new System.Drawing.Point(63, 0);
            this.twobt.Name = "twobt";
            this.twobt.Size = new System.Drawing.Size(63, 40);
            this.twobt.TabIndex = 2;
            this.twobt.Text = "2";
            this.twobt.UseVisualStyleBackColor = false;
            this.twobt.Click += new System.EventHandler(this.OnTwoBtClick);
            // 
            // onebt
            // 
            this.onebt.BackColor = System.Drawing.Color.GhostWhite;
            this.onebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.onebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onebt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onebt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.onebt.Location = new System.Drawing.Point(0, 0);
            this.onebt.Name = "onebt";
            this.onebt.Size = new System.Drawing.Size(63, 40);
            this.onebt.TabIndex = 1;
            this.onebt.Text = "1";
            this.onebt.UseVisualStyleBackColor = false;
            this.onebt.Click += new System.EventHandler(this.OnOneBtClick);
            // 
            // p3
            // 
            this.p3.Controls.Add(this.addbt);
            this.p3.Controls.Add(this.sixbt);
            this.p3.Controls.Add(this.fivebt);
            this.p3.Controls.Add(this.fourbt);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(10, 131);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(252, 40);
            this.p3.TabIndex = 11;
            // 
            // addbt
            // 
            this.addbt.BackColor = System.Drawing.Color.GhostWhite;
            this.addbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbt.Location = new System.Drawing.Point(189, 0);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(63, 40);
            this.addbt.TabIndex = 4;
            this.addbt.Text = "+";
            this.addbt.UseVisualStyleBackColor = false;
            this.addbt.Click += new System.EventHandler(this.OnAddBtClick);
            // 
            // sixbt
            // 
            this.sixbt.BackColor = System.Drawing.Color.GhostWhite;
            this.sixbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.sixbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixbt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sixbt.Location = new System.Drawing.Point(126, 0);
            this.sixbt.Name = "sixbt";
            this.sixbt.Size = new System.Drawing.Size(63, 40);
            this.sixbt.TabIndex = 3;
            this.sixbt.Text = "6";
            this.sixbt.UseVisualStyleBackColor = false;
            this.sixbt.Click += new System.EventHandler(this.OnSixBtClick);
            // 
            // fivebt
            // 
            this.fivebt.BackColor = System.Drawing.Color.GhostWhite;
            this.fivebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.fivebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fivebt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivebt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fivebt.Location = new System.Drawing.Point(63, 0);
            this.fivebt.Name = "fivebt";
            this.fivebt.Size = new System.Drawing.Size(63, 40);
            this.fivebt.TabIndex = 2;
            this.fivebt.Text = "5";
            this.fivebt.UseVisualStyleBackColor = false;
            this.fivebt.Click += new System.EventHandler(this.OnFiveBtClick);
            // 
            // fourbt
            // 
            this.fourbt.BackColor = System.Drawing.Color.GhostWhite;
            this.fourbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.fourbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourbt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fourbt.Location = new System.Drawing.Point(0, 0);
            this.fourbt.Name = "fourbt";
            this.fourbt.Size = new System.Drawing.Size(63, 40);
            this.fourbt.TabIndex = 1;
            this.fourbt.Text = "4";
            this.fourbt.UseVisualStyleBackColor = false;
            this.fourbt.Click += new System.EventHandler(this.OnFourBtClick);
            // 
            // p2
            // 
            this.p2.Controls.Add(this.subtractbt);
            this.p2.Controls.Add(this.ninebt);
            this.p2.Controls.Add(this.eightbt);
            this.p2.Controls.Add(this.sevenbt);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(10, 91);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(252, 40);
            this.p2.TabIndex = 10;
            // 
            // subtractbt
            // 
            this.subtractbt.BackColor = System.Drawing.Color.GhostWhite;
            this.subtractbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractbt.Location = new System.Drawing.Point(189, 0);
            this.subtractbt.Name = "subtractbt";
            this.subtractbt.Size = new System.Drawing.Size(63, 40);
            this.subtractbt.TabIndex = 4;
            this.subtractbt.Text = "-";
            this.subtractbt.UseVisualStyleBackColor = false;
            this.subtractbt.Click += new System.EventHandler(this.OnSubtractBtClick);
            // 
            // ninebt
            // 
            this.ninebt.BackColor = System.Drawing.Color.GhostWhite;
            this.ninebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.ninebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ninebt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninebt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ninebt.Location = new System.Drawing.Point(126, 0);
            this.ninebt.Name = "ninebt";
            this.ninebt.Size = new System.Drawing.Size(63, 40);
            this.ninebt.TabIndex = 3;
            this.ninebt.Text = "9";
            this.ninebt.UseVisualStyleBackColor = false;
            this.ninebt.Click += new System.EventHandler(this.OnNineBtClick);
            // 
            // eightbt
            // 
            this.eightbt.BackColor = System.Drawing.Color.GhostWhite;
            this.eightbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.eightbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightbt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.eightbt.Location = new System.Drawing.Point(63, 0);
            this.eightbt.Name = "eightbt";
            this.eightbt.Size = new System.Drawing.Size(63, 40);
            this.eightbt.TabIndex = 2;
            this.eightbt.Text = "8";
            this.eightbt.UseVisualStyleBackColor = false;
            this.eightbt.Click += new System.EventHandler(this.OnEightBtClick);
            // 
            // sevenbt
            // 
            this.sevenbt.BackColor = System.Drawing.Color.GhostWhite;
            this.sevenbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.sevenbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenbt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sevenbt.Location = new System.Drawing.Point(0, 0);
            this.sevenbt.Name = "sevenbt";
            this.sevenbt.Size = new System.Drawing.Size(63, 40);
            this.sevenbt.TabIndex = 1;
            this.sevenbt.Text = "7";
            this.sevenbt.UseVisualStyleBackColor = false;
            this.sevenbt.Click += new System.EventHandler(this.OnSevenBtClick);
            // 
            // p1
            // 
            this.p1.Controls.Add(this.deletebt);
            this.p1.Controls.Add(this.multiplybt);
            this.p1.Controls.Add(this.dividebt);
            this.p1.Controls.Add(this.clearbt);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(10, 51);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(252, 40);
            this.p1.TabIndex = 9;
            // 
            // deletebt
            // 
            this.deletebt.BackColor = System.Drawing.Color.GhostWhite;
            this.deletebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebt.BackgroundImage")));
            this.deletebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebt.ForeColor = System.Drawing.Color.Black;
            this.deletebt.Location = new System.Drawing.Point(189, 0);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(63, 40);
            this.deletebt.TabIndex = 3;
            this.deletebt.UseVisualStyleBackColor = false;
            this.deletebt.Click += new System.EventHandler(this.OnDeleteBtClick);
            // 
            // multiplybt
            // 
            this.multiplybt.BackColor = System.Drawing.Color.GhostWhite;
            this.multiplybt.Dock = System.Windows.Forms.DockStyle.Left;
            this.multiplybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplybt.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplybt.Location = new System.Drawing.Point(126, 0);
            this.multiplybt.Name = "multiplybt";
            this.multiplybt.Size = new System.Drawing.Size(63, 40);
            this.multiplybt.TabIndex = 2;
            this.multiplybt.Text = "*";
            this.multiplybt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplybt.UseVisualStyleBackColor = false;
            this.multiplybt.Click += new System.EventHandler(this.OnMultiplyBtClick);
            // 
            // dividebt
            // 
            this.dividebt.BackColor = System.Drawing.Color.GhostWhite;
            this.dividebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.dividebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividebt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebt.Location = new System.Drawing.Point(63, 0);
            this.dividebt.Name = "dividebt";
            this.dividebt.Size = new System.Drawing.Size(63, 40);
            this.dividebt.TabIndex = 1;
            this.dividebt.Text = "/";
            this.dividebt.UseVisualStyleBackColor = false;
            this.dividebt.Click += new System.EventHandler(this.OnDivideBtClick);
            // 
            // clearbt
            // 
            this.clearbt.BackColor = System.Drawing.Color.GhostWhite;
            this.clearbt.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbt.Location = new System.Drawing.Point(0, 0);
            this.clearbt.Name = "clearbt";
            this.clearbt.Size = new System.Drawing.Size(63, 40);
            this.clearbt.TabIndex = 0;
            this.clearbt.Text = "C";
            this.clearbt.UseVisualStyleBackColor = false;
            this.clearbt.Click += new System.EventHandler(this.OnClearBtClick);
            // 
            // pdata
            // 
            this.pdata.Controls.Add(this.datatb);
            this.pdata.Controls.Add(this.rupeelb);
            this.pdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.pdata.Location = new System.Drawing.Point(10, 10);
            this.pdata.Name = "pdata";
            this.pdata.Size = new System.Drawing.Size(252, 41);
            this.pdata.TabIndex = 4;
            // 
            // datatb
            // 
            this.datatb.BackColor = System.Drawing.Color.White;
            this.datatb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datatb.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatb.Location = new System.Drawing.Point(63, 0);
            this.datatb.MaxLength = 10;
            this.datatb.Name = "datatb";
            this.datatb.Size = new System.Drawing.Size(189, 41);
            this.datatb.TabIndex = 1;
            this.datatb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnDataBtKeyPress);
            // 
            // rupeelb
            // 
            this.rupeelb.BackColor = System.Drawing.Color.GhostWhite;
            this.rupeelb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rupeelb.Dock = System.Windows.Forms.DockStyle.Left;
            this.rupeelb.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rupeelb.Location = new System.Drawing.Point(0, 0);
            this.rupeelb.Name = "rupeelb";
            this.rupeelb.Size = new System.Drawing.Size(63, 41);
            this.rupeelb.TabIndex = 0;
            this.rupeelb.Text = "₹";
            this.rupeelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pright
            // 
            this.pright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pright.Location = new System.Drawing.Point(262, 10);
            this.pright.Name = "pright";
            this.pright.Size = new System.Drawing.Size(10, 241);
            this.pright.TabIndex = 3;
            // 
            // pleft
            // 
            this.pleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pleft.Location = new System.Drawing.Point(0, 10);
            this.pleft.Name = "pleft";
            this.pleft.Size = new System.Drawing.Size(10, 241);
            this.pleft.TabIndex = 2;
            // 
            // pbottom
            // 
            this.pbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbottom.Location = new System.Drawing.Point(0, 251);
            this.pbottom.Name = "pbottom";
            this.pbottom.Size = new System.Drawing.Size(272, 10);
            this.pbottom.TabIndex = 1;
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(272, 10);
            this.ptop.TabIndex = 0;
            // 
            // calctimer
            // 
            this.calctimer.Tick += new System.EventHandler(this.OnTimerStart);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pback);
            this.Name = "Calculator";
            this.Size = new System.Drawing.Size(272, 261);
            this.Load += new System.EventHandler(this.OnCalculatorLoad);
            this.pback.ResumeLayout(false);
            this.p5.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.pdata.ResumeLayout(false);
            this.pdata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pback;
        private System.Windows.Forms.Panel pright;
        private System.Windows.Forms.Panel pleft;
        private System.Windows.Forms.Panel pbottom;
        private System.Windows.Forms.Panel ptop;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.Button backbt;
        private System.Windows.Forms.Button savebt;
        private System.Windows.Forms.Button zero1bt;
        private System.Windows.Forms.Button dotbt;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Button equaltobt;
        private System.Windows.Forms.Button threebt;
        private System.Windows.Forms.Button twobt;
        private System.Windows.Forms.Button onebt;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Button sixbt;
        private System.Windows.Forms.Button fivebt;
        private System.Windows.Forms.Button fourbt;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Button subtractbt;
        private System.Windows.Forms.Button ninebt;
        private System.Windows.Forms.Button eightbt;
        private System.Windows.Forms.Button sevenbt;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.Button multiplybt;
        private System.Windows.Forms.Button dividebt;
        private System.Windows.Forms.Button clearbt;
        private System.Windows.Forms.Panel pdata;
        private System.Windows.Forms.Label rupeelb;
        private System.Windows.Forms.TextBox datatb;
        private System.Windows.Forms.Timer calctimer;
    }
}
