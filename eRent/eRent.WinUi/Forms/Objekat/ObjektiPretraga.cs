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
    public partial class ObjektiPretraga : Form
    {
        private readonly APIService aPIService = new APIService("Objekat");
        private readonly APIService aPIServiceTip = new APIService("TipObjektum");
        private readonly APIService aPIServiceKategorija = new APIService("Kategorija");

        public ObjektiPretraga()
        {
            InitializeComponent();
        }

        private async void ObjektiPretraga_Load(object sender, EventArgs e)
        {
            await UcitajTipove();
            await UcitajKategorije();
            dgvObjekti.AutoGenerateColumns = false;
            LoadData();
            
        }

        private async void LoadData()
        {
            var podaci = await aPIService.Get<List<Model.Model.Objekat>>(null);
            List<frmObjekti1> lista = new List<frmObjekti1>();
            foreach (var item in podaci)
            {
                frmObjekti1 forma = new frmObjekti1
                {
                    Adresa = item.Adresa,
                    Naziv = item.Naziv,
                    BrTelefona = item.BrTelefona,
                    Email = item.Email,
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

        async Task UcitajKategorije()
        {
            var result = await aPIServiceKategorija.Get<List<Model.Model.Kategorija>>(null);
            result.Insert(0, new Model.Model.Kategorija() { NazivKategorije = "---" });
            cmbKategorije.DisplayMember = "NazivKategorije";
            cmbKategorije.ValueMember = "KategorijaId";
            cmbKategorije.DataSource = result;
            cmbKategorije.SelectedIndex = 0;
        }

        async Task UcitajTipove()
        {
            var result = await aPIServiceTip.Get<List<Model.Model.TipObjektum>>(null);
            result.Insert(0, new Model.Model.TipObjektum() { Tip = "---" });
            cmbTipObjekta.DisplayMember = "Tip";
            cmbTipObjekta.ValueMember = "TipObjektaId";
            cmbTipObjekta.DataSource = result;
            cmbTipObjekta.SelectedIndex = 0;
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {

            var pretraga = new ObjekatSearchRequest
            {
                KategorijaId= cmbKategorije.SelectedIndex,
                TipObjektaId = cmbTipObjekta.SelectedIndex
            };
            var result2 = await aPIService.Get<List<Model.Model.Objekat>>(pretraga);
            dgvObjekti.DataSource = null;
            dgvObjekti.DataSource = result2;
        }

        private void dgvObjekti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var objekat = dgvObjekti.SelectedRows[0].Cells[0].Value;
            var rez = objekat.ToString();
            frmDetaljiObjekta forma = new frmDetaljiObjekta(int.Parse(rez));
            forma.Show();
        }
    }
}
