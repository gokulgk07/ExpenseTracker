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
    public partial class CurveButtons : Button
    {
        public CurveButtons()
        {
            InitializeComponent();
            ForeColor = Color.White;
            MouseHover += OnMouseHovered;
            MouseLeave += OnMouseLeaved;
            DoubleBuffered = true;
        }
        private int curveSize = 35;

        private Color stringColor = Color.White;

        private Color back = Color.White;

        private Color primaryColor = GUIStyles.primaryColor;

        private Color secondColor = GUIStyles.secondaryColor;

        private bool select = false;

        private void OnMouseLeaved(object sender, EventArgs e)
        {
            //Select = !Select;
            stringColor = Color.White;
            Invalidate();
        }

        private void OnMouseHovered(object sender, EventArgs e)
        {
            //Select = !Select;
            stringColor = Color.Cyan;
            Invalidate();
        }

        public bool ReturnClicked { get; set; } = false;

        public int CurveSize
        {
            get => curveSize;
            set
            {
                curveSize = value;
                Invalidate();
            }
        }

        public bool Select
        {
            get => select;
            set
            {
                select = value;
                Invalidate();
            }
        }

        public Color Back
        {
            get => back;
            set
            {
                back = value;
                Invalidate();
            }
        }

        public Color PrimaryColor
        {
            get => primaryColor;
            set
            {
                primaryColor = value;
                Invalidate();
            }
        }

        public Color SecondColor
        {
            get => secondColor;
            set
            {
                secondColor = value;
                Invalidate();
            }
        }

        public event EventHandler<string> SelectedValueChange;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.Clear(Back);
            Graphics g = pevent.Graphics;
            DoubleBuffered = true;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calculate the dimensions and position of the curve
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            // Fill the button with appropriate color
            if (!Select)
                g.FillPath(new SolidBrush(primaryColor), path);
            else
                g.FillPath(new SolidBrush(secondColor), path);

            // Draw text
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawString(this.Text, this.Font, new SolidBrush(stringColor), rect, format);

            // Draw border
            g.DrawPath(new Pen(this.ForeColor), path);

        }

        private void OnClicked(object sender, EventArgs e)
        {
            if (!ReturnClicked)
            {
                if (Text == "...")
                    return;
                if (Select == true)
                    Select = false;
                else
                    Select = true;

                SelectedValueChange?.Invoke(sender, Text);
            }
        }
    }
}
