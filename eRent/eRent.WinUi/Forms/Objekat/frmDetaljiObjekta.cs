using eRent.WinUi.Helpers;
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
    public partial class frmDetaljiObjekta : Form
    {
        private int? _objekat;
        private readonly APIService aPIService = new APIService("Objekat");
        private readonly APIService aPIServiceSlike = new APIService("ObjekatSlike");

        public frmDetaljiObjekta(int objekat)
        {
            InitializeComponent();
            _objekat = objekat;
        }

        private void frmDetaljiObjekta_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            if (_objekat.HasValue)
            {
                var podaci = await aPIService.GetById<Model.Model.Objekat>(_objekat);
                var podaciSlike = await aPIServiceSlike.Get<Model.Model.ObjekatSlike>(null);
                label2.Text = podaci.Naziv;
                label4.Text = podaci.TipObjekta.Tip;
                label6.Text = podaci.Kategorija.NazivKategorije;
                label8.Text = podaci.Adresa;
                label10.Text = podaci.Aktivan.ToString();
                label12.Text = podaci.BrTelefona;
                label14.Text = podaci.Email;
                if (podaciSlike.ObjekatId == _objekat)
                {
                    pictureBox1.Image = ImageHelper.FromByteToImage(podaciSlike.ObjekatSlike1);
                }
            }   
        }
    }
}
