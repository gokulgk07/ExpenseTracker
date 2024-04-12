using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace ExpenseTrackerGUI.Account
{
    public partial class WalkThrough : UserControl
    {
        public WalkThrough()
        {
            InitializeComponent();

            label18.Text = "Food & Beverage";
            topPanel.BackColor = GUIStyles.primaryColor;
            bottomPanel.BackColor = GUIStyles.primaryColor;
            rightPanel.BackColor = GUIStyles.primaryColor;
            leftPanel.BackColor = GUIStyles.primaryColor;

            transactionPage.BackColor = GUIStyles.backColor;
            reportPage.BackColor = GUIStyles.backColor;
            budgetPage.BackColor = GUIStyles.backColor;
            calculationsPage.BackColor = GUIStyles.backColor;

            transactionLbl.BackColor = GUIStyles.primaryColor;
            transactionLbl.ForeColor = GUIStyles.whiteColor;
            reportLbl.BackColor = GUIStyles.primaryColor;
            reportLbl.ForeColor = GUIStyles.whiteColor;
            budgetLbl.BackColor = GUIStyles.primaryColor;
            budgetLbl.ForeColor = GUIStyles.whiteColor;
            convertLbl.BackColor = GUIStyles.primaryColor;
            convertLbl.ForeColor = GUIStyles.whiteColor;

            tabControl1.SelectedTab = transactionPage;
            dark1.BringToFront();
            dark2.SendToBack();
            dark3.SendToBack();
            dark4.SendToBack();

            ShowPieChart();

            back1.BackColor = GUIStyles.primaryColor;
            back2.BackColor = GUIStyles.primaryColor;
            back3.BackColor = GUIStyles.primaryColor;
            back4.BackColor = GUIStyles.primaryColor;
        }

        private void ShowPieChart()
        {
            pieChart1.InnerRadius = 30;
            SeriesCollection piechartData = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Rentals",
                    Values = new ChartValues<double> {60},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Gas bill",
                    Values = new ChartValues<double> {50},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Travel",
                    Values = new ChartValues<double> {77},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Food",
                    Values = new ChartValues<double> {55},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Fun Money",
                    Values = new ChartValues<double> {30},
                    DataLabels = true,
                },
            };

            piechartData.Add(
                new PieSeries
                {
                    Title = "Fourth Item",
                    Values = new ChartValues<double> { 25 },
                    DataLabels = true,
                }
            );

            pieChart1.Series = piechartData;
            pieChart1.LegendLocation = LegendLocation.Right;
        }


        private void headingLbl_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = reportPage;
            dark2.BringToFront();
            dark1.SendToBack();
            dark3.SendToBack();
            dark4.SendToBack();
        }

        private void title_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = budgetPage;
            dark3.BringToFront();
            dark1.SendToBack();
            dark2.SendToBack();
            dark4.SendToBack();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = calculationsPage;
            dark4.BringToFront();
            dark1.SendToBack();
            dark2.SendToBack();
            dark3.SendToBack();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = transactionPage;
            dark1.BringToFront();
            dark2.SendToBack();
            dark3.SendToBack();
            dark4.SendToBack();
        }

        private void light1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = transactionPage;
            dark1.BringToFront();
            dark2.SendToBack();
            dark3.SendToBack();
            dark4.SendToBack();
        }

        private void light2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = reportPage;
            dark2.BringToFront();
            dark1.SendToBack();
            dark3.SendToBack();
            dark4.SendToBack();
        }

        private void light3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = budgetPage;
            dark3.BringToFront();
            dark1.SendToBack();
            dark2.SendToBack();
            dark4.SendToBack();
        }

        private void light4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = calculationsPage;
            dark4.BringToFront();
            dark1.SendToBack();
            dark2.SendToBack();
            dark3.SendToBack();
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(pictureBox12.Width + 5, pictureBox12.Height + 5);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(pictureBox12.Width - 5, pictureBox12.Height - 5);
        }

        public event EventHandler walkthroughBackClick;

        private void back1_Click(object sender, EventArgs e)
        {
            walkthroughBackClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
