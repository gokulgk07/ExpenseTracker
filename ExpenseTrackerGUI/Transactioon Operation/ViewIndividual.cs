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
    public partial class ViewIndividual : UserControl
    {
        public ViewIndividual()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        //Paint Events

        Color borderColor = GUIStyles.primaryColor;
        Color backcolor = Color.White;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DoubleBuffered = true;
            TransactionEditor.PaintOperation(this, e, borderColor, backcolor, this.Width, this.Height, 7, 30);
        }

        private void OnViewIndividualMouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent();
        }

        private void OnViewIndividualMouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent();
        }

        private void MouseEnterEvent()
        {
            backcolor = GUIStyles.terenaryColor;
            categoryicon.BackColor = GUIStyles.terenaryColor;
            Categorynamelb.BackColor= GUIStyles.terenaryColor;
            rupeelb.BackColor= GUIStyles.terenaryColor; 
            Amountlb.BackColor= GUIStyles.terenaryColor; 
            editlb.BackColor= GUIStyles.terenaryColor;
            Editbt.BackColor = GUIStyles.terenaryColor;
            deletelb.BackColor= GUIStyles.terenaryColor;
            Deletebt.BackColor = GUIStyles.terenaryColor;
            datelb.BackColor= GUIStyles.terenaryColor;
            Descriptionlb.BackColor= GUIStyles.terenaryColor;
            Invalidate();
        }

        private void MouseLeaveEvent()
        {
            backcolor = Color.White;
            categoryicon.BackColor = Color.White;
            Categorynamelb.BackColor = Color.White;
            rupeelb.BackColor = Color.White;
            Amountlb.BackColor = Color.White;
            editlb.BackColor = Color.White;
            Editbt.BackColor = Color.White;
            deletelb.BackColor = Color.White;
            Deletebt.BackColor = Color.White;
            datelb.BackColor = Color.White;
            Descriptionlb.BackColor = Color.White;
            Invalidate();
        }

        //Mouse Enter Events

        private void OnEditBtMouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent();
            Editbt.BackgroundImage = Image.FromFile(@".\Images\Edit1.png"); 
        }

        private void OnEditBtMouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent();
            Editbt.BackgroundImage = Image.FromFile(@".\Images\Edit2.png"); 
        }

        private void OnDeleteBtMouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent();
            Deletebt.BackgroundImage = Image.FromFile(@".\Images\Trash1.png"); 
        }

        private void OnDeleteBtMouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent();
            Deletebt.BackgroundImage = Image.FromFile(@".\Images\Trash12.png"); 
        }


        //Event Creation

        public delegate void ControlDisable(object sender, bool disabled);
        public event ControlDisable ControlDisabled;
        public delegate void ControlChange(object sender, bool changed);
        public event ControlChange ControlChanged;

        // View Transaction Properties

        Transaction viewdata;

        public Transaction ViewData
        {
            get => viewdata;
            set
            {
                viewdata = value;
                Categorynamelb.Text = viewdata.CategoryName;
                Amountlb.Text = viewdata.Amount.ToString();
                datelb.Text = viewdata.Date.ToLongDateString();
                Descriptionlb.Text = viewdata.Description;
                if ((Communicator.Manager.FetchCategoryName(viewdata.CategoryId)).Type == true)
                    Amountlb.ForeColor = Color.FromArgb(0, 192, 0);
                else
                    Amountlb.ForeColor = Color.Red;
                categoryicon.BackgroundImage = new Bitmap((Communicator.Manager.FetchCategoryName(viewdata.CategoryId)).ImagePath);
            }
        }    

        //button Click Functions   

        private void OnEditBtClick(object sender, EventArgs e)
        {
            ControlDisabled?.Invoke(this, true);
            EditTransaction et = new EditTransaction
            {
                EditData=viewdata,
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

        // Delete Function

        private void DeleteTransaction()
        {
            bool result = TransactionEditor.DeleteTransaction(viewdata);
            if (result == true)
            {
                ControlChanged?.Invoke(this, true);
            }
        }
    }
}
