using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI.Login
{
    public partial class MovingLabel : UserControl
    {
        public MovingLabel()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer2.Interval = 5000;
            strings.Add("Always Keep track your\nincome and expenses");
            strings.Add("Saving is a great habit but\n without saving and investing,\nit just sleeps");
            strings.Add("A budget is telling your money\nwhere to go\ninstead of wondering\nwhere it went");
            label1.Text = strings[0];
            label2.Text = strings[1];
            timer1.Tick += OnTimer1Ticked;
            timer2.Tick += OnTimer2Ticked;
            timer2.Start();
        }

        private void OnTimer2Ticked(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Stop();
        }

        private void OnTimer1Ticked(object sender, EventArgs e)
        {
            if(label1.Location.X + label1.Width == 0 || label2.Location.X + label2.Width == 0)
            {
                timer1.Stop();
                if(label1.Location.X + label1.Width == 0)
                {
                    label1.Location = new Point(291, 0);
                    label1.Text = strings[index++];
                }
                else
                {
                    label2.Location = new Point(291, 0);
                    label2.Text = strings[index++];
                }
                if(index >= strings.Count)
                {
                    index = 0;
                }
                timer2.Start();
                return;
            }
            label1.Location = new Point(label1.Location.X - 1, label1.Location.Y);
            label2.Location = new Point(label2.Location.X - 1, label2.Location.Y);
        }

        int index = 2;
        private Timer timer1 = new Timer();
        private Timer timer2 = new Timer();
        private List<string> strings = new List<string>();

    }
}
