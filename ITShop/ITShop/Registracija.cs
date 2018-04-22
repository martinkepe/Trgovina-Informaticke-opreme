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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            prijava.Show();

            this.Close();
        }
    }
}
