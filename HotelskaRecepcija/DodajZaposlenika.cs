using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class DodajZaposlenika : Form
    {
        public DodajZaposlenika()
        {
            InitializeComponent();
        }

        private void dodajNovogZaposlenika_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
                con.Open();

                string insert = "insert into OSOBLJE (Ime, Prezime, Zaduženje, Početak, Kraj, Smjena) values ('" + NovoIme.Text + "','" + NovoPrezime.Text + "','"
                                                        + NovoZaduzenje.Text + "','" + pocetakNovog.Value.ToShortDateString() + "','" 
                                                        + krajNovog.Value.ToShortDateString() + "','" + smjenaNovog.Text + "')";

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                sda.Update(dt);
                con.Close();
                MessageBox.Show("Uspješno ste dodali novog zaposlenika.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
