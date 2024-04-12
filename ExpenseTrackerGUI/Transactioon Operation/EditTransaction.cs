using ExpenseTracker;
using ExpenseTrackerDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    public partial class EditTransaction : Form
    {
        public EditTransaction()
        {
            InitializeComponent();
            LoadTransaction();
        }

        //Paint Operation

        private void OnPdesignPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.GhostWhite, Color.GhostWhite, pdesign.Width, pdesign.Height, 0, 30);
        }

        private void OnPbottomPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.DarkBlue, Color.White, pbottom.Width, pbottom.Height, 25, 30);
        }

        // Object Creation

        Calculator calc = new Calculator();
        CategoryView categoryview = new CategoryView();
        ChangeWallet wallet = new ChangeWallet();

        // Edit Property
        Transaction editdata;

        public Transaction EditData
        {
            get => editdata;
            set
            {
                editdata = value;
                ChangeData();
                categorybt.Text = editdata.CategoryName;
                amountbt.Text = editdata.Amount.ToString();
                datepicker.Text = editdata.Date.ToLongDateString();
                descriptiontb.Text = editdata.Description;
                walletbt.Text=(Communicator.Manager.FetchWallet(editdata.WalletId)).WalletName;
                CalculateDate();
            }
        }

        public bool done = false;
        DateTime startdate = DateTime.Now, enddate = DateTime.Now,newdate=DateTime.Now;

        // Load  and Resize EditTransaction

        private void LoadTransaction()
        {
            this.BackColor = Color.DarkBlue;
            pdesign.Location = new Point(pbottom.Width / 2 - pdesign.Width / 2, (pbottom.Height - pdown.Height) / 2 - pdesign.Height / 2);
            pback.Location = new Point(pdesign.Width / 2 - pback.Width / 2, pdesign.Height / 2 - pback.Height / 2);
            pcalculator.Size = new Size(272, 261);
            pcalculator.Location = new Point(pdesign.Location.X-1, pback.Location.Y);
        }

        private void OnEditTransactionLoad(object sender, EventArgs e)
        {
            ActiveControl = donebt;
            calc.Dock = DockStyle.Fill;
            pcalculator.Controls.Add(calc);
            categoryview.Dock = DockStyle.Fill;
            pbackground.Controls.Add(categoryview);
            categoryview.Visible = false;
            //wallet.Dock = DockStyle.Fill;
            //pbackground.Controls.Add(wallet);
            //wallet.Visible = false;
        }

        private void OnEditTransactionResize(object sender, EventArgs e)
        {
            LoadTransaction();
        }

        // Button Click Events

        private void OnCategoryBtClick(object sender, EventArgs e)
        {
            pbottom.Visible = false;
            categoryview.WalletChange = new Wallet() { WalletID = editdata.WalletId };
            categoryview.Visible = true;
            categoryview.CategorySelect += Categoryview_CategorySelect;
            categoryview.CategoryClose += Categoryview_CategoryClose;
        }

        private void Categoryview_CategoryClose(object sender, EventArgs e)
        {
            pbottom.Visible = true;
            categoryview.Visible = false;
        }

        private void Categoryview_CategorySelect(object sender, Category e)
        {
            Category c = new Category();
            c = e;
            editdata.CategoryId = c.ID;
            editdata.CategoryName = c.CategoryName;
            categorybt.Text = editdata.CategoryName;
            ChangeData();
            pbottom.Visible = true;
            categoryview.Visible = false;
        }

        private void OnWalletBtClick(object sender, EventArgs e)
        {
            pbottom.Visible = false;
            wallet.Visible = true;
            wallet.WalletClick += OnWalletClick;
        }

        private void OnWalletClick(object sender, Wallet e)
        {
            Wallet w = new Wallet();
            w = e;
            editdata.WalletId = w.WalletID;
            walletbt.Text = w.WalletName;
            pbottom.Visible = true;
            wallet.Visible = false;
        }

        private void OnDoneBtClick(object sender, EventArgs e)
        {
            if (CheckAmount()==true && amountbt.Text.Length > 0 && pback.Visible == true)
            {
                done = true;
                editdata.Amount = float.Parse(amountbt.Text);
                editdata.Description = descriptiontb.Text;
                editdata.Date = datepicker.Value;
                EditTransactionData();
                this.Close();
            }
            if (amountbt.Text.Length <= 0)
            {
                ErrorProvider.SetError(pback, "Enter Amount");
                ErrorProvider.SetIconAlignment(pback, ErrorIconAlignment.TopRight);
            }
        }

        private bool CheckAmount()
        {
            string budgetamount = Communicator.Manager.FetchAmount(editdata.CategoryId, datepicker.Value, editdata.WalletId);
            if (budgetamount == "Not Found")
            {
                return true;
            }
            if (float.Parse(amountbt.Text) > float.Parse(budgetamount))
            {
                Notification n = new Notification
                {
                    Category_Name = editdata.CategoryName,
                    borderColor = GUIStyles.secondaryColor,
                    outcolor = GUIStyles.secondaryColor
                };
                n.ShowDialog();
                if (n.yes == true)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        private void OnCancelBtClick(object sender, EventArgs e)
        {
            done = false;
            this.Close();
        }

        private void OnAmountBtClick(object sender, EventArgs e)
        {
            pback.Enabled = false; pbutton.Enabled = false;
            calc.Answer = float.Parse(amountbt.Text);
            pcalculator.BringToFront();
            pcalculator.Visible = true;
            calc.CalculatorClosed += OnCalculatorClosed;
        }

        private void OnCalculatorClosed(object sender, bool closed)
        {
            amountbt.Text = calc.Answer.ToString();
            pcalculator.Visible = false;
            pback.Enabled = true; pbutton.Enabled = true;
        }

        //Button Enter Events

        private void OnAmountMouseEnter(object sender, EventArgs e)
        {
            amountbt.BackColor = rupeelb.BackColor = Color.Gainsboro;
        }

        private void OnAmountMouseLeave(object sender, EventArgs e)
        {
            amountbt.BackColor = rupeelb.BackColor = Color.White;
        }

        private void OnCategoryMouseEnter(object sender, EventArgs e)
        {
            categorybt.BackColor = categoryimg.BackColor = Color.Gainsboro;
        }

        private void OnCategoryMouseLeave(object sender, EventArgs e)
        {
            categorybt.BackColor = categoryimg.BackColor = Color.White;
        }

        //EditTransaction Function

        private void EditTransactionData()
        {
            newdate = editdata.Date;
            if (CheckDateTime())
            {
                bool result = TransactionEditor.EditTransaction(editdata);
            }
        }

        private void CalculateDate()
        {
            startdate = DateTime.Parse("01/" + editdata.Date.ToString("MM/yyyy"));
            enddate = editdata.Date.AddMonths(1);
            enddate = DateTime.Parse("01/" + enddate.ToString("MM/yyyy"));
            enddate = enddate.AddDays(-1);
        }

        private bool CheckDateTime()
        {
            if (newdate >= startdate && newdate <= enddate)
            {
                return true;
            }
            bool iscreated = CreateTransaction();
            if (iscreated == true)
            {
                DeleteTransaction();
            }
            return false;
        }

        private void DeleteTransaction()
        {
            bool result = TransactionEditor.DeleteTransaction(editdata);
        }

        private bool CreateTransaction()
        {
            bool result = TransactionEditor.CreateTransaction(editdata);
            if (result == true)
            {
                return true;
            }
            return false;
        }

        private void ChangeData()
        {
            categoryimg.BackgroundImage = new Bitmap((Communicator.Manager.FetchCategoryName(editdata.CategoryId)).ImagePath);
            if ((Communicator.Manager.FetchCategoryName(editdata.CategoryId)).Type == true)
            {
                amountbt.ForeColor = rupeelb.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                amountbt.ForeColor = rupeelb.ForeColor = Color.Red;
            }
        }
    }
}
