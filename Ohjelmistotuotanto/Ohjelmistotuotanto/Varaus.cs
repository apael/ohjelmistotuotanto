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

        private void AsiakkaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakkaat asiakkaat = new Asiakkaat();
            asiakkaat.ShowDialog();
        }

        private void palveluidenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta PH = new PalveluidenHallinta();
            PH.ShowDialog();
        }


        private void BtnPaivita_Click(object sender, EventArgs e)
        {
            btnPoista.Enabled = true;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:3002/varaukset");
            HttpResponseMessage response = client.GetAsync("varaukset").Result;
            var varaukset = response.Content.ReadAsAsync<IEnumerable<Varaukset>>().Result;
            dgvVaraukset.DataSource = varaukset;
        }

        private async void BtnPoista_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Haluatko varmastii poistaa valitun rivin?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {

                    int selectedrowindex = dgvVaraukset.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvVaraukset.Rows[selectedrowindex];
                    string value = selectedRow.Cells["varaus_id"].Value.ToString();


                    HttpClient client = new HttpClient();

                    var data = new List<KeyValuePair<string, string>>();
                    data.Add(new KeyValuePair<string, string>("id", value));

                    var request = new HttpRequestMessage(HttpMethod.Delete, "http://127.0.0.1:3002/varaukset");
                    request.Content = new FormUrlEncodedContent(data);
                    await client.SendAsync(request);

                    //MessageBox.Show("Poisto onnistui, päivitä nähdäksesi muutokset");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

        }


        //muuttakaa tämä funktio
        public async void BtnTallenna_ClickAsync(object sender, EventArgs e)
        {
            string enimi = tbEtunimi.Text;
            string snimi = tbSukunimi.Text;
            string sposti = tbSahkoposti.Text;
            string puhnro = tbPuhelinnumero.Text;
            string osoite = tbLahiosoite.Text;
            string postinro = tbPostinro.Text;
            string postintoimipaikka = tbToimipaikka.Text;

            HttpClient client = new HttpClient();

            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("postinro", postinro));
            data.Add(new KeyValuePair<string, string>("toimipaikka", postintoimipaikka));
            var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:3002/posti");
            request.Content = new FormUrlEncodedContent(data);
            await client.SendAsync(request);

            var data2 = new List<KeyValuePair<string, string>>();
            data2.Add(new KeyValuePair<string, string>("etunimi", enimi));
            data2.Add(new KeyValuePair<string, string>("sukunimi", snimi));
            data2.Add(new KeyValuePair<string, string>("email", sposti));
            data2.Add(new KeyValuePair<string, string>("postinro", postinro));
            data2.Add(new KeyValuePair<string, string>("puhelinnro", puhnro));
            data2.Add(new KeyValuePair<string, string>("lahiosoite", osoite));

            var request2 = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:3002/asiakkaat");
            request2.Content = new FormUrlEncodedContent(data2);
            await client.SendAsync(request2);

        }

        static async void GetAsiakkaat()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:3002/asiakkaat");

            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(response.Content.ReadAsStringAsync().Result);
                var asiakkaat = response.Content.ReadAsAsync<IEnumerable<Asiakas>>().Result;
                Debug.WriteLine("Success");
            }
            else
            {
                Debug.WriteLine("Fail");
            }
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

            var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:3002/asiakkaat");
            request.Content = new FormUrlEncodedContent(data);
            await client.SendAsync(request);
        }

       
    }
}
