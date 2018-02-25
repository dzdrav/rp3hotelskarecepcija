using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class PrikazUsluga : Form
    {
        Panel panel_usluge;
        DataGridView dataGridView = new DataGridView()
        {
            BackgroundColor = Color.White,
            //ScrollBars=ScrollBars.None,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
            //AutoSizeMode =DataGridViewAutoSizeColumnMode.Fill,
            //ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
            //Dock = DockStyle.Fill

        };

        public PrikazUsluga()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.ResumeLayout(false);
            this.Text = "Popis svih usluga";
            // this.PerformLayout();

            panel_usluge = new Panel() { Location = new Point(0, 20), BackColor = Color.Transparent, Size = new Size(ClientRectangle.Width, ClientRectangle.Height) };

            this.Controls.Add(panel_usluge);

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_Database.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT NAZIV_VRSTE_USLUGA, CIJENA from HR_VRSTE_USLUGA", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                panel_usluge.Controls.Add(dataGridView);

                dataGridView.DataSource = bSource;

                int height = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                    height += row.Height;
                height += dataGridView.ColumnHeadersHeight;

                int width = 0;
                foreach (DataGridViewColumn col in dataGridView.Columns)
                    width += col.Width;
                width += dataGridView.RowHeadersWidth;

                dataGridView.ClientSize = new Size(width*2, height+2);
                dataGridView.Location = new Point(0, 20);

                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
