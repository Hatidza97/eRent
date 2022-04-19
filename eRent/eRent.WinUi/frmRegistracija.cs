using eRent.Model.Model;
using eRent.Model.Request.Korisnik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRent.WinUi
{
    public partial class frmRegistracija : Form
    {

        private readonly APIService aPIService = new APIService("Korisnici");
        private readonly APIService aPIService_Uloge = new APIService("Uloge");
        private readonly APIService aPIService_Grad = new APIService("Grad");

        public frmRegistracija()
        {
            InitializeComponent();
        }

        private async void frmRegistracija_Load(object sender, EventArgs e)
        {
            await UcitajUloge();
            await UcitajGradove();
        }

        async Task UcitajGradove()
        {
            var result = await aPIService_Grad.Get<List<Model.Model.Grad>>(null);
            result.Insert(0, new Grad() { Naziv = "---" });
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "GradId";
            cmbGrad.DataSource = result;
            cmbGrad.SelectedIndex = 0;
        }

        async Task UcitajUloge()
        {
            var result = await aPIService_Uloge.Get<List<Model.Model.Uloga>>(null);
            result.Insert(0, new Uloga() { Naziv = "---" });
            cmbUloge.DisplayMember = "Naziv";
            cmbUloge.ValueMember = "UlogaId";
            cmbUloge.DataSource = result;
            cmbUloge.SelectedIndex = 0;
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider1.SetError(txtKorisnickoIme, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                errorProvider1.SetError(txtLozinka, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLozinka, null);
            }
        }

        private void txtPotvrdiLozinku_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPotvrdiLozinku.Text))
            {
                errorProvider1.SetError(txtPotvrdiLozinku, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPotvrdiLozinku, null);
            }
        }

        private async void btnRegistracija_Click(object sender, EventArgs e)
        {
            APIService.Username = txtKorisnickoIme.Text;
            APIService.Password = txtLozinka.Text;


            var request = new KorisniciInsertRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Telefon = txtTelefon.Text,
                Adresa = txtAdresa.Text,
                Email = txtEmail.Text,
                Username = txtKorisnickoIme.Text,
                Password = txtLozinka.Text,
                PasswordPotvrda = txtPotvrdiLozinku.Text,
                Aktivan = checkBox1.Checked,
                GradId = cmbGrad.SelectedIndex,
                UlogaId = cmbUloge.SelectedIndex
            };
            var result =  aPIService.Insert<List<Korisnik>>(request);

            if (result is null /*|| result.Count == 0*/)
            {
                return;
            }
            else
            {
                MessageBox.Show("Korisnik uspjesno dodan!");
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
