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
        public BirajGosta()
        {
            InitializeComponent();
        }
        // alternativni konstruktor koji prima referencu na roditelja
        public BirajGosta(PregledajSobe roditeljForma)
        {
            InitializeComponent();
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
    }
}
