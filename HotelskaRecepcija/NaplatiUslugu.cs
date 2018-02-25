using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            naplataUsluge.Items.Add("SPOSLUGA U SOBU");
        }

        
    }
}
