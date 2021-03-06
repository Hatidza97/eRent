using eRent.WinUi.Forms.Korisnici;
using eRent.WinUi.Forms.Objekat;
using eRent.WinUi.Forms.Rezervacija;
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
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            Home forma = new Home();
            forma.MdiParent = this;
            forma.Show();
        }

        private void prikazKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici forma = new frmKorisnici();
            forma.MdiParent = this;
            forma.Show();
        }

        private void prikazObjekataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObjekti forma = new frmObjekti();
            forma.MdiParent = this;
            forma.Show(); 
        }

        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervacija forma = new frmRezervacija();
            forma.MdiParent = this;
            forma.Show();
        }

        private void kreirajRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajRezervaciju forma = new frmDodajRezervaciju();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pretragaObjekataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjektiPretraga forma = new ObjektiPretraga();
            forma.MdiParent = this;
            forma.Show();
        }


        //private void dodajNoviObjekatToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmNoviObjekat forma = new frmNoviObjekat();
        //    forma.MdiParent = this;
        //    forma.Show();
        //}
    }
}
