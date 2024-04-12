using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrackerDS;
using ExpenseTracker;
using System.Drawing.Drawing2D;

namespace ExpenseTrackerGUI
{
    public partial class TransactionManager : UserControl
    {
        public TransactionManager()
        {
            InitializeComponent();
            CreateView();
        }

        #region Paint Events 

        # region Panel Paint Events 
        private void OnPincomePaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, bordercolor, incomebackcolor, pexp.Width, pexp.Height, 10, 10);
        }

        private void OnPexpensePaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, bordercolor, expensebackcolor, pexp.Width, pexp.Height, 10, 10);
        }

        private void OnPresultPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, bordercolor, Color.GhostWhite, presult.Width, presult.Height, 10, 10);
        }

        private void OnPnchoosePaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, bordercolor, Color.White, pnchoose.Width, pnchoose.Height, 10, 10);
        }

        private void OnPselectbtPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.White, sbackcolor, selectbt.Width, selectbt.Height, 8, 10);
        }

        private void OnCategoryNamePaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.White, Color.GhostWhite, pcategoryname.Width, pcategoryname.Height, 8, 10);
        }

        #endregion

        #region Button Paint Events

        private void OnbtPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintButtonOperation(sender, e, bt1.Width, bt1.Height);
        }

        private void OnCustomPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintButtonOperation(sender, e, pcustom.Width, pcustom.Height);
        }

        #endregion

        #endregion

        #region Object Creation

        ChangeWallet wallet = new ChangeWallet();

        #endregion

        #region Input Data to View Transaction

        Color incomebackcolor = Color.GhostWhite, expensebackcolor = Color.GhostWhite, sbackcolor = Color.Lavender;
        Color bordercolor = GUIStyles.primaryColor;
        int presentdate=0, locy = 10, locx = 0, lcy = 10, lcx = 0;
        DateTime startdate, enddate;
        static int index = 0,vtWidth,vtheight, walletid = 0; DateTime sdate, edate;
        static float tincome = 0, texpense = 0;
        static List<ViewIndividual> liviewIndividual = new List<ViewIndividual>();
        static List<ViewTransaction> liviewtransac = new List<ViewTransaction>();
        static List<ViewCategory> liviewcat = new List<ViewCategory>();
        static List<Transaction> liall = new List<Transaction>();
        Dictionary<String, int> expenseli = new Dictionary<string, int>();
        Dictionary<String, int> incomeli = new Dictionary<string, int>();

        #endregion

        #region ViewIndividualTransaction

        public void CreateView()
        {
            for (int i = 0; i < 5; i++)
            {
                ViewIndividual vt = new ViewIndividual
                {
                    Location = new Point(locx, locy)
                };
                vt.ControlDisabled += OnControlDisabled;
                vt.ControlChanged += OnControlChanged;
                Pview.Controls.Add(vt);
                liviewIndividual.Add(vt);
                locy += vt.Height + 18;
                vtWidth = vt.Width; vtheight = vt.Height;
            }
        }

        public void ShowIndividualTransaction(List<Transaction> li)
        {
            Pview.Visible = padown.Visible = paup.Visible = false;
            pnodata.Visible = true;
            liall.Clear(); index = 0;
            liall = new List<Transaction>(li);
            expenseli.Clear(); incomeli.Clear();
            tincome = 0; texpense = 0;
            CheckIncomeExpense(li);
            for (int i = 0; i < liviewIndividual.Count; i++)
            {
                liviewIndividual[i].Visible = false;
            }
            if (liall.Count<=5 && liall.Count>0)
            {
                Pview.Visible = true;
                for(int i = 0; i < liall.Count; i++)
                {
                    liviewIndividual[i].Visible = true;
                    liviewIndividual[i].ViewData = liall[i];
                }
            }
            else if(liall.Count>5)
            {
                Pview.Visible = padown.Visible = true;
                ShowDataIndividualTransac();
                Pview.MouseWheel += OnPviewMouseWheel;
                pscroll.MouseWheel+= OnPviewMouseWheel;
            }
            IncomeExpenseDetails();
        }

        private void ShowDataIndividualTransac()
        {
            int i = 0;
            for (int j = index; j < index + 5; j++)
            {
                liviewIndividual[i].Visible = true;
                liviewIndividual[i].ViewData = liall[j];
                i++;
            }
        }

        #endregion

        #region Mouse Scroll Events

        private void OnPviewMouseWheel(object sender, MouseEventArgs e)
        {
            if (liall.Count > 5)
            {
                if (e.Delta > 0)
                {
                    if (index - 1 > 0)
                    {
                        index--;
                        ShowDataIndividualTransac();
                    }
                    else if (index - 1 == 0)
                    {
                        index--;
                        ShowDataIndividualTransac();
                        padown.Visible = true;
                        paup.Visible = false;
                    }
                    else
                    {
                        padown.Visible = true;
                        paup.Visible = false;
                    }
                }
                else
                {
                    if (index + 1 <liall.Count - 5)
                    {
                        index++;
                        ShowDataIndividualTransac();
                    }
                    else if (index + 1 == liall.Count - 5)
                    {
                        index++;
                        ShowDataIndividualTransac();
                        padown.Visible = false;
                        paup.Visible = true;
                    }
                    else
                    {
                        padown.Visible = false;
                        paup.Visible = true;
                    }
                }
            }
        }

        private void OnPbUpClick(object sender, EventArgs e)
        {
            if (index - 1 > 0)
            {
                index--;
                ShowDataIndividualTransac();
            }
            else if (index - 1 == 0)
            {
                index--;
                ShowDataIndividualTransac();
                padown.Visible = true;
                paup.Visible = false;
            }
            else
            {
                padown.Visible = true;
                paup.Visible = false;
            }
        }

        private void OnPbDownClick(object sender, EventArgs e)
        {
            if (index + 1 < liall.Count - 5)
            {
                index++;
                ShowDataIndividualTransac();
            }
            else if (index + 1 == liall.Count - 5)
            {
                index++;
                ShowDataIndividualTransac();
                padown.Visible = false;
                paup.Visible = true;
            }
            else
            {
                padown.Visible = false;
                paup.Visible = true;
            }
        }

        #endregion

        #region Common Functions for transaction and category

        private void OnControlDisabled(object sender, bool disabled)
        {
            if (disabled == true)
            {
               // pviewtransaction.BackColor = prevenue.BackColor = pincome.BackColor = pexpense.BackColor = bordercolor = Color.Lavender;
                pback.Enabled = false;
            }
            else
            {
               // pviewtransaction.BackColor = prevenue.BackColor = pincome.BackColor = pexpense.BackColor = bordercolor = GUIStyles.primaryColor;
                pback.Enabled = true;
            }
        }

        private void OnControlChanged(object sender, bool changed)
        {
            RefreshTransactionManager();
        }

        private void RefreshTransactionManager()
        {
            if (cdaylb.Text == "View All")
            {
                OnViewAllSelect(this, EventArgs.Empty);
            }
            else if (cdaylb.Text == "Custom")
            {
                OnCustomSelect(this, EventArgs.Empty);
            }
            else
            {
                FindData();
            }
        }

        private void IncomeExpenseDetails()
        {
            expensedata.Items.Clear();
            incomedata.Items.Clear();
            expensedata.Visible = true; incomedata.Visible = true;
            if (expenseli.Count > 0)
            {
                for (int i = 0; i < expenseli.Count; i++)
                {
                    expensedata.Items.Add(expenseli.ElementAt(i).Value + "   " + expenseli.ElementAt(i).Key);
                }
            }
            else
            {
                expensedata.Visible = false;
            }
            if (incomeli.Count > 0)
            {
                for (int i = 0; i < incomeli.Count; i++)
                {
                    incomedata.Items.Add(incomeli.ElementAt(i).Value + "   " + incomeli.ElementAt(i).Key);
                }
            }
            else
            {
                incomedata.Visible = false;
            }
            incomeamt.Text = "₹  " + tincome.ToString();
            expenseamt.Text = "₹  " + texpense.ToString();
            totalamt.Text = "₹  " + (tincome - texpense).ToString();
        }

        private void CheckIncomeExpense(List<Transaction> transac)
        {
            for (int i = 0; i < transac.Count; i++)
            {
                if (Communicator.Manager.FetchCategoryName(transac[i].CategoryId).Type == false)
                {
                    if (expenseli.ContainsKey(transac[i].CategoryName))
                    {
                        expenseli[transac[i].CategoryName]++;
                    }
                    else
                    {
                        expenseli.Add(transac[i].CategoryName, 1);
                    }
                    texpense += transac[i].Amount;
                }
                else
                {
                    if (incomeli.ContainsKey(transac[i].CategoryName))
                    {
                        incomeli[transac[i].CategoryName]++;
                    }
                    else
                    {
                        incomeli.Add(transac[i].CategoryName, 1);
                    }
                    tincome += transac[i].Amount;
                }
            }
        }

        #endregion

        #region ViewCategory

        public void ShowCategory(Dictionary<String,List<Transaction>> dicat)
        {
            for (int i = 0; i < liviewtransac.Count; i++)
            {
                liviewtransac[i].Dispose();
            }
            for (int i = 0; i < liviewcat.Count; i++)
            {
                liviewcat[i].Dispose();
            }
            liviewcat.Clear();lcy = 10;
            expenseli.Clear(); incomeli.Clear();
            tincome = 0; texpense = 0;
            Pview.Visible = padown.Visible = paup.Visible = pnodata.Visible = false;
            index = 0;
            if (dicat.Count == 0)
            {
                pnodata.Visible = true;
            }
            else
            {
                for (int i = 0; i < dicat.Count; i++)
                {
                    CheckIncomeExpense(dicat.ElementAt(i).Value);
                    AssignValueCat(i,dicat);
                }
            }
            IncomeExpenseDetails();
        }

        private void AssignValueCat(int j, Dictionary<String, List<Transaction>> dicat)
        {            
            if (dicat.ElementAt(j).Value.Count > 0)
            {
                ViewCategory vc = new ViewCategory
                {
                    ListData = dicat.ElementAt(j).Value,
                    Location = new Point(lcx, lcy)
                };
                vc.ControlChanged += OnControlChanged;
                vc.ControlDisabled += OnControlDisabled;
                pviewcategory.Controls.Add(vc);
                liviewcat.Add(vc);
                lcy += vc.Height + 10;
            }
        }

        #endregion

        #region ViewTransaction

        public void ShowTransaction(Dictionary<DateTime, List<Transaction>> ditransac)
        {
            for (int i = 0; i < liviewcat.Count; i++)
            {
                liviewcat[i].Dispose();
            }
            for (int i = 0; i < liviewtransac.Count; i++)
            {
                liviewtransac[i].Dispose();
            }
            liviewtransac.Clear(); lcy = 10;
            expenseli.Clear(); incomeli.Clear();
            tincome = 0; texpense = 0;
            Pview.Visible = padown.Visible = paup.Visible = pnodata.Visible = false;
            sdate = startdate; edate = enddate;
            index = 0;
            if (ditransac.Count == 0)
            {
                pnodata.Visible = true;
            }
            else
            {
                for (int i = 0; i < ditransac.Count; i++)
                {
                    CheckIncomeExpense(ditransac.ElementAt(i).Value);
                    AssignValueTransac(i,ditransac);
                }
            }
            IncomeExpenseDetails();
        }

        private void AssignValueTransac(int j, Dictionary<DateTime, List<Transaction>> ditransac)
        {
            if (ditransac.ElementAt(j).Value.Count > 0)
            {
                ViewTransaction vt=new ViewTransaction
                {
                    ListData = ditransac.ElementAt(j).Value,
                    Location = new Point(lcx, lcy)
                };
                vt.ControlChanged += OnControlChanged;
                vt.ControlDisabled += OnControlDisabled;
                pviewcategory.Controls.Add(vt);
                liviewtransac.Add(vt);
                lcy += vt.Height + 10;
            }
        }

        #endregion

        #region Transaction Manager Load

        private void OnTransactionManagerLoad(object sender, EventArgs e)
        {
            presult.Paint += OnPresultPaint; pnchoose.Paint += OnPnchoosePaint;
            pexp.Paint += OnPexpensePaint; pinc.Paint += OnPincomePaint; pselectbt.Paint += OnPselectbtPaint;
            wallet.AddMode = false;
            pselectwallet.Controls.Add(wallet);
            wallet.Dock = DockStyle.Fill;
            pselectwallet.Visible = false;
            walletnamelb.Text = "Total";
            bt2.BackColor = GUIStyles.terenaryColor;
            presentdate = TransactionEditor.viewday.Count - 3;
            OnIndividualSelect(this, EventArgs.Empty);
        }

        private void AdjustSize()
        {
            prevenue.BackColor = pincome.BackColor = pexpense.BackColor = pviewtransaction.BackColor = GUIStyles.primaryColor;
            pend.Width = pviewtransaction.Width * 99 / 100;
            pend.Height = pviewtransaction.Height * 94 / 100;
            pend.Location = new Point(pviewtransaction.Width / 2 - pend.Width / 2, lhead.Height);
            pbutton.Width = poption.Width * 50 / 100;
            bt1.Width = pbutton.Width * 30 / 100; pm1.Width = pbutton.Width * 5 / 100;
            bt2.Width = pbutton.Width * 30 / 100; pm2.Width = pbutton.Width * 5 / 100; bt3.Width = pbutton.Width * 30 / 100;
            pshow.Width = vtWidth + 50;
            pshow.Height = vtheight * 5 + 140;
            pbutton.Location = new Point((poption.Width / 2 - pbutton.Width / 2) + 80);
            pnchoose.Location = new Point(pback.Width - pnchoose.Width - 10, 10);
            pselectcategorytransaction.Size = new Size(273, 105);
            pselectcategorytransaction.Location = new Point(pback.Width - pselectcategorytransaction.Width -20, pnchoose.Height - 38);
            pselectviewtype.Size = new Size(273, 245);
            pselectviewtype.Location = new Point(pback.Width - pselectviewtype.Width - 20, pnchoose.Height );
            //  pchoose.Location = new Point(pback.Width - pchoose.Width - 4, 5);
            pcustom.Location = new Point(pback.Width - pcustom.Width - 4, pnchoose.Location.Y + pnchoose.Height + 10);
            prevenue.Location = new Point(presult.Width / 5, 80);
            pexpense.Location = new Point(presult.Width / 5, prevenue.Location.Y + prevenue.Height + 50);
            pincome.Location = new Point(presult.Width / 5, pexpense.Location.Y + pexpense.Height + 50);
            pshow.Location = new Point(pbutton.Location.X + 5, pdown.Height / 2 - pshow.Height / 2 + 30);
            pcategoryname.Location = new Point((pshow.Location.X)+pshow.Width / 2 - pcategoryname.Width / 2, pshow.Location.Y - pcategoryname.Height - 20);
            pselectwallet.Size = new Size(475, 502);
            pselectwallet.Location = new Point(34, 5);
            expensedata.Width = pexp.Width * 90 / 100; incomedata.Width = pinc.Width * 90 / 100;
            expensedata.Height = pexp.Height * 90 / 100; incomedata.Height = pinc.Height * 90 / 100;
            expensedata.Location = new Point(pexp.Width / 2 - expensedata.Width / 2, pexp.Height / 2 - expensedata.Height / 2);
            incomedata.Location = new Point(pinc.Width / 2 - incomedata.Width / 2, pinc.Height / 2 - incomedata.Height / 2);
            nodatalb1.Height = pshow.Height / 2;
            nodatalb2.Height = pshow.Height / 2;
            AddOptions();
        }

        private void AddOptions()
        {
            TransactionEditor.AddDay();
            TransactionEditor.AddWeek();
            TransactionEditor.AddMonth();
            TransactionEditor.AddQuarter();
            TransactionEditor.AddYear();
           // TransactionEditor.AddViewOption();
           // ViewOptions.DataSource = TransactionEditor.viewoption;
           // ViewCategoryTransaction.DataSource = TransactionEditor.viewcategory;
        }

        #endregion

        #region Transaction Manager Resize

        private void OnTRansactionManagerResize(object sender, EventArgs e)
        {
            AdjustSize();
        }

        #endregion

        #region Wallet , Custom and Category Selection

        private void OnSelectWalletbtClick(object sender, EventArgs e)
        {
            pback.SuspendLayout();
            pnchoose.Enabled = pshow.Enabled = poption.Enabled = pexpense.Enabled = pincome.Enabled = prevenue.Enabled = false;
            pselectwallet.BringToFront();
            pselectwallet.Visible = true;
            wallet.WalletClick += OnWalletClick;
            wallet.WalletClose += OnWalletClose;
            pback.ResumeLayout();
        }

        private void OnWalletClose(object sender, EventArgs e)
        {
            pselectwallet.Visible = false;
            pnchoose.Enabled = pshow.Enabled = poption.Enabled = pexpense.Enabled = pincome.Enabled = prevenue.Enabled = true;
        }

        private void OnWalletClick(object sender, Wallet e)
        {
            walletnamelb.Text = e.WalletName;
            if (walletid != e.WalletID)
            {
                walletid = e.WalletID;
                RefreshTransactionManager();
            }
            pselectwallet.Visible = false;
            pnchoose.Enabled = pshow.Enabled = poption.Enabled = pexpense.Enabled = pincome.Enabled = prevenue.Enabled = true;
        }

        private void OnSelectCLick(object sender, EventArgs e)
        {
            if (pnchoose.Visible == true)
                pnchoose.Visible = false;
            else
                pnchoose.Visible = true;
        }

        private void OnDoneBtClick(object sender, EventArgs e)
        {
            pcday.Enabled = pcindividual.Enabled = true;
            pbutton.Enabled = false;
            startdate = startpicker.Value;
            enddate = endpicker.Value;
            if (enddate >= startdate)
            {
                pcategoryname.Visible = true;
                categorynamelb.Text = startdate.ToString("dd/MM/yyyy") + " - " + enddate.ToString("dd/MM/yyyy");
                pcustom.Visible = false;
                pshow.Enabled = poption.Enabled = pnchoose.Enabled = pincome.Enabled = pexpense.Enabled = prevenue.Enabled = true;
                if (cindividuallb.Text == "View By Category")
                {
                    Dictionary<string, List<Transaction>> licustom = Communicator.Manager.FetchTransactionOnDates<Dictionary<string, List<Transaction>>>(startdate, enddate, Manager.ViewType.Custom, walletid);
                    ShowCategory(licustom);
                }
                else if (cindividuallb.Text == "View Individual Transaction")
                {
                    List<Transaction> licustom = Communicator.Manager.FetchTransactionOnDates<List<Transaction>>(startdate, enddate, Manager.ViewType.Custom, walletid);
                    ShowIndividualTransaction(licustom);
                }
                else
                {
                    Dictionary<DateTime, List<Transaction>> licustom = Communicator.Manager.FetchTransactionOnDates<Dictionary<DateTime, List<Transaction>>>(startdate, enddate, Manager.ViewType.Custom, walletid);
                    ShowTransaction(licustom);
                }
            }
            else
            {
                Messagelb.Visible = true;
            }
        }

        private void OnBackBtClick(object sender, EventArgs e)
        {
            FindData();
            pcustom.Visible = false;
            pcday.Enabled = pcindividual.Enabled = pshow.Enabled = poption.Enabled = pnchoose.Enabled = pincome.Enabled = pexpense.Enabled = prevenue.Enabled = true;
        }
        #endregion

        #region Button select (view by date)

        private void OnSelectDatebtClick(object sender, EventArgs e)
        {
            if (pselectviewtype.Visible == false)
            {
                pbutton.Enabled = pcindividual.Enabled = pcustom.Visible = poption.Enabled = pshow.Enabled = pcategoryname.Visible = false;
                pselectviewtype.BringToFront();
                pselectviewtype.Visible = true;
            }
            else
            {
                pbutton.Enabled = pcindividual.Enabled = poption.Enabled = pshow.Enabled = true;
                pselectviewtype.Visible = false;
            }
        }

        private void OnDaySelect(object sender, EventArgs e)
        {
            cdaylb.Text = "View by Day";
            pbutton.Enabled = pcindividual.Enabled = poption.Enabled = pshow.Enabled = true;
            pselectviewtype.Visible = false;
            presentdate = TransactionEditor.viewday.Count - 3;
            DaybtData();
            Button2Color();
            FindData(); 
        }

        private void OnWeekSelect(object sender, EventArgs e)
        {
            cdaylb.Text = "View by Week";
            pbutton.Enabled = pcindividual.Enabled = poption.Enabled = pshow.Enabled = true;
            pselectviewtype.Visible = false;
            presentdate = TransactionEditor.viewweek.Count - 3;
            WeekbtData();
            Button2Color();
            FindData(); 
        }

        private void OnMonthSelect(object sender, EventArgs e)
        {
            cdaylb.Text = "View by Month";
            pbutton.Enabled = pcindividual.Enabled = poption.Enabled = pshow.Enabled = true;
            pselectviewtype.Visible = false;
            presentdate = TransactionEditor.viewmonth.Count - 3;
            MonthbtData();
            Button2Color();
            FindData(); 
        }

        private void OnQuarterSelect(object sender, EventArgs e)
        {
            cdaylb.Text = "View by Quarter";
            pbutton.Enabled = pcindividual.Enabled = poption.Enabled = pshow.Enabled = true;
            pselectviewtype.Visible = false;
            presentdate = TransactionEditor.viewquarter.Count - 3;
            QuarterbtData();
            Button2Color();
            FindData(); 
        }

        private void OnYearSelect(object sender, EventArgs e)
        {
            cdaylb.Text = "View by Year";
            pbutton.Enabled = pcindividual.Enabled = poption.Enabled = pshow.Enabled = true;
            pselectviewtype.Visible = false;
            presentdate = TransactionEditor.viewyear.Count - 3;
            YearbtData();
            Button2Color();
            FindData(); 
        }

        private void OnViewAllSelect(object sender, EventArgs e)
        {
            pcategoryname.Visible = true;
            categorynamelb.Text = "All Transactions";
            cdaylb.Text = "View All";
            pbutton.Enabled = false;
            pcindividual.Enabled = poption.Enabled = pshow.Enabled = true;
            pselectviewtype.Visible = false;
            if (cindividuallb.Text == "View by Category")
            {
                Dictionary<string, List<Transaction>> liall = Communicator.Manager.FetchTransactions<Dictionary<string, List<Transaction>>>(walletid);
                ShowCategory(liall);
            }
            else if (cindividuallb.Text == "View Individual Transaction")
            {
                List<Transaction> liall = Communicator.Manager.FetchTransactions<List<Transaction>>(walletid);
                ShowIndividualTransaction(liall);
            }
            else
            {
                Dictionary<DateTime, List<Transaction>> liall = Communicator.Manager.FetchTransactions<Dictionary<DateTime, List<Transaction>>>(walletid);
                ShowTransaction(liall);
            }
        }

        private void OnCustomSelect(object sender, EventArgs e)
        {
            cdaylb.Text = "Custom";
            startpicker.Value = DateTime.Now.AddDays(-1);
            pshow.Enabled = poption.Enabled = pnchoose.Enabled = pincome.Enabled = pexpense.Enabled = prevenue.Enabled = pselectviewtype.Visible = false;
            pcustom.Visible = true;
        }
        #endregion

        #region Button select (view by category)

        private void OnSelectTypeBtClick(object sender, EventArgs e)
        {
            if (pselectviewtype.Visible == false)
            {
                pbutton.Enabled = pcday.Enabled = poption.Enabled = pshow.Enabled = Pview.Enabled = false;
                pselectcategorytransaction.BringToFront();
                pselectcategorytransaction.Visible = true;
                //pcindividual.Enabled = pcustom.Visible = poption.Enabled = pshow.Enabled = pcategoryname.Visible = false;
                //pselectviewtype.BringToFront();
                //pselectviewtype.Visible = true;
            }
            else
            {
                pbutton.Enabled = pcday.Enabled = poption.Enabled = pshow.Enabled = Pview.Enabled = true;
                pselectcategorytransaction.Visible = false;
            }
        }

        private void OnIndividualSelect(object sender, EventArgs e)
        {
            cindividuallb.Text = "View Individual Transaction";
            pbutton.Enabled = pcday.Enabled = poption.Enabled = pshow.Enabled = Pview.Enabled = Pview.Visible = true;
            pselectcategorytransaction.Visible = false;
            Pview.BringToFront();
            RefreshTransactionManager();
        }

        private void OnCategorySelect(object sender, EventArgs e)
        {
            cindividuallb.Text = "View by Category";
            pbutton.Enabled = pcday.Enabled = poption.Enabled = pshow.Enabled = Pview.Enabled = true;
            pselectcategorytransaction.Visible = Pview.Visible = false;
            RefreshTransactionManager();
        }

        private void OnTransactionSelect(object sender, EventArgs e)
        {
            cindividuallb.Text = "View by Transaction";
            pbutton.Enabled = pcday.Enabled = poption.Enabled = pshow.Enabled = Pview.Enabled = true;
            pselectcategorytransaction.Visible = Pview.Visible = false;
            RefreshTransactionManager();
        }
        #endregion

        #region Button text change functions

        private void DaybtData()
        {
            bt1.Text = TransactionEditor.viewday[presentdate];
            bt2.Text = TransactionEditor.viewday[presentdate + 1];
            bt3.Text = TransactionEditor.viewday[presentdate + 2];
        }

        private void WeekbtData()
        {
            bt1.Text = TransactionEditor.viewweek[presentdate];
            bt2.Text = TransactionEditor.viewweek[presentdate + 1];
            bt3.Text = TransactionEditor.viewweek[presentdate + 2];
        }

        private void MonthbtData()
        {
            bt1.Text = TransactionEditor.viewmonth[presentdate];
            bt2.Text = TransactionEditor.viewmonth[presentdate + 1];
            bt3.Text = TransactionEditor.viewmonth[presentdate + 2];
        }

        private void QuarterbtData()
        {
            bt1.Text = TransactionEditor.viewquarter[presentdate];
            bt2.Text = TransactionEditor.viewquarter[presentdate + 1];
            bt3.Text = TransactionEditor.viewquarter[presentdate + 2];
        }

        private void YearbtData()
        {
            bt1.Text = TransactionEditor.viewyear[presentdate];
            bt2.Text = TransactionEditor.viewyear[presentdate + 1];
            bt3.Text = TransactionEditor.viewyear[presentdate + 2];
        }
        #endregion

        #region  Button Click Events

        private void OnBt1Click(object sender, EventArgs e)
        {
            if (bt1.BackColor == GUIStyles.terenaryColor)
            {
                return;
            }
            if (cdaylb.Text == "View by Day")
            {
                if (presentdate - 1 >= 0)
                {
                    presentdate--;
                    DaybtData();
                    Button2Color();
                }
                else
                    Button1Color();
            }
            else if (cdaylb.Text == "View by Week")
            {
                if (presentdate - 1 >= 0)
                {
                    presentdate--;
                    WeekbtData();
                    Button2Color();
                }
                else
                    Button1Color();
            }
            else if (cdaylb.Text == "View by Month")
            {
                if (presentdate - 1 >= 0)
                {
                    presentdate--;
                    MonthbtData();
                    Button2Color();
                }
                else
                    Button1Color();
            }
            else if (cdaylb.Text == "View by Quarter")
            {
                if (presentdate - 1 >= 0)
                {
                    presentdate--;
                    QuarterbtData();
                    Button2Color();
                }
                else
                    Button1Color();
            }
            else if (cdaylb.Text == "View by Year")
            {
                if (presentdate - 1 >= 0)
                {
                    presentdate--;
                    YearbtData();
                    Button2Color();
                }
                else
                    Button1Color();
            }
            FindData();
        }

        private void OnBt2Click(object sender, EventArgs e)
        {
            if (bt2.BackColor == GUIStyles.terenaryColor)
            {
                return;
            }
            Button2Color();
            FindData();
        }

        private void OnBt3Click(object sender, EventArgs e)
        {
            if (bt3.BackColor == GUIStyles.terenaryColor)
            {
                return;
            }
            if (cdaylb.Text == "View by Day")
            {
                if (presentdate + 1 <= TransactionEditor.viewday.Count - 3)
                {
                    presentdate++;
                    DaybtData();
                    Button2Color();
                }
                else
                    Button3Color();
            }
            else if (cdaylb.Text == "View by Week")
            {
                if (presentdate + 1 <= TransactionEditor.viewweek.Count - 3)
                {
                    presentdate++;
                    WeekbtData();
                    Button2Color();
                }
                else
                    Button3Color();
            }
            else if (cdaylb.Text == "View by Month")
            {
                if (presentdate + 1 <= TransactionEditor.viewmonth.Count - 3)
                {
                    presentdate++;
                    MonthbtData();
                    Button2Color();
                }
                else
                    Button3Color();
            }
            else if (cdaylb.Text == "View by Quarter")
            {
                if (presentdate + 1 <= TransactionEditor.viewquarter.Count - 3)
                {
                    presentdate++;
                    QuarterbtData();
                    Button2Color();
                }
                else
                    Button3Color();
            }
            else if (cdaylb.Text == "View by Year")
            {
                if (presentdate + 1 <= TransactionEditor.viewyear.Count - 3)
                {
                    presentdate++;
                    YearbtData();
                    Button2Color();
                }
                else
                    Button3Color();
            }
            FindData();
        }

        private void Button1Color()
        {
            ActiveControl = bt1;
            bt1.BackColor = GUIStyles.terenaryColor;
            bt2.BackColor = bt3.BackColor = Color.White;
        }

        private void Button2Color()
        {
            ActiveControl = bt2;
            bt1.BackColor = bt3.BackColor = Color.White;
            bt2.BackColor = GUIStyles.terenaryColor;
        }

        private void Button3Color()
        {
            ActiveControl = bt3;
            bt1.BackColor = bt2.BackColor = Color.White;
            bt3.BackColor = GUIStyles.terenaryColor;
        }
        #endregion

        #region Find Data To View Transaction

        private void FindData()
        {
            String str = "";
            if (bt1.BackColor == GUIStyles.terenaryColor)
                str = bt1.Text;
            else if (bt2.BackColor == GUIStyles.terenaryColor)
                str = bt2.Text;
            else if (bt3.BackColor == GUIStyles.terenaryColor)
                str = bt3.Text;

            if (str == "Future")
            {
                FindFuture(DateTime.Now);
                return;
            }

            if (cdaylb.Text == "View by Day")
                FindExactDay(str);
            else if (cdaylb.Text == "View by Week")
                FindExactWeek(str);
            else if (cdaylb.Text == "View by Month")
                FindExactMonth(str);
            else if (cdaylb.Text == "View by Quarter")
                FindExactQuarter(str);
            else if (cdaylb.Text == "View by Year")
                FindExactYear(str);
        }

        private void FindExactDay(String str)
        {
            DateTime dt=TransactionEditor.FindDay(str);
            List<String> datetime = new List<string>
            {
                dt.ToString(),
                dt.ToString()
            };
            FetchData(datetime, Manager.ViewType.Day);
        }

        private void FindExactWeek(String str)
        {
            DateTime dt = TransactionEditor.FindWeek(str);
            List<String> datetime = Communicator.Manager.FindWeek(dt);
            FetchData(datetime, Manager.ViewType.Week);
        }

        private void FindExactMonth(String str)
        {
            DateTime dt = TransactionEditor.FindMonth(str);
            List<String> datetime = Communicator.Manager.FindMonth(dt);
            FetchData(datetime, Manager.ViewType.Month);
        }

        private void FindExactQuarter(String str)
        {
            DateTime dt = TransactionEditor.FindQuarter(str);
            List<String> datetime = Communicator.Manager.FindQuartar(dt);
            FetchData(datetime, Manager.ViewType.Quarter);
        }

        private void FindExactYear(String str)
        {
            DateTime dt = TransactionEditor.FindYear(str);
            List<String> datetime = Communicator.Manager.FindYear(dt);
            FetchData(datetime, Manager.ViewType.Year);
        }

        private void FindFuture(DateTime dt)
        {
            List<String> datetime = new List<string>
            {
                dt.ToString(),
                dt.ToString()
            };
            FetchData(datetime, Manager.ViewType.Future);
        }

        private void FetchData(List<String> datetime, Manager.ViewType type)
        {
            DateTime sdate = DateTime.Parse(datetime[0]);
            DateTime edate = DateTime.Parse(datetime[1]);
            if (cindividuallb.Text == "View by Category")
            {
                Dictionary<string, List<Transaction>> lidata = Communicator.Manager.FetchTransactionOnDates<Dictionary<string, List<Transaction>>>(sdate, edate, type, walletid);
                ShowCategory(lidata);
            }
            else if (cindividuallb.Text == "View Individual Transaction")
            {
                List<Transaction> lidata = Communicator.Manager.FetchTransactionOnDates<List<Transaction>>(sdate, edate, type, walletid);
                ShowIndividualTransaction(lidata);
            }
            else
            {
                Dictionary<DateTime, List<Transaction>> lidata = Communicator.Manager.FetchTransactionOnDates<Dictionary<DateTime, List<Transaction>>>(sdate, edate, type, walletid);
                ShowTransaction(lidata);
            }
        }
        #endregion

        #region MouseEnterEvents
        private void OnSelectBtMouseEnter(object sender, EventArgs e)
        {
            sbackcolor = GUIStyles.terenaryColor; selectbt.Invalidate();
        }

        private void OnSelectBtMouseLeave(object sender, EventArgs e)
        {
            sbackcolor = Color.Lavender; selectbt.Invalidate();
        }

        private void OnBackBtMouseEnter(object sender, EventArgs e)
        {
            backbt.ForeColor = Color.Gray;
        }

        private void OnBackBtMouseLeave(object sender, EventArgs e)
        {
            backbt.ForeColor = Color.DarkBlue;
        }

        private void OnExpenseMouseEnter(object sender, EventArgs e)
        {
            expensebackcolor = Color.Lavender; expensedata.BackColor = expensebackcolor; pexp.Invalidate(); 
        }

        private void OnExpenseMouseLeave(object sender, EventArgs e)
        {
            expensebackcolor = Color.GhostWhite; expensedata.BackColor = expensebackcolor; pexp.Invalidate();
        }

        private void OnIncomeMouseEnter(object sender, EventArgs e)
        {
            incomebackcolor = Color.Lavender; incomedata.BackColor = incomebackcolor; pinc.Invalidate();
        }

        private void OnIncomeMouseLeave(object sender, EventArgs e)
        {
            incomebackcolor = Color.GhostWhite; incomedata.BackColor = incomebackcolor; pinc.Invalidate();
        }

        private void OnDayMouseEnter(object sender, EventArgs e)
        {
            daypb.BackColor = daymid.BackColor = daylb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnDayMouseLeave(object sender, EventArgs e)
        {
            daypb.BackColor = daymid.BackColor = daylb.BackColor = Color.GhostWhite;
        }

        private void OnWeekMouseEnter(object sender, EventArgs e)
        {
            weekpb.BackColor = weekmid.BackColor = weeklb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnWeekMouseLeave(object sender, EventArgs e)
        {
            weekpb.BackColor = weekmid.BackColor = weeklb.BackColor = Color.GhostWhite;
        }

        private void OnMonthMouseEnter(object sender, EventArgs e)
        {
            monthpb.BackColor = monthmid.BackColor = monthlb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnMonthMouseLeave(object sender, EventArgs e)
        {
            monthpb.BackColor = monthmid.BackColor = monthlb.BackColor = Color.GhostWhite;
        }

        private void OnQuarterMouseEnter(object sender, EventArgs e)
        {
            quarterpb.BackColor = quartermid.BackColor = quarterlb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnQuarterMouseLeave(object sender, EventArgs e)
        {
            quarterpb.BackColor = quartermid.BackColor = quarterlb.BackColor = Color.GhostWhite;
        }

        private void OnYearMouseEnter(object sender, EventArgs e)
        {
            yearpb.BackColor = yearmid.BackColor = yearlb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnYearMouseLeave(object sender, EventArgs e)
        {
            yearpb.BackColor = yearmid.BackColor = yearlb.BackColor = Color.GhostWhite;
        }

        private void OnViewAllMouseEnter(object sender, EventArgs e)
        {
            allpb.BackColor = allmid.BackColor = alllb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnViewAllMouseLeave(object sender, EventArgs e)
        {
            allpb.BackColor = allmid.BackColor = alllb.BackColor = Color.GhostWhite;
        }

        private void OnCustomMouseEnter(object sender, EventArgs e)
        {
            custompb.BackColor = custommid.BackColor = customlb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnCustomMouseLeave(object sender, EventArgs e)
        {
            custompb.BackColor = custommid.BackColor = customlb.BackColor = Color.GhostWhite;
        }

        private void OnIndividualMouseEnter(object sender, EventArgs e)
        {
            individualpb.BackColor = individualmid.BackColor = individuallb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnIndividualMouseLeave(object sender, EventArgs e)
        {
            individualpb.BackColor = individualmid.BackColor = individuallb.BackColor = Color.White;
        }

        private void OnCategoryMouseEnter(object sender, EventArgs e)
        {
            categorypb.BackColor = categorymid.BackColor = categorylb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnCategoryMouseLeave(object sender, EventArgs e)
        {
            categorypb.BackColor = categorymid.BackColor = categorylb.BackColor = Color.White;
        }

        private void OnTransactionMouseEnter(object sender, EventArgs e)
        {
            transactionpb.BackColor = transactonmid.BackColor = transactionlb.BackColor = GUIStyles.terenaryColor;
        }

        private void OnTransactionMouseLeave(object sender, EventArgs e)
        {
            transactionpb.BackColor = transactonmid.BackColor = transactionlb.BackColor = Color.White;
        }
        #endregion

        //private void ViewByCategoryOrTransactionIndexChanged(object sender, EventArgs e)
        //{
        //    if (ViewCategoryTransaction.Text == "Individual Transaction")
        //    {
        //        pcategoryview.Visible = false;
        //        Pview.Visible = true;
        //        Pview.BringToFront();
        //        RefreshTransactionManager();
        //    }
        //    else
        //    {
        //        Pview.Visible = false;
        //        pcategoryview.Visible = true;
        //        RefreshTransactionManager();
        //    }
        //}

        //private void ViewByDateIndexChanged(object sender, EventArgs e)
        //{
        //    pcustom.Visible = false;
        //    pbutton.Enabled = true;
        //    if (ViewOptions.Text == "View All")
        //    {
        //        pbutton.Enabled = false;
        //        if (ViewCategoryTransaction.Text == "View By Category")
        //        {
        //            Dictionary<string, List<Transaction>> liall = Communicator.Manager.FetchTransactions<Dictionary<string, List<Transaction>>>(walletid);
        //            ShowCategory(liall);
        //        }
        //        else if (ViewCategoryTransaction.Text == "Individual Transaction")
        //        {
        //            List<Transaction> liall = Communicator.Manager.FetchTransactions<List<Transaction>>(walletid);
        //            ShowIndividualTransaction(liall);
        //        }
        //        else
        //        {
        //            Dictionary<DateTime, List<Transaction>> liall = Communicator.Manager.FetchTransactions<Dictionary<DateTime, List<Transaction>>>(walletid);
        //            ShowTransaction(liall);
        //        }
        //        return;
        //    }
        //    else if (ViewOptions.Text == "Custom")
        //    {
        //        startpicker.Value = DateTime.Now.AddDays(-1);
        //        pcustom.Visible = true;
        //        pshow.Enabled =  poption.Enabled = pbutton.Enabled = pnchoose.Enabled = pincome.Enabled = pexpense.Enabled = prevenue.Enabled = false;
        //        return;
        //    }
        //    else if (ViewOptions.Text == "View by Day")
        //    {
        //        presentdate = TransactionEditor.viewday.Count - 3;
        //        DaybtData();
        //    }
        //    else if (ViewOptions.Text == "View by Week")
        //    {
        //        presentdate = TransactionEditor.viewweek.Count - 3;
        //        WeekbtData();
        //    }
        //    else if (ViewOptions.Text == "View by Month")
        //    {
        //        presentdate = TransactionEditor.viewmonth.Count - 3;
        //        MonthbtData();
        //    }
        //    else if (ViewOptions.Text == "View by Quarter")
        //    {
        //        presentdate = TransactionEditor.viewquarter.Count - 3;
        //        QuarterbtData();
        //    }
        //    else if (ViewOptions.Text == "View by Year")
        //    {
        //        presentdate = TransactionEditor.viewyear.Count - 3;
        //        YearbtData();
        //    }
        //    Button2Color();
        //    FindData();

        //}
    }
}