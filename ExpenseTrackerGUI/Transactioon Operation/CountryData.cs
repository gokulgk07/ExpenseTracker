using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrackerDS;

namespace ExpenseTrackerGUI
{
    public partial class CountryData : UserControl
    {
        public CountryData()
        {
            InitializeComponent();
        }

        //Event Creation
        public delegate void CountrySelection(object sender, Country e);
        public event CountrySelection CountrySelected;

        //Preoperty Creation

        Country pcountry=new Country();
        public Country Pcountry
        {
            get => pcountry;
            set
            {
                pcountry = value;
                namelb.Text = pcountry.Name;
                symbollb.Text = pcountry.Symbol;
                flagpb.BackgroundImage = new Bitmap(@".\\Images\\" + pcountry.Flag);
            }
        }

        private void OnCountryDataMouseEnter(object sender, EventArgs e)
        {
            pback.BackColor = GUIStyles.terenaryColor;
        }

        private void OnCountryDataMouseLeave(object sender, EventArgs e)
        {
            pback.BackColor = Color.White;
        }

        private void OnCountryDataClick(object sender, EventArgs e)
        {
            CountrySelected?.Invoke(sender, pcountry);
        }
    }
}
