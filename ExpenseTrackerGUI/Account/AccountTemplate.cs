using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using ExpenseTrackerDS;
using ExpenseTracker;

namespace ExpenseTrackerGUI.Account
{
    public partial class AccountTemplate : UserControl
    {
        public AccountTemplate()
        {
            InitializeComponent();
            SetRoundPictureBox();
            ShowControls();
            settingsBtn.Click += settingsPicture_Click;
            toolsBtn.Click += toolsPicture_Click;
            aboutBtn.Click += aboutPicture_Click;
            showCsv.Hide();
            currencyConvertorPanel.Hide();
            interestRateCalculator.Hide();
            exportToCSV1.CloseBtnClick += OnExportToCSV1_CloseBtnClick;
            userNameLabel.Text = Communicator.Manager.username;
            mailLabel.Text = Communicator.Manager.mailId;
            signoutPanel.Hide();
            cardPanel1.Hide();
        }

        private void OnExportToCSV1_CloseBtnClick(object sender, EventArgs e)
        {
            showCsv.Hide();
            accountPanel.Show();
            space1.Show();
            toolPanel.Show();
            space2.Show();
            settingsPanel.Show();
            space3.Show();
            aboutPanel.Show();
            editPanel.Show();
            space4.Show();
        }

        private void SetRoundPictureBox()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, imagePictureBox.Width, imagePictureBox.Height);
            imagePictureBox.Region = new Region(path);
            imagePictureBox.BackgroundImageLayout = ImageLayout.Stretch; 
        }

        private void ShowControls()
        {
            userNameLabel.Text = Communicator.Manager.username;
            mailLabel.Text = Communicator.Manager.mailId;
            this.BackColor = GUIStyles.backColor;
            topPanel.BackColor = GUIStyles.primaryColor;
            bottomPanel.BackColor = GUIStyles.primaryColor;
            leftPanel.BackColor = GUIStyles.primaryColor;
            rightPanel.BackColor = GUIStyles.primaryColor;
            linePanel.Width = this.Width - 60;

            csvPicture.Hide();
            CSVBtn.Hide();
            interestRatePicture.Hide();
            interestRateBnt.Hide();

            theme.Hide();
            themePicture.Hide();
            currency.Hide();
            currencyPicture.Hide();
            signoutPicture.Hide();
            signoutBtn.Hide();

            walkthroughPicture.Hide();
            walkthroughBtn.Hide();

            toolPanel.Height = 91;
            settingsPanel.Height = 91;
            aboutPanel.Height = 91;
        }

        private void AccountTemplate_Load(object sender, EventArgs e)
        {
            ShowControls();
        }

        static int toolsCnt = 0, settingsCnt = 0, aboutCnt = 0;

        private void toolsPicture_Click(object sender, EventArgs e)
        {
            toolsCnt++;
            if (toolsCnt % 2 != 0)
            {
                ShowTools();
            }
            else
            {
                ShowControls();
            }
        }        

        private void settingsPicture_Click(object sender, EventArgs e)
        {
            settingsCnt++;
            if (settingsCnt % 2 != 0)
            {
                ShowSettings();
            }
            else
            {
                ShowControls();
            }
        }

        private void aboutPicture_Click(object sender, EventArgs e)
        {
            aboutCnt++;
            if (aboutCnt % 2 != 0)
            {
                ShowAbout();
            }
            else
            {
                ShowControls();
            }
        }

        private void ShowTools()
        {
            csvPicture.Show();
            CSVBtn.Show();
            interestRatePicture.Show();
            interestRateBnt.Show();
            currency.Show();
            currencyPicture.Show();

            theme.Hide();
            themePicture.Hide();
            //currency.Hide();
            //currencyPicture.Hide();
            signoutPicture.Hide();
            signoutBtn.Hide();

            walkthroughPicture.Hide();
            walkthroughBtn.Hide();

            toolPanel.Height = 285;
            settingsPanel.Height = 91;
            aboutPanel.Height = 91;
        }

        private void csvPicture_Click(object sender, EventArgs e)
        {
            accountPanel.Hide();
            space1.Hide();
            toolPanel.Hide();
            space2.Hide();
            settingsPanel.Hide();
            space3.Hide();
            aboutPanel.Hide();
            editPanel.Hide();
            space4.Hide();
            showCsv.BringToFront();
            showCsv.Dock = DockStyle.Fill;
            showCsv.Show();

            //var res = Communicator.Manager.FetchTransactionOnDates<List<Transaction>>(DateTime.Now.AddMonths(-1), DateTime.Now, Manager.ViewType.Month);
            //ToCSV(res);
        }

        public void ToCSV(List<Transaction> list)
        {
            //String file = saveFileDialog1();

            String separator = ",";
            StringBuilder output = new StringBuilder();

            String[] headings = { "Transaction Id", "Category Id", "Category Name", "Amount", "Date", "Description", "Wallet Id" };
            output.AppendLine(string.Join(separator, headings));

            foreach (Transaction t in list)
            {
                String[] newLine = { t.TransactionId.ToString(), t.CategoryId.ToString(), t.CategoryName, t.Amount.ToString(), t.Date.ToString(), t.Description, t.WalletId.ToString() };
                output.AppendLine(string.Join(separator, newLine));
            }

            try
            {
                //File.AppendAllText(file, output.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data could not be written to the CSV file.");
                return;
            }

            Console.WriteLine("The data has been successfully saved to the CSV file");
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            String file = "";
            openFileDialog1.ShowDialog();
            //openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Image Files (*.png)|*.png";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
            }
            Bitmap bitmap = new Bitmap(file);
            imagePictureBox.Image = null;
            imagePictureBox.BackgroundImage = null;
            imagePictureBox.Image = bitmap;
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void currency_Click(object sender, EventArgs e)
        {
            currencyConvertorPanel.Show();
            accountPanel.Enabled = false;
            toolPanel.Enabled = false;
            settingsPanel.Enabled = false;
            aboutPanel.Enabled = false;
            editPanel.Enabled = false;
            currencyConverter1.CurrencyConverterClosed += OnCurrencyConverter1_CurrencyConverterClosed;
        }

        private void OnCurrencyConverter1_CurrencyConverterClosed(object sender, EventArgs e)
        {
            currencyConvertorPanel.Hide();
            accountPanel.Enabled = true;
            toolPanel.Enabled = true;
            settingsPanel.Enabled = true;
            aboutPanel.Enabled = true;
            editPanel.Enabled = true;
        }

        private void interestRatePicture_Click(object sender, EventArgs e)
        {
            interestRateCalculator.Show();
            interestCalculator1.InterestCalculatorClosed += OnInterestCalculator1_InterestCalculatorClosed;
            accountPanel.Enabled = false;
            toolPanel.Enabled = false;
            settingsPanel.Enabled = false;
            aboutPanel.Enabled = false;
            editPanel.Enabled = false;
        }

        private void OnInterestCalculator1_InterestCalculatorClosed(object sender, EventArgs e)
        {
            interestCalculator1.Hide();
            accountPanel.Enabled = true;
            toolPanel.Enabled = true;
            settingsPanel.Enabled = true;
            aboutPanel.Enabled = true;
            editPanel.Enabled = true;
        }

        public event EventHandler walkthroughClick;

        private void walkthroughPicture_Click(object sender, EventArgs e)
        {
            walkthroughClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Signout;
        private void signoutBtn_Click(object sender, EventArgs e)
        {
            signoutLabel.ForeColor = GUIStyles.primaryColor;
            yesBtn.BackColor = GUIStyles.primaryColor;
            NoBtn.BackColor = GUIStyles.primaryColor;
            yesBtn.ForeColor = GUIStyles.whiteColor;
            NoBtn.ForeColor = GUIStyles.whiteColor;
            yesBtn.FlatAppearance.MouseOverBackColor = GUIStyles.terenaryColor;
            NoBtn.FlatAppearance.MouseOverBackColor = GUIStyles.terenaryColor;
            cardPanel1.Show();
            signoutPanel.Show();
            signoutPanel.BringToFront();
        }

        private void yesBtn_Click_1(object sender, EventArgs e)
        {
            Signout?.Invoke(this, EventArgs.Empty);
        }

        private void NoBtn_Click_1(object sender, EventArgs e)
        {
            signoutPanel.Hide();
            cardPanel1.Hide();
        }

        private void ShowSettings()
        {
            csvPicture.Hide();
            CSVBtn.Hide();
            interestRatePicture.Hide();
            interestRateBnt.Hide();

            theme.Show();
            themePicture.Show();
            currency.Show();
            currencyPicture.Show();
            signoutPicture.Show();
            signoutBtn.Show();

            walkthroughPicture.Hide();
            walkthroughBtn.Hide();

            toolPanel.Height = 91;
            settingsPanel.Height = 215;
            aboutPanel.Height = 91;
        }

        private void ShowAbout()
        {
            csvPicture.Hide();
            CSVBtn.Hide();
            interestRatePicture.Hide();
            interestRateBnt.Hide();

            theme.Hide();
            themePicture.Hide();
            currency.Hide();
            currencyPicture.Hide();
            signoutPicture.Hide();
            signoutBtn.Hide();

            walkthroughPicture.Show();
            walkthroughBtn.Show();

            toolPanel.Height = 91;
            settingsPanel.Height = 91;
            aboutPanel.Height = 143;
        }
    }
}
