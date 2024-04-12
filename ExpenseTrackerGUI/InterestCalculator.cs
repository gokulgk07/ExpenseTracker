using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerGUI
{
    public partial class InterestCalculator : UserControl
    {
        public InterestCalculator()
        {
            InitializeComponent();
        }

        private void OnInterestRateLoad(object sender, EventArgs e)
        {
            calc.Dock = DockStyle.Fill;
            pcalculator.Controls.Add(calc);
            pcalculator.Location = new Point(156, 22);
            pcalculator.Size = new Size(272, 261);
            calc1.Dock = DockStyle.Fill;
            pcalculator1.Controls.Add(calc1);
            pcalculator1.Location = new Point(156, 22);
            pcalculator1.Size = new Size(272, 261);
            litype.Add("Years");
            litype.Add("Quaters");
            litype.Add("Months");
            litype.Add("Weeks");
            litype.Add("Days");
            typecb.DataSource = litype;
            typecb1.DataSource = litype;
            licompound.Add("Yearly");
            licompound.Add("Haly-Yearly");
            licompound.Add("Quarterly");
            licompound.Add("Monthly");
            licompound.Add("Weekly");
            licompound.Add("Daily");
            compoundcb1.DataSource = licompound;
        }

        //Event Creation

        public event EventHandler InterestCalculatorClosed;

        //Paint Operation

        private void OnSimpleInterestPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.MidnightBlue, SIbackcolor, SIbt.Width, SIbt.Height, 4, 15);
        }

        private void OnCompoundInterestPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, Color.MidnightBlue, CIbackcolor, SIbt.Width, SIbt.Height, 4, 15);
        }

        private void OnPbottomPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); DoubleBuffered = true;
            TransactionEditor.PaintOperation(sender, e, GUIStyles.primaryColor, Color.GhostWhite, pbottom.Width, pbottom.Height, 10, 10);
        }

        //Variable Initialization

        Color SIbackcolor = Color.Lavender, CIbackcolor = Color.GhostWhite;
        Calculator calc = new Calculator();
        Calculator calc1 = new Calculator();
        List<string> litype = new List<string>();
        List<string> licompound = new List<string>();

        //Button Click Events

        private void OnSIbtClick(object sender, EventArgs e)
        {
            CIbackcolor = Color.GhostWhite;
            SIbackcolor = Color.Lavender;
            pSI.Invalidate(); pCI.Invalidate();
            TabControl.SelectedTab = SItb;
            OnCalculatebtClick(sender, e);
        }

        private void OnCIbtClick(object sender, EventArgs e)
        {
            CIbackcolor = Color.Lavender;
            SIbackcolor = Color.GhostWhite;
            pSI.Invalidate();pCI.Invalidate();
            TabControl.SelectedTab = CItb;
            OnCalculate1btClick(sender, e);
        }
        
        //SI button Click Events

        private void OnAmountbtClick(object sender, EventArgs e)
        {
            pcalculator.BringToFront();
            calc.Answer = float.Parse(amountbt.Text);
            pcalculator.Visible = true;
            pamount.Enabled = ptime.Enabled = ptype.Enabled = prate.Enabled = pbutton.Enabled = presult.Enabled = calculatebt.Enabled = false;
            calc.CalculatorClosed += OnCalculatorClosed;
        }

        private void OnAmount1btClick(object sender, EventArgs e)
        {
            pcalculator1.BringToFront();
            calc1.Answer = float.Parse(amountbt1.Text);
            pcalculator1.Visible = true;
            pamount1.Enabled = ptime1.Enabled = ptype1.Enabled = pcompound1.Enabled = prate1.Enabled = pbutton.Enabled = presult1.Enabled = calculate1bt.Enabled = false;
            calc1.CalculatorClosed += OnCalculatorClosed1;
        }

        private void OnCalculatorClosed1(object sender, bool closed)
        {
            amountbt1.Text = calc1.Answer.ToString();
            pcalculator1.Visible = false;
            pamount1.Enabled = ptime1.Enabled = ptype1.Enabled = pcompound1.Enabled = prate1.Enabled = pbutton.Enabled = presult1.Enabled = calculate1bt.Enabled = true;
        }

        private void OnCalculatorClosed(object sender, bool closed)
        {
            amountbt.Text = calc.Answer.ToString();
            pcalculator.Visible = false;
            pamount.Enabled = ptime.Enabled = ptype.Enabled = prate.Enabled = pbutton.Enabled = presult.Enabled = calculatebt.Enabled = true;
        }

        private void OnCalculatebtClick(object sender, EventArgs e)
        {
            if (CheckAmount(amountbt.Text,0) == true && CheckRate(ratetb.Text,0) == true && CheckTime(timetb.Text,0) == true)
            {
                float principal = float.Parse(amountbt.Text);
                float rate = float.Parse(ratetb.Text);
                float time = FindTime(float.Parse(timetb.Text),0);
                float answer = (principal * time * rate) / 100;
                pamountas.Text = "₹ "+principal.ToString("F2");
                iamountas.Text = "₹ " + answer.ToString("F2");
                tamountas.Text = "₹ " + (principal + answer).ToString("F2");
            }
        }

        private void OnCalculate1btClick(object sender, EventArgs e)
        {
            if (CheckAmount(amountbt1.Text,1) == true && CheckRate(ratetb1.Text,1) == true && CheckTime(timetb1.Text,1) == true)
            {
                float principal = float.Parse(amountbt1.Text);
                float rate = (float.Parse(ratetb1.Text))/100;
                float time = FindTime(float.Parse(timetb1.Text),1);
                double answer = FindAnswer(principal,rate,time);
                pamountac.Text = "₹ " + principal.ToString("F2");
                iamountac.Text = "₹ " + answer.ToString("F2");
                tamountac.Text = "₹ " + (principal + answer).ToString("F2");
            }
        }

        private double FindAnswer(float principal,float rate,float time)
        {
            double answer = 0;
            if (compoundcb1.Text == "Yearly")
                answer = (principal * (Math.Pow((1 + rate), time))) - principal;
            else if (compoundcb1.Text == "Haly-Yearly")
                answer = (principal * (Math.Pow((1 + (rate / 2)), (2 * time)))) - principal;
            else if (compoundcb1.Text == "Quarterly")
                answer = (principal * (Math.Pow((1 + (rate / 4)), (4 * time)))) - principal;
            else if (compoundcb1.Text == "Monthly")
                answer = (principal * (Math.Pow((1 + (rate / 12)), (12 * time)))) - principal;
            else if (compoundcb1.Text == "Weekly")
                answer = (principal * (Math.Pow((1 + (rate / 52)), (52 * time)))) - principal;
            else if (compoundcb1.Text == "Daily")
                answer = (principal * (Math.Pow((1 + (rate / 365)), (365 * time)))) - principal;
            return answer;
        }

        private float FindTime(float time,int i)
        {
            string strtime = "";
            if (i == 1)
                strtime = typecb1.Text;
            else
                strtime = typecb.Text;

            if (strtime == "Quaters")
                time = time / 4;
            else if (strtime == "Months")
                time = time / 12;
            else if (strtime == "Weeks")
                time = time / 52;
            else if (strtime == "Days")
                time = time / 365;
            return time;
        }

        //Validate Functions

        private bool CheckAmount(string amt,int i)
        {
            if (i == 0)
            {
                if (amt.Length > 0)
                {
                    ErrorProvider.SetError(pamount, "");
                    return true;
                }
                ErrorProvider.SetError(pamount, "Amount is required");
                return false;
            }
            if (amt.Length > 0)
            {
                ErrorProvider.SetError(pamount1, "");
                return true;
            }
            ErrorProvider.SetError(pamount1, "Amount is required");
            return false;
        }

        private bool CheckRate(string rate, int i)
        {
            if (i == 0)
            {
                if (rate.Length > 0)
                {
                    ErrorProvider.SetError(prate, "");
                    return true;
                }
                ErrorProvider.SetError(prate, "Interest is required");
                return false;
            }
            if (rate.Length > 0)
            {
                ErrorProvider.SetError(prate1, "");
                return true;
            }
            ErrorProvider.SetError(prate1, "Interest is required");
            return false;
        }

        private bool CheckTime(string time, int i)
        {
            if (i == 0)
            {
                if (time.Length > 0)
                {
                    ErrorProvider.SetError(ptime, "");
                    return true;
                }
                ErrorProvider.SetError(ptime, "Period Value is required");
                return false;
            }
            if (time.Length > 0)
            {
                ErrorProvider.SetError(ptime1, "");
                return true;
            }
            ErrorProvider.SetError(ptime1, "Period Value is required");
            return false;
        }

        private bool CheckDot(string rate)
        {
            for (int i = 0; i < rate.Length; i++)
            {
                if (rate[i] == '.')
                {
                    return false;
                }
            }
            return true;
        }

        //KeyPress Events

        private void OnRateKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)46)
            {
                if (CheckDot(ratetb.Text) == true)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnRateKeyPress1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)46)
            {
                if (CheckDot(ratetb1.Text) == true)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnCloseBtClick(object sender, EventArgs e)
        {
            InterestCalculatorClosed?.Invoke(sender, e);
        }

        private void OnTimeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
