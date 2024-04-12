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

namespace ExpenseTrackerGUI
{
    public partial class CurveButton : UserControl
    {
        public CurveButton()
        {
            InitializeComponent();
        }

        public int Radius { get; set; } = 20;
        private Color color = GUIStyles.primaryColor, foreColor= Color.White, borderColor= Color.GhostWhite;


        public string ButtonText
        {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public Color ButtonColor
        {
            get => BackColor;
            set => BackColor = value;
        }
        
        public Color ButtonForeColor
        {
            get => lblText.ForeColor;
            set => lblText.ForeColor = value;
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
            }
        }

        private void OnMouseEntered(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.BackColor = GUIStyles.secondaryColor;
            this.Size = new Size(this.Width + 4, this.Height + 4);
        }

        private void OnMouseLeaved(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            this.BackColor = GUIStyles.primaryColor;
            this.Size = new Size(this.Width - 4, this.Height - 4);
        }

        private void OnClickTriggered(object sender, EventArgs e)
        {
            OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            
            // Get the rectangle bounds
            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            path.StartFigure();

            // Create a rounded rectangle path
            path.AddArc(bounds.X, bounds.Y, Radius * 2, Radius * 2, 180, 90); // Top left arc
            path.AddArc(bounds.Right - (Radius * 2), bounds.Y, Radius * 2, Radius * 2, 270, 90); // Top right arc
            path.AddArc(bounds.Right - (Radius * 2), bounds.Bottom - (Radius * 2), Radius * 2, Radius * 2, 0, 90); // Bottom right arc
            path.AddArc(bounds.X, bounds.Bottom - (Radius * 2), Radius * 2, Radius * 2, 90, 90); // Bottom left arc

            // Close the path
            path.CloseFigure();
            
            // Apply the rounded rectangle path as the region of the panel
            Region = new Region(path);
            
            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Fill the rectangle with a solid color (you can customize this)
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (Pen pen = new Pen(BorderColor, 3))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

    }
}
