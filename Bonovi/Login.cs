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
    public partial class frmLogin : Form
    {
        Upiti veza = new Upiti();
        int nivo_dozvoljava;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Prijava();
        }

        private void Prijava()
        {
            DataTable Korisnik = new DataTable();

            veza.ExecuteQuery("SELECT * from operater", ref Korisnik);
            if (Korisnik.Rows.Count <= 0)
            {
                MessageBox.Show("Nema autoriziranih korisnika! Dodajte korisnika u bazu.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //autorizacija
            {
                DataTable dt = new DataTable();
                veza.ExecuteQuery("select * from operater where op_sifra = '" + txtKorisnickoIme.Text + "' AND op_lozinka = '" + txtLozinka.Text + "'", ref dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][1].ToString() == txtKorisnickoIme.Text && dt.Rows[0][2].ToString() == txtLozinka.Text)
                {
                    Global.Korisnik = Convert.ToString(dt.Rows[0][3] + " " + dt.Rows[0][4].ToString());
                    Global.KorisnikID = dt.Rows[0][0].ToString();
                    PravaOperatera();
                    if (nivo_dozvoljava == 1)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nemate prava za rad u programu!");
                        Application.Exit();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Niste upisali točne korisničke podatke!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                    txtKorisnickoIme.Focus();
                }
            }
        }

        public void PravaOperatera()
        {
            try
            {
                DataTable operater = new DataTable();
                string id = Global.KorisnikID;
                veza.ExecuteQuery("select op_nivo from operater where op_ID = '" + id + "'", ref operater);
                //string nivo = operater.Rows[0][0].ToString();
                int nivo = Convert.ToInt16(operater.Rows[0][0]);

                if (nivo >= 3)
                {
                    nivo_dozvoljava = 1;
                }
                else
                {
                    nivo_dozvoljava = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtKorisnickoIme_Enter(object sender, EventArgs e)
        {
            txtKorisnickoIme = sender as TextBox;
            if (txtKorisnickoIme != null)
                txtKorisnickoIme.SelectAll();
        }

        private void txtLozinka_Enter(object sender, EventArgs e)
        {
            txtLozinka = sender as TextBox;
            if (txtLozinka != null)
                txtLozinka.SelectAll();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
