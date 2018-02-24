using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
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
            /*
            //String myConnString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HR_Database.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HR_Database.mdf;" +
                "Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from HR_SOBE";
            conn.Open();

            cmd.Connection = conn;*/
        }

        private void PregledajSobe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_DatabaseDataSet1.HR_SOBE' table. You can move, or remove it, as needed.
            this.hR_SOBETableAdapter.Fill(this.hR_DatabaseDataSet1.HR_SOBE);
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hR_SOBEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hR_SOBEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hR_DatabaseDataSet1);
        }

        private void checkBoxDozvoliPromjene_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDozvoliPromjene.Checked)
            {
                cIJENA_NOCENJATextBox.Enabled = true;
                aPARTMANCheckBox.Enabled = true;
                pOGLEDCheckBox.Enabled = true;
                kupaonicaCheckBox.Enabled = true;
                klimaCheckBox.Enabled = true;
                minibarCheckBox.Enabled = true;
                tvCheckBox.Enabled = true;
                telefonCheckBox.Enabled = true;
            }
            else
            {
                cIJENA_NOCENJATextBox.Enabled = false;
                aPARTMANCheckBox.Enabled = false;
                pOGLEDCheckBox.Enabled = false;
                kupaonicaCheckBox.Enabled = false;
                klimaCheckBox.Enabled = false;
                minibarCheckBox.Enabled = false;
                tvCheckBox.Enabled = false;
                telefonCheckBox.Enabled = false;
            }
            
        }
    }
}
