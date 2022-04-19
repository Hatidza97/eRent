using eRent.Model.Request.Korisnik;
using eRent.Model.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRent.WinUi.Forms.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<Model.Model.Korisnik>>(null);
            List<frmKorisnici1> lista = new List<frmKorisnici1>();
            foreach (var item in podaci)
            {
                frmKorisnici1 forma = new frmKorisnici1
                {
                    Ime = item.Ime,
                    Prezime = item.Prezime,
                    Adresa = item.Adresa,
                    Email = item.Email,
                    Telefon = item.Telefon,
                    Username = item.Username

                };
                lista.Add(forma);
            }
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = lista;
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
                var request = new KorisniciSearchRequest
            {
                Ime = txtImePrezime.Text,
                Prezime = txtImePrezime.Text
            };
           

                var podaci = await _apiService.Get<List<Model.Model.Korisnik>>(request);
                var lista = new List<frmKorisnici1>();

                foreach (var item in podaci)
                {
                    var forma = new frmKorisnici1
                    {
                        Ime = item.Ime,
                        Prezime = item.Prezime,
                        Email = item.Email,
                        Telefon = item.Telefon,
                        Adresa = item.Adresa,
                        Username=item.Username
                    };
                    lista.Add(forma);
                }
                dgvKorisnici.AutoGenerateColumns = false;
                dgvKorisnici.DataSource = lista;
                if (lista.Count == 0)
                {
                    MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
                }
            
        }
    }
}
