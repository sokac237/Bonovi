using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FastReport;
using System.Collections;

namespace Bonovi
{
    public partial class frmNapraviFakturu : Form
    {
        public static Button osvjezi = new Button();
        Upiti veza = new Upiti();

        string noviBrojFakture;
        string _bonID;
        string _iznosFakture;
        string _IDpartner;
        string _sifraB;
        string _bezStavki;
        string _poSifra;

        string iznos;
        string porez;
        string povratna;
        string ukupno;

        string datum;
        string isporuka;
        string valuta;

        string napomena;

        public frmNapraviFakturu()
        {
            InitializeComponent();
        }

        public string posifra
        {
            get { return _poSifra; }
            set { _poSifra = value; }
        }

        public string BezStavki
        {
            get { return _bezStavki; }
            set { _bezStavki = value; }
        }

        public string IDbona
        {
            get { return _bonID; }
            set { _bonID = value; }
        }

        public string SifraBon
        {
            get { return _sifraB; }
            set { _sifraB = value; }
        }

        public string Iznos
        {
            get { return _iznosFakture; }
            set { _iznosFakture = value; }
        }

        public string Partner
        {
            get { return _IDpartner; }
            set { _IDpartner = value; }
        }


        private void frmNapraviFakturu_Load(object sender, EventArgs e)
        {
            if (Global.konNova != "")
            {
                this.ifabonstavka_tmpTableAdapter.Connection.ConnectionString = Global.konNova;
            }

            if (_bezStavki != "1") 
            {
                osvjezi = btnOsvjezi;
                // TODO: This line of code loads data into the 'stavkeBona.ifabonstavka_tmp' table. You can move, or remove it, as needed.
                this.ifabonstavka_tmpTableAdapter.Fill(this.stavkeBona.ifabonstavka_tmp, Convert.ToInt32(Global.KorisnikID));
                txtBonoviBroj.Text = _sifraB;
                txtIznos.Text = _iznosFakture;
                dgBonovi.Focus();
            }
            else
            {
                btnIzmjena.Visible = true;
                osvjezi = btnOsvjezi;
                txtBonoviBroj.Text = _sifraB;
                txtIznos.Text = _iznosFakture;
                dgBonovi.Focus();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgBon.RowCount > 0)
            {
                try
                {
                    System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);

                    DialogResult result;
                    result = MessageBox.Show("Želite obrisati stavku " +row[3].ToString()+" ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        
                        if (row != null)
                        {
                            if (_bezStavki != "1")
                            {
                                string IDstavke = row[0].ToString();

                                veza.ExecuteQuery("Delete from ifabonstavka_tmp where bonSt_ID = " + IDstavke + " and operater_op_ID = "+Global.KorisnikID+" ");

                                //MessageBox.Show("Uspješno ste obrisali stavku!");

                                this.ifabonstavka_tmpTableAdapter.Fill(this.stavkeBona.ifabonstavka_tmp, Convert.ToInt32(Global.KorisnikID));
                            }
                            else
                            {
                                //bez stavki - roba po izboru
                                veza.ExecuteQuery("delete from ifabonstavka_tmp where operater_op_ID = "+Global.KorisnikID+"");

                                //MessageBox.Show("Uspješno ste obrisali stavke!");

                                this.ifabonstavka_tmpTableAdapter.Fill(this.stavkeBona.ifabonstavka_tmp, Convert.ToInt32(Global.KorisnikID));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            if (dgBon.RowCount > 0)
            {
                try
                {
                    System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);

                    if (row != null)
                    {
                        string IDstavke = row[0].ToString();

                        frmAzurirajStavkeFakture _frm;
                        foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                        {
                            if (childForm.GetType() == typeof(frmAzurirajStavkeFakture))
                            {
                                childForm.Focus();
                                return;
                            }
                        }
                        _frm = new frmAzurirajStavkeFakture();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.IDstavke = IDstavke;
                        _frm.oznaka = "A"; //ažuriranje
                        _frm.stavke = _bezStavki;
                        _frm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgBon.RowCount > 0 && _bezStavki == "1") //ako fakturiramo robu po izboru i postoji stavka u gridu ne dozvoli dodavanje još stavki
                {
                    return;
                }
                else
                {
                    frmAzurirajStavkeFakture _frm;
                    foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                    {
                        if (childForm.GetType() == typeof(frmAzurirajStavkeFakture))
                        {
                            childForm.Focus();
                            return;
                        }
                    }
                    _frm = new frmAzurirajStavkeFakture();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.oznaka = "N"; //nova stavka
                    _frm.sifraPo = _poSifra;
                    _frm.oznakaVrsteFakture = _bezStavki;
                    _frm.partnerID = _IDpartner;
                    _frm.iznosFakture = _iznosFakture;
                    _frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stavkeBona.ifabonstavka_tmp' table. You can move, or remove it, as needed.
            this.ifabonstavka_tmpTableAdapter.Fill(this.stavkeBona.ifabonstavka_tmp, Convert.ToInt32(Global.KorisnikID));
            //dgBon.RefreshData();
            txtBonoviBroj.Text = _sifraB;
            txtIznos.Text = _iznosFakture;
            //dgBonovi.Focus();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgBon.RowCount > 0)
                {
                    decimal sumaFooter = Math.Round(Convert.ToDecimal(dgBon.Columns[19].SummaryItem.SummaryValue),2);
                    decimal sumaZaglavlje = Convert.ToDecimal(txtIznos.Text);

                    decimal razlika = Math.Abs(sumaFooter) - Math.Abs(sumaZaglavlje);

        
                    decimal dozvoljeno = (decimal) 0.01;
                    if (sumaFooter > sumaZaglavlje)
                    {
                        if (Math.Abs(razlika) > dozvoljeno)
                        {
                            MessageBox.Show("Suma stavki trenutke fakture je veća od sume bonova koje trebate fakturirati!!!");
                        }
                        else
                        {
                            panel1.Visible = true;
                            dtpDokumenta.Focus();
                            btnDelete.Visible = false;
                            btnDodaj.Visible = false;
                            btnIzmjena.Visible = false;
                            btnSpremi.Visible = false;
                        }
                    }
                    else
                    {

                        panel1.Visible = true;
                        dtpDokumenta.Focus();
                        btnDelete.Visible = false;
                        btnDodaj.Visible = false;
                        btnIzmjena.Visible = false;
                        btnSpremi.Visible = false;

                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void izracunajBrojdFakture()    
        {
            try
            {
                DataTable brojFakture = new DataTable();
                DataTable IDvrsteDokumenta = new DataTable();

                veza.ExecuteQuery("select dv_ID from dokumentvrsta where dv_sifra = 'IFABON'", ref IDvrsteDokumenta);

                if (IDvrsteDokumenta.Rows.Count > 0)
                {
                    string ID = IDvrsteDokumenta.Rows[0][0].ToString();

                    veza.ExecuteQuery("select se_trenutnibr from serija where dokumentvrsta_dv_ID = " + ID + "", ref brojFakture);

                    if (brojFakture.Rows.Count > 0)
                    {
                        noviBrojFakture = Convert.ToString(Convert.ToInt32(brojFakture.Rows[0][0]) + 1);

                        veza.ExecuteQuery("update ifabonstavka_tmp set ifab_ID = " + noviBrojFakture + " where operater_op_ID= "+Global.KorisnikID+"");
                        veza.ExecuteQuery("update serija set se_trenutnibr = se_trenutnibr +1 where dokumentvrsta_dv_ID = " + ID + "");
                    }
                    else
                    {
                        veza.ExecuteQuery("insert into serija (dokumentVrsta_dv_ID, PG_godina,se_pocetnibr) values ("+ID+", "+DateTime.Now.Year+", 1) ");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNastavi_Click(object sender, EventArgs e) 
        {
            DialogResult result;
            result = MessageBox.Show("Želite fakturirati?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if(result == DialogResult.Yes)
            {
                if (dtpDokumenta.Text != " " && dtpIsporuka.Text != " " && dtpValuta.Text != " ")
                {
                    dohvatipodatke();

                    //izracun broja fakture iz serija
                    izracunajBrojdFakture();

                    veza.ExecuteQuery(@"insert into ifabon (ifab_ID, partner_pa_ID, ifab_datum, ifab_valuta, ifab_isporuka, ifab_iznos, ifab_porez, ifab_povratna, ifab_ukupno, ifab_status, ifab_napomena, ifab_operater) 
                                    values (" + noviBrojFakture + ", " + _IDpartner + ", '" + datum + "', '" + valuta + "', '" + isporuka + "', " + iznos + ", " + porez + ", " + povratna + ", " + ukupno + ", 'Z', '" + napomena + "', '" + Global.KorisnikID + "') ");

                    //prekopiraj stavke iz TMP u pravu tablicu ifabonstavke
                    veza.ExecuteQuery(@"INSERT INTO ifabonstavka (ifab_ID, pr_sifra, pr_naziv, pr_kolicina, pr_povratna, pr_cijenabruto, pr_postorabat, pr_iznosrabat, pr_netocijena, pr_iznosneto, pz_posto, pr_porezIznos) 
                                SELECT ifab_ID, pr_sifra, pr_naziv, pr_kolicina, pr_povratna, pr_cijenabruto, pr_postorabat,pr_iznosrabat, pr_netocijena, pr_iznosneto, pz_posto, pr_porezIznos FROM ifabonstavka_tmp where operater_op_ID ="+Global.KorisnikID+"");


                    //update bonovi
                    veza.ExecuteQuery("update bonovi set ifab_ID = '" + noviBrojFakture + "' where bon_rednibroj in(" + _sifraB + ") and partner_pa_ID = " + _IDpartner + "");

                    frmFakturiranje.osvjezi.PerformClick();
                    report();

                    //obriši stavke artikala od trenutnog korisnika ukoliko postoje

                    veza.ExecuteQuery("delete from ifabonstavka_tmp where operater_op_ID = " + Global.KorisnikID + "");   

                    this.Close();
                }
            }
        }

        private void report()
        {
            try
            {
                DataTable partner = new DataTable();

                veza.ExecuteQuery("select partner.PA_NAZIV, partner.PA_ADRESA, mjesto.mj_naziv, mjesto.mj_posta, partner.PA_OIB, partner.PA_SIFRA from mjesto, partner where partner.mjesto_mj_ID = mjesto.mj_ID and partner.PA_ID = "+_IDpartner+"", ref partner);
                DataTable porez = new DataTable();

                veza.ExecuteQuery("SELECT  p1.pz_posto, SUM( p1.pr_iznosneto) as 'Vrijednost' , SUM( p1.pr_porezIznos) as 'Porez' FROM  ifabonstavka p1 WHERE p1.ifab_ID = " + noviBrojFakture + " GROUP BY 1 ORDER BY 1 DESC", ref porez);
                
                DataTable zaglavlje = new DataTable();

                veza.ExecuteQuery("select ifabon.*, concat (operater.op_ime, ' ', operater.op_prezime) as operater from operater, ifabon where ifabon.ifab_operater = operater.op_ID and  ifab_ID = "+noviBrojFakture+"", ref zaglavlje);

                DataTable stavke = new DataTable();
                stavke = stavkeBona.ifabonstavka_tmp.CopyToDataTable();

                //veza.ExecuteQuery("select  ifabonstavka.*  from ifabonstavka where ifabonstavka.ifab_ID= " + noviBrojFakture + "", ref stavke);

                DataSet FDataSet = new DataSet();

                zaglavlje.TableName = "Zaglavlje";
                stavke.TableName = "Stavke";
                porez.TableName = "Porez";
                partner.TableName = "Partner";

                FDataSet.Tables.Add(zaglavlje);
                FDataSet.Tables.Add(stavke);
                FDataSet.Tables.Add(porez);
                FDataSet.Tables.Add(partner);

                // create report instance
                Report report = new Report();

                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();

                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                report.Load(baseDir + "/report/Faktura.frx");

                report.RegisterData(FDataSet);

                //report.Design();

                report.Show();

                report.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dohvatipodatke()
        {
            try
            {
                DataTable podaci = new DataTable();
                veza.ExecuteQuery("select sum(pr_iznosneto) as iznos, sum(pr_porezIznos) as porez, sum(pr_povratna) as povratna,sum( pr_iznosneto + pr_porezIznos + pr_povratna) as ukupno from ifabonstavka_tmp where operater_op_ID ="+Global.KorisnikID+"", ref podaci);

                if (podaci.Rows.Count > 0)
                {
                    iznos = Convert.ToString(podaci.Rows[0][0]).Replace(',', '.');
                    porez = Convert.ToString(podaci.Rows[0][1]).Replace(',', '.');
                    povratna = Convert.ToString(podaci.Rows[0][2]).Replace(',', '.');
                    ukupno = Convert.ToString(podaci.Rows[0][3]).Replace(',', '.');

                    datum = Convert.ToDateTime(dtpDokumenta.Text).ToString("yyyy-MM-dd");
                    isporuka = Convert.ToDateTime(dtpIsporuka.Text).ToString("yyyy-MM-dd");
                    valuta = Convert.ToDateTime(dtpValuta.Text).ToString("yyyy-MM-dd");

                    napomena = txtOpis.Text.Trim();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNapraviFakturu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dtpDokumenta_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpValuta_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpIsporuka_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpDokumenta_Enter(object sender, EventArgs e)
        {
            dtpDokumenta.Format = DateTimePickerFormat.Short;
            if (dtpDokumenta.Text == " ")
            {
                dtpDokumenta.Value = DateTime.Now;
            }
        }

        private void dtpValuta_Enter(object sender, EventArgs e)
        {
            dtpValuta.Format = DateTimePickerFormat.Short;
            if (dtpValuta.Text == " ")
            {
                dtpValuta.Value = DateTime.Now;
            }
        }

        private void dtpIsporuka_Enter(object sender, EventArgs e)
        {
            dtpIsporuka.Format = DateTimePickerFormat.Short;
            if (dtpIsporuka.Text == " ")
            {
                dtpIsporuka.Value = DateTime.Now;
            }
        }
    }
}
