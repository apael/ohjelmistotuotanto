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
            this.mokki_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kohdeBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.gbKohde.Location = new System.Drawing.Point(17, 39);
            this.gbKohde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKohde.Name = "gbKohde";
            this.gbKohde.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKohde.Size = new System.Drawing.Size(445, 214);
            this.gbKohde.TabIndex = 0;
            this.gbKohde.TabStop = false;
            this.gbKohde.Text = "Kohteen tiedot";
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(228, 178);
            this.btnPaivita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(100, 28);
            this.btnPaivita.TabIndex = 9;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.BtnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(12, 178);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(100, 28);
            this.btnPoista.TabIndex = 8;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(120, 178);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(100, 28);
            this.btnMuokkaa.TabIndex = 7;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(336, 178);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(100, 28);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(111, 86);
            this.tbHinta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(161, 22);
            this.tbHinta.TabIndex = 5;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(51, 22);
            this.tbHenkilomaara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(221, 22);
            this.tbHenkilomaara.TabIndex = 4;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(111, 56);
            this.tbNimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(161, 22);
            this.tbNimi.TabIndex = 3;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(8, 91);
            this.lblHinta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(41, 17);
            this.lblHinta.TabIndex = 2;
            this.lblHinta.Text = "Hinta";
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(8, 59);
            this.lblHenkilomaara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(95, 17);
            this.lblHenkilomaara.TabIndex = 1;
            this.lblHenkilomaara.Text = "Henkilömäärä";
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(8, 27);
            this.lblNimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(35, 17);
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
            this.dgvKohde.Location = new System.Drawing.Point(488, 39);
            this.dgvKohde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKohde.Name = "dgvKohde";
            this.dgvKohde.RowHeadersWidth = 51;
            this.dgvKohde.Size = new System.Drawing.Size(507, 207);
            this.dgvKohde.TabIndex = 1;
            // 
            // mokki_id
            // 
            this.mokki_id.DataPropertyName = "mokki_id";
            this.mokki_id.HeaderText = "mokki_id";
            this.mokki_id.MinimumWidth = 6;
            this.mokki_id.Name = "mokki_id";
            this.mokki_id.Width = 125;
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            this.toimintaalueidDataGridViewTextBoxColumn.Width = 125;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 125;
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            this.mokkinimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            this.katuosoiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            this.kuvausDataGridViewTextBoxColumn.Width = 125;
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            this.henkilomaaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // kohdeBindingSource
            // 
            this.kohdeBindingSource.DataSource = typeof(Ohjelmistotuotanto.Kohde);
            // 
            // Kohteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvKohde);
            this.Controls.Add(this.gbKohde);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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