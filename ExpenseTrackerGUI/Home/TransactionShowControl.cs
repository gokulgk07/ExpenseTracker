using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI.Home
{
    public partial class TransactionShowControl : UserControl
    {
        public TransactionShowControl()
        {
            InitializeComponent();

            SetDoubleBuffered(trans1);

            SetDoubleBuffered(trans2);

            SetDoubleBuffered(trans3);

            SetDoubleBuffered(trans4);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();

            ShowTransaction();
            timer1.Start();
        }

        static int index = 0;
        public bool res = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!res)
            {
                if (transactions.Count > 4)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();

                    if (index >= transactions.Count)
                    {
                        index = 0;
                    }

                    if (transactions.Count > 0)
                    {
                        if (trans1.Bottom <= 0)
                        {
                            trans1.Top = this.Location.Y + Height - trans1.Height + 30;
                            trans1Label.Text = transactions[index].CategoryName;
                            des1.Text = transactions[index].Description;
                            amount1.Text = "₹ " + transactions[index++].Amount.ToString();
                            if (index == transactions.Count)
                            {
                                index = 0;
                            }
                        }

                        if (trans2.Bottom <= 0)
                        {
                            trans2.Top = this.Location.Y + Height - trans1.Height + 30;
                            trans2Label.Text = transactions[index].CategoryName;
                            des2.Text = transactions[index].Description;
                            amount2.Text = "₹ " + transactions[index++].Amount.ToString();
                            if (index == transactions.Count)
                            {
                                index = 0;
                            }
                        }

                        if (trans3.Bottom <= 0)
                        {
                            trans3.Top = this.Location.Y + Height - trans1.Height + 30;
                            trans3Label.Text = transactions[index].CategoryName;
                            des3.Text = transactions[index].Description;
                            amount3.Text = "₹ " + transactions[index++].Amount.ToString();
                            if (index == transactions.Count)
                            {
                                index = 0;
                            }
                        }

                        if (trans4.Bottom <= 0)
                        {
                            trans4.Top = this.Location.Y + Height - trans1.Height + 30;
                            trans4Label.Text = transactions[index].CategoryName;

                            des4.Text = transactions[index].Description;
                            amount4.Text = "₹ " + transactions[index++].Amount.ToString();
                            if (index == transactions.Count)
                            {
                                index = 0;
                            }
                        }

                        trans1.Top -= 10;
                        trans2.Top -= 10;
                        trans3.Top -= 10;
                        trans4.Top -= 10;
                    }

                    else
                    {
                        timer1.Stop();
                    }
                }
                //else
                //{
                //    label1.Show();
                //    label2.Show();
                //    label3.Show();
                //    label4.Show();
                //    label5.Show();
                //    label6.Show();
                //    label7.Show();
                //    label8.Show();

                //    timer1.Stop();
                //}
            }
                
        }

        private void MouseEnterEvent(Panel panel, Label label)
        {
            panel.Location = new Point(panel.Location.X - 7, panel.Location.Y - 7);
            panel.Size = new Size(panel.Width + 15, panel.Height + 15);
            panel.Focus();
            // panel.BackColor = GUIStyles.terenaryColor;
            label.Font = new Font("Arial", 12);
        }

        private void MouseLeaveEvent(Panel panel, Label label)
        {
            panel.Location = new Point(panel.Location.X + 7, panel.Location.Y + 7);
            panel.Size = new Size(panel.Width - 15, panel.Height - 15);
            // panel.BackColor = GUIStyles.primaryColor;
            label.Font = new Font("Arial", 10);
        }

        private void SetDoubleBuffered(Control control)
        {
            // Enable double buffering
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(control, true, null);
        }

        private void trans1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans1, trans1Label);
        }

        private void trans1_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans1, trans1Label);
            timer1.Start();
        }

        private void trans2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans2, trans2Label);
        }

        private void trans2_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans2, trans2Label);
            timer1.Start();
        }

        private void trans3_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans3, trans3Label);
        }

        private void trans3_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans3, trans3Label);
            timer1.Start();
        }

        private void trans4_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans4, trans4Label);
        }

        private void trans4_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans4, trans4Label);
            timer1.Start();
        }

        private void trans1Label_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans1, trans1Label);
        }

        private void trans1Label_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans1, trans1Label);
            timer1.Start();
        }

        private void trans2Label_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans2, trans2Label);
        }

        private void trans2Label_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans2, trans2Label);
            timer1.Start();
        }

        private void trans3Label_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans3, trans3Label);
        }

        private void trans3Label_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans3, trans3Label);
            timer1.Start();
        }

        private void trans4Label_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans4, trans4Label);
        }

        private void trans4Label_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans4, trans4Label);
            timer1.Start();
        }

        private void des1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans1, trans1Label);
        }

        private void des1_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans1, trans1Label);
            timer1.Start();
        }

        private void des2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans2, trans2Label);
        }

        private void des2_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans2, trans2Label);
            timer1.Start();
        }

        private void des3_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans3, trans3Label);
        }

        private void des3_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans3, trans3Label);
            timer1.Start();
        }

        private void des4_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans4, trans4Label);
        }

        private void des4_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans4, trans4Label);
            timer1.Start();
        }

        private void amount1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans1, trans1Label);
        }

        private void amount1_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans1, trans1Label);
            timer1.Start();
        }

        private void amount2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans2, trans2Label);
        }

        private void amount2_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans2, trans2Label);
            timer1.Start();
        }

        private void amount3_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans3, trans3Label);
        }

        private void amount3_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans3, trans3Label);
            timer1.Start();
        }

        private void amount4_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MouseEnterEvent(trans4, trans4Label);
        }

        private void amount4_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(trans4, trans4Label);
            timer1.Start();
        }

        List<ExpenseTrackerDS.Transaction> transactions = new List<ExpenseTrackerDS.Transaction>();

        private void ShowTransaction()
        {
            ExpenseTracker.Manager manager = new ExpenseTracker.Manager();
            transactions = manager.FetchTransactions<List<ExpenseTrackerDS.Transaction>>(0);
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            if (index >= transactions.Count)
            {
                index = 0;
            }
            //if (transactions.Count < 4)
            //{
            //    label1.Show();
            //    label2.Show();
            //    label3.Show();
            //    label4.Show();
            //    label5.Show();
            //    label6.Show();
            //    label7.Show();
            //    label8.Show();
            //}
            //else
            //{
            //    label1.Hide();
            //    label2.Hide();
            //    label3.Hide();
            //    label4.Hide();
            //    label5.Hide();
            //    label6.Hide();
            //    label7.Hide();
            //    label8.Hide();
            //}

            if (transactions.Count > 0)//&& transactions.Count>index+4)
            {
                label1.Hide();
                label2.Hide();
                trans1Label.Text = transactions[index].CategoryName;
                des1.Text = transactions[index].Description;
                amount1.Text = "₹ " + transactions[index++].Amount.ToString();                
            }
            if (transactions.Count > 1)
            {
                label3.Hide();
                label4.Hide();
                trans2Label.Text = transactions[index].CategoryName;
                des2.Text = transactions[index].Description;
                amount2.Text = "₹ " + transactions[index++].Amount.ToString();
                
            }
            if (transactions.Count > 2)
            {
                label5.Hide();
                label6.Hide();
                trans3Label.Text = transactions[index].CategoryName;
                des3.Text = transactions[index].Description;
                amount3.Text = "₹ " + transactions[index++].Amount.ToString();
                
            }
            if (transactions.Count > 3)
            {
                label7.Hide();
                label8.Hide();
                trans4Label.Text = transactions[index].CategoryName;
                des4.Text = transactions[index].Description;
                amount4.Text = "₹ " + transactions[index++].Amount.ToString();
                
            }

            //index = index + 4;
        }
    }

}

