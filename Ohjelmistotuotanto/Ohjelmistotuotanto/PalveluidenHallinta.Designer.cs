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
            this.btnDeaktivoipalvelu = new System.Windows.Forms.Button();
            this.btnAktivoipalvelu = new System.Windows.Forms.Button();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.palvelu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alv = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
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
            this.btnAktivoipalvelu.Click += new System.EventHandler(this.btnAktivoipalvelu_Click);
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palvelu_id,
            this.toimintaalue_id,
            this.nimi,
            this.tyyppi,
            this.kuvaus,
            this.hinta,
            this.alv});
            this.dgvPalvelut.Location = new System.Drawing.Point(169, 38);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.Size = new System.Drawing.Size(744, 145);
            this.dgvPalvelut.TabIndex = 2;
            // 
            // palvelu_id
            // 
            this.palvelu_id.HeaderText = "palvelu_id";
            this.palvelu_id.Name = "palvelu_id";
            // 
            // toimintaalue_id
            // 
            this.toimintaalue_id.HeaderText = "toimintaalue_id";
            this.toimintaalue_id.Name = "toimintaalue_id";
            // 
            // nimi
            // 
            this.nimi.HeaderText = "nimi";
            this.nimi.Name = "nimi";
            // 
            // tyyppi
            // 
            this.tyyppi.HeaderText = "tyyppi";
            this.tyyppi.Name = "tyyppi";
            // 
            // kuvaus
            // 
            this.kuvaus.HeaderText = "kuvaus";
            this.kuvaus.Name = "kuvaus";
            // 
            // hinta
            // 
            this.hinta.HeaderText = "hinta";
            this.hinta.Name = "hinta";
            // 
            // alv
            // 
            this.alv.HeaderText = "alv";
            this.alv.Name = "alv";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn palvelu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn alv;
        private System.Windows.Forms.DataGridViewTextBoxColumn depalvelu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn detoimintaalue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn denimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn detyyppi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dekuvaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dehinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealv;
    }
}