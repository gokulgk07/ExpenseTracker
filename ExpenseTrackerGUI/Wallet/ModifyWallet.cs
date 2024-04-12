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

namespace ExpenseTrackerGUI
{
    public partial class ModifyWallet : UserControl
    {
        public ModifyWallet()
        {
            InitializeComponent();

            wallet = new Wallet();
            temp = new Wallet();
        }
        
        public delegate void WalletChangeHander(WalletMode mode, Wallet e);

        public event EventHandler WalletClose;
        public event WalletChangeHander WalletChange;

        private Wallet wallet, temp;
        private WalletMode walletMode = WalletMode.AddMode;
        private bool nameCheck = false, balanceCheck = false;

        #region Properties

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public enum WalletMode
        {
            AddMode,
            EditMode,
            DeleteMode
        };

        #endregion

        #region GetData

        public void GetData(Wallet e, WalletMode mode)
        {
            if (e == null) return;
            
            temp = wallet = e;
            walletMode = mode;
            
            if (mode == WalletMode.AddMode)
            {
                Title = "Add Category";
                this.Size = new Size(400, 340);
                btnSave.Enabled = false;
                btnSave.ButtonColor = Color.WhiteSmoke;
                btnSave.Show();

                nameCheck = balanceCheck = false;
            }
            else if (mode == WalletMode.EditMode)
            {
                Title = "Edit Category";
                this.Size = new Size(400, 400);

                tbWalletName.Text = e.WalletName;
                tbBalance.Text = e.Amount.ToString();

                nameCheck = balanceCheck = true;

                btnSave.Enabled = true;
                btnSave.ButtonColor = GUIStyles.primaryColor;
                btnSave.ButtonForeColor = Color.White;
            }
            lblExist.Hide();

        }

        #endregion

        #region KeyPress

        private void OnTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                if (tbWalletName.Text == "" || (tbWalletName.Text.Length == 1 && e.KeyChar == 8))
                {
                    tbWalletName.Text = "Wallet Name";
                    tbWalletName.ForeColor = Color.Gray;
                    nameCheck = false;
                }
                else if (tbWalletName.Text == "Wallet Name" && e.KeyChar != 8)
                {
                    tbWalletName.Text = "";
                    tbWalletName.ForeColor = Color.Black;
                    nameCheck = true;
                }
                else if (tbWalletName.Text == "Wallet Name" && e.KeyChar == 8)
                {
                    e.Handled = true;
                }
                else tbWalletName.ForeColor = Color.Black;
            }
            else e.Handled = true;
            CheckTextBox();
        }

        private void OnBalanceKeyPressed(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
            {
                if (tbBalance.Text == "" || (tbBalance.Text.Length == 1 && e.KeyChar == 8))
                {
                    tbBalance.Text = "Enter your current balance";
                    tbBalance.ForeColor = Color.Gray;
                    balanceCheck = false;
                }
                else if (tbBalance.Text == "Enter your current balance" && e.KeyChar != 8)
                {
                    tbBalance.Text = "";
                    tbBalance.ForeColor = Color.Black;
                    balanceCheck = true;
                }
                else if (tbBalance.Text == "Enter your current balance" && e.KeyChar == 8)
                {
                    e.Handled = true;
                }
                else tbBalance.ForeColor = Color.Black;
            }
            else e.Handled = true;
            CheckTextBox();
        }

        private void CheckTextBox()
        {
            if (nameCheck == true && balanceCheck == true)
            {
                btnSave.Enabled = true;
                btnSave.ButtonColor = GUIStyles.primaryColor;
                btnSave.ButtonForeColor = Color.White;
            }
            else
            {
                btnSave.Enabled = false;
                btnSave.ButtonColor = Color.WhiteSmoke;
                btnSave.ButtonForeColor = Color.Black;
            }
        }

        #endregion

        #region Cancel Click

        private void OnCancelClickTriggered(object sender, EventArgs e)
        {
            WalletClose?.Invoke(this, EventArgs.Empty);
            Rebuild();
        }

        #endregion

        #region Delete Wallet

        private void OnDeleteClickTriggered(object sender, EventArgs e)
        {
            pnlTop.Height = pnlBottom.Height = pnlLeft.Width = pnlRight.Width = 10;
            this.Size = new Size(400, 280);

            //if (wallet.WalletID == 1)
            //{
            //    lblDeleteTitle.Text = "";
            //    lblMsg.Text = $"As {wallet.WalletName} wallet was default wallet, you cannot delete this wallet.";

            //    btnCancel.ButtonText = "Close";
            //    btnCancel.Show();
            //    btnDelete.Hide();
            //}
            //else
            //{
            //    lblDeleteTitle.Text = $"Do you want to delete {wallet.WalletName} wallet?";
            //    lblMsg.Text = "You will also delete all of its transaction, budgets, events, bills and this action cannot be undone.";

            //    btnCancel.ButtonText = "Cancel";
            //    btnCancel.Show();
            //    btnDelete.Show();
            //}

            lblDeleteTitle.Text = $"Do you want to delete {wallet.WalletName} wallet?";
            lblMsg.Text = "You will also delete all of its transaction, budgets, events, bills and this action cannot be undone.";

            btnCancel.ButtonText = "Cancel";
            btnCancel.Show();
            btnDelete.Show();

            tcWallet.SelectedTab = tabPage2;
        }

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            ChangeDeleteUI();
        }

        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            Communicator.Manager.RemoveData(wallet);
            WalletChange?.Invoke(WalletMode.DeleteMode, wallet);
            ChangeDeleteUI();
            Rebuild();
        }

        #endregion

        #region Save Click

        private void OnSaveBtnClickTriggered(object sender, EventArgs e)
        {
            wallet.WalletName = tbWalletName.Text;
            wallet.Amount = float.Parse(tbBalance.Text);
            
            if(walletMode== WalletMode.AddMode)
            {
                Communicator.Manager.AddData(wallet);
                WalletChange?.Invoke(WalletMode.AddMode, wallet);
            }
            else if(walletMode== WalletMode.EditMode)
            {
                Communicator.Manager.EditData(wallet);
                WalletChange?.Invoke(WalletMode.EditMode, wallet);
            }
            
            Rebuild();
        }

        #endregion

        #region UI Rebuid

        private void Rebuild()
        {
            tbWalletName.Text = "Wallet Name";
            tbBalance.Text = "Enter your current balance";

            tbWalletName.ForeColor = tbBalance.ForeColor = Color.Gray;

            tcWallet.SelectedTab = tabPage1;
        }

        private void ChangeDeleteUI()
        {
            pnlTop.Height = 40;
            this.Size = new Size(400, 400);
            tcWallet.SelectedTab = tabPage1;
        }

        #endregion

    }
}
