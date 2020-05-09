using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


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
            //  string selected_Id = dgvVaraukset.CurrentRow.Cells[asiakas_id].Value.ToString();
            //  string selected_enimi = dgvVaraukset.CurrentRow.Cells[etunimi].Value.ToString();
            //  string selected_snimi = dgvVaraukset.CurrentRow.Cells[sukunimi].Value.ToString();
            //  string selected_email = dgvVaraukset.CurrentRow.Cells[email].Value.ToString();
            //  string selected_puhnro = dgvVaraukset.CurrentRow.Cells[puhelinnro].Value.ToString();
            // string selected_osoite = dgvVaraukset.CurrentRow.Cells[lahiosoite].Value.ToString();
            // string selected_postinro = dgvVaraukset.CurrentRow.Cells[postinro].Value.ToString();

            //  string deleteRow = "delete * from asiakas where asiakas_id = '" + selected_Id + "' AND etunimi = '"+selected_enimi+"' AND sukunimi = '"+selected_snimi+"' AND email = '"+selected_email+"' AND puhelinnro '"+selected_puhnro+"' AND lahiosoite '"+selected_osoite+"' AND postinro = '"+selected_postinro+"'";
            //  int count = DataAccess.execute(deleteRow);

            /* if (count > 0)
             {
                 MessageBox.Show("Poisto onnistui");
                 dgvVaraukset.Rows.Clear();
             }
             else
             {
                 MessageBox.Show("Poisto ei onnistunut");
             }*/


        }
        //muuttakaa tämä funktio
        public void BtnTallenna_ClickAsync(object sender, EventArgs e)
        {

            // GetAsiakkaat();
            // PostAsiakkaat();

        }

        static async void GetAsiakkaat()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:3002/asiakkaat");

            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(response.Content.ReadAsStringAsync().Result);
                Debug.WriteLine("Success");
            }
            else
            {
                Debug.WriteLine("Fail");
            }
        }

        static async void DeleteAsiakkaat()
        {
            HttpClient client = new HttpClient();

            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("id", "4"));

            var request = new HttpRequestMessage(HttpMethod.Delete, "http://127.0.0.1:3002/toimintaalue");
            request.Content = new FormUrlEncodedContent(data);
            await client.SendAsync(request);
        }

        static async void PostAsiakkaat()
        {
            HttpClient client = new HttpClient();

            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("summa", "300"));
            data.Add(new KeyValuePair<string, string>("varaus_id", "1"));
            data.Add(new KeyValuePair<string, string>("alv", "24"));
            data.Add(new KeyValuePair<string, string>("maksettu", "0"));
            data.Add(new KeyValuePair<string, string>("lasku_id", "23"));

            var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:3002/laskut");
            request.Content = new FormUrlEncodedContent(data);
            await client.SendAsync(request);
        }

    }
}
