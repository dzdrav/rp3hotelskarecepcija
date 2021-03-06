﻿using System;
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
        int idG, i;
        int[] polje = new int[100];
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_database.mdf;Integrated Security=True");
        public PopisGostiju()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM HR_GOSTI", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["prezime"].ToString());
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            idG = 0;
            i = -1;

            try
            {
                SqlCommand cmdd = new SqlCommand("SELECT GOST_ID FROM HR_NOCENJA WHERE DATUM = @date", con);
                cmdd.Parameters.AddWithValue("@date", DateTime.Parse(dateTimePicker1.Text));

                SqlDataAdapter sda1 = new SqlDataAdapter(cmdd);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    idG = Int32.Parse(dr["GOST_ID"].ToString());
                    polje[++i] = idG;
                    //++i;
                }

                if (idG == 0)
                {
                    listView1.Items.Clear();
                }

                for (int j = 0; j <= i; j++)
                {
                    SqlCommand cmd = new SqlCommand("SELECT Id, ime, prezime FROM HR_GOSTI WHERE Id = @IdGost", con);
                    cmd.Parameters.AddWithValue("@IdGost", polje[j]);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(dr["Id"].ToString());
                        item.SubItems.Add(dr["prezime"].ToString());
                        item.SubItems.Add(dr["ime"].ToString());

                        listView1.Items.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}