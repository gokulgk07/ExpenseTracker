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
using ExpenseTrackerDS;

namespace ExpenseTrackerGUI
{
    public partial class AddBudget : UserControl
    {
        public AddBudget()
        {
            InitializeComponent();
            ErrorProvider = new ErrorProvider();
            choiceComboBox.SelectedIndex = 0;
            categoryview.CategorySelect += OnCategoryViewSelectClicked;
            categoryview.CategoryClose += OnCategoryClosedClicked;
            changeWallet.WalletClick += OnWalletSelectClicked;
            changeWallet.WalletClose += OnWalletCloseClicked;
            changeWallet.AddMode = false;
            changeWallet.EditMode = false;
            paddtransaction.BackColor = GUIStyles.primaryColor;
            padd.BackColor = GUIStyles.terenaryColor;
            pnlTop.BackColor = GUIStyles.primaryColor;
            warningPanel.BackColor = GUIStyles.primaryColor;
            resultTimer.Interval = 800;
            resultTimer.Tick += OnResultTimerTicked;
            changeWallet.TotalShow = false;
        }
        
        private Timer resultTimer = new Timer();

        private CategoryView categoryview = new CategoryView();

        private ChangeWallet changeWallet = new ChangeWallet();

        private ErrorProvider ErrorProvider;
        
        private int categoryid = 0, walletid = 1;

        private ExpenseTrackerDS.Budget.Choices choice = ExpenseTrackerDS.Budget.Choices.ThisWeek;

        private String categoryname = "";

        private float amount;

        private DateTime startDate , endDate ;

        private bool modifyExisting = false;

        private void AdjustSize()
        {
            paddtransaction.BackColor = GUIStyles.primaryColor;
            pback.Width = paddtransaction.Width * 60 / 100;
            pback.Height = paddtransaction.Height * 70 / 100;
            padd.Width = paddtransaction.Width * 70 / 100;
            padd.Height = paddtransaction.Height * 70 / 100;
            pback.Location = new Point(paddtransaction.Width / 2 - pback.Width / 2, paddtransaction.Height / 2 - pback.Height / 2);
            padd.Location = new Point(paddtransaction.Width / 2 - padd.Width / 2, paddtransaction.Height / 2 - padd.Height / 2);
            warningPanel.Location = new Point(Width/2 - (warningPanel.Width/2), Height /2 - (warningPanel.Height/2));
            warningPanel.Visible = false;
        }

        public void ClearData()
        {
            amounttb.Text = "";
            ErrorProvider.SetError(amounttb, "");
            categoryselectbt.Text = "Select Category                ➤";
            walletbt.Text = "Select Wallet                      ➤";
            categoryselectbt.BackColor = Color.Gainsboro;
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now;
        }

        private bool CheckAmount()
        {
            if (amounttb.TextLength > 0)
            {
                ErrorProvider.SetError(amounttb, "");
                return true;
            }
            ErrorProvider.SetError(amounttb, "Amount is required");
            return false;
        }

        private bool CheckCategory()
        {
            if (categoryselectbt.Text == "Select Category                ➤")
            {
                ErrorProvider.SetError(categoryselectbt, "Choose Category");
                return false;
            }
            ErrorProvider.SetError(categoryselectbt, "");
            return true;
        }

        private bool CheckWallet()
        {
            if (walletbt.Text == "Select Wallet                      ➤")
            {
                ErrorProvider.SetError(walletbt, "Choose Wallet");
                return false;
            }
            ErrorProvider.SetError(walletbt, "");
            return true;
        }

        private bool CheckChoice()
        {
            if((choiceComboBox.SelectedIndex ==4 && startDatePicker.Value <= endDatePicker.Value)|| (choiceComboBox.SelectedIndex <= 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void ChangeChoice()
        {
            if (choiceComboBox.SelectedIndex == 0)
                choice = ExpenseTrackerDS.Budget.Choices.ThisWeek;
            if (choiceComboBox.SelectedIndex == 1)
                choice = ExpenseTrackerDS.Budget.Choices.ThisMonth;
            if (choiceComboBox.SelectedIndex == 2)
                choice = ExpenseTrackerDS.Budget.Choices.ThisQuarter;
            if (choiceComboBox.SelectedIndex == 3)
                choice = ExpenseTrackerDS.Budget.Choices.ThisYear;
            if (choiceComboBox.SelectedIndex == 4)
                choice = ExpenseTrackerDS.Budget.Choices.Custom;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            padd.BackColor = GUIStyles.terenaryColor;
            pback.Controls.Add(categoryview);
            categoryview.Dock = DockStyle.Fill;
            categoryview.Visible = false;
            categoryview.SendToBack();
            pback.Controls.Add(changeWallet);
            changeWallet.Dock = DockStyle.Fill;
            changeWallet.Visible = false;
            changeWallet.BringToFront();
            AdjustSize();
        }
        
        private void OnResultTimerTicked(object sender, EventArgs e)
        {
            resultLbl.Text = "";
            savebt.Enabled = true;
            Clearbt.Enabled = true;
            resultTimer.Stop();
        }

        private void OnSaveBtnClicked(object sender, EventArgs e)
        {
            
            if (CheckAmount() && CheckCategory() && CheckChoice() && CheckWallet())
            {
                amount = float.Parse(amounttb.Text);
                if(choiceComboBox.SelectedIndex ==  4)
                {
                    startDate = startDatePicker.Value;
                    endDate = endDatePicker.Value;
                }
                ExpenseTrackerDS.Budget budget = new ExpenseTrackerDS.Budget
                {
                    CategoryId = categoryid,
                    Amount = amount,
                    Choice = choice,
                    WalletId = walletid,
                    StartDate = startDate,
                    EndDate = endDate,
                };
                bool res = Communicator.Manager.AddData(budget , modifyExisting);

                if(res)
                {
                    resultLbl.Text = " Created Successfully ✔";
                    resultLbl.ForeColor = Color.Chartreuse;
                    savebt.Enabled = false;
                    Clearbt.Enabled = false;
                    resultTimer.Start();
                }
                else
                {
                    cancelWarningBtn.Select = false;
                    modifyExistingBtn.Select = false;
                    warningPanel.Visible = true;
                    padd.Enabled = false;
                    //resultLbl.Text = " Failed to Create ✘";
                    //resultLbl.ForeColor = Color.Red;
                }
                ErrorProvider.SetError(amounttb, "");
                modifyExisting = false;
            }
            
        }

        private void OnClearBtnClicked(object sender, EventArgs e)
        {
            ClearData();
        }
        
        private void OnCategoryViewSelectClicked(object sender, ExpenseTrackerDS.Category e)
        {
            ExpenseTrackerDS.Category c = new ExpenseTrackerDS.Category();
            c = e;
            categoryid = c.ID;
            categoryname = c.CategoryName;
            categoryview.Visible = false;
            padd.Visible = true;
            categoryselectbt.Text = categoryname;
            categoryselectbt.BackColor = Color.White;
        }

        private void OnWalletSelectClicked(object sender, ExpenseTrackerDS.Wallet e)
        {
            walletid = e.WalletID;
            walletbt.Text = e.WalletName;
            changeWallet.Visible = false;
            padd.Visible = true;
            walletbt.BackColor = Color.White;
        }
        
        private void OnSaveBtnMouseEnter(object sender, EventArgs e)
        {
            savebt.BackColor = GUIStyles.secondaryColor;
            savebt.ForeColor = Color.White;
        }

        private void OnSaveBtnMouseLeave(object sender, EventArgs e)
        {
            savebt.BackColor = Color.White;
            savebt.ForeColor = Color.MediumBlue;
        }

        private void OnClearBtnMouseEnter(object sender, EventArgs e)
        {
            Clearbt.BackColor = GUIStyles.secondaryColor;
            Clearbt.ForeColor = Color.White;
        }

        private void OnClearBtnMouseLeave(object sender, EventArgs e)
        {
            Clearbt.BackColor = Color.White;
            Clearbt.ForeColor = Color.MediumBlue;
        }

        private void OnAmounttbKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void OnPaddPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, GUIStyles.terenaryColor, GUIStyles.primaryColor, padd.Width, padd.Height, 25, 50);
        }

        private void OnCancelWarningBtnClicked(object sender, EventArgs e)
        {
            warningPanel.Visible = false;
            padd.Enabled = true;
        }

        private void OnModifyExisting(object sender, EventArgs e)
        {
            modifyExisting = true;
            OnSaveBtnClicked(this, e);
            warningPanel.Visible = false;
            padd.Enabled = true;
        }

        private void OnCategorySelectLblClicked(object sender, EventArgs e)
        {
            if (walletbt.Text == "Select Wallet                      ➤")
            {
                ErrorProvider.SetError(categoryselectbt, "Choose Wallet");
            }
            else
            {
                ErrorProvider.SetError(categoryselectbt, "");
                categoryview.BringToFront();
                changeWallet.SendToBack();
                categoryview.Visible = true;
                categoryview.WalletChange = new Wallet { WalletID = walletid };
                padd.Visible = false;

            }
        }

        private void OnCategoryClosedClicked(object sender, EventArgs e)
        {
            categoryview.Visible = false;
            padd.Visible = true;
        }
        
        private void OnAddBudgetResized(object sender, EventArgs e)
        {
            pborder.Size = new Size(Width - 24, Height - 62);
        }

        private void OnWalletBtClicked(object sender, EventArgs e)
        {
            categoryview.SendToBack();
            changeWallet.BringToFront();
            changeWallet.Visible = true;
            padd.Visible = false;
        }

        private void OnWalletCloseClicked(object sender, EventArgs e)
        {
            changeWallet.Visible = false;
            padd.Visible = true;
        }
        
        private void OnChoiceComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if(choiceComboBox.SelectedIndex != 4)
            {
                startDatelb.Hide();
                endDatelb.Hide();
                startDatePicker.Hide();
                endDatePicker.Hide();
            }
            else
            {
                startDatelb.Show();
                endDatelb.Show();
                startDatePicker.Show();
                endDatePicker.Show();
            }
            ChangeChoice();
        }
        
    }
}
