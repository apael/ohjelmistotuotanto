namespace Ohjelmistotuotanto
{
    partial class PalveluidenHallinta
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
            this.btnDeaktivoipalvelu = new System.Windows.Forms.Button();
            this.btnAktivoipalvelu = new System.Windows.Forms.Button();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPoistetutpalvelut = new System.Windows.Forms.DataGridView();
            this.depalvelu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detoimintaalue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detyyppi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dekuvaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dehinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.lblEiaktiivisetpalvelut = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoistetutpalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeaktivoipalvelu
            // 
            this.btnDeaktivoipalvelu.Location = new System.Drawing.Point(12, 84);
            this.btnDeaktivoipalvelu.Name = "btnDeaktivoipalvelu";
            this.btnDeaktivoipalvelu.Size = new System.Drawing.Size(137, 49);
            this.btnDeaktivoipalvelu.TabIndex = 0;
            this.btnDeaktivoipalvelu.Text = "Hyllytä palvelu";
            this.btnDeaktivoipalvelu.UseVisualStyleBackColor = true;
            this.btnDeaktivoipalvelu.Click += new System.EventHandler(this.btnDeaktivoipalvelu_Click);
            // 
            // btnAktivoipalvelu
            // 
            this.btnAktivoipalvelu.Location = new System.Drawing.Point(12, 314);
            this.btnAktivoipalvelu.Name = "btnAktivoipalvelu";
            this.btnAktivoipalvelu.Size = new System.Drawing.Size(137, 49);
            this.btnAktivoipalvelu.TabIndex = 1;
            this.btnAktivoipalvelu.Text = "Aktivoi palvelu";
            this.btnAktivoipalvelu.UseVisualStyleBackColor = true;
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.AutoGenerateColumns = false;
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dgvPalvelut.DataSource = this.palveluBindingSource;
            this.dgvPalvelut.Location = new System.Drawing.Point(169, 44);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.Size = new System.Drawing.Size(744, 145);
            this.dgvPalvelut.TabIndex = 2;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataSource = typeof(Ohjelmistotuotanto.Palvelu);
            // 
            // dgvPoistetutpalvelut
            // 
            this.dgvPoistetutpalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoistetutpalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depalvelu_id,
            this.detoimintaalue_id,
            this.denimi,
            this.detyyppi,
            this.dekuvaus,
            this.dehinta,
            this.dealv});
            this.dgvPoistetutpalvelut.Location = new System.Drawing.Point(169, 253);
            this.dgvPoistetutpalvelut.Name = "dgvPoistetutpalvelut";
            this.dgvPoistetutpalvelut.Size = new System.Drawing.Size(744, 158);
            this.dgvPoistetutpalvelut.TabIndex = 3;
            // 
            // depalvelu_id
            // 
            this.depalvelu_id.HeaderText = "palvelu_id";
            this.depalvelu_id.Name = "depalvelu_id";
            // 
            // detoimintaalue_id
            // 
            this.detoimintaalue_id.HeaderText = "toimintaalue_id";
            this.detoimintaalue_id.Name = "detoimintaalue_id";
            // 
            // denimi
            // 
            this.denimi.HeaderText = "nimi";
            this.denimi.Name = "denimi";
            // 
            // detyyppi
            // 
            this.detyyppi.HeaderText = "tyyppi";
            this.detyyppi.Name = "detyyppi";
            // 
            // dekuvaus
            // 
            this.dekuvaus.HeaderText = "kuvaus";
            this.dekuvaus.Name = "dekuvaus";
            // 
            // dehinta
            // 
            this.dehinta.HeaderText = "hinta";
            this.dehinta.Name = "dehinta";
            // 
            // dealv
            // 
            this.dealv.HeaderText = "alv";
            this.dealv.Name = "dealv";
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.Location = new System.Drawing.Point(166, 9);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(89, 13);
            this.lblPalvelut.TabIndex = 4;
            this.lblPalvelut.Text = "Aktiiviset palvelut";
            // 
            // lblEiaktiivisetpalvelut
            // 
            this.lblEiaktiivisetpalvelut.AutoSize = true;
            this.lblEiaktiivisetpalvelut.Location = new System.Drawing.Point(166, 226);
            this.lblEiaktiivisetpalvelut.Name = "lblEiaktiivisetpalvelut";
            this.lblEiaktiivisetpalvelut.Size = new System.Drawing.Size(100, 13);
            this.lblEiaktiivisetpalvelut.TabIndex = 5;
            this.lblEiaktiivisetpalvelut.Text = "Ei-aktiiviset palvelut";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(455, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Päivitä kentät";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            // 
            // PalveluidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 492);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblEiaktiivisetpalvelut);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.dgvPoistetutpalvelut);
            this.Controls.Add(this.dgvPalvelut);
            this.Controls.Add(this.btnAktivoipalvelu);
            this.Controls.Add(this.btnDeaktivoipalvelu);
            this.Name = "PalveluidenHallinta";
            this.Text = "PalveluidenHallinta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoistetutpalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeaktivoipalvelu;
        private System.Windows.Forms.Button btnAktivoipalvelu;
        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.DataGridView dgvPoistetutpalvelut;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.Label lblEiaktiivisetpalvelut;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn depalvelu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn detoimintaalue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn denimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn detyyppi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dekuvaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dehinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealv;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
    }
}