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
    public partial class BirajGosta : Form
    {
        // ovdje spremamo ID odabranog korisnika
        private string m_odabraniID;
        PregledajSobe m_roditelj = null;

        public BirajGosta()
        {
            InitializeComponent();
        }

        // alternativni konstruktor koji prima referencu na roditelja
        public BirajGosta(PregledajSobe roditeljForma)
        {
            InitializeComponent();
            m_roditelj = roditeljForma;
            m_odabraniID = "0";
        }

        private void hR_GOSTIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hR_GOSTIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hR_DatabaseDataSet1);

        }

        private void BirajGosta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_DatabaseDataSet1.HR_GOSTI' table. You can move, or remove it, as needed.
            this.hR_GOSTITableAdapter.Fill(this.hR_DatabaseDataSet1.HR_GOSTI);

        }

        // zatvara formu i odustaje od odabnira
        private void buttonBirajGostaZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // pri promjeni odabranog retka, spremi ID odabranog korisnika u privatnu var. članicu
        private void hR_GOSTIDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow odabraniRedak = hR_GOSTIDataGridView.SelectedRows[0];
            m_odabraniID = odabraniRedak.Cells[0].Value.ToString();
        }

        // pri zatvaranju forme pomoću OK, proslijedi ID odabranog gosta u roditeljsku formu
        private void buttonBirajGostaOK_Click(object sender, EventArgs e)
        {
            m_roditelj.OdabraniGost = m_odabraniID;
            this.Close();
        }

        // dupli klik na redak radi isto što i gumb OK
        private void hR_GOSTIDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_roditelj.OdabraniGost = m_odabraniID;
            this.Close();
        }
    }
}
