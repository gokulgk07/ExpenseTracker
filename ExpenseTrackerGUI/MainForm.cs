using ExpenseTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1174, 775);
            this.Location = new Point(390, 160);
            loginPage1.Show();
            loginPage1.LoginSuccessful += OnLoginPage1_LoginSuccessful;
            //homeDashboard1 = new HomeDashboard();
            //homeDashboard1.Dock = DockStyle.Fill;
            Console.WriteLine(this.Size);
            homeDashboard1 = new HomeDashboard();
            this.Controls.Add(homeDashboard1);
            homeDashboard1.Hide();
            ratingPanel.BackColor = GUIStyles.primaryColor;
            ratingPanel.Hide();
            ratingLbl.Hide();
            rating1.Hide();
            mayBeLaterBtn.Hide();
            submitBtn.Hide();
            close.Hide();
        }

        private void OnLoginPage1_LoginSuccessful(object sender, EventArgs e)
        {
            loginPage1.Hide();
            this.WindowState = FormWindowState.Maximized;
            homeDashboard1 = new HomeDashboard();
            this.Controls.Add(homeDashboard1);
            homeDashboard1.Dock = DockStyle.Fill;            
            homeDashboard1.Show();
            homeDashboard1.HomeDashboard_Load(this,EventArgs.Empty);
            //this.Size = new Size(1173, 773);
            //this.Location = new Point(390, 160);

            homeDashboard1.OnExitClick += OnHomeDashboard1_OnExitClick;
            homeDashboard1.HideHomeDashboard += OnHomeDashboard1_HideHomeDashboard;
            homeDashboard1.UpdateFunctions();
        }

        HomeDashboard homeDashboard1;

        private void OnHomeDashboard1_HideHomeDashboard(object sender, EventArgs e)
        {
            homeDashboard1.Hide();
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1174, 775);
            this.Location = new Point(390, 160);
            loginPage1.Show();
        }

        private void OnHomeDashboard1_OnExitClick(object sender, EventArgs e)
        {
            List<ExpenseTrackerDS.Rating> res = Communicator.Manager.FetchRating();

            if (res.Count==0 || (res.Count>0 && res[0].Account_Id == 1 && res[0].Rated==false))
            {
                ratingTimer.Stop();
                ratingPanel.Show();
                ratingLbl.Show();
                rating1.Show();
                mayBeLaterBtn.Show();
                submitBtn.Show();
                close.Show();
                ratingLbl.BringToFront();
                mayBeLaterBtn.BringToFront();
                close.BringToFront();
                rating1.BringToFront();
                submitBtn.BringToFront();
            }

            else
            {
                this.Close();
            }            
        }

        private void mayBeLaterBtn_Click(object sender, EventArgs e)
        {                       
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            ExpenseTrackerDS.Rating rating = new ExpenseTrackerDS.Rating();
            rating.Account_Id = 1;
            rating.Account_Name = "ABCD123400009";
            rating.Rating_Value = rating1.finalAns;
            rating.Rated = true;

            Communicator.Manager.AddData(rating);
            this.Close();
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            rating1.Hide();
            ratingPanel.Hide();
            submitBtn.Hide();
            mayBeLaterBtn.Hide();
            ratingLbl.Hide();
            close.Hide();
            //homeDashboard1.Show();
        }
    }
}
