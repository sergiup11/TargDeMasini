using TargDeMasini;
namespace TargDeMasini
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codul generat de designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAdaugaMasina = new System.Windows.Forms.Button();
            this.btnAfiseazaMasini = new System.Windows.Forms.Button();
            this.btnCautaMasina = new System.Windows.Forms.Button();
            this.btnStergeMasina = new System.Windows.Forms.Button();
            this.btnSalveazaFisier = new System.Windows.Forms.Button();
            this.btnCitesteFisier = new System.Windows.Forms.Button();
            this.groupBoxCombustibil = new System.Windows.Forms.GroupBox();
            this.checkBoxBenzina = new System.Windows.Forms.CheckBox();
            this.checkBoxMotorina = new System.Windows.Forms.CheckBox();
            this.checkBoxElectric = new System.Windows.Forms.CheckBox();
            this.checkBoxHibrid = new System.Windows.Forms.CheckBox();
            this.dataGridViewMasini = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDataAdaugare = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDisponibilitate = new System.Windows.Forms.GroupBox();
            this.radioDisponibile = new System.Windows.Forms.RadioButton();
            this.radioToate = new System.Windows.Forms.RadioButton();
            this.groupBoxCombustibil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).BeginInit();
            this.groupBoxDisponibilitate.SuspendLayout();
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
            // groupBoxCombustibil
            // 
            this.groupBoxCombustibil.Controls.Add(this.checkBoxBenzina);
            this.groupBoxCombustibil.Controls.Add(this.checkBoxMotorina);
            this.groupBoxCombustibil.Controls.Add(this.checkBoxElectric);
            this.groupBoxCombustibil.Controls.Add(this.checkBoxHibrid);
            this.groupBoxCombustibil.Location = new System.Drawing.Point(12, 230);
            this.groupBoxCombustibil.Name = "groupBoxCombustibil";
            this.groupBoxCombustibil.Size = new System.Drawing.Size(200, 120);
            this.groupBoxCombustibil.TabIndex = 6;
            this.groupBoxCombustibil.TabStop = false;
            this.groupBoxCombustibil.Text = "Tip Combustibil";
            // 
            // checkBoxBenzina
            // 
            this.checkBoxBenzina.Location = new System.Drawing.Point(10, 20);
            this.checkBoxBenzina.Name = "checkBoxBenzina";
            this.checkBoxBenzina.Size = new System.Drawing.Size(100, 20);
            this.checkBoxBenzina.TabIndex = 0;
            this.checkBoxBenzina.Text = "Benzina";
            this.checkBoxBenzina.UseVisualStyleBackColor = true;
            this.checkBoxBenzina.CheckedChanged += new System.EventHandler(this.CheckBoxCombustibil_CheckedChanged);
            // 
            // checkBoxMotorina
            // 
            this.checkBoxMotorina.Location = new System.Drawing.Point(10, 45);
            this.checkBoxMotorina.Name = "checkBoxMotorina";
            this.checkBoxMotorina.Size = new System.Drawing.Size(100, 20);
            this.checkBoxMotorina.TabIndex = 1;
            this.checkBoxMotorina.Text = "Motorina";
            this.checkBoxMotorina.UseVisualStyleBackColor = true;
            this.checkBoxMotorina.CheckedChanged += new System.EventHandler(this.CheckBoxCombustibil_CheckedChanged);
            // 
            // checkBoxElectric
            // 
            this.checkBoxElectric.Location = new System.Drawing.Point(10, 70);
            this.checkBoxElectric.Name = "checkBoxElectric";
            this.checkBoxElectric.Size = new System.Drawing.Size(100, 20);
            this.checkBoxElectric.TabIndex = 2;
            this.checkBoxElectric.Text = "Electric";
            this.checkBoxElectric.UseVisualStyleBackColor = true;
            this.checkBoxElectric.CheckedChanged += new System.EventHandler(this.CheckBoxCombustibil_CheckedChanged);
            // 
            // checkBoxHibrid
            // 
            this.checkBoxHibrid.Location = new System.Drawing.Point(10, 95);
            this.checkBoxHibrid.Name = "checkBoxHibrid";
            this.checkBoxHibrid.Size = new System.Drawing.Size(100, 20);
            this.checkBoxHibrid.TabIndex = 3;
            this.checkBoxHibrid.Text = "Hibrid";
            this.checkBoxHibrid.UseVisualStyleBackColor = true;
            this.checkBoxHibrid.CheckedChanged += new System.EventHandler(this.CheckBoxCombustibil_CheckedChanged);
            // 
            // dataGridViewMasini
            // 
            this.dataGridViewMasini.ColumnHeadersHeight = 29;
            this.dataGridViewMasini.Location = new System.Drawing.Point(230, 12);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.RowHeadersWidth = 51;
            this.dataGridViewMasini.Size = new System.Drawing.Size(757, 338);
            this.dataGridViewMasini.TabIndex = 7;
            // 
            // dateTimePickerDataAdaugare
            // 
            this.dateTimePickerDataAdaugare.Location = new System.Drawing.Point(12, 360);
            this.dateTimePickerDataAdaugare.Name = "dateTimePickerDataAdaugare";
            this.dateTimePickerDataAdaugare.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDataAdaugare.TabIndex = 10;
            this.dateTimePickerDataAdaugare.ValueChanged += new System.EventHandler(this.RadioDisponibilitate_CheckedChanged);
            // 
            // groupBoxDisponibilitate
            // 
            this.groupBoxDisponibilitate.Controls.Add(this.radioDisponibile);
            this.groupBoxDisponibilitate.Controls.Add(this.radioToate);
            this.groupBoxDisponibilitate.Location = new System.Drawing.Point(12, 400);
            this.groupBoxDisponibilitate.Name = "groupBoxDisponibilitate";
            this.groupBoxDisponibilitate.Size = new System.Drawing.Size(200, 70);
            this.groupBoxDisponibilitate.TabIndex = 11;
            this.groupBoxDisponibilitate.TabStop = false;
            this.groupBoxDisponibilitate.Text = "Filtrare Disponibilitate";
            // 
            // radioDisponibile
            // 
            this.radioDisponibile.Location = new System.Drawing.Point(10, 20);
            this.radioDisponibile.Name = "radioDisponibile";
            this.radioDisponibile.Size = new System.Drawing.Size(120, 20);
            this.radioDisponibile.TabIndex = 0;
            this.radioDisponibile.Text = "Disponibile";
            this.radioDisponibile.UseVisualStyleBackColor = true;
            this.radioDisponibile.CheckedChanged += new System.EventHandler(this.RadioDisponibilitate_CheckedChanged);
            // 
            // radioToate
            // 
            this.radioToate.Checked = true;
            this.radioToate.Location = new System.Drawing.Point(10, 40);
            this.radioToate.Name = "radioToate";
            this.radioToate.Size = new System.Drawing.Size(120, 20);
            this.radioToate.TabIndex = 1;
            this.radioToate.TabStop = true;
            this.radioToate.Text = "Toate";
            this.radioToate.UseVisualStyleBackColor = true;
            this.radioToate.CheckedChanged += new System.EventHandler(this.RadioDisponibilitate_CheckedChanged);
            // 
            // MainForm
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 490);
            this.Controls.Add(this.dateTimePickerDataAdaugare);
            this.Controls.Add(this.groupBoxDisponibilitate);
            this.Controls.Add(this.dataGridViewMasini);
            this.Controls.Add(this.groupBoxCombustibil);
            this.Controls.Add(this.btnCitesteFisier);
            this.Controls.Add(this.btnSalveazaFisier);
            this.Controls.Add(this.btnStergeMasina);
            this.Controls.Add(this.btnCautaMasina);
            this.Controls.Add(this.btnAfiseazaMasini);
            this.Controls.Add(this.btnAdaugaMasina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Târg Auto";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxCombustibil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).EndInit();
            this.groupBoxDisponibilitate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaMasina;
        private System.Windows.Forms.Button btnAfiseazaMasini;
        private System.Windows.Forms.Button btnCautaMasina;
        private System.Windows.Forms.Button btnStergeMasina;
        private System.Windows.Forms.Button btnSalveazaFisier;
        private System.Windows.Forms.Button btnCitesteFisier;
        private System.Windows.Forms.GroupBox groupBoxCombustibil;
        private System.Windows.Forms.CheckBox checkBoxBenzina;
        private System.Windows.Forms.CheckBox checkBoxMotorina;
        private System.Windows.Forms.CheckBox checkBoxElectric;
        private System.Windows.Forms.CheckBox checkBoxHibrid;
        private System.Windows.Forms.DataGridView dataGridViewMasini;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAdaugare;
        private System.Windows.Forms.GroupBox groupBoxDisponibilitate;
        private System.Windows.Forms.RadioButton radioDisponibile;
        private System.Windows.Forms.RadioButton radioToate;
    }
}
