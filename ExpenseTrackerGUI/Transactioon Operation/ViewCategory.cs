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
    public partial class ViewCategory : UserControl
    {
        public ViewCategory()
        {
            InitializeComponent();
        }

        //Event Creation

        public delegate void ControlDisable(object sender, bool disabled);
        public event ControlDisable ControlDisabled;
        public delegate void ControlChange(object sender, bool changed);
        public event ControlChange ControlChanged;

        int lx = 0, ly = 0;
        float totamount = 0;
        string catname;

        Color borderColor = GUIStyles.primaryColor;
        Color backcolor = Color.White;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(this, e, borderColor, backcolor, this.Width, this.Height, 7, 30);
        }
        
        List<Transaction> listdata = new List<Transaction>();
        List<DateCategory> lidate = new List<DateCategory>();

        public List<Transaction> ListData
        {
            get => listdata;
            set
            {
                listdata = value; 
                AddDataInLabel();
                if ((Communicator.Manager.FetchCategoryName(listdata[0].CategoryId)).Type == true)
                    amountlb.ForeColor = Color.FromArgb(0, 192, 0);
                else
                    amountlb.ForeColor = Color.Red;
                categoryicon.BackgroundImage=new Bitmap((Communicator.Manager.FetchCategoryName(listdata[0].CategoryId)).ImagePath);
            }
        }        

        private void OnPbottomScroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void OnViewCategoryLoad(object sender, EventArgs e)
        {
            padd.Width = pbottom.Width * 90 / 100;
            padd.Height = pbottom.Height * 75 / 100;
            padd.Location = new Point(pbottom.Width / 2 - padd.Width / 2, pbottom.Height / 2 - padd.Height / 2);
        }

        private void AddDataInLabel()
        {
            if (listdata != null)
            {
                for (int j = 0; j < lidate.Count; j++)
                {
                    lidate[j].Dispose();
                }
                lidate.Clear();
                padd.Controls.Clear();
                lx = 2; ly = 0;totamount = 0;
                for (int i = 0; i < listdata.Count; i++)
                {
                    DateCategory dc = new DateCategory
                    {
                        EditData = listdata[i],
                        Location = new Point(lx, ly)
                    };
                    if (i % 2 != 0)
                        dc.Backcolor = Color.White;
                    else
                        dc.Backcolor = Color.GhostWhite;
                    if (i >= 1)
                        this.Height = Height + 25 + 6;
                    dc.ControlChanged += OnDcControlChanged;
                    dc.ControlDisabled += OnDcControlDisabled;
                    padd.Controls.Add(dc);
                    lidate.Add(dc);
                    ly += dc.Height+6;
                    totamount += listdata[i].Amount;
                    catname = listdata[i].CategoryName;
                }
                amountlb.Text = totamount.ToString();
                Categorynamelb.Text = "   " + catname.ToString();
                transactioncountlb.Text = "        (" + listdata.Count() + " Transactions)";
            }
        }

        //Dc Events

        private void OnDcControlDisabled(object sender, bool disabled)
        {
            if (disabled == true)
            {
                ControlDisabled?.Invoke(this, true);
            }
            else
            {
                ControlDisabled?.Invoke(this, false);
            }
        }

        private void OnDcControlChanged(object sender, bool changed)
        {
            if (changed == true)
            {
                ControlChanged?.Invoke(this, true);
            }
            else
            {
                ControlChanged?.Invoke(this, false);
            }
        }
    }
}
