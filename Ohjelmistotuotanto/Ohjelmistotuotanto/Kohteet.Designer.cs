namespace Ohjelmistotuotanto
{
    partial class Kohteet
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
            this.gbKohde = new System.Windows.Forms.GroupBox();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.lblHinta = new System.Windows.Forms.Label();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.lblNimi = new System.Windows.Forms.Label();
            this.dgvKohde = new System.Windows.Forms.DataGridView();
            this.kohdeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokki_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKohde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKohde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kohdeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKohde
            // 
            this.gbKohde.Controls.Add(this.btnPaivita);
            this.gbKohde.Controls.Add(this.btnPoista);
            this.gbKohde.Controls.Add(this.btnMuokkaa);
            this.gbKohde.Controls.Add(this.btnTallenna);
            this.gbKohde.Controls.Add(this.tbHinta);
            this.gbKohde.Controls.Add(this.tbHenkilomaara);
            this.gbKohde.Controls.Add(this.tbNimi);
            this.gbKohde.Controls.Add(this.lblHinta);
            this.gbKohde.Controls.Add(this.lblHenkilomaara);
            this.gbKohde.Controls.Add(this.lblNimi);
            this.gbKohde.Location = new System.Drawing.Point(13, 32);
            this.gbKohde.Name = "gbKohde";
            this.gbKohde.Size = new System.Drawing.Size(334, 174);
            this.gbKohde.TabIndex = 0;
            this.gbKohde.TabStop = false;
            this.gbKohde.Text = "Kohteen tiedot";
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(171, 145);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita.TabIndex = 9;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.BtnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(9, 145);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 8;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(90, 145);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 7;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(252, 145);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 23);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(44, 71);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(161, 20);
            this.tbHinta.TabIndex = 5;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(84, 45);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(121, 20);
            this.tbHenkilomaara.TabIndex = 4;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(39, 19);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(166, 20);
            this.tbNimi.TabIndex = 3;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(6, 74);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(32, 13);
            this.lblHinta.TabIndex = 2;
            this.lblHinta.Text = "Hinta";
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(6, 48);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(72, 13);
            this.lblHenkilomaara.TabIndex = 1;
            this.lblHenkilomaara.Text = "Henkilömäärä";
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(6, 22);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(27, 13);
            this.lblNimi.TabIndex = 0;
            this.lblNimi.Text = "Nimi";
            // 
            // dgvKohde
            // 
            this.dgvKohde.AutoGenerateColumns = false;
            this.dgvKohde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKohde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokki_id,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn});
            this.dgvKohde.DataSource = this.kohdeBindingSource;
            this.dgvKohde.Location = new System.Drawing.Point(366, 32);
            this.dgvKohde.Name = "dgvKohde";
            this.dgvKohde.Size = new System.Drawing.Size(380, 168);
            this.dgvKohde.TabIndex = 1;
            // 
            // kohdeBindingSource
            // 
            this.kohdeBindingSource.DataSource = typeof(Ohjelmistotuotanto.Kohde);
            // 
            // mokki_id
            // 
            this.mokki_id.DataPropertyName = "mokki_id";
            this.mokki_id.HeaderText = "mokki_id";
            this.mokki_id.Name = "mokki_id";
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // Kohteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKohde);
            this.Controls.Add(this.gbKohde);
            this.Name = "Kohteet";
            this.Text = "Kohteet";
            this.gbKohde.ResumeLayout(false);
            this.gbKohde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKohde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kohdeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKohde;
        private System.Windows.Forms.DataGridView dgvKohde;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.BindingSource kohdeBindingSource;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokki_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
    }
}