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
            DodajNovogGostaForm novaForma = new DodajNovogGostaForm();
            novaForma.ShowDialog();
        }

        private void pogledajRasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasporedOsoblja raspored = new RasporedOsoblja();
            raspored.ShowDialog();
        }

        private void dodajZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajZaposlenika zaposlenik = new DodajZaposlenika();
            zaposlenik.ShowDialog();
        }

        private void novoZaduženjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoZaduzenje zaduzenje = new novoZaduzenje();
            zaduzenje.ShowDialog();
        }

        private void pregledajDostupneSobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledajSobe novaForma = new PregledajSobe();
            novaForma.Show();
        }

        private void hR_NOCENJABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void popisUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazUsluga usluge = new PrikazUsluga();
            usluge.ShowDialog();
        }

        private void rezervacijaUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervirajUslugu usluga = new RezervirajUslugu();
            usluga.ShowDialog();
        }

        private void naplatiUsluguToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NaplatiUslugu usluga = new NaplatiUslugu();
            usluga.ShowDialog();
        }

        private void popisRezerviranihUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezerviraneUsluge usluge = new RezerviraneUsluge();
            usluge.ShowDialog();
        }

        private void popisGostijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopisGostiju popis = new PopisGostiju();
            popis.ShowDialog();
        }
    }
}
