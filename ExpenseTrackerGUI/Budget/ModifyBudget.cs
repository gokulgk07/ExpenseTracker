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
    public partial class ModifyBudget : UserControl
    {
        public ModifyBudget()
        {
            InitializeComponent();
            choiceComboBox.SelectedIndex = 0;
            paddtransaction.BackColor = GUIStyles.primaryColor;
            warningPanel.BackColor = GUIStyles.primaryColor;
            pnlTop.BackColor = GUIStyles.primaryColor;
            padd.BackColor = GUIStyles.terenaryColor;
            resultTimer.Interval = 800;
            resultTimer.Tick += OnResultTimerTicked;
            changeWallet.TotalShow = false;
            //AdjustSize();


        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            padd.BackColor = GUIStyles.terenaryColor;
            pback.Controls.Add(categoryView);
            categoryView.Dock = DockStyle.Fill;
            categoryView.Visible = false;
            categoryView.SendToBack();
            pback.Controls.Add(changeWallet);
            changeWallet.Dock = DockStyle.Fill;
            changeWallet.Visible = false;
            changeWallet.BringToFront();
            AdjustSize();
            categoryView.CategorySelect += OnCategoryViewSelectClicked;
            categoryView.CategoryClose += OnCategoryClosedClicked;
            changeWallet.WalletClick += OnWalletSelectClicked;
            changeWallet.WalletClose += OnWalletCloseClicked;
        }

        public event EventHandler<bool> ModifiedOrDeleted;

        private CategoryView categoryView = new CategoryView();

        private ChangeWallet changeWallet = new ChangeWallet();

        private Budget budget;

        private Budget budget2 = new Budget();

        private Timer resultTimer = new Timer();

        private ErrorProvider ErrorProvider = new ErrorProvider();
        
        private int categoryid = 0, walletid = 1;

        private Budget.Choices choice = Budget.Choices.ThisWeek;

        private String categoryname = "";

        private float amount;

        private DateTime startDate, endDate;

        private bool isEditable = true;

        private bool modifyExisting = false;

        public bool IsEditable
        {
            get => isEditable;
            set
            {
                isEditable = value;
                ChangeState();
            }
        }

        public void Initialize(Budget budget)
        {
            this.budget = budget;
            this.budget.BudgetId = budget.BudgetId;//////
            amounttb.Text = budget.Amount.ToString();
            choiceComboBox.Text = budget.Choice.ToString();
            if (budget.Choice.ToString() == "Custom")
            {
                choiceComboBox.SelectedIndex = 4;
                startDatelb.Show();
                endDatelb.Show();
                startDatePicker.Show();
                endDatePicker.Show();
            }
            else
            {
                startDatelb.Hide();
                endDatelb.Hide();
                startDatePicker.Hide();
                endDatePicker.Hide();
            }
            ChangeChoice();
            categoryselectbt.Text = $"{Communicator.Manager.FetchCategoryName(budget.CategoryId).CategoryName}";
            walletid = budget.WalletId;
            walletbt.Text = Communicator.Manager.FetchWallet(walletid).WalletName;
            categoryid = budget.CategoryId;
            categoryname = categoryselectbt.Text;
            startDatePicker.Value = budget.StartDate;
            endDatePicker.Value = budget.EndDate;
            categoryselectbt.BackColor = Color.White;
            walletbt.BackColor = Color.White;
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

        private bool CheckChoice()
        {
            if ((choiceComboBox.SelectedIndex == 4 && startDatePicker.Value <= endDatePicker.Value) || (choiceComboBox.SelectedIndex <= 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void AdjustSize()
        {
            paddtransaction.BackColor = GUIStyles.primaryColor;
            pback.Width = paddtransaction.Width * 60 / 100;
            pback.Height = paddtransaction.Height * 70 / 100;
            padd.Width = paddtransaction.Width * 70 / 100;
            padd.Height = paddtransaction.Height * 70 / 100;
            pback.Location = new Point(paddtransaction.Width / 2 - pback.Width / 2, paddtransaction.Height / 2 - pback.Height / 2);
            padd.Location = new Point(paddtransaction.Width / 2 - padd.Width / 2, paddtransaction.Height / 2 - padd.Height / 2);
            warningPanel.Location = new Point(Width / 2 - (warningPanel.Width / 2), Height / 2 - (warningPanel.Height / 2));
            warningPanel.Visible = false;
        }
        
        private void ChangeChoice()
        {
            if (choiceComboBox.SelectedIndex == 0 || choiceComboBox.Text == "This Week")
                choice = ExpenseTrackerDS.Budget.Choices.ThisWeek;
            if (choiceComboBox.SelectedIndex == 1 || choiceComboBox.Text == "This Month")
                choice = ExpenseTrackerDS.Budget.Choices.ThisMonth;
            if (choiceComboBox.SelectedIndex == 2 || choiceComboBox.Text == "This Quarter")
                choice = ExpenseTrackerDS.Budget.Choices.ThisQuarter;
            if (choiceComboBox.SelectedIndex == 3 || choiceComboBox.Text == "This Year")
                choice = ExpenseTrackerDS.Budget.Choices.ThisYear;
            if (choiceComboBox.SelectedIndex == 4 || choiceComboBox.Text == "Custom")
                choice = ExpenseTrackerDS.Budget.Choices.Custom;
        }

        private void ChangeState()
        {
            if(!isEditable)
            {
                amounttb.Enabled = false;
                categoryselectbt.Enabled = false;
                choiceComboBox.Enabled = false;
                walletbt.Enabled = false;
                startDatePicker.Enabled = false;
                endDatePicker.Enabled = false;
                modifyBtn.Visible = false;
                deletebtn.Visible = false;
            }
            else
            {
                amounttb.Enabled = true;
                categoryselectbt.Enabled = true;
                choiceComboBox.Enabled = true;
                walletbt.Enabled = true;
                startDatePicker.Enabled = true;
                endDatePicker.Enabled = true;
                modifyBtn.Visible = true;
                deletebtn.Visible = true;
            }
        }

        private void OnResultTimerTicked(object sender, EventArgs e)
        {
            resultLbl.Text = "";
            modifyBtn.Enabled = true;
            deletebtn.Enabled = true;
            resultTimer.Stop();
            ModifiedOrDeleted?.Invoke(this, true);
        }
        
        private void OnLoad(object sender, EventArgs e)
        {
            padd.BackColor = GUIStyles.primaryColor;
            categoryView.Visible = false;
            pback.Visible = false;
            AdjustSize();
        }

        private void OnModifyBtnClicked(object sender, EventArgs e)
        {
            if (CheckAmount() && CheckCategory() && CheckChoice())
            {
                amount = float.Parse(amounttb.Text);
                if (choiceComboBox.SelectedIndex == 4)
                {
                    startDate = startDatePicker.Value;
                    endDate = endDatePicker.Value;
                }

                budget2.CategoryId = categoryid;
                budget2.Amount = amount;
                budget2.Choice = choice;
                budget2.WalletId = walletid;
                budget2.StartDate = startDate;
                budget2.EndDate = endDate;

                if(budget!=null && (budget.CategoryId == budget2.CategoryId && budget.Amount == budget2.Amount && budget.WalletId == budget2.WalletId && budget.Choice == budget2.Choice))
                {
                    modifyBtn.Enabled = false;
                    deletebtn.Enabled = false;
                    resultTimer.Start();
                    return;
                }
                else//if(budget!=null &&(budget.CategoryId !=  budget2.CategoryId || budget.Amount != budget2.Amount || budget.WalletId != budget2.WalletId || budget.Choice != budget2.Choice))
                {
                    if (budget != null)
                    {
                        Communicator.Manager.RemoveData(budget);
                        budget = null;
                    }
                }

                bool res = Communicator.Manager.AddData(budget2 , modifyExisting);
                Result(res , true);
                ErrorProvider.SetError(amounttb, "");
                modifyExisting = false;
            }
        }

        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            bool res = Communicator.Manager.RemoveData(budget);
            Result(res , false);
        }

        private void Result(bool res , bool modify)
        {
            if (res)
            {
                if (modify)
                    resultLbl.Text = "Modified ✔";
                else
                    resultLbl.Text = "Deleted ✔";
                resultLbl.ForeColor = Color.Chartreuse;
                modifyBtn.Enabled = false;
                deletebtn.Enabled = false;
                resultTimer.Start();
            }
            else
            {
                //resultLbl.Text = " Failed ✘";
                //resultLbl.ForeColor = Color.Red;
                cancelWarningBtn.Select = false;
                modifyExistingBtn.Select = false;
                warningPanel.Visible = true;
                padd.Enabled = false;
            }
        }

        private void OnCategorySelectLblClicked(object sender, EventArgs e)
        {
            categoryView.WalletChange = new Wallet { WalletID = walletid };
            pback.Visible = true;
            changeWallet.SendToBack();
            categoryView.BringToFront();
            categoryView.Visible = true;
            padd.Visible = false;
        }

        private void OnCategoryViewSelectClicked(object sender, Category e)
        {
            Category c = new Category();
            c = e;
            categoryid = c.ID;
            categoryname = c.CategoryName;
            pback.Visible = false;
            categoryView.Visible = false;
            padd.Visible = true;
            categoryselectbt.Text = categoryname;
        }
        
        private void OnCategoryClosedClicked(object sender, EventArgs e)
        {
            pback.Visible = false;
            categoryView.Visible = false;
            padd.Visible = true;
        }
        
        private void OnWalletBtClicked(object sender, EventArgs e)
        {
            pback.Visible = true;
            categoryView.SendToBack();
            changeWallet.BringToFront();
            changeWallet.Visible = true;
            padd.Visible = false;
        }
        
        private void OnWalletSelectClicked(object sender, Wallet e)
        {
            changeWallet.Visible = false;
            pback.Visible = false;
            padd.Visible = true;
            walletbt.Text = e.WalletName;
            walletid = e.WalletID;
        }

        private void OnWalletCloseClicked(object sender, EventArgs e)
        {
            changeWallet.Visible = false;
            pback.Visible = false;
            padd.Visible = true;
        }
        
        private void OnModifyBtnMouseEntered(object sender, EventArgs e)
        {
            modifyBtn.BackColor = GUIStyles.secondaryColor;
            modifyBtn.ForeColor = Color.White;
        }

        private void OnModifyBtnMouseLeaved(object sender, EventArgs e)
        {
            modifyBtn.BackColor = Color.White;
            modifyBtn.ForeColor = Color.MediumBlue;
        }

        private void OnDeleteBtnMouseEntered(object sender, EventArgs e)
        {
            deletebtn.BackColor = GUIStyles.secondaryColor;
            deletebtn.ForeColor = Color.White;
        }

        private void OnDeleteBtnMouseLeaved(object sender, EventArgs e)
        {
            deletebtn.BackColor = Color.White;
            deletebtn.ForeColor = Color.MediumBlue;
        }

        private void OnAmounttbKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
         
        private void OnCloseBtnClicked(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void OnCancelWarningBtnClicked(object sender, EventArgs e)
        {
            warningPanel.Visible = false;
            padd.Enabled = true;
            cancelWarningBtn.Select = false;
        }

        private void OnModifyExisitngBtnClicked(object sender, EventArgs e)
        {
            modifyExisting = true;
            padd.Enabled = true;
            OnModifyBtnClicked(this, e);
            warningPanel.Visible = false;
            modifyExistingBtn.Select = false;
        }

        private void OnResized(object sender, EventArgs e)
        {
            pborder.Size = new Size(Width - 24, Height - 62);
        }

        private void OnPaddPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, GUIStyles.terenaryColor, GUIStyles.primaryColor, padd.Width, padd.Height, 25, 50);
        }

        private void OnChoiceComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (choiceComboBox.SelectedIndex != 4)
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
