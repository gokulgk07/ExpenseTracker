namespace ExpenseTrackerGUI
{
    partial class BudgetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backPanel = new System.Windows.Forms.Panel();
            this.periodPanel = new System.Windows.Forms.Panel();
            this.pastChoice = new ExpenseTrackerGUI.SingleWallet();
            this.currentChoice = new ExpenseTrackerGUI.SingleWallet();
            this.selectChoicePanel = new System.Windows.Forms.Panel();
            this.choiceLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.choicePb = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectChoiceBtn = new System.Windows.Forms.Button();
            this.walletsPanel = new System.Windows.Forms.Panel();
            this.selectWalletPanel = new System.Windows.Forms.Panel();
            this.walletNameLbl = new System.Windows.Forms.Label();
            this.pwalletmid = new System.Windows.Forms.Panel();
            this.walletpb = new System.Windows.Forms.PictureBox();
            this.pwalletmid1 = new System.Windows.Forms.Panel();
            this.selectwalletbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.paginationControl = new ExpenseTrackerGUI.Pagination();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.budgetSquare1 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare12 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare11 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare10 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare9 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare8 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare7 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare6 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare5 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare4 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare3 = new ExpenseTrackerGUI.BudgetSquare();
            this.budgetSquare2 = new ExpenseTrackerGUI.BudgetSquare();
            this.pastChoicePanel = new System.Windows.Forms.Panel();
            this.currentChoicePanel = new System.Windows.Forms.Panel();
            this.curveBtn4 = new ExpenseTrackerGUI.CurveButtons();
            this.curveBtn3 = new ExpenseTrackerGUI.CurveButtons();
            this.curveBtn2 = new ExpenseTrackerGUI.CurveButtons();
            this.curveBtn1 = new ExpenseTrackerGUI.CurveButtons();
            this.backPanel.SuspendLayout();
            this.periodPanel.SuspendLayout();
            this.selectChoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choicePb)).BeginInit();
            this.selectWalletPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.currentChoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(65, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 764);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(988, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 764);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.backPanel.Controls.Add(this.periodPanel);
            this.backPanel.Controls.Add(this.selectChoicePanel);
            this.backPanel.Controls.Add(this.walletsPanel);
            this.backPanel.Controls.Add(this.selectWalletPanel);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.pictureBox1);
            this.backPanel.Controls.Add(this.ControlsPanel);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1290, 924);
            this.backPanel.TabIndex = 0;
            // 
            // periodPanel
            // 
            this.periodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.periodPanel.Controls.Add(this.pastChoice);
            this.periodPanel.Controls.Add(this.currentChoice);
            this.periodPanel.Location = new System.Drawing.Point(1043, 37);
            this.periodPanel.Name = "periodPanel";
            this.periodPanel.Size = new System.Drawing.Size(200, 52);
            this.periodPanel.TabIndex = 8;
            // 
            // pastChoice
            // 
            this.pastChoice.BackColor = System.Drawing.Color.White;
            this.pastChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pastChoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pastChoice.Id = 2;
            this.pastChoice.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.pastChoice.LabelText = "Past";
            this.pastChoice.Location = new System.Drawing.Point(0, 26);
            this.pastChoice.Name = "pastChoice";
            this.pastChoice.Size = new System.Drawing.Size(200, 26);
            this.pastChoice.TabIndex = 1;
            this.pastChoice.ViewImage = global::ExpenseTrackerGUI.Properties.Resources.Time1;
            this.pastChoice.Selected += new ExpenseTrackerGUI.SingleWallet.SelectHandler(this.OnChoiceSelected);
            // 
            // currentChoice
            // 
            this.currentChoice.BackColor = System.Drawing.Color.White;
            this.currentChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentChoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentChoice.Id = 1;
            this.currentChoice.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.currentChoice.LabelText = "Current";
            this.currentChoice.Location = new System.Drawing.Point(0, 0);
            this.currentChoice.Name = "currentChoice";
            this.currentChoice.Size = new System.Drawing.Size(200, 26);
            this.currentChoice.TabIndex = 0;
            this.currentChoice.ViewImage = global::ExpenseTrackerGUI.Properties.Resources.Time;
            this.currentChoice.Selected += new ExpenseTrackerGUI.SingleWallet.SelectHandler(this.OnChoiceSelected);
            // 
            // selectChoicePanel
            // 
            this.selectChoicePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectChoicePanel.Controls.Add(this.choiceLbl);
            this.selectChoicePanel.Controls.Add(this.panel3);
            this.selectChoicePanel.Controls.Add(this.choicePb);
            this.selectChoicePanel.Controls.Add(this.panel4);
            this.selectChoicePanel.Controls.Add(this.selectChoiceBtn);
            this.selectChoicePanel.Location = new System.Drawing.Point(1043, 9);
            this.selectChoicePanel.Name = "selectChoicePanel";
            this.selectChoicePanel.Size = new System.Drawing.Size(200, 28);
            this.selectChoicePanel.TabIndex = 9;
            // 
            // choiceLbl
            // 
            this.choiceLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choiceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLbl.Location = new System.Drawing.Point(61, 0);
            this.choiceLbl.Name = "choiceLbl";
            this.choiceLbl.Size = new System.Drawing.Size(114, 28);
            this.choiceLbl.TabIndex = 12;
            this.choiceLbl.Text = "Current";
            this.choiceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(48, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 28);
            this.panel3.TabIndex = 11;
            // 
            // choicePb
            // 
            this.choicePb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("choicePb.BackgroundImage")));
            this.choicePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.choicePb.Dock = System.Windows.Forms.DockStyle.Left;
            this.choicePb.Location = new System.Drawing.Point(13, 0);
            this.choicePb.Name = "choicePb";
            this.choicePb.Size = new System.Drawing.Size(35, 28);
            this.choicePb.TabIndex = 10;
            this.choicePb.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 28);
            this.panel4.TabIndex = 9;
            // 
            // selectChoiceBtn
            // 
            this.selectChoiceBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectChoiceBtn.BackgroundImage")));
            this.selectChoiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectChoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectChoiceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectChoiceBtn.FlatAppearance.BorderSize = 0;
            this.selectChoiceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectChoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectChoiceBtn.Location = new System.Drawing.Point(175, 0);
            this.selectChoiceBtn.Name = "selectChoiceBtn";
            this.selectChoiceBtn.Size = new System.Drawing.Size(25, 28);
            this.selectChoiceBtn.TabIndex = 8;
            this.selectChoiceBtn.UseVisualStyleBackColor = true;
            this.selectChoiceBtn.Click += new System.EventHandler(this.OnSelectChoiceBtnClicked);
            // 
            // walletsPanel
            // 
            this.walletsPanel.BackColor = System.Drawing.Color.Black;
            this.walletsPanel.Location = new System.Drawing.Point(778, 37);
            this.walletsPanel.Name = "walletsPanel";
            this.walletsPanel.Size = new System.Drawing.Size(200, 0);
            this.walletsPanel.TabIndex = 8;
            // 
            // selectWalletPanel
            // 
            this.selectWalletPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectWalletPanel.Controls.Add(this.walletNameLbl);
            this.selectWalletPanel.Controls.Add(this.pwalletmid);
            this.selectWalletPanel.Controls.Add(this.walletpb);
            this.selectWalletPanel.Controls.Add(this.pwalletmid1);
            this.selectWalletPanel.Controls.Add(this.selectwalletbtn);
            this.selectWalletPanel.Location = new System.Drawing.Point(778, 9);
            this.selectWalletPanel.Name = "selectWalletPanel";
            this.selectWalletPanel.Size = new System.Drawing.Size(200, 28);
            this.selectWalletPanel.TabIndex = 4;
            // 
            // walletNameLbl
            // 
            this.walletNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walletNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletNameLbl.Location = new System.Drawing.Point(61, 0);
            this.walletNameLbl.Name = "walletNameLbl";
            this.walletNameLbl.Size = new System.Drawing.Size(114, 28);
            this.walletNameLbl.TabIndex = 12;
            this.walletNameLbl.Text = "Total";
            this.walletNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pwalletmid
            // 
            this.pwalletmid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pwalletmid.Location = new System.Drawing.Point(48, 0);
            this.pwalletmid.Name = "pwalletmid";
            this.pwalletmid.Size = new System.Drawing.Size(13, 28);
            this.pwalletmid.TabIndex = 11;
            // 
            // walletpb
            // 
            this.walletpb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("walletpb.BackgroundImage")));
            this.walletpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.walletpb.Dock = System.Windows.Forms.DockStyle.Left;
            this.walletpb.Location = new System.Drawing.Point(13, 0);
            this.walletpb.Name = "walletpb";
            this.walletpb.Size = new System.Drawing.Size(35, 28);
            this.walletpb.TabIndex = 10;
            this.walletpb.TabStop = false;
            // 
            // pwalletmid1
            // 
            this.pwalletmid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pwalletmid1.Location = new System.Drawing.Point(0, 0);
            this.pwalletmid1.Name = "pwalletmid1";
            this.pwalletmid1.Size = new System.Drawing.Size(13, 28);
            this.pwalletmid1.TabIndex = 9;
            // 
            // selectwalletbtn
            // 
            this.selectwalletbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectwalletbtn.BackgroundImage")));
            this.selectwalletbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectwalletbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectwalletbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectwalletbtn.FlatAppearance.BorderSize = 0;
            this.selectwalletbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectwalletbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectwalletbtn.Location = new System.Drawing.Point(175, 0);
            this.selectwalletbtn.Name = "selectwalletbtn";
            this.selectwalletbtn.Size = new System.Drawing.Size(25, 28);
            this.selectwalletbtn.TabIndex = 8;
            this.selectwalletbtn.UseVisualStyleBackColor = true;
            this.selectwalletbtn.Click += new System.EventHandler(this.OnSelectWalletBtnClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Budget";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ExpenseTrackerGUI.Properties.Resources.icons8_budget_96;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.ControlsPanel.Controls.Add(this.paginationControl);
            this.ControlsPanel.Controls.Add(this.mainPanel);
            this.ControlsPanel.Controls.Add(this.pastChoicePanel);
            this.ControlsPanel.Controls.Add(this.currentChoicePanel);
            this.ControlsPanel.Location = new System.Drawing.Point(12, 50);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(1266, 862);
            this.ControlsPanel.TabIndex = 0;
            // 
            // paginationControl
            // 
            this.paginationControl.ButtonCount = 1;
            this.paginationControl.Location = new System.Drawing.Point(554, 798);
            this.paginationControl.MaximumSize = new System.Drawing.Size(261, 35);
            this.paginationControl.MinimumSize = new System.Drawing.Size(35, 35);
            this.paginationControl.Name = "paginationControl";
            this.paginationControl.Size = new System.Drawing.Size(105, 35);
            this.paginationControl.TabIndex = 5;
            this.paginationControl.SizeChanged += new System.EventHandler(this.OnPaginationSizeChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainPanel.Controls.Add(this.budgetSquare1);
            this.mainPanel.Controls.Add(this.budgetSquare12);
            this.mainPanel.Controls.Add(this.budgetSquare11);
            this.mainPanel.Controls.Add(this.budgetSquare10);
            this.mainPanel.Controls.Add(this.budgetSquare9);
            this.mainPanel.Controls.Add(this.budgetSquare8);
            this.mainPanel.Controls.Add(this.budgetSquare7);
            this.mainPanel.Controls.Add(this.budgetSquare6);
            this.mainPanel.Controls.Add(this.budgetSquare5);
            this.mainPanel.Controls.Add(this.budgetSquare4);
            this.mainPanel.Controls.Add(this.budgetSquare3);
            this.mainPanel.Controls.Add(this.budgetSquare2);
            this.mainPanel.Location = new System.Drawing.Point(67, 72);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1140, 718);
            this.mainPanel.TabIndex = 3;
            // 
            // budgetSquare1
            // 
            this.budgetSquare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare1.Location = new System.Drawing.Point(59, 26);
            this.budgetSquare1.MaximumSize = new System.Drawing.Size(210, 210);
            this.budgetSquare1.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare1.Name = "budgetSquare1";
            this.budgetSquare1.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare1.TabIndex = 24;
            this.budgetSquare1.Value = 75;
            // 
            // budgetSquare12
            // 
            this.budgetSquare12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare12.Location = new System.Drawing.Point(885, 488);
            this.budgetSquare12.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare12.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare12.Name = "budgetSquare12";
            this.budgetSquare12.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare12.TabIndex = 23;
            this.budgetSquare12.Value = 75;
            // 
            // budgetSquare11
            // 
            this.budgetSquare11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare11.Location = new System.Drawing.Point(608, 488);
            this.budgetSquare11.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare11.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare11.Name = "budgetSquare11";
            this.budgetSquare11.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare11.TabIndex = 22;
            this.budgetSquare11.Value = 75;
            // 
            // budgetSquare10
            // 
            this.budgetSquare10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare10.Location = new System.Drawing.Point(330, 488);
            this.budgetSquare10.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare10.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare10.Name = "budgetSquare10";
            this.budgetSquare10.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare10.TabIndex = 21;
            this.budgetSquare10.Value = 75;
            // 
            // budgetSquare9
            // 
            this.budgetSquare9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare9.Location = new System.Drawing.Point(59, 488);
            this.budgetSquare9.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare9.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare9.Name = "budgetSquare9";
            this.budgetSquare9.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare9.TabIndex = 20;
            this.budgetSquare9.Value = 75;
            // 
            // budgetSquare8
            // 
            this.budgetSquare8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare8.Location = new System.Drawing.Point(885, 257);
            this.budgetSquare8.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare8.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare8.Name = "budgetSquare8";
            this.budgetSquare8.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare8.TabIndex = 19;
            this.budgetSquare8.Value = 75;
            // 
            // budgetSquare7
            // 
            this.budgetSquare7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare7.Location = new System.Drawing.Point(608, 257);
            this.budgetSquare7.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare7.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare7.Name = "budgetSquare7";
            this.budgetSquare7.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare7.TabIndex = 18;
            this.budgetSquare7.Value = 75;
            // 
            // budgetSquare6
            // 
            this.budgetSquare6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare6.Location = new System.Drawing.Point(330, 257);
            this.budgetSquare6.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare6.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare6.Name = "budgetSquare6";
            this.budgetSquare6.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare6.TabIndex = 17;
            this.budgetSquare6.Value = 75;
            // 
            // budgetSquare5
            // 
            this.budgetSquare5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare5.Location = new System.Drawing.Point(59, 257);
            this.budgetSquare5.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare5.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare5.Name = "budgetSquare5";
            this.budgetSquare5.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare5.TabIndex = 16;
            this.budgetSquare5.Value = 75;
            // 
            // budgetSquare4
            // 
            this.budgetSquare4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare4.Location = new System.Drawing.Point(885, 26);
            this.budgetSquare4.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare4.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare4.Name = "budgetSquare4";
            this.budgetSquare4.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare4.TabIndex = 15;
            this.budgetSquare4.Value = 75;
            // 
            // budgetSquare3
            // 
            this.budgetSquare3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare3.Location = new System.Drawing.Point(608, 26);
            this.budgetSquare3.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare3.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare3.Name = "budgetSquare3";
            this.budgetSquare3.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare3.TabIndex = 14;
            this.budgetSquare3.Value = 75;
            // 
            // budgetSquare2
            // 
            this.budgetSquare2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.budgetSquare2.Location = new System.Drawing.Point(330, 26);
            this.budgetSquare2.MaximumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare2.MinimumSize = new System.Drawing.Size(200, 200);
            this.budgetSquare2.Name = "budgetSquare2";
            this.budgetSquare2.Size = new System.Drawing.Size(200, 200);
            this.budgetSquare2.TabIndex = 13;
            this.budgetSquare2.Value = 75;
            // 
            // pastChoicePanel
            // 
            this.pastChoicePanel.Location = new System.Drawing.Point(69, 13);
            this.pastChoicePanel.Name = "pastChoicePanel";
            this.pastChoicePanel.Size = new System.Drawing.Size(1138, 40);
            this.pastChoicePanel.TabIndex = 7;
            // 
            // currentChoicePanel
            // 
            this.currentChoicePanel.Controls.Add(this.curveBtn4);
            this.currentChoicePanel.Controls.Add(this.curveBtn3);
            this.currentChoicePanel.Controls.Add(this.curveBtn2);
            this.currentChoicePanel.Controls.Add(this.curveBtn1);
            this.currentChoicePanel.Location = new System.Drawing.Point(69, 13);
            this.currentChoicePanel.Name = "currentChoicePanel";
            this.currentChoicePanel.Size = new System.Drawing.Size(1138, 40);
            this.currentChoicePanel.TabIndex = 6;
            // 
            // curveBtn4
            // 
            this.curveBtn4.Back = System.Drawing.Color.White;
            this.curveBtn4.CurveSize = 35;
            this.curveBtn4.Dock = System.Windows.Forms.DockStyle.Left;
            this.curveBtn4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveBtn4.ForeColor = System.Drawing.Color.White;
            this.curveBtn4.Location = new System.Drawing.Point(570, 0);
            this.curveBtn4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.curveBtn4.Name = "curveBtn4";
            this.curveBtn4.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.curveBtn4.ReturnClicked = false;
            this.curveBtn4.SecondColor = System.Drawing.Color.MediumSlateBlue;
            this.curveBtn4.Select = false;
            this.curveBtn4.Size = new System.Drawing.Size(190, 40);
            this.curveBtn4.TabIndex = 3;
            this.curveBtn4.Text = "This Year";
            this.curveBtn4.UseVisualStyleBackColor = true;
            // 
            // curveBtn3
            // 
            this.curveBtn3.Back = System.Drawing.Color.White;
            this.curveBtn3.CurveSize = 35;
            this.curveBtn3.Dock = System.Windows.Forms.DockStyle.Left;
            this.curveBtn3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveBtn3.ForeColor = System.Drawing.Color.White;
            this.curveBtn3.Location = new System.Drawing.Point(380, 0);
            this.curveBtn3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.curveBtn3.Name = "curveBtn3";
            this.curveBtn3.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.curveBtn3.ReturnClicked = false;
            this.curveBtn3.SecondColor = System.Drawing.Color.MediumSlateBlue;
            this.curveBtn3.Select = false;
            this.curveBtn3.Size = new System.Drawing.Size(190, 40);
            this.curveBtn3.TabIndex = 2;
            this.curveBtn3.Text = "This Quarter";
            this.curveBtn3.UseVisualStyleBackColor = true;
            // 
            // curveBtn2
            // 
            this.curveBtn2.Back = System.Drawing.Color.White;
            this.curveBtn2.CurveSize = 35;
            this.curveBtn2.Dock = System.Windows.Forms.DockStyle.Left;
            this.curveBtn2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveBtn2.ForeColor = System.Drawing.Color.White;
            this.curveBtn2.Location = new System.Drawing.Point(190, 0);
            this.curveBtn2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.curveBtn2.Name = "curveBtn2";
            this.curveBtn2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.curveBtn2.ReturnClicked = false;
            this.curveBtn2.SecondColor = System.Drawing.Color.MediumSlateBlue;
            this.curveBtn2.Select = false;
            this.curveBtn2.Size = new System.Drawing.Size(190, 40);
            this.curveBtn2.TabIndex = 1;
            this.curveBtn2.Text = "This Month";
            this.curveBtn2.UseVisualStyleBackColor = true;
            // 
            // curveBtn1
            // 
            this.curveBtn1.Back = System.Drawing.Color.White;
            this.curveBtn1.CurveSize = 35;
            this.curveBtn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.curveBtn1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveBtn1.ForeColor = System.Drawing.Color.White;
            this.curveBtn1.Location = new System.Drawing.Point(0, 0);
            this.curveBtn1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.curveBtn1.Name = "curveBtn1";
            this.curveBtn1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(149)))));
            this.curveBtn1.ReturnClicked = false;
            this.curveBtn1.SecondColor = System.Drawing.Color.MediumSlateBlue;
            this.curveBtn1.Select = false;
            this.curveBtn1.Size = new System.Drawing.Size(190, 40);
            this.curveBtn1.TabIndex = 0;
            this.curveBtn1.Text = "This Week";
            this.curveBtn1.UseVisualStyleBackColor = true;
            // 
            // BudgetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.backPanel);
            this.DoubleBuffered = true;
            this.Name = "BudgetPage";
            this.Size = new System.Drawing.Size(1290, 924);
            this.Resize += new System.EventHandler(this.OnBudgetPageResized);
            this.backPanel.ResumeLayout(false);
            this.periodPanel.ResumeLayout(false);
            this.selectChoicePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.choicePb)).EndInit();
            this.selectWalletPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.walletpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlsPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.currentChoicePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Panel mainPanel;
        private Pagination paginationControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel currentChoicePanel;
        private CurveButtons curveBtn2;
        private CurveButtons curveBtn1;
        private CurveButtons curveBtn4;
        private CurveButtons curveBtn3;
        private BudgetSquare budgetSquare12;
        private BudgetSquare budgetSquare11;
        private BudgetSquare budgetSquare10;
        private BudgetSquare budgetSquare9;
        private BudgetSquare budgetSquare8;
        private BudgetSquare budgetSquare7;
        private BudgetSquare budgetSquare6;
        private BudgetSquare budgetSquare5;
        private BudgetSquare budgetSquare4;
        private BudgetSquare budgetSquare3;
        private BudgetSquare budgetSquare2;
        private BudgetSquare budgetSquare1;
        private System.Windows.Forms.Panel pastChoicePanel;
        private System.Windows.Forms.Panel selectWalletPanel;
        private System.Windows.Forms.Label walletNameLbl;
        private System.Windows.Forms.Panel pwalletmid;
        private System.Windows.Forms.PictureBox walletpb;
        private System.Windows.Forms.Panel pwalletmid1;
        private System.Windows.Forms.Button selectwalletbtn;
        private System.Windows.Forms.Panel walletsPanel;
        private System.Windows.Forms.Panel selectChoicePanel;
        private System.Windows.Forms.Label choiceLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox choicePb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button selectChoiceBtn;
        private System.Windows.Forms.Panel periodPanel;
        private SingleWallet pastChoice;
        private SingleWallet currentChoice;
    }
}
