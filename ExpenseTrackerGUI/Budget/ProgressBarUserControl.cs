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
    public partial class ProgressBarUserControl : UserControl
    {

        public ProgressBarUserControl()
        {
            InitializeComponent();
        }
        
        private List<Color> colors = new List<Color>() { Color.LightSeaGreen };

        private int value = 0;

        public int Value
        {
            get => value;
            set
            {
                this.value = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Graphics g = e.Graphics)
            {
                BackColor = GUIStyles.primaryColor;

                int width = 150;
                int height = 11;
                int radius = 5;

                int x = (this.ClientSize.Width - width) / 2;
                int y = (this.ClientSize.Height - height) / 2;

                Brush brush = new SolidBrush(Color.FromArgb(10, 255, 30));
                
                g.SmoothingMode = SmoothingMode.AntiAlias;

                g.FillEllipse(Brushes.White, x, y, 2 * radius, 2 * radius);
                g.FillRectangle(Brushes.White, x + radius, y, width - radius - radius, height + 1);
                g.FillEllipse(Brushes.White, x + width - 2 * radius, y, 2 * radius, 2 * radius);

                if (value <= 5)
                {
                    g.FillEllipse(brush, x, y, ((2 * radius) / 5) * value, 2 * radius);
                }
                if (value > 5 && value <= 99)
                {
                    g.FillEllipse(brush, x, y, 2 * radius, 2 * radius);
                    g.FillRectangle(brush, x + radius, y, (int)(((float)(width - radius - radius) / 100) * value), height);
                }
                if (value > 99)
                {
                    g.FillEllipse(Brushes.Red, x, y, 2 * radius, 2 * radius);
                    g.FillRectangle(Brushes.Red, x + radius, y, (int)(((float)(width - radius - radius) / 100) * value), height);
                    g.FillEllipse(Brushes.Red, x + width - 2 * radius, y, 2 * radius, 2 * radius);
                }

            }
        }
    }
}
