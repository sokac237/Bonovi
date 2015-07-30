using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Bonovi
{
    public partial class frmFakturiranje : Form
    {
        int novi = 0; //oznaka za bonove do 31.12.2013 i ove od 1.1.2014. na dalje zbog stope poreza 10 -- > 13, ako je 1 onda je 2014 napravljen bon ako je 0 onda su od prije 1.1.2014.
        public static Button osvjezi = new Button();
        public static DataSet podaci = new DataSet("stavke");
        public static DataSet podaciporez = new DataSet("porez");
        MySqlConnection connection = new MySqlConnection();

        DataTable stavkeTMP = new DataTable();

        string sifraBona;
        Upiti veza = new Upiti();
        int brojac;
        int partnerID;
        string IDbona;
        decimal iznosFaktura = 0;
        //decimal iznosBona = 0;
        int flag;
        string IPadresa;
        string baza;
        string kasa;
        string racunBr;
        string vrijemeKoristenja;
        string datumKoristenja;
        DateTime datumKoristi;
        string poSifra;
        string poID;

        decimal povratna;
        decimal osnovica5;
        decimal postotak5;
        decimal osnovica10;
        decimal postotak10;


        string cijena;


        int otvoriformu = 0; //ako je 0 onda formu za ažuriranje stavke ne otvaraj, ako je 1 onda otvori

        int broj = 0;

        public frmFakturiranje()
        {
            InitializeComponent();
        }

        private void frmFakturiranje_Load(object sender, EventArgs e)
        {
            if (Global.konNova != "")
            {
                this.fakturiranjeTableAdapter.Connection.ConnectionString = Global.konNova;
                this.partnerTableAdapter.Connection.ConnectionString = Global.konNova;
            }
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);
            osvjezi = btnPrikazi;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glPartner.Text != "")
                {
                    partnerID = Convert.ToInt32(glPartner.EditValue);

                    this.fakturiranjeTableAdapter.Fill(this.faturiranje.fakturiranje, partnerID);

                    DataTable statistika = new DataTable();

                    veza.ExecuteQuery("select (select sum(bon_iznosracuna ) from bonovi where partner_pa_ID = " + partnerID + " and bonovi.bon_datumkoristenja is not null and bonovi.ifab_ID is null and bonovi.bon_ponisten = 0 ) as UKUPNO", ref statistika);

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

        private void frmFakturiranje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgBon_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            string faturirati = dgBon.GetRowCellDisplayText(e.RowHandle, dgBon.Columns[7]);

            if (e.RowHandle >= 0)
            {              

                if (faturirati == "")
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

        private void dgBon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    //provjeri datum korištenja bona

                    datumKoristi = DateTime.Parse(row["bon_datumkoristenja"].ToString());

                    if (broj == 0)
                    {
                        if (datumKoristi >= DateTime.Parse("01/01/2014")) //pdv 13 %
                        {
                            novi = 1;
                            broj = 1;
                            Global.postotakoznaka = "13";
                        }
                        else
                        {
                            novi = 0;
                            broj = 1;
                            Global.postotakoznaka = "10";
                        }

                        if (row[7].ToString() != "Da")
                        {
                            dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "Da");
                        }
                        else
                        {
                            dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "");
                        }
                    }
                    else
                    {
                        //sad znamo koji datum je od prvog dokumenta
                        //pa usporedimo datume sljedećih sa tim prvog

                        if (datumKoristi >= DateTime.Parse("01/01/2014") && novi == 1)
                        {
                            if (row[7].ToString() != "Da")
                            {
                                dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "Da");
                                broj++;
                            }
                            else
                            {
                                dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "");
                                broj--;
                            }
                        }
                        else if (datumKoristi < DateTime.Parse("01/01/2014") && novi == 0)
                        {
                            if (row[7].ToString() != "Da")
                            {
                                dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "Da");
                                broj++;
                            }
                            else
                            {
                                dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "");
                                broj--;
                            }
                        }
                        else
                        {
                            if (broj > 0)
                            {
                                
                            }
                            else
                            {
                                novi = 0;
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

        private void dgBonovi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F7) //oznaci za storno ili fakturiranje
                {
                    System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                    if (row != null)
                    {
                        //provjeri datum izdavanja bona

                        datumKoristi = DateTime.Parse(row["bon_datumkoristenja"].ToString());

                        if (broj == 0)
                        {
                            if (datumKoristi >= DateTime.Parse("01/01/2014")) //pdv 13 %
                            {
                                novi = 1;
                                broj = 1;
                                Global.postotakoznaka = "13";
                            }
                            else
                            {
                                novi = 0;
                                broj = 1;
                                Global.postotakoznaka = "10";
                            }

                            if (row[7].ToString() != "Da")
                            {
                                dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "Da");
                            }
                            else
                            {
                                dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "");
                            }
                        }
                        else
                        {
                            //sad znamo koji datum je od prvog dokumenta
                            //pa usporedimo datume sljedećih sa tim prvog

                            if (datumKoristi >= DateTime.Parse("01/01/2014") && novi == 1)
                            {
                                if (row[7].ToString() != "Da")
                                {
                                    dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "Da");
                                    broj++;
                                }
                                else
                                {
                                    dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "");
                                    broj--;
                                }
                            }
                            else if (datumKoristi < DateTime.Parse("01/01/2014") && novi == 0)
                            {
                                if (row[7].ToString() != "Da")
                                {
                                    dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "Da");
                                    broj++;
                                }
                                else
                                {
                                    dgBon.SetRowCellValue(dgBon.FocusedRowHandle, dgBon.Columns[7], "");
                                    broj--;
                                }
                            }
                            else
                            {
                                if (broj > 0)
                                {

                                }
                                else
                                {
                                    novi = 0;
                                }
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.F9) //storno bona    
                {
                    //DataTable bonPonistiModul = new DataTable();

                    //veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'BONPONISTI' ", ref bonPonistiModul);

                    //if (bonPonistiModul.Rows.Count > 0)
                    //{
                    //    System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                    //    if (row != null)
                    //    {
                    //        if (row[7].ToString() == "Da")
                    //        {
                    //            IDbona = row[8].ToString();

                    //            DialogResult result;
                    //            result = MessageBox.Show("Želite stornirati bon broj: " + row[2].ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    //            if (result == DialogResult.Yes)
                    //            {
                    //                veza.ExecuteQuery("Update bonovi set bon_ponisten = 1 where bon_ID = " + IDbona + " ");
                    //                btnPrikazi.PerformClick();
                    //            }
                    //        }
                    //    }
                    //}
                }
                else if (e.KeyCode == Keys.F5)
                {
                    DataTable bonPonistiModul = new DataTable();

                    veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = '" + Global.KorisnikID + "' and opov_modul = 'IFABONIZRADA' ", ref bonPonistiModul);

                    if (bonPonistiModul.Rows.Count > 0)
                    {
                        lblPoruka.Visible = true;
                        lblPoruka.Refresh();
                        iznosFaktura = 0;
                        sifraBona = "";
                        povratna = 0;
                        osnovica5 = 0;
                        osnovica10 = 0;

                        postotak5 = 0;
                        postotak10 = 0;
                        Podaci.osnovica5 = "0";
                        Podaci.osnovica10 = "0";
                        Podaci.postotak5 = "0";
                        Podaci.postotak10 = "0";



                        if (dgBon.RowCount > 0)
                        {
                            DialogResult result;
                            result = MessageBox.Show("Fakturirati sa unosom stavki računa?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                            if (result == DialogResult.Yes)
                            {
                                pokupiPodatke2();
                                //fakturiranje  sa stavkama kojie se unose ručno

                                //obriši stavke artikala od trenutnog korisnika ukoliko postoje

                                veza.ExecuteQuery("delete from ifabonstavka_tmp where operater_op_ID = " + Global.KorisnikID + "");

                                for (brojac = 0; brojac < dgBon.RowCount; brojac++)
                                {
                                    System.Data.DataRow row = dgBon.GetDataRow(brojac);
                                    if (row != null)
                                    {
                                        if (row[7].ToString() == "Da")
                                        {
                                            if (Convert.ToDecimal(row[5]) > Convert.ToDecimal(row[3]))
                                            {
                                                //ako je iznos računa koji treba fakturirati veći od iznosa bona uzmi max iznos bona za fakturirati
                                                iznosFaktura = iznosFaktura + Convert.ToDecimal(row[3]);
                                            }
                                            else
                                            {
                                                iznosFaktura = iznosFaktura + Convert.ToDecimal(row[5]);
                                            }
                                            flag = 1;

                                            if (sifraBona != "")
                                            {
                                                sifraBona = sifraBona + ",";
                                            }
                                            sifraBona = sifraBona + row[2].ToString();
                                        }
                                    }
                                }

                                kopirajStavkeuTMP();

                                //ako postoji sifra bona znaci da je barem jedan oznacen i da mogu pozvati formu za stavke

                                if (sifraBona == "")
                                {
                                    return;
                                }
                                else
                                {
                                    ////izbrisi duple  zapise artiklala
                                    //veza.ExecuteQuery("ALTER IGNORE TABLE ifabonstavka_tmp ADD UNIQUE INDEX moj_index(pr_sifra)");
                                    //veza.ExecuteQuery("DROP INDEX moj_index ON ifabonstavka_tmp");
                                    pozoviFormu();
                                }
                            }

                            else //fakturiranje roba po izboru
                            {
                                //dohvati osnovice računa koji se fakturiraju i prenesi ih u formu dodavanja stavki

                                pokupiPodatkeOBazama();

                                for (brojac = 0; brojac < dgBon.RowCount; brojac++)
                                {
                                    System.Data.DataRow row = dgBon.GetDataRow(brojac);
                                    if (row != null)
                                    {
                                        if (row[7].ToString() == "Da")
                                        {
                                            if (Convert.ToDecimal(row[5]) > Convert.ToDecimal(row[3]))
                                            {
                                                //ako je iznos računa koji treba fakturirati veći od iznosa bona uzmi max iznos bona za fakturirati
                                                iznosFaktura = iznosFaktura + Convert.ToDecimal(row[3]);
                                            }
                                            else
                                            {
                                                iznosFaktura = iznosFaktura + Convert.ToDecimal(row[5]);
                                            }

                                            flag = 0;

                                            if (sifraBona != "")
                                            {
                                                sifraBona = sifraBona + ",";
                                            }
                                            sifraBona = sifraBona + row[2].ToString();
                                        }
                                    }
                                }

                                //veza.ExecuteQuery("truncate table ifabonstavka_tmp");

                                //obriši stavke artikala od trenutnog korisnika ukoliko postoje

                                veza.ExecuteQuery("delete from ifabonstavka_tmp where operater_op_ID = " + Global.KorisnikID + "");

                                for (brojac = 0; brojac < dgStavkePDVstavka.RowCount; brojac++)
                                {

                                    System.Data.DataRow row = dgStavkePDVstavka.GetDataRow(brojac);
                                    if (row != null)
                                    {
                                        //string a = row[2].ToString();
                                        if (row[2].ToString() == "5,00")
                                        {
                                            povratna = povratna + Convert.ToDecimal(row[0].ToString());

                                            osnovica5 = osnovica5 + Convert.ToDecimal(row[1].ToString());
                                            postotak5 = osnovica10 + Convert.ToDecimal(row[2].ToString());

                                            Podaci.osnovica5 = Convert.ToString(osnovica5);
                                            Podaci.postotak5 = Convert.ToString(postotak5);

                                        }

                                        if (row[2].ToString() == "10,00")
                                        {
                                            povratna = povratna + Convert.ToDecimal(row[0].ToString());

                                            osnovica10 = osnovica10 + Convert.ToDecimal(row[1].ToString());
                                            postotak10 = postotak10 + Convert.ToDecimal(row[2].ToString());

                                            Podaci.osnovica10 = Convert.ToString(osnovica10);
                                            Podaci.postotak10 = Convert.ToString(postotak10);

                                        }


                                        if (row[2].ToString() == "13,00")
                                        {
                                            povratna = povratna + Convert.ToDecimal(row[0].ToString());

                                            osnovica10 = osnovica10 + Convert.ToDecimal(row[1].ToString());
                                            postotak10 = postotak10 + Convert.ToDecimal(row[2].ToString());

                                            Podaci.osnovica10 = Convert.ToString(osnovica10);
                                            Podaci.postotak10 = Convert.ToString(postotak10);

                                        }


                                        if (row[2].ToString() == "25,00")
                                        {
                                            povratna = povratna + Convert.ToDecimal(row[0].ToString());
                                        }
                                    }
                                }

                                Podaci.povratna = Convert.ToString(povratna);

                                if (sifraBona == "")
                                {
                                    return;
                                }
                                else
                                {
                                    pozoviFormu();
                                }
                            }
                        }
                    }

                    //prava za fakturiranje imaju monika i danijela i admin 
                    if (Global.KorisnikID == "1414" || Global.KorisnikID == "1967" || Global.KorisnikID == "1498" || Global.KorisnikID == "2403")
                    {
                        //lblPoruka.Visible = true;
                        //lblPoruka.Refresh();
                        //iznosFaktura = 0;
                        //sifraBona = "";
                        //povratna = 0;
                        //osnovica5 = 0;
                        //osnovica10 = 0;

                        //postotak5 = 0;
                        //postotak10 = 0;
                        //Podaci.osnovica5 = "0";
                        //Podaci.osnovica10 = "0";
                        //Podaci.postotak5 = "0";
                        //Podaci.postotak10 = "0";

                        

                        //if (dgBon.RowCount > 0)
                        //{
                        //    DialogResult result;
                        //    result = MessageBox.Show("Fakturirati sa unosom stavki računa?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        //    if (result == DialogResult.Yes)
                        //    {
                        //        //fakturiranje  sa stavkama kojie se unose ručno

                        //        //obriši stavke artikala od trenutnog korisnika ukoliko postoje

                        //        veza.ExecuteQuery("delete from ifabonstavka_tmp where operater_op_ID = " + Global.KorisnikID + "");

                        //        for (brojac = 0; brojac < dgBon.RowCount; brojac++)
                        //        {
                        //            System.Data.DataRow row = dgBon.GetDataRow(brojac);
                        //            if (row != null)
                        //            {
                        //                if (row[7].ToString() == "Da")
                        //                {
                        //                    if (Convert.ToDecimal(row[5]) > Convert.ToDecimal(row[3]))
                        //                    {
                        //                        //ako je iznos računa koji treba fakturirati veći od iznosa bona uzmi max iznos bona za fakturirati
                        //                        iznosFaktura = iznosFaktura + Convert.ToDecimal(row[3]);
                        //                    }
                        //                    else
                        //                    {
                        //                        iznosFaktura = iznosFaktura + Convert.ToDecimal(row[5]);
                        //                    }
                        //                    flag = 1;

                        //                    if (sifraBona != "")
                        //                    {
                        //                        sifraBona = sifraBona + ",";
                        //                    }
                        //                    sifraBona = sifraBona + row[2].ToString();
                        //                }
                        //            }
                        //        }

                        //        //kopirajStavkeuTMP();

                        //        //ako postoji sifra bona znaci da je barem jedan oznacen i da mogu pozvati formu za stavke

                        //        if (sifraBona == "")
                        //        {
                        //            return;
                        //        }
                        //        else
                        //        {
                        //            ////izbrisi duple  zapise artiklala
                        //            //veza.ExecuteQuery("ALTER IGNORE TABLE ifabonstavka_tmp ADD UNIQUE INDEX moj_index(pr_sifra)");
                        //            //veza.ExecuteQuery("DROP INDEX moj_index ON ifabonstavka_tmp");
                        //            pozoviFormu();
                        //        }
                        //    }

                        //    else //fakturiranje roba po izboru
                        //    {
                        //        //dohvati osnovice računa koji se fakturiraju i prenesi ih u formu dodavanja stavki

                        //        pokupiPodatkeOBazama();

                        //        for (brojac = 0; brojac < dgBon.RowCount; brojac++)
                        //        {
                        //            System.Data.DataRow row = dgBon.GetDataRow(brojac);
                        //            if (row != null)
                        //            {
                        //                if (row[7].ToString() == "Da")
                        //                {
                        //                    if (Convert.ToDecimal(row[5]) > Convert.ToDecimal(row[3]))
                        //                    {
                        //                        //ako je iznos računa koji treba fakturirati veći od iznosa bona uzmi max iznos bona za fakturirati
                        //                        iznosFaktura = iznosFaktura + Convert.ToDecimal(row[3]);
                        //                    }
                        //                    else
                        //                    {
                        //                        iznosFaktura = iznosFaktura + Convert.ToDecimal(row[5]);
                        //                    }

                        //                    flag = 0;

                        //                    if (sifraBona != "")
                        //                    {
                        //                        sifraBona = sifraBona + ",";
                        //                    }
                        //                    sifraBona = sifraBona + row[2].ToString();
                        //                }
                        //            }
                        //        }

                        //        //veza.ExecuteQuery("truncate table ifabonstavka_tmp");

                        //        //obriši stavke artikala od trenutnog korisnika ukoliko postoje

                        //        veza.ExecuteQuery("delete from ifabonstavka_tmp where operater_op_ID = " + Global.KorisnikID + "");

                        //        for (brojac = 0; brojac < dgStavkeBona.RowCount; brojac++)
                        //        {

                        //            System.Data.DataRow row = dgStavkeBona.GetDataRow(brojac);
                        //            if (row != null)
                        //            {
                        //                //string a = row[2].ToString();
                        //                if (row[2].ToString() == "5,00")
                        //                {
                        //                    povratna = povratna + Convert.ToDecimal(row[0].ToString());

                        //                    osnovica5 = osnovica5 + Convert.ToDecimal(row[1].ToString());
                        //                    postotak5 = osnovica10 + Convert.ToDecimal(row[2].ToString());

                        //                    Podaci.osnovica5 = Convert.ToString(osnovica5);
                        //                    Podaci.postotak5 = Convert.ToString(postotak5);

                        //                }

                        //                if (row[2].ToString() == "10,00")
                        //                {
                        //                    povratna = povratna + Convert.ToDecimal(row[0].ToString());

                        //                    osnovica10 = osnovica10 + Convert.ToDecimal(row[1].ToString());
                        //                    postotak10 = postotak10 + Convert.ToDecimal(row[2].ToString());

                        //                    Podaci.osnovica10 = Convert.ToString(osnovica10);
                        //                    Podaci.postotak10 = Convert.ToString(postotak10);

                        //                }


                        //                if (row[2].ToString() == "13,00")
                        //                {
                        //                    povratna = povratna + Convert.ToDecimal(row[0].ToString());

                        //                    osnovica10 = osnovica10 + Convert.ToDecimal(row[1].ToString());
                        //                    postotak10 = postotak10 + Convert.ToDecimal(row[2].ToString());

                        //                    Podaci.osnovica10 = Convert.ToString(osnovica10);
                        //                    Podaci.postotak10 = Convert.ToString(postotak10);

                        //                }


                        //                if (row[2].ToString() == "25,00")
                        //                {
                        //                    povratna = povratna + Convert.ToDecimal(row[0].ToString());
                        //                }
                        //            }
                        //        }

                        //        Podaci.povratna = Convert.ToString(povratna);

                        //        if (sifraBona == "")
                        //        {
                        //            return;
                        //        }
                        //        else
                        //        {
                        //            pozoviFormu();
                        //        }
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pozoviFormu()
        {
            System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    if (row[7].ToString() == "Da")
                    {
                        poSifra = row[9].ToString();
                    }
                }

            if (flag == 1) //fakturiranje sa svim stavkama
            {
                if (otvoriformu == 1)
                {
                    frmNapraviFakturu _frm;
                    foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                    {
                        if (childForm.GetType() == typeof(frmNapraviFakturu))
                        {
                            childForm.Focus();
                            return;
                        }
                    }
                    _frm = new frmNapraviFakturu();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.Iznos = iznosFaktura.ToString();
                    _frm.IDbona = IDbona;
                    _frm.SifraBon = sifraBona;
                    _frm.posifra = poSifra;
                    _frm.Partner = glPartner.EditValue.ToString();
                    _frm.Show();
                    lblPoruka.Visible = false;
                    lblPoruka.Refresh();
                }
            }
            else //fakturiranje bez povlacenja stavki 
            {              
                frmNapraviFakturu _frm;
                foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmNapraviFakturu))
                    {
                        childForm.Focus();
                        return;
                    }
                }

                _frm = new frmNapraviFakturu();
                _frm.MdiParent = frmMain.ActiveForm;
                _frm.Iznos = iznosFaktura.ToString();
                _frm.IDbona = IDbona;
                _frm.SifraBon = sifraBona;
                _frm.Partner = glPartner.EditValue.ToString();
                _frm.BezStavki = "1";
                _frm.posifra = poSifra;
                _frm.Show();
                lblPoruka.Visible = false;
                lblPoruka.Refresh();
            }
        }

        private void pokupiPodatkeOBazama()
        {
            DataTable katalog = new DataTable();
            try
            {
                if (dgStavkePDVstavka.RowCount > 0)
                {
                    podaciporez.Tables["Table"].Clear();
                    dgStavkePDV.DataSource = podaciporez.Tables["Table"];
                }

                DataTable tablica = new DataTable();
                int oznaka = 0; //ako je 1 onda pogu napravit upit na stavke jer taj račun nisam pokupio
                int a;
                tablica.Columns.Add("Šifra", typeof(string));
                tablica.Columns.Add("Broja računa", typeof(decimal));

                for (brojac = 0; brojac < dgBon.RowCount; brojac++)
                {
                    System.Data.DataRow row = dgBon.GetDataRow(brojac);
                    if (row != null)
                    {
                        if (row[7].ToString() == "Da")
                        {
                            kasa = row[11].ToString();
                            racunBr = row[12].ToString();
                            vrijemeKoristenja = DateTime.Parse(row[15].ToString()).ToString("HH:mm:ss");// Convert.ToDateTime(row[15]).ToString("H:mm:ss");
                            datumKoristenja = Convert.ToDateTime(row[4]).ToString("yyyy-MM-dd");
                            poSifra = row[9].ToString();
                            poID = row[14].ToString();

                            // u globalnoj varijabli postotak piše postotak 10 ili 13 ovisno da li se radi o tekućoj godini 2014 ili staroj < 2014
                            //u skladu s tim gledam u katalog poslovnice za IPadresu i katalog za spajanje 

                            if (Global.postotakoznaka == "13")
                            {
                                //aktualna godina
                                veza.ExecuteQuery("Select po_IPadresa, po_katalog from poslovnica where po_ID = " + poID + "", ref katalog);

                                if (katalog.Rows.Count > 0)
                                {
                                    IPadresa = katalog.Rows[0][0].ToString();
                                    baza = katalog.Rows[0][1].ToString();
                                }
                            }
                            else
                            {
                                //prošla godina

                                IPadresa = "192.168.0.124";
                                baza = "t" + poSifra + "-2013";

                            }
                           

                          
                               
                                string ConnectionString = "Server = " + IPadresa + "; Database=" + baza + "; Uid=admin10; Pwd=movema10;";
                                connection.ConnectionString = ConnectionString;


                                //prije upita provjeriti da li sam već izvršio upit za taj broj računa , kasu i šifru poslovnice, tj ako je više bonova provučeno na isti račun da jednom napravim upit
                                //taj podatak spremit u privremenu tablicu 
                                                                                              
                                
                                if (tablica.Rows.Count > 0)
                                {
                                    //ako postoji već neki zapis provjeri da li se radi o istom računu


                                    for (a = 0; a < tablica.Rows.Count; a++)
                                    {
                                        if (tablica.Rows[a][1].ToString() != racunBr)
                                        {
                                            //ako ne postoji isti račun 

                                            oznaka = 1;

                                        }
                                        else //ako postoji isti račun provjeri poslovnicu
                                        {
                                            if (tablica.Rows[a][0].ToString() != poSifra)
                                            {
                                                //slobodno napravi upit za stavke jer za ovaj broj račun i poslovnicu upit nije rađen 

                                                oznaka = 1;
                                            }
                                            else
                                            {
                                                oznaka = 0;
                                            }                                         
                                        }
                                    }

                                    if (oznaka == 1)
                                    {
                                        MySqlCommand comm = new MySqlCommand(@"select sum(sviracuni.ar_povnak * sviracuni.ra_kolicina) as 'povratna', sum(sviracuni.ra_osnovica) as 'osnovica', sviracuni.pz_posto from poslovnice, racunzag,  sviracuni 
                                                                    where  poslovnice.po_sifra = sviracuni.PO_SIFRA and   racunzag.RA_DATUM = sviracuni.RA_DATUM and racunzag.RA_BROJ = sviracuni.RA_BROJ 
                                                                    and racunzag.RA_KASABR = sviracuni.RA_KASABR and racunzag.Z_BROJ = sviracuni.Z_BROJ  and 
                                                                     sviracuni.ra_broj = " + racunBr + " and sviracuni.ra_datum = '" + datumKoristenja + "' and  sviracuni.ra_kasabr = " + kasa + " and sviracuni.PO_SIFRA = " + poSifra + " group by sviracuni.pz_posto ", connection);


                                        MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                                        adapter.Fill(podaciporez, "Table");

                                        dgStavkePDV.DataSource = podaciporez.Tables["Table"];

                                        //spremi u privremenu tablicu pdoatke o računu i poslovnici za koje si napravio upit
                                        tablica.Rows.Add(poSifra, racunBr);
                                    }

                                }
                                else
                                {
                                    //prvi put upit
                                    MySqlCommand comm = new MySqlCommand(@"select sum(sviracuni.ar_povnak * sviracuni.ra_kolicina) as 'povratna', sum(sviracuni.ra_osnovica) as 'osnovica', sviracuni.pz_posto from poslovnice, racunzag,  sviracuni 
                                                                        where  poslovnice.po_sifra = sviracuni.PO_SIFRA and   racunzag.RA_DATUM = sviracuni.RA_DATUM and racunzag.RA_BROJ = sviracuni.RA_BROJ 
                                                                        and racunzag.RA_KASABR = sviracuni.RA_KASABR and racunzag.Z_BROJ = sviracuni.Z_BROJ  and 
                                                                         sviracuni.ra_broj = " + racunBr + " and sviracuni.ra_datum = '" + datumKoristenja + "' and  sviracuni.ra_kasabr = " + kasa + " and sviracuni.PO_SIFRA = " + poSifra + " group by sviracuni.pz_posto ", connection);


                                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                                    adapter.Fill(podaciporez, "Table");

                                    dgStavkePDV.DataSource = podaciporez.Tables["Table"];

                                    tablica.Rows.Add(poSifra, racunBr);
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


                
        private void pokupiPodatke2()
        {
            DataTable katalog = new DataTable();
            try
            {
                if (dgStavkeBona.RowCount > 0)
                {
                    podaci.Tables["Table"].Clear();
                    dgStavke.DataSource = podaci.Tables["Table"];
                }

                DataTable tablica = new DataTable();
                int oznaka = 0; //ako je 1 onda pogu napravit upit na stavke jer taj račun nisam pokupio
                int a;
                tablica.Columns.Add("Šifra", typeof(string));
                tablica.Columns.Add("Broja računa", typeof(decimal));

                for (brojac = 0; brojac < dgBon.RowCount; brojac++)
                {
                    System.Data.DataRow row = dgBon.GetDataRow(brojac);
                    if (row != null)
                    {
                        if (row[7].ToString() == "Da")
                        {
                            kasa = row[11].ToString();
                            racunBr = row[12].ToString();
                            vrijemeKoristenja = DateTime.Parse(row[15].ToString()).ToString("HH:mm:ss");// Convert.ToDateTime(row[15]).ToString("H:mm:ss");
                            datumKoristenja = Convert.ToDateTime(row[4]).ToString("yyyy-MM-dd");
                            poSifra = row[9].ToString();
                            poID = row[14].ToString();

                            // u globalnoj varijabli postotak piše postotak 10 ili 13 ovisno da li se radi o tekućoj godini 2014 ili staroj < 2014
                            //u skladu s tim gledam u katalog poslovnice za IPadresu i katalog za spajanje 

                            if (Global.postotakoznaka == "13")
                            {
                                //aktualna godina
                                veza.ExecuteQuery("Select po_IPadresa, po_katalog from poslovnica where po_ID = " + poID + "", ref katalog);

                                if (katalog.Rows.Count > 0)
                                {
                                    IPadresa = katalog.Rows[0][0].ToString();
                                    baza = katalog.Rows[0][1].ToString();
                                }
                            }
                            else
                            {
                                //prošla godina

                                IPadresa = "192.168.0.124";
                                baza = "t" + poSifra + "-2013";

                            }




                            string ConnectionString = "Server = " + IPadresa + "; Database=" + baza + "; Uid=admin10; Pwd=movema10;";
                            connection.ConnectionString = ConnectionString;


                            //prije upita provjeriti da li sam već izvršio upit za taj broj računa , kasu i šifru poslovnice, tj ako je više bonova provučeno na isti račun da jednom napravim upit
                            //taj podatak spremit u privremenu tablicu 


                            if (tablica.Rows.Count > 0)
                            {
                                //ako postoji već neki zapis provjeri da li se radi o istom računu


                                for (a = 0; a < tablica.Rows.Count; a++)
                                {
                                    if (tablica.Rows[a][1].ToString() != racunBr)
                                    {
                                        //ako ne postoji isti račun , ako su razliciti brojevi ne radi novi upit i ne daj otvoriti formu stavki

                                        oznaka = 0;
                                        otvoriformu = 0;
                                        MessageBox.Show("Možete odabrati samo sve bonove jednog računa jedne poslovnice!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                        return;
                                    }
                                    else //ako postoji isti račun provjeri poslovnicu
                                    {
                                        if (tablica.Rows[a][0].ToString() != poSifra)
                                        {
                                            //slobodno napravi upit za stavke jer za ovaj broj račun i poslovnicu upit nije rađen 

                                            oznaka = 0;
                                            MessageBox.Show("Možete odabrati samo sve bonove jednog računa jedne poslovnice!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                            otvoriformu = 0;
                                        }
                                        else
                                        {
                                            oznaka = 0;
                                            otvoriformu = 1;

                                        }
                                    }
                                }

                                if (oznaka == 1)
                                {
                                   
                                    MySqlCommand comm = new MySqlCommand(@"select sviracuni.PO_SIFRA, poslovnice.po_naziv, sviracuni.RA_KASABR, 
                                                                    sviracuni.RA_BROJ, sviracuni.AR_SIFRA, sviracuni.AR_NAZIV, sviracuni.RA_KOLICINA, 
                                                                    sviracuni.RA_OSNOVICA/sviracuni.RA_KOLICINA, sviracuni.PZ_POSTO, sviracuni.AR_POVNAK, sviracuni.RA_OSNOVICA, 
                                                                    sviracuni.RA_DATUM, sviracuni.RA_VRIJEME, sviracuni.ra_pdv from poslovnice, racunzag,  sviracuni 
 
                                                                    where  trim(poslovnice.po_sifra) = trim(sviracuni.PO_SIFRA) and   racunzag.RA_DATUM = sviracuni.RA_DATUM and racunzag.RA_BROJ = sviracuni.RA_BROJ 
                                                                    and racunzag.RA_KASABR = sviracuni.RA_KASABR and racunzag.Z_BROJ = sviracuni.Z_BROJ  and 
                                                                    sviracuni.ra_datum = '" + datumKoristenja + "' and sviracuni.ra_broj = " + racunBr + " and  sviracuni.ra_kasabr = " + kasa + " and trim(sviracuni.PO_SIFRA) = " + poSifra + "", connection);



                                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                                    adapter.Fill(podaci, "Table");

                                    dgStavke.DataSource = podaci.Tables["Table"];

                                    //spremi u privremenu tablicu pdoatke o računu i poslovnici za koje si napravio upit
                                    tablica.Rows.Add(poSifra, racunBr);
                                }

                            }
                            else
                            {
                                //sviracuni.RA_CIJENA, sviracuni.PZ_POSTO, sviracuni.AR_POVNAK, sviracuni.RA_IZNOS - sviracuni.ra_pdv, 
                                //prvi put upit
                                MySqlCommand comm = new MySqlCommand(@"select sviracuni.PO_SIFRA, poslovnice.po_naziv, sviracuni.RA_KASABR, 
                                                                    sviracuni.RA_BROJ, sviracuni.AR_SIFRA, sviracuni.AR_NAZIV, sviracuni.RA_KOLICINA, 
                                                                    sviracuni.RA_OSNOVICA/sviracuni.RA_KOLICINA, sviracuni.PZ_POSTO, sviracuni.AR_POVNAK, sviracuni.RA_OSNOVICA, 
                                                                    sviracuni.RA_DATUM, sviracuni.RA_VRIJEME, sviracuni.ra_pdv from poslovnice, racunzag,  sviracuni 
 
                                                                    where  trim(poslovnice.po_sifra) = trim(sviracuni.PO_SIFRA) and   racunzag.RA_DATUM = sviracuni.RA_DATUM and racunzag.RA_BROJ = sviracuni.RA_BROJ 
                                                                    and racunzag.RA_KASABR = sviracuni.RA_KASABR and racunzag.Z_BROJ = sviracuni.Z_BROJ  and 
                                                                    sviracuni.ra_datum = '" + datumKoristenja + "' and sviracuni.ra_broj = " + racunBr + " and  sviracuni.ra_kasabr = " + kasa + " and trim(sviracuni.PO_SIFRA) = " + poSifra + "", connection);


                                MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                                adapter.Fill(podaci, "Table");

                                dgStavke.DataSource = podaci.Tables["Table"];

                                tablica.Rows.Add(poSifra, racunBr);

                                otvoriformu = 1;
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
      
        private void kopirajStavkeuTMP() 
        {
            try
            {
                //veza.ExecuteQuery("truncate table ifabonstavka_tmp");   

                for (brojac = 0; brojac < dgStavkeBona.RowCount; brojac++)
                {
                    System.Data.DataRow row = dgStavkeBona.GetDataRow(brojac);
                    if (row != null)
                    {
                        string poSifra = row[0].ToString().Trim();
                        string sifraartikl = row[4].ToString().Trim();
                        string naziv = row[5].ToString().Trim(); 
                        string kolicina = Convert.ToString(row[6]).Replace(',', '.');
                        string povratna = Convert.ToString(row[9]).Replace(',', '.');

                        if (row[7].ToString() == "")
                        {
                            cijena = "0.00";
                        }
                        else
                        {
                            cijena = Convert.ToString(row[7]).Replace(',', '.');
                        }
                        string iznos = Convert.ToString(row[10]).Replace(',', '.');
                        string posto = Convert.ToString(row[8]).Replace(',', '.');
                        string brojKase = row[2].ToString().Trim();
                        string brojRacuna = row[3].ToString().Trim();
                        //string a = row[11].ToString();
                        string datum = Convert.ToDateTime(row[11]).ToString("yyyy-MM-dd");
                        string vrijeme = DateTime.Parse(row[12].ToString()).ToString("HH:mm:ss");
                        string PDViznos = Convert.ToString(row[13]).Replace(',', '.');

                        veza.ExecuteQuery(@"insert into ifabonstavka_tmp (pr_sifra, pr_naziv, pr_kolicina, pr_povratna, 
                        pr_cijenabruto,pr_netocijena, pr_iznosneto, pz_posto , pr_po_Sifra, pr_porezIznos, operater_op_ID, pr_postorabat, pr_iznosrabat) values ('" + sifraartikl + "', '" + naziv.Replace("'", "''") + "' , '" + kolicina + "', '" + povratna + "', '" + cijena + "','" + cijena + "', '" + iznos + "' ,'" + posto + "', '" + poSifra + "', '" + PDViznos + "', '" + Global.KorisnikID + "',0,0)");                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void glPartner_EditValueChanged(object sender, EventArgs e)
        {
            faturiranje.Clear();
        }
    }
}
