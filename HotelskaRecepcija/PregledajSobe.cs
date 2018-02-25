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
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HR_Database.mdf;" +
                "Integrated Security=True");
        public PregledajSobe()
        {
            InitializeComponent();
            conn.Open();
        }
        //svojstvo za spremanje u textboxOdabraniGost
        public string OdabraniGost
        {
            get { return textBoxOdabraniGost.Text; }
            set { textBoxOdabraniGost.Text = value; }
        }

        private void PregledajSobe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_DatabaseDataSet1.HR_SOBE' table. You can move, or remove it, as needed.
            this.hR_SOBETableAdapter.Fill(this.hR_DatabaseDataSet1.HR_SOBE);
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            conn.Close();
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

        private void ButtonProvjeriDostupnost_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                bool slobodna = true;
                try
                {
                    // SQL upit
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "select GOST_ID, SOBA_ID, DATUM from HR_NOCENJA",
                        Connection = conn
                    };
                    SqlDataAdapter myAdapter = new SqlDataAdapter();
                    myAdapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();

                    // popunjavanje dataset-a
                    myAdapter.Fill(dataSet);
                    DataTable mojaTablica = dataSet.Tables[0];

                    // provjeri nalazi li se trenutna soba na odabrani datum u HR_NOCENJA
                    //textBoxDatum.Text = "Prvi id: " + mojaTablica.Rows[0]["SOBA_ID"].ToString()
                        //+ " na datum " + mojaTablica.Rows[0]["DATUM"].ToString();
                    foreach (DataRow redak in mojaTablica.Rows)
                    {
                        if (redak["SOBA_ID"].ToString() == idTextBox.Text)
                        {
                            if (redak["DATUM"].ToString() == monthCalendar1.SelectionRange.Start.ToString())
                            {
                                buttonRezerviraj.Enabled = false;
                                labelDostupnost.Text = "Soba je zauzeta";
                                labelDostupnost.ForeColor = Color.DarkRed;
                                slobodna = false;
                            }
                        }
                    }
                    if (slobodna)
                    {
                        buttonRezerviraj.Enabled = true;
                        labelDostupnost.Text = "Soba je slobodna";
                        labelDostupnost.ForeColor = Color.DarkGreen;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati datum");
            }
                     
        }

        private void buttonBirajDatum_Click(object sender, EventArgs e)
        {
            if (!monthCalendar1.Visible)
            {
                monthCalendar1.Visible = true;
                buttonBirajDatum.Text = "Zatvori kalendar";
            }
            else
            {
                monthCalendar1.Visible = false;
                buttonBirajDatum.Text = "Biraj datum";
                buttonRezerviraj.Enabled = true;
                labelDostupnost.Text = "Dostupnost sobe";
                labelDostupnost.ForeColor = Color.Black;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                // pretpostavit ćemo da je soba slobodna dok ne nađemo rezervaciju
                buttonRezerviraj.Enabled = true;
                textBoxDatum.Text = monthCalendar1.SelectionStart.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {

        }

        private void buttonBirajGosta_Click(object sender, EventArgs e)
        {
            BirajGosta forma = new BirajGosta(this);
            forma.ShowDialog();
            //forma.DialogResult.
        }
    }
}
