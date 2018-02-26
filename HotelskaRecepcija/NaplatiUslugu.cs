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
    public partial class NaplatiUslugu : Form
    {

        public NaplatiUslugu()
        {
            InitializeComponent();

            naplataUsluge.Items.Add("SAUNA");
            naplataUsluge.Items.Add("TERETANA");
            naplataUsluge.Items.Add("SPA");
            naplataUsluge.Items.Add("MASAŽA");
            naplataUsluge.Items.Add("POSLUGA U SOBU");

            cijenaUsluge.Items.Add("100");
            cijenaUsluge.Items.Add("30");
            cijenaUsluge.Items.Add("100");
            cijenaUsluge.Items.Add("80");
            cijenaUsluge.Items.Add("50");
        }

        private void Naplati_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
                con.Open();


                string insert = "insert into HR_USLUGE (Ime, Prezime, Usluga, Cijena) values ('" + imeGostaNaplati.Text + "','" + prezimeGostaNaplati.Text + "','"
                                                        + naplataUsluge.Text + "','" + cijenaUsluge.Text + "')";

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                sda.Update(dt);
                con.Close();
                MessageBox.Show("Usluga čeka na naplatu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzdajRacun_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            int suma = 0;
            int cijena = 0;
            String ukupanIznos;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Usluga, Cijena FROM HR_USLUGE WHERE Ime=@ime AND Prezime=@prezime", con);

                cmd.Parameters.AddWithValue("@ime", imeGostaNaplati.Text);
                cmd.Parameters.AddWithValue("@prezime", prezimeGostaNaplati.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Usluga"].ToString());
                    item.SubItems.Add(dr["Cijena"].ToString());
                    ukupanIznos = dr["Cijena"].ToString();
                    cijena = Int32.Parse(ukupanIznos);
                    suma += cijena;
                    listView1.Items.Add(item);
                }

                ukupno.Text = suma.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Račun izdan");
            this.Close();
        }
    }
}
