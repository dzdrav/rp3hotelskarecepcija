using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class PregledajSobe : Form
    {
        

        public PregledajSobe()
        {
            InitializeComponent();
        }

        private void PregledajSobe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_DatabaseDataSet.HR_KARAKT_SOBA' table. You can move, or remove it, as needed.
            this.hR_KARAKT_SOBATableAdapter.Fill(this.hR_DatabaseDataSet.HR_KARAKT_SOBA);
            // TODO: This line of code loads data into the 'hR_DatabaseDataSet.HR_SOBE' table. You can move, or remove it, as needed.
            this.hR_SOBETableAdapter.Fill(this.hR_DatabaseDataSet.HR_SOBE);
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hR_SOBEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hR_SOBEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hR_DatabaseDataSet);

        }

        private void hR_SOBEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hR_SOBEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hR_DatabaseDataSet);

        }
    }
}
