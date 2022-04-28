
namespace eRent.WinUi.Forms.Objekat
{
    partial class ObjektiPretraga
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
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipObjekta = new System.Windows.Forms.ComboBox();
            this.dgvObjekti = new System.Windows.Forms.DataGridView();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.ObjekatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipObjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga po kategoriji:";
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(181, 17);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(141, 24);
            this.cmbKategorije.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pretraga po tipu objekta:";
            // 
            // cmbTipObjekta
            // 
            this.cmbTipObjekta.FormattingEnabled = true;
            this.cmbTipObjekta.Location = new System.Drawing.Point(536, 19);
            this.cmbTipObjekta.Name = "cmbTipObjekta";
            this.cmbTipObjekta.Size = new System.Drawing.Size(166, 24);
            this.cmbTipObjekta.TabIndex = 3;
            // 
            // dgvObjekti
            // 
            this.dgvObjekti.AllowUserToAddRows = false;
            this.dgvObjekti.AllowUserToDeleteRows = false;
            this.dgvObjekti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjekatId,
            this.Naziv,
            this.TipObjekta,
            this.Kategorija,
            this.Adresa,
            this.Telefon});
            this.dgvObjekti.Location = new System.Drawing.Point(7, 172);
            this.dgvObjekti.Name = "dgvObjekti";
            this.dgvObjekti.ReadOnly = true;
            this.dgvObjekti.RowHeadersWidth = 51;
            this.dgvObjekti.RowTemplate.Height = 24;
            this.dgvObjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjekti.Size = new System.Drawing.Size(781, 266);
            this.dgvObjekti.TabIndex = 4;
            this.dgvObjekti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjekti_CellContentClick);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(326, 109);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(102, 33);
            this.btnTrazi.TabIndex = 5;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // ObjekatId
            // 
            this.ObjekatId.DataPropertyName = "ObjekatId";
            this.ObjekatId.HeaderText = "ObjekatId";
            this.ObjekatId.MinimumWidth = 6;
            this.ObjekatId.Name = "ObjekatId";
            this.ObjekatId.ReadOnly = true;
            this.ObjekatId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // TipObjekta
            // 
            this.TipObjekta.DataPropertyName = "TipObjekta";
            this.TipObjekta.HeaderText = "Tip objekta";
            this.TipObjekta.MinimumWidth = 6;
            this.TipObjekta.Name = "TipObjekta";
            this.TipObjekta.ReadOnly = true;
            this.TipObjekta.Visible = false;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            this.Kategorija.Visible = false;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MinimumWidth = 6;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "BrTelefona";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // ObjektiPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.dgvObjekti);
            this.Controls.Add(this.cmbTipObjekta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.label1);
            this.Name = "ObjektiPretraga";
            this.Text = "ObjektiPretraga";
            this.Load += new System.EventHandler(this.ObjektiPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipObjekta;
        private System.Windows.Forms.DataGridView dgvObjekti;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjekatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipObjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
    }
}