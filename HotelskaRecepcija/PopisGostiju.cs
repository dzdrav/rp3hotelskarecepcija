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
    public partial class PopisGostiju : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
        public PopisGostiju()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM HR_GOSTI ORDER BY prezime ASC", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["prezime"].ToString());
                    item.SubItems.Add(dr["ime"].ToString());

                    listView1.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopisGostiju_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM HR_GOSTI ORDER BY prezime ASC", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["prezime"].ToString());
                    item.SubItems.Add(dr["ime"].ToString());

                    listView1.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}