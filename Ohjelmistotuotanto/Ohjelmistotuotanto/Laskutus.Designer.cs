namespace Ohjelmistotuotanto
{
    partial class Laskutus
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
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVaraus = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTulosta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.gbVaraus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(13, 36);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(240, 150);
            this.dgvVaraukset.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tohon dgv:lle varaukset joista valitaan laskutettava";
            // 
            // gbVaraus
            // 
            this.gbVaraus.Controls.Add(this.btnTulosta);
            this.gbVaraus.Controls.Add(this.label2);
            this.gbVaraus.Location = new System.Drawing.Point(289, 36);
            this.gbVaraus.Name = "gbVaraus";
            this.gbVaraus.Size = new System.Drawing.Size(436, 150);
            this.gbVaraus.TabIndex = 2;
            this.gbVaraus.TabStop = false;
            this.gbVaraus.Text = "Varaus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "tänne jotakin varauksen tietoja, jos käyttäjä haluaa muokata ennen laskun tulostu" +
    "sta";
            // 
            // btnTulosta
            // 
            this.btnTulosta.Location = new System.Drawing.Point(326, 121);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(101, 23);
            this.btnTulosta.TabIndex = 1;
            this.btnTulosta.Text = "Hyväksy ja tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            // 
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbVaraus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVaraukset);
            this.Name = "Laskutus";
            this.Text = "Laskutus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.gbVaraus.ResumeLayout(false);
            this.gbVaraus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVaraus;
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.Label label2;
    }
}