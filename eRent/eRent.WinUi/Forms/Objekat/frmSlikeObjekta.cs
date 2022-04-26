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
    public partial class frmSlikeObjekta : Form
    {
        private object _idobjekta;
        private readonly APIService aPIService_ObjekatSlike = new APIService("ObjekatSlike");

        //public frmSlikeObjekta()
        //{
        //}

        public frmSlikeObjekta(object idobjekta)
        {
            InitializeComponent();
            _idobjekta = idobjekta;
        }
        ObjekatSlikeInsertRequest request = new ObjekatSlikeInsertRequest();
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //var result = openFileDialog1.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    //var fileName = openFileDialog1.FileName;
            //    //var file = File.ReadAllBytes(fileName);
            //    //request.ObjekatSlike1 = file;
            //    //txtSlika.Text = fileName;
            //    //Image img = Image.FromFile(fileName);
            //    //pbSlika.Image = img;
            //    //pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;

            //    var fileName = openFileDialog1.FileName;
            //    var file = File.ReadAllBytes(fileName);
            //    //request.ObjekatSlike1 = file;
            //    request.ObjekatId = (int)_idobjekta;
            //    txtSlika.Text = fileName;
            //    pbSlika.Image = Image.FromFile(fileName);
            //    request.ObjekatSlike1 = eRent.WinUi.Helpers.ImageHelper.FromImageToByte(pbSlika.Image);
            //}
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.ObjekatSlike1 = file;
                txtSlika.Text = fileName;
                request.ObjekatId = (int)_idobjekta;
                Image img = Image.FromFile(fileName);
                pbSlika.Image = img;
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.ObjekatSlike1 = ImageHelper.FromImageToByte(pbSlika.Image);
            await aPIService_ObjekatSlike.Insert<Model.Model.ObjekatSlike>(request);
             MessageBox.Show("Slika je dodana u bazu", "Poruka", MessageBoxButtons.OK);
             this.Close();
        }
    }
}
