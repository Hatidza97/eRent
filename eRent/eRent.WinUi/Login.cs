using eRent.Model.Model;
using eRent.Model.Request.Korisnik;
using eRent.Model.Request.Uloga;
using eRent.WinUi.Forms;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace eRent.WinUi
{
    public partial class Login : Form
    {
        private readonly APIService aPIService = new APIService("Korisnici");
        private readonly APIService aPIService_Uloge = new APIService("Uloge");
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            await UcitajUloge();
        }

        //private void UcitajUloge()
        //{
        //    cmbUloge.DisplayMember = "Naziv";
        //    cmbUloge.ValueMember = "UlogaId";
        //    var izvor =aPIService.Get<List<eRent.Model.Model.Uloga>>();
        //    cmbUloge.DataSource = izvor.ToString();
        //}

        async Task UcitajUloge()
        {
            var result = await aPIService_Uloge.Get<List<Model.Model.Uloga>>(null);
            result.Insert(0, new Uloga() { Naziv = "---" });
            cmbUloge.DisplayMember = "Naziv";
            cmbUloge.ValueMember = "UlogaId";
            cmbUloge.DataSource = result;
            cmbUloge.SelectedIndex = 0;
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;


                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Sva polja su obavezna", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var request = new KorisniciSearchRequest
                {
                    KorisnickoIme = txtUsername.Text,
                    //UlogaId = Convert.ToInt32(txtUloga.Text),
                    UlogaId = cmbUloge.SelectedIndex
                    
                };
              
                var result = await aPIService.Get<List<Korisnik>>(request);
                
                if (result is null || result.Count == 0)
                {
                    return;
                }
                else
                {
                    frmPocetna frm = new frmPocetna();
                    frm.Show();
                    this.Hide();
                }
            }

            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 401)
                    MessageBox.Show("Neispravno korisničko ime ili lozinka! ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Došlo je do greške, pokušajte opet! ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
    
}
