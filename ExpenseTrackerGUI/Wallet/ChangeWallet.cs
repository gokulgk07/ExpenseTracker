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
    public partial class ChangeWallet : UserControl
    {
        public ChangeWallet()
        {
            InitializeComponent();
        }
        public delegate void WalletEventHandler(Image image, Wallet e);
        public event WalletEventHandler WalletClick;

        public event EventHandler WalletClose;

        private bool totalShow = true, showBorder=true;

        #region Properties 

        public string Title
        {
            get => lblTitle.Text;
            set
            {
                if (value == null || value=="") return;
                lblTitle.Text = value;
            }
        }

        public bool EditMode
        {
            get => selectWallet1.EditMode;
            set
            {
                selectWallet1.EditMode = value;
                if (value)
                {
                    Title = "My Wallets";
                    pbBack.Hide();
                    lblTitle.Location = new Point(11, 6);
                }
                else
                {
                    Title = "Select Wallet";
                    pbBack.Show();
                    lblTitle.Location = new Point(50, 6);
                }
            }
        }

        public bool AddMode
        {
            get => selectWallet1.AddMode;
            set
            {
                selectWallet1.AddMode = value;
            }
        }

        public bool ShowBorder
        {
            get => showBorder;
            set
            {
                showBorder = value;
                if (value)
                {
                    panel1.Height = 50;
                    panel2.Width = panel3.Width = panel4.Height = 12;
                }
                else
                {
                    panel1.Height = panel2.Width = panel3.Width = panel4.Height = 1;
                }
            }
        }

        public bool TotalShow
        {
            get => totalShow;
            set
            {
                totalShow = value;
                if (value)
                {
                    tpnlTotal.Show();
                    tpnlTotal.Height = 100;
                }
                else
                {
                    tpnlTotal.Hide();
                    tpnlTotal.Height = 0;
                }
            }
        }

        #endregion

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ChangeTotalWallet();
        }

        private void OnVisibilityChanged(object sender, EventArgs e)
        {
            ChangeTotalWallet();
        }

        #endregion

        #region Total Wallet 

        private void OnTotalClicked(object sender, EventArgs e)
        {
            WalletClick?.Invoke(Image.FromFile(".\\ResourceImages\\globe.png"), Communicator.Manager.FetchWallet(1));
            //WalletClick?.Invoke(Image.FromFile(".\\ResourceImages\\globe.png"), new Wallet() { WalletID = 0, WalletName = "Total", Amount = ChangeTotalWallet() });
        }

        private int ChangeTotalWallet()
        {
            int amount = 0;
            foreach (int num in ExpenseTracker.Communicator.Manager.FetchWallet().Select(i => i.Amount).ToList()) amount += num;
            totalWallet.CardBalance = amount.ToString();
            return amount;
        }

        #endregion

        #region Wallet Change

        private void OnWalletSelected(object sender, ExpenseTrackerDS.Wallet e)
        {
            ChangeTotalWallet();
            WalletClick?.Invoke(Image.FromFile(".\\ResourceImages\\Wallets.png"), e);
        }

        private void OnBackBtnClicked(object sender, EventArgs e)
        {
            WalletClose?.Invoke(this, EventArgs.Empty);
        }

        #endregion
        
    }
}
