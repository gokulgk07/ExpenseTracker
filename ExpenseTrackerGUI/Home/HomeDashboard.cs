using ExpenseTracker;
using ExpenseTrackerGUI.Account;
using ExpenseTrackerGUI.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
	public partial class HomeDashboard : UserControl
	{
		public HomeDashboard()
		{
			InitializeComponent();

            AddControls();
            account1.DeleteAccount += OnAccount1_DeleteAccount;
            account1.AccountClick += OnAccount1_AccountClick;
            this.DoubleBuffered = true;
            this.Size = new Size(1936, 1056);
            
            avgCardPanel.CardFlickerColor = Color.Transparent;
            transactionAddPicturebox.Hide();
            budgetAddPictureBox.Hide();

            HideControl();

            if (DesignMode) return;
            UpdateFunctions();

            walkthroghPanel.Hide();            
            walkThrough1.walkthroughBackClick += OnWalkThrough1_walkthroughBackClick;
        }

        private void OnAccount1_AccountClick(object sender, EventArgs e)
        {
            accountPictureBox.Show();
        }

        private void OnWalkThrough1_walkthroughBackClick(object sender, EventArgs e)
        {
            walkthroghPanel.Hide();
            menuShowPannel.Enabled = true;
            titlePanel.Enabled = true;
            accountTemplate.Enabled = true;
            //this.Size = new Size(1173, 773);
            //this.Location = new Point(390, 160);

            //homeDashboard1.OnExitClick += OnHomeDashboard1_OnExitClick;
            //homeDashboard1.HideHomeDashboard += OnHomeDashboard1_HideHomeDashboard;
            //homeDashboard1.UpdateFunctions();
        }

        public event EventHandler HideHomeDashboard;

        private void OnAccount1_DeleteAccount(object sender, EventArgs e)
        {
            HideHomeDashboard?.Invoke(this, EventArgs.Empty);
        }

        Dictionary<string, float> dict1 = new Dictionary<string, float>();

        static int countTrans = 0;
        static bool res = false;

        public void UpdateFunctions()
        {
            SetUpChart();
            ShowTransaction();
            ShowTotalAmount();
            ShowBiggestExpense();
        }

        private TransactionManager transactionManager = new TransactionManager();
        private BudgetPage budgetPage = new BudgetPage();
        private MainCategoryView mainCategoryView = new MainCategoryView();
        private CreateTransaction createTransaction = new CreateTransaction();
        private AddBudget addBudget = new AddBudget();
        private AccountTemplate accountTemplate = new AccountTemplate();
        private SeeReports seeReports = new SeeReports();
        private WalletView walletView = new WalletView();

        private void AddControls()
        {            
            transactionManager.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(transactionManager);
            
            budgetPage.Dock = DockStyle.Fill;
            tabPage3.Controls.Add(budgetPage);
            
            mainCategoryView.Dock = DockStyle.Fill;
            tabPage4.Controls.Add(mainCategoryView);

            walletView.Dock = DockStyle.Fill;
            tabPage5.Controls.Add(walletView);

            createTransaction.Dock = DockStyle.Fill;
            tabPage6.Controls.Add(createTransaction);
           
            addBudget.Dock = DockStyle.Fill;
            tabPage7.Controls.Add(addBudget);

            accountTemplate.Dock = DockStyle.Fill;
            tabPage8.Controls.Add(accountTemplate);
            account1.OnNextPictureClick += OnAccount1_OnNextPictureClick;
            accountTemplate.walkthroughClick += OnAccountTemplate_walkthroughClick;

            seeReports.Dock = DockStyle.Fill;
            tabPage9.Controls.Add(seeReports);   

            Console.WriteLine("Transactions size : " + transactionManager.Size);
            Console.WriteLine("Budget size : " + budgetPage.Size);
        }

        public event EventHandler accountTemplateWalkthroughClick;

        private void OnAccountTemplate_walkthroughClick(object sender, EventArgs e)
        {
            menuShowPannel.Enabled = false;
            titlePanel.Enabled = false;
            accountTemplate.Enabled = false;
            walkthroghPanel.Location = tabPage8.PointToScreen(new Point(0,0));

            walkthroghPanel.Show();
        }

        private void OnAccount1_OnNextPictureClick(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            accountTemplate.Signout += OnAccountTemplate_Signout;
            HideControl();
        }

        private void OnAccountTemplate_Signout(object sender, EventArgs e)
        {
            OnAccount1_DeleteAccount(this, EventArgs.Empty);
        }

        private List<ExpenseTrackerDS.Transaction> SortTransactions(List<ExpenseTrackerDS.Transaction> transactions)
        {
            for (int i = 0; i < transactions.Count; i++)
            {
                for (int j = i + 1; j < transactions.Count; j++)
                {
                    if (transactions[i].Date < transactions[j].Date)
                    {
                        ExpenseTrackerDS.Transaction transaction = new ExpenseTrackerDS.Transaction();
                        transaction.TransactionId = transactions[i].TransactionId;
                        transaction.CategoryId = transactions[i].CategoryId;
                        transaction.CategoryName = transactions[i].CategoryName;
                        transaction.Date = transactions[i].Date;
                        transaction.Description = transactions[i].Description;
                        transaction.Amount = transactions[i].Amount;
                        transaction.WalletId = transactions[i].WalletId;

                        transactions[i] = transactions[j];
                        transactions[j] = transaction;
                    }
                }
            }
            return transactions;
        }

        private void ShowTransaction()
        {
            List<ExpenseTrackerDS.Transaction> transactions = Communicator.Manager.FetchTransactions<List<ExpenseTrackerDS.Transaction>>(0);

            transactions = SortTransactions(transactions);

            dict1.Clear();
            for (int i = 0; i < transactions.Count; i++)
            {
                float amount = transactions[i].Amount, avg = 0, cnt = 1;
                for (int j = i + 1; j < transactions.Count; j++)
                {
                    if (transactions[i].Date == transactions[j].Date)
                    {
                        amount += transactions[j].Amount;
                        cnt++;
                    }
                }
                avg = amount / cnt;

                if (!dict1.ContainsKey(transactions[i].Date.ToString("dd.MM.yyyy")))
                {
                    dict1.Add(transactions[i].Date.ToString("dd.MM.yyyy"), avg);
                }

            }
            Console.WriteLine("Dictionary............");
            foreach (var key in dict1)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }

            todayAvg.Text = "";
            todayLabel.Text = "";
            yesterdayLabel.Text = "";
            yesterdayAvg.Text = "";
            dayBeforeLabel.Text = "";
            dayBeforeAvg.Text = "";
            nextDayAvg.Text = "";
            nextDayLabel.Text = "";
            
            if (dict1.Count > 0)
            {
                if (dict1.Keys.ElementAt(0) == DateTime.Now.ToString("dd.MM.yyyy"))
                {
                    countTrans = 0;
                    todayLabel.Text = "Today, " + DateTime.Now.Day;
                    todayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans);
                }
                else
                {
                    countTrans = 0;
                    todayLabel.Text = dict1.Keys.ElementAt(countTrans);
                    todayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans);
                }
            }
            if (dict1.Count > 1)
            {
                countTrans = 1;
                yesterdayLabel.Text = dict1.Keys.ElementAt(countTrans);
                yesterdayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans);
            }
            if (dict1.Count > 2)
            {
                countTrans = 2;
                dayBeforeLabel.Text = dict1.Keys.ElementAt(countTrans);
                dayBeforeAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans);
            }
            if (dict1.Count > 3)
            {
                countTrans = 3;
                nextDayLabel.Text = dict1.Keys.ElementAt(countTrans);
                nextDayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans);
            }
            //    backPictureBox.Image =Image.FromFile(@".\Images\back3.png");

        }

        private void ShowTotalAmount()
        {
            List<ExpenseTrackerDS.Transaction> transactions = Communicator.Manager.FetchTransactionOnDates<List<ExpenseTrackerDS.Transaction>>(DateTime.Now, DateTime.Now, ExpenseTracker.Manager.ViewType.Month, 0);

            float total = 0;
            foreach(ExpenseTrackerDS.Transaction transaction in transactions)
            {
                total += transaction.Amount;
            }

            Console.WriteLine("Total Amount : "+total);
            totalLabel.Text = "₹ " + total.ToString();
        }

        private void ShowBiggestExpense()
        {
            List<ExpenseTrackerDS.Transaction> transactions = Communicator.Manager.FetchTransactionOnDates<List<ExpenseTrackerDS.Transaction>>(DateTime.Now, DateTime.Now, ExpenseTracker.Manager.ViewType.Month, 0);
            float total = 0;
            string name = "";
            foreach (ExpenseTrackerDS.Transaction transaction in transactions)
            {
                if (total < transaction.Amount)
                {
                    total = transaction.Amount;
                    name = transaction.CategoryName;
                }
            }

            Console.WriteLine("CategoryName : "+name+"Amount : " + total);
            expenseLabel.Text = name + " :  ₹ " + total.ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Console.WriteLine("Form Width : "+ Width + ", Form Height : " + Height);
            Console.WriteLine("Tab Page : " + tabControl1.Width + " , " + tabControl1.Height);

            titlePanel.Invalidate();
            int x = Width - 90;
            int y = 4;
            accountPictureBox.Location = new Point(x, y);

            x = graphAndAddPanel.Width - addPictureBox.Width - 5;
            y = graphAndAddPanel.Height - addPictureBox.Height - 5;
            addPictureBox.Location = new Point(x, y);

            x = graphAndAddPanel.Width - budgetAddPictureBox.Width - 5;
            y = graphAndAddPanel.Height - budgetAddPictureBox.Height - 200;
            budgetAddPictureBox.Location = new Point(x, y);

            x = graphAndAddPanel.Width - transactionAddPicturebox.Width - 5;
            y = graphAndAddPanel.Height - transactionAddPicturebox.Height - 120;
            transactionAddPicturebox.Location = new Point(x, y);

            searchControl1.Location = new Point(Width-521, searchControl1.Location.Y);

            seeReportLinkLabel1.Location = new Point(tabPage1.Width -seeReportLinkLabel1.Width- 15, seeReportLinkLabel1.Location.Y);            
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {            
            using(Graphics gh = e.Graphics)
            {
                using (Brush b = new SolidBrush(GUIStyles.backColor))
                {
                    gh.FillRectangle(b, 0, 0, Width, Height);
                    gh.DrawRectangle(new Pen(GUIStyles.primaryColor), 0, 0, titlePanel.Width - 1, titlePanel.Height - 1);
                    gh.DrawRectangle(new Pen(GUIStyles.primaryColor), 10, 76, menuShowPannel.Width - 1, menuShowPannel.Height - 1);
                    Console.Write(Width + "" + Height);
                    Console.WriteLine("title:  " + titlePanel.Width + " " + titlePanel.Height);
                }
            }
            
        }

        bool flag = true;

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;

            HideControl();
        }

        int cnt = 0;

        private void HideControl()
        {
            accountPictureBox.Show();
            account1.Hide();
            account1.HideFunction();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!res)
            {
                cnt++;
                if (flag)
                {
                    if (cnt == 1)
                    {
                        transactionAddPicturebox.Show();
                    }
                    else if (cnt == 2)
                    {
                        budgetAddPictureBox.Show();
                    }

                    else
                    {
                        flag = false;
                        cnt = 0;
                        timer1.Stop();
                    }
                }

                else
                {
                    if (cnt == 1)
                    {
                        budgetAddPictureBox.Hide();
                    }

                    else if (cnt == 2)
                    {
                        transactionAddPicturebox.Hide();
                    }
                    else
                    {
                        flag = true;
                        cnt = 0;
                        timer1.Stop();
                    }
                }
            }

            else
            {
                timer1.Stop();
            }
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular); 

            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, new PointF(2, 2));
        }

        private void logoutPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\rename3.png");
            MouseEnterEvent(logoutPictureBox, exitLabel, hoverImage,exitPanel);
        }

        private void logoutPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\rename1.png");
            MouseLeaveEvent(logoutPictureBox, exitLabel, hoverImage,exitPanel);
        }

        private void menuPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\showmenu2.png");
            //MouseEnterEvent(menuPictureBox, hoverImage);
        }

        private void menuPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\showmenu.png");
           // MouseLeaveEvent(menuPictureBox, hoverImage);
        }

        private void homePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\home3.png");
            MouseEnterEvent(homePictureBox, homeLabel, hoverImage,homePanel);
        }

        private void homePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\home1.png");
            MouseLeaveEvent(homePictureBox, homeLabel, hoverImage,homePanel);
        }

        private void transactionPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet4.png");
            MouseEnterEvent(transactionPictureBox, transactionLabel, hoverImage,transactionPanel);
        }

        private void transactionPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet.png");
            MouseLeaveEvent(transactionPictureBox, transactionLabel, hoverImage,transactionPanel);
        }

        private void budgetPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\budget2.png");
            MouseEnterEvent(budgetPictureBox, budgetLabel, hoverImage,budgetPanel);
        }

        private void budgetPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\budget1.png");
            MouseLeaveEvent(budgetPictureBox, budgetLabel, hoverImage,budgetPanel);
        }

        private void addPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\add2.png");
            MouseEnterEvent(addPictureBox, hoverImage);
        }

        private void addPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\add.png");
            MouseLeaveEvent(addPictureBox, hoverImage);
        }

        private void transactionAddPicturebox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet1.png");
            MouseEnterEvent(transactionAddPicturebox, hoverImage);
        }

        private void transactionAddPicturebox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet.png");
            MouseLeaveEvent(transactionAddPicturebox, hoverImage);
        }

        private void budgetAddPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\budget3.png");
            MouseEnterEvent(budgetAddPictureBox, hoverImage);
        }

        private void budgetAddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\budget1.png");
            MouseLeaveEvent(budgetAddPictureBox, hoverImage);
        }

        private void categoryPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\category4.png");
            MouseEnterEvent(categoryPictureBox, categoryLabel, hoverImage,categoryPanel);
        }

        private void categoryPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\category3.png");
            MouseLeaveEvent(categoryPictureBox, categoryLabel, hoverImage,categoryPanel);
        }

        private void walletPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet5.png");
            MouseEnterEvent(walletPictureBox, walletLabel, hoverImage,walletPanel);
        }

        private void walletPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet2.png");
            MouseLeaveEvent(walletPictureBox, walletLabel, hoverImage,walletPanel);
        }

        private void accountPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\account1.png");
            accountPictureBox.Image = hoverImage;
            accountPictureBox.Cursor = Cursors.Hand;
        }

        private void accountPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\account.png");
            accountPictureBox.Image = hoverImage;
            accountPictureBox.Cursor = Cursors.Hand;
        }

        List<Tuple<string, float>> result = new List<Tuple<string, float>>();

        private void SetUpChart()
        {
            result = Communicator.Manager.FetchAmount();
            var sortedList = result.OrderByDescending(t => t.Item1).ToList();

            chart1.Series.SuspendUpdates();
            foreach (Tuple<string,float> t1 in sortedList)
            {
                chart1.Series["Series1"].Points.AddXY(t1.Item1, t1.Item2);
            }

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.Series.ResumeUpdates();
        }

        private void homeLabel_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\home3.png");
            MouseEnterEvent(homePictureBox, homeLabel, hoverImage,homePanel);
        }

        private void homeLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\home1.png");
            MouseLeaveEvent(homePictureBox, homeLabel, hoverImage,homePanel);
        }

        private void transactionLabel_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet4.png");
            MouseEnterEvent(transactionPictureBox, transactionLabel, hoverImage,transactionPanel);
        }

        private void transactionLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet.png");
            MouseLeaveEvent(transactionPictureBox, transactionLabel, hoverImage,transactionPanel);
        }

        private void budgetLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@".\Images\budget2.png");
            MouseEnterEvent(budgetPictureBox, budgetLabel, hoverImage,budgetPanel);
        }

        private void budgetLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\budget1.png");
            MouseLeaveEvent(budgetPictureBox, budgetLabel, hoverImage,budgetPanel);
        }

        private void categoryLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@".\Images\category4.png");
            MouseEnterEvent(categoryPictureBox, categoryLabel, hoverImage,categoryPanel);
        }

        private void categoryLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\category3.png");
            MouseLeaveEvent(categoryPictureBox, categoryLabel, hoverImage,categoryPanel);
        }

        private void walletLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@".\Images\wallet5.png");
            MouseEnterEvent(walletPictureBox, walletLabel, hoverImage,walletPanel);
        }

        private void walletLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\wallet2.png");
            MouseLeaveEvent(walletPictureBox, walletLabel, hoverImage,walletPanel);
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@".\Images\rename3.png");           
            MouseEnterEvent(logoutPictureBox, exitLabel, hoverImage,exitPanel);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@".\Images\rename1.png");
            MouseLeaveEvent(logoutPictureBox, exitLabel, hoverImage,exitPanel);
        }

        private void MouseEnterEvent(PictureBox control1,Label control2,Image hoverImage,Panel control3)
        {
            control1.Size = new Size(control1.Width + 5, control1.Height + 5);
            control1.Image = hoverImage;
            control1.Cursor = Cursors.Hand;

            control2.Font= new Font("Arial", 13, FontStyle.Bold);
            control2.ForeColor = GUIStyles.whiteColor;

            control3.BackColor = GUIStyles.primaryColor;
        }

        private void MouseLeaveEvent(PictureBox control1,Label control2,Image hoverImage,Panel control3)
        {
            control1.Size = new Size(control1.Width - 5, control1.Height - 5);            
            control1.Image = hoverImage;
            control1.Cursor = Cursors.Hand;

            control2.Font = new Font("Arial", 11, FontStyle.Bold);
            control2.ForeColor = GUIStyles.primaryColor;

            control3.BackColor = GUIStyles.backColor;
        }

        private void MouseEnterEvent(PictureBox control1,Image hoverImage)
        {
            control1.Size = new Size(control1.Width + 5, control1.Height + 5);
            control1.Image = hoverImage;
            control1.Cursor = Cursors.Hand;
        }

        private void MouseLeaveEvent(PictureBox control1,Image hoverImage)
        {
            control1.Size = new Size(control1.Width - 5, control1.Height - 5);
            control1.Image = hoverImage;
            control1.Cursor = Cursors.Hand;
        }

        public event EventHandler OnExitClick;

        private void exitLabel_Click(object sender, EventArgs e)
        {
            res = true;
            transactionShowControl1.res = false;
            OnExitClick?.Invoke(this,EventArgs.Empty);
            HideControl();
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            res = true;
            transactionShowControl1.res = false;
            OnExitClick?.Invoke(this, EventArgs.Empty);
            HideControl();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            homePanel.BackColor = GUIStyles.terenaryColor;
            homeLabel.ForeColor= GUIStyles.primaryColor;

            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;

            UpdateFunctions();
            HideControl();
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            homePanel.BackColor = GUIStyles.terenaryColor;
            homeLabel.ForeColor = GUIStyles.primaryColor;

            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;

            UpdateFunctions();
            HideControl();
        }

        private void transactionLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            transactionPanel.BackColor = GUIStyles.terenaryColor;
            transactionLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;
            HideControl();
        }

        private void transactionPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            transactionPanel.BackColor = GUIStyles.terenaryColor;
            transactionLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;
            HideControl();
        }

        private void budgetLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            budgetPanel.BackColor = GUIStyles.terenaryColor;
            budgetLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;

            budgetPage.InitializeBudgetPage();
            HideControl();
        }

        private void budgetPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3; transactionPanel.BackColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = GUIStyles.terenaryColor;
            budgetLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;

            budgetPage.InitializeBudgetPage();
            HideControl();
        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            categoryPanel.BackColor = GUIStyles.terenaryColor;
            categoryLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;
            HideControl();
        }

        private void categoryPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            categoryPanel.BackColor = GUIStyles.terenaryColor;
            categoryLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = GUIStyles.primaryColor;
            HideControl();
        }

        private void walletLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            walletPanel.BackColor = GUIStyles.terenaryColor;
            walletLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;

            HideControl();
        }

        private void walletPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            walletPanel.BackColor = GUIStyles.terenaryColor;
            walletLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = GUIStyles.primaryColor;
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = GUIStyles.primaryColor;
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = GUIStyles.primaryColor;
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = GUIStyles.primaryColor;
            HideControl();
        }

        private void transactionAddPicturebox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage6;
            HideControl();
        }

        private void budgetAddPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage7;
            HideControl();
        }

        private void categoryAddPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage8;
            HideControl();
        }

        private void todayPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gh = e.Graphics)
            {
                using (Pen colorPen = new Pen(GUIStyles.primaryColor, 5))
                {
                    gh.DrawRectangle(colorPen, 2, 2, todayPanel.Width - 5, todayPanel.Height - 5);
                }
            }
        }

        private void yesterdayPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gh = e.Graphics)
            {
                using (Pen colorPen = new Pen(GUIStyles.primaryColor, 5))
                {
                    gh.DrawRectangle(colorPen, 2, 2, yesterdayPanel.Width - 5, yesterdayPanel.Height - 5);
                }
            }
        }

        private void dayBeforePanel_Paint(object sender, PaintEventArgs e)
        {
            using(Graphics gh = e.Graphics)
            {
                using(Pen colorPen=new Pen(GUIStyles.primaryColor, 5))
                {
                    gh.DrawRectangle(colorPen, 2, 2, dayBeforePanel.Width - 5, dayBeforePanel.Height - 5);
                }
            }            
        }

        private void nextDayPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gh = e.Graphics)
            {
                using (Pen colorPen = new Pen(GUIStyles.primaryColor, 5))
                {
                    gh.DrawRectangle(colorPen, 2, 2, nextDayPanel.Width - 5, nextDayPanel.Height - 5);
                }
            }
        }

        public int count = 0;

        private void nextPictureBox_Click(object sender, EventArgs e)
       {
            if (countTrans + 1 < dict1.Count)
            {
                countTrans++;
                todayLabel.Text = dict1.Keys.ElementAt(countTrans);
                todayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans).ToString();
            }
            else
            { 
                nextPictureBox.Image = Image.FromFile(@".\Images\next3.png");
                return;
            }

            backPictureBox.Image = Image.FromFile(@".\Images\back1.png");            

            if (countTrans + 1 < dict1.Count)
            {
                countTrans++;
                yesterdayLabel.Text = dict1.Keys.ElementAt(countTrans);
                yesterdayAvg.Text = "₹ "+dict1.Values.ElementAt(countTrans).ToString();
            }

            else
            {
                yesterdayLabel.Text = "";
                yesterdayAvg.Text = "";
                nextPictureBox.Image = Image.FromFile(@".\Images\next3.png");
            }

            if (countTrans + 1 < dict1.Count)
            {
                countTrans++;
                dayBeforeLabel.Text = dict1.Keys.ElementAt(countTrans);
                dayBeforeAvg.Text = "₹ "+dict1.Values.ElementAt(countTrans).ToString();
            }

            else
            {
                dayBeforeLabel.Text = "";
                dayBeforeAvg.Text = "";
                nextPictureBox.Image = Image.FromFile(@".\Images\next3.png");
            }

            if (countTrans + 1 < dict1.Count)
            {
                countTrans++;
                nextDayLabel.Text = dict1.Keys.ElementAt(countTrans);
                nextDayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans).ToString();
            }

            else
            {
                nextDayLabel.Text = "";
                nextDayAvg.Text = "";
                nextPictureBox.Image = Image.FromFile(@".\Images\next3.png");
            }
            HideControl();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            count = 1;
            if(count*4 - 4 == 0 ||count * 4 - 3 == 0 || count*4-2==0 || count * 4 - 1 == 0)
            {
                backPictureBox.Image = Image.FromFile(@".\Images\back3.png");
            }

            for(int i=countTrans; i>=0 ; i--)
            {
                if (i % 4 == 0)
                {
                    countTrans = i;
                    break;
                }
            }

            nextPictureBox.Image = Image.FromFile(@".\Images\next1.png");

            if (countTrans - 4 >= 0)
            {
                countTrans -= 4;
                if (dict1.Keys.ElementAt(countTrans) == DateTime.Now.ToString("dd.MM.yyyy"))
                {
                    todayLabel.Text = "Today, " + DateTime.Now.Day;
                }
                else
                {
                    todayLabel.Text = dict1.Keys.ElementAt(countTrans);
                }
                todayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans).ToString();
            }

            if (countTrans + 1 <dict1.Count)
            {
                countTrans++;
                yesterdayLabel.Text = dict1.Keys.ElementAt(countTrans);
                yesterdayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans).ToString();
            }

            if (countTrans + 1 < dict1.Count)
            {
                countTrans++;
                dayBeforeLabel.Text = dict1.Keys.ElementAt(countTrans);
                dayBeforeAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans).ToString();
            }

            if (countTrans + 1 < dict1.Count)
            {
                countTrans++;
                nextDayLabel.Text = dict1.Keys.ElementAt(countTrans);
                nextDayAvg.Text = "₹ " + dict1.Values.ElementAt(countTrans).ToString();
            }
            HideControl();
        }

        private void todayPanel_MouseEnter(object sender, EventArgs e)
        {
            todayPanel.BackColor= GUIStyles.primaryColor;
            todayLabel.ForeColor = GUIStyles.whiteColor;
            todayAvg.ForeColor = GUIStyles.whiteColor;
        }

        private void todayPanel_MouseLeave(object sender, EventArgs e)
        {
            todayPanel.BackColor = GUIStyles.backColor;
            todayLabel.ForeColor = GUIStyles.blackColor;
            todayAvg.ForeColor = GUIStyles.blackColor;
        }

        private void yesterdayPanel_MouseEnter(object sender, EventArgs e)
        {
            yesterdayPanel.BackColor = GUIStyles.primaryColor;
            yesterdayLabel.ForeColor = GUIStyles.whiteColor;
            yesterdayAvg.ForeColor = GUIStyles.whiteColor;
        }

        private void yesterdayPanel_MouseLeave(object sender, EventArgs e)
        {
            yesterdayPanel.BackColor = GUIStyles.backColor;
            yesterdayLabel.ForeColor = GUIStyles.blackColor; 
            yesterdayAvg.ForeColor = GUIStyles.blackColor;
        }

        private void dayBeforeAvg_MouseEnter(object sender, EventArgs e)
        {
            dayBeforePanel.BackColor = GUIStyles.primaryColor;
            dayBeforeLabel.ForeColor = GUIStyles.whiteColor;
            dayBeforeAvg.ForeColor = GUIStyles.whiteColor;
        }

        private void dayBeforeAvg_MouseLeave(object sender, EventArgs e)
        {
            dayBeforePanel.BackColor = GUIStyles.backColor;
            dayBeforeLabel.ForeColor = GUIStyles.blackColor;
            dayBeforeAvg.ForeColor = GUIStyles.blackColor;
        }

        private void nextDayPanel_MouseEnter(object sender, EventArgs e)
        {
            nextDayPanel.BackColor = GUIStyles.primaryColor;
            nextDayLabel.ForeColor = GUIStyles.whiteColor;
            nextDayAvg.ForeColor = GUIStyles.whiteColor;
        }

        private void nextDayPanel_MouseLeave(object sender, EventArgs e)
        {
            nextDayPanel.BackColor = GUIStyles.backColor;
            nextDayLabel.ForeColor = GUIStyles.blackColor;
            nextDayAvg.ForeColor = GUIStyles.blackColor;
        }

        private void totalLabel_MouseEnter(object sender, EventArgs e)
        {
            cardPanel1.CardBackColor = GUIStyles.terenaryColor;
        }

        private void totalLabel_MouseLeave(object sender, EventArgs e)
        {
            cardPanel1.CardBackColor = GUIStyles.backColor;
        }

        private void expenseLabel_MouseEnter(object sender, EventArgs e)
        {
            cardPanel2.CardBackColor = GUIStyles.terenaryColor;
        }

        private void expenseLabel_MouseLeave(object sender, EventArgs e)
        {
            cardPanel2.CardBackColor = GUIStyles.backColor;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;            
        }

        private void accountPictureBox_Click(object sender, EventArgs e)
        {
            accountPictureBox.Hide();
            account1.ShowUsername();
            account1.Show();
        }

        private void seeReportLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            account1.Hide();
            accountPictureBox.Show();
            seeReports.Reload();
            seeReports.WalletView += OnSeeReports_WalletView;
        }

        private void OnSeeReports_WalletView(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        public void HomeDashboard_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            seeReportLinkLabel1.Location = new Point(tabPage1.Width - seeReportLinkLabel1.Width - 15, seeReportLinkLabel1.Location.Y);
        }
    }
}
