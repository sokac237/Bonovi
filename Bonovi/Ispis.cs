using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Advantage.Data.Provider;
using FastReport;
using System.Threading;

namespace Bonovi
{
    public partial class frmIspis : Form
    {
        Upiti veza = new Upiti();
        //int brojac;

        string pa_ID;

        public frmIspis()
        {
            InitializeComponent();
        }



        //private void PokupiPodatke()
        //{
        //    try
        //    {              
        //        spoji se na bazu advantage


        //        DataTable bonovi = new DataTable();

        //        AdsConnection conn = new AdsConnection();

        //        conn.ConnectionString = "data source=T:\\Kartice\\backupbon.add; " + "user id = adssys;  " + "ServerType=REMOTE; TrimTrailingSpaces = true";

        //        conn.Open();

        //        using (AdsCommand cmd = conn.CreateCommand())
        //        {
        //            MessageBox.Show("select pa_sifpa,g_datdok,g_zapisnik,g_odobr,ar_sifra,g_kolic,g_nabcij,g_nabvrij,g_procij,g_provri,ka_broj,g_napom,po_sifpo,po_osoba,g_gotov,g_vrsta from gratisi where g_datdok between '" + datOD + "' and '" + datDO + "'");
        //            cmd.CommandText = "select bonovi.* from bonovi where b_sifbon greater than = '"+ txtBrojBona.Text.Trim()+"'";


        //            using (AdsDataReader reader = cmd.ExecuteReader())
        //            {
        //                bonovi.Load(reader);

        //                if (bonovi.Rows.Count > 0)
        //                {
                           
        //                }
        //            }
        //        }

        //        conn.Close();

        //        kopiraj u tablicu

        //        for (brojac = 0; brojac < dgBon.RowCount; brojac++)
        //        {
        //            System.Data.DataRow row = dgBon.GetDataRow(brojac);

        //            if (row != null)
        //            {
        //                sifraArtikla = row[1].ToString();

        //            }
        //        }
                
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}



        private void btnIspisi_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblPartner.Text != "")
                {
                    DohvatiIDSifra dohvati = new DohvatiIDSifra();
                    pa_ID = dohvati.DohvatiSifID("pa_ID", "partner","pa_sifra = "+txtSifraPartnera.Text.Trim()+"");
                }
                ispis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ispis()
        {

            DataTable podaci = new DataTable();
            veza.ExecuteQuery("select bon_kod, bon_rednibroj, bon_iznos, bon_vazido from bonovi where bon_rednibroj = '" + txtBrojOD.Text + "' and partner_pa_ID = " + pa_ID + "", ref podaci);

            if (podaci.Rows.Count > 0)
            {
                //create dataset 
                DataSet FDataSet = new DataSet();

                podaci.TableName = "Artikli";

                FDataSet.Tables.Add(podaci);

                // create report instance
                Report report = new Report();

                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                report.Load(baseDir + "/report/Novikopija.frx");
                
                report.SetParameterValue("Datum", "31.12.2013.");
                report.SetParameterValue("Naziv", "ILOČKI PODRUMI D.D. ILOK");
                report.SetParameterValue("OIB", "38793818363");
                report.SetParameterValue("Sifra", "1430");

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

                veza.ExecuteQuery("update bonovi set bon_brojIspisa = bon_brojIspisa + 1,  operater_op_ID2 = " + Global.KorisnikID + " where bon_rednibroj in (" + txtBrojOD.Text.Trim() + ")");
            }
            else
            {
                lblPoruka.Text = "Ne postoji bon pod tim brojem!!";
                txtBrojOD.Text = "";
                txtSifraPartnera.Text = "";
                lblPartner.Text = "";
                lblPoruka.Refresh();
                int milliseconds = 5000;

                Thread.Sleep(milliseconds);

                lblPoruka.Text = "";
                lblPoruka.Refresh();
                txtSifraPartnera.Focus();
            }

        }

        private void frmIspis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtSifraPartnera_TextChanged(object sender, EventArgs e)
        {
            DataTable podaci = new DataTable();
            veza.ExecuteQuery("select pa_id, pa_sifra, pa_naziv from partner where pa_sifra like '%"+txtSifraPartnera.Text.Trim()+"'" , ref podaci);
            if (podaci.Rows.Count > 0)
            {
                lblPartner.Text = podaci.Rows[0][2].ToString();
            }
            else
            {
                lblPartner.Text = "";
            }
        }
       
    }
}
