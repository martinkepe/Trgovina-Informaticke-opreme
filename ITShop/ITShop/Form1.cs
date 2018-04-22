using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITShop
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ITShop iTShop = new ITShop();
            iTShop.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();

            this.Close();
        }
    }
}
