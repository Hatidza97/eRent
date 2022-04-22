
namespace eRent.WinUi.Forms.Objekat
{
    partial class frmObjekti
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
            this.dgvObjekti = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vlasnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObjekti
            // 
            this.dgvObjekti.AllowUserToAddRows = false;
            this.dgvObjekti.AllowUserToDeleteRows = false;
            this.dgvObjekti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.BrTelefona,
            this.Email,
            this.Kategorija,
            this.Adresa,
            this.Vlasnik});
            this.dgvObjekti.Location = new System.Drawing.Point(12, 146);
            this.dgvObjekti.Name = "dgvObjekti";
            this.dgvObjekti.ReadOnly = true;
            this.dgvObjekti.RowHeadersWidth = 51;
            this.dgvObjekti.RowTemplate.Height = 24;
            this.dgvObjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjekti.Size = new System.Drawing.Size(775, 292);
            this.dgvObjekti.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // BrTelefona
            // 
            this.BrTelefona.DataPropertyName = "BrTelefona";
            this.BrTelefona.HeaderText = "Broj telefona";
            this.BrTelefona.MinimumWidth = 6;
            this.BrTelefona.Name = "BrTelefona";
            this.BrTelefona.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MinimumWidth = 6;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Vlasnik
            // 
            this.Vlasnik.DataPropertyName = "Vlasnik";
            this.Vlasnik.HeaderText = "Vlasnik";
            this.Vlasnik.MinimumWidth = 6;
            this.Vlasnik.Name = "Vlasnik";
            this.Vlasnik.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista objekata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pretraga po nazivu objekta:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(201, 79);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(587, 22);
            this.txtPretraga.TabIndex = 3;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // frmObjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObjekti);
            this.Name = "frmObjekti";
            this.Text = "frmObjekti";
            this.Load += new System.EventHandler(this.frmObjekti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObjekti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlasnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
    }
}