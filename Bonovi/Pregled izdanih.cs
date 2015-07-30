using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using FastReport;

namespace Bonovi
{
    public partial class frmPregledBonova : Form
    {
        int topRowIndex;
        int   focus;
        string bonkod;
        string brojbona;
        string _oznaka;
        Upiti veza = new Upiti();
        int partnerID;
        DataTable podaciZaReport = new DataTable();


        string IDbona;

        public frmPregledBonova()
        {
            InitializeComponent();
        }

        private void frmPregledBonova_Load(object sender, EventArgs e)
        {
            if (Global.konNova != "")
            {
                this.bonoviTableAdapter.Connection.ConnectionString = Global.konNova;
                this.poslovnicaTableAdapter.Connection.ConnectionString = Global.konNova;
                this.operaterTableAdapter.Connection.ConnectionString = Global.konNova;
                this.partnerTableAdapter.Connection.ConnectionString = Global.konNova;
                
            }

            // TODO: This line of code loads data into the 'operater.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this.operater.poslovnica);
            // TODO: This line of code loads data into the 'operater.operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater.operater);
            this.partnerTableAdapter.Fill(this.partner.partner);
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka= value; }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glPartner.Text != "" && dtpDoKada.Text != "" && dtpOdKada.Text != "")
                {
                    DateTime prv = Convert.ToDateTime(dtpOdKada.Text);
                    DateTime drug = Convert.ToDateTime(dtpDoKada.Text);
                    partnerID = Convert.ToInt32(glPartner.EditValue);

                    if (_oznaka == "I")//izdani
                    {
                        this.bonoviTableAdapter.Fill(this.izdani_bonovi.bonovi, prv, drug, partnerID);
                    }
                    else
                    {
                        this.bonoviTableAdapter.iskoristeni(this.izdani_bonovi.bonovi, prv, drug, partnerID);
                    }

                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                    DataTable statistika = new DataTable();

                    //MessageBox.Show("select (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO");
                    //veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);
                    veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + "   and bon_ponisten = 0 and  bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_ponisten = 0 and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(ifab_ukupno) from ifabon where partner_pa_ID = " + partnerID + " and  ifab_datum between '" + prvi + "' and '" + drugi + "' and ifab_status <>'S') as UKUPNO", ref statistika);

                    if (statistika.Rows.Count > 0)
                    {
                        txtUkupnoIzdano.Text = statistika.Rows[0][0].ToString();
                        txtUkupnoIskoristeno.Text = statistika.Rows[0][1].ToString();
                        txtFakturirano.Text = statistika.Rows[0][4].ToString();
                        txtNijeIskoristeno.Text = statistika.Rows[0][2].ToString();
                        txtPonisteno.Text = statistika.Rows[0][3].ToString();
                    }
                    dgBonovi.Focus();
                }
                else if (dtpDoKada.Text != "" && dtpOdKada.Text != "")
                {
                    DateTime prv = Convert.ToDateTime(dtpOdKada.Text);
                    DateTime drug = Convert.ToDateTime(dtpDoKada.Text);
                    //partnerID = Convert.ToInt32(glPartner.EditValue);

                    if (_oznaka == "I")//izdani
                    {
                        this.bonoviTableAdapter.FillBy(this.izdani_bonovi.bonovi, prv, drug);
                    }
                    else
                    {
                        this.bonoviTableAdapter.iskoristeniSvi(this.izdani_bonovi.bonovi, prv, drug);
                    }

                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                    DataTable statistika = new DataTable();

                    //MessageBox.Show("select (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO");
                    //veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);
                    veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where bon_ponisten = 0 and  bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where bon_ponisten = 0 and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where bon_ponisten = 0 and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);

                    if (statistika.Rows.Count > 0)
                    {
                        txtUkupnoIzdano.Text = statistika.Rows[0][0].ToString();
                        txtUkupnoIskoristeno.Text = statistika.Rows[0][1].ToString();
                        txtFakturirano.Text = statistika.Rows[0][4].ToString();
                        txtNijeIskoristeno.Text = statistika.Rows[0][2].ToString();
                        txtPonisteno.Text = statistika.Rows[0][3].ToString();
                    }
                    dgBonovi.Focus();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPregledBonova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                dtpDatKor.Text = "";
                txtBrojKasa.Text = "";
                txtIznosRacuna.Text = "";
                txtRacunKasa.Text = "";
                glOperater.EditValue = 0;
                glPoslovnica.EditValue = 0;
                txtBosoKartica.Text = "";
                pnlAzuriranjeBona.Visible = false;
            }
        }

        private void dgBon_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            string fakturaBR = dgBon.GetRowCellDisplayText(e.RowHandle, dgBon.Columns[7]);
            string datKoristenja = dgBon.GetRowCellDisplayText(e.RowHandle, dgBon.Columns[4]);

            if (e.RowHandle >= 0)
            {
                if (fakturaBR == "" && datKoristenja != "")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }

            string ponisten = dgBon.GetRowCellDisplayText(e.RowHandle, dgBon.Columns[9]);

            if (e.RowHandle >= 0)
            {
                if (ponisten == "Checked")
                {
                    e.Appearance.ForeColor = Color.DarkGray;
                }
            }          
        }

        private void dgBonovi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F2)
                {
                    //report detalji bona
                    if (dgBon.RowCount > 0)
                    {
                        try
                        {
                            System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                            if (row != null)
                            {
                                bonkod = row[0].ToString();
                            }

                            podaciZaReport = new DataTable();

                            veza.ExecuteQuery("select  bonovi.bon_kod, partner.PA_NAZIV, bonovi.bon_rednibroj , bonovi.bon_datumizrade , bonovi.bon_iznos, bonovi.bon_datumkoristenja, bonovi.bon_iznosracuna, bonovi.ifab_ID, concat(operater.op_ime,'',operater.op_prezime), bon_ponisten , bonovi.bon_kasa, bonovi.bon_vazido, bonovi.bon_racunnakasi, poslovnica.po_naziv, ifabon.ifab_datum from operater, bonovi left outer join partner on partner.PA_ID = bonovi.partner_pa_ID left outer join poslovnica on poslovnica.po_id = bonovi.poslovnica_po_ID left outer join ifabon on ifabon.ifab_ID = bonovi.ifab_ID where bonovi.bon_kod = " + bonkod + " and operater.op_ID= bonovi.operater_op_ID", ref podaciZaReport);

                            if (podaciZaReport.Rows.Count > 0)
                            {
                                //DataTable artikli = new DataTable();
                                //artikli = izdani_bonovi.bonovi.CopyToDataTable();

                                //create dataset 
                                DataSet FDataSet = new DataSet();
                                podaciZaReport.TableName = "Artikli";
                                FDataSet.Tables.Add(podaciZaReport);

                                // create report instance
                                Report report = new Report();

                                // load the existing report
                                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                                report.Load(baseDir + "/report/DetaljiBona.frx");
                                //report.SetParameterValue("datumPredaje", DateTime.Now.Date.ToString("dd.MM.yyyy"));

                                // register the dataset
                                report.RegisterData(FDataSet);

                                //dizajn
                                //report.Design();

                                // run the report
                                report.Show();

                                // free resources used by report
                                report.Dispose();
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (e.KeyCode == Keys.F3) //poništi bon
                {
                    DataTable bonPonistiModul = new DataTable();

                    veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'BONPONISTI' ", ref bonPonistiModul);

                    if (bonPonistiModul.Rows.Count > 0)
                    {
                        provjeriBon();
                    }                    
                }
                else if (e.KeyCode == Keys.F4) //report koji nisu iskoristeni
                {
                    if (dgBon.RowCount > 0 && glPartner.Text != "")
                    {
                        try
                        {
                            string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                            string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                            podaciZaReport = new DataTable();

                            veza.ExecuteQuery("select  bonovi.bon_kod, partner.PA_NAZIV, bonovi.bon_rednibroj , bonovi.bon_datumizrade , bonovi.bon_iznos, bonovi.bon_datumkoristenja, bonovi.bon_iznosracuna, bonovi.ifab_ID, concat(operater.op_ime,'',operater.op_prezime), bon_ponisten , bonovi.bon_kasa, bonovi.bon_vazido, bonovi.bon_racunnakasi, poslovnica.po_naziv, ifabon.ifab_datum from operater, bonovi left outer join partner on partner.PA_ID = bonovi.partner_pa_ID left outer join poslovnica on poslovnica.po_id = bonovi.poslovnica_po_ID left outer join ifabon on ifabon.ifab_ID = bonovi.ifab_ID where  operater.op_ID= bonovi.operater_op_ID and  partner.PA_ID = " + glPartner.EditValue + " and bonovi.bon_datumkoristenja is null and bonovi.bon_datumizrade between '" + prvi + "' and '" + drugi + "'", ref podaciZaReport);

                            if (podaciZaReport.Rows.Count > 0)
                            {
                                //DataTable artikli = new DataTable();
                                //artikli = izdani_bonovi.bonovi.CopyToDataTable();

                                //create dataset 
                                DataSet FDataSet = new DataSet();
                                podaciZaReport.TableName = "Artikli";
                                FDataSet.Tables.Add(podaciZaReport);

                                // create report instance
                                Report report = new Report();

                                // load the existing report
                                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                                report.Load(baseDir + "/report/PregledBonova.frx");
                                report.SetParameterValue("partner", glPartner.Text);
                                report.SetParameterValue("naslov", "PREGLED NEISKORIŠTENIH BONOVA ZA:");

                                // register the dataset
                                report.RegisterData(FDataSet);

                                //dizajn
                                //report.Design();

                                // run the report
                                report.Show();

                                // free resources used by report
                                report.Dispose();
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (e.KeyCode == Keys.F5) //report pregled izdanih
                {
    
                        try
                        {
                            string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                            string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                            podaciZaReport = new DataTable();



                            if (glPartner.Text != "")
                            {
                                veza.ExecuteQuery("select  bonovi.bon_kod, partner.PA_NAZIV, bonovi.bon_rednibroj , bonovi.bon_datumizrade , bonovi.bon_iznos, bonovi.bon_datumkoristenja, bonovi.bon_iznosracuna, bonovi.ifab_ID, concat(operater.op_ime,'',operater.op_prezime), bon_ponisten , bonovi.bon_kasa, bonovi.bon_vazido, bonovi.bon_racunnakasi, poslovnica.po_naziv, ifabon.ifab_datum, (select sum(bonovi.bon_iznos) from bonovi where bonovi.bon_datumkoristenja is not null) as iskoristeno from operater, bonovi left outer join partner on partner.PA_ID = bonovi.partner_pa_ID left outer join poslovnica on poslovnica.po_id = bonovi.poslovnica_po_ID left outer join ifabon on ifabon.ifab_ID = bonovi.ifab_ID where  operater.op_ID= bonovi.operater_op_ID and  partner.PA_ID = " + glPartner.EditValue + " and bonovi.bon_ponisten = 0 and bonovi.bon_datumizrade between '" + prvi + "' and '" + drugi + "'", ref podaciZaReport);

                                //DataTable artikli = new DataTable();
                                //artikli = izdani_bonovi.bonovi.CopyToDataTable();

                                //create dataset 
                                DataSet FDataSet = new DataSet();
                                podaciZaReport.TableName = "Artikli";
                                FDataSet.Tables.Add(podaciZaReport);

                                // create report instance
                                Report report = new Report();

                                // load the existing report
                                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                                report.Load(baseDir + "/report/PregledBonova.frx");
                                report.SetParameterValue("partner", glPartner.Text);
                                report.SetParameterValue("naslov", "PREGLED IZDANIH BONOVA ZA:");
                                report.SetParameterValue("iskoristeno", podaciZaReport.Rows[0][15].ToString());
                                report.SetParameterValue("od", prvi);
                                report.SetParameterValue("do", drugi);

                                // register the dataset
                                report.RegisterData(FDataSet);

                                //dizajn
                                report.Design();

                                // run the report
                                report.Show();

                                // free resources used by report
                                report.Dispose();
                            }
                            else
                            {
                                DataTable artikli = new DataTable();
                                artikli = izdani_bonovi.bonovi.CopyToDataTable();

                                //create dataset 
                                DataSet FDataSet = new DataSet();
                                artikli.TableName = "Artikli";
                                FDataSet.Tables.Add(artikli);

                                // create report instance
                                Report report = new Report();

                                // load the existing report
                                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                                report.Load(baseDir + "/report/PregledBonova.frx");
                                report.SetParameterValue("partner", glPartner.Text);
                                report.SetParameterValue("naslov", "PREGLED IZDANIH BONOVA ZA:");
                                //report.SetParameterValue("iskoristeno", podaciZaReport.Rows[0][15].ToString());
                                report.SetParameterValue("od", prvi);
                                report.SetParameterValue("do", drugi);

                                // register the dataset
                                report.RegisterData(FDataSet);

                                //dizajn
                                //report.Design();

                                // run the report
                                report.Show();

                                // free resources used by report
                                report.Dispose();
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    
                }
                else if (e.KeyCode == Keys.F6) //pregled iskoristenih
                {
                    if (dgBon.RowCount > 0 && glPartner.Text != "")
                    {
                        try
                        {
                            string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                            string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                            podaciZaReport = new DataTable();

                            veza.ExecuteQuery("select  bonovi.bon_kod, partner.PA_NAZIV, bonovi.bon_rednibroj , bonovi.bon_datumizrade , bonovi.bon_iznos, bonovi.bon_datumkoristenja, bonovi.bon_iznosracuna, bonovi.ifab_ID, concat(operater.op_ime,'',operater.op_prezime), bon_ponisten , bonovi.bon_kasa, bonovi.bon_vazido, bonovi.bon_racunnakasi, poslovnica.po_naziv, ifabon.ifab_datum, (select sum(bonovi.bon_iznosracuna) from bonovi where bonovi.bon_datumkoristenja is not null) as iskoristeno from operater, bonovi left outer join partner on partner.PA_ID = bonovi.partner_pa_ID left outer join poslovnica on poslovnica.po_id = bonovi.poslovnica_po_ID left outer join ifabon on ifabon.ifab_ID = bonovi.ifab_ID where  operater.op_ID= bonovi.operater_op_ID and  partner.PA_ID = " + glPartner.EditValue + " and bonovi.bon_datumkoristenja is not null and bonovi.bon_datumizrade between '" + prvi + "' and '" + drugi + "'", ref podaciZaReport);

                            if (podaciZaReport.Rows.Count > 0)
                            {
                                //DataTable artikli = new DataTable();
                                //artikli = izdani_bonovi.bonovi.CopyToDataTable();

                                //create dataset 
                                DataSet FDataSet = new DataSet();
                                podaciZaReport.TableName = "Artikli";
                                FDataSet.Tables.Add(podaciZaReport);

                                // create report instance
                                Report report = new Report();

                                // load the existing report
                                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                                report.Load(baseDir + "/report/PregledBonovaIskoristenih.frx");
                                report.SetParameterValue("partner", glPartner.Text);
                                report.SetParameterValue("naslov", "PREGLED ISKORIŠTENIH BONOVA ZA:");
                                report.SetParameterValue("iskoristeno", podaciZaReport.Rows[0][15].ToString());

                                // register the dataset
                                report.RegisterData(FDataSet);

                                //dizajn
                                //report.Design();

                                // run the report
                                report.Show();

                                // free resources used by report
                                report.Dispose();
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (e.KeyCode == Keys.F8) // ponovni ispis bona
                {
                    DataTable bonIspisModul = new DataTable();

                    veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'BONISPIS' ", ref bonIspisModul);

                    if (bonIspisModul.Rows.Count > 0)
                    {
                        if (dgBon.RowCount > 0)
                        {
                            DialogResult result;

                            System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                            if (row != null)
                            {
                                //provjeri da li je odabrani bon već iskorišten ili poništen, ne dozvoli naknadni ispis
                                string aa = row["bon_datumkoristenja"].ToString();


                                if (row["ifab_ID"].ToString() == "" && row["bon_ponisten"].ToString() != "True" && row["bon_datumkoristenja"].ToString() == "")
                                {
                                    result = MessageBox.Show("Svako naknadno ispisivanje bona se bilježi, sigurni ste da želite nastaviti?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                                    if (result == DialogResult.Yes)
                                    {
                                        bonkod = row[0].ToString();
                                        brojbona = row[2].ToString();

                                        DataTable podaci = new DataTable();
                                        veza.ExecuteQuery("select bonovi.bon_kod, bonovi.bon_ID, bonovi.bon_iznos, bonovi.bon_vazido, partner.pa_naziv, partner.pa_sifra, partner.pa_OIB  from partner, bonovi where partner.pa_ID = bonovi.partner_pa_ID and  bon_kod = " + bonkod + " ", ref podaci);
                                        //create dataset 
                                        DataSet FDataSet = new DataSet();

                                        podaci.TableName = "Artikli";

                                        FDataSet.Tables.Add(podaci);

                                        // create report instance
                                        Report report = new Report();

                                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                                        report.Load(baseDir + "/report/NoviBon.frx");

                                        report.SetParameterValue("brojbona", brojbona);

                                        report.RegisterData(FDataSet);

                                        //report.Design();
                                        //report.Show();
                                        report.Print();
                                        //report.PrintSettings.ShowDialog = true;
                                        //report.Prepare();
                                        //report.PrintPrepared();

                                        //report.ShowPrepared();
                                        report.Dispose();
                                        podaci = new DataTable();
                                        //MessageBox.Show("update bonovi set bon_brojIspisa = bon_brojIspisa + 1,  operater_op_ID2 = " + Global.KorisnikID + " where bon_ID in (" + bonoviID + ")");
                                        veza.ExecuteQuery("update bonovi set bon_brojIspisa = bon_brojIspisa + 1, bon_vrijemeIspisa = now(),   operater_op_ID2 = " + Global.KorisnikID + " where bon_kod in (" + bonkod + ")");
                                    }
                                }
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    

                    DataTable bonUnosModul = new DataTable();

                    veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'BONUNOS' ", ref bonUnosModul);

                    if (bonUnosModul.Rows.Count > 0)
                    {

                        pnlAzuriranjeBona.Visible = true;

                        dtpDatKor.Format = DateTimePickerFormat.Short;

                        //dtpDatKor.Text = "";
                        txtBrojKasa.Text = "";
                        txtIznosRacuna.Text = "";
                        txtRacunKasa.Text = "";
                        glOperater.EditValue = 0;
                        glPoslovnica.EditValue = 0;
                        txtBosoKartica.Text = "";

                        topRowIndex = dgBon.TopRowIndex;
                        focus = dgBon.FocusedRowHandle;

                        if (dgBon.RowCount > 0)
                        {
                            System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);

                            if (row != null)
                            {

                                //pokupi podatke
                                IDbona = row["bon_kod"].ToString();

                                //string a = row["bon_datumkoristenja"].ToString();

                                if (row["bon_datumkoristenja"].ToString() != "")
                                {
                                    
                                    //dohvati podatke iz baze
                                    DataTable podaci = new DataTable();

                                    veza.ExecuteQuery("select bon_datumkoristenja, bon_kasa, bon_racunnakasi, bon_iznosracuna, operater_op_ID1, poslovnica_po_ID, bon_bosocard from bonovi where bon_kod = " + IDbona + "", ref podaci);

                                    if (podaci.Rows.Count > 0)
                                    {
                                        //popuni azuriranje bonova s podacima

                                        string a = podaci.Rows[0][0].ToString();
                                        dtpDatKor.Text = a;
                                        txtBrojKasa.Text = podaci.Rows[0][1].ToString();
                                        txtRacunKasa.Text = podaci.Rows[0][2].ToString();
                                        if (podaci.Rows[0][3].ToString() == "")
                                        {
                                            txtIznosRacuna.EditValue = 0;
                                        }
                                        else
                                        {
                                            txtIznosRacuna.EditValue = Convert.ToDecimal(podaci.Rows[0][3]);
                                        }
                                        string aa = podaci.Rows[0][4].ToString();

                                        if (podaci.Rows[0][4].ToString() != "" && podaci.Rows[0][4].ToString() != "null")
                                        {
                                            glOperater.EditValue = Convert.ToInt32(podaci.Rows[0][4]);
                                        }

                                        if (podaci.Rows[0][5].ToString() != "" && podaci.Rows[0][5].ToString() != "null")
                                        {
                                            glPoslovnica.EditValue = Convert.ToInt32(podaci.Rows[0][5]);
                                        }

                                        txtBosoKartica.Text = podaci.Rows[0][6].ToString();

                                        //dtpDatKor.Focus();
                                    }

                                }
                                else
                                {

                                    pnlAzuriranjeBona.Visible = true;
                                    dtpDatKor.Focus();

                                    dtpDatKor.Value = DateTime.Now;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void provjeriBon() //provjerava bon da li je već ponište ili iskorišten, ako nije onda ga poništava
        {
            try
            {
                DataTable bon = new DataTable();
                System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    bonkod = row[0].ToString();
                    brojbona = row[2].ToString();
                }

                veza.ExecuteQuery("Select bon_ID from bonovi where bon_kod = '" + bonkod + "' and bon_datumkoristenja is null and bon_ponisten = 0", ref bon);

                if (bon.Rows.Count == 0)
                {
                    MessageBox.Show("Bon je već iskorišten ili poništen! Ne možete ga ponovno poništiti!");
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Želite poništiti bon broj: " + brojbona + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        veza.ExecuteQuery("update bonovi set bon_ponisten = 1 where bon_kod = " + bonkod + " ");
                        MessageBox.Show("Usješno ste poništili bon");
                        btnPrikazi.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpOdKada_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpDoKada_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");           
        }

        private void dtpOdKada_Enter(object sender, EventArgs e)
        {
            dtpOdKada.Format = DateTimePickerFormat.Short;
            if (dtpOdKada.Text == " ")
            {
                dtpOdKada.Value = DateTime.Now;
            }
        }

        private void dtpDoKada_Enter(object sender, EventArgs e)
        {
            dtpDoKada.Format = DateTimePickerFormat.Short;
            if (dtpDoKada.Text == " ")
            {                
                dtpDoKada.Value = DateTime.Now;
            }           
        }

        private void dtpDatKor_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}"); 
        }

        private void dtpDatKor_Enter(object sender, EventArgs e)
        {
            dtpDatKor.Format = DateTimePickerFormat.Short;
            if (dtpDatKor.Text == " ")
            {
                dtpDatKor.Value = DateTime.Now;
            }    
        }

        private void dgBon_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            pnlAzuriranjeBona.Visible = false;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (pnlAzuriranjeBona.Visible)
            {
                if (dtpDatKor.Text != "" && txtBrojKasa.Text != "" && txtIznosRacuna.Text != "" && txtRacunKasa.Text != ""  && glPoslovnica.Text != "")
                {
                    string datumKoristenja = Convert.ToDateTime(dtpDatKor.Text).ToString("yyyy-MM-dd");

                    string vrijemeOD = "12:00:00";//Convert.ToDateTime(dtpVrijemeOD.Text).ToString("hh:mm:ss");

                    string operater;

                    if (glOperater.Text != "")
                    {
                        operater = glOperater.EditValue.ToString();
                    }
                    else 
                    {
                        operater = "default";
                    }
                    string iznos = Convert.ToString(txtIznosRacuna.Text).Replace(',', '.');
                    //MessageBox.Show("update bonovi set bon_datumkoristenja = '" + datumKoristenja + "' , bon_vrijemekoristenja= '" + vrijemeOD + "'  ,bon_kasa = " + txtBrojKasa.Text + ", bon_racunnakasi=" + txtRacunKasa.Text + ", bon_iznosracuna ='" + iznos + "' , operater_op_ID1 = " + glOperater.EditValue + ", poslovnica_po_ID = " + glPoslovnica.EditValue + ", bon_bosocard= '" + txtBosoKartica.Text + "'  where bon_ID =" + IDbona + "");
                    veza.ExecuteQuery("update bonovi set bon_datumkoristenja = '" + datumKoristenja + "' , bon_vrijemekoristenja= '" + vrijemeOD + "'  ,bon_kasa = " + txtBrojKasa.Text + ", bon_racunnakasi=" + txtRacunKasa.Text + ", bon_iznosracuna ='" + iznos + "' , operater_op_ID1 = " + operater + ", poslovnica_po_ID = " + glPoslovnica.EditValue + ", bon_bosocard= '" + txtBosoKartica.Text + "'  where bon_kod =" + IDbona + "");
                    btnPrikazi.PerformClick();

                    dgBon.TopRowIndex = topRowIndex;
                    dgBon.FocusedRowHandle = focus;

                    dtpDatKor.Text = "";
                    txtBrojKasa.Text = "";
                    txtIznosRacuna.Text = "";
                    txtRacunKasa.Text = ""; 
                    glOperater.EditValue = 0;
                    glPoslovnica.EditValue = 0;
                    txtBosoKartica.Text = "";

                    pnlAzuriranjeBona.Visible = false;
                }
 
            }
        }

        private void txtBrojKasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void txtRacunKasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void txtBosoKartica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void glPartner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (glPartner.Text != "")
                {
                    glPartner.EditValue = 0;
                }
            }
        }

        private void glOperater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glOperater.EditValue = 0;
            }
        }

        private void dgBon_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    string a = row["bon_id"].ToString();
                    int IDbona = Convert.ToInt32(row["bon_id"]);
                    string napomena = row["bon_napomena"].ToString();
    

                    if (napomena != "")
                    {
                        this.bonoviTableAdapter.updateNapomena(napomena, IDbona);
                        //dgStavkeNarudzbe.SetRowCellValue(dgStavkeNarudzbe.FocusedRowHandle, dgStavkeNarudzbe.Columns[20], "Da");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
