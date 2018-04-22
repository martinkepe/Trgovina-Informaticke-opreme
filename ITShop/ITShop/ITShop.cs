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
    public partial class ITShop : Form
    {
        public ITShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Artikli artikli = new Artikli();
            artikli.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Slaganje slaganje = new Slaganje();
            slaganje.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zavrseno zavrseno = new Zavrseno();
            zavrseno.Show();
        }
    }
}
