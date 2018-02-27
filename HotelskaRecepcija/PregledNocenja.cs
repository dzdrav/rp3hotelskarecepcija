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
    public partial class PregledNocenja : Form
    {
        public PregledNocenja()
        {
            InitializeComponent();
        }

        private void buttonPregledNocenjaZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hR_NOCENJABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hR_NOCENJABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hR_DatabaseDataSet1);

        }

        private void PregledNocenja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_DatabaseDataSet1.HR_NOCENJA' table. You can move, or remove it, as needed.
            this.hR_NOCENJATableAdapter.Fill(this.hR_DatabaseDataSet1.HR_NOCENJA);

        }

        
    }
}
