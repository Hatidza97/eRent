
namespace eRent.WinUi.Forms.Rezervacija
{
    partial class frmDodajRezervaciju
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDjeca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdrasli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvObjekti = new System.Windows.Forms.DataGridView();
            this.Objekat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjekatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Do:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(539, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Djeca:";
            // 
            // txtDjeca
            // 
            this.txtDjeca.Location = new System.Drawing.Point(81, 23);
            this.txtDjeca.Name = "txtDjeca";
            this.txtDjeca.Size = new System.Drawing.Size(34, 22);
            this.txtDjeca.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Odrasli:";
            // 
            // txtOdrasli
            // 
            this.txtOdrasli.Location = new System.Drawing.Point(81, 53);
            this.txtOdrasli.Name = "txtOdrasli";
            this.txtOdrasli.Size = new System.Drawing.Size(34, 22);
            this.txtOdrasli.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grad:";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(81, 90);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(121, 24);
            this.cmbGradovi.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(210, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(380, 38);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Pogledaj listu dostupnih objekata";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvObjekti
            // 
            this.dgvObjekti.AllowUserToAddRows = false;
            this.dgvObjekti.AllowUserToDeleteRows = false;
            this.dgvObjekti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Objekat,
            this.ObjekatId});
            this.dgvObjekti.Location = new System.Drawing.Point(16, 240);
            this.dgvObjekti.Name = "dgvObjekti";
            this.dgvObjekti.ReadOnly = true;
            this.dgvObjekti.RowHeadersWidth = 51;
            this.dgvObjekti.RowTemplate.Height = 24;
            this.dgvObjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjekti.Size = new System.Drawing.Size(772, 150);
            this.dgvObjekti.TabIndex = 13;
            this.dgvObjekti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjekti_CellContentClick);
            // 
            // Objekat
            // 
            this.Objekat.DataPropertyName = "Naziv";
            this.Objekat.HeaderText = "Objekat";
            this.Objekat.MinimumWidth = 6;
            this.Objekat.Name = "Objekat";
            this.Objekat.ReadOnly = true;
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
            // frmDodajRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvObjekti);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOdrasli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDjeca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmDodajRezervaciju";
            this.Text = "frmDodajRezervaciju";
            this.Load += new System.EventHandler(this.frmDodajRezervaciju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDjeca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdrasli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvObjekti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objekat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjekatId;
    }
}