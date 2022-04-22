using eRent.Model.Request.Objekat;
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
    public partial class frmNoviObjekat : Form
    {
        private readonly APIService aPIService = new APIService("Objekat");
        private readonly APIService aPIService_Kategorija = new APIService("Kategorija");
        private readonly APIService aPIService_Tip = new APIService("TipObjektum");
        private readonly APIService aPIService_Korisnik = new APIService("Korisnici");
        public frmNoviObjekat(int v)
        {
            InitializeComponent();
            _v = v;
        }

        private async void frmNoviObjekat_Load(object sender, EventArgs e)
        {
            await UcitajKategorije();
            await UcitajTipove();
        }

        async Task UcitajTipove()
        {
            var result = await aPIService_Tip.Get<List<Model.Model.TipObjektum>>(null);
            result.Insert(0, new Model.Model.TipObjektum() { Tip = "---" });
            cmbTip.DisplayMember = "Tip";
            cmbTip.ValueMember = "TipObjektaId";
            cmbTip.DataSource = result;
            cmbTip.SelectedIndex = 0;
        }

        async Task UcitajKategorije()
        {
            var result = await aPIService_Kategorija.Get<List<Model.Model.Kategorija>>(null);
            result.Insert(0, new Model.Model.Kategorija() { NazivKategorije = "---" });
            cmbKategorije.DisplayMember = "NazivKategorije";
            cmbKategorije.ValueMember = "KategorijaId";
            cmbKategorije.DataSource = result;
            cmbKategorije.SelectedIndex = 0;
        }
        ObjekatInserRequest request = new ObjekatInserRequest();
        private int? _v;

        private async void button1_Click(object sender, EventArgs e)
        {
            request.VlasnikId =(int)_v;
            request.Adresa = txtAdresa.Text;
            request.Email = txtEmail.Text;
            request.BrTelefona = txtBrTel.Text;
            request.Aktivan = checkBox1.Checked;
            request.Naziv = txtNaziv.Text;
            request.KategorijaId = cmbKategorije.SelectedIndex;
            request.TipObjektaId = cmbTip.SelectedIndex;
            
            var listaObjekata = await aPIService.Get<List<Model.Model.Objekat>>(request);
            if (listaObjekata.Count >= 1)
            {
                MessageBox.Show("Objekat je već unijet u sistem, pokušajte ponovo sa novim objektom.", "Greška", MessageBoxButtons.OK);
                return;
            }
            else
            {
                await aPIService.Insert<Model.Model.Objekat>(request);
                MessageBox.Show("Objekat je dodan u bazu", "Poruka", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
