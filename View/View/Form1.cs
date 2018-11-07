using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.View;

namespace View
{
    public partial class PhoneBookView : Form, IView
    {
        public PhoneBookView()
        {
            InitializeComponent();
        }

        public string ContactName
        {
            get
            {
                return NameTextBox.Text;
            }
            set
            {
                NameTextBox.Text = value;
            }
        }

        public string EMail
        {
            get
            {
                return EmailTextBox.Text;
            }
            set
            {
                EmailTextBox.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return LastNameTextBox.Text;
            }
            set
            {
                LastNameTextBox.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return PhoneNumberTextBox.Text;
            }
            set
            {
                PhoneNumberTextBox.Text = value;
            }
        }

        public string Search
        {
            get
            {
                return SearchTextBox.Text;
            }
            set
            {
                SearchTextBox.Text = value;
            }
        }

        public string Skype
        {
            get
            {
                return SkypeTextBox.Text;
            }
            set
            {
                SkypeTextBox.Text = value;
            }
        }
    }
}
