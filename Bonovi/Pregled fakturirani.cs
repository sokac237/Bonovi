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
    public partial class frmFakturirani : Form
    {
        Upiti veza = new Upiti();
        int partnerID;
        string IFAID;
        DataTable podaciZaReport = new DataTable();
        string datumOD;
        string datumDO;
        string noviBrojFakture;

        public frmFakturirani()
        {
            InitializeComponent();
        }

        private void frmFakturirani_Load(object sender, EventArgs e)
        {
            if (Global.konNova != "")
            {
                this.bonoviTableAdapter.Connection.ConnectionString = Global.konNova;
                this.partnerTableAdapter.Connection.ConnectionString = Global.konNova;
            }
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);
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

                    this.bonoviTableAdapter.Fill(this.fakturirani_bonovi.bonovi, prv, drug, partnerID);

                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                    DataTable statistika = new DataTable();

                    //MessageBox.Show("select (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO");
                    //veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);
                    veza.ExecuteQuery("select (select sum(ifab_ukupno) from ifabon where partner_pa_ID = " + partnerID + " and  ifab_datum between '" + prvi + "' and '" + drugi + "' and ifab_status <>'S') as UKUPNO ", ref statistika);

                    if (statistika.Rows.Count > 0)
                    {
                        txtUkupnoIzdano.Text = statistika.Rows[0][0].ToString();
                    }
                    dgBonovi.Focus();
                }
                else
                {
                    //za sve partnere
                    DateTime prv = Convert.ToDateTime(dtpOdKada.Text);
                    DateTime drug = Convert.ToDateTime(dtpDoKada.Text);
                    //partnerID = Convert.ToInt32(glPartner.EditValue);

                    this.bonoviTableAdapter.FillBy(this.fakturirani_bonovi.bonovi, prv, drug);

                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                    DataTable statistika = new DataTable();

                    //MessageBox.Show("select (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "') as UKUPNO , (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = " + partnerID + " and bon_datumizrade between '" + prvi + "' and '" + drugi + "' and ifab_ID is not null)  as FAKTURIRANO");
                    //veza.ExecuteQuery("select (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"') as UKUPNO , (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is not null and bon_ponisten = 0)  as ISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_datumkoristenja is null)  as NEISKORISTENO, (select sum(bon_iznos) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and bon_ponisten = 1 )  as PONISTENO, (select sum(bon_iznosracuna) from bonovi where partner_pa_ID = "+partnerID+" and bon_datumizrade between '"+prvi+"' and '"+drugi+"' and ifab_ID is not null)  as FAKTURIRANO", ref statistika);
                    veza.ExecuteQuery("select (select sum(ifab_ukupno) from ifabon where ifab_datum between '" + prvi + "' and '" + drugi + "' and ifab_status <>'S') as UKUPNO ", ref statistika);

                    if (statistika.Rows.Count > 0)
                    {
                        txtUkupnoIzdano.Text = statistika.Rows[0][0].ToString();
                    }
                    dgBonovi.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmFakturirani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                pnlAzuriraj.Visible = false;
                dtpIsporuka.Text = DateTime.Now.Date.ToString();
                dtpValuta.Text = DateTime.Now.Date.ToString();
                dtpDokumenta.Text = DateTime.Now.Date.ToString();
            }
        }

        private void dgBonovi_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgBon.RowCount > 0)
            {
                if (e.KeyCode == Keys.F3)
                {

                }
                else if (e.KeyCode == Keys.F5)
                {
                    if (dgBon.RowCount > 0)
                    {
                        try
                        {
                            podaciZaReport = new DataTable();

                            podaciZaReport = fakturirani_bonovi.bonovi.CopyToDataTable();

                            if (dtpDoKada.Text != "" && dtpOdKada.Text != "")
                            {
                                datumOD = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                                datumDO = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                            }

                            //create dataset 
                            DataSet FDataSet = new DataSet();
                            podaciZaReport.TableName = "Artikli";
                            FDataSet.Tables.Add(podaciZaReport);

                            // create report instance
                            Report report = new Report();

                            // load the existing report
                            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                            report.Load(baseDir + "/report/FakturiraniLista.frx");
                            report.SetParameterValue("datumOD", datumOD);
                            report.SetParameterValue("datumDO", datumDO);

                            // register the dataset
                            report.RegisterData(FDataSet);

                            //dizajn
                            //report.Design();

                            // run the report
                            report.Show();

                            // free resources used by report
                            report.Dispose();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                else if (e.KeyCode == Keys.F8)
                {
                    report();
                }
                else if (e.KeyCode == Keys.F9)
                {
                    DataTable IFAStornoModul = new DataTable();

                    veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'IFABONSTORNO' ", ref IFAStornoModul);

                    if (IFAStornoModul.Rows.Count > 0)
                    {

                        System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                        if (row != null)
                        {
                            IFAID = row[0].ToString();

                            DialogResult result;
                            result = MessageBox.Show("Želite stornirati račun broj: " + row[0].ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                            if (result == DialogResult.Yes)
                            {
                                veza.ExecuteQuery("Update ifabon set ifab_status = 'S' where ifab_ID = " + IFAID + " ");

                                //update bonovi gdje je prethodni ifab_ID treba ga maknut

                                veza.ExecuteQuery("update bonovi set ifab_ID = null where ifab_ID = " + IFAID + "");

                                btnPrikazi.PerformClick();
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    DataTable IFAStornoModul = new DataTable();

                    veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'IFABONIZMJENA' ", ref IFAStornoModul);

                    if (IFAStornoModul.Rows.Count > 0)
                    {

                        System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                        if (row != null)
                        {

                            //provjeri da nije knjižen
                            //string aa = row["ifab_datumknjizenja"].ToString();
                            if (row["ifab_datumknjizenja"].ToString() == "")
                            {
                                DataTable podaci = new DataTable();
                                IFAID = row[0].ToString();

                                pnlAzuriraj.Visible = true;
                                //napuni datume
                                dtpDokumenta.Focus();
                                dtpValuta.Focus();
                                dtpIsporuka.Focus();
                                veza.ExecuteQuery("Select ifab_datum, ifab_valuta, ifab_isporuka, ifab_napomena from ifabon  where ifab_ID = " + IFAID + " ", ref podaci);

                                //popuni podatke u polja

                                if (podaci.Rows.Count > 0)
                                {
                                    string a = podaci.Rows[0][0].ToString();
                                    dtpDokumenta.Text = a;
                                    dtpValuta.Text = podaci.Rows[0][1].ToString();
                                    dtpIsporuka.Text = podaci.Rows[0][2].ToString();
                                    txtOpis.Text = podaci.Rows[0][3].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void report()
        {
            try
            {
                System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    noviBrojFakture = row[0].ToString();
                    partnerID = Convert.ToInt32(row[7]);
                }
                DataTable partner = new DataTable();

                veza.ExecuteQuery("select partner.PA_NAZIV, partner.PA_ADRESA, mjesto.mj_naziv, mjesto.mj_posta, partner.PA_OIB, partner.PA_SIFRA from mjesto, partner where partner.mjesto_mj_ID = mjesto.mj_ID and partner.PA_ID = " + partnerID + "", ref partner);
                DataTable porez = new DataTable();

                veza.ExecuteQuery("SELECT  p1.pz_posto, SUM( p1.pr_iznosneto) as 'Vrijednost' , SUM( p1.pr_porezIznos) as 'Porez' FROM  ifabonstavka p1 WHERE p1.ifab_ID = " + noviBrojFakture + " GROUP BY 1 ORDER BY 1 DESC", ref porez);
                DataTable zaglavlje = new DataTable();

                veza.ExecuteQuery("select ifabon.*, concat (operater.op_ime, ' ', operater.op_prezime) as operater from operater, ifabon where ifabon.ifab_operater = operater.op_ID and  ifab_ID = " + noviBrojFakture + "", ref zaglavlje);

                //DataTable stavke = new DataTable();
                //veza.ExecuteQuery("select  ifabonstavka.* , poslovnica.po_naziv from ifabonstavka left outer join poslovnica on poslovnica.po_sifra = ifabonstavka.pr_po_sifra", ref stavke);

                DataTable stavke = new DataTable();
                veza.ExecuteQuery("select  ifabonstavka.*  from ifabonstavka where ifabonstavka.ifab_ID= "+noviBrojFakture+"", ref stavke);

                //select  ifabonstavka.*  from ifabonstavka where ifabonstavka.ifab_ID= 32742

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

                report.Load(baseDir + "/report/Faktura2.frx");

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

        private void dtpOdKada_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpDoKada_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpDoKada_Enter(object sender, EventArgs e)
        {
            dtpDoKada.Format = DateTimePickerFormat.Short;
            if (dtpDoKada.Text == " ")
            {
                dtpDoKada.Value = DateTime.Now;
            }
        }

        private void dtpOdKada_Enter(object sender, EventArgs e)
        {
            dtpOdKada.Format = DateTimePickerFormat.Short;
            if (dtpOdKada.Text == " ")
            {
                dtpOdKada.Value = DateTime.Now;
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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlAzuriraj.Visible == true)
                {
                    string datum = Convert.ToDateTime(dtpDokumenta.Text).ToString("yyyy-MM-dd");
                    string isporuka = Convert.ToDateTime(dtpIsporuka.Text).ToString("yyyy-MM-dd");
                    string valuta = Convert.ToDateTime(dtpValuta.Text).ToString("yyyy-MM-dd");

                    veza.ExecuteQuery("update ifabon set ifab_datum = '"+datum+"', ifab_valuta = '"+valuta+"', ifab_isporuka = '"+isporuka+"', ifab_napomena = '"+txtOpis.Text+"'  where ifab_ID = " + IFAID + "");

                    MessageBox.Show("Uspješno ste ažurirali fakturu!");
                    pnlAzuriraj.Visible = false;
                    dtpIsporuka.Text = DateTime.Now.Date.ToString();
                    dtpValuta.Text = DateTime.Now.Date.ToString();
                    dtpDokumenta.Text = DateTime.Now.Date.ToString();
 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void dtpIsporuka_Enter(object sender, EventArgs e)
        {
            dtpIsporuka.Format = DateTimePickerFormat.Short;
            if (dtpIsporuka.Text == " ")
            {
                dtpIsporuka.Value = DateTime.Now;
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

        private void dtpDokumenta_Enter(object sender, EventArgs e)
        {
            dtpDokumenta.Format = DateTimePickerFormat.Short;
            if (dtpDokumenta.Text == " ")
            {
                dtpDokumenta.Value = DateTime.Now;
            } 
        }

    }
}   
