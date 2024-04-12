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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            string startupPath = "";
            startupPath = @".\Images\account.png";
            Console.WriteLine(startupPath);

            CategoryView categoryView = new CategoryView();
            categoryView.Dock = DockStyle.Fill;
            this.Controls.Add(categoryView);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabPage1;
        }
    }
}
