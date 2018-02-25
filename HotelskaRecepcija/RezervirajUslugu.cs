using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class RezervirajUslugu : Form
    {
        public RezervirajUslugu()
        {
            InitializeComponent();
            uslugeRezervacija.Items.Add("SAUNA");
            uslugeRezervacija.Items.Add("TERETANA");
            uslugeRezervacija.Items.Add("SPA");
            uslugeRezervacija.Items.Add("MASAŽA");
            uslugeRezervacija.Items.Add("SPOSLUGA U SOBU");
        }

        private void RezervirajUsluga_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
                con.Open();


                string insert = "insert into HR_REZERVACIJE_USLUGA (Ime, Prezime, Usluga, Datum, Termin) values ('" + imeGostaRezervacija.Text + "','" + prezimeGostaRezervacija.Text + "','"
                                                        + uslugeRezervacija.Text + "','" + datumRezervacija.Value.ToShortDateString() + "','"
                                                        +  terminRezervacija.Text + "')";

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                sda.Update(dt);
                con.Close();
                MessageBox.Show("Uspješno ste rezervirali uslugu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
