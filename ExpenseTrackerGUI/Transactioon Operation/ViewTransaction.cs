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
    public partial class ViewTransaction : UserControl
    {
        public ViewTransaction()
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
        DateTime date;
        string month;

        Color borderColor = GUIStyles.primaryColor;
        Color backcolor = Color.White;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(this, e, borderColor, backcolor, this.Width, this.Height, 7, 30);
        }
        
        List<Transaction> listdata = new List<Transaction>();
        List<NameTransaction> liname = new List<NameTransaction>();

        public List<Transaction> ListData
        {
            get => listdata;
            set
            {
                listdata = value;
                AddDataInLabel();
            }
        }            

        //View Transaction Load

        private void OnViewTransactionLoad(object sender, EventArgs e)
        {
            padd.Width = pbottom.Width * 90 / 100;
            padd.Height = pbottom.Height * 75 / 100;
            padd.Location = new Point(pbottom.Width / 2 - padd.Width / 2, pbottom.Height / 2 - padd.Height / 2);
        }

        private void AddDataInLabel()
        {
            if (listdata != null)
            {
                for (int j = 0; j < liname.Count; j++)
                {
                    liname[j].Dispose();
                }
                liname.Clear();
                padd.Controls.Clear();
                lx = 2; ly = 0; totamount = 0;
                for (int i = 0; i < listdata.Count; i++)
                {
                    NameTransaction nt = new NameTransaction
                    {
                        EditData = listdata[i],
                        Location = new Point(lx, ly)
                    };
                    if (i % 2 != 0)
                        nt.Backcolor = Color.White;
                    else
                        nt.Backcolor = Color.GhostWhite;
                    if (i >= 1)
                        this.Height = Height + 25 + 6;
                    nt.ControlChanged += OnNtControlChanged;
                    nt.ControlDisabled += OnNtControlDisabled;
                    padd.Controls.Add(nt);
                    liname.Add(nt);
                    ly += nt.Height + 6;
                    totamount += listdata[i].Amount;
                    date = listdata[i].Date;
                }
                amountlb.Text = totamount.ToString(); 
                datelb.Text = "   " + date.ToString("dd");
                daylb.Text = date.DayOfWeek.ToString();
                FindMonth(date.Month);
                monthlb.Text = month+",  "+date.Year.ToString();
            }
        }

        private void FindMonth(int mon)
        {
            if (mon == 1)
            {
                month = "January";
            }
            else if (mon == 2)
            {
                month = "February";
            }
            else if (mon == 3)
            {
                month = "March";
            }
            else if (mon == 4)
            {
                month = "April";
            }
            else if (mon == 5)
            {
                month = "May";
            }
            else if (mon == 6)
            {
                month = "June";
            }
            else if (mon == 7)
            {
                month = "July";
            }
            else if (mon == 8)
            {
                month = "August";
            }
            else if (mon == 9)
            {
                month = "September";
            }
            else if (mon == 10)
            {
                month = "October";
            }
            else if (mon == 11)
            {
                month = "November";
            }
            else if (mon == 12)
            {
                month = "December";
            }
        }

        //Dc Events

        private void OnNtControlDisabled(object sender, bool disabled)
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

        private void OnNtControlChanged(object sender, bool changed)
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
