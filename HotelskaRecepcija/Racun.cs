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
    public partial class Racun : Form
    {
        int idGosta;
        public Racun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idGosta = 0;
            float suma = 0;
            float cijena = 0;
            String ukupanIznos;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
                con.Open();

                SqlCommand cmdd = new SqlCommand("SELECT Id FROM HR_GOSTI WHERE ime=@ime AND prezime=@prezime", con);
                cmdd.Parameters.AddWithValue("@ime", imeGosta.Text);
                cmdd.Parameters.AddWithValue("@prezime", prezimeGosta.Text);

                SqlDataAdapter sda1 = new SqlDataAdapter(cmdd);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    idGosta = Int32.Parse(dr["Id"].ToString());
                    
                }

                SqlCommand cmd = new SqlCommand("SELECT DATUM, SOBA_ID,CIJENA FROM HR_NOCENJA WHERE GOST_ID = @IdGost", con);
                cmd.Parameters.AddWithValue("@IdGost", idGosta);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["DATUM"].ToString());
                    item.SubItems.Add(dr["SOBA_ID"].ToString());
                    item.SubItems.Add(dr["CIJENA"].ToString());
                    ukupanIznos = dr["CIJENA"].ToString();
                    cijena = float.Parse(ukupanIznos);
                    suma += cijena;
                    listView1.Items.Add(item);
                }

                label5.Text = suma.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idGosta == 0)
            {
                MessageBox.Show("Račun ne postoji.");
            }
            else
            {
                MessageBox.Show("Račun izdan!");
                this.Close();
            }
        }
    }
    
}
