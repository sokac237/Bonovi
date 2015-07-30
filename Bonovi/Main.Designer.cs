namespace Bonovi
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bonoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izradaBonovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izdaniBonoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iskorišteniBonoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturiraniBonoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturiranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pripremToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaTrgovineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijenosIFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prenesiStareBonoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arhivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preuzmiArhivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ssKorisnik = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssDatum = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssGodina = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssNazivFirme = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonoviToolStripMenuItem,
            this.preglediToolStripMenuItem,
            this.fakturiranjeToolStripMenuItem,
            this.pripremToolStripMenuItem,
            this.prijenosIFAToolStripMenuItem,
            this.prenesiStareBonoveToolStripMenuItem,
            this.arhivaToolStripMenuItem,
            this.preuzmiArhivuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bonoviToolStripMenuItem
            // 
            this.bonoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izradaBonovaToolStripMenuItem,
            this.ispisToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazToolStripMenuItem});
            this.bonoviToolStripMenuItem.Name = "bonoviToolStripMenuItem";
            this.bonoviToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.bonoviToolStripMenuItem.Text = "Bonovi";
            // 
            // izradaBonovaToolStripMenuItem
            // 
            this.izradaBonovaToolStripMenuItem.Name = "izradaBonovaToolStripMenuItem";
            this.izradaBonovaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.izradaBonovaToolStripMenuItem.Text = "Izrada bonova";
            this.izradaBonovaToolStripMenuItem.Click += new System.EventHandler(this.izradaBonovaToolStripMenuItem_Click);
            // 
            // ispisToolStripMenuItem
            // 
            this.ispisToolStripMenuItem.Enabled = false;
            this.ispisToolStripMenuItem.Name = "ispisToolStripMenuItem";
            this.ispisToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ispisToolStripMenuItem.Text = "Ispis";
            this.ispisToolStripMenuItem.Visible = false;
            this.ispisToolStripMenuItem.Click += new System.EventHandler(this.ispisToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izdaniBonoviToolStripMenuItem,
            this.iskorišteniBonoviToolStripMenuItem,
            this.fakturiraniBonoviToolStripMenuItem});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // izdaniBonoviToolStripMenuItem
            // 
            this.izdaniBonoviToolStripMenuItem.Name = "izdaniBonoviToolStripMenuItem";
            this.izdaniBonoviToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.izdaniBonoviToolStripMenuItem.Text = "Izdani bonovi";
            this.izdaniBonoviToolStripMenuItem.Click += new System.EventHandler(this.izdaniBonoviToolStripMenuItem_Click);
            // 
            // iskorišteniBonoviToolStripMenuItem
            // 
            this.iskorišteniBonoviToolStripMenuItem.Name = "iskorišteniBonoviToolStripMenuItem";
            this.iskorišteniBonoviToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.iskorišteniBonoviToolStripMenuItem.Text = "Iskorišteni bonovi";
            this.iskorišteniBonoviToolStripMenuItem.Click += new System.EventHandler(this.iskorišteniBonoviToolStripMenuItem_Click);
            // 
            // fakturiraniBonoviToolStripMenuItem
            // 
            this.fakturiraniBonoviToolStripMenuItem.Name = "fakturiraniBonoviToolStripMenuItem";
            this.fakturiraniBonoviToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.fakturiraniBonoviToolStripMenuItem.Text = "Fakture";
            this.fakturiraniBonoviToolStripMenuItem.Click += new System.EventHandler(this.fakturiraniBonoviToolStripMenuItem_Click);
            // 
            // fakturiranjeToolStripMenuItem
            // 
            this.fakturiranjeToolStripMenuItem.Name = "fakturiranjeToolStripMenuItem";
            this.fakturiranjeToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.fakturiranjeToolStripMenuItem.Text = "Fakturiranje";
            this.fakturiranjeToolStripMenuItem.Click += new System.EventHandler(this.fakturiranjeToolStripMenuItem_Click);
            // 
            // pripremToolStripMenuItem
            // 
            this.pripremToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaKontoToolStripMenuItem,
            this.zaTrgovineToolStripMenuItem});
            this.pripremToolStripMenuItem.Enabled = false;
            this.pripremToolStripMenuItem.Name = "pripremToolStripMenuItem";
            this.pripremToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pripremToolStripMenuItem.Text = "Pripreme";
            this.pripremToolStripMenuItem.Visible = false;
            // 
            // zaKontoToolStripMenuItem
            // 
            this.zaKontoToolStripMenuItem.Name = "zaKontoToolStripMenuItem";
            this.zaKontoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.zaKontoToolStripMenuItem.Text = "Za konto";
            // 
            // zaTrgovineToolStripMenuItem
            // 
            this.zaTrgovineToolStripMenuItem.Name = "zaTrgovineToolStripMenuItem";
            this.zaTrgovineToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.zaTrgovineToolStripMenuItem.Text = "Za trgovine";
            // 
            // prijenosIFAToolStripMenuItem
            // 
            this.prijenosIFAToolStripMenuItem.Name = "prijenosIFAToolStripMenuItem";
            this.prijenosIFAToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.prijenosIFAToolStripMenuItem.Text = "Prijenos IFA";
            this.prijenosIFAToolStripMenuItem.Click += new System.EventHandler(this.prijenosIFAToolStripMenuItem_Click);
            // 
            // prenesiStareBonoveToolStripMenuItem
            // 
            this.prenesiStareBonoveToolStripMenuItem.Name = "prenesiStareBonoveToolStripMenuItem";
            this.prenesiStareBonoveToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.prenesiStareBonoveToolStripMenuItem.Text = "Prenesi stare bonove";
            this.prenesiStareBonoveToolStripMenuItem.Click += new System.EventHandler(this.prenesiStareBonoveToolStripMenuItem_Click);
            // 
            // arhivaToolStripMenuItem
            // 
            this.arhivaToolStripMenuItem.Name = "arhivaToolStripMenuItem";
            this.arhivaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.arhivaToolStripMenuItem.Text = "Arhiva";
            this.arhivaToolStripMenuItem.Click += new System.EventHandler(this.arhivaToolStripMenuItem_Click);
            // 
            // preuzmiArhivuToolStripMenuItem
            // 
            this.preuzmiArhivuToolStripMenuItem.Name = "preuzmiArhivuToolStripMenuItem";
            this.preuzmiArhivuToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.preuzmiArhivuToolStripMenuItem.Text = "Preuzmi arhivu";
            this.preuzmiArhivuToolStripMenuItem.Click += new System.EventHandler(this.preuzmiArhivuToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssKorisnik,
            this.ssDatum,
            this.ssGodina,
            this.ssNazivFirme});
            this.statusStrip.Location = new System.Drawing.Point(0, 526);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(837, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "StatusStrip";
            // 
            // ssKorisnik
            // 
            this.ssKorisnik.Name = "ssKorisnik";
            this.ssKorisnik.Size = new System.Drawing.Size(49, 17);
            this.ssKorisnik.Text = "Korisnik";
            // 
            // ssDatum
            // 
            this.ssDatum.Name = "ssDatum";
            this.ssDatum.Size = new System.Drawing.Size(43, 17);
            this.ssDatum.Text = "Datum";
            // 
            // ssGodina
            // 
            this.ssGodina.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.ssGodina.Name = "ssGodina";
            this.ssGodina.Size = new System.Drawing.Size(45, 17);
            this.ssGodina.Text = "Godina";
            // 
            // ssNazivFirme
            // 
            this.ssNazivFirme.Margin = new System.Windows.Forms.Padding(300, 3, 0, 2);
            this.ssNazivFirme.Name = "ssNazivFirme";
            this.ssNazivFirme.Size = new System.Drawing.Size(37, 17);
            this.ssNazivFirme.Text = "Firma";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 548);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonovi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bonoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izradaBonovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izdaniBonoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iskorišteniBonoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturiraniBonoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturiranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pripremToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaKontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaTrgovineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijenosIFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prenesiStareBonoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arhivaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ssKorisnik;
        private System.Windows.Forms.ToolStripStatusLabel ssDatum;
        private System.Windows.Forms.ToolStripStatusLabel ssGodina;
        private System.Windows.Forms.ToolStripStatusLabel ssNazivFirme;
        private System.Windows.Forms.ToolStripMenuItem preuzmiArhivuToolStripMenuItem;
    }
}

