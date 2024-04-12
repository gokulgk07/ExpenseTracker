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
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }

        //Property

        float answer = 0;
        int time = 0;
        public float Answer
        {
            get => answer;
            set
            {
                answer = value;
                datatb.Text = answer.ToString();
            }
        }

        //Event Creation

        public delegate void CalculatorClose(object sender, bool closed);
        public event CalculatorClose CalculatorClosed;

        //Calculator Load and Timer

        private void OnCalculatorLoad(object sender, EventArgs e)
        {
            p5.Width = p1.Width;
        }

        private void OnTimerStart(object sender, EventArgs e)
        {
            time++;
            if (time == 10)
            {
                time = 0;
                savebt.BackgroundImage = Image.FromFile(@".\Images\TickCalc.png");
                calctimer.Stop();
            }
        }

        //Sign Button Click

        private void OnDivideBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            if (datatb.TextLength > 0)
            {
                char txt = datatb.Text[datatb.TextLength - 1];
                if (txt == '/' || txt == '*' || txt == '+' || txt == '-' || txt == '.')
                {
                    datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1) + "/";
                }
                else
                {
                    datatb.Text += "/";
                }
            }
        }

        private void OnMultiplyBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            if (datatb.TextLength > 0)
            {
                char txt = datatb.Text[datatb.TextLength - 1];
                if (txt == '/' || txt == '*' || txt == '+' || txt == '-' || txt == '.')
                {
                    datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1) + "*";
                }
                else
                {
                    datatb.Text += "*";
                }
            }
        }

        private void OnSubtractBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            if (datatb.TextLength > 0)
            {
                char txt = datatb.Text[datatb.TextLength - 1];
                if (txt == '/' || txt == '*' || txt == '+' || txt == '-' || txt == '.')
                {
                    datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1) + "-";
                }
                else
                {
                    datatb.Text += "-";
                }
            }
        }

        private void OnAddBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            if (datatb.TextLength > 0)
            {
                char txt = datatb.Text[datatb.TextLength - 1];
                if (txt == '/' || txt == '*' || txt == '+' || txt == '-' || txt == '.')
                {
                    datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1) + "+";
                }
                else
                {
                    datatb.Text += "+";
                }
            }
        }

        private void OnDotBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            if (datatb.TextLength > 0 && CheckDot() == true)
            {
                char txt = datatb.Text[datatb.TextLength - 1];
                if (txt == '/' || txt == '*' || txt == '+' || txt == '-')
                {
                    datatb.Text += "0.";
                }
                else if(txt == '.')
                {
                    datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1) + ".";
                }
                else
                {
                    datatb.Text += ".";
                }
            }
            else if(datatb.TextLength==0)
            {
                datatb.Text += "0.";
            }
        }

        private void OnDeleteBtClick(object sender, EventArgs e)
        {
            if (datatb.TextLength > 0)
            {
                datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1);
            }
        }

        private void OnClearBtClick(object sender, EventArgs e)
        {
            datatb.Text = "";
        }

        private void OnEqualToBtClick(object sender, EventArgs e)
        {
            if (datatb.TextLength > 0)
            {
                string data = datatb.Text;
                string ndata = "";
                List<char> lisign = new List<char>();
                List<float> linum = new List<float>();
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == 'E')
                    {
                        linum.Add(CheckFloat(ndata)); ndata = "";
                        break;
                    }
                    else if (data[i] == '/' && i < data.Length - 1)
                    {                        
                        linum.Add(CheckFloat(ndata));
                        lisign.Add('/'); ndata = "";
                    }
                    else if (data[i] == '*' && i < data.Length - 1)
                    {
                        linum.Add(CheckFloat(ndata));
                        lisign.Add('*'); ndata = "";
                    }
                    else if (data[i] == '+' && i < data.Length - 1)
                    {
                        linum.Add(CheckFloat(ndata));
                        lisign.Add('+'); ndata = "";
                    }
                    else if (data[i] == '-' && i < data.Length - 1)
                    {
                        linum.Add(CheckFloat(ndata));
                        lisign.Add('-'); ndata = "";
                    }
                    else
                    {
                        if (data[i] != '/' && data[i] != '*' && data[i] != '+' && data[i] != '-')
                        {
                            ndata += data[i];
                        }
                    }
                }
                if (ndata.Length > 0)
                {
                    linum.Add(CheckFloat(ndata));
                }
                while (lisign.Count > 0)
                {
                    for (int i = 0; i < lisign.Count; i++)
                    {
                        if (lisign[i] == '/')
                        {
                            linum[i] = linum[i] / linum[i + 1];
                            linum.RemoveAt(i + 1);
                            lisign.RemoveAt(i);
                            i--;
                        }
                        if (i >= 0 && lisign[i] == '*')
                        {
                            linum[i] = linum[i] * linum[i + 1];
                            linum.RemoveAt(i + 1);
                            lisign.RemoveAt(i);
                            i--;
                        }
                    }
                    for (int i = 0; i < lisign.Count; i++)
                    {
                        if (lisign[i] == '+')
                        {
                            linum[i] = linum[i] + linum[i + 1];
                            linum.RemoveAt(i + 1);
                            lisign.RemoveAt(i);
                            i--;
                        }
                        if (i >= 0 && lisign[i] == '-')
                        {
                            linum[i] = linum[i] - linum[i + 1];
                            linum.RemoveAt(i + 1);
                            lisign.RemoveAt(i);
                            i--;
                        }
                    }
                }
                datatb.Text = linum[0].ToString();
            }
        }

        private void OnSaveBtClick(object sender, EventArgs e)
        {
            ValidateFloat();
            OnEqualToBtClick(sender, e);
            ValidateFloat();
            answer = float.Parse(datatb.Text);
            savebt.BackgroundImage = Image.FromFile(@".\Images\TickCalcGreen.png");
            calctimer.Start();
        }

        private void OnBackBtClick(object sender, EventArgs e)
        {
            CalculatorClosed?.Invoke(sender, true);
        }

        private float CheckFloat(String val)
        {
            bool check = false;
            float value=0;
            check = float.TryParse(val, out value);
            if (check == false)
            {
                return 0;
            }
            return value;
        }

        private void ValidateFloat()
        {
            if (datatb.Text == "∞" || datatb.Text == "NaN" || datatb.Text == "0" || datatb.Text == "")
            {
                datatb.Text = answer.ToString();
                return;
            }
            for (int i = 0; i < datatb.Text.Length; i++)
            {
                if (datatb.Text[i] == 'E')
                {
                    datatb.Text = answer.ToString();
                    return;
                }
            }
        }

        //Validat Functions

        private void OnDataBtKeyPress(object sender, KeyPressEventArgs e)
        {
            ChechInfinity();
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else if(e.KeyChar == (char)43 || e.KeyChar == (char)45 || e.KeyChar == (char)42 || e.KeyChar == (char)47)
            {
                if (datatb.TextLength > 0)
                {
                    char txt = datatb.Text[datatb.TextLength - 1];
                    if (txt == '/' || txt == '*' || txt == '+' || txt == '-' || txt == '.')
                    {
                        datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1);
                    }
                }
                else
                {
                    e.Handled = true;
                }
                datatb.SelectionStart = datatb.TextLength;
            }
            else if (e.KeyChar == (char)46)
            {                
                if(datatb.TextLength==0)
                {
                    datatb.Text += "0";
                }
                else if (datatb.TextLength > 0 && CheckDot() == true)
                {
                    char txt = datatb.Text[datatb.TextLength - 1];
                    if (txt == '/' || txt == '*' || txt == '+' || txt == '-')
                    {
                        datatb.Text += "0";
                        datatb.SelectionStart = datatb.TextLength;
                    }
                    else if (txt == '.')
                    {
                        datatb.Text = datatb.Text.Substring(0, datatb.TextLength - 1);
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == (char)13)
            {
                OnEqualToBtClick(sender, EventArgs.Empty);
                datatb.SelectionStart = datatb.TextLength;
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool CheckDot()
        {
            String totdata = datatb.Text;
            for(int i= totdata.Length - 1; i >= 0; i--)
            {
                if(totdata[i]=='/' || totdata[i] == '*' || totdata[i] == '+' || totdata[i] == '-')
                {
                    return true;
                }
                else if(totdata[i] == '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void ChechInfinity()
        {
            if (datatb.Text == "∞" || datatb.Text == "NaN" || datatb.Text=="0")
            {
                datatb.Text = "";
            }
        }

        //Number Button Click

        private void OnOneBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "1";
        }

        private void OnTwoBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "2";
        }

        private void OnThreeBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "3";
        }

        private void OnFourBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "4";
        }

        private void OnFiveBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "5";
        }

        private void OnSixBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "6";
        }

        private void OnSevenBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "7";
        }

        private void OnEightBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "8";
        }

        private void OnNineBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "9";
        }

        private void OnZeroBtClick(object sender, EventArgs e)
        {
            ChechInfinity();
            datatb.Text += "0";
        }
    }
}
