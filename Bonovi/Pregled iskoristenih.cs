using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;

namespace Bonovi
{
    public partial class frmIskoristeni : Form
    {
        Upiti veza = new Upiti();
        int partnerID;
        DataTable podaciZaReport = new DataTable();
        string bonkod;

        public frmIskoristeni()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glPartner.Text != "")
                {
                    DateTime prv = Convert.ToDateTime(dtpOdKada.Text);
                    DateTime drug = Convert.ToDateTime(dtpDoKada.Text);
                    partnerID = Convert.ToInt32(glPartner.EditValue);

                    this.bonoviTableAdapter.iskoristeni(this.izdani_bonovi.bonovi, prv, drug, partnerID);

                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                    DataTable statistika = new DataTable();

                    //MessageBox.Show("select (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO");
                    //veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);
                    veza.ExecuteQuery("select (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = " + partnerID + "  and  bon_datumizrade between '" + prvi + "' and '" + drugi + "'  and bon_datumkoristenja is not null and bon_ponisten = 0 and ifab_ID is null) as NAPLATA , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(ifab_ukupno) from ifabon where partner_pa_ID = " + partnerID + " and  ifab_datum between '" + prvi + "' and '" + drugi + "' and ifab_status <>'S') as UKUPNO ", ref statistika);

                    //(select sum(bon_iznosracuna) from bonovi where partner_pa_ID = " + partnerID + "  and bon_ponisten = 0 and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO
                    if (statistika.Rows.Count > 0)
                    {
                        txtIskoristeno.Text = statistika.Rows[0][1].ToString();
                        txtPlaceno.Text = statistika.Rows[0][2].ToString();
                        txtNaplata.Text = statistika.Rows[0][0].ToString();
                    }
                    dgBonovi.Focus();
                }
                else
                {
                    DateTime prv = Convert.ToDateTime(dtpOdKada.Text);
                    DateTime drug = Convert.ToDateTime(dtpDoKada.Text);
                    //partnerID = Convert.ToInt32(glPartner.EditValue);

                    this.bonoviTableAdapter.iskoristeniSvi(this.izdani_bonovi.bonovi, prv, drug);

                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                    DataTable statistika = new DataTable();

                    //MessageBox.Show("select (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO");
                    //veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);
                    veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where bon_ponisten = 0 and  bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where bon_ponisten = 0 and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where bon_ponisten = 0 and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);

                    if (statistika.Rows.Count > 0)
                    {
                        txtIskoristeno.Text = statistika.Rows[0][1].ToString();
                        txtPlaceno.Text = statistika.Rows[0][4].ToString();
                        txtNaplata.Text = statistika.Rows[0][1].ToString();
                    }
                    dgBonovi.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmIskoristeni_Load(object sender, EventArgs e)
        {
            if(Global.konNova != "")
            {
                this.bonoviTableAdapter.Connection.ConnectionString = Global.konNova;
                this.partnerTableAdapter.Connection.ConnectionString = Global.konNova;
            }
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);

        }

        private void frmIskoristeni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgBon_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
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
            else if (e.KeyCode == Keys.F5) //lista
            {

                try
                {
                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                    podaciZaReport = new DataTable();

                    if (glPartner.Text != "")
                    {
                        veza.ExecuteQuery("select  bonovi.bon_kod, partner.PA_NAZIV, bonovi.bon_rednibroj , bonovi.bon_datumizrade , bonovi.bon_iznos, bonovi.bon_datumkoristenja, bonovi.bon_iznosracuna, bonovi.ifab_ID, concat(operater.op_ime,'',operater.op_prezime), bon_ponisten , bonovi.bon_kasa, bonovi.bon_vazido, bonovi.bon_racunnakasi, poslovnica.po_naziv, ifabon.ifab_datum, (select sum(bonovi.bon_iznosracuna) from bonovi where bonovi.bon_datumkoristenja is not null) as iskoristeno from operater, bonovi left outer join partner on partner.PA_ID = bonovi.partner_pa_ID left outer join poslovnica on poslovnica.po_id = bonovi.poslovnica_po_ID left outer join ifabon on ifabon.ifab_ID = bonovi.ifab_ID where  operater.op_ID= bonovi.operater_op_ID and  partner.PA_ID = " + glPartner.EditValue + " and bonovi.bon_datumkoristenja is not null and bonovi.bon_datumizrade between '" + prvi + "' and '" + drugi + "'", ref podaciZaReport);

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

                        report.Load(baseDir + "/report/ListaIskoristenih.frx");
                        report.SetParameterValue("partner", glPartner.Text);
                        report.SetParameterValue("naslov", "PREGLED ISKORIŠTENIH BONOVA");
                        report.SetParameterValue("iskoristeno", podaciZaReport.Rows[0][15].ToString());
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
                    else
                    {
                        //ako ne odabere partnera

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

                        report.Load(baseDir + "/report/ListaIskoristenih.frx");
                        report.SetParameterValue("partner", "");
                        report.SetParameterValue("naslov", "PREGLED ISKORIŠTENIH BONOVA");
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
            else if (e.KeyCode == Keys.F7)
            {

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
    }
}

