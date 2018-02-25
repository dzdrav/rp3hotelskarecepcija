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
    public partial class novoZaduzenje : Form
    {
        public novoZaduzenje()
        {
            InitializeComponent();
        }

        private void izmjena_Click(object sender, EventArgs e)
        {
            string ime = imeIzmjena.Text;
            string prezime = prezimeIzmjena.Text;
            string zaduzenje = zaduzenjeIzmjena.Text;
            string od = pocetak.Value.ToShortDateString();
            string kraj = krajZaduz.Value.ToShortDateString();
            string smjena = smjenaIzmjena.Text;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
                con.Open();

<<<<<<< HEAD:HotelskaRecepcija/DodajZaduzenje.cs
                string update = " UPDATE HR_OSOBLJE SET Zaduženje=@zaduzenje, " +
=======
                string update = " UPDATE Osoblje SET Zaduženje=@zaduzenje, " +
>>>>>>> osoblje:HotelskaRecepcija/novoZaduzenje.cs
                    " Početak=@pocetak, " + " Kraj=@kraj, " + " Smjena=@smjena WHERE Ime=@ime AND Prezime=@prezime";
                SqlCommand cmd = new SqlCommand(update, con);

                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@zaduzenje", zaduzenje);
                cmd.Parameters.AddWithValue("@pocetak", od);
                cmd.Parameters.AddWithValue("@kraj", kraj);
                cmd.Parameters.AddWithValue("@smjena", smjena);

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();

                cmd.ExecuteNonQuery();
                sda.Update(dt);
                con.Close();
                MessageBox.Show("Uspješno ste izmijenili zaduženje.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
