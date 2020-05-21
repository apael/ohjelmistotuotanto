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
    public partial class Kohteet : Form
    {
        public Kohteet()
        {
            InitializeComponent();
           
            btnMuokkaa.Enabled = false; //Piilotetaan alkuun muokkaus ja poisto painikkeet ja enabloidaan kun datagridviewistä on valittu jotai
            btnPoista.Enabled = false;
            haeTiedot();
        }
        
        private async void haeTiedot()
        {
            btnPoista.Enabled = true;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:3002/mokit");
            HttpResponseMessage response = client.GetAsync("mokit").Result;
            var kohde = response.Content.ReadAsAsync<IEnumerable<Kohde>>().Result;
            dgvKohde.DataSource = kohde;
        }
        private async void BtnPoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmastii poistaa valitun rivin?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int selectedrowindex = dgvKohde.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvKohde.Rows[selectedrowindex];
                    string value = selectedRow.Cells["mokki_id"].Value.ToString();

                    HttpClient client = new HttpClient();

                    var data = new List<KeyValuePair<string, string>>();
                    data.Add(new KeyValuePair<string, string>("id", value));

                    var request = new HttpRequestMessage(HttpMethod.Delete, "http://127.0.0.1:3002/mokit");
                    request.Content = new FormUrlEncodedContent(data);
                    await client.SendAsync(request);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                BtnPaivita_Click(sender, e);
            }
        }

        private void BtnPaivita_Click(object sender, EventArgs e)
        {
            haeTiedot();
        }

        private async void btnTallenna_Click(object sender, EventArgs e)
        {
            string mokkinimi = tbNimi.Text;
            string henkilomaara = tbNimi.Text;

            HttpClient client = new HttpClient();

            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("mokkinimi", mokkinimi));
            data.Add(new KeyValuePair<string, string>("henkilomaara", henkilomaara));
            data.Add(new KeyValuePair<string, string>("toimintaalue_id", "1"));
            data.Add(new KeyValuePair<string, string>("postinro", "55500"));
            data.Add(new KeyValuePair<string, string>("katuosoite", "mokkitie 1"));
            data.Add(new KeyValuePair<string, string>("kuvaus", "sturdy"));
            data.Add(new KeyValuePair<string, string>("varustelu", "takka"));


            var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:3002/mokit");
            request.Content = new FormUrlEncodedContent(data);
            await client.SendAsync(request);

            haeTiedot();
        }
    }
}
