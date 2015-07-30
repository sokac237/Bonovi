using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bonovi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ssNazivFirme.Text = "Copyright © Informatika FORTUNO d.o.o. Vukovar";
            frmLogin _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmLogin))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmLogin();
            _frm.ShowDialog();
            _frm.TopMost = true;

            string datum = DateTime.Today.Day.ToString() + "." +
                          DateTime.Today.Month.ToString() + "." +
                          DateTime.Today.Year.ToString();
            ssDatum.Text = "Datum: " + datum;
            ssKorisnik.Text = "Korisnik: " + Global.Korisnik;
            Global.poslGod = DateTime.Now.Year.ToString();
            ssGodina.Text = Global.poslGod;

            if (Global.KorisnikID == "1414" || Global.KorisnikID == "1607")
            {
                //ako su renata i monika onda omogući dohvaćanje starih pojedinacnih bonova
            }
            else
            {
                prenesiStareBonoveToolStripMenuItem.Enabled = false;
            }
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izradaBonovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoviBon _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmNoviBon))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmNoviBon();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void izdaniBonoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledBonova _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledBonova))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledBonova();
            _frm.MdiParent = this;
            _frm.oznaka = "I"; //izdani bonovi
            _frm.Show();
        }

        private void iskorišteniBonoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIskoristeni _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmIskoristeni))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmIskoristeni();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void fakturiraniBonoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFakturirani _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmFakturirani))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmFakturirani();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void fakturiranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFakturiranje _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmFakturiranje))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmFakturiranje();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void prenesiStareBonoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrenesiStare _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPrenesiStare))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPrenesiStare();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void ispisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIspis _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmIspis))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmIspis();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void prijenosIFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrijenosIFA _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmIspis))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPrijenosIFA();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void arhivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZatvoriSveAktivneForme();

            if (Global.poslGod == (DateTime.Now.Year - 1).ToString())
            {
                //ako je već odabrana prošla poslovna godina vrati na tekuCu
                Global.konNova = "";
                statusStrip.BackColor = SystemColors.Control;
                ssGodina.Text = DateTime.Now.Year.ToString();
                Global.poslGod = DateTime.Now.Year.ToString();

            }
            else
            {
                //ponudi odabir prošle poslovne godine

                frmArhiva _Form;

                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmArhiva))
                    {
                        childForm.Focus();
                        return;
                    }
                }
                _Form = new frmArhiva();
                if (_Form.ShowDialog() == DialogResult.OK)
                {
                    statusStrip.BackColor = Color.Red;
                    ssGodina.Text = Global.poslGod;
                }
            }
        }

        private void ZatvoriSveAktivneForme()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (!child.Focused)
                {
                    child.Close();
                }
            }
        }

        private void preuzmiArhivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreuzmiArhivu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPreuzmiArhivu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPreuzmiArhivu();
            _frm.MdiParent = this;
            _frm.Show();
        }
    }
}
