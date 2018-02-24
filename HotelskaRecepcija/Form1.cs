using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dodajNovogGostaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pregledajDostupneSobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledajSobe novaForma = new PregledajSobe();
            novaForma.Show();
        }
    }
}
