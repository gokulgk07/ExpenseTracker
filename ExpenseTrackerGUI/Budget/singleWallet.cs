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
    public partial class SingleWallet : UserControl
    {
        public SingleWallet()
        {
            InitializeComponent();
        }

        public delegate void SelectHandler(object sender, string name, int id);

        public event SelectHandler Selected;

        public int Id { get; set; } = 1;

        public Color LabelForeColor
        {
            get => nameLbl.ForeColor;
            set => nameLbl.ForeColor = value;
        }

        public string LabelText
        {
            get => nameLbl.Text;
            set => nameLbl.Text = value;
        }

        public Image ViewImage
        {
            get => walletpb.BackgroundImage;
            set => walletpb.BackgroundImage = value;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Selected?.Invoke(sender, nameLbl.Text, Id);
        }

        private void OnMouseEntered(object sender, EventArgs e)
        {
            BackColor = GUIStyles.secondaryColor;
        }

        private void OnMouseLeaved(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }
    }
}
