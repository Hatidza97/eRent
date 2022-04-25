using eRent.Model.Request.Cjenovnik;
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
    public partial class frmNovaRezervacija : Form
    {
        private readonly APIService aPIService_Rezervacija = new APIService("Rezervacija");
        private readonly APIService aPIService_Cjenovnik = new APIService("Cjenovnik");

        private object _objekat;
        private string text1;
        private string text2;
        private object _objekatid;
        //public frmNovaRezervacija()
        //{
        //}

        //public frmNovaRezervacija(object objekat)
        //{
        //    InitializeComponent();
        //    _objekat = objekat;
        //}
        RezervacijaSearchRequest request = new RezervacijaSearchRequest();
        CjenovnikSearchRequest req = new CjenovnikSearchRequest();
        public frmNovaRezervacija(object objekat, string text1, string text2,object objekatid)
        {
            InitializeComponent();
            this.text1 = text1;
            this.text2 = text2;
            _objekat = objekat;
            _objekatid = objekatid;
        }

        private void frmNovaRezervacija_Load(object sender, EventArgs e)
        {
            label2.Text = _objekat.ToString();
            label4.Text = text1;
            label6.Text = text2;
        }

        private async void btnKreiraj_Click(object sender, EventArgs e)
        {
            request.ObjekatId =Convert.ToInt32(_objekatid);
            request.BrojMjestaDjeca =Convert.ToInt32(label4.Text);
            request.BrojMjestaOdrasli = Convert.ToInt32(label6.Text);
            request.DatumRezervacije = DateTime.Now;
            request.DatumPrijave = dateTimePicker1.Value;
            request.DatumOdjave = dateTimePicker2.Value;
            var d1 = "2022-02-02";
            var d2 = "2022-05-05";
            var d11 = DateTime.Parse(d1);
            var d22 = DateTime.Parse(d2);
            if(request.DatumPrijave>=d11 && 
                request.DatumOdjave<=d22)
            {
                request.CjenovnikId = 1;
            }
            List<frmRezervacija1> lista = new List<frmRezervacija1>();
            var podaci = await aPIService_Rezervacija.Get<List<Model.Model.Rezervacija>>(null);
            var podaci1 = await aPIService_Cjenovnik.GetById<List<Model.Model.Cjenovnik>>(null);
            foreach (var x in podaci)
            {
                frmRezervacija1 forma = new frmRezervacija1
                {
                    Cjenovnik = x.Cjenovnik.Cijena.ToString(),
                    Cijena = x.Cijena.ToString()
                };
                lista.Add(forma);
            }
            foreach (var x in lista)
            {
                request.Cijena =Convert.ToDouble(x.Cijena);
                request.Vrijednost = Convert.ToDouble(x.Cijena);

            }
            request.GostId = 1;
            request.KorisnikId = 1;
            var listaRezervacija = await aPIService_Rezervacija.Get<List<Model.Model.Rezervacija>>(request);
            var listaCjenovnik = await aPIService_Cjenovnik.Get<List<Model.Model.Cjenovnik>>(req);
            if (listaRezervacija.Count >= 1)
            {
                MessageBox.Show("Rezervacija je već unijeta u sistem, pokušajte ponovo sa novom rezervacijom.", "Greška", MessageBoxButtons.OK);
                return;
            }
            else
            {
                await aPIService_Rezervacija.Insert<Model.Model.Rezervacija>(request);
                MessageBox.Show("Rezervacija je dodan u bazu", "Poruka", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
