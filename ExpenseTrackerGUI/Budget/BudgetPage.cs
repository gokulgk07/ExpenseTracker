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
    public partial class BudgetPage : UserControl
    {
        public BudgetPage()
        {
            InitializeComponent();
            BackColor = GUIStyles.backColor;
            paginationControl.Location = new Point(((Width / 2) - (paginationControl.Width) / 2), paginationControl.Location.Y);
            paginationControl.ValueChanged += OnPaginationValueChanged;
            curveBtn1.Select = !curveBtn1.Select;
            Controls.Add(modifyBudget);
            modifyBudget.ModifiedOrDeleted += OnBudgetModifiedOrDeleted;
            modifyBudget.SendToBack();
            modifyBudget.Dock = DockStyle.Fill;
            InitializeCollection();
            choiceId = 1;
            pastChoicePanel.Hide();
            InitializeColors();
            InitializeWallets();
            
        }
        
        private void InitializeColors()
        {
            walletsPanel.BackColor = GUIStyles.whiteColor;

        }

        public void InitializeWallets()
        {
            walletsPanel.Visible = false;
            periodPanel.Visible = false;
            while (walletsPanel.Controls.Count > 0)
            {
                if(walletsPanel.Controls[0]  is SingleWallet s)
                {
                    s.Selected -= OnSingleWalletSelected;
                }
                walletsPanel.Controls.RemoveAt(0);
            }
            walletsPanel.Height = 0;
            List<Wallet> wallets = Communicator.Manager.FetchWallet();
            walletId = 0;
            walletNameLbl.Text = "Total";
            SingleWallet wallet = new SingleWallet() { Id = 0, LabelText = "Total" };
            wallet.Selected += OnSingleWalletSelected;
            wallet.Dock = DockStyle.Top;
            walletsPanel.Controls.Add(wallet);
            walletsPanel.Height += 28;
            foreach (Wallet w in wallets)
            {
                wallet = new SingleWallet() { Id = w.WalletID, LabelText = w.WalletName };
                wallet.Selected += OnSingleWalletSelected;
                wallet.Dock = DockStyle.Top;
                walletsPanel.Controls.Add(wallet);
                walletsPanel.Height += 25;
            }
            walletsPanel.Height += 2;
        }

        private void OnSingleWalletSelected(object sender, string name, int id)
        {
            walletId = id;
            walletNameLbl.Text = name;
            walletsPanel.Visible = false;
            pastChoicePanel.Enabled = true;
            currentChoicePanel.Enabled = true;
            paginationControl.Enabled = true;
            mainPanel.Enabled = true;
            walletsPanel.Visible = false;
            selectChoicePanel.Enabled = true;
        }

        private Budget.Choices choice = Budget.Choices.ThisWeek;

        private List<Budget> budgets = new List<Budget>();
        
        private List<BudgetSquare> budgetSquares = new List<BudgetSquare>();

        private List<CurveButtons> currentChoices = new List<CurveButtons>();

        private List<CurveButtons>  pastChoices= new List<CurveButtons>();

        private List<Tuple<string, string>> customeDates = new List<Tuple<string, string>>();

        private ModifyBudget modifyBudget = new ModifyBudget();

        private List<Budget> pastBudgets = new List<Budget>();

        private bool flag = false;

        private int choiceIndex = 0, pageNo = 1 , walletId = 1 , choiceId = 1;

        private void CheckChoice()
        {
            if(choiceIndex == 0)
                choice = ExpenseTrackerDS.Budget.Choices.ThisWeek;
            if(choiceIndex == 1)
                choice = ExpenseTrackerDS.Budget.Choices.ThisMonth;
            if(choiceIndex == 2)
                choice = ExpenseTrackerDS.Budget.Choices.ThisQuarter;
            if(choiceIndex == 3)
                choice = ExpenseTrackerDS.Budget.Choices.ThisYear;
            if(choiceIndex >=4)
                choice = ExpenseTrackerDS.Budget.Choices.Custom;
        }

        private void ShowBudgets()
        {
            int count = pageNo * 12;
            int remaining = 0;
            for(int i= ((pageNo-1)*12), j = 0;i< budgets.Count && i<count;i++,j++)
            {
                budgetSquares[j].Show();
                budgetSquares[j].InitializeValues( budgets[i].BudgetId ,Convert.ToInt32(budgets[i].Amount), Convert.ToInt32(Communicator.Manager.FetchAmount(budgets[i])), Communicator.Manager.FetchCategoryName(budgets[i].CategoryId).CategoryName, Communicator.Manager.FetchCategoryName(budgets[i].CategoryId).ImagePath);
                remaining = j;
            }
            if (budgets.Count == 0) remaining--;
            for(int i = remaining+1;i<12;i++)
            {
                budgetSquares[i].Hide();
            }
        }

        private void CreateChoiceButtons()
        {
            int i = 0;
            foreach (Tuple<string, string> dates in customeDates)
            {
                CurveButtons btn = new CurveButtons()
                {
                    Text = $" { Convert.ToDateTime(dates.Item1).ToShortDateString() }  -  { Convert.ToDateTime(dates.Item2).ToShortDateString() }",
                };
                btn.SelectedValueChange += OnSelectedValuesChanged;
                if (choiceId == 1)
                {
                    currentChoices.Add(btn);
                    currentChoicePanel.Controls.Add(btn);
                }
                else
                {
                    pastChoices.Add(btn);
                    pastChoicePanel.Controls.Add(btn);
                    if (pastBudgets[i].Choice != Budget.Choices.ThisWeek && pastBudgets[i].Choice != Budget.Choices.Custom)
                    {
                        btn.Text = GetButtonText(pastBudgets[i]);
                    }
                    i++;
                    ///////////////////////////////////////////
                }
                btn.Dock = DockStyle.Left;
                btn.Size = new Size(190, 40);
                btn.Font = new Font("Arial", 9);
                btn.BringToFront();
            }
        }

        private void InitializePaginationButtons()
        {
            pageNo = 1;
            paginationControl.ButtonCount = budgets.Count / 12;
            if (budgets.Count % 12 != 0 || paginationControl.ButtonCount == 0)
                paginationControl.ButtonCount++;
        }
        
        private void InitializeCollection()
        {
            budgetSquares.Add(budgetSquare1);
            budgetSquare1.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare2);
            budgetSquare2.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare3);
            budgetSquare3.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare4);
            budgetSquare4.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare5);
            budgetSquare5.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare6);
            budgetSquare6.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare7);
            budgetSquare7.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare8);
            budgetSquare8.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare9);
            budgetSquare9.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare10);
            budgetSquare10.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare11);
            budgetSquare11.BudgetSquareClicked += OnBudgetSquareClicked;
            budgetSquares.Add(budgetSquare12);
            budgetSquare12.BudgetSquareClicked += OnBudgetSquareClicked;

            currentChoices.Add(curveBtn1);
            currentChoices.Add(curveBtn2);
            currentChoices.Add(curveBtn3);
            currentChoices.Add(curveBtn4);
            curveBtn1.SelectedValueChange += OnSelectedValuesChanged;
            curveBtn2.SelectedValueChange += OnSelectedValuesChanged;
            curveBtn3.SelectedValueChange += OnSelectedValuesChanged;
            curveBtn4.SelectedValueChange += OnSelectedValuesChanged;

        }

        public void InitializeBudgetPage()
        {
            if (choiceId == 1)
            {
                customeDates = Communicator.Manager.FetchCustomDates();//add walletId
                while (currentChoices.Count >= 5)
                {
                    currentChoices[4].SelectedValueChange -= OnSelectedValuesChanged;
                    currentChoicePanel.Controls.Remove(currentChoices[4]);
                    currentChoices.Remove(currentChoices[4]);
                }
                CreateChoiceButtons();
                if (currentChoices.Count > 5)
                {
                    currentChoicePanel.AutoScroll = true;
                    currentChoicePanel.Height = 58;
                }
                else
                {
                    currentChoicePanel.AutoScroll = false;
                    currentChoicePanel.Height = 40;
                }
                OnSelectedValuesChanged(new object(), EventArgs.Empty.ToString());
            }
            else
            {
                customeDates = Communicator.Manager.FetchDistinctDates(out pastBudgets);//add WalletId
                while(pastChoicePanel.Controls.Count>=1)
                {
                    pastChoices[pastChoicePanel.Controls.Count - 1].SelectedValueChange -= OnSelectedValuesChanged;
                    pastChoices.RemoveAt(pastChoicePanel.Controls.Count - 1);
                    pastChoicePanel.Controls.RemoveAt(pastChoicePanel.Controls.Count - 1);
                }
                CreateChoiceButtons();
                if(pastChoices.Count > 5)
                {
                    pastChoicePanel.AutoScroll = true;
                    pastChoicePanel.Height = 58;
                }
                else
                {
                    pastChoicePanel.AutoScroll = false;
                    pastChoicePanel.Height = 40;
                }
                OnSelectedValuesChanged(new object(), EventArgs.Empty.ToString());
            }
        }
        
        private string GetButtonText(Budget b)
        {
            if (b.Choice == Budget.Choices.ThisYear)
                return b.StartDate.Year.ToString();
            if (b.Choice == Budget.Choices.ThisMonth)
                return $"{b.StartDate.ToString("MMMM")} {b.StartDate.Year}";
            if(b.Choice == Budget.Choices.ThisQuarter)
            {
                if (b.StartDate.Month == 1)
                    return $"Q-I({b.StartDate.Year})";
                if (b.StartDate.Month == 4)
                    return $"Q-II({b.StartDate.Year})";
                if (b.StartDate.Month == 7)
                    return $"Q-III({b.StartDate.Year})";
                if (b.StartDate.Month == 10)
                    return $"Q-IV({b.StartDate.Year})";
            }
            return "";
        }

        private void OnPaginationValueChanged(object sender, int e)
        {
            pageNo = e;
            ShowBudgets();
        }

        private void OnPaginationSizeChanged(object sender, EventArgs e)
        {
            paginationControl.Location = new Point(((Width /2)-(paginationControl.Width)/2) , paginationControl.Location.Y);
        }

        private void OnBudgetModifiedOrDeleted(object sender, bool e)
        {
            InitializeBudgetPage();
            modifyBudget.SendToBack();
            pageNo = 1;
            paginationControl.SelectStarting();
        }

        private void OnBudgetSquareClicked(object sender, int e)
        {
            modifyBudget.Initialize(Communicator.Manager.FetchBudgets(e));
            modifyBudget.BringToFront();
        }

        private void OnSelectedValuesChanged(object sender, string e)
        {
            budgets.Clear();
            if (choiceId == 1)
            {
                if ((sender is CurveButtons btn) && !flag)
                {
                    flag = true;
                    if (!(btn.Text == currentChoices[choiceIndex].Text))
                        currentChoices[choiceIndex].Select = false;
                    else
                        currentChoices[choiceIndex].Select = true;
                }
                else if (!flag)
                {
                    flag = true;
                    if (pastChoices.Count > choiceIndex)
                    {
                        pastChoices[choiceIndex].Select = false;
                    }
                    if (currentChoices.Count > choiceIndex)
                    {
                        currentChoices[choiceIndex].Select = false;
                    }
                    currentChoices[0].Select = true;
                }
                flag = false;
                choiceIndex = 0;
                foreach (CurveButtons btns in currentChoices)
                {
                    if (btns.Select == true)
                    {
                        break;
                    }
                    choiceIndex++;
                }
                CheckChoice();
                if (choice == ExpenseTrackerDS.Budget.Choices.Custom && customeDates.Count > 0)
                    budgets = Communicator.Manager.FetchRecords(ExpenseTrackerDS.Budget.Choices.Custom, Convert.ToDateTime(customeDates[choiceIndex - 4].Item1), Convert.ToDateTime(customeDates[choiceIndex - 4].Item2));//add wallet id
                else
                    budgets = Communicator.Manager.FetchRecords(choice, DateTime.Now, DateTime.Now);//add walllet id
                InitializePaginationButtons();
            }
            else
            {
                if ((sender is CurveButtons btn) && !flag)
                {
                    flag = true;
                    pastChoices[choiceIndex].Select = false;
                }
                else if (!flag)
                {
                    flag = true;
                    if (currentChoices.Count > choiceIndex)
                    {
                        currentChoices[choiceIndex].Select = false;
                    }
                    if (pastChoices.Count > choiceIndex)
                    {
                        pastChoices[choiceIndex].Select = false;
                    }
                    if (pastChoices.Count != 0)
                    {
                        pastChoices[0].Select = true;
                    }
                }
                flag = false;
                choiceIndex = 0;
                foreach(CurveButtons btns in pastChoices)
                {
                    if (btns.Select == true)
                    {
                        break;
                    }
                    choiceIndex++;
                }
                if (customeDates.Count > choiceIndex)
                {
                    budgets = Communicator.Manager.FetchRecords(Convert.ToDateTime(customeDates[choiceIndex].Item1), Convert.ToDateTime(customeDates[choiceIndex].Item2));//add wallet id
                }////condition not verified
                InitializePaginationButtons();
            }
            ShowBudgets();
        }

        private void OnSelectChoiceBtnClicked(object sender, EventArgs e)
        {
            if(periodPanel.Visible == true)
            {
                pastChoicePanel.Enabled = true;
                currentChoicePanel.Enabled = true;
                paginationControl.Enabled = true;
                mainPanel.Enabled = true;
                selectWalletPanel.Enabled = true;
                periodPanel.Visible = false;
            }
            else
            {
                pastChoicePanel.Enabled = false;
                currentChoicePanel.Enabled = false;
                paginationControl.Enabled = false;
                mainPanel.Enabled = false;
                selectWalletPanel.Enabled = false;
                periodPanel.Visible = true;
            }
        }

        private void OnSelectWalletBtnClicked(object sender, EventArgs e)
        {
            if(walletsPanel.Visible == true)
            {
                pastChoicePanel.Enabled = true;
                currentChoicePanel.Enabled = true;
                paginationControl.Enabled = true;
                mainPanel.Enabled = true;
                selectChoicePanel.Enabled = true;
                walletsPanel.Visible = false;
            }
            else
            {
                pastChoicePanel.Enabled = false;
                currentChoicePanel.Enabled = false;
                paginationControl.Enabled = false;
                mainPanel.Enabled = false;
                selectChoicePanel.Enabled = false;
                walletsPanel.Visible = true;
            }
        }

        private void OnChoiceSelected(object sender, string name, int id)
        {
            pastChoicePanel.Enabled = true;
            currentChoicePanel.Enabled = true;
            paginationControl.Enabled = true;
            mainPanel.Enabled = true;
            selectWalletPanel.Enabled = true;
            periodPanel.Visible = false;
            if (id == 1)
            {
                choiceId = 1;
                choiceLbl.Text = "Current";
                currentChoicePanel.Show();
                pastChoicePanel.Hide();
                InitializeBudgetPage();
                modifyBudget.IsEditable = true;
            }
            else
            {
                choiceId = 2;
                choiceLbl.Text = "Past";
                pastChoicePanel.Show();
                currentChoicePanel.Hide();
                InitializeBudgetPage();
                pastBudgets.Clear();
                modifyBudget.IsEditable = false;
                pastBudgets = new List<Budget>();
            }
        }

        private void OnBudgetPageResized(object sender, EventArgs e)
        {
            ControlsPanel.Size = new Size(Width - 24, Height - 62);
        }
        
    }
}
