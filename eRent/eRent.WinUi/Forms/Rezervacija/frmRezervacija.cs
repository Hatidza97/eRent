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

namespace eRent.WinUi.Forms.Rezervacija
{
    public partial class frmRezervacija : Form
    {
        protected APIService _servisKorisnik = new APIService("Korisnici");
        protected APIService _servisRezervacija = new APIService("Rezervacija");
        protected APIService _servisObjekat = new APIService("Objekat");
        public frmRezervacija()
        {
            InitializeComponent();
        }

        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var podaci = await _servisRezervacija.Get<List<Model.Model.Rezervacija>>(null);

            var lista = new List<frmRezervacija1>();
            foreach (var x in podaci)
            {
                frmRezervacija1 forma = new frmRezervacija1
                {
                    RezervacijaId = x.RezervacijaId,
                    DatumRezervacije=x.DatumRezervacije.Date,
                    DatumOdjave = x.DatumOdjave.Date,
                    DatumPrijave = x.DatumPrijave.Date,
                    Ime = x.Korisnik.Ime,
                    Prezime = x.Korisnik.Prezime,
                    Objekat = x.Objekat.Naziv,
                    Cijena = x.Cijena.ToString(),
                    BrojMjestaDjeca = (int)x.BrojMjestaDjeca,
                    BrojMjestaOdrasli = (int)x.BrojMjestaOdrasli,
                    Vrijednost=x.Vrijednost,
                    KorisnikId=x.KorisnikId
                };
                lista.Add(forma);
            }
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = lista;
        }
    }
}
