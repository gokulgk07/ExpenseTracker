using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker;
using LiveCharts.Wpf;
using LiveCharts;
using ExpenseTrackerDS;

namespace ExpenseTrackerGUI.Account
{
    public partial class CategoryReport : UserControl
    {
        public CategoryReport()
        {
            InitializeComponent();
            if (DesignMode) return;
            ShowFunction();
            AddOptions();
            date3Panel.BackColor = GUIStyles.primaryColor;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = GUIStyles.whiteColor;
            seletedType = monthLabel.Text;

            ShowChart(dt, Manager.ViewType.Month);
            MonthPanel_Click_1(this, EventArgs.Empty);
            ViewByDateIndexChanged();
            noTransactionPanel.Hide();
        }

        public event EventHandler BackClick;

        private void ShowChart(DateTime dt, Manager.ViewType view)
        {
            Dictionary<string, List<ExpenseTrackerDS.Transaction>> res = new Dictionary<string, List<ExpenseTrackerDS.Transaction>>();
            if (isAll)
            {
                var result = Communicator.Manager.FetchTransactions<List<Transaction>>(0);
                for (int i = 0; i < result.Count; i++)
                {
                    if (res.ContainsKey(result[i].CategoryName))
                    {
                        res[result[i].CategoryName].Add(result[i]);
                    }
                    else
                    {
                        res.Add(result[i].CategoryName, new List<ExpenseTrackerDS.Transaction>() { result[i] });
                    }
                }
            }

            else
            {
                res = Communicator.Manager.FetchTransactionOnDates<Dictionary<string, List<ExpenseTrackerDS.Transaction>>>(dt, dt, view,0);
            }

            barChart.Series.Clear();
            barChart.AxisX.Clear();
            barChart.AxisY.Clear();

            ColumnSeries columnSeries = new ColumnSeries();
            Axis axisX = new Axis();
            Axis axisY = new Axis();

            if (res != null && res.Count > 0)
            {
                noTransactionPanel.Hide();
                chartPanel.Show();
                columnSeries = new ColumnSeries()
                {
                    DataLabels = true,
                    Values = new ChartValues<float>(),
                    LabelPoint = point => point.Y.ToString(),
                };

                axisX = new Axis()
                {
                    Separator = new Separator() { Step = 1, IsEnabled = false },
                    Labels = new List<string>()
                };

                axisY = new Axis()
                {
                    LabelFormatter = y => y.ToString(),
                    Separator = new Separator()
                };

                barChart.Series.Add(columnSeries);
                barChart.AxisX.Add(axisX);
                barChart.AxisY.Add(axisY);

                float total = 0;

                foreach (var d in res)
                {
                    foreach (ExpenseTrackerDS.Transaction t in d.Value)
                    {
                        total += t.Amount;
                    }
                }

                if (total == 0)
                {
                    noTransactionPanel.Show();
                }

                else
                {
                    noTransactionPanel.Hide();
                }

                foreach (var d in res)
                {
                    float t = 0;
                    foreach (ExpenseTrackerDS.Transaction t1 in d.Value)
                    {
                        t += t1.Amount;
                    }
                    float amount = (int)(t / total * 100);
                    columnSeries.Values.Add(amount);
                    axisX.Labels.Add(d.Key);
                }
            }

            else
            {
                chartPanel.Hide();
                noTransactionPanel.Location = new Point(150, 400);
                noTransactionPanel.Show();
                noTransactionPanel.BringToFront();
            }
        }

        private void ShowFunction()
        {
            borderPanel.Location = new Point(112, 272);
            borderPanel.BringToFront();
            this.BackColor = GUIStyles.backColor;
            topPanel.BackColor = GUIStyles.primaryColor;
            bottomPanel.BackColor = GUIStyles.primaryColor;
            leftPanel.BackColor = GUIStyles.primaryColor;
            rightPanel.BackColor = GUIStyles.primaryColor;

            date1Panel.BackColor = GUIStyles.primaryColor;
            date2Panel.BackColor = GUIStyles.primaryColor;
            date3Panel.BackColor = GUIStyles.primaryColor;

            date1.BackColor = GUIStyles.whiteColor;
            date2.BackColor = GUIStyles.whiteColor;
            date3.BackColor = GUIStyles.primaryColor;

            date1.FlatAppearance.BorderColor = GUIStyles.primaryColor;
            date2.FlatAppearance.BorderColor = GUIStyles.primaryColor;
            date3.FlatAppearance.BorderColor = GUIStyles.primaryColor;

            date1.FlatAppearance.BorderSize = 2;
            date2.FlatAppearance.BorderSize = 2;
            date3.FlatAppearance.BorderSize = 2;

            date1.ForeColor = GUIStyles.primaryColor;
            date2.ForeColor = GUIStyles.primaryColor;
            date3.ForeColor = GUIStyles.whiteColor;

            date1Panel.Hide();
            date2Panel.Hide();
            date3Panel.Hide();

            dayTick.Hide();
            weekTick.Hide();
            quarterTick.Hide();
            yearTick.Hide();
            allTick.Hide();
            customTick.Hide();

            timeSelectPanel.Hide();
            borderPanel.Hide();
            borderPanel.BackColor = GUIStyles.primaryColor;
            timeSelectPanel.BackColor = GUIStyles.backColor;
            border1.BackColor = GUIStyles.primaryColor;
            borderPanel.BringToFront();
        }

        private void CategoryReport_Load(object sender, EventArgs e)
        {
            ShowChart(dt, Manager.ViewType.Month);
            choicePicture.Location = new Point(this.Width - rightPanel.Width - choicePicture.Width - 50, choicePicture.Location.Y);

            categoryReportLabel.ForeColor = GUIStyles.primaryColor;
            topPanel.BackColor = GUIStyles.primaryColor;
            bottomPanel.BackColor = GUIStyles.primaryColor;
            rightPanel.BackColor = GUIStyles.primaryColor;
            leftPanel.BackColor = GUIStyles.primaryColor;

            borderPanel.BackColor = GUIStyles.primaryColor;
            timeSelectPanel.BackColor = GUIStyles.backColor;
            borderPanel.Hide();

           // BackClick?.Invoke(this, EventArgs.Empty);
        }

        List<string> viewday = new List<string>();
        List<string> viewweek = new List<string>();
        List<string> viewmonth = new List<string>();
        List<string> viewquarter = new List<string>();
        List<string> viewyear = new List<string>();

        private void AddOptions()
        {
            if (viewday.Count == 0 && viewweek.Count == 0 && viewmonth.Count == 0 && viewquarter.Count == 0 && viewyear.Count == 0)
            {
                TransactionEditor.AddDay();
                TransactionEditor.AddWeek();
                TransactionEditor.AddMonth();
                TransactionEditor.AddQuarter();
                TransactionEditor.AddYear();
                viewday = new List<string>(TransactionEditor.viewday);
                viewweek = new List<string>(TransactionEditor.viewweek);
                viewmonth = new List<string>(TransactionEditor.viewmonth);
                viewquarter = new List<string>(TransactionEditor.viewquarter);
                viewyear = new List<string>(TransactionEditor.viewyear);
                viewday.RemoveAt(TransactionEditor.viewday.Count - 1);
                viewweek.RemoveAt(TransactionEditor.viewweek.Count - 1);
                viewmonth.RemoveAt(TransactionEditor.viewmonth.Count - 1);
                viewquarter.RemoveAt(TransactionEditor.viewquarter.Count - 1);
                viewyear.RemoveAt(TransactionEditor.viewyear.Count - 1);
            }
        }

        DateTime dt;

        private void FindData()
        {
            string str = "";

            if (date1Panel.BackColor == GUIStyles.primaryColor)
                str = date1.Text;
            else if (date2Panel.BackColor == GUIStyles.primaryColor)
                str = date2.Text;
            else if (date3Panel.BackColor == GUIStyles.primaryColor)
                str = date3.Text;

            if (seletedType == "Day")
            {
                dt = TransactionEditor.FindDay(str);
                ShowChart(dt, Manager.ViewType.Day);
            }

            else if (seletedType == "Week")
            {
                dt = TransactionEditor.FindWeek(str);
                ShowChart(dt, Manager.ViewType.Week);
            }

            else if (seletedType == "Month")
            {
                dt = TransactionEditor.FindMonth(str);
                ShowChart(dt, Manager.ViewType.Month);
            }

            else if (seletedType == "Quarter")
            {
                dt = TransactionEditor.FindQuarter(str);
                ShowChart(dt, Manager.ViewType.Quarter);
            }

            else if (seletedType == "Year")
            {
                dt = TransactionEditor.FindYear(str);
                ShowChart(dt, Manager.ViewType.Year);
            }
        }

        private void ViewByDateIndexChanged()
        {
            if (seletedType == "Day")
            {
                presentday = viewday.Count - 3;
                date1.Text = viewday[presentday];
                date2.Text = viewday[presentday + 1];
                date3.Text = viewday[presentday + 2];
            }
            else if (seletedType == "Week")
            {
                presentweek = viewweek.Count - 3;
                date1.Text = viewweek[presentweek];
                date2.Text = viewweek[presentweek + 1];
                date3.Text = viewweek[presentweek + 2];
            }
            else if (seletedType == "Month")
            {
                presentmonth = viewmonth.Count - 3;
                date1.Text = viewmonth[presentmonth];
                date2.Text = viewmonth[presentmonth + 1];
                date3.Text = viewmonth[presentmonth + 2];
            }
            else if (seletedType == "Quarter")
            {
                presentquarter = viewquarter.Count - 3;
                date1.Text = viewquarter[presentquarter];
                date2.Text = viewquarter[presentquarter + 1];
                date3.Text = viewquarter[presentquarter + 2];
            }
            else if (seletedType == "Year")
            {
                presentyear = viewyear.Count - 3;
                date1.Text = viewyear[presentyear];
                date2.Text = viewyear[presentyear + 1];
                date3.Text = viewyear[presentyear + 2];
            }
            FindData();
        }
        static string seletedType = "";
        int presentmonth = 0, presentyear = 0, presentday = 0, presentquarter = 0, presentweek;

        private void Button1Color()
        {
            ActiveControl = date1;
            date1Panel.BackColor = GUIStyles.primaryColor;
            date2Panel.BackColor = GUIStyles.whiteColor;
            date3Panel.BackColor = GUIStyles.whiteColor;
        }

        private void Button2Color()
        {
            ActiveControl = date2;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = GUIStyles.primaryColor;
            date3Panel.BackColor = GUIStyles.whiteColor;
        }

        private void Button3Color()
        {
            ActiveControl = date3;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = Color.White;
            date3Panel.BackColor = GUIStyles.primaryColor;
        }

        private void date3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            date2.BackColor = GUIStyles.primaryColor;
            date2.ForeColor = GUIStyles.whiteColor;
            date3.ForeColor = GUIStyles.primaryColor;
            date3.BackColor = GUIStyles.whiteColor;
            if (btn == date1)
            {
                //date1.BackColor = GUIStyles.primaryColor;

                if (seletedType == "Day")
                {
                    if (presentday - 1 >= 0)
                    {
                        presentday--;
                        date1.Text = viewday[presentday];
                        date2.Text = viewday[presentday + 1];
                        date3.Text = viewday[presentday + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date1Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button1Color();
                    }
                }
                else if (seletedType == "Week")
                {
                    if (presentweek - 1 >= 0)
                    {
                        presentweek--;
                        date1.Text = viewweek[presentweek];
                        date2.Text = viewweek[presentweek + 1];
                        date3.Text = viewweek[presentweek + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date1Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button1Color();
                    }
                }
                else if (seletedType == "Month")
                {
                    if (presentmonth - 1 >= 0)
                    {
                        presentmonth--;
                        date1.Text = viewmonth[presentmonth];
                        date2.Text = viewmonth[presentmonth + 1];
                        date3.Text = viewmonth[presentmonth + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date1Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button1Color();
                    }
                }
                else if (seletedType == "Quarter")
                {
                    if (presentquarter - 1 >= 0)
                    {
                        presentquarter--;
                        date1.Text = viewquarter[presentquarter];
                        date2.Text = viewquarter[presentquarter + 1];
                        date3.Text = viewquarter[presentquarter + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date1Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button1Color();
                    }
                }
                else if (seletedType == "Year")
                {
                    if (presentyear - 1 >= 0)
                    {
                        presentyear--;
                        date1.Text = viewyear[presentyear];
                        date2.Text = viewyear[presentyear + 1];
                        date3.Text = viewyear[presentyear + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date1Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button1Color();
                    }
                }
                FindData();
            }

            else if (btn == date2)
            {
                //date2.BackColor = GUIStyles.primaryColor;
                if (date2Panel.BackColor == GUIStyles.primaryColor)
                {
                    return;
                }
                Button2Color();
                FindData();
            }

            else if (btn == date3)
            {
                //date3.BackColor = GUIStyles.primaryColor;
                if (seletedType == "Day")
                {
                    if (presentday + 1 <= viewday.Count - 3)
                    {
                        presentday++;
                        date1.Text = viewday[presentday];
                        date2.Text = viewday[presentday + 1];
                        date3.Text = viewday[presentday + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date3Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button3Color();
                    }
                }
                else if (seletedType == "Week")
                {
                    if (presentweek + 1 <= viewweek.Count - 3)
                    {
                        presentweek++;
                        date1.Text = viewweek[presentweek];
                        date2.Text = viewweek[presentweek + 1];
                        date3.Text = viewweek[presentweek + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date3Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button3Color();
                    }
                }
                else if (seletedType == "Month")
                {
                    if (presentmonth + 1 <= viewmonth.Count - 3)
                    {
                        presentmonth++;
                        date1.Text = viewmonth[presentmonth];
                        date2.Text = viewmonth[presentmonth + 1];
                        date3.Text = viewmonth[presentmonth + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date3Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button3Color();
                    }
                }
                else if (seletedType == "Quarter")
                {
                    if (presentquarter + 1 <= viewquarter.Count - 3)
                    {
                        presentquarter++;
                        date1.Text = viewquarter[presentquarter];
                        date2.Text = viewquarter[presentquarter + 1];
                        date3.Text = viewquarter[presentquarter + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date3Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button3Color();
                    }
                }
                else if (seletedType == "Year")
                {
                    if (presentyear + 1 <= viewyear.Count - 3)
                    {
                        presentyear++;
                        date1.Text = viewyear[presentyear];
                        date2.Text = viewyear[presentyear + 1];
                        date3.Text = viewyear[presentyear + 2];
                        Button2Color();
                    }
                    else
                    {
                        if (date3Panel.BackColor == GUIStyles.primaryColor)
                        {
                            return;
                        }
                        Button3Color();
                    }
                }
                FindData();
            }
        }

        int cnt = 0;
        bool isAll = false;

        private void backPicture_Click(object sender, EventArgs e)
        {
            BackClick?.Invoke(this, EventArgs.Empty);
        }

        private void choicePicture_Click_1(object sender, EventArgs e)
        {
            noTransactionPanel.Hide();
            noTransactionPanel.SendToBack();
            date3.BackColor = GUIStyles.primaryColor;
            date3.ForeColor = GUIStyles.whiteColor;
            date2.ForeColor = GUIStyles.primaryColor;
            date2.BackColor = GUIStyles.whiteColor;
            cnt++;

            if (cnt % 2 != 0)
            {
                borderPanel.Show();
                categoryReportPanel.Enabled = false;
                choiceShowPanel.Enabled = false;
                chartPanel.Enabled = false;
                timeSelectPanel.Show();
                timeSelectPanel.BringToFront();
            }

            else
            {
                borderPanel.Hide();
                timeSelectPanel.Hide();
            }
        }

        private void dayPanel_Click_1(object sender, EventArgs e)
        {
            isAll = false;
            categoryReportPanel.Enabled = true;
            choiceShowPanel.Enabled = true;
            chartPanel.Enabled = true;
            dayTick.Show();
            weekTick.Hide();
            monthTick.Hide();
            quarterTick.Hide();
            yearTick.Hide();
            allTick.Hide();
            customTick.Hide();

            seletedType = "Day";

            borderPanel.Hide();
            timeSelectPanel.Hide();
            date3Panel.BackColor = GUIStyles.primaryColor;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = GUIStyles.whiteColor;

            ViewByDateIndexChanged();

            date1.Show();
            date2.Show();
            date3.Show();
        }

        private void weekPanel_Click_1(object sender, EventArgs e)
        {
            isAll = false;
            categoryReportPanel.Enabled = true;
            choiceShowPanel.Enabled = true;
            chartPanel.Enabled = true;
            dayTick.Hide();
            weekTick.Show();
            monthTick.Hide();
            quarterTick.Hide();
            yearTick.Hide();
            allTick.Hide();
            customTick.Hide();

            seletedType = "Week";

            borderPanel.Hide();
            timeSelectPanel.Hide();

            date3Panel.BackColor = GUIStyles.primaryColor;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = GUIStyles.whiteColor;
            ViewByDateIndexChanged();

            date1.Show();
            date2.Show();
            date3.Show();
        }

        private void MonthPanel_Click_1(object sender, EventArgs e)
        {
            isAll = false;
            categoryReportPanel.Enabled = true;
            choiceShowPanel.Enabled = true;
            chartPanel.Enabled = true;
            dayTick.Hide();
            weekTick.Hide();
            monthTick.Show();
            quarterTick.Hide();
            yearTick.Hide();
            allTick.Hide();
            customTick.Hide();

            seletedType = "Month";

            borderPanel.Hide();
            timeSelectPanel.Hide();

            date3Panel.BackColor = GUIStyles.primaryColor;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = GUIStyles.whiteColor;
            ViewByDateIndexChanged();

            date1.Show();
            date2.Show();
            date3.Show();
        }

        private void barpanel_Click(object sender, EventArgs e)
        {
            barpanel.BringToFront();
            hidepiePanel.BringToFront();
        }

        private void hidepiePanel_Click(object sender, EventArgs e)
        {
            piepanel.BringToFront();
            hidebarPanel.BringToFront();
        }

        private void hidebarPanel_Click(object sender, EventArgs e)
        {
            barpanel.BringToFront();
            hidepiePanel.BringToFront();
        }

        private void piepanel_Click(object sender, EventArgs e)
        {
            piepanel.BringToFront();
            hidebarPanel.BringToFront();
        }

        private void quarterPanel_Click_1(object sender, EventArgs e)
        {
            isAll = false;
            categoryReportPanel.Enabled = true;
            choiceShowPanel.Enabled = true;
            chartPanel.Enabled = true;
            dayTick.Hide();
            weekTick.Hide();
            monthTick.Hide();
            quarterTick.Show();
            yearTick.Hide();
            allTick.Hide();
            customTick.Hide();

            seletedType = "Quarter";

            borderPanel.Hide();
            timeSelectPanel.Hide();

            date3Panel.BackColor = GUIStyles.primaryColor;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = GUIStyles.whiteColor;
            ViewByDateIndexChanged();

            date1.Show();
            date2.Show();
            date3.Show();
        }

        private void yearPanel_Click_1(object sender, EventArgs e)
        {
            isAll = false;
            categoryReportPanel.Enabled = true;
            choiceShowPanel.Enabled = true;
            chartPanel.Enabled = true;
            dayTick.Hide();
            weekTick.Hide();
            monthTick.Hide();
            quarterTick.Hide();
            yearTick.Show();
            allTick.Hide();
            customTick.Hide();

            seletedType = "Year";

            borderPanel.Hide();
            timeSelectPanel.Hide();

            date3Panel.BackColor = GUIStyles.primaryColor;
            date1Panel.BackColor = GUIStyles.whiteColor;
            date2Panel.BackColor = GUIStyles.whiteColor;
            ViewByDateIndexChanged();

            date1.Show();
            date2.Show();
            date3.Show();
        }

        private void allPanel_Click_1(object sender, EventArgs e)
        {
            isAll = true;
            categoryReportPanel.Enabled = true;
            choiceShowPanel.Enabled = true;
            chartPanel.Enabled = true;
            dayTick.Hide();
            weekTick.Hide();
            monthTick.Hide();
            quarterTick.Hide();
            yearTick.Hide();
            allTick.Show();
            customTick.Hide();

            seletedType = "All";

            borderPanel.Hide();
            timeSelectPanel.Hide();
            ViewByDateIndexChanged();

            date1.Hide();
            date2.Hide();
            date3.Hide();
            ShowChart(DateTime.Now, Manager.ViewType.Custom);
        }

        private void customPanel_Click_1(object sender, EventArgs e)
        {
            isAll = false;
            categoryReportPanel.Enabled = true;
            choiceShowPanel.Enabled = true;
            chartPanel.Enabled = true;
            dayTick.Hide();
            weekTick.Hide();
            monthTick.Hide();
            quarterTick.Hide();
            yearTick.Hide();
            allTick.Hide();
            customTick.Show();

            seletedType = "Custom";

            borderPanel.Hide();
            timeSelectPanel.Hide();
            ViewByDateIndexChanged();
        }
    }
}
