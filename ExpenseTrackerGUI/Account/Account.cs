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

namespace ExpenseTrackerGUI.Account
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
            changeBtn.ForeColor = GUIStyles.primaryColor;
            deleteBtn.ForeColor = GUIStyles.primaryColor;
            signOutBtn.ForeColor = GUIStyles.primaryColor;
            changePassword.ForeColor = GUIStyles.primaryColor;
            deleteAccount.ForeColor = GUIStyles.primaryColor;            

            HideFunction();
            resultShowPanel.Hide();
        }

        public void ShowUsername()
        {
            userNameLabel.Text = Communicator.Manager.username;
            emailLabel.Text = Communicator.Manager.mailId;
        }

        private void oldLbl_Click(object sender, EventArgs e)
        {
            oldLbl.Hide();
            oldTextBox.Cursor = Cursors.IBeam;
        }

        private void newLbl_Click(object sender, EventArgs e)
        {
            newLbl.Hide();
        }

        private void OldEyeClose_Click(object sender, EventArgs e)
        {
            if (oldTextBox.PasswordChar == '\0')
            {
                oldEyeShow.BringToFront();
                oldTextBox.PasswordChar = '*';
                oldTextBox.Font = new Font("Arial", 18, FontStyle.Bold);
            }            
        }

        private void newEyeHide_Click(object sender, EventArgs e)
        {
            if (newTextbox.PasswordChar == '\0')
            {
                newEyeShow.BringToFront();
                newTextbox.PasswordChar = '*';
                newTextbox.Font = new Font("Arial", 18, FontStyle.Bold);
            }
        }

        private void oldEyeShow_Click(object sender, EventArgs e)
        {
            if (oldTextBox.PasswordChar == '*')
            {
                OldEyeClose.BringToFront();
                oldTextBox.PasswordChar = '\0';
                oldTextBox.Font = new Font("Arial", 10, FontStyle.Bold);
            }
        }

        private void newEyeShow_Click(object sender, EventArgs e)
        {
            if (newTextbox.PasswordChar == '*')
            {
                newEyeHide.BringToFront();
                newTextbox.PasswordChar = '\0';
                newTextbox.Font = new Font("Arial", 10, FontStyle.Bold);
            }            
        }

        int cnt1 = 0, cnt2 = 0;

        private void changeBtn_Click(object sender, EventArgs e)
        {
            cnt1++;
            cnt2 = 0;
            if (cnt1 % 2 == 0)
            {
                HideFunction();
            }

            else
            {
                ShowFunction();
            }
        }

        private void ShowFunction()
        {
            deletePanel.Location = new Point(3, 410);
            changePicture.Show();
            changeLabel.Show();
            oldLbl.Show();
            newLbl.Show();
            oldTextBox.Show();
            newTextbox.Show();
            oldEyeShow.Show();
            OldEyeClose.Show();
            newEyeHide.Show();
            newEyeShow.Show();
            changePassword.Show();
            passwordPanel.Show();
            panel1.BringToFront();
            panel2.BringToFront();
            panel1.Show();
            panel2.Show();

            infoPanel.Hide();
            infoLabel.Hide();
            info1.Hide();
            info2.Hide();
            info3.Hide();
            picture1.Hide();
            picture2.Hide();
            picture3.Hide();
            deleteAccount.Hide();
        }

        public void HideFunction()
        {
            changePicture.Hide();
            changeLabel.Hide();
            oldLbl.Hide();
            newLbl.Hide();
            oldTextBox.Hide();
            newTextbox.Hide();
            oldEyeShow.Hide();
            OldEyeClose.Hide();
            newEyeHide.Hide();
            newEyeShow.Hide();
            changePassword.Hide();
            passwordPanel.Hide();
            panel1.Hide();
            panel2.Hide();

            infoPanel.Hide();
            infoLabel.Hide();
            info1.Hide();
            info2.Hide();
            info3.Hide();
            picture1.Hide();
            picture2.Hide();
            picture3.Hide();
            deleteAccount.Hide();
        }

        public event EventHandler OnNextPictureClick;

        private void nextPicture_Click(object sender, EventArgs e)
        {
            OnNextPictureClick?.Invoke(this, EventArgs.Empty);            
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            string result = "";
            if (oldTextBox.Text == Communicator.Manager.password)
            {
                Communicator.Manager.mailId = "santhiyadevi1302@gmail.com";
                Communicator.Manager.SwitchDatabase("expense_tracker_application");
                var res = Communicator.Manager.ResetPassword(Communicator.Manager.mailId, newTextbox.Text);
                Communicator.Manager.SwitchDatabase("expensetracker");
                result = "Changed successfully";
            }

            else
            {
                result = "Password incorrect. Please enter correct password.";
            }

            timer1.Start();
            resultShowLbl.Text = result;
        }

        int cnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == 10)
            {
                timer1.Stop();
                resultShowPanel.Hide();
                cnt = 0;
            }
            else
            {
                resultShowPanel.Show();
            }
        }

        public event EventHandler DeleteAccount;
        private void deleteAccount_Click(object sender, EventArgs e)
        {
            Communicator.Manager.RemoveData();
            DeleteAccount?.Invoke(this, EventArgs.Empty);
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            DeleteAccount?.Invoke(this, EventArgs.Empty);
        }

        private void cross1_MouseEnter(object sender, EventArgs e)
        {
            cross2.BringToFront();
        }

        private void cross1_MouseLeave(object sender, EventArgs e)
        {
            cross1.BringToFront();
        }

        public event EventHandler AccountClick;

        private void accountDetailsPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountClick?.Invoke(this, EventArgs.Empty);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            cnt2++;
            cnt1 = 0;
            if (cnt2 % 2 == 0)
            {
                HideFunction();
            }

            else
            {
                changePicture.Hide();
                changeLabel.Hide();
                oldLbl.Hide();
                newLbl.Hide();
                oldTextBox.Hide();
                newTextbox.Hide();
                oldEyeShow.Hide();
                OldEyeClose.Hide();
                newEyeHide.Hide();
                newEyeShow.Hide();
                changePassword.Hide();
                passwordPanel.Hide();
                panel1.Hide();
                panel2.Hide();

                deletePanel.Location = new Point(0, 179);
                infoPanel.Show();
                infoLabel.Show();
                info1.Show();
                info2.Show();
                info3.Show();
                picture1.Show();
                picture2.Show();
                picture3.Show();
                deleteAccount.Show();
            }
        }
    }
}
