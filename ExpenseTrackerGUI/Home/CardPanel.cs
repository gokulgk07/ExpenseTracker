using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ExpenseTrackerGUI.Home
{
    public partial class CardPanel : UserControl
    {
        public CardPanel()
        {
            InitializeComponent();
        }          

        Color borderColor = GUIStyles.primaryColor;
        Color backcolor = Color.White;
        Color flickercolor = GUIStyles.terenaryColor;

        public Color CardBorderColor
        {
            get => borderColor;

            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public Color CardBackColor
        {
            get => backcolor;

            set
            {
                backcolor = value;
                Invalidate();
            }
        }

        public Color CardFlickerColor
        {
            get => flickercolor;

            set
            {
                flickercolor = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); base.OnPaint(e);
            int borderWidth = 7;
            int borderRadius = 12;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                this.DoubleBuffered = true;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath borderPath = CreateRoundedRectanglePath(new Rectangle(borderWidth / 2, borderWidth / 2, this.Width - borderWidth, this.Height - borderWidth), borderRadius);
                e.Graphics.DrawPath(borderPen, borderPath);
                e.Graphics.FillPath(new SolidBrush(backcolor), borderPath);
            }
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rectangle, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (cornerRadius == 0)
            {
                path.AddRectangle(rectangle);
                return path;
            }
            // Top left arc
            path.AddArc(arc, 180, 90);
            // Top right arc
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            // Bottom right arc
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // Bottom left arc
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void CardPanel_MouseEnter(object sender, EventArgs e)
        {
            backcolor = flickercolor;
            this.Invalidate();
        }

        private void CardPanel_MouseLeave(object sender, EventArgs e)
        {
            backcolor = Color.White;
            this.Invalidate();
        }
    }
}
