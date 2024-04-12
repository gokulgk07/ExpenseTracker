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

namespace ExpenseTrackerGUI
{
    public partial class MainCategoryView : UserControl
    {
        public MainCategoryView()
        {
            InitializeComponent();

            categoryView = new CategoryView();
            this.tabPage1.Controls.Add(categoryView);
            categoryView.Dock = DockStyle.Fill;
            categoryView.EditMode = true;
            categoryView.BorderWidth = 1;

            changeWallet = new ChangeWallet();
            this.tabPage2.Controls.Add(changeWallet);
            changeWallet.Dock = DockStyle.Fill;
            
            changeWallet.AddMode = true;
            changeWallet.EditMode = false;
            changeWallet.TotalShow = true;
            changeWallet.ShowBorder = false;

            changeWallet.WalletClick += OnWalletClicked;
            changeWallet.WalletClose += OnWalletClosed;

            tcCategory.SelectedTab = tabPage1;
        }

        private CategoryView categoryView;
        private ChangeWallet changeWallet;

        private void OnWalletClosed(object sender, EventArgs e)
        {
            lblTitle.Text = "My Categories";
            mainCategoryViewSearch.Show();

            tcCategory.SelectedTab = tabPage1;
        }

        private void OnWalletClicked(Image image, Wallet e)
        {
            lblTitle.Text = "My Categories";
            mainCategoryViewSearch.Show();

            lblWalletName.Text = e.WalletName;
            categoryView.Wallet = e;
            tcCategory.SelectedTab = tabPage1;

            pbWalletIamge.Image = image;
        }
        
        private void OnSearchBackClicked(object sender, EventArgs e)
        {
            mainCategoryViewSearch.Width = 90;
        }

        private void OnSearchBarClicked(object sender, EventArgs e)
        {
            mainCategoryViewSearch.Width = this.Width;
        }

        private void OnSearchBarTextChanged(object sender, string e)
        {
            categoryView.SearchText = e;
        }

        private void OnSearchBarChanged(object sender, EventArgs e)
        {
            mainCategoryViewSearch.SearchBarShow = false;
        }

        private void OnWalletChangeClicked(object sender, EventArgs e)
        {
            lblTitle.Text = "Select Wallet";
            mainCategoryViewSearch.Hide();
            tcCategory.SelectedTab = tabPage2;
        }
    }
}
