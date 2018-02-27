using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelskaRecepcija
{
    public partial class DodajNovogGostaForm : Form
    {
        
        public DodajNovogGostaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text != "" & textBoxPrezime.Text != "" & comboBox1.SelectedIndex > -1)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO HR_GOSTI (ime, prezime, SPOL) VALUES ('" + textBoxIme.Text + "', '" + textBoxPrezime.Text + "', '" + comboBox1.SelectedItem.ToString() + "') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Osoba je dodana");
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
