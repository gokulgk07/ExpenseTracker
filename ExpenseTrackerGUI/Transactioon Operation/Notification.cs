using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            ActiveControl = Yesbt;
        }

        //Paint Operation

        public Color borderColor = GUIStyles.primaryColor;
        public Color backcolor = Color.White;
        public Color outcolor= GUIStyles.primaryColor;

        private void OnDeleteShowPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, borderColor, backcolor, pdeleteshow.Width, pdeleteshow.Height, 20, 20);
        }

        //Variables

        public bool yes = false;
        String category_name = "";

        //Property

        public String Category_Name
        {
            get => category_name;
            set
            {
                category_name = value;
                if (category_name != "")
                {
                    ltext.Text = "Your Budget for " + category_name + " is Exceeded.\n";
                    ltext.Text += "\nDo you want to Continue Transaction ?";
                    lhead.Text = "Budget Exceeded";
                    logopb.BackgroundImage = Image.FromFile(@".\Images\Limitcrossed.png"); 
                }
            }
        }

        //Notification Load

        private void OnNotificationLoad(object sender, EventArgs e)
        {
            this.BackColor = outcolor;
        }

        //Button Click Events

        private void OnYesBtClick(object sender, EventArgs e)
        {
            yes = true;
            this.Close();
        }

        private void OnNoBtClick(object sender, EventArgs e)
        {
            yes = false;
            this.Close();
        }
    }
}
