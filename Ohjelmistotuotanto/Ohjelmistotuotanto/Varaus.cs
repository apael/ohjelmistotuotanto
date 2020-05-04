using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Web;


namespace Ohjelmistotuotanto
{
    public partial class Varaus : Form
    {

        public Varaus()
        {
            InitializeComponent();

            btnPoista.Enabled = true; //Piilotetaan alkuun muokkaus ja poisto painikkeet ja enabloidaan kun datagridviewistä on valittu jotai
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


        private void BtnPoista_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvVaraukset.CurrentCell.RowIndex;

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:3002/");
                var response = client.DeleteAsync("/asiakkaat").Result;
                if (response.IsSuccessStatusCode)
                {
                    DialogResult dialogResult = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dgvVaraukset.Rows.RemoveAt(rowIndex); //poistaa valitun rivin
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Poisto peruutettiin");
                    }

                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }
    }
}         
