
namespace eRent.WinUi
{
    partial class frmPocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazObjekataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pretragaObjekataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(64, 24);
            this.fileMenu.Text = "Home";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazKorisnikaToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(79, 24);
            this.editMenu.Text = "Korisnici";
            // 
            // prikazKorisnikaToolStripMenuItem
            // 
            this.prikazKorisnikaToolStripMenuItem.Name = "prikazKorisnikaToolStripMenuItem";
            this.prikazKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.prikazKorisnikaToolStripMenuItem.Text = "Prikaz korisnika";
            this.prikazKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.prikazKorisnikaToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazObjekataToolStripMenuItem,
            this.pretragaObjekataToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(71, 24);
            this.toolsMenu.Text = "Objekti";
            // 
            // prikazObjekataToolStripMenuItem
            // 
            this.prikazObjekataToolStripMenuItem.Name = "prikazObjekataToolStripMenuItem";
            this.prikazObjekataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prikazObjekataToolStripMenuItem.Text = "Prikaz objekata";
            this.prikazObjekataToolStripMenuItem.Click += new System.EventHandler(this.prikazObjekataToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledRezervacijaToolStripMenuItem,
            this.kreirajRezervacijuToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(98, 24);
            this.windowsMenu.Text = "Rezervacije";
            // 
            // pregledRezervacijaToolStripMenuItem
            // 
            this.pregledRezervacijaToolStripMenuItem.Name = "pregledRezervacijaToolStripMenuItem";
            this.pregledRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.pregledRezervacijaToolStripMenuItem.Text = "Pregled rezervacija";
            this.pregledRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.pregledRezervacijaToolStripMenuItem_Click);
            // 
            // kreirajRezervacijuToolStripMenuItem
            // 
            this.kreirajRezervacijuToolStripMenuItem.Name = "kreirajRezervacijuToolStripMenuItem";
            this.kreirajRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.kreirajRezervacijuToolStripMenuItem.Text = "Kreiraj rezervaciju";
            this.kreirajRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.kreirajRezervacijuToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(75, 24);
            this.helpMenu.Text = "O nama";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(71, 6);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pretragaObjekataToolStripMenuItem
            // 
            this.pretragaObjekataToolStripMenuItem.Name = "pretragaObjekataToolStripMenuItem";
            this.pretragaObjekataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pretragaObjekataToolStripMenuItem.Text = "Pretraga objekata";
            this.pretragaObjekataToolStripMenuItem.Click += new System.EventHandler(this.pretragaObjekataToolStripMenuItem_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPocetna";
            this.Text = "frmPocetna";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem prikazKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazObjekataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaObjekataToolStripMenuItem;
    }
}



