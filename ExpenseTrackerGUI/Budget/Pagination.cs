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
    public partial class Pagination : UserControl
    {
        public Pagination()
        {
            InitializeComponent();
            CreateButtons();
        }

        private int buttonCount = 1;

        private string index =1.ToString();

        private List<CurveButtons> buttons = new List<CurveButtons>();

        public int ButtonCount
        {
            get => buttonCount;
            set
            {
                buttonCount = value;
                CreateButtons();
            }
        }

        public event EventHandler<int> ValueChanged;

        public void CreateButtons()
        {
            foreach(CurveButtons btn in buttons)
            {
                btn.Dispose();
            }
            buttons.Clear();
            buttons.Add(new CurveButtons() { Text = "<", Dock = DockStyle.Right , Size = new Size(35,35) });
            for(int i=0;i<5 && i< ButtonCount; i++)
            {
                if(i==4 && ButtonCount > 5)
                {
                    buttons.Add(new CurveButtons() { Text = "...", Dock = DockStyle.Right, Size = new Size(35, 35) });
                    break;
                }
                buttons.Add(new CurveButtons() { Text = $"{i+1}", Dock = DockStyle.Right, Size = new Size(35, 35) });

            }
            buttons.Add(new CurveButtons() { Text = ">", Dock = DockStyle.Right, Size = new Size(35, 35) });
            Size = new Size((buttons.Count * 35) , 35);
            AddControls();
        }

        public void SelectStarting()
        {
            for(int i=0;i<buttons.Count;i++)
            {
                buttons[i].SelectedValueChange -= OnSelectedValueChanged;
                if(i==1)
                {
                    buttons[i].Select = true;
                    OnSelectedValueChanged(new object(), "1");
                }
                else
                {
                    buttons[i].Select = false;
                }
                buttons[i].SelectedValueChange += OnSelectedValueChanged;
            }
        }

        private void AddControls()
        {
            Controls.Clear();
            foreach (CurveButtons btn in buttons)
            {
                Controls.Add(btn);
                if(btn.Text == index)
                {
                    btn.Select = !btn.Select;
                }
                btn.SelectedValueChange += OnSelectedValueChanged;
            }
        }

        private void OnSelectedValueChanged(object sender, string e)
        {
            if (e == "<")
            {
                buttons[0].Select = false;
                PreviousClicked();
                ValueChanged?.Invoke(sender, Convert.ToInt32(buttons[Convert.ToInt32(index)].Text));
                return;
            }
            if (e == ">")
            {
                buttons[buttons.Count - 1].Select = false;
                NextClicked();
                ValueChanged?.Invoke(sender, Convert.ToInt32(buttons[Convert.ToInt32(index)].Text));
                return;
            }
            for(int i = 1;i<=5 && i<=buttons.Count-1;i++)
            {
                if(e == buttons[i].Text)
                {
                    buttons[Convert.ToInt32(index)].Select = !buttons[Convert.ToInt32(index)].Select;
                    index = i.ToString();
                    ValueChanged?.Invoke(sender, Convert.ToInt32(buttons[Convert.ToInt32(index)].Text));
                    break;
                }
            } 
        }

        private void NextClicked()
        {
            if(Convert.ToInt32(buttons[Convert.ToInt32(index)].Text) < ButtonCount)
            {
                buttons[Convert.ToInt32(index)].Select = !buttons[Convert.ToInt32(index)].Select;
                if(Convert.ToInt32(index) == 4 && buttons[5].Text == "..." || (Convert.ToInt32(buttons[ Convert.ToInt32(index)].Text) + 4 == ButtonCount &&(ButtonCount > 5)))
                {
                    int num = Convert.ToInt32(buttons[Convert.ToInt32(index)].Text);
                    buttons[1].Text = "...";
                    if(buttonCount <= 8 && num <= 8)
                    {
                        for(int i = 2;i <= 5;i++)
                        {
                            buttons[i].Text = $"{i + num - 1}";
                        }
                    }
                    else
                    {
                        if (num + 4 >= ButtonCount)
                        {
                            for(int i=2;i<=5;i++)
                            {
                                buttons[i].Text = $"{(num++)+1}";
                            }
                        }
                        else
                        {
                            for (int i = 2; i <= 4; i++)
                            {
                                buttons[i].Text = $"{i + num - 1}";
                            }
                            buttons[5].Text = "...";
                        }
                    }

                    buttons[2].Select = !buttons[2].Select;
                    index = 2.ToString();
                } 
                else
                {
                    buttons[Convert.ToInt32(index)+1].Select = !buttons[Convert.ToInt32(index)+1].Select;
                    index = (Convert.ToInt32(index) + 1).ToString();
                }
            }
        }

        private void PreviousClicked()
        {
            if(Convert.ToInt32(buttons[Convert.ToInt32(index)].Text) > 1)
            {
                buttons[Convert.ToInt32(index)].Select = !buttons[Convert.ToInt32(index)].Select;
                if((Convert.ToInt32(index) > ButtonCount - 3 && Convert.ToInt32(index) <= ButtonCount && buttons[1].Text == "...")||(buttons[1].Text == "..." && buttons[5].Text == "...") || buttons[(Convert.ToInt32(index))].Text == (ButtonCount - 3).ToString() && buttons[1].Text == "...")   
                {
                    int num = Convert.ToInt32(buttons[Convert.ToInt32(index)].Text);
                    if (buttonCount <= 8 && num <= 5 )
                    {
                        buttons[5].Text = "...";
                        for (int i = 1; i < 5; i++)
                        {
                            buttons[i].Text = $"{i}";
                        }
                        buttons[Convert.ToInt32(index)].Select = !buttons[Convert.ToInt32(index)].Select;
                        buttons[4].Select = !buttons[4].Select;
                        index = 4.ToString();
                    }
                    else
                    {
                        if(buttons[1].Text == "..." && buttons[5].Text !="...")
                        {
                            num--;
                            for (int i = 2; i <= 4; i++)
                            {
                                buttons[i].Text = $"{num++}";
                            }
                            buttons[3].Select = !buttons[3].Select;
                            index = 3.ToString();
                        }
                        else if(num > 4 && buttons[Convert.ToInt32(index)-1].Text == "...")
                        {
                            for(int i = 2 , j = 3; i <=4;i++,j--)
                            {
                                buttons[i].Text = $"{num - j }";
                            }
                            buttons[4].Select = !buttons[4].Select;
                            index = 4.ToString();
                        }
                        else
                        {
                            buttons[Convert.ToInt32(index) - 1].Select = !buttons[Convert.ToInt32(index) - 1].Select;
                            index = (Convert.ToInt32(index) - 1).ToString();
                        }
                        buttons[5].Text = "...";
                    }

                    if (Convert.ToInt32(buttons[Convert.ToInt32(index)].Text) <= 4)
                    {
                        buttons[1].Text = "1";
                    }
                }
                else
                {
                    buttons[Convert.ToInt32(index) - 1].Select = !buttons[Convert.ToInt32(index) - 1].Select;
                    index = (Convert.ToInt32(index) - 1).ToString();
                }
            }
        }
    }
}
