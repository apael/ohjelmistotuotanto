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
            this.gbKohde = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.lblHinta = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.gbKohde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKohde
            // 
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
            this.gbKohde.Size = new System.Drawing.Size(263, 174);
            this.gbKohde.TabIndex = 0;
            this.gbKohde.TabStop = false;
            this.gbKohde.Text = "Kohteen tiedot";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 168);
            this.dataGridView1.TabIndex = 1;
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
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(6, 48);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(72, 13);
            this.lblHenkilomaara.TabIndex = 1;
            this.lblHenkilomaara.Text = "Henkilömäärä";
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
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(39, 19);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(166, 20);
            this.tbNimi.TabIndex = 3;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(84, 45);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(121, 20);
            this.tbHenkilomaara.TabIndex = 4;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(44, 71);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(161, 20);
            this.tbHinta.TabIndex = 5;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(182, 145);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 23);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(101, 145);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 7;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(20, 145);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 8;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // Kohteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbKohde);
            this.Name = "Kohteet";
            this.Text = "Kohteet";
            this.gbKohde.ResumeLayout(false);
            this.gbKohde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKohde;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.Label lblNimi;
    }
}