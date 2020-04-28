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
            string selected_Id = dgvVaraukset.CurrentRow.Cells[asiakas_id].Value.ToString();
            string selected_enimi = dgvVaraukset.CurrentRow.Cells[etunimi].Value.ToString();
            string selected_snimi = dgvVaraukset.CurrentRow.Cells[sukunimi].Value.ToString();
            string selected_email = dgvVaraukset.CurrentRow.Cells[email].Value.ToString();
            string selected_puhnro = dgvVaraukset.CurrentRow.Cells[puhelinnro].Value.ToString();
            string selected_osoite = dgvVaraukset.CurrentRow.Cells[lahiosoite].Value.ToString();
            string selected_postinro = dgvVaraukset.CurrentRow.Cells[postinro].Value.ToString();

            string deleteRow = "delete * from asiakas where asiakas_id = '" + selected_Id + "' AND etunimi = '"+selected_enimi+"' AND sukunimi = '"+selected_snimi+"' AND email = '"+selected_email+"' AND puhelinnro '"+selected_puhnro+"' AND lahiosoite '"+selected_osoite+"' AND postinro = '"+selected_postinro+"'";
            int count = DataAccess.execute(deleteRow);

            if (count > 0)
            {
                MessageBox.Show("Poisto onnistui");
                dgvVaraukset.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Poisto ei onnistunut");
            }
           

        }
    }
}
