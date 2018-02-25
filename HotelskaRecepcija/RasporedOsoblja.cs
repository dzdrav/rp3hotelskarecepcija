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
    public partial class RasporedOsoblja : Form
    {
        Panel panel_osoblje;
        DataGridView dataGridView = new DataGridView()
        {
            BackgroundColor = Color.White,
            //ScrollBars=ScrollBars.None,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
            AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells,
            //AutoSizeMode =DataGridViewAutoSizeColumnMode.Fill,
            //ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
            //Dock = DockStyle.Fill

        };

        public RasporedOsoblja()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
           // this.PerformLayout();

            panel_osoblje = new Panel() { Location = new Point(0, 20), BackColor = Color.Transparent, Size = new Size(ClientRectangle.Width, ClientRectangle.Height) };

            this.Controls.Add(panel_osoblje);

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HR_Database.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Osoblje", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                panel_osoblje.Controls.Add(dataGridView);

                dataGridView.DataSource = bSource;

                int height = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                    height += row.Height;
                height += dataGridView.ColumnHeadersHeight;

                int width = 0;
                foreach (DataGridViewColumn col in dataGridView.Columns)
                    width += col.Width;
                width += dataGridView.RowHeadersWidth;

                dataGridView.ClientSize = new Size(width, height);
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
