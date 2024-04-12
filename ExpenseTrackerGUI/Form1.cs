using ExpenseTracker;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            this.DoubleBuffered = true;
            this.Size = new Size(1936, 1056);

            //avgCardPanel.CardFlickerColor = Color.Transparent;
            transactionAddPicturebox.Hide();
            categoryAddPictureBox.Hide();
            budgetAddPictureBox.Hide();

            if (DesignMode) return;
            SetUpChart();
            ShowTransaction();
            ShowTotalAmount();
            ShowBiggestExpense();
        }

        Dictionary<string, float> dict1 = new Dictionary<string, float>();

        private void ShowTransaction()
        {            
            List<ExpenseTrackerDS.Transaction> transactions = Communicator.Manager.FetchTransactions<List<ExpenseTrackerDS.Transaction>>(0);
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
            foreach(var key in dict1)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }

            if (dict1.Count==0)
            {
                todayAvg.Text = "";
                yesterdayLabel.Text = "";
                yesterdayAvg.Text = "";
                dayBeforeLabel.Text = "";
                dayBeforeAvg.Text = "";
                nextDayAvg.Text = "";
            }

            else
            {
                if (dict1.Keys.ElementAt(0) == DateTime.Now.ToString("dd.MM.yyyy"))
                {
                    todayLabel.Text = "Today, " + DateTime.Now.Day;
                }
                else
                {
                    todayLabel.Text = dict1.Keys.ElementAt(0);
                }
                yesterdayLabel.Text = dict1.Keys.ElementAt(1);
                dayBeforeLabel.Text = dict1.Keys.ElementAt(2);
                nextDayLabel.Text = dict1.Keys.ElementAt(3);

                todayAvg.Text = "₹ " + dict1.Values.ElementAt(0);
                yesterdayAvg.Text = "₹ " + dict1.Values.ElementAt(1);
                dayBeforeAvg.Text = "₹ " + dict1.Values.ElementAt(2);
                nextDayAvg.Text = "₹ " + dict1.Values.ElementAt(3);
                backPictureBox.Image = Image.FromFile(@"D:\Santhiya\C#\Images\back3.png");
            }
        }

        private void ShowTotalAmount()
        {
            List<ExpenseTrackerDS.Transaction> transactions = Communicator.Manager.FetchTransactionOnDates<List<ExpenseTrackerDS.Transaction>>(DateTime.Now, DateTime.Now, ExpenseTracker.Manager.ViewType.Month,0);
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

            x = graphAndAddPanel.Width - categoryAddPictureBox.Width - 5;
            y = graphAndAddPanel.Height - categoryAddPictureBox.Height - 280;
            categoryAddPictureBox.Location = new Point(x, y);

            x = graphAndAddPanel.Width - budgetAddPictureBox.Width - 5;
            y = graphAndAddPanel.Height - budgetAddPictureBox.Height - 200;
            budgetAddPictureBox.Location = new Point(x, y);

            x = graphAndAddPanel.Width - transactionAddPicturebox.Width - 5;
            y = graphAndAddPanel.Height - transactionAddPicturebox.Height - 120;
            transactionAddPicturebox.Location = new Point(x, y);

            //searchControl1.Location = new Point(Width-521, searchControl1.Location.Y);

            seeReportLinkLabel1.Location = new Point(tabPage1.Width -seeReportLinkLabel1.Width- 15, seeReportLinkLabel1.Location.Y);            
        }


        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {            
            Graphics gh = e.Graphics;
            using (Brush b = new SolidBrush(Color.GhostWhite))//GUIStyles.terenaryColor))
                gh.FillRectangle(b, 0, 0, Width, Height);
            gh.DrawRectangle(new Pen(GUIStyles.primaryColor), 0, 0, titlePanel.Width - 1, titlePanel.Height - 1);
            gh.DrawRectangle(new Pen(GUIStyles.primaryColor), 10, 76, menuShowPannel.Width - 1, menuShowPannel.Height - 1);
            Console.Write(Width + "" + Height);
            Console.WriteLine("title:  " + titlePanel.Width + " " + titlePanel.Height);
        }

        bool flag = true;

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        int cnt = 0;

        private void timer1_Tick(object sender, EventArgs e)
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

                else if (cnt == 3)
                {
                    categoryAddPictureBox.Show();
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
                    categoryAddPictureBox.Hide();
                }
                else if (cnt == 2)
                {
                    budgetAddPictureBox.Hide();
                }

                else if (cnt == 3)
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

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular); 

            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, new PointF(2, 2));
        }

        private void logoutPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\rename2.png");
            MouseEnterEvent(logoutPictureBox, exitLabel, hoverImage);
        }

        private void logoutPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\rename1.png");
            MouseLeaveEvent(logoutPictureBox, exitLabel, hoverImage);
        }

        private void menuPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\showmenu2.png");
            MouseEnterEvent(menuPictureBox, hoverImage);
        }

        private void menuPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\showmenu.png");
            MouseLeaveEvent(menuPictureBox, hoverImage);
        }

        private void homePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\home2.png");
            MouseEnterEvent(homePictureBox, homeLabel, hoverImage);
        }

        private void homePictureBox_MouseLeave(object sender, EventArgs e)
        {
            homePictureBox.Size = new Size(homePictureBox.Width - 5, homePictureBox.Height - 5);
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\icons8-home-100 (1).png");
            MouseLeaveEvent(homePictureBox, homeLabel, hoverImage);
        }

        private void transactionPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet1.png");
            MouseEnterEvent(transactionPictureBox, transactionLabel, hoverImage);
        }

        private void transactionPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet.png");
            MouseLeaveEvent(transactionPictureBox, transactionLabel, hoverImage);
        }

        private void budgetPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\budget3.png");
            MouseEnterEvent(budgetPictureBox, budgetLabel, hoverImage);
        }

        private void budgetPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\budget1.png");
            MouseLeaveEvent(budgetPictureBox, budgetLabel, hoverImage);
        }

        private void addPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\add2.png");
            MouseEnterEvent(addPictureBox, hoverImage);
        }

        private void addPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\add.png");
            MouseLeaveEvent(addPictureBox, hoverImage);
        }

        private void transactionAddPicturebox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet1.png");
            MouseEnterEvent(transactionAddPicturebox, hoverImage);
        }

        private void transactionAddPicturebox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet.png");
            MouseLeaveEvent(transactionAddPicturebox, hoverImage);
        }

        private void budgetAddPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\budget3.png");
            MouseEnterEvent(budgetAddPictureBox, hoverImage);
        }

        private void budgetAddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\budget1.png");
            MouseLeaveEvent(budgetAddPictureBox, hoverImage);
        }

        private void categoryAddPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\category2.png");
            MouseEnterEvent(categoryAddPictureBox, hoverImage);
        }

        private void categoryAddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\category3.png");
            MouseLeaveEvent(categoryAddPictureBox, hoverImage);
        }

        private void categoryPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\category2.png");
            MouseEnterEvent(categoryPictureBox, categoryLabel, hoverImage);
        }

        private void categoryPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\category3.png");
            MouseLeaveEvent(categoryPictureBox, categoryLabel, hoverImage);
        }

        private void walletPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet3.png");
            MouseEnterEvent(walletPictureBox, walletLabel, hoverImage);
        }

        private void walletPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet2.png");
            MouseLeaveEvent(walletPictureBox, walletLabel, hoverImage);
        }

        private void accountPictureBox_MouseEnter(object sender, EventArgs e)
        {
            //accountPictureBox.Size = new Size(accountPictureBox.Width - 5, accountPictureBox.Height - 5);
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\account1.png");
            accountPictureBox.Image = hoverImage;
            accountPictureBox.Cursor = Cursors.Hand;
        }

        private void accountPictureBox_MouseLeave(object sender, EventArgs e)
        {
            //accountPictureBox.Size = new Size(accountPictureBox.Width + 5, accountPictureBox.Height + 5);
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\account.png");
            accountPictureBox.Image = hoverImage;
            accountPictureBox.Cursor = Cursors.Hand;
        }

        private void SetUpChart()
        {
            List<Tuple<string, float>> result = Communicator.Manager.FetchAmount();

            int y = 1000;
            for(int i = 0; i < 10; i++)
            {
                chart1.Series["Series1"].Points.AddY(y);
                y += 1000;
            }

            foreach(Tuple<string,float> t1 in result)
            {
                chart1.Series["Series1"].Points.AddXY(t1.Item1, t1.Item2);
            }
            //chart1.Series["Series1"].Points.AddXY(1, 15000);
            //chart1.Series["Series1"].Points.AddXY(2, 200);
            //chart1.Series["Series1"].Points.AddXY(3, 150);
            //chart1.Series["Series1"].Points.AddXY(4, 400);
            //chart1.Series["Series1"].Points.AddXY(5, 250);
            //chart1.Series["Series1"].Points.AddXY(6, 250);
            //chart1.Series["Series1"].Points.AddXY(7, 250);
            //chart1.Series["Series1"].Points.AddXY(8, 250);
            //chart1.Series["Series1"].Points.AddXY(9, 250);
            //chart1.Series["Series1"].Points.AddXY(10, 250);
            //chart1.Series["Series1"].Points.AddXY(11, 250);
            //chart1.Series["Series1"].Points.AddXY(12, 250);

            // Hide the gridlines (x lines and y lines)
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
        }

        private void homeLabel_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\home2.png");
            MouseEnterEvent(homePictureBox, homeLabel, hoverImage);
        }

        private void homeLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\icons8-home-100 (1).png");
            MouseLeaveEvent(homePictureBox, homeLabel, hoverImage);
        }

        private void transactionLabel_MouseEnter(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet1.png");
            MouseEnterEvent(transactionPictureBox, transactionLabel, hoverImage);
        }

        private void transactionLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet.png");
            MouseLeaveEvent(transactionPictureBox, transactionLabel, hoverImage);
        }

        private void budgetLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\budget3.png");
            MouseEnterEvent(budgetPictureBox, budgetLabel, hoverImage);
        }

        private void budgetLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\budget1.png");
            MouseLeaveEvent(budgetPictureBox, budgetLabel, hoverImage);
        }

        private void categoryLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\category2.png");
            MouseEnterEvent(categoryPictureBox, categoryLabel, hoverImage);
        }

        private void categoryLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\category3.png");
            MouseLeaveEvent(categoryPictureBox, categoryLabel, hoverImage);
        }

        private void walletLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet3.png");
            MouseEnterEvent(walletPictureBox, walletLabel, hoverImage);
        }

        private void walletLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\wallet2.png");
            MouseLeaveEvent(walletPictureBox, walletLabel, hoverImage);
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {            
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\rename2.png");           
            MouseEnterEvent(logoutPictureBox, exitLabel, hoverImage);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            Image hoverImage = Image.FromFile(@"D:\Santhiya\C#\Images\rename1.png");
            MouseLeaveEvent(logoutPictureBox, exitLabel, hoverImage);
        }

        private void MouseEnterEvent(PictureBox control1,Label control2,Image hoverImage)
        {
            control1.Size = new Size(control1.Width + 5, control1.Height + 5);
            control1.Image = hoverImage;
            control1.Cursor = Cursors.Hand;

            control2.Font= new Font("Arial", 13, FontStyle.Bold);
            control2.ForeColor= Color.FromArgb(192, 192, 255);
        }

        private void MouseLeaveEvent(PictureBox control1,Label control2,Image hoverImage)
        {
            control1.Size = new Size(control1.Width - 5, control1.Height - 5);            
            control1.Image = hoverImage;
            control1.Cursor = Cursors.Hand;

            control2.Font = new Font("Arial", 11, FontStyle.Bold);
            control2.ForeColor = GUIStyles.primaryColor;
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

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            homePanel.BackColor= Color.FromArgb(192, 192, 255);
            homeLabel.ForeColor= GUIStyles.primaryColor;

            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            homePanel.BackColor = Color.FromArgb(192, 192, 255);
            homeLabel.ForeColor = GUIStyles.primaryColor;

            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void transactionLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            transactionPanel.BackColor= Color.FromArgb(192, 192, 255);
            transactionLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void transactionPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            transactionPanel.BackColor = Color.FromArgb(192, 192, 255);
            transactionLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void budgetLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            budgetPanel.BackColor = Color.FromArgb(192, 192, 255);
            budgetLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void budgetPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3; transactionPanel.BackColor = Color.FromArgb(192, 192, 255);
            budgetPanel.BackColor = Color.FromArgb(192, 192, 255);
            budgetLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            categoryPanel.BackColor = Color.FromArgb(192, 192, 255);
            categoryLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void categoryPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            categoryPanel.BackColor = Color.FromArgb(192, 192, 255);
            categoryLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            walletPanel.BackColor = Color.Transparent;
            walletLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void walletLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            walletPanel.BackColor = Color.FromArgb(192, 192, 255);
            walletLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);
        }

        private void walletPictureBox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            walletPanel.BackColor = Color.FromArgb(192, 192, 255);
            walletLabel.ForeColor = GUIStyles.primaryColor;

            homePanel.BackColor = Color.Transparent;
            homeLabel.ForeColor = Color.FromArgb(54, 55, 149);
            budgetPanel.BackColor = Color.Transparent;
            budgetLabel.ForeColor = Color.FromArgb(54, 55, 149);
            transactionPanel.BackColor = Color.Transparent;
            transactionLabel.ForeColor = Color.FromArgb(54, 55, 149);
            categoryPanel.BackColor = Color.Transparent;
            categoryLabel.ForeColor = Color.FromArgb(54, 55, 149);            
        }

        private void transactionAddPicturebox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage6;            
        }

        private void budgetAddPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage7;
        }

        private void categoryAddPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage8;
        }

        private void todayPanel_Paint(object sender, PaintEventArgs e)
        {
            return;
            Graphics gh = e.Graphics;

            Pen colorPen = new Pen(GUIStyles.primaryColor, 5);
            gh.DrawRectangle(colorPen, 2, 2, todayPanel.Width - 5, todayPanel.Height - 5);
        }

        private void yesterdayPanel_Paint(object sender, PaintEventArgs e)
        {
            return;
            Graphics gh = e.Graphics;

            Pen colorPen = new Pen(GUIStyles.primaryColor, 5);
            gh.DrawRectangle(colorPen, 2, 2, yesterdayPanel.Width - 5, yesterdayPanel.Height - 5);
        }

        private void dayBeforePanel_Paint(object sender, PaintEventArgs e)
        {
            return;
            Graphics gh = e.Graphics;

            Pen colorPen = new Pen(GUIStyles.primaryColor, 5);
            gh.DrawRectangle(colorPen, 2, 2, dayBeforePanel.Width - 5, dayBeforePanel.Height - 5);
        }

        private void nextDayPanel_Paint(object sender, PaintEventArgs e)
        {
            return;
            Graphics gh = e.Graphics;

            Pen colorPen = new Pen(GUIStyles.primaryColor, 5);
            gh.DrawRectangle(colorPen, 2, 2, nextDayPanel.Width - 5, nextDayPanel.Height - 5);
        }

        public int count = 0;

        private void nextPictureBox_Click(object sender, EventArgs e)
        {
            count = 1;
            backPictureBox.Image = Image.FromFile(@"D:\Santhiya\C#\Images\back1.png");
            if (count * 4 + 1 <= dict1.Count)
            {
                todayLabel.Text = dict1.Keys.ElementAt(count * 4);
                todayAvg.Text = "₹ "+dict1.Values.ElementAt(count * 4).ToString();
            }

            else
            {
                todayLabel.Text = "";
                todayAvg.Text = "";
                nextPictureBox.Image= Image.FromFile(@"D:\Santhiya\C#\Images\next3.png");
            }

            if (count * 4 + 2 <= dict1.Count)
            {
                yesterdayLabel.Text = dict1.Keys.ElementAt(count * 4 + 1);
                yesterdayAvg.Text = "₹ "+dict1.Values.ElementAt(count * 4 + 1).ToString();
            }

            else
            {
                yesterdayLabel.Text = "";
                yesterdayAvg.Text = "";
                nextPictureBox.Image = Image.FromFile(@"D:\Santhiya\C#\Images\next3.png");
            }

            if (count * 4 + 3 <= dict1.Count)
            {
                dayBeforeLabel.Text = dict1.Keys.ElementAt(count * 4 + 2);
                dayBeforeAvg.Text = "₹ "+dict1.Values.ElementAt(count * 4 + 2).ToString();
            }

            else
            {
                dayBeforeLabel.Text = "";
                dayBeforeAvg.Text = "";
                nextPictureBox.Image = Image.FromFile(@"D:\Santhiya\C#\Images\next3.png");
            }

            if (count * 4 + 4 <= dict1.Count)
            {
                nextDayLabel.Text = dict1.Keys.ElementAt(count * 4 + 3);
                nextDayAvg.Text = "₹ " + dict1.Values.ElementAt(count * 4 + 2).ToString();
            }

            else
            {
                nextDayLabel.Text = "";
                nextDayAvg.Text = "";
                nextPictureBox.Image = Image.FromFile(@"D:\Santhiya\C#\Images\next3.png");
            }
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            count = 1;
            if(count*4 - 4 == 0 ||count * 4 - 3 == 0 || count*4-2==0 || count * 4 - 1 == 0)
            {
                backPictureBox.Image = Image.FromFile(@"D:\Santhiya\C#\Images\back3.png");
            }

            nextPictureBox.Image = Image.FromFile(@"D:\Santhiya\C#\Images\next1.png");

            if (count * 4 - 4 <= 0)
            {
                if (dict1.Keys.ElementAt(count * 4 - 4) == DateTime.Now.ToString("dd.MM.yyyy"))
                {
                    todayLabel.Text = "Today, " + DateTime.Now.Day;
                }
                else
                {
                    todayLabel.Text = dict1.Keys.ElementAt(count * 4 - 4);
                }                
                todayAvg.Text = "₹ "+dict1.Values.ElementAt(count * 4-4).ToString();
            }

            if (count * 4 - 4 <= 0)
            {
                yesterdayLabel.Text = dict1.Keys.ElementAt(count * 4 - 3);
                yesterdayAvg.Text = "₹ "+dict1.Values.ElementAt(count * 4 - 3).ToString();
            }

            if (count * 4 - 4 <= 0)
            {
                dayBeforeLabel.Text = dict1.Keys.ElementAt(count * 4 - 2);
                dayBeforeAvg.Text = "₹ "+dict1.Values.ElementAt(count * 4 - 2).ToString();
            }

            if (count * 4 - 4 <= 0)
            {
                nextDayLabel.Text = dict1.Keys.ElementAt(count * 4 - 1);
                nextDayAvg.Text = "₹ " + dict1.Values.ElementAt(count * 4 - 1).ToString();
            }
        }

        private void todayPanel_MouseEnter(object sender, EventArgs e)
        {
            todayPanel.BackColor= GUIStyles.primaryColor;
            todayLabel.ForeColor = Color.White;
            todayAvg.ForeColor = Color.White;
        }

        private void todayPanel_MouseLeave(object sender, EventArgs e)
        {
            todayPanel.BackColor = GUIStyles.backColor;
            todayLabel.ForeColor = Color.Black;
            todayAvg.ForeColor = Color.Black;
        }

        private void yesterdayPanel_MouseEnter(object sender, EventArgs e)
        {
            yesterdayPanel.BackColor = GUIStyles.primaryColor;
            yesterdayLabel.ForeColor = Color.White;
            yesterdayAvg.ForeColor = Color.White;
        }

        private void yesterdayPanel_MouseLeave(object sender, EventArgs e)
        {
            yesterdayPanel.BackColor = GUIStyles.backColor;
            yesterdayLabel.ForeColor = Color.Black;
            yesterdayAvg.ForeColor = Color.Black;
        }

        private void dayBeforeAvg_MouseEnter(object sender, EventArgs e)
        {
            dayBeforePanel.BackColor = GUIStyles.primaryColor;
            dayBeforeLabel.ForeColor = Color.White;
            dayBeforeAvg.ForeColor = Color.White;
        }

        private void dayBeforeAvg_MouseLeave(object sender, EventArgs e)
        {
            dayBeforePanel.BackColor = GUIStyles.backColor;
            dayBeforeLabel.ForeColor = Color.Black;
            dayBeforeAvg.ForeColor = Color.Black;
        }

        private void nextDayPanel_MouseEnter(object sender, EventArgs e)
        {
            nextDayPanel.BackColor = GUIStyles.primaryColor;
            nextDayLabel.ForeColor = Color.White;
            nextDayAvg.ForeColor = Color.White;
        }

        private void nextDayPanel_MouseLeave(object sender, EventArgs e)
        {
            nextDayPanel.BackColor = GUIStyles.backColor;
            nextDayLabel.ForeColor = Color.Black;
            nextDayAvg.ForeColor = Color.Black;
        }

        private void totalLabel_MouseEnter(object sender, EventArgs e)
        {
           // cardPanel1.CardBackColor = GUIStyles.terenaryColor;
        }

        private void totalLabel_MouseLeave(object sender, EventArgs e)
        {
            //cardPanel1.CardBackColor = GUIStyles.backColor;
        }

        private void expenseLabel_MouseEnter(object sender, EventArgs e)
        {
           // cardPanel2.CardBackColor = GUIStyles.terenaryColor;
        }

        private void expenseLabel_MouseLeave(object sender, EventArgs e)
        {
            //cardPanel2.CardBackColor = GUIStyles.backColor;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //seeReportLinkLabel1.Location = new Point(tabPage1.Width - seeReportLinkLabel1.Width - 15, seeReportLinkLabel1.Location.Y);

        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            SetUpIncomeChart();
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            SetUpExpenseChart();
        }

        private void SetUpIncomeChart()
        {
            //ExpenseTracker.Manager manager = new ExpenseTracker.Manager();
            //List<ExpenseTrackerDS.Category> dataList = manager.FetchCategories(true);

            //List<ExpenseTrackerDS.Transaction> result = new List<ExpenseTrackerDS.Transaction>();

            //foreach(ExpenseTrackerDS.Category category in dataList)
            //{
            //    List<ExpenseTrackerDS.Transaction> transactions = manager.FetchTransactions(category.ID);
            //    foreach(ExpenseTrackerDS.Transaction transaction in transactions)
            //    {
            //        result.Add(transaction);
            //    }
            //}

            //int amount=
            
        }

        private void SetUpExpenseChart()
        {

        }

        private void rating1_Load(object sender, EventArgs e)
        {

        }
    }
}
