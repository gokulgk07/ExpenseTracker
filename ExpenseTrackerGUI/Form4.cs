using ExpenseTracker;
using ExpenseTrackerDS;
using ExpenseTrackerGUI.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // var res = Communicator.Manager.FetchTransactionOnDates<List<Transaction>>(DateTime.Now.AddMonths(-1), DateTime.Now, Manager.ViewType.Month);
            //ToCSV(res);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //CreateTransaction c = new CreateTransaction();
            //c.Dock = DockStyle.Fill;
            //this.Controls.Add(c);

        }
    }
}
