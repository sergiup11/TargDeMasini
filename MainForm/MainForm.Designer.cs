using TargDeMasini;

namespace TargDeMasini
{
    partial class MainForm
    {
        /// <summary>
        /// Variabila necesară la designer
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Curăță resursele folosite
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codul generat de designer

        /// <summary>
        /// Necesită metode de inițializare
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdaugaMasina = new System.Windows.Forms.Button();
            this.btnAfiseazaMasini = new System.Windows.Forms.Button();
            this.btnCautaMasina = new System.Windows.Forms.Button();
            this.btnStergeMasina = new System.Windows.Forms.Button();
            this.btnSalveazaFisier = new System.Windows.Forms.Button();
            this.btnCitesteFisier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaugaMasina
            // 
            this.btnAdaugaMasina.Location = new System.Drawing.Point(12, 12);
            this.btnAdaugaMasina.Name = "btnAdaugaMasina";
            this.btnAdaugaMasina.Size = new System.Drawing.Size(200, 30);
            this.btnAdaugaMasina.TabIndex = 0;
            this.btnAdaugaMasina.Text = "Adaugă Mașină";
            this.btnAdaugaMasina.UseVisualStyleBackColor = true;
            // 
            // btnAfiseazaMasini
            // 
            this.btnAfiseazaMasini.Location = new System.Drawing.Point(12, 48);
            this.btnAfiseazaMasini.Name = "btnAfiseazaMasini";
            this.btnAfiseazaMasini.Size = new System.Drawing.Size(200, 30);
            this.btnAfiseazaMasini.TabIndex = 1;
            this.btnAfiseazaMasini.Text = "Afișează Mașini";
            this.btnAfiseazaMasini.UseVisualStyleBackColor = true;
            // 
            // btnCautaMasina
            // 
            this.btnCautaMasina.Location = new System.Drawing.Point(12, 84);
            this.btnCautaMasina.Name = "btnCautaMasina";
            this.btnCautaMasina.Size = new System.Drawing.Size(200, 30);
            this.btnCautaMasina.TabIndex = 2;
            this.btnCautaMasina.Text = "Caută Mașină";
            this.btnCautaMasina.UseVisualStyleBackColor = true;
            // 
            // btnStergeMasina
            // 
            this.btnStergeMasina.Location = new System.Drawing.Point(12, 120);
            this.btnStergeMasina.Name = "btnStergeMasina";
            this.btnStergeMasina.Size = new System.Drawing.Size(200, 30);
            this.btnStergeMasina.TabIndex = 3;
            this.btnStergeMasina.Text = "Șterge Mașină";
            this.btnStergeMasina.UseVisualStyleBackColor = true;
            // 
            // btnSalveazaFisier
            // 
            this.btnSalveazaFisier.Location = new System.Drawing.Point(12, 156);
            this.btnSalveazaFisier.Name = "btnSalveazaFisier";
            this.btnSalveazaFisier.Size = new System.Drawing.Size(200, 30);
            this.btnSalveazaFisier.TabIndex = 4;
            this.btnSalveazaFisier.Text = "Salvează în Fișier";
            this.btnSalveazaFisier.UseVisualStyleBackColor = true;
            // 
            // btnCitesteFisier
            // 
            this.btnCitesteFisier.Location = new System.Drawing.Point(12, 192);
            this.btnCitesteFisier.Name = "btnCitesteFisier";
            this.btnCitesteFisier.Size = new System.Drawing.Size(200, 30);
            this.btnCitesteFisier.TabIndex = 5;
            this.btnCitesteFisier.Text = "Citește din Fișier";
            this.btnCitesteFisier.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(230, 240);
            this.Controls.Add(this.btnCitesteFisier);
            this.Controls.Add(this.btnSalveazaFisier);
            this.Controls.Add(this.btnStergeMasina);
            this.Controls.Add(this.btnCautaMasina);
            this.Controls.Add(this.btnAfiseazaMasini);
            this.Controls.Add(this.btnAdaugaMasina);
            this.Name = "MainForm";
            this.Text = "Târg Auto";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaMasina;
        private System.Windows.Forms.Button btnAfiseazaMasini;
        private System.Windows.Forms.Button btnCautaMasina;
        private System.Windows.Forms.Button btnStergeMasina;
        private System.Windows.Forms.Button btnSalveazaFisier;
        private System.Windows.Forms.Button btnCitesteFisier;

    }
}
