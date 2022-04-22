
namespace eRent.WinUi.Forms.Rezervacija
{
    partial class frmRezervacija
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objekat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojMjestaDjeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojMjestaOdrasli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled rezervacija";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumRezervacije,
            this.DatumPrijave,
            this.DatumOdjave,
            this.Cijena,
            this.Objekat,
            this.BrojMjestaDjeca,
            this.BrojMjestaOdrasli});
            this.dgvRezervacije.Location = new System.Drawing.Point(13, 128);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(775, 299);
            this.dgvRezervacije.TabIndex = 1;
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.MinimumWidth = 6;
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            // 
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "Datum prijave";
            this.DatumPrijave.MinimumWidth = 6;
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.ReadOnly = true;
            // 
            // DatumOdjave
            // 
            this.DatumOdjave.DataPropertyName = "DatumOdjave";
            this.DatumOdjave.HeaderText = "Datum odjave";
            this.DatumOdjave.MinimumWidth = 6;
            this.DatumOdjave.Name = "DatumOdjave";
            this.DatumOdjave.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Objekat
            // 
            this.Objekat.DataPropertyName = "Objekat";
            this.Objekat.HeaderText = "Objekat";
            this.Objekat.MinimumWidth = 6;
            this.Objekat.Name = "Objekat";
            this.Objekat.ReadOnly = true;
            // 
            // BrojMjestaDjeca
            // 
            this.BrojMjestaDjeca.DataPropertyName = "BrojMjestaDjeca";
            this.BrojMjestaDjeca.HeaderText = "Djeca";
            this.BrojMjestaDjeca.MinimumWidth = 6;
            this.BrojMjestaDjeca.Name = "BrojMjestaDjeca";
            this.BrojMjestaDjeca.ReadOnly = true;
            // 
            // BrojMjestaOdrasli
            // 
            this.BrojMjestaOdrasli.DataPropertyName = "BrojMjestaOdrasli";
            this.BrojMjestaOdrasli.HeaderText = "Odrasli";
            this.BrojMjestaOdrasli.MinimumWidth = 6;
            this.BrojMjestaOdrasli.Name = "BrojMjestaOdrasli";
            this.BrojMjestaOdrasli.ReadOnly = true;
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.label1);
            this.Name = "frmRezervacija";
            this.Text = "frmRezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objekat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojMjestaDjeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojMjestaOdrasli;
    }
}