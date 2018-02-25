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
        private string m_connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HR_Database.mdf;" +
                "Integrated Security=True";
        private SqlConnection m_conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HR_Database.mdf;" +
                "Integrated Security=True");
        
        // konstruktor
        public PregledajSobe()
        {
            InitializeComponent();
            m_conn.Open();
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

        // gumb zatvori
        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            m_conn.Close();
            this.Close();
        }

        private void hR_SOBEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hR_SOBEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hR_DatabaseDataSet1);
        }

        // jesu li dozvoljene promjene nad sobama
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

        // provjerava dostupnost odabrane sobe na odabrani datum
        private void ButtonProvjeriDostupnost_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                try
                {
                    // pretpostavimo da je slobodna pa idemo u 'obaranje' pretpostavke
                    bool slobodna = true;
                    // SQL upit
                    // TODO - razmotri pretvaranje konekcije na bazu pomoću 'using' klauzule
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "select GOST_ID, SOBA_ID, DATUM from HR_NOCENJA",
                        Connection = m_conn
                    };
                    SqlDataAdapter myAdapter = new SqlDataAdapter();
                    myAdapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();

                    // popunjavanje dataset-a
                    myAdapter.Fill(dataSet);
                    DataTable mojaTablica = dataSet.Tables[0];

                    // je li odabrana soba zauzeta na odabrani datum
                    foreach (DataRow redak in mojaTablica.Rows)
                    {
                        if (redak["SOBA_ID"].ToString() == idTextBox.Text)
                        {
                            if (redak["DATUM"].ToString() == monthCalendar1.SelectionRange.Start.ToString())
                            {
                                // ako nađe, dakle soba je zauzeta na taj datum
                                labelDostupnost.Text = "Soba je zauzeta";
                                labelDostupnost.ForeColor = Color.DarkRed;
                                slobodna = false;
                            }
                        }
                    }
                    // ako nije zauzeta, onda je slobodna i rezervacija je moguća
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

        // prikazuje/skriva skočni kalendar
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
                buttonRezerviraj.Enabled = false;
                labelDostupnost.Text = "Dostupnost sobe";
                labelDostupnost.ForeColor = Color.Black;
            }
        }

        // rezervira sobu danom korisniku na izabrani datum 
        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection(m_connectionString))
            {
                string query = "INSERT INTO hr_nocenja (GOST_ID, SOBA_ID, DATUM, CIJENA) " +
                    "VALUES (@gostid, @sobaid, @datum, @cijena)";
                using (SqlCommand querySaveStaff = new SqlCommand(query))
                {
                    querySaveStaff.Connection = openCon;
                    // parametrizacija kao zaštita od SQL injectiona
                    querySaveStaff.Parameters.AddWithValue("@gostid", Int32.Parse(textBoxOdabraniGost.Text));
                    querySaveStaff.Parameters.AddWithValue("@sobaid", Int32.Parse(idTextBox.Text));
                    querySaveStaff.Parameters.AddWithValue("@datum", DateTime.Parse(textBoxDatum.Text));                    
                    querySaveStaff.Parameters.AddWithValue("@cijena", Convert.ToDecimal(cIJENA_NOCENJATextBox.Text));
                    openCon.Open();
                    querySaveStaff.ExecuteNonQuery();
                    MessageBox.Show("Rezervacija obavljena");
                }
            }            
        }

        // stvara formu za biranje gosta
        private void buttonBirajGosta_Click(object sender, EventArgs e)
        {
            BirajGosta forma = new BirajGosta(this);
            forma.ShowDialog();
        }

        // pretpostavit ćemo da je soba zauzeta dok ne provjerimo
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                buttonRezerviraj.Enabled = false;
                textBoxDatum.Text = monthCalendar1.SelectionStart.ToString();
                labelDostupnost.Text = "Dostupnost sobe";
                labelDostupnost.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
