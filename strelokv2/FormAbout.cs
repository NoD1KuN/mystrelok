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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            label1.Text =("Стрелок | Версия 0.9.5");
            label1.Text += ('\n' + "© 死神 Corporation, 2019.01.07");
            label1.Text += ('\n' + "Programmer:Amurkhan Karsanov");
            label1.Text += ('\n' + "NOSU");
            label1.Text += ('\n' + "All rights reserved");
        }
    }
}
