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
    public partial class NameTransaction : UserControl
    {
        public NameTransaction()
        {
            InitializeComponent();
        } //Event Creation

        public delegate void ControlDisable(object sender, bool disabled);
        public event ControlDisable ControlDisabled;
        public delegate void ControlChange(object sender, bool changed);
        public event ControlChange ControlChanged;

        //Property Creation

        Transaction editdata;
        Color backcolor;

        public Color Backcolor
        {
            get => backcolor;
            set
            {
                backcolor = value;
                imglb.BackColor = categorynamelb.BackColor = rupeelb.BackColor = amountlb.BackColor = Editlb.BackColor = Deletelb.BackColor = editbt.BackColor = deletebt.BackColor = pback.BackColor = backcolor;
            }
        }

        public Transaction EditData
        {
            get => editdata;
            set
            {
                editdata = value;
                categorynamelb.Text = editdata.CategoryName;
                amountlb.Text = editdata.Amount.ToString();
                if ((Communicator.Manager.FetchCategoryName(editdata.CategoryId)).Type == true)
                {
                    amountlb.ForeColor = Color.FromArgb(0, 192, 0);
                }
                else
                {
                    amountlb.ForeColor = Color.Red;
                }
                imglb.BackgroundImage = new Bitmap((Communicator.Manager.FetchCategoryName(EditData.CategoryId)).ImagePath);
            }
        }

        //Button Click Events

        private void OnEditBtClick(object sender, EventArgs e)
        {
            ControlDisabled?.Invoke(this, true);
            EditTransaction et = new EditTransaction
            {
                EditData = editdata,
            };
            et.ShowDialog();
            if (et.done == true)
            {
                ControlChanged?.Invoke(this, true);
            }
            ControlDisabled?.Invoke(this, false);
        }

        private void OnDeleteBtClick(object sender, EventArgs e)
        {
            ControlDisabled?.Invoke(this, true);
            Notification dv = new Notification();
            dv.ShowDialog();
            if (dv.yes == true)
            {
                DeleteTransaction();
            }
            ControlDisabled?.Invoke(this, false);
        }

        private void DeleteTransaction()
        {
            Transaction transaction = editdata;
            bool result = TransactionEditor.DeleteTransaction(transaction);
            if (result == true)
            {
                ControlChanged?.Invoke(this, true);
            }
        }

        //Mouse Enter Events
        
        private void OnEditBtMouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent();
            editbt.BackgroundImage = Image.FromFile(@".\Images\Edit1.png");
        }

        private void OnEditBtMouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent();
            editbt.BackgroundImage = Image.FromFile(@".\Images\Edit2.png");
        }

        private void OnDeleteBtMouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent();
            deletebt.BackgroundImage = Image.FromFile(@".\Images\Trash1.png");
        }

        private void OnDeleteBtMouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent();
            deletebt.BackgroundImage = Image.FromFile(@".\Images\Trash12.png");
        }

        private void OnNameTransactionMouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent();
        }

        private void OnNameTransactionMouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent();
        }

        private void MouseEnterEvent()
        {
            Color bgcolor = GUIStyles.terenaryColor;
            imglb.BackColor = categorynamelb.BackColor = rupeelb.BackColor = amountlb.BackColor = Editlb.BackColor = Deletelb.BackColor = editbt.BackColor = deletebt.BackColor = pback.BackColor = bgcolor;
        }

        private void MouseLeaveEvent()
        {
            imglb.BackColor = categorynamelb.BackColor = rupeelb.BackColor = amountlb.BackColor = Editlb.BackColor = Deletelb.BackColor = editbt.BackColor = deletebt.BackColor = pback.BackColor = backcolor;
        }
    }
}
