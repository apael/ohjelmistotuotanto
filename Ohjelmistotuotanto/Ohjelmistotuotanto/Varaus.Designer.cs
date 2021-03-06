﻿namespace Ohjelmistotuotanto
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
            this.components = new System.ComponentModel.Container();
            this.gbVaraus = new System.Windows.Forms.GroupBox();
            this.btnPaivita = new System.Windows.Forms.Button();
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
            this.tbToimipaikka = new System.Windows.Forms.TextBox();
            this.lblToimipaikka = new System.Windows.Forms.Label();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.lblPostinro = new System.Windows.Forms.Label();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbPuhelinnumero = new System.Windows.Forms.TextBox();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.lblPuhelin = new System.Windows.Forms.Label();
            this.lblSahkoposti = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.varaus_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakas_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokki_mokki_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattu_alkupvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattu_loppupvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varauksetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.valikkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kohteetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laskutusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakkaatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisäpalvelutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluidenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbVaraus.SuspendLayout();
            this.gbTiedot.SuspendLayout();
            this.gbLisapalvelut.SuspendLayout();
            this.gbVaraaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVaraus
            // 
            this.gbVaraus.Controls.Add(this.btnPaivita);
            this.gbVaraus.Controls.Add(this.btnPoista);
            this.gbVaraus.Controls.Add(this.btnMuokkaa);
            this.gbVaraus.Controls.Add(this.btnTallenna);
            this.gbVaraus.Controls.Add(this.gbTiedot);
            this.gbVaraus.Controls.Add(this.gbVaraaja);
            this.gbVaraus.Location = new System.Drawing.Point(12, 39);
            this.gbVaraus.Name = "gbVaraus";
            this.gbVaraus.Size = new System.Drawing.Size(609, 267);
            this.gbVaraus.TabIndex = 0;
            this.gbVaraus.TabStop = false;
            this.gbVaraus.Text = "Varaus";
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(441, 232);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita.TabIndex = 5;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.BtnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(279, 232);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 4;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(360, 232);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 3;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(522, 232);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 23);
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
            this.gbTiedot.Location = new System.Drawing.Point(313, 20);
            this.gbTiedot.Name = "gbTiedot";
            this.gbTiedot.Size = new System.Drawing.Size(290, 206);
            this.gbTiedot.TabIndex = 1;
            this.gbTiedot.TabStop = false;
            this.gbTiedot.Text = "Varauksen tiedot";
            // 
            // gbLisapalvelut
            // 
            this.gbLisapalvelut.Controls.Add(this.cbLumikenkaily);
            this.gbLisapalvelut.Controls.Add(this.cbKelkkasafari);
            this.gbLisapalvelut.Location = new System.Drawing.Point(9, 100);
            this.gbLisapalvelut.Name = "gbLisapalvelut";
            this.gbLisapalvelut.Size = new System.Drawing.Size(275, 100);
            this.gbLisapalvelut.TabIndex = 6;
            this.gbLisapalvelut.TabStop = false;
            this.gbLisapalvelut.Text = "Lisäpalvelut";
            // 
            // cbLumikenkaily
            // 
            this.cbLumikenkaily.AutoSize = true;
            this.cbLumikenkaily.Location = new System.Drawing.Point(128, 23);
            this.cbLumikenkaily.Name = "cbLumikenkaily";
            this.cbLumikenkaily.Size = new System.Drawing.Size(87, 17);
            this.cbLumikenkaily.TabIndex = 3;
            this.cbLumikenkaily.Text = "Lumikenkäily";
            this.cbLumikenkaily.UseVisualStyleBackColor = true;
            // 
            // cbKelkkasafari
            // 
            this.cbKelkkasafari.AutoSize = true;
            this.cbKelkkasafari.Location = new System.Drawing.Point(9, 22);
            this.cbKelkkasafari.Name = "cbKelkkasafari";
            this.cbKelkkasafari.Size = new System.Drawing.Size(84, 17);
            this.cbKelkkasafari.TabIndex = 2;
            this.cbKelkkasafari.Text = "Kelkkasafari";
            this.cbKelkkasafari.UseVisualStyleBackColor = true;
            // 
            // cbKohde
            // 
            this.cbKohde.FormattingEnabled = true;
            this.cbKohde.Location = new System.Drawing.Point(99, 74);
            this.cbKohde.Name = "cbKohde";
            this.cbKohde.Size = new System.Drawing.Size(185, 21);
            this.cbKohde.TabIndex = 5;
            // 
            // lblKohde
            // 
            this.lblKohde.AutoSize = true;
            this.lblKohde.Location = new System.Drawing.Point(6, 77);
            this.lblKohde.Name = "lblKohde";
            this.lblKohde.Size = new System.Drawing.Size(38, 13);
            this.lblKohde.TabIndex = 4;
            this.lblKohde.Text = "Kohde";
            // 
            // dtpLahto
            // 
            this.dtpLahto.Location = new System.Drawing.Point(99, 48);
            this.dtpLahto.Name = "dtpLahto";
            this.dtpLahto.Size = new System.Drawing.Size(185, 20);
            this.dtpLahto.TabIndex = 3;
            // 
            // lblLahto
            // 
            this.lblLahto.AutoSize = true;
            this.lblLahto.Location = new System.Drawing.Point(6, 54);
            this.lblLahto.Name = "lblLahto";
            this.lblLahto.Size = new System.Drawing.Size(92, 13);
            this.lblLahto.TabIndex = 2;
            this.lblLahto.Text = "Lähtö päivämäärä";
            // 
            // dtpTulo
            // 
            this.dtpTulo.Location = new System.Drawing.Point(99, 22);
            this.dtpTulo.Name = "dtpTulo";
            this.dtpTulo.Size = new System.Drawing.Size(185, 20);
            this.dtpTulo.TabIndex = 1;
            // 
            // lblTulo
            // 
            this.lblTulo.AutoSize = true;
            this.lblTulo.Location = new System.Drawing.Point(6, 28);
            this.lblTulo.Name = "lblTulo";
            this.lblTulo.Size = new System.Drawing.Size(86, 13);
            this.lblTulo.TabIndex = 0;
            this.lblTulo.Text = "Tulo päivämäärä";
            // 
            // gbVaraaja
            // 
            this.gbVaraaja.Controls.Add(this.tbToimipaikka);
            this.gbVaraaja.Controls.Add(this.lblToimipaikka);
            this.gbVaraaja.Controls.Add(this.tbPostinro);
            this.gbVaraaja.Controls.Add(this.lblPostinro);
            this.gbVaraaja.Controls.Add(this.tbLahiosoite);
            this.gbVaraaja.Controls.Add(this.tbPuhelinnumero);
            this.gbVaraaja.Controls.Add(this.tbSahkoposti);
            this.gbVaraaja.Controls.Add(this.tbSukunimi);
            this.gbVaraaja.Controls.Add(this.tbEtunimi);
            this.gbVaraaja.Controls.Add(this.lblLahiosoite);
            this.gbVaraaja.Controls.Add(this.lblPuhelin);
            this.gbVaraaja.Controls.Add(this.lblSahkoposti);
            this.gbVaraaja.Controls.Add(this.lblSukunimi);
            this.gbVaraaja.Controls.Add(this.lblEtunimi);
            this.gbVaraaja.Location = new System.Drawing.Point(7, 20);
            this.gbVaraaja.Name = "gbVaraaja";
            this.gbVaraaja.Size = new System.Drawing.Size(290, 206);
            this.gbVaraaja.TabIndex = 0;
            this.gbVaraaja.TabStop = false;
            this.gbVaraaja.Text = "Varaaja";
            // 
            // tbToimipaikka
            // 
            this.tbToimipaikka.Location = new System.Drawing.Point(89, 175);
            this.tbToimipaikka.Name = "tbToimipaikka";
            this.tbToimipaikka.Size = new System.Drawing.Size(195, 20);
            this.tbToimipaikka.TabIndex = 12;
            // 
            // lblToimipaikka
            // 
            this.lblToimipaikka.AutoSize = true;
            this.lblToimipaikka.Location = new System.Drawing.Point(6, 178);
            this.lblToimipaikka.Name = "lblToimipaikka";
            this.lblToimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblToimipaikka.TabIndex = 11;
            this.lblToimipaikka.Text = "Postitoimipaikka";
            // 
            // tbPostinro
            // 
            this.tbPostinro.Location = new System.Drawing.Point(89, 149);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(195, 20);
            this.tbPostinro.TabIndex = 10;
            // 
            // lblPostinro
            // 
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Location = new System.Drawing.Point(6, 153);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(65, 13);
            this.lblPostinro.TabIndex = 6;
            this.lblPostinro.Text = "Postinumero";
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(89, 123);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(195, 20);
            this.tbLahiosoite.TabIndex = 9;
            // 
            // tbPuhelinnumero
            // 
            this.tbPuhelinnumero.Location = new System.Drawing.Point(89, 97);
            this.tbPuhelinnumero.Name = "tbPuhelinnumero";
            this.tbPuhelinnumero.Size = new System.Drawing.Size(195, 20);
            this.tbPuhelinnumero.TabIndex = 8;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(89, 71);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(195, 20);
            this.tbSahkoposti.TabIndex = 7;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(89, 45);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(195, 20);
            this.tbSukunimi.TabIndex = 6;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(89, 19);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(195, 20);
            this.tbEtunimi.TabIndex = 5;
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Location = new System.Drawing.Point(6, 126);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(55, 13);
            this.lblLahiosoite.TabIndex = 4;
            this.lblLahiosoite.Text = "Lahiosoite";
            // 
            // lblPuhelin
            // 
            this.lblPuhelin.AutoSize = true;
            this.lblPuhelin.Location = new System.Drawing.Point(6, 100);
            this.lblPuhelin.Name = "lblPuhelin";
            this.lblPuhelin.Size = new System.Drawing.Size(77, 13);
            this.lblPuhelin.TabIndex = 3;
            this.lblPuhelin.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            this.lblSahkoposti.AutoSize = true;
            this.lblSahkoposti.Location = new System.Drawing.Point(6, 74);
            this.lblSahkoposti.Name = "lblSahkoposti";
            this.lblSahkoposti.Size = new System.Drawing.Size(60, 13);
            this.lblSahkoposti.TabIndex = 2;
            this.lblSahkoposti.Text = "Sähköposti";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(6, 48);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 1;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(6, 22);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lblEtunimi.TabIndex = 0;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.AutoGenerateColumns = false;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varaus_id,
            this.asiakas_id,
            this.mokki_mokki_id,
            this.varattu_alkupvm,
            this.varattu_loppupvm,
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dgvVaraukset.DataSource = this.varauksetBindingSource;
            this.dgvVaraukset.Location = new System.Drawing.Point(627, 42);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(303, 217);
            this.dgvVaraukset.TabIndex = 1;
            // 
            // varaus_id
            // 
            this.varaus_id.DataPropertyName = "varaus_id";
            this.varaus_id.HeaderText = "varaus_id";
            this.varaus_id.Name = "varaus_id";
            // 
            // asiakas_id
            // 
            this.asiakas_id.DataPropertyName = "asiakas_id";
            this.asiakas_id.HeaderText = "asiakas_id";
            this.asiakas_id.Name = "asiakas_id";
            // 
            // mokki_mokki_id
            // 
            this.mokki_mokki_id.DataPropertyName = "mokki_mokki_id";
            this.mokki_mokki_id.HeaderText = "mokki_mokki_id";
            this.mokki_mokki_id.Name = "mokki_mokki_id";
            // 
            // varattu_alkupvm
            // 
            this.varattu_alkupvm.DataPropertyName = "varattu_alkupvm";
            this.varattu_alkupvm.HeaderText = "varattu_alkupvm";
            this.varattu_alkupvm.Name = "varattu_alkupvm";
            // 
            // varattu_loppupvm
            // 
            this.varattu_loppupvm.DataPropertyName = "varattu_loppupvm";
            this.varattu_loppupvm.HeaderText = "varattu_loppupvm";
            this.varattu_loppupvm.Name = "varattu_loppupvm";
            // 
            // varauksetBindingSource
            // 
            this.varauksetBindingSource.DataSource = typeof(Ohjelmistotuotanto.Varaukset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Muokkaa ja poista painikkeet piiloon aluksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "datagridview varauksia varten";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valikkoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // valikkoToolStripMenuItem
            // 
            this.valikkoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kohteetToolStripMenuItem,
            this.laskutusToolStripMenuItem,
            this.asiakkaatToolStripMenuItem,
            this.lisäpalvelutToolStripMenuItem,
            this.palveluidenHallintaToolStripMenuItem});
            this.valikkoToolStripMenuItem.Name = "valikkoToolStripMenuItem";
            this.valikkoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.valikkoToolStripMenuItem.Text = "Valikko";
            // 
            // kohteetToolStripMenuItem
            // 
            this.kohteetToolStripMenuItem.Name = "kohteetToolStripMenuItem";
            this.kohteetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kohteetToolStripMenuItem.Text = "Kohteet";
            this.kohteetToolStripMenuItem.Click += new System.EventHandler(this.KohteetToolStripMenuItem_Click);
            // 
            // laskutusToolStripMenuItem
            // 
            this.laskutusToolStripMenuItem.Name = "laskutusToolStripMenuItem";
            this.laskutusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.laskutusToolStripMenuItem.Text = "Laskutus";
            this.laskutusToolStripMenuItem.Click += new System.EventHandler(this.LaskutusToolStripMenuItem_Click);
            // 
            // asiakkaatToolStripMenuItem
            // 
            this.asiakkaatToolStripMenuItem.Name = "asiakkaatToolStripMenuItem";
            this.asiakkaatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asiakkaatToolStripMenuItem.Text = "Asiakkaat";
            this.asiakkaatToolStripMenuItem.Click += new System.EventHandler(this.AsiakkaatToolStripMenuItem_Click);
            // 
            // lisäpalvelutToolStripMenuItem
            // 
            this.lisäpalvelutToolStripMenuItem.Name = "lisäpalvelutToolStripMenuItem";
            this.lisäpalvelutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lisäpalvelutToolStripMenuItem.Text = "Lisäpalvelut?";
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataSource = typeof(Ohjelmistotuotanto.Asiakas);
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // palveluidenHallintaToolStripMenuItem
            // 
            this.palveluidenHallintaToolStripMenuItem.Name = "palveluidenHallintaToolStripMenuItem";
            this.palveluidenHallintaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.palveluidenHallintaToolStripMenuItem.Text = "Palveluiden hallinta";
            this.palveluidenHallintaToolStripMenuItem.Click += new System.EventHandler(this.palveluidenHallintaToolStripMenuItem_Click);
            // 
            // Varaus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.gbVaraus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Varaus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varaus";
            this.gbVaraus.ResumeLayout(false);
            this.gbTiedot.ResumeLayout(false);
            this.gbTiedot.PerformLayout();
            this.gbLisapalvelut.ResumeLayout(false);
            this.gbLisapalvelut.PerformLayout();
            this.gbVaraaja.ResumeLayout(false);
            this.gbVaraaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbPuhelinnumero;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label lblLahiosoite;
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
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.BindingSource varauksetBindingSource;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.Label lblPostinro;
        private System.Windows.Forms.TextBox tbToimipaikka;
        private System.Windows.Forms.Label lblToimipaikka;
        private System.Windows.Forms.DataGridViewTextBoxColumn varaus_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakas_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokki_mokki_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattu_alkupvm;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattu_loppupvm;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem palveluidenHallintaToolStripMenuItem;
    }
}

