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
    public partial class SelectWallet : UserControl
    {
        public SelectWallet()
        {
            InitializeComponent();

            modifyWallet = new ModifyWallet();
            modifyWallet.WalletChange += OnWalletChanged;
            modifyWallet.WalletClose += OnWalletClosed;
            modifyWallet.Hide();
            this.Controls.Add(modifyWallet);

            GetWallets();
        }
        
        public event EventHandler<Wallet> WalletSelect;

        private bool editMode = false, addMode=true;
        private List<WalletCard> walletCards = new List<WalletCard>();
        private ModifyWallet modifyWallet;

        #region Properties

        public int Radius { get; set; } = 10;

        public bool AddMode
        {
            get => addMode;
            set
            {
                addMode = value;
                if (addMode)
                {
                    pnlAddWallet.Show();
                    tableLayoutPanel1.RowStyles[1] = new RowStyle(SizeType.Absolute, 50);
                    tableLayoutPanel1.RowStyles[2] = new RowStyle(SizeType.Absolute, 20);
                }
                else
                {
                    pnlAddWallet.Hide();
                    tableLayoutPanel1.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
                    tableLayoutPanel1.RowStyles[2] = new RowStyle(SizeType.Absolute, 0);
                }
            }
        }

        public bool EditMode
        {
            get => editMode;
            set => editMode = value;
        }

        #endregion
        
        #region AddWallet

        private void OnAddWalletClickTriggered(object sender, EventArgs e)
        {
            if (!modifyWallet.Visible)
            {
                modifyWallet.GetData(new Wallet(), ModifyWallet.WalletMode.AddMode);
                modifyWallet.Location = new Point(((Width / 2) - (modifyWallet.Width / 2)), ((Height / 2) - (modifyWallet.Height / 2)));
                modifyWallet.Show();
                modifyWallet.BringToFront();
            }
        }

        #endregion

        #region Wallet Change

        private void OnWalletClosed(object sender, EventArgs e)
        {
            modifyWallet.Hide();
        }

        private void OnWalletChanged(ModifyWallet.WalletMode mode, Wallet e)
        {
            if(mode== ModifyWallet.WalletMode.AddMode)
            {
                GetWallets();
            }
            else if(mode== ModifyWallet.WalletMode.EditMode)
            {
                WalletCard card = walletCards.Find(i => int.Parse(i.Name) == e.WalletID);
                card.CardName = e.WalletName;
                card.CardBalance = e.Amount.ToString();
            }
            else if(mode == ModifyWallet.WalletMode.DeleteMode)
            {
                WalletCard card = walletCards.Find(i => int.Parse(i.Name) == e.WalletID);
                card.Click -= OnCardClicked;
                walletCards.Remove(card);
                pnlShow.Controls.Remove(card);

                card.Dispose();

                ArrangeCards();
            }
            modifyWallet.Hide();


            //this.Hide();
            //
            //GetWallets();
            //this.Show();
        }

        #endregion

        #region GetWallets & Arrange Wallets

        private void GetWallets()
        {
            foreach (var v in walletCards) v.Dispose();
            walletCards.Clear();
            pnlShow.Controls.Clear();
            foreach (Wallet wallet in Communicator.Manager.FetchWallet())
            {
                if (wallet.WalletID == 1) continue;
                WalletCard card = new WalletCard();
                walletCards.Add(card);
                pnlShow.Controls.Add(card);
                card.IsWallet = true;
                card.Name = wallet.WalletID.ToString();
                card.CardName = wallet.WalletName;
                card.CardBalance = wallet.Amount.ToString();

                card.Click += OnCardClicked;
            }
            ArrangeCards();
        }

        private void ArrangeCards()
        {
            int xPos = 0, yPos = 20, walletSpace = 20;
            pnlShow.VerticalScroll.Value = 0;
            foreach (WalletCard card in walletCards)
            {
                card.Location = new Point(xPos, yPos);
                yPos += (card.Height + walletSpace);
                card.Width = this.Width - 50;
            }
        }

        #endregion

        #region Card Click

        private void OnCardClicked(object sender, EventArgs e)
        {
            if(sender is WalletCard card)
            {
                Wallet wallet = Communicator.Manager.FetchWallet(int.Parse(card.Name));
                if (EditMode)
                {
                    modifyWallet.GetData(wallet, ModifyWallet.WalletMode.EditMode);
                    modifyWallet.Location = new Point(((Width / 2) - (modifyWallet.Width / 2)), ((Height / 2) - (modifyWallet.Height / 2)));
                    modifyWallet.Show();
                    modifyWallet.BringToFront();
                }
                else
                {
                    WalletSelect?.Invoke(this, wallet);
                }
            }
        }

        #endregion

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GetWallets();
        }

        private void OnVisibilityChanged(object sender, EventArgs e)
        {
            GetWallets();
        }

        private void OnMouseEntered(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        
        private void OnMouseLeaved(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        #endregion
    }
}
