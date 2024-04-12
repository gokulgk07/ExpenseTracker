using ExpenseTrackerDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    public partial class DeleteCategoryForm : Form
    {
        public DeleteCategoryForm()
        {
            InitializeComponent();
        }

        public event EventHandler<DeleteResult> DeleteCategoryChange;
        
        private void OnCloseBtnClicked(object sender, EventArgs e)
        {
            DeleteCategoryChange?.Invoke(this, DeleteResult.Cancel);
        }
        
        private void OnButtonClicked(object sender, EventArgs e)
        {
            CurveButton button = (CurveButton)sender;
            if (button.ButtonText == "Delete")
            {
                DeleteCategoryChange?.Invoke(this, DeleteResult.Delete);
            }
            else if (button.ButtonText == "Merge")
            {
                DeleteCategoryChange?.Invoke(this, DeleteResult.Merge);
            }
        }

        public void ChangeDeleteUI(bool hasTransaction, bool hasChild, int cnt, Category e)
        {
            if(hasTransaction==true && hasChild == true)
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = true;
                if (cnt == 1)
                {
                    lblText.Text = $"There is 1 transaction in the {e.CategoryName} category and childern categories.";
                }
                else
                {
                    lblText.Text = $"There are {cnt} transaction in the {e.CategoryName} category and childern categories.";
                }
                this.Size = new Size(400, 315);
                btnDelete1.Hide();
            }
            else if(hasTransaction == true && hasChild == false)
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = true;
                if (cnt == 1)
                {
                    lblText.Text = $"There is 1 transaction in the {e.CategoryName} category.";
                }
                else
                {
                    lblText.Text = $"There are {cnt} transaction in the {e.CategoryName} category.";
                }
                this.Size = new Size(400, 315);
                btnDelete1.Hide();
            }
            else if(hasTransaction == false && hasChild == true)
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = false;
                this.Size = new Size(400, 235);
                btnDelete1.Show();
                lblText.Text = $"Are you sure you want to delete {e.CategoryName} category and children?";
            }
            else
            {
                lblMergeTitle.Visible = lblDeleteTitle.Visible = lblMergeDescription.Visible = lblDeleteDescription.Visible = false;
                this.Size = new Size(400, 235);
                btnDelete1.Show();
                lblText.Text = $"Are you sure you want to delete {e.CategoryName} category?";
            }
        }

        public enum DeleteResult
        {
            Cancel,
            Merge,
            Delete
        };
    }
}
