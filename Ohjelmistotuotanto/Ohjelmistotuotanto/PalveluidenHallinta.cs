﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmistotuotanto
{
    public partial class PalveluidenHallinta : Form
    {
        public PalveluidenHallinta()
        {
            InitializeComponent();
            //HaePalvelut();
            //HaePoistetutPalvelut();
        }

        // Siirtää valitun ei-aktiivisen palvelun palveluihin 
        public async void btnAktivoipalvelu_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();

                int selectedrowindex = dgvPoistetutpalvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPoistetutpalvelut.Rows[selectedrowindex];

                string palveluid = selectedRow.Cells["depalvelu_id"].Value.ToString();
                string toimintaalueid = selectedRow.Cells["detoimintaalue_id"].Value.ToString();
                string nimi = selectedRow.Cells["denimi"].Value.ToString();
                string tyyppi = selectedRow.Cells["detyyppi"].Value.ToString(); 
                string kuvaus = selectedRow.Cells["dekuvaus"].Value.ToString();
                string hinta = selectedRow.Cells["dehinta"].Value.ToString();
                string alv = selectedRow.Cells["dealv"].Value.ToString();

                var g = new List<KeyValuePair<string, string>>();
                g.Add(new KeyValuePair<string, string>("palvelu_id", palveluid));
                g.Add(new KeyValuePair<string, string>("toimintaalue_id", toimintaalueid));
                g.Add(new KeyValuePair<string, string>("nimi", nimi));
                g.Add(new KeyValuePair<string, string>("tyyppi", tyyppi));
                g.Add(new KeyValuePair<string, string>("kuvaus", kuvaus));
                g.Add(new KeyValuePair<string, string>("hinta", hinta));
                g.Add(new KeyValuePair<string, string>("alv", alv));

                var req = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:3002/palvelu");
                req.Content = new FormUrlEncodedContent(g);
                await client.SendAsync(req);

                var data = new List<KeyValuePair<string, string>>();
                data.Add(new KeyValuePair<string, string>("palvelu_id", palveluid));

                var req2 = new HttpRequestMessage(HttpMethod.Delete, "http://127.0.0.1:3002/poistettupalvelut");
                req2.Content = new FormUrlEncodedContent(data);
                await client.SendAsync(req2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
   
        Boolean a = false; // tämän avulla selvitetään oliko TarkastaPvm(); tulos

        // Siirtää valitun aktiivisen palvelun ei-aktiivisiin palveluihin
        public async void btnDeaktivoipalvelu_Click(object sender, EventArgs e)
        {
            //TarkastaPvm();
            //if (a == true)
            //{
                try
                {
                    HttpClient client = new HttpClient();

                    int selectedrowindex = dgvPalvelut.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvPalvelut.Rows[selectedrowindex];

                    string palveluid = selectedRow.Cells["palvelu_id"].Value.ToString();
                    string toimintaalueid = selectedRow.Cells["toimintaalue_id"].Value.ToString();
                    string nimi = selectedRow.Cells["nimi"].Value.ToString();
                    string tyyppi = selectedRow.Cells["tyyppi"].Value.ToString();
                    string kuvaus = selectedRow.Cells["kuvaus"].Value.ToString();
                    string hinta = selectedRow.Cells["hinta"].Value.ToString();
                    string alv = selectedRow.Cells["alv"].Value.ToString();

                    var g = new List<KeyValuePair<string, string>>();
                    g.Add(new KeyValuePair<string, string>("palvelu_id", palveluid));
                    g.Add(new KeyValuePair<string, string>("toimintaalue_id", toimintaalueid));
                    g.Add(new KeyValuePair<string, string>("nimi", nimi));
                    g.Add(new KeyValuePair<string, string>("tyyppi", tyyppi));
                    g.Add(new KeyValuePair<string, string>("kuvaus", kuvaus));
                    g.Add(new KeyValuePair<string, string>("hinta", hinta));
                    g.Add(new KeyValuePair<string, string>("alv", alv));

                    var req = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:3002/poistettupalvelu");
                    req.Content = new FormUrlEncodedContent(g);
                    await client.SendAsync(req);

                    var data = new List<KeyValuePair<string, string>>();
                    data.Add(new KeyValuePair<string, string>("palvelu_id", palveluid));

                    var req2 = new HttpRequestMessage(HttpMethod.Delete, "http://127.0.0.1:3002/palvelut");
                    req2.Content = new FormUrlEncodedContent(data);
                    await client.SendAsync(req2);

                    a = false;

                }
                catch (Exception ex)
                {
                    a = false;
                    MessageBox.Show(ex.Message);
                }
            /*}
            else
            {
                DialogResult result = MessageBox.Show("Et voi poistaa palvelua joka on jo varattu", "Delete", MessageBoxButtons.OK);
                a = false;
            }
            */
        }

        // Päivittää datagridviewt
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HaePalvelut();
            HaePoistetutPalvelut();
        }

        // Hakee palvelut datagridview:hen
        public void HaePalvelut()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:3002/palvelu");
            HttpResponseMessage response = client.GetAsync("palvelu").Result;
            var palvelu = response.Content.ReadAsAsync<IEnumerable<Palvelu>>().Result;
            dgvPalvelut.DataSource = palvelu;
        }

        
        // Hakee ei aktiiviset palvelut datagridview:hen
        public void HaePoistetutPalvelut()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:3002/poistettupalvelu");
            HttpResponseMessage response = client.GetAsync("poistettupalvelu").Result;
            var poistettupalvelu = response.Content.ReadAsAsync<IEnumerable<Palvelu>>().Result;
            dgvPoistetutpalvelut.DataSource = poistettupalvelu;
        }

        private void btnAktivoipalvelu_Click(object sender, EventArgs e)
        {

        }

        /*
        // Tarkastaa ettei palvelua joka on jo varattu voi poistaa käytöstä 
        public async void TarkastaPvm()
        {
            HttpClient client = new HttpClient();

            int selectedrowindex = dgvPalvelut.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPalvelut.Rows[selectedrowindex];

            string palveluid = selectedRow.Cells["palvelu_id"].Value.ToString(); // valitun alvelun id

            client.BaseAddress = new Uri("http://127.0.0.1:3002/varaus");
            HttpResponseMessage response = client.GetAsync("varaus").Result;
            var u = response.Content.ReadAsAsync<IEnumerable<Varaukset>>().Result; // tämä pitäisi saada muistiin johonkin ja tästä pitäisi erotella varattu_loppupäivä 

            client.BaseAddress = new Uri("http://127.0.0.1:3002/varauksen_palvelut");
            HttpResponseMessage response2 = client.GetAsync("varauksen_palvelut").Result; 
            var i = response.Content.ReadAsAsync<IEnumerable<???>>().Result; // <- ? // tästä varaus id ja palvelun id_v2

            // Jos palveluid ja palveluid_v2 matchaa niin pitäisi selvittää onko varattu_loppupäivä nykyisen hetken jälkeen vai ei

            if (/*Jos ajat eivät mene ristiin niin// )
            {
                a = true;
            }
            else
            { 
                a = false;
            }        
        }
        */




    }
}
