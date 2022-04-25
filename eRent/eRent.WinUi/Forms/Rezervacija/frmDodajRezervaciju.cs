using eRent.Model.Request.Objekat;
using eRent.Model.Request.Rezervacija;
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
    public partial class frmDodajRezervaciju : Form
    {
        private readonly APIService aPIService = new APIService("Objekat");
        private readonly APIService aPIService_Kategorija = new APIService("Grad");
        private readonly APIService aPIService_Tip = new APIService("TipObjektum");
        private readonly APIService aPIService_Korisnik = new APIService("Korisnici");
        private readonly APIService aPIService_Rezervacija = new APIService("Rezervacija");
        public frmDodajRezervaciju()
        {
            InitializeComponent();
        }

        private async void frmDodajRezervaciju_Load(object sender, EventArgs e)
        {
            await UcitajGradove();
            UcitajDatume();
        }

        private void UcitajDatume()
        {
            var datumOd = dateTimePicker1.Value;
            var datumDo = dateTimePicker1.Value;
        }

        async Task UcitajGradove()
        {
            var result = await aPIService_Kategorija.Get<List<Model.Model.Grad>>(null);
            result.Insert(0, new Model.Model.Grad() { Naziv = "---" });
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            cmbGradovi.DataSource = result;
            cmbGradovi.SelectedIndex = 0;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var DatumOd = dateTimePicker1.Value;
            var DatumDo = dateTimePicker2.Value;
            var djeca = txtDjeca.Text;
            var odrasli = txtOdrasli.Text;
            ObjekatSearchRequest uslov = new ObjekatSearchRequest
            {
                Rezervisano = false,
                GradId=cmbGradovi.SelectedIndex
            };
            var request = new RezervacijaSearchRequest
            {
                BrojMjestaDjeca = Convert.ToInt32(txtDjeca.Text),
                BrojMjestaOdrasli = Convert.ToInt32(txtOdrasli.Text),
                //DatumPrijave = DatumOd,
                //DatumOdjave = DatumDo,
                ObjekatSearchRequest=uslov
            };
            //if (request.DatumOdjave.Value.Date <= request.DatumPrijave.Value.Date)
            //{
            //    MessageBox.Show("Datum početka mora biti manji od datuma završetka", "Greška", MessageBoxButtons.OK);
            //}
            var podaci = await aPIService_Rezervacija.Get<List<Model.Model.Rezervacija>>(request);
            var podaciObjekat = await aPIService.Get<List<Model.Model.Objekat>>(uslov);
            List<frmRezervacija1> lista = new List<frmRezervacija1>();
            List<frmObjekti1> lista1 = new List<frmObjekti1>();
            foreach (var x in podaci)
            {
                frmRezervacija1 forma = new frmRezervacija1
                {
                    RezervacijaId = x.RezervacijaId,
                    DatumPrijave = x.DatumPrijave,
                    DatumOdjave = x.DatumOdjave,
                    Ime = x.Korisnik.Ime,
                    Prezime = x.Korisnik.Prezime,
                    BrojMjestaDjeca = x.BrojMjestaDjeca,
                    BrojMjestaOdrasli = x.BrojMjestaOdrasli,
                    Cijena = x.Cijena.ToString(),
                    DatumRezervacije = x.DatumRezervacije,
                    KorisnikId = x.KorisnikId,
                    Objekat = x.Objekat.Naziv,
                    Vrijednost = x.Vrijednost
                };
                lista.Add(forma);
            }
            foreach (var x in podaciObjekat)
            {
                frmObjekti1 forma1 = new frmObjekti1
                {
                  Naziv=x.Naziv
                };
                lista1.Add(forma1);
            }

            dgvObjekti.AutoGenerateColumns = false;
            dgvObjekti.DataSource = podaciObjekat;
            if (lista1.Count == 0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);

            }
        }

        private void dgvObjekti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var objekat = dgvObjekti.SelectedRows[0].Cells[0].Value;
            var objekat_id = dgvObjekti.SelectedRows[0].Cells[1].Value;
            frmNovaRezervacija forma = new frmNovaRezervacija(objekat, txtDjeca.Text,txtOdrasli.Text,objekat_id);
            forma.Show();


        }
    }
}
