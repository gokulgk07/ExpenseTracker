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
    public partial class CreateTransaction : UserControl
    {
        public CreateTransaction()
        {
            InitializeComponent();
        }

        //Object Creation

        CategoryView categoryview = new CategoryView();
        ChangeWallet wallet = new ChangeWallet();

        //Input Data To Create Transaction

        int categoryid = 0, walletid = 0;
        String description = "", categoryname = "",walletname="";
        float amount;
        DateTime date;

        //Load Page

        private void OnCreateTransactionLoad(object sender, EventArgs e)
        {
            padd.BackColor = GUIStyles.terenaryColor;
            pback.Controls.Add(categoryview);
            categoryview.Dock = DockStyle.Fill;
            wallet.TotalShow = false;
            wallet.AddMode = false;
            pback.Controls.Add(wallet);
            wallet.Dock = DockStyle.Fill;
            wallet.Visible = false;
            categoryview.Visible = false;
            AdjustSize();
        }

        private void OnPaddPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, GUIStyles.terenaryColor, GUIStyles.primaryColor, padd.Width, padd.Height, 25, 50);
        }

        //Resize Page

        private void OnCreateTransactionResize(object sender, EventArgs e)
        {
            AdjustSize();
            amountlb.Font = new Font("Arial", padd.Width / 50);
            categorylb.Font = new Font("Arial", padd.Width / 50);
            datelb.Font = new Font("Arial", padd.Width / 50);
            descriptionlb.Font = new Font("Arial", padd.Width / 50);
            walletlb.Font = new Font("Arial", padd.Width / 50);
            amountlb.Location = new Point(padd.Width * 10 / 100, padd.Height * 10 / 100);
            categorylb.Location = new Point(padd.Width * 10 / 100, padd.Height * 22 / 100);
            datelb.Location = new Point(padd.Width * 10 / 100, padd.Height * 35 / 100);
            descriptionlb.Location = new Point(padd.Width * 10 / 100, padd.Height * 47 / 100);
            walletlb.Location = new Point(padd.Width * 10 / 100, padd.Height * 60 / 100);
            //
            amounttb.Location = new Point(padd.Width * 50 / 100, padd.Height * 10 / 100);
            categoryselectbt.Location = new Point(padd.Width * 50 / 100, padd.Height * 22 / 100);
            datepicker.Location = new Point(padd.Width * 50 / 100, padd.Height * 35 / 100);
            descriptiontb.Location = new Point(padd.Width * 50 / 100, padd.Height * 47 / 100);
            walletbt.Location = new Point(padd.Width * 50 / 100, padd.Height * 60 / 100);
            //
            lresult.Font = new Font("Arial", padd.Width / 60);
            lresult.Location = new Point(padd.Width * 40 / 100, padd.Height * 70 / 100);
            Clearbt.Font = new Font("Arial", padd.Width / 60);
            Clearbt.Location = new Point(padd.Width * 30 / 100, padd.Height * 80 / 100);
            savebt.Font = new Font("Arial", padd.Width / 60);
            savebt.Location = new Point(padd.Width * 60 / 100, padd.Height * 80 / 100);
        }

        private void AdjustSize()
        {
            paddtransaction.BackColor = GUIStyles.primaryColor;
            pback.Width = paddtransaction.Width * 60 / 100;
            pback.Height = paddtransaction.Height * 70 / 100;
            padd.Width = paddtransaction.Width * 70 / 100;
            padd.Height = paddtransaction.Height * 70 / 100;
            pborder.Width = paddtransaction.Width * 99 / 100;
            pborder.Height = paddtransaction.Height * 94 / 100;
            pback.Location = new Point(paddtransaction.Width / 2 - pback.Width / 2, paddtransaction.Height / 2 - pback.Height / 2);
            padd.Location = new Point(paddtransaction.Width / 2 - padd.Width / 2, paddtransaction.Height / 2 - padd.Height / 2);
            pborder.Location=new Point(paddtransaction.Width / 2 - pborder.Width / 2, lhead.Height);
        }

        //Button Click Functions

        private void OnSaveBtClick(object sender, EventArgs e)
        {
            lresult.Text = "";
            if (CheckAmount() == true && CheckCategory() == true && CheckBudget() == true)//&& CheckDescription() == true
            {
                amount = float.Parse(amounttb.Text);
                date = datepicker.Value;
                description = descriptiontb.Text;
                Transaction t = new Transaction
                {
                    CategoryId = categoryid,
                    CategoryName = categoryname,
                    Amount = amount,
                    Date = date,
                    Description = description,
                    WalletId = walletid
                };
                bool res = TransactionEditor.CreateTransaction(t);
                if (res == true)
                {
                    lresult.Text = "Transaction Created ✔";

                    lresult.ForeColor = Color.Chartreuse;
                }
                else
                {
                    lresult.Text = "Transaction Failed ✘";
                    lresult.ForeColor = Color.Red;
                }
                ErrorProvider.SetError(amounttb, "");
            }
        }

        private void OnClearBtClick(object sender, EventArgs e)
        {
            ClearData();
        }

        //Select Button Events

        private void OnCategoryBtSelect(object sender, EventArgs e)
        {
            if (walletbt.Text == "Select Wallet                          ➤")
            {
                ErrorProvider.SetError(categoryselectbt, "Choose Wallet");
            }
            else
            {
                ErrorProvider.SetError(categoryselectbt, "");
                categoryview.Visible = true;
                categoryview.WalletChange = new Wallet { WalletID = walletid };
                padd.Visible = false;
                categoryview.CategorySelect += OnCategorySelect;
                categoryview.CategoryClose += OnCategoryClose;
            }
        }

        private void OnCategoryClose(object sender, EventArgs e)
        {
            categoryview.Visible = false;
            padd.Visible = true;
        }

        private void OnCategorySelect(object sender, Category e)
        {
            categoryid = e.ID;
            categoryname = e.CategoryName;
            categoryview.Visible = false;
            padd.Visible = true;
            categoryselectbt.Text = categoryname;
            categoryselectbt.BackColor = Color.White;
            ErrorProvider.SetError(categoryselectbt, "");
        }

        private void OnWalletBtClick(object sender, EventArgs e)
        {
            wallet.Visible = true;
            padd.Visible = false;
            wallet.WalletClick += OnWalletClick;
            wallet.WalletClose += OnWalletClose;
        }

        private void OnWalletClose(object sender, EventArgs e)
        {
            wallet.Visible = false;
            padd.Visible = true;
        }

        private void OnWalletClick(object sender, Wallet e)
        {
            walletid = e.WalletID;
            walletname = e.WalletName;
            wallet.Visible = false;
            padd.Visible = true;
            walletbt.Text = walletname;
            ErrorProvider.SetError(categoryselectbt, "");
            categoryselectbt.Text = "Select Category                     ➤";
            categoryselectbt.BackColor = Color.Gainsboro;
            walletbt.BackColor = Color.White;
            ErrorProvider.SetError(walletbt, "");
        }

        //KeyPress Events

        private void OnAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider.SetError(amounttb, "");
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //Validate Functions

        public void ClearData()
        {
            lresult.Text = "";
            amounttb.Text = "";
            descriptiontb.Text = "";
            ErrorProvider.SetError(amounttb, "");
            datepicker.Text = DateTime.Now.ToString();
            categoryselectbt.Text = "Select Category                     ➤";
            walletbt.Text= "Select Wallet                          ➤";
            categoryselectbt.BackColor = walletbt.BackColor = Color.Gainsboro;
        }

        public bool CheckAmount()
        {
            if (amounttb.TextLength > 0)
            {
                ErrorProvider.SetError(amounttb, "");
                return true;
            }
            ErrorProvider.SetError(amounttb, "Amount is required");
            return false;
        }

        public bool CheckCategory()
        {
            if (categoryselectbt.Text== "Select Category                     ➤")
            {
                ErrorProvider.SetError(categoryselectbt, "Choose Category");
                return false;
            }
            ErrorProvider.SetError(categoryselectbt, "");
            return true;
        }

        public bool CheckWallet()
        {
            if (walletbt.Text == "Select Wallet                          ➤")
            {
                ErrorProvider.SetError(walletbt, "Choose Wallet");
                return false;
            }
            ErrorProvider.SetError(walletbt, "");
            return true;
        }

        public bool CheckBudget()
        {
            string budgetamount = Communicator.Manager.FetchAmount(categoryid, datepicker.Value,walletid);
            if(budgetamount=="Not Found")
            {
                return true;
            }
            if (float.Parse(amounttb.Text) > float.Parse(budgetamount))
            {
                padd.Enabled = false;
                Notification n = new Notification
                {
                    Category_Name=categoryname,
                    borderColor = GUIStyles.secondaryColor,
                    outcolor= GUIStyles.secondaryColor
                };
                n.ShowDialog();
                padd.Enabled = true;
                if (n.yes == true)
                {
                    return true;
                }
                return false;
            }
            return true;
        }                   

        //public bool CheckDescription()
        //{
        //    if (descriptiontb.TextLength > 0)
        //    {
        //        ErrorProvider.SetError(descriptiontb, "");
        //        return true;
        //    }
        //    ErrorProvider.SetError(descriptiontb, "Enter Description");
        //    return false;
        //}
    }
}
