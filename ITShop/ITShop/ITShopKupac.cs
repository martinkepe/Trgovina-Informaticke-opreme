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
    public partial class ITShopKupac : Form
    {
        public ITShopKupac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArtikliKupac artikliKupac = new ArtikliKupac();
            artikliKupac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zavrseno zavrseno = new Zavrseno();
        }
    }
}
