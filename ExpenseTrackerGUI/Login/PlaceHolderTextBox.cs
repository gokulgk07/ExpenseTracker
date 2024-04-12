using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    internal class PlaceHolderTextBox:TextBox
    {
        private string placeHolderText="";
        private bool ispassword;
        private Color tempForColor=Color.Black;
        private Color placeHolderColor= Color.FromArgb(97, 97, 97);
        public bool isPlaceholder = false;
        public Color PlaceHolderColor
        {
            set
            {
                placeHolderColor= value;
            }
            get
            {
                return placeHolderColor;
            }

        }
        public string PlaceHolderText
        {
            set
            {
                Text = value;
                placeHolderText = value;
                isPlaceholder= true;
            }
            get
            {
                return placeHolderText;
            }
        }
        public bool IsPassword
        {
            set
            {
                ispassword =value;
            }
            get
            {
                return ispassword;
            }
        }
        public override Color ForeColor {
            get 
            { 
                return base.ForeColor;
            }  
            set {
                base.ForeColor = value;
                if(value != placeHolderColor) 
                tempForColor = value;
            }
        }
        public PlaceHolderTextBox()
        {
            TextChanged += PlaceHolderTextBox_TextChanged;
          
        }

        private void PlaceHolderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Text ==null)
            {
                OnLostFocus(EventArgs.Empty);
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
          
                    if (Text == PlaceHolderText)
                    {
                        
                        if (IsPassword)
                            PasswordChar = '*';
                        Text = "";
                        ForeColor = tempForColor;
                isPlaceholder= false;
                    }

                
            base.OnGotFocus(e);

        }
        public void OnLostFocusMethod()
        {
            OnLostFocus(EventArgs.Empty);
        }
        protected override void OnLostFocus(EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Text))
            {
                if (IsPassword)
                    PasswordChar = '\0';
                ForeColor = placeHolderColor;
                Text = PlaceHolderText;
                isPlaceholder = true;


            }   
            base.OnLostFocus(e);
        }
    }
}
