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
            }
        }

        private void BtnPaivita_Click(object sender, EventArgs e)
        {
            btnPoista.Enabled = true;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:3002/mokit");
            HttpResponseMessage response = client.GetAsync("mokit").Result;
            var kohde = response.Content.ReadAsAsync<IEnumerable<Kohde>>().Result;
            dgvKohde.DataSource = kohde;
        }
    }
}
