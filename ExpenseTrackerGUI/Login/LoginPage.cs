using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Drawing.Drawing2D;
using System.Net;
using ExpenseTracker;
using System.Text.RegularExpressions;

namespace ExpenseTrackerGUI
{
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
            resendTimer.Interval = 1000;
            LoadTimer.Interval = 3000;
            connectionErrorTimer.Interval = 5000;
            resendTimer.Tick += OnResendTimerTicked;
            LoadTimer.Tick += OnLoadTimerTicked;
            connectionErrorTimer.Tick += OnConnectionErrorTimerTicked;
            signInPanel.Show();
            signUpPanel.Hide();
            otpPanel.Hide();
            resetPanel.Hide();
            eyePanel1.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
            eyePanel2.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
            loginEyePanel.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
            signUpEyePanel1.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
            signUpEyePanel2.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
            resetPasswordTextBox.TextChanged += OnPasswordTextBoxTextChanged;
            resetConfirmPasswordTextBox.TextChanged += OnPasswordTextBoxTextChanged;
            signUpConfirmPasswordTextBox.TextChanged += OnPasswordTextBoxTextChanged;
            signUpPasswordTextBox.TextChanged += OnPasswordTextBoxTextChanged;
            Communicator.Manager.SwitchDatabase("expense_tracker_application");
            internetIssueLbl.Hide();
        }

        public event EventHandler LoginSuccessful;

        private LoadingForm loading = new LoadingForm();

        private Timer connectionErrorTimer = new Timer();

        private Timer resendTimer = new Timer();

        private Timer LoadTimer = new Timer();

        private Random rand = new Random();

        private SmtpClient client = new SmtpClient("smtp.gmail.com");

        private bool one = false, two = false, three = false, four = false , forgetPass = false;

        private int strengthCount = 0 , resendTime = 20 , random = 1804 , cornerRadius = 10;

        private readonly string specialCharacters = @"~!@#$%^&*(){}|";

        private readonly string fromEmail = "lucidsdi07@gmail.com";

        private readonly string password = "hzyk urco fern xazt";

        private readonly string subject = "OTP VERIFICATION";

        private string toEmail = "sujithar0812@gmail.com";
        
        private string body = "";

        public int CornerRadius
        {
            get => cornerRadius;

            set
            {
                cornerRadius = value;
                Invalidate();
            }
        }
        
        public void InitializeOtpPanel()
        {
            resendTimer.Start();
        }
        
        private void OnResendTimerTicked(object sender, EventArgs e)
        {
            timerLbl.Text = resendTime.ToString();
            resendTime--;
            if (resendTime == 0)
            {
                resendTime = 20;
                timerLbl.Text = "";
                resendTimer.Stop();
                resendOTPLbl.Enabled = true;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            tableLayoutPanel.Height = (int)((Height / 100) * 12.0);
            imagePanel.Width = Width / 2;
        }

        private void OnForgetPasswordLblMouseEntered(object sender, EventArgs e)
        {
            if (sender is System.Windows.Controls.Label lbl && lbl.Name == "forgetPasswordLbl")
                forgetPasswordLbl.Font = new Font("Arial", (float)8.75);
            else
                signUpLbl.Font = new Font("Arial", (float)8.75);
        }

        private void OnForgetPasswordLblMouseLeaved(object sender, EventArgs e)
        {
            if (sender is System.Windows.Controls.Label lbl && lbl.Name == "forgetPasswordLbl")
                forgetPasswordLbl.Font = new Font("Arial", (float)8.25);
            else
                signUpLbl.Font = new Font("Arial", (float)8.25);
        }

        private void OnBackPBMouseEntered(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Image.FromFile(@".\Images\back2.png");
        }

        private void OnBackPBMouseLeaved(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Image.FromFile(@".\Images\back1.png");
        }

        private void OnBackPBClicked(object sender, EventArgs e)
        {
            resendTimer.Stop();
            otpTextBox.TextBoxtext = "";
            resendOTPLbl.Enabled = false;
            timerLbl.Text = "";
            if(forgetPass)
            {
                otpPanel.Hide();
                signInPanel.Show();
                forgetPass = false;
                return;
            }
            otpPanel.Hide();
            signUpPanel.Show();
        }

        #region Completed

        private bool SendMail()
        {
            client.Port = 587;
            client.Credentials = new NetworkCredential(fromEmail, password);
            client.EnableSsl = true;
            body = $"Your OTP for the login is {random}  \n don\'t share the OTP with anyone!";
            MailMessage message = new MailMessage(fromEmail, toEmail, subject, body);
            LoadTimer.Start();
            loading.ShowDialog();
            try
            {
                client.Send(message);
                Console.WriteLine("Email sent successfully!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email: {ex.Message}");
                return false;
            }
            
        }

        private void OnVerifyBtnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(otpTextBox.TextBoxtext))
            {
                errorProvider.SetError(otpTextBox, "Enter OTP");
            }
            else
            {
                errorProvider.SetError(otpTextBox, "");
            }
            if (random == ConvertToInt(otpTextBox.TextBoxtext))
            {
                //Successfull
                if(forgetPass)
                {
                    PageShow(4);
                    return;
                }
                Communicator.Manager.SwitchDatabase("expense_tracker_application");
                bool res = Communicator.Manager.AddUser(signUpNameTextBox.TextBoxtext, toEmail, signUpPasswordTextBox.TextBoxtext);
                PageShow(1);
            }
            else
            {
                errorProvider.SetError(otpTextBox, "Wrong OTP");
                //wrong otp 
            }
        }

        private void OnexitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnForgetPasswordLblClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginMailTextBox.TextBoxtext))
            {
                errorProvider.SetError(loginMailTextBox, "Enter mail");
            }
            else if (!IsValidEmail(loginMailTextBox.TextBoxtext))
            {
                errorProvider.SetError(loginMailTextBox, "Enter valid email");
            }
            else if ((Communicator.Manager.IsUserExits(loginMailTextBox.TextBoxtext.ToLower(), "",out string temp)) && temp == "Email doesnot exits")
            {
                //check mail not exists in db
                errorProvider.SetError(loginMailTextBox, "Mail id does not exists");
            }
            else
            {
                forgetPass = true;
                toEmail = loginMailTextBox.TextBoxtext.ToLower();
                PageShow(3);
            }
        }

        private void OnResetBtnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(resetPasswordTextBox.TextBoxtext))
            {
                errorProvider.SetError(resetPasswordTextBox, "Enter password");
                return;
            }
            else
            {
                errorProvider.SetError(resetPasswordTextBox, "");
            }
            if (string.IsNullOrWhiteSpace(resetConfirmPasswordTextBox.TextBoxtext))
            {
                errorProvider.SetError(resetConfirmPasswordTextBox, "Enter password");
                return;
            }
            else
            {
                errorProvider.SetError(resetConfirmPasswordTextBox, "");
            }

            if (resetConfirmPasswordTextBox.TextBoxtext == resetPasswordTextBox.TextBoxtext && strengthCount == 4)
            {
                //reset
                Communicator.Manager.SwitchDatabase("expense_tracker_application");
                Communicator.Manager.ResetPassword(toEmail, resetPasswordTextBox.TextBoxtext);
                PageShow(1);
            }
        }

        private void OnSignInLblClicked(object sender, EventArgs e)
        {
            PageShow(1);
        }

        private void OnSignUpLblClicked(object sender, EventArgs e)
        {
            PageShow(2);
        }

        private void OnSignInBtnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginMailTextBox.TextBoxtext))
            {
                errorProvider.SetError(loginMailTextBox, "Enter email ");
                return;
            }
            else
            {
                errorProvider.SetError(loginMailTextBox, "");
            }
            if (string.IsNullOrWhiteSpace(loginPasswordTextBox.TextBoxtext))
            {
                errorProvider.SetError(loginPasswordTextBox, "Enter password");
                return;
            }
            else
            {
                errorProvider.SetError(loginPasswordTextBox, "");
            }

            if (IsValidEmail(loginMailTextBox.TextBoxtext))
            {
                errorProvider.SetError(loginMailTextBox, "");
                Communicator.Manager.SwitchDatabase("expense_tracker_application");
                bool res = Communicator.Manager.IsUserExits(loginMailTextBox.TextBoxtext.ToLower(), loginPasswordTextBox.TextBoxtext, out string resultMsg);
                if (!res)
                {
                    if (resultMsg == "Email doesnot exits")
                    {
                        errorProvider.SetError(loginPasswordTextBox, "");
                        errorProvider.SetError(loginMailTextBox, "Email doesnot exists , click signup for creating new account!");
                        return;
                    }
                    else
                    {
                        errorProvider.SetError(loginMailTextBox, "");
                        errorProvider.SetError(loginPasswordTextBox, "Password not matched , Click forget password to change password!");
                        return;
                    }
                }
                else
                {
                    Communicator.Manager.mailId = loginMailTextBox.TextBoxtext.ToLower();
                    Communicator.Manager.password = loginPasswordTextBox.TextBoxtext;
                    Communicator.Manager.GetUserName(Communicator.Manager.mailId);
                    //successful - Show gif 

                    LoginSuccessful?.Invoke(this, e);
                }
                //check whether the email exisits in db
                //check whether the email and password matches
                //
            }
            else
            {
                //Show enter valid email address
                errorProvider.SetError(loginMailTextBox, "Enter valid email ");
                return;
            }
        }

        private void OnSignUpBtnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signUpNameTextBox.TextBoxtext))
            {
                errorProvider.SetError(signUpNameTextBox, "Enter name ");
                return;
            }
            else
            {
                errorProvider.SetError(signUpNameTextBox, "");
            }
            if (string.IsNullOrWhiteSpace(signUpEmailTextBox.TextBoxtext))
            {
                errorProvider.SetError(signUpEmailTextBox, "Enter email ");
                return;
            }
            else
            {
                errorProvider.SetError(signUpEmailTextBox, "");
            }

            if (string.IsNullOrWhiteSpace(signUpPasswordTextBox.TextBoxtext))
            {
                errorProvider.SetError(signUpPasswordTextBox, "Enter password ");
                return;
            }
            else
            {
                errorProvider.SetError(signUpPasswordTextBox, "");
            }

            if (string.IsNullOrWhiteSpace(signUpConfirmPasswordTextBox.TextBoxtext))
            {
                errorProvider.SetError(signUpConfirmPasswordTextBox, "Enter password ");
                return;
            }
            else
            {
                errorProvider.SetError(signUpConfirmPasswordTextBox, "");
            }

            if (IsValidEmail(signUpEmailTextBox.TextBoxtext) && signUpPasswordTextBox.TextBoxtext == signUpConfirmPasswordTextBox.TextBoxtext && (!Communicator.Manager.IsUserExits(signUpEmailTextBox.TextBoxtext.ToLower(), signUpPasswordTextBox.TextBoxtext, out string result)) && result == "Email doesnot exits")
            {
                if(strengthCount < 4)
                {
                    errorProvider.SetError(signUpConfirmPasswordTextBox, "Enter strong password , check the instructions below. ");
                    return;
                }
                forgetPass = false;
                errorProvider.SetError(signUpConfirmPasswordTextBox, "");
                toEmail = signUpEmailTextBox.TextBoxtext.ToLower();
                PageShow(3);
                InitializeOtpPanel();
            }
        }

        private void OnConnectionErrorTimerTicked(object sender, EventArgs e)
        {
            internetIssueLbl.Hide();
            connectionErrorTimer.Stop();
        }

        private void OnPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            OnPasswordTextBoxValidated(sender, e);

            if (sender is TextBox t)
            {
                //text lenngth check
                if(t.Text.Length >= 8)
                {
                    one = true;
                }
                //special character check
                foreach (char c in specialCharacters)
                {
                    if (t.Text.Contains(c))
                    {
                        two = true;
                        break;
                    }
                }
                //uppercase , alpha-numeric check
                foreach(char c in t.Text)
                {
                    if(c >= 65 && c<= 90)
                    {
                        three = true;
                    }
                    if(c >= 48 && c<= 57)
                    {
                        four = true;
                    }
                    
                    if(three && four)
                    {
                        break;
                    }
                }
                SetStrengthLblText();
            }

            //* Must contain 8 characters.
            //* Must contain a special character('@','#','$', etc...).
            //* Must have a upper case letter.
            //* Must contain alpha-number combinations.

        }

        private void OnPasswordTextBoxValidated(object sender, EventArgs e)
        {
            one = false;
            two = false;
            three = false;
            four = false;
        }

        private void OtpGeneratorAndSender()
        {
            random = rand.Next(1000, 10000);
            if (!SendMail())
            {
                //mail not sent
                internetIssueLbl.Show();
                connectionErrorTimer.Start();
            }
            if (resendTime == 20)
            {
                resendOTPLbl.Enabled = false;
                resendTimer.Start();
            }
        }

        private void SetStrengthLblText()
        {
            strengthCount = 0;

            if (one)
            {
                strengthCount++;
                resetPasswordCheckedListBox.SetItemChecked(0, true);
                signUpCheckedListBox.SetItemChecked(0, true);
            }
            else
            {
                resetPasswordCheckedListBox.SetItemChecked(0, false);
                signUpCheckedListBox.SetItemChecked(0, false);
            }

            if (two)
            {
                strengthCount++;
                resetPasswordCheckedListBox.SetItemChecked(1, true);
                signUpCheckedListBox.SetItemChecked(1, true);
            }
            else
            {
                resetPasswordCheckedListBox.SetItemChecked(1, false);
                signUpCheckedListBox.SetItemChecked(1, false);
            }

            if (three)
            {
                strengthCount++;
                resetPasswordCheckedListBox.SetItemChecked(2, true);
                signUpCheckedListBox.SetItemChecked(2, true);
            }
            else
            {
                resetPasswordCheckedListBox.SetItemChecked(2, false);
                signUpCheckedListBox.SetItemChecked(2, false);
            }

            if (four)
            {
                strengthCount++;
                resetPasswordCheckedListBox.SetItemChecked(3, true);
                signUpCheckedListBox.SetItemChecked(3, true);
            }
            else
            {
                resetPasswordCheckedListBox.SetItemChecked(3, false);
                signUpCheckedListBox.SetItemChecked(3, false);
            }

            if(strengthCount == 0)
            {
                signUpPasswordStrngthLbl.Text = "Poor";
                signUpPasswordStrngthLbl.ForeColor = Color.Red;
                ResetPasswordStrengthLbl.Text = "Poor";
                ResetPasswordStrengthLbl.ForeColor = Color.Red;
            }
            else if(strengthCount == 1)
            {
                signUpPasswordStrngthLbl.Text = "Weak";
                signUpPasswordStrngthLbl.ForeColor = Color.Gold;
                ResetPasswordStrengthLbl.Text = "Weak";
                ResetPasswordStrengthLbl.ForeColor = Color.Gold;
            }
            else if(strengthCount == 2)
            {
                signUpPasswordStrngthLbl.Text = "Average";
                signUpPasswordStrngthLbl.ForeColor = Color.DarkOrange;
                ResetPasswordStrengthLbl.Text = "Average";
                ResetPasswordStrengthLbl.ForeColor = Color.DarkOrange;
            }
            else if(strengthCount == 3)
            {
                signUpPasswordStrngthLbl.Text = "Good";
                signUpPasswordStrngthLbl.ForeColor = Color.ForestGreen;
                ResetPasswordStrengthLbl.Text = "Good";
                ResetPasswordStrengthLbl.ForeColor = Color.ForestGreen;
            }
            else
            {
                signUpPasswordStrngthLbl.Text = "Strong";
                signUpPasswordStrngthLbl.ForeColor = Color.DarkGreen;
                ResetPasswordStrengthLbl.Text = "Strong";
                ResetPasswordStrengthLbl.ForeColor = Color.DarkGreen;
            }
        }

        private bool IsValidEmail(string mail)
        {
            //return Regex.IsMatch(mail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            //string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
            //return System.Text.RegularExpressions.Regex.IsMatch(email, regex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            bool valid = true;
            try
            {
                var email = new MailAddress(mail);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }

        private void OnEyePanelClicked(object sender, EventArgs e)
        {
            if (sender is Panel p)
            {
                if(p.Name == "eyePanel1")
                {
                    if(resetPasswordTextBox.PasswordChar == '*')
                    {
                        resetPasswordTextBox.PasswordChar = '\0';
                        eyePanel1.BackgroundImage = Image.FromFile(@".\Images\eyeOpen.PNG");
                    }
                    else
                    {
                        resetPasswordTextBox.PasswordChar = '*';
                        eyePanel1.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
                    }
                    return;
                }
                if(p.Name == "eyePanel2")
                {
                    if (resetConfirmPasswordTextBox.PasswordChar == '*')
                    {
                        resetConfirmPasswordTextBox.PasswordChar = '\0';
                        eyePanel2.BackgroundImage = Image.FromFile(@".\Images\eyeOpen.PNG");
                    }
                    else
                    {
                        resetConfirmPasswordTextBox.PasswordChar = '*';
                        eyePanel2.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
                    }
                    return;
                }
                if (p.Name == "loginEyePanel")
                {
                    if (loginPasswordTextBox.PasswordChar == '*')
                    {
                        loginPasswordTextBox.PasswordChar = '\0';
                        loginEyePanel.BackgroundImage = Image.FromFile(@".\Images\eyeOpen.PNG");
                    }
                    else
                    {
                        loginPasswordTextBox.PasswordChar = '*';
                        loginEyePanel.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
                    }
                    return;
                }
                if (p.Name == "signUpEyePanel1")
                {
                    if (signUpPasswordTextBox.PasswordChar == '*')
                    {
                        signUpPasswordTextBox.PasswordChar = '\0';
                        signUpEyePanel1.BackgroundImage = Image.FromFile(@".\Images\eyeOpen.PNG");
                    }
                    else
                    {
                        signUpPasswordTextBox.PasswordChar = '*';
                        signUpEyePanel1.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
                    }
                    return;
                }
                if (p.Name == "signUpEyePanel2")
                {
                    if (signUpConfirmPasswordTextBox.PasswordChar == '*')
                    {
                        signUpConfirmPasswordTextBox.PasswordChar = '\0';
                        signUpEyePanel2.BackgroundImage = Image.FromFile(@".\Images\eyeOpen.PNG");
                    }
                    else
                    {
                        signUpConfirmPasswordTextBox.PasswordChar = '*';
                        signUpEyePanel2.BackgroundImage = Image.FromFile(@".\Images\eyeClose.PNG");
                    }
                    return;
                }
            }
        }

        private int ConvertToInt(string s)
        {
            if (int.TryParse(s, out int entered))
            {
                return entered;
            }
            return 0;
        }

        private void PageShow(int i)
        {
            if (i == 1)
            {
                signInPanel.Show();
                signUpPanel.Hide();
                otpPanel.Hide();
                resetPanel.Hide();
                loginMailTextBox.TextBoxtext = "";
                loginPasswordTextBox.TextBoxtext = "";
                errorProvider.SetError(loginMailTextBox, "");
                errorProvider.SetError(loginPasswordTextBox, "");
            }
            else if(i == 2)
            {
                signInPanel.Hide();
                signUpPanel.Show();
                otpPanel.Hide();
                resetPanel.Hide();
                forgetPass = false;
                signUpPasswordStrngthLbl.Text = "";
                signUpEmailTextBox.TextBoxtext = "";
                signUpPasswordTextBox.TextBoxtext = "";
                signUpNameTextBox.TextBoxtext = "";
                signUpConfirmPasswordTextBox.TextBoxtext = "";
                errorProvider.SetError(signUpEmailTextBox, "");
                errorProvider.SetError(signUpPasswordTextBox, "");
                errorProvider.SetError(signUpNameTextBox, "");
                errorProvider.SetError(signUpConfirmPasswordTextBox, "");
                signUpCheckedListBox.SetItemChecked(0, false);
                signUpCheckedListBox.SetItemChecked(1, false);
                signUpCheckedListBox.SetItemChecked(2, false);
                signUpCheckedListBox.SetItemChecked(3, false);
                OnPasswordTextBoxTextChanged(new object(), EventArgs.Empty);
            }
            else if(i == 3)
            {
                signInPanel.Hide();
                signUpPanel.Hide();
                otpPanel.Show();
                resetPanel.Hide();
                otpTextBox.TextBoxtext = "";
                errorProvider.SetError(otpTextBox, "");
                OtpGeneratorAndSender();
            }
            else
            {
                signInPanel.Hide();
                signUpPanel.Hide();
                otpPanel.Hide();
                resetPanel.Show();
                ResetPasswordStrengthLbl.Text = "";
                toEmail = loginMailTextBox.TextBoxtext.ToLower();
                resetPasswordTextBox.TextBoxtext = "";
                resetConfirmPasswordTextBox.TextBoxtext = "";
                errorProvider.SetError(resetPasswordTextBox, "");
                errorProvider.SetError(resetConfirmPasswordTextBox, "");
                resetPasswordCheckedListBox.SetItemChecked(0, false);
                resetPasswordCheckedListBox.SetItemChecked(1, false);
                resetPasswordCheckedListBox.SetItemChecked(2, false);
                resetPasswordCheckedListBox.SetItemChecked(3, false);
                OnPasswordTextBoxTextChanged(new object(), EventArgs.Empty);
            }
        }
        
        private void OnResendOTPLblClicked(object sender, EventArgs e)
        {
            if (resendTime == 20)
            {
                resendOTPLbl.Enabled = false;
                OtpGeneratorAndSender();
                resendTimer.Start();
            }
        }

        private void OnLoadTimerTicked(object sender, EventArgs e)
        {
            LoadTimer.Stop();
            loading.Close();
        }
        
        #endregion

    }
}
