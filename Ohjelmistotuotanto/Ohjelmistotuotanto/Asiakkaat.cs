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
    public partial class Asiakkaat : Form
    {
        public Asiakkaat()
        {
            InitializeComponent();
            btnPoista.Enabled = false;
        }

        private void BtnPaivita_Click(object sender, EventArgs e)
        {
            btnPoista.Enabled = true;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:3002/asiakkaat");
            HttpResponseMessage response = client.GetAsync("asiakkaat").Result;
            var asiakkaat = response.Content.ReadAsAsync<IEnumerable<Asiakas>>().Result;
            dgvAsiakkaat.DataSource = asiakkaat;
        }

        private async void BtnPoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmastii poistaa valitun asiakkaan?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int selectedrowindex = dgvAsiakkaat.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAsiakkaat.Rows[selectedrowindex];
                    string value = selectedRow.Cells["asiakas_id"].Value.ToString();

                    HttpClient client = new HttpClient();

                    var data = new List<KeyValuePair<string, string>>();
                    data.Add(new KeyValuePair<string, string>("id", value));

                    var request = new HttpRequestMessage(HttpMethod.Delete, "http://127.0.0.1:3002/asiakkaat");
                    request.Content = new FormUrlEncodedContent(data);
                    await client.SendAsync(request);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    

            }
        }
    }
}
