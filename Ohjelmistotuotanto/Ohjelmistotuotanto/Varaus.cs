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
    public partial class Varaus : Form
    {
        public Varaus()
        {
            InitializeComponent();

            btnPoista.Enabled = false; //Piilotetaan alkuun muokkaus ja poisto painikkeet ja enabloidaan kun datagridviewistä on valittu jotai
            btnMuokkaa.Enabled = false;
        }

        private void KohteetToolStripMenuItem_Click(object sender, EventArgs e) //avaa kohteet ikkunan
        {
            Kohteet kohteet = new Kohteet();
            kohteet.ShowDialog();
        }

        private void LaskutusToolStripMenuItem_Click(object sender, EventArgs e) //avaa laskutus ikkunan
        {
            Laskutus laskutus = new Laskutus();
            laskutus.ShowDialog();
        }
    }
}
