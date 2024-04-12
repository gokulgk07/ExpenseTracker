﻿using System;
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
    public partial class WalletCard : UserControl
    {
        public WalletCard()
        {
            InitializeComponent();
        }

        public int Radius { get; set; } = 20;
        private bool isWallet = true;

        private Color backcolor = Color.White;

        #region Properties

        public Color CardBackColor
        {
            get => backcolor;
            set
            {
                backcolor = value;
                this.BackColor = backcolor;
            }
        }

        public string CardName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string CardBalance
        {
            get => lblAmount.Text;
            set => lblAmount.Text = value;
        }

        public bool IsWallet
        {
            get => isWallet;
            set
            {
                isWallet = value;
                if (value)
                {
                    pbImage.Image = Image.FromFile(".\\ResourceImages\\Wallets.png");
                }
                else
                {
                    pbImage.Image = Image.FromFile(".\\ResourceImages\\globe.png");
                }
            }
        }

        public override Font Font
        {
            get => lblName.Font;
            set => lblName.Font = lblAmount.Font = value;
        }

        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            // Get the rectangle bounds
            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);

            // Create a rounded rectangle path
            path.AddArc(bounds.X, bounds.Y, Radius * 2, Radius * 2, 180, 90); // Top left arc
            path.AddArc(bounds.Right - (Radius * 2), bounds.Y, Radius * 2, Radius * 2, 270, 90); // Top right arc
            path.AddArc(bounds.Right - (Radius * 2), bounds.Bottom - (Radius * 2), Radius * 2, Radius * 2, 0, 90); // Bottom right arc
            path.AddArc(bounds.X, bounds.Bottom - (Radius * 2), Radius * 2, Radius * 2, 90, 90); // Bottom left arc

            // Close the path
            path.CloseFigure();

            // Apply the rounded rectangle path as the region of the panel
            Region = new Region(path);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Fill the rectangle with a solid color (you can customize this)
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (Pen pen = new Pen(Color.WhiteSmoke, 3))
            {
                e.Graphics.DrawPath(pen, path);
            }

        }

        #endregion

        #region Card Click

        private void OnCardClicked(object sender, EventArgs e)
        {
            OnClick(e);
        }

        #endregion

        #region Mouse Events

        private void OnMouseEntered(object sender, EventArgs e)
        {
            this.BackColor = GUIStyles.terenaryColor;
            lblName.ForeColor = lblAmount.ForeColor = Color.Black;

            this.Cursor = Cursors.Hand;
        }

        private void OnMouseLeaved(object sender, EventArgs e)
        {
            this.BackColor = CardBackColor;
            lblName.ForeColor= lblAmount.ForeColor = Color.Black;

            this.Cursor = Cursors.Arrow;
        }

        #endregion
    }
}
