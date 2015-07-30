using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Configuration;
using FastReport;

namespace Bonovi
{
    public partial class frmPrijenosIFA : Form
    {
        Upiti veza = new Upiti();
        DataTable bonovi = new DataTable();
        public static DataSet podaci = new DataSet("stavke");

        int brojac;
        MySqlConnection connection = new MySqlConnection();

        string putanjaPrazna; //di se nalaze prazne tablice
        string putanja; //di se nalaze pune tablice s podacima



        string poSifra;
        string poId;
        string z_broj;


        //report
        string datumOD;
        string datumDO;
        string brojanje;
        string VpSifra;

        public frmPrijenosIFA()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Prikupljam podatke...";
                lblStatus.Refresh();
                btnPrikazi.Enabled = false;
                btnPrenesi.Enabled = false;
                DateTime prv = Convert.ToDateTime(dtpDatumOD.Text);
                DateTime drug = Convert.ToDateTime(dtpDatumDO.Text);

                string OD = Convert.ToDateTime(dtpDatumOD.Text).ToString("yyyy-MM-dd");
                string DO = Convert.ToDateTime(dtpDatumDO.Text).ToString("yyyy-MM-dd");

                //provjeri da li se knjiže bonovi ili IFE

                if (rbBB.Checked)
                {
                    if (dgBon.RowCount > 0)
                    {
                        zaPrijenosIFA.Clear();
                    }

                    if (dgBon2.RowCount > 0)
                    {
                        zaPrijenosBonova.Clear();
                    }

                    //string vrstaPoslovnice;


                    //if (rbDiskonti.Checked)
                    //{
                    //    vrstaPoslovnice = "200";
                    //}
                    //else
                    //{
                    //    vrstaPoslovnice = "300";
                    //}


    
                    //pokupi podatke za knjižiti bonove, tj one koji su iskorišteni u odabranom razdoblju i dodaj u view 

                    //string viewNaziv = "bon" + Global.KorisnikID;

                    //veza.ExecuteQuery("CREATE VIEW " + viewNaziv + " AS select bonovi.bon_kod, bonovi.bon_datumkoristenja, bonovi.partner_pa_ID, bonovi.bon_iznosracuna, bonovi.bon_kasa, bonovi.bon_racunnakasi, bonovi.poslovnica_po_ID, bonovi.z_broj, null as datumBrojanja from bonovi where bonovi.bon_datumkoristenja between '" + OD + "' and '" + DO + "' and ( bonovi.bon_proknjizen <> 'K'or  bonovi.bon_proknjizen is null) and bonovi.bon_ponisten = 0");

                    veza.ExecuteQuery("select bonovi.bon_kod, bonovi.bon_datumkoristenja, bonovi.partner_pa_ID, partner.PA_NAZIV,partner.pa_sifra, bonovi.bon_iznosracuna, bonovi.bon_kasa, bonovi.bon_racunnakasi, bonovi.poslovnica_po_ID, bonovi.z_broj , poslovnica.po_sifra from bonovi, partner, poslovnica where  partner.PA_ID= bonovi.partner_pa_ID  and bonovi.bon_datumkoristenja between '" + OD + "' and '" + DO + "' and ( bonovi.bon_proknjizen <> 'K' or  bonovi.bon_proknjizen is null) and bonovi.bon_ponisten = 0 and poslovnica.po_id= bonovi.poslovnica_po_ID", ref bonovi);

                    // veza.ExecuteQuery("select bonovi.bon_kod, bonovi.bon_datumkoristenja, bonovi.partner_pa_ID, partner.PA_NAZIV,partner.pa_sifra, bonovi.bon_iznosracuna, bonovi.bon_kasa, bonovi.bon_racunnakasi, bonovi.poslovnica_po_ID, bonovi.z_broj , poslovnica.po_sifra from bonovi, partner, poslovnica where  partner.PA_ID= bonovi.partner_pa_ID  and poslovnica.vp_sifra = '" + vrstaPoslovnice + "' and bonovi.bon_datumkoristenja between '" + OD + "' and '" + DO + "' and ( bonovi.bon_proknjizen <> 'K' or  bonovi.bon_proknjizen is null) and bonovi.bon_ponisten = 0 and poslovnica.po_id= bonovi.poslovnica_po_ID", ref bonovi);

                   
                    if (bonovi.Rows.Count > 0)
                    {
                        //nakon dobivenih Z-brojeva odi na 192.168.0.111 baza mpman tablica polkasa i dohvati datum brojanja tog Z- zaključka,
                        //taj datum  bit će datum knjiženja i mora odgovarati unesenom datumu prilikom pretrage

                        string datumBrojanja = Convert.ToDateTime(dtpBrojanje.Text).ToString("yyyy-MM-dd");

                        DateTime datBroj = Convert.ToDateTime(dtpBrojanje.Text);

                        //za svaki bon broj provjeri koji dan mu je izbrojan Z

                        for (brojac = 0; brojac < bonovi.Rows.Count; brojac++)
                        {
                            poId = bonovi.Rows[brojac][8].ToString();
                            poSifra = bonovi.Rows[brojac][10].ToString().Trim();
                            z_broj = bonovi.Rows[brojac][9].ToString();

                            //dohvati sve z_brojeve izbrojane na zadani datum za odabrane bonove
                            string ConnectionString = "Server =192.168.0.111 ; Database=mpman; Uid=admin10; Pwd=movema10;";

                            connection.ConnectionString = ConnectionString;

                            connection.Open();

                            MySqlCommand comm = new MySqlCommand("Select polkasa.PO_SIFRA, polkasa.Z_BROJ, polkasa.POL_DATUMUNOSA from polkasa where polkasa.POL_DATUMUNOSA ='" + datumBrojanja + "' and polkasa.po_sifra ="+poSifra+" and polkasa.z_broj = '"+z_broj+"'  ", connection);

                            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                            adapter.Fill(podaci, "Table");

                            DataTable poda = new DataTable();
                            poda = podaci.Tables["Table"];

                            connection.Close();

                            if (poda.Rows.Count > 0)
                            {
                                //znači da postoji Z_broj izbrojan na odabrani datum brojanja u kojem je iskorišten bon
                                //ažurirati podatak o datumu brojanja u tablici bonova 

                                veza.ExecuteQuery("update bonovi set bon_datumbrojanja = '" + datumBrojanja + "' where poslovnica_po_ID ='" + poId + "' and z_broj = '" + z_broj + "' ");
                                poda.Clear();
                            }
                            else
                            {
                                poda.Clear();
                                podaci.Tables.Clear();
                            }
                        }

                        //konačni rezultat bonova izbrojanih na odabrani dan

                        //this.bonoviPrijenosTableAdapter.Fill(this.zaPrijenosBonova.bonoviPrijenos, vrstaPoslovnice, prv, drug, datBroj);
                        this.bonPrijenosTableAdapter.Fill(this.zaPrijenosBonova.bonPrijenos, prv, drug, datBroj);
                    }
                }
                else
                {
                    //Select do_datum, do_broj, do_vrsta, do_tekst, partner.pa_ID, partner.pa_naziv, do_ukupno, do_proknjizen, do_ntl, do_zakupca from dokument, partner 
                    //where partner.fi_ID = dokument.fi_ID and dokument.pa_ID = partner.pa_ID and do_status ='Z' and (do_proknjizen <>'K' or do_proknjizen is null) and do_vrsta = '" + vrsta + "' and do_datum between '" + Datum + "' and '" + Datum2 + "' and dokument.fi_ID = '" + firmaID + "' and do_valutaVrsta = '"+ valuta +"' 
                    
                    this.ifaPrijenosTableAdapter.Fill(this.zaPrijenosIFA.IfaPrijenos, prv, drug);
                }

                lblStatus.Text = "";
                lblStatus.Refresh();
                btnPrikazi.Enabled = true;
                btnPrenesi.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblStatus.Text = "";
                lblStatus.Refresh();
                btnPrikazi.Enabled = true;
                //btnPrenesi.Enabled = true;
            }
        }

        private void dtpDatumOD_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpDatumDO_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpDatumDO_Enter(object sender, EventArgs e)
        {
            dtpDatumDO.Format = DateTimePickerFormat.Short;
            if (dtpDatumDO.Text == " ")
            {
                dtpDatumDO.Value = DateTime.Now;
            }
        }

        private void dtpDatumOD_Enter(object sender, EventArgs e)
        {
            dtpDatumOD.Format = DateTimePickerFormat.Short;
            if (dtpDatumOD.Text == " ")
            {
                dtpDatumOD.Value = DateTime.Now;
            }
        }
        

        private void procitajParametre()
        {
            List<string> lines = new List<string>();
            int counter = 0;
            string line;            

            // Read the file and display it line by line.
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

            System.IO.StreamReader file = new System.IO.StreamReader(baseDir + "\\Paramet.txt");
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
                counter++;
            }

            file.Close();

                putanjaPrazna = lines[1];
                putanja = lines[3];
            
        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            DialogResult result;

            try
            {
                result = MessageBox.Show("Prenijeti u knjigovodstvo u godinu " + cmbGodina.Text + ". ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return;
                }
                else if (result == DialogResult.Yes && dgBon.RowCount > 0 && rbOK.Checked)
                {       
                    //prijenos ifa

                    lblStatus.Text = "Prenosim podatke...";
                    lblStatus.Refresh();
                    btnPrikazi.Enabled = false;
                    btnPrenesi.Enabled = false;
                    //pročitaj putanju praznih tablica knjige i salda
                    //pročitaj putanje knjiga i salda da možeš obrisati te kopirati prazne tablice

                    procitajParametre();

                    string putanjabrisanje = putanja + cmbGodina.Text + "\\BI\\";

                    if (System.IO.File.Exists(putanjabrisanje + "KNJIGA.DBF") && System.IO.File.Exists(putanjabrisanje + "SALDA.DBF"))
                    {
                        try
                        {
                            System.IO.File.Delete(putanjabrisanje + "KNJIGA.DBF");
                            System.IO.File.Delete(putanjabrisanje + "SALDA.DBF");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            lblStatus.Text = "";
                            lblStatus.Refresh();
                            btnPrikazi.Enabled = true;
                            btnPrenesi.Enabled = true;
                            return;
                        }
                    }
                    //kopiranje praznih tablica

                    string fileName = "KNJIGA.DBF";
                    string fileName1 = "SALDA.DBF";
                    string sourcePath = putanjaPrazna;
                    string targetPath = putanjabrisanje;

                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);

                    string source = System.IO.Path.Combine(sourcePath, fileName1);
                    string dest = System.IO.Path.Combine(targetPath, fileName1);

                    try
                    {
                        System.IO.File.Copy(sourceFile, destFile, true);
                        System.IO.File.Copy(source, dest, true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        lblStatus.Text = "";
                        lblStatus.Refresh();
                        btnPrikazi.Enabled = true;
                        btnPrenesi.Enabled = true;
                        return;
                    }


                    //kopiranje u tablice   
                    for (int i = 0; i < dgBon.RowCount; i++)
                    {
                        System.Data.DataRow row = dgBon.GetDataRow(i);

                        if (row != null)
                        {
                            //provjeri da li je odabran za prijenos
                            if (row[10].ToString() == "Da")
                            {
                                string filepath = putanja  + cmbGodina.Text + "\\BI\\";

                                string brojdokumenta = row[0].ToString(); //dgOdobrenja.CurrentRow.Cells[1].Value.ToString();

                                string ukupno = row[7].ToString();

                                string partner = row[6].ToString();

                                string datumdokumenta = row[1].ToString();
                                string datumisporuke = row[3].ToString();
                                string datumvalute = row[2].ToString();

                                string opis = "Velep.rn." + brojdokumenta;

                                OleDbConnection ccc = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath.Substring(0, filepath.LastIndexOf("\\")) + ";Extended Properties=dBASE IV;");
                                ccc.Open();

                                try
                                {
                                    //knjiga
                                    OleDbCommand cmd = new OleDbCommand("insert into " + filepath + "KNJIGA.dbf (DOKUM,BROJDOKUME, SKBROJSTAV, SKBROJPROT, GKBROJSTAV, DATUMKNJIZ, DATUMDOKUM, ORGAN, KONTO, OPISKNJIZE, DUGUJE, POTRAZUJE) values ('BI', '" + brojdokumenta + "',1,1,1,now(),'" + datumdokumenta + "', 1 ,1200,'" + opis + "', '" + ukupno + "', 0)", ccc);
                                    cmd.ExecuteReader();


                                    OleDbCommand cmd1 = new OleDbCommand("insert into " + filepath + "KNJIGA.dbf (DOKUM,BROJDOKUME, SKBROJSTAV, SKBROJPROT, GKBROJSTAV, DATUMKNJIZ, DATUMDOKUM, ORGAN, KONTO, OPISKNJIZE, DUGUJE, POTRAZUJE) values ('BI', '" + brojdokumenta + "',1,1,2,now(),'" + datumdokumenta + "', 1 ,1203,'" + opis + "', -'" + ukupno + "', 0)", ccc);
                                    cmd1.ExecuteReader();



                                    //salda
                                    OleDbCommand cmd2 = new OleDbCommand("insert into " + filepath + "SALDA.dbf (DOKUM,BROJDOKUME,BROJSTAVKE,ORGAN,PARTNER,KONTO,BROJRACUNA,DATUMKNJIZ,DATUMDOKUM,DATUMDVO,VALUTAPLAC,OPISKNJIZE,DUGUJE,POTRAZUJE,ZATVORENA,PROGRAM, PROGRACUN) values ('BI', '" + brojdokumenta + "',1, 1, '" + partner + "', 1200,'" + brojdokumenta + "',now(),'" + datumdokumenta + "','" + datumisporuke + "', '" + datumvalute + "', '" + opis + "','" + ukupno + "',0,false,'BVR', '" + brojdokumenta + "')", ccc);
                                    cmd2.ExecuteReader();


                                    OleDbCommand cmd3 = new OleDbCommand("insert into " + filepath + "SALDA.dbf (DOKUM,BROJDOKUME,BROJSTAVKE,ORGAN,PARTNER,KONTO,BROJRACUNA,DATUMKNJIZ,DATUMDOKUM,DATUMDVO,VALUTAPLAC,OPISKNJIZE,DUGUJE,POTRAZUJE,ZATVORENA,PROGRAM, PROGRACUN) values ('BI', '" + brojdokumenta + "',2, 1, '" + partner + "', 1203,'" + brojdokumenta + "',now(),'" + datumdokumenta + "','" + datumisporuke + "', '" + datumvalute + "', '" + opis + "',-'" + ukupno + "',0,false,'BVR', '" + brojdokumenta + "')", ccc);
                                    cmd3.ExecuteReader();


                                    veza.ExecuteQuery("update ifabon set ifab_proknjizen = 'K', ifab_datumknjizenja=now() where ifab_ID = '" + brojdokumenta + "'");

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message + " Na dokumentu broj: " + brojdokumenta + " dogodila se greška!");
                                    this.Close();
                                }
                                ccc.Close();
                            }
                        }
                       
                    }

                    lblStatus.Text = "";
                    lblStatus.Refresh();
                    btnPrikazi.Enabled = true;
                    btnPrenesi.Enabled = true;

                    btnPrikazi.PerformClick();
                }
                else if (result == DialogResult.Yes && dgBon2.RowCount > 0 && rbBB.Checked)
                {
                    //prijenos bonova
                    lblStatus.Text = "Prenosim podatke...";
                    lblStatus.Refresh();
                    btnPrikazi.Enabled = false;
                    btnPrenesi.Enabled = false;

                    procitajParametre();


                    string putanjabrisanje = putanja + cmbGodina.Text + "\\BB\\";

                    if (System.IO.File.Exists(putanjabrisanje + "KNJIGA.DBF") && System.IO.File.Exists(putanjabrisanje + "SALDA.DBF"))
                    {
                        try
                        {
                            System.IO.File.Delete(putanjabrisanje + "KNJIGA.DBF");
                            System.IO.File.Delete(putanjabrisanje + "SALDA.DBF");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            lblStatus.Text = "";
                            lblStatus.Refresh();
                            btnPrikazi.Enabled = true;
                            btnPrenesi.Enabled = true;
                            return;
                        }
                    }
                    //kopiranje praznih tablica

                    string fileName = "KNJIGA.DBF";
                    string fileName1 = "SALDA.DBF";
                    string sourcePath = putanjaPrazna;
                    string targetPath = putanjabrisanje;

                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);

                    string source = System.IO.Path.Combine(sourcePath, fileName1);
                    string dest = System.IO.Path.Combine(targetPath, fileName1);

                    try
                    {
                        System.IO.File.Copy(sourceFile, destFile, true);
                        System.IO.File.Copy(source, dest, true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        lblStatus.Text = "";
                        lblStatus.Refresh();
                        btnPrikazi.Enabled = true;
                        btnPrenesi.Enabled = true;
                        return;
                    }

                    int stavka = 0;
                    string filepath = putanja + cmbGodina.Text + "\\BB\\";

                    //kopiranje u tablice   
                    for (int i = 0; i < dgBon2.RowCount; i++)
                    {
                        System.Data.DataRow row = dgBon2.GetDataRow(i);

                        if (row != null)
                        {
                            stavka = stavka +1;                            

                            string bonKod = row[1].ToString(); //dgOdobrenja.CurrentRow.Cells[1].Value.ToString();

                            string bonID = row[0].ToString();

                            string ukupno = row[7].ToString();

                            string partner = row[3].ToString();

                            string partnerNaziv = row[4].ToString();

                            string poslovnicaSifra = row[5].ToString();

                            string datumknjizenja = row[8].ToString(); //datum brojanja

                            string datumdokumenta = row[2].ToString(); //datum koristenja

                            string datumisporuke = row[8].ToString(); //datum brojanja

                            string datumvalute = row[8].ToString(); //datum brojanja + 90 dana

                            DateTime valuta = DateTime.Parse(datumvalute);

                            valuta = valuta.AddDays(90);

                            datumvalute = Convert.ToDateTime(valuta).ToString("dd.MM.yyyy");

                            string opis = partnerNaziv + "  " + bonKod;

                            OleDbConnection ccc = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath.Substring(0, filepath.LastIndexOf("\\")) + ";Extended Properties=dBASE IV;");
                            ccc.Open();

                            try
                            {
                                //knjiga
                                OleDbCommand cmd = new OleDbCommand("insert into " + filepath + "KNJIGA.dbf (DOKUM,BROJDOKUME, SKBROJSTAV, SKBROJPROT, GKBROJSTAV, DATUMKNJIZ, DATUMDOKUM, ORGAN, KONTO, OPISKNJIZE, DUGUJE) values ('BB', 1 ,'" + stavka + "',1," + stavka + ",'" + datumknjizenja + "','" + datumdokumenta + "',  " + poslovnicaSifra + " ,1203,'" + opis + "', '" + ukupno + "')", ccc);
                                cmd.ExecuteReader();


                                //salda
                                OleDbCommand cmd2 = new OleDbCommand("insert into " + filepath + "SALDA.dbf (DOKUM,BROJDOKUME,BROJSTAVKE,ORGAN,PARTNER,KONTO,DATUMKNJIZ,DATUMDOKUM,DATUMDVO,VALUTAPLAC,OPISKNJIZE,DUGUJE) values ('BB', 1, '" + stavka + "', " + poslovnicaSifra + ", '" + partner + "', 1203, '" + datumknjizenja + "','" + datumdokumenta + "','" + datumisporuke + "', '" + datumvalute + "', '" + opis + "','" + ukupno + "')", ccc);
                                cmd2.ExecuteReader();


                                veza.ExecuteQuery("update bonovi set bon_proknjizen = 'K', bon_datumknjizenja=now() where bon_ID = '" + bonID + "'");

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + " Na dokumentu broj: " + bonKod + " dogodila se greška!");
                            }
                            ccc.Close();
                        }
                    }

                    OleDbConnection cc = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath.Substring(0, filepath.LastIndexOf("\\")) + ";Extended Properties=dBASE IV;");
                    cc.Open();

                    try
                    {
                        string datumBrojanja = dtpBrojanje.Text;
                        decimal ukupno =  Convert.ToDecimal(dgBon2.Columns[7].SummaryItem.SummaryValue);;
                        string opis = "PROMET BONOVA - DANA " + datumBrojanja;
                        stavka = stavka +1;
                        //knjiga
                        OleDbCommand cmd = new OleDbCommand("insert into " + filepath + "KNJIGA.dbf (DOKUM,BROJDOKUME,  GKBROJSTAV, DATUMKNJIZ, DATUMDOKUM, ORGAN, KONTO, OPISKNJIZE, DUGUJE,Z_BROJ) values ('BB', 1 ," + stavka + ",'" + datumBrojanja + "','" + datumBrojanja + "', 1 ,10090004,'" + opis + "', -'" + ukupno + "', 'Z-9-999999')", cc);
                        cmd.ExecuteReader();      

                    }
                    catch (Exception)
                    {
                        //this.Close();
                    }
                    cc.Close();
                    
                    lblStatus.Text = "";
                    lblStatus.Refresh();
                    btnPrikazi.Enabled = true;
                    btnPrenesi.Enabled = true;

                    btnPrikazi.PerformClick();
                }

                //kopiranje na G: disk za konto

                if (rbOK.Checked) //kopiranje OK
                {
                    string kop = "\\\\192.168.0.95\\konto\\Prijenos\\BOSO\\" + cmbGodina.Text + "\\";
                    string kopiramu = kop;

                    /* kopiranje IR (salda i knjiga) za trenutnu firmu na G:\ */
                    string fileName = "KNJIGA.DBF";
                    string fileName1 = "SALDA.DBF";
                    string sourcePath = putanja + cmbGodina.Text + "\\BI\\";
                    string targetPath = kopiramu + "BI\\";

                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);

                    string source = System.IO.Path.Combine(sourcePath, fileName1);
                    string dest = System.IO.Path.Combine(targetPath, fileName1);

                    try
                    {
                        System.IO.File.Copy(sourceFile, destFile, true);
                        System.IO.File.Copy(source, dest, true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Close();
                    }

                }
                else //rbBB.checked - kopiranje BB 
                {
                    string kop = "\\\\192.168.0.95\\konto\\Prijenos\\BOSO\\" + cmbGodina.Text + "\\";
                    string kopiramu = kop;

                    /* kopiranje OK (salda i knjiga) za trenutnu firmu na G:\ */
                    string fileName = "KNJIGA.DBF";
                    string fileName1 = "SALDA.DBF";
                    string sourcePath = putanja + cmbGodina.Text +"\\BB\\";
                    string targetPath = kopiramu + "BB\\";

                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);

                    string source = System.IO.Path.Combine(sourcePath, fileName1);
                    string dest = System.IO.Path.Combine(targetPath, fileName1);

                    try
                    {
                        System.IO.File.Copy(sourceFile, destFile, true);
                        System.IO.File.Copy(source, dest, true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Close();
                    }
                }

                MessageBox.Show("Prijenos je završio.");
                //this.Close();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "";
                lblStatus.Refresh();
                btnPrikazi.Enabled = true;
                btnPrenesi.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPrijenosIFA_Load(object sender, EventArgs e)
        {
            if (Global.konNova != "")
            {
                this.bonoviPrijenosTableAdapter.Connection.ConnectionString = Global.konNova;
                this.bonPrijenosTableAdapter.Connection.ConnectionString = Global.konNova;
                this.ifaPrijenosTableAdapter.Connection.ConnectionString = Global.konNova;
            }
            //provjeri ako su renata ili vlatka onda omogući button prenesi ako nisu onda onemogući

            if (Global.KorisnikID == "1600" || Global.KorisnikID == "1607" || Global.KorisnikID =="1967")
            {
                btnPrenesi.Enabled = true;
                btnVrati.Enabled = true;
            }
            else
            {
                btnPrenesi.Enabled = false;
                btnVrati.Enabled = false;
            }
            cmbGodina.Visible = true;
            cmbGodina.Focus();

            cmbGodina.Items.Add(DateTime.Now.Year - 1);
            cmbGodina.Items.Add(DateTime.Now.Year);
            cmbGodina.Text = DateTime.Now.Year.ToString();

            if (rbOK.Checked)
            {
                dgBonovi.Show();
            }
            else
            {
                dgBonovi.Hide();
                dgBonovi2.Show();
            }
        }

        private void frmPrijenosIFA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgBonovi_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    string brojdokumenta = row[0].ToString();

                    if (row["oznaka"].ToString() != "Da")
                    {
                        dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[10], "Da");
                        veza.ExecuteQuery("Update ifabon set ifab_proknjizen = 'P' where ifab_ID = " + brojdokumenta + "");
                    }
                    else
                    {
                        dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[10], "");
                        veza.ExecuteQuery("Update ifabon set ifab_proknjizen = '' where ifab_ID = " + brojdokumenta + "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgBonovi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7) //oznaci za prijenos
            {
                System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    string brojdokumenta = row[0].ToString();

                    if (row[10].ToString() != "Da")
                    {
                        dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[10], "Da");
                        veza.ExecuteQuery("Update ifabon set ifab_proknjizen = 'P' where ifab_ID = "+brojdokumenta+"");
                    }
                    else
                    {
                        dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[10], "");
                        veza.ExecuteQuery("Update ifabon set ifab_proknjizen = '' where ifab_ID = " + brojdokumenta + "");
                    }
                }
            }
        }

        private void dgBon_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            string prijenos = dgBon.GetRowCellDisplayText(e.RowHandle, dgBon.Columns[10]);

            if (e.RowHandle >= 0)
            {

                if (prijenos == "")
                {
                    e.Appearance.ForeColor = Color.Red;
                    //dgBon.RefreshRow(e.RowHandle);
                }
                else
                {
                    e.Appearance.ForeColor = Color.Green;
                    //dgBon.RefreshRow(e.RowHandle);
                }
            }
        }

        private void rbOK_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOK.Checked)
            {
                dgBonovi2.Hide();
                dgBonovi.Show();
                gbOdabirDiskontaIdatBr.Visible = false;
            }
        }

        private void rbBB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBB.Checked)
            {
                dgBonovi.Hide();
                dgBonovi2.Show();
                gbOdabirDiskontaIdatBr.Visible = true;
            }
        }

        private void dtpBrojanje_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dtpBrojanje_Enter(object sender, EventArgs e)
        {
            dtpBrojanje.Format = DateTimePickerFormat.Short;
            if (dtpBrojanje.Text == " ")
            {
                dtpBrojanje.Value = DateTime.Now;
            }
        }


        private void dgBonovi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    DataTable podaciZaReport = new DataTable();

                    if (dgBon2.RowCount > 0)
                    {
                        podaciZaReport = zaPrijenosBonova.bonPrijenos.CopyToDataTable();
                        datumOD = Convert.ToDateTime(dtpDatumOD.Text).ToString("dd.MM.yyyy");
                        datumDO = Convert.ToDateTime(dtpDatumDO.Text).ToString("dd.MM.yyyy");
                        brojanje = Convert.ToDateTime(dtpBrojanje.Text).ToString("dd.MM.yyyy");
                    }
                    else
                    {
                        //upitom pokupi podatke
                        if (dtpBrojanje.Text != "" && dtpDatumOD.Text != "" && dtpDatumDO.Text != "")
                        {
                            datumOD = Convert.ToDateTime(dtpDatumOD.Text).ToString("dd.MM.yyyy");
                            datumDO = Convert.ToDateTime(dtpDatumDO.Text).ToString("dd.MM.yyyy");
                            brojanje = Convert.ToDateTime(dtpBrojanje.Text).ToString("dd.MM.yyyy");

                            string dtmOD = Convert.ToDateTime(dtpDatumOD.Text).ToString("yyyy-MM-dd");
                            string dtmDO = Convert.ToDateTime(dtpDatumDO.Text).ToString("yyyy-MM-dd");
                            string dtmBrojanje = Convert.ToDateTime(dtpBrojanje.Text).ToString("yyyy-MM-dd");

                            if (rbDiskonti.Checked)
                            {
                                VpSifra = "200";
                            }
                            else
                            {
                                VpSifra = "300";
                            }

                            veza.ExecuteQuery(@"select bonovi.bon_ID, bonovi.bon_kod, bonovi.bon_datumkoristenja, partner.PA_SIFRA, partner.PA_NAZIV, poslovnica.po_sifra, poslovnica.po_naziv, bonovi.bon_iznosracuna, bon_datumbrojanja, bonovi.bon_datumizrade,  bonovi.bon_iznos "+
                                             "from bonovi left join partner on partner.PA_ID= bonovi.partner_pa_ID left join poslovnica on poslovnica.po_id = bonovi.poslovnica_po_ID "+
                                             "where poslovnica.vp_sifra = " + VpSifra + " and bonovi.bon_datumkoristenja between '" + dtmOD + "' and '" + dtmDO + "' and bonovi.bon_ponisten = 0  and bonovi.bon_datumbrojanja = '" + dtmBrojanje + "' order by CONVERT(partner.PA_SIFRA, unsigned) , CONVERT( bonovi.bon_kod, unsigned)  ", ref podaciZaReport);
                        }

                    }



                    //create dataset 
                    DataSet FDataSet = new DataSet();
                    podaciZaReport.TableName = "Bonovi";
                    FDataSet.Tables.Add(podaciZaReport);

                    // create report instance
                    Report report = new Report();

                    // load the existing report
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    report.Load(baseDir + "/report/BonoviZaPrijenos.frx");
                    report.SetParameterValue("datumOD", datumOD);
                    report.SetParameterValue("datumDO", datumDO);
                    report.SetParameterValue("brojanje",brojanje);

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

        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (dtpDatumOD.Text != "" && dtpDatumDO.Text != "" && dtpBrojanje.Text != "" && rbBB.Checked)
            {
                DataTable vrati = new DataTable();
                //string tekst;

                //if (rbDiskonti.Checked)
                //{
                //    tekst = "diskonte";
                //    VpSifra = "200";
                //}
                //else
                //{
                //    tekst = "trgovine";
                //    VpSifra = "300";
                //}

                DialogResult result;
                result = MessageBox.Show("Želite vratiti na prijenos dokumente s datumom brojanja  " + dtpBrojanje.Text + " ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


                if (result == DialogResult.Yes)
                {                 

                    string dtmOD = Convert.ToDateTime(dtpDatumOD.Text).ToString("yyyy-MM-dd");
                    string dtmDO = Convert.ToDateTime(dtpDatumDO.Text).ToString("yyyy-MM-dd");
                    string dtmBrojanje = Convert.ToDateTime(dtpBrojanje.Text).ToString("yyyy-MM-dd");


                    veza.ExecuteQuery("select bonovi.bon_ID from bonovi left join poslovnica on poslovnica.po_id = bonovi.poslovnica_po_ID where bonovi.bon_datumkoristenja between '" + dtmOD + "' and '" + dtmDO + "' and bonovi.bon_ponisten = 0  and bonovi.bon_datumbrojanja = '" + dtmBrojanje + "' and bon_proknjizen = 'K'", ref vrati);

                    if (vrati.Rows.Count > 0)
                    {
                        for (int i = 0; i < vrati.Rows.Count; i++)
                        {
                            string ID = vrati.Rows[i][0].ToString();

                            veza.ExecuteQuery("update bonovi set bon_proknjizen = null , bon_datumknjizenja = null where bon_id = " + ID + "");
                        }
                        btnPrikazi.PerformClick();
                    }        
                }
            }
        }
    }
}
