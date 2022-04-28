using eRent.Model.Request.ObjekatSlike;
using eRent.WinUi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRent.WinUi.Forms.Objekat
{
    public partial class frmDetaljiObjekta : Form
    {
        private int? _objekat;
        private readonly APIService aPIService = new APIService("Objekat");
        private readonly APIService aPIServiceSlike = new APIService("ObjekatSlike");
        private readonly APIService aPIServiceKategorija = new APIService("Kategorija");
        private readonly APIService aPIServiceTip = new APIService("TipObjektum");

        public frmDetaljiObjekta(int objekat)
        {
            InitializeComponent();
            _objekat = objekat;
        }

        private void frmDetaljiObjekta_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private async void LoadData()
        {
            if (_objekat.HasValue)
            {
                var podaci = await aPIService.GetById<Model.Model.Objekat>(_objekat);
                var kat =await aPIServiceKategorija.GetById<Model.Model.Kategorija>(podaci.KategorijaId);
                var tip = await aPIServiceTip.GetById<Model.Model.TipObjektum>(podaci.TipObjektaId);
                label2.Text = podaci.Naziv;
                label4.Text = tip.Tip;
                label6.Text = kat.NazivKategorije;
                label8.Text = podaci.Adresa;
                label10.Text = podaci.Aktivan?"da":"ne";
                label12.Text = podaci.BrTelefona;
                label14.Text = podaci.Email;
            }
        }

        

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
