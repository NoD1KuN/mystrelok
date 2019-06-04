using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strelokv2
{
    public partial class LoginForm : Form
    {
        public static string login = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool LoginCheck()
        {
            if (textBoxLogin.Text == "") return false;
            for (int i = 0; i < textBoxLogin.Text.Length; i++)
            {
                if (textBoxLogin.Text[i] < 'A' || textBoxLogin.Text[i] > 'z')
                {
                    textBoxLogin.Text = "";
                    return false;
                }
            }
            return true;
        }

        private void textBoxLogin_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (LoginCheck())
                {
                    login = textBoxLogin.Text;
                    this.Close();
                }
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (LoginCheck())
            {
                login = textBoxLogin.Text;
                this.Close();
            }
        }
    }
}
