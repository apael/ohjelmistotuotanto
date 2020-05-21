namespace Ohjelmistotuotanto
{
    partial class Varaus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbVaraus = new System.Windows.Forms.GroupBox();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.gbTiedot = new System.Windows.Forms.GroupBox();
            this.gbLisapalvelut = new System.Windows.Forms.GroupBox();
            this.cbLumikenkaily = new System.Windows.Forms.CheckBox();
            this.cbKelkkasafari = new System.Windows.Forms.CheckBox();
            this.cbKohde = new System.Windows.Forms.ComboBox();
            this.lblKohde = new System.Windows.Forms.Label();
            this.dtpLahto = new System.Windows.Forms.DateTimePicker();
            this.lblLahto = new System.Windows.Forms.Label();
            this.dtpTulo = new System.Windows.Forms.DateTimePicker();
            this.lblTulo = new System.Windows.Forms.Label();
            this.gbVaraaja = new System.Windows.Forms.GroupBox();
            this.tbKommentti = new System.Windows.Forms.TextBox();
            this.tbPuhelinnumero = new System.Windows.Forms.TextBox();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.lblKommentti = new System.Windows.Forms.Label();
            this.lblPuhelin = new System.Windows.Forms.Label();
            this.lblSahkoposti = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.valikkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kohteetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laskutusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakkaatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisäpalvelutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbVaraus.SuspendLayout();
            this.gbTiedot.SuspendLayout();
            this.gbLisapalvelut.SuspendLayout();
            this.gbVaraaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVaraus
            // 
            this.gbVaraus.Controls.Add(this.btnPoista);
            this.gbVaraus.Controls.Add(this.btnMuokkaa);
            this.gbVaraus.Controls.Add(this.btnTallenna);
            this.gbVaraus.Controls.Add(this.gbTiedot);
            this.gbVaraus.Controls.Add(this.gbVaraaja);
            this.gbVaraus.Location = new System.Drawing.Point(16, 48);
            this.gbVaraus.Margin = new System.Windows.Forms.Padding(4);
            this.gbVaraus.Name = "gbVaraus";
            this.gbVaraus.Padding = new System.Windows.Forms.Padding(4);
            this.gbVaraus.Size = new System.Drawing.Size(812, 329);
            this.gbVaraus.TabIndex = 0;
            this.gbVaraus.TabStop = false;
            this.gbVaraus.Text = "Varaus";
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(480, 287);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(100, 28);
            this.btnPoista.TabIndex = 4;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(588, 287);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(100, 28);
            this.btnMuokkaa.TabIndex = 3;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(696, 286);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(4);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(100, 28);
            this.btnTallenna.TabIndex = 2;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.BtnTallenna_ClickAsync);
            // 
            // gbTiedot
            // 
            this.gbTiedot.Controls.Add(this.gbLisapalvelut);
            this.gbTiedot.Controls.Add(this.cbKohde);
            this.gbTiedot.Controls.Add(this.lblKohde);
            this.gbTiedot.Controls.Add(this.dtpLahto);
            this.gbTiedot.Controls.Add(this.lblLahto);
            this.gbTiedot.Controls.Add(this.dtpTulo);
            this.gbTiedot.Controls.Add(this.lblTulo);
            this.gbTiedot.Location = new System.Drawing.Point(417, 25);
            this.gbTiedot.Margin = new System.Windows.Forms.Padding(4);
            this.gbTiedot.Name = "gbTiedot";
            this.gbTiedot.Padding = new System.Windows.Forms.Padding(4);
            this.gbTiedot.Size = new System.Drawing.Size(387, 254);
            this.gbTiedot.TabIndex = 1;
            this.gbTiedot.TabStop = false;
            this.gbTiedot.Text = "Varauksen tiedot";
            // 
            // gbLisapalvelut
            // 
            this.gbLisapalvelut.Controls.Add(this.cbLumikenkaily);
            this.gbLisapalvelut.Controls.Add(this.cbKelkkasafari);
            this.gbLisapalvelut.Location = new System.Drawing.Point(12, 123);
            this.gbLisapalvelut.Margin = new System.Windows.Forms.Padding(4);
            this.gbLisapalvelut.Name = "gbLisapalvelut";
            this.gbLisapalvelut.Padding = new System.Windows.Forms.Padding(4);
            this.gbLisapalvelut.Size = new System.Drawing.Size(367, 123);
            this.gbLisapalvelut.TabIndex = 6;
            this.gbLisapalvelut.TabStop = false;
            this.gbLisapalvelut.Text = "Lisäpalvelut";
            // 
            // cbLumikenkaily
            // 
            this.cbLumikenkaily.AutoSize = true;
            this.cbLumikenkaily.Location = new System.Drawing.Point(171, 28);
            this.cbLumikenkaily.Margin = new System.Windows.Forms.Padding(4);
            this.cbLumikenkaily.Name = "cbLumikenkaily";
            this.cbLumikenkaily.Size = new System.Drawing.Size(111, 21);
            this.cbLumikenkaily.TabIndex = 3;
            this.cbLumikenkaily.Text = "Lumikenkäily";
            this.cbLumikenkaily.UseVisualStyleBackColor = true;
            // 
            // cbKelkkasafari
            // 
            this.cbKelkkasafari.AutoSize = true;
            this.cbKelkkasafari.Location = new System.Drawing.Point(12, 27);
            this.cbKelkkasafari.Margin = new System.Windows.Forms.Padding(4);
            this.cbKelkkasafari.Name = "cbKelkkasafari";
            this.cbKelkkasafari.Size = new System.Drawing.Size(107, 21);
            this.cbKelkkasafari.TabIndex = 2;
            this.cbKelkkasafari.Text = "Kelkkasafari";
            this.cbKelkkasafari.UseVisualStyleBackColor = true;
            // 
            // cbKohde
            // 
            this.cbKohde.FormattingEnabled = true;
            this.cbKohde.Location = new System.Drawing.Point(132, 91);
            this.cbKohde.Margin = new System.Windows.Forms.Padding(4);
            this.cbKohde.Name = "cbKohde";
            this.cbKohde.Size = new System.Drawing.Size(245, 24);
            this.cbKohde.TabIndex = 5;
            // 
            // lblKohde
            // 
            this.lblKohde.AutoSize = true;
            this.lblKohde.Location = new System.Drawing.Point(8, 95);
            this.lblKohde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKohde.Name = "lblKohde";
            this.lblKohde.Size = new System.Drawing.Size(49, 17);
            this.lblKohde.TabIndex = 4;
            this.lblKohde.Text = "Kohde";
            // 
            // dtpLahto
            // 
            this.dtpLahto.Location = new System.Drawing.Point(132, 59);
            this.dtpLahto.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLahto.Name = "dtpLahto";
            this.dtpLahto.Size = new System.Drawing.Size(245, 22);
            this.dtpLahto.TabIndex = 3;
            // 
            // lblLahto
            // 
            this.lblLahto.AutoSize = true;
            this.lblLahto.Location = new System.Drawing.Point(8, 66);
            this.lblLahto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLahto.Name = "lblLahto";
            this.lblLahto.Size = new System.Drawing.Size(122, 17);
            this.lblLahto.TabIndex = 2;
            this.lblLahto.Text = "Lähtö päivämäärä";
            // 
            // dtpTulo
            // 
            this.dtpTulo.Location = new System.Drawing.Point(132, 27);
            this.dtpTulo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTulo.Name = "dtpTulo";
            this.dtpTulo.Size = new System.Drawing.Size(245, 22);
            this.dtpTulo.TabIndex = 1;
            // 
            // lblTulo
            // 
            this.lblTulo.AutoSize = true;
            this.lblTulo.Location = new System.Drawing.Point(8, 34);
            this.lblTulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTulo.Name = "lblTulo";
            this.lblTulo.Size = new System.Drawing.Size(114, 17);
            this.lblTulo.TabIndex = 0;
            this.lblTulo.Text = "Tulo päivämäärä";
            // 
            // gbVaraaja
            // 
            this.gbVaraaja.Controls.Add(this.tbKommentti);
            this.gbVaraaja.Controls.Add(this.tbPuhelinnumero);
            this.gbVaraaja.Controls.Add(this.tbSahkoposti);
            this.gbVaraaja.Controls.Add(this.tbSukunimi);
            this.gbVaraaja.Controls.Add(this.tbEtunimi);
            this.gbVaraaja.Controls.Add(this.lblKommentti);
            this.gbVaraaja.Controls.Add(this.lblPuhelin);
            this.gbVaraaja.Controls.Add(this.lblSahkoposti);
            this.gbVaraaja.Controls.Add(this.lblSukunimi);
            this.gbVaraaja.Controls.Add(this.lblEtunimi);
            this.gbVaraaja.Location = new System.Drawing.Point(9, 25);
            this.gbVaraaja.Margin = new System.Windows.Forms.Padding(4);
            this.gbVaraaja.Name = "gbVaraaja";
            this.gbVaraaja.Padding = new System.Windows.Forms.Padding(4);
            this.gbVaraaja.Size = new System.Drawing.Size(387, 254);
            this.gbVaraaja.TabIndex = 0;
            this.gbVaraaja.TabStop = false;
            this.gbVaraaja.Text = "Varaaja";
            // 
            // tbKommentti
            // 
            this.tbKommentti.Location = new System.Drawing.Point(119, 151);
            this.tbKommentti.Margin = new System.Windows.Forms.Padding(4);
            this.tbKommentti.Name = "tbKommentti";
            this.tbKommentti.Size = new System.Drawing.Size(259, 22);
            this.tbKommentti.TabIndex = 9;
            // 
            // tbPuhelinnumero
            // 
            this.tbPuhelinnumero.Location = new System.Drawing.Point(119, 119);
            this.tbPuhelinnumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbPuhelinnumero.Name = "tbPuhelinnumero";
            this.tbPuhelinnumero.Size = new System.Drawing.Size(259, 22);
            this.tbPuhelinnumero.TabIndex = 8;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(119, 87);
            this.tbSahkoposti.Margin = new System.Windows.Forms.Padding(4);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(259, 22);
            this.tbSahkoposti.TabIndex = 7;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(119, 55);
            this.tbSukunimi.Margin = new System.Windows.Forms.Padding(4);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(259, 22);
            this.tbSukunimi.TabIndex = 6;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(119, 23);
            this.tbEtunimi.Margin = new System.Windows.Forms.Padding(4);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(259, 22);
            this.tbEtunimi.TabIndex = 5;
            // 
            // lblKommentti
            // 
            this.lblKommentti.AutoSize = true;
            this.lblKommentti.Location = new System.Drawing.Point(8, 155);
            this.lblKommentti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKommentti.Name = "lblKommentti";
            this.lblKommentti.Size = new System.Drawing.Size(74, 17);
            this.lblKommentti.TabIndex = 4;
            this.lblKommentti.Text = "Kommentti";
            // 
            // lblPuhelin
            // 
            this.lblPuhelin.AutoSize = true;
            this.lblPuhelin.Location = new System.Drawing.Point(8, 123);
            this.lblPuhelin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuhelin.Name = "lblPuhelin";
            this.lblPuhelin.Size = new System.Drawing.Size(103, 17);
            this.lblPuhelin.TabIndex = 3;
            this.lblPuhelin.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            this.lblSahkoposti.AutoSize = true;
            this.lblSahkoposti.Location = new System.Drawing.Point(8, 91);
            this.lblSahkoposti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSahkoposti.Name = "lblSahkoposti";
            this.lblSahkoposti.Size = new System.Drawing.Size(78, 17);
            this.lblSahkoposti.TabIndex = 2;
            this.lblSahkoposti.Text = "Sähköposti";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(8, 59);
            this.lblSukunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(65, 17);
            this.lblSukunimi.TabIndex = 1;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(8, 27);
            this.lblEtunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(54, 17);
            this.lblEtunimi.TabIndex = 0;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(836, 52);
            this.dgvVaraukset.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.RowHeadersWidth = 51;
            this.dgvVaraukset.Size = new System.Drawing.Size(404, 267);
            this.dgvVaraukset.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Muokkaa ja poista painikkeet piiloon aluksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "datagridview varauksia varten";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valikkoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // valikkoToolStripMenuItem
            // 
            this.valikkoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kohteetToolStripMenuItem,
            this.laskutusToolStripMenuItem,
            this.asiakkaatToolStripMenuItem,
            this.lisäpalvelutToolStripMenuItem});
            this.valikkoToolStripMenuItem.Name = "valikkoToolStripMenuItem";
            this.valikkoToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.valikkoToolStripMenuItem.Text = "Valikko";
            // 
            // kohteetToolStripMenuItem
            // 
            this.kohteetToolStripMenuItem.Name = "kohteetToolStripMenuItem";
            this.kohteetToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.kohteetToolStripMenuItem.Text = "Kohteet";
            this.kohteetToolStripMenuItem.Click += new System.EventHandler(this.KohteetToolStripMenuItem_Click);
            // 
            // laskutusToolStripMenuItem
            // 
            this.laskutusToolStripMenuItem.Name = "laskutusToolStripMenuItem";
            this.laskutusToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.laskutusToolStripMenuItem.Text = "Laskutus";
            this.laskutusToolStripMenuItem.Click += new System.EventHandler(this.LaskutusToolStripMenuItem_Click);
            // 
            // asiakkaatToolStripMenuItem
            // 
            this.asiakkaatToolStripMenuItem.Name = "asiakkaatToolStripMenuItem";
            this.asiakkaatToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.asiakkaatToolStripMenuItem.Text = "Asiakkaat?";
            // 
            // lisäpalvelutToolStripMenuItem
            // 
            this.lisäpalvelutToolStripMenuItem.Name = "lisäpalvelutToolStripMenuItem";
            this.lisäpalvelutToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.lisäpalvelutToolStripMenuItem.Text = "Lisäpalvelut?";
            // 
            // Varaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.gbVaraus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Varaus";
            this.Text = "Varaus";
            this.gbVaraus.ResumeLayout(false);
            this.gbTiedot.ResumeLayout(false);
            this.gbTiedot.PerformLayout();
            this.gbLisapalvelut.ResumeLayout(false);
            this.gbLisapalvelut.PerformLayout();
            this.gbVaraaja.ResumeLayout(false);
            this.gbVaraaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVaraus;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.GroupBox gbTiedot;
        private System.Windows.Forms.GroupBox gbLisapalvelut;
        private System.Windows.Forms.CheckBox cbLumikenkaily;
        private System.Windows.Forms.CheckBox cbKelkkasafari;
        private System.Windows.Forms.ComboBox cbKohde;
        private System.Windows.Forms.Label lblKohde;
        private System.Windows.Forms.DateTimePicker dtpLahto;
        private System.Windows.Forms.Label lblLahto;
        private System.Windows.Forms.DateTimePicker dtpTulo;
        private System.Windows.Forms.Label lblTulo;
        private System.Windows.Forms.GroupBox gbVaraaja;
        private System.Windows.Forms.TextBox tbKommentti;
        private System.Windows.Forms.TextBox tbPuhelinnumero;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label lblKommentti;
        private System.Windows.Forms.Label lblPuhelin;
        private System.Windows.Forms.Label lblSahkoposti;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem valikkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kohteetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laskutusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiakkaatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisäpalvelutToolStripMenuItem;
    }
}

