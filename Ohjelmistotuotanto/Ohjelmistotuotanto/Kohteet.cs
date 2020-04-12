using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmistotuotanto
{
    public partial class Kohteet : Form
    {
        public Kohteet()
        {
            InitializeComponent();

            btnMuokkaa.Enabled = false; //Piilotetaan alkuun muokkaus ja poisto painikkeet ja enabloidaan kun datagridviewistä on valittu jotai
            btnPoista.Enabled = false;
        }
    }
}
