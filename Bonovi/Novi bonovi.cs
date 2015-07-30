using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Configuration;
using FastReport;

namespace Bonovi
{
    public partial class frmNoviBon : Form
    {
        //private const string PRINTER_NAME = "\\\\2412-KASA02\\zelja";
        string PRINTER_NAME;
        Upiti veza = new Upiti();
        DataTable tablica = new DataTable();
        string barkod;
        string rjesenjeModulo;
        int bonID;
        string sifraPartner;
        string oib;

        int rednibrojZaPartnera;

        string bonoviID = "";

        public frmNoviBon()
        {
            InitializeComponent();
        }

        private void frmNoviBon_Load(object sender, EventArgs e)
        {
            if (Global.konNova != "")
            {
                this.partnerTableAdapter.Connection.ConnectionString = Global.konNova;
            }
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);
            progressBar1.Visible = false;

            DataTable bonIzradaModul = new DataTable();

            veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'BONIZRADI' ", ref bonIzradaModul);

            if (bonIzradaModul.Rows.Count > 0)
            {
                //dopusti pravljenje
            }
            else
            {
                btnNapravi.Enabled = false;
                btnReset.Enabled = false;
            }

        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void procitajNazivPrintera()
        {
            string line;

            // Read the file and display it line by line.
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

            System.IO.StreamReader file = new System.IO.StreamReader(baseDir + "\\Printer.txt");
            while ((line = file.ReadLine()) != null)
            {
                PRINTER_NAME = line;
            }

            file.Close();
        }

        private void frmNoviBon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable prazna = new DataTable();

            txtCijenaLetka.Text = "";
            txtBrojKomada.Text = "";
            dtpVaziOd.Text = DateTime.Now.Date.ToString();
            dgBonovi.DataSource = prazna;
            progressBar1.Visible = false;
            glPartner.EditValue = 0;
            glPartner.Focus();
        }

        private void btnNapravi_Click(object sender, EventArgs e)
        {
            if (txtBrojKomada.Text != "" && txtCijenaLetka.Text != "" && glPartner.Text != "")
            {
                try
                {
                    bonoviID = "";
                    DialogResult result;
                    tablica.Columns.Clear();
                    tablica.Rows.Clear();
                    progressBar1.Visible = true;

                    result = MessageBox.Show("Želite napraviti ove bonove?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        tablica.Columns.Add("Barkod", typeof(string));
                        tablica.Columns.Add("Potvrda broj", typeof(string));
                        tablica.Columns.Add("Iznos", typeof(string));
                        tablica.Columns.Add("Važi do", typeof(string));
                        tablica.Columns.Add("Partner", typeof(string));
                        tablica.Columns.Add("Šifra partnera", typeof(string));
                        tablica.Columns.Add("OIB", typeof(string));
                        partnersifra();

                        btnNapravi.Enabled = false;
                        int i;
                        int brojKomada = Convert.ToInt32(txtBrojKomada.EditValue);
                        for (i = 0; i < brojKomada; i++)
                        {
                            progressBar1.Maximum = brojKomada;
                            timer1.Interval = 1;
                            progressBar1.Increment(1);
                            Spremi();
                            izracunajBarkod();
                            veza.ExecuteQuery("update bonovi set bon_kod = " + barkod + " where bon_ID = " + bonID + "");

                            string iznos = Convert.ToString(txtCijenaLetka.EditValue);

                            tablica.Rows.Add(barkod, rednibrojZaPartnera, iznos, dtpVaziOd.Text, glPartner.Text, sifraPartner, oib);

                            if (bonoviID != "")
                            {
                                bonoviID = bonoviID + ",";
                            }
                            bonoviID = bonoviID + bonID;

                        }
                        this.dgBonovi.DataSource = tablica;
                        dgBonovi.RefreshDataSource();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnNapravi.Enabled = true;
                }

                if (progressBar1.Value == progressBar1.Maximum)
                {
                    timer1.Stop();
                    btnNapravi.Enabled = true;
                    label5.Text = "Uspješno ste dodali bonove. Možete ih vidjeti na pregledu.";
                }
                printaj();
            }
        }

        private void odrediSljedeciRedniBrojPartnera()
        {
            try
            {
                DataTable rednibroj = new DataTable();
                //DataTable bon = new DataTable();
                veza.ExecuteQuery("select  max(bon_rednibroj) as rednibroj from bonovi where partner_pa_ID = " + glPartner.EditValue + "", ref rednibroj);


                //veza.ExecuteQuery("select bon_rednibroj as rednibroj from bonovi", ref bon);

                //if (bon.Rows.Count == 0)
                //{
                //    rednibrojZaPartnera = 3971;
                //}
                //else
                //{

                //    veza.ExecuteQuery("select max(bon_rednibroj) as rednibroj from bonovi", ref rednibroj);
                //    rednibrojZaPartnera = Convert.ToInt32(rednibroj.Rows[0][0]);
                //    rednibrojZaPartnera = rednibrojZaPartnera + 1;
                //}

                string a = rednibroj.Rows[0][0].ToString();
                if (rednibroj.Rows.Count > 0)
                {
                    if (rednibroj.Rows[0][0].ToString() == "")
                    {
                        //rednibrojZaPartnera = 3970;
                        rednibrojZaPartnera = 1;

                    }
                    else
                    {
                        rednibrojZaPartnera = Convert.ToInt32(rednibroj.Rows[0][0]);
                        rednibrojZaPartnera = rednibrojZaPartnera + 1;
                    }
                }
                else
                {

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void partnersifra()
        {
            try
            {
                DataTable partner = new DataTable();
                veza.ExecuteQuery("select pa_sifra, pa_oib from partner where pa_ID = " + glPartner.EditValue + "", ref partner);
                if (partner.Rows.Count == 1)
                {
                    sifraPartner = partner.Rows[0][0].ToString();
                    oib = partner.Rows[0][1].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Spremi()
        {

             MySqlConnection conn;
        
        string ConnectionString;



           
            try
            {
                odrediSljedeciRedniBrojPartnera();


                if (Global.konNova != "")
                {
                    ConnectionString = Global.konNova;

                }
                else
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["Bonovi.Properties.Settings.boso2011ConnectionString"].ConnectionString;
                }


                //string ConnectionString = "Server = 192.168.0.104.; Database=odobrenja; Uid=admin10; Pwd=movema10;";
                conn = new MySqlConnection();
                
                conn.ConnectionString = ConnectionString;

            
                
                MySqlCommand comm = new MySqlCommand("fk_dohvati_ID_bona", conn);
                comm.CommandType = CommandType.StoredProcedure;

                MySqlParameter prm = new MySqlParameter("partner", MySqlDbType.Int16);
                prm.Direction = ParameterDirection.Input;
                prm.Value = glPartner.EditValue;
                comm.Parameters.Add(prm);

                prm = new MySqlParameter("redniBroj", MySqlDbType.Int16);
                prm.Direction = ParameterDirection.Input;
                prm.Value = rednibrojZaPartnera;
                comm.Parameters.Add(prm);

                prm = new MySqlParameter("iznos", MySqlDbType.Double);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Convert.ToDouble(txtCijenaLetka.EditValue);
                comm.Parameters.Add(prm);

                prm = new MySqlParameter("vazido", MySqlDbType.Date);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Convert.ToDateTime(dtpVaziOd.Text).ToString("yyyy-MM-dd");
                comm.Parameters.Add(prm);

                prm = new MySqlParameter("operaterID", MySqlDbType.Int16);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Global.KorisnikID;
                comm.Parameters.Add(prm);

                MySqlParameter retval = comm.Parameters.Add("@asd", MySqlDbType.VarChar);
                retval.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();

                string retunvalue = (string)comm.Parameters["@asd"].Value;
                bonID = Convert.ToInt32(retunvalue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void izracunajBarkod()
        {
            //racunanje barkod
            //pocinje od 300000 + bonID
            try
            {
                DataTable bonkod = new DataTable();

                veza.ExecuteQuery("select max(bon_kod) from bonovi", ref bonkod);



                //int pocetak = 300000 + bonID;

                //prvih 6 znakova se povečava za +1 i modulo racuna zadnje dvije znamenke
                //int pocetak = 261976 + bonID;

                int pocetak = Convert.ToInt32(bonkod.Rows[0][0].ToString().Substring(0, 6)) + 1;

                string izraz = Convert.ToString(pocetak);

                barkod = pocetak + Modulo_11(izraz) + Modulo_EAN(izraz + rjesenjeModulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string Modulo_11(string izraz)
        {
            string result;
            if (izraz != izraz.ToString())
            {
                izraz = izraz.ToString().Trim();
            }
            else
            {
                izraz.Trim();
            }

            int Modul_11_ZBROJ = 0;
            int ponder = 1;
            int i;

            for (i = izraz.Length - 1; i >= 0; i--)
            {
                ponder++;
                Modul_11_ZBROJ = Modul_11_ZBROJ + Convert.ToInt32(izraz.Substring(i, 1)) * ponder;
            }

            int ostatak;

            ostatak = Modul_11_ZBROJ - 11 * (Modul_11_ZBROJ / 11);


            int Modul_11_KONTROL = 11 - ostatak;

            if (Modul_11_KONTROL >= 10)
            {
                rjesenjeModulo = Convert.ToString(0);
                return result = Convert.ToString(0);
            }
            else
            {
                rjesenjeModulo = Modul_11_KONTROL.ToString().Trim();
                return result = Modul_11_KONTROL.ToString().Trim();
            }
        }

        public string Modulo_EAN(string izraz)
        {
            string result2;
            decimal j = 0;
            if (izraz != izraz.ToString())
            {
                izraz = izraz.ToString().Trim();
            }
            else
            {
                izraz.Trim();
            }

            int Modul_EAN_ZBROJ = 0;
            int i;
            for (i = izraz.Length - 1; i >= 0; i--)
            {
                j++;

                decimal a = j / 2;
                if (j / 2 == Math.Truncate(Convert.ToDecimal(j / 2)))
                {
                    Modul_EAN_ZBROJ = Modul_EAN_ZBROJ + Convert.ToInt32(izraz.Substring(i, 1));
                }
                else
                {
                    Modul_EAN_ZBROJ = Modul_EAN_ZBROJ + Convert.ToInt32(izraz.Substring(i, 1)) * 3;
                }
            }

            int dodatak;

            dodatak = 10 + (10 * (Modul_EAN_ZBROJ / 10));

            int Modul_EAN_KONTROL = dodatak - Modul_EAN_ZBROJ;

            if (Modul_EAN_KONTROL == 10)
            {
                return result2 = Convert.ToString(0); ;
            }
            else
            {
                return result2 = Modul_EAN_KONTROL.ToString().Trim();
            }
        }

        private void printaj()
        {
            if (dgBon.RowCount > 0)
            {
                try
                {
                    //procitajNazivPrintera();

                    //string skladisteBroj = txtSkladiste.Text;
                    //string brojNarudzbe = txtBrojNarudzbe.Text;
                    //string trgovina = txtNazivTrgovine.Text;
                    //string trgovinasifra = txtSifraTrgovine.Text;
                    //veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

                    if (dgBon.RowCount > 0)
                    {
                        //create dataset 
                        DataSet FDataSet = new DataSet();

                        tablica.TableName = "Artikli";

                        FDataSet.Tables.Add(tablica);

                        
                        // create report instance
                        Report report = new Report();

                        

                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                        report.Load(baseDir + "/report/Novi.frx");
                        
                        report.RegisterData(FDataSet);

                        //report.Design();
                        //report.Show();
                        //report.PrintSettings.ShowDialog = false;
                        //report.PrintSettings.Printer = PRINTER_NAME;
                        report.Prepare();
                        //report.PrintPrepared();

                        report.Print();

                        //report.ShowPrepared();
                        report.Dispose();
                        //tablica = new DataTable();

                        FDataSet.Tables.Remove(tablica);

                        //MessageBox.Show("update bonovi set bon_brojIspisa = bon_brojIspisa + 1,  operater_op_ID2 = " + Global.KorisnikID + " where bon_ID in (" + bonoviID + ")");
                        veza.ExecuteQuery("update bonovi set bon_brojIspisa = bon_brojIspisa + 1,  operater_op_ID2 = " + Global.KorisnikID + " where bon_ID in (" + bonoviID + ")");
                        progressBar1.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtpVaziOd_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpVaziOd_Enter(object sender, EventArgs e)
        {
            dtpVaziOd.Format = DateTimePickerFormat.Short;
            if (dtpVaziOd.Text == " ")
            {
                dtpVaziOd.Value = DateTime.Now;
            }
        }

        private void dtpVaziOd_Leave(object sender, EventArgs e)
        {
            //provjeriti da datum nije prije danas i veći od godine 2020 recimo
            

            if (dtpVaziOd.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Datum do kad vrijedi bon ne smije biti manji od današnjeg datuma!!");
                dtpVaziOd.Focus();
            }


            if (DateTime.Parse(dtpVaziOd.Text) > DateTime.Parse("2025-01-01"))
            {
                MessageBox.Show("Datum do kada vrijedi bon je jako daleko, provjerite!!");
                dtpVaziOd.Focus();
            }
        }
    }
}