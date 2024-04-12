using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    public partial class CategorySearchBar : UserControl
    {
        public CategorySearchBar()
        {
            InitializeComponent();
            OnBackClicked(this, EventArgs.Empty);
        }

        public event EventHandler SearchBackClick;
        public event EventHandler SearchBarClick;
        public event EventHandler<string> TextChange;

        private bool searchBarShow = false;

        public bool SearchBarShow
        {
            get => searchBarShow;
            set
            {
                searchBarShow = value;
                if (!searchBarShow)
                {
                    SearchBackClick?.Invoke(this, EventArgs.Empty);
                    tblBack.Visible = false;
                    pbBack.Visible = false;
                    tbText.Visible = false;
                    tbText.Text = "";
                }
                else
                {
                    SearchBarClick?.Invoke(this, EventArgs.Empty);
                    tblBack.Visible = true;
                    pbBack.Visible = true;
                    tbText.Visible = true;
                    tbText.Cursor = Cursors.IBeam;
                }
            }
        }

        private void OnSearchBarClicked(object sender, EventArgs e)
        {
            SearchBarShow = true;
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            SearchBarShow = false;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            TextChange?.Invoke(this, tbText.Text);
        }

    }
}
