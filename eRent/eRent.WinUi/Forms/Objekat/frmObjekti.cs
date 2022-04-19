using eRent.Model.Request.Objekat;
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

namespace eRent.WinUi.Forms.Objekat
{
    public partial class frmObjekti : Form
    {
        private readonly APIService _apiService = new APIService("Objekat");
        private readonly APIService _apiServiceTipovi = new APIService("TipObjektum");
        private readonly APIService _apiServiceKategorija = new APIService("Kategorija");

        public frmObjekti()
        {
            InitializeComponent();
        }

        private async void frmObjekti_Load(object sender, EventArgs e)
        {

            var podaci = await _apiService.Get<List<Model.Model.Objekat>>(null);
            List<frmObjekti1> lista = new List<frmObjekti1>();
            foreach (var item in podaci)
            {
                frmObjekti1 forma = new frmObjekti1
                {
                    Adresa = item.Adresa,
                    Naziv = item.Naziv,
                    KategorijaId = item.KategorijaId,
                    ObjekatId = item.ObjekatId,
                    TipObjektaId = item.TipObjektaId,
                    VlasnikId = item.VlasnikId,
                    Kategorija = item.Kategorija.NazivKategorije,
                    TipObjekta = item.TipObjekta.Tip,
                    Vlasnik = item.Vlasnik.Ime + " " + item.Vlasnik.Prezime
                };
                lista.Add(forma);
            }

            dgvObjekti.AutoGenerateColumns = false;
            dgvObjekti.DataSource = lista;
        }
    }
}
