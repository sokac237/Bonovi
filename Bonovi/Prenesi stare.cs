using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Advantage.Data.Provider;

namespace Bonovi
{
    public partial class frmPrenesiStare : Form
    {
        Upiti veza = new Upiti();
        DataTable stariBonovi = new DataTable();
        int brojac;
        List<string> partnerLOG = new List<string>();
        List<string> myCollection = new List<string>();

        string bonKod;
        string partnerSifra;
        string partner_pa_ID;
        string bon_rednibroj;
        string datumIzrade;
        string vrijemIzrade;
        string iznosBona;
        string vaziDO;
        string operaterSifra;
        string operaterSifra2;
        string operater_op_ID;
        string operater_op_ID2;
        string datumKoristenja;
        string vrijemeKristenja;
        string kasa;
        string racunnakasi;
        string iznosracuna;
        string poslovnicaSifra;
        string poslovnica_po_ID;
        string bosocard;

        string ifabID;
        string PDV;
        string povratna;
        string ukupno;
        string status;
        string opis;
        string knjizen;
        string datumknjizenja;

        string pdv5;
        string pdv10;
        string pdv25;

        string osnovica5;
        string osnovica10;
        string osnovica25;

        int povratnaUpisana = 0; //oznaka koja daje do znanja da je povratna već upisana na jednoj od stavki robe po izboru

        public frmPrenesiStare()
        {
            InitializeComponent();
        }

        private void btnDohvati_Click(object sender, EventArgs e)
        {
            stariBonovi.Clear();

            DataTable bon = new DataTable();
            if (txtBonKod.Text.Trim() != "")
            {
                //prvo provjeri kod nas u bazi da li postoji taj bon ako ne onda ga dohvati iz stare i spremi u tablicu bonova

                veza.ExecuteQuery("select bon_ID from bonovi where bon_kod = " + txtBonKod.Text.Trim() + "", ref bon);
                if (bon.Rows.Count > 0)
                {
                    //postoji u bazi ne dohvacaj ponovno
                    MessageBox.Show("Bon sa tim barkodom već postoji u bazi! Provjerite još jednom!");
                    txtBonKod.Text = "";
                    txtBonKod.Focus();
                }
                else
                {
                    //dohvati taj bon

                    AdsConnection conn = new AdsConnection();
                    conn.ConnectionString = "data source=V:\\Centrala\\rabati-dobavljaci.add; " + "user id = adssys; password = 'movema' " + "ServerType=REMOTE; TrimTrailingSpaces = true";
                    //za mene lokalno   
                    //"data source=V:\\stanic\\baza\\centralna.add; " + "user id = adssys; password = '' " + "ServerType=REMOTE; TrimTrailingSpaces = true";
                    //za restoran
                    //"data source=\\\\192.168.3.5:6262\\podaci\\velep\\stanic\\baza\\centralna.add; " + "user id = adssys; password = '' " + "ServerType=REMOTE; TrimTrailingSpaces = true"
                    conn.Open();
                    using (AdsCommand cmd = conn.CreateCommand())
                    {
                        //cmd.CommandText = "Select b_sifbon, b_sifpar, b_redbroj, b_datizd, b_satizd, b_iznos, b_operi, b_vazido, b_datkor, b_sat, b_kasa, b_racun, b_brkart, b_iznosrac, b_operk, b_organ, b_brfakt from bonovi where B_datizd between '2013-01-01' and '2013-12-31' and b_ponisten <> True ";

                        cmd.CommandText = "Select b_sifbon, b_sifpar, b_redbroj, b_datizd, b_satizd, b_iznos, b_operi, b_vazido, b_datkor, b_sat, b_kasa, b_racun, b_brkart, b_iznosrac, b_operk, b_organ, b_brfakt from bonovi where B_sifbon = '" + txtBonKod.Text.Trim() + "' ";
                        using (AdsDataReader reader = cmd.ExecuteReader())
                        {
                            stariBonovi.Load(reader);

                            if (stariBonovi.Rows.Count < 1)
                            {
                                return;
                            }
                            else
                            {
                                dgStariBonovi.DataSource = stariBonovi;
                            }
                        }
                        conn.Close();
                        dgNoviBonovi.Refresh();
                    }
                }
            }
            else
            {
                txtBonKod.Focus();
            }
          
        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgStariBon.RowCount >0)
                {
                    lvlStatus.Text = "Kopiram bonove iz stare baze u novu! Pričekajte...";
                    lvlStatus.Refresh();
                    btnPrenesi.Enabled = false;
                    for (brojac = 0; brojac < dgStariBon.RowCount; brojac++)
                    {
                        System.Data.DataRow row = dgStariBon.GetDataRow(brojac);
                        if (row != null)
                        {
                           
                            if (row[16].ToString() != "")
                            {
                                ifabID = row[16].ToString();
                            }
                            else
                            {
                                ifabID = "default";
                            }
                            bonKod = row[0].ToString();
                            partnerSifra = row[1].ToString().Trim();
                            bon_rednibroj = row[2].ToString();
                            datumIzrade = Convert.ToDateTime(row[3]).ToString("yyyy-MM-dd");
                            vrijemIzrade = Convert.ToDateTime(row[4]).ToString("HH:mm:ss");
                            iznosBona = row[5].ToString().Replace(",", ".");
                            if (row[7].ToString() != "")
                            {
                                vaziDO = "'" + Convert.ToDateTime(row[7]).ToString("yyyy-MM-dd") + "'";
                            }
                            else
                            {
                                vaziDO = "default";
                            }
                            operaterSifra = row[6].ToString();
                            if (row[8].ToString() != "")
                            {
                                datumKoristenja = "'" +Convert.ToDateTime(row[8]).ToString("yyyy-MM-dd")+"'";
                            }
                            else
                            {
                                datumKoristenja = "default";
                            }
                            if (row[9].ToString() != "")
                            {
                                vrijemeKristenja = "'"+ Convert.ToDateTime(row[9]).ToString("HH:mm:ss")+ "'";
                            }
                            else
                            {
                                vrijemeKristenja = "default";
                            }

                            if (row[10].ToString() != "")
                            {
                                kasa = row[10].ToString();
                            }
                            else
                            {
                                kasa = "default";
                            }
                            if (row[11].ToString() != "")
                            {
                                racunnakasi = row[11].ToString();
                            }
                            else
                            {
                                racunnakasi = "default";
                            }
                            if (row[13].ToString() != "")
                            {
                                if (row[13].ToString().Length > 10)
                                {
                                    string aa = row[13].ToString().Substring(0,5);
                                    iznosracuna = row[13].ToString().Replace(",", ".").Substring(0, 8);
                                }
                                else
                                {
                                    iznosracuna = row[13].ToString().Replace(",", ".");
                                }
                            }
                            else
                            {
                                iznosracuna = "0.00";
                            }
                            if (row[12].ToString() != "")
                            {
                                bosocard = row[12].ToString();
                            }
                            else
                            {
                                bosocard = "default";
                            }
                            operaterSifra2 = row[14].ToString();
                            poslovnicaSifra = row[15].ToString();
                        }

                        partnerID();
                        operaterID();
                        poslovnicaID();
                        operaterID2();

                        //MessageBox.Show("insert into bonovi (bon_kod, partner_pa_ID,bon_rednibroj,bon_datumizrade, bon_vrijemeizrade, bon_iznos, bon_vazido, operater_op_ID, bon_datumkoristenja, bon_vrijemekoristenja, bon_kasa, bon_racunnakasi, bon_iznosracuna, operater_op_ID1, poslovnica_po_ID, bon_bosocard, ifab_ID) values ("+bonKod+", "+partner_pa_ID+", "+bon_rednibroj+", '"+datumIzrade+"', '"+vrijemIzrade+"', "+iznosBona+", "+vaziDO+", "+operater_op_ID+", "+datumKoristenja+", "+vrijemeKristenja+","+kasa+", "+racunnakasi+", "+iznosracuna+", "+operater_op_ID2+", "+poslovnica_po_ID+", "+bosocard+", "+ifabID+") ");
                        veza.ExecuteQuery(@"insert into bonovi (bon_kod, partner_pa_ID,bon_rednibroj,bon_datumizrade, bon_vrijemeizrade, bon_iznos, bon_vazido, operater_op_ID, bon_datumkoristenja, bon_vrijemekoristenja, bon_kasa, bon_racunnakasi, bon_iznosracuna, operater_op_ID1, poslovnica_po_ID, bon_bosocard, ifab_ID) 
                                                        values ("+bonKod+", "+partner_pa_ID+", "+bon_rednibroj+", '"+datumIzrade+"', '"+vrijemIzrade+"', "+iznosBona+", "+vaziDO+", "+operater_op_ID+", "+datumKoristenja+", "+vrijemeKristenja+","+kasa+", "+racunnakasi+", "+iznosracuna+", "+operater_op_ID2+", "+poslovnica_po_ID+", "+bosocard+", "+ifabID+") ");
                    }
                    MessageBox.Show("Gotovo prebacivanje!");
                    btnPrenesi.Enabled = false;
                    lvlStatus.Text = "";
                    lvlStatus.Refresh();
                    txtBonKod.Text = "";
                    txtBonKod.Focus();

                    string a = "";

                    for (int i = 0; i < myCollection.Count; i++)
                    {
                        a= a + " ;"+ myCollection[i];
                    }

                    MessageBox.Show(a);

                    DataTable podaci = new DataTable();
                    veza.ExecuteQuery("select * from bonovi", ref podaci);
                    dgNoviBonovi.DataSource = podaci;
                    btnPrenesi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + bonKod);
            }
        }

        private void partnerID()
        {
            int umetni = 0;
            try
            {
                DataTable partner = new DataTable();

                veza.ExecuteQuery("select pa_ID from partner where pa_sifra = '"+partnerSifra+"' ", ref partner);

                if (partner.Rows.Count > 0)
                {
                    partner_pa_ID = partner.Rows[0][0].ToString();
                }
                else
                {
                    if (myCollection.Count < 1)
                    {
                        myCollection.Add(partnerSifra);
                    }

                    myCollection.ToArray();

                    int i;
                    for (i = 0; i < myCollection.Count; i++)
                    {
                        if (myCollection[i].ToString() == partnerSifra)
                        {
                            //postoji šifra napravi break i ne umeci je
                            umetni = 0;
                            break;
                        }

                        umetni = 1;
                    }

                    if (umetni == 1)
                    {
                        myCollection.Add(partnerSifra);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void operaterID()
        {
            try
            {
                DataTable operater = new DataTable();
                veza.ExecuteQuery("select op_ID from operater where op_sifra = '" + operaterSifra + "' ", ref operater);

                if (operater.Rows.Count > 0)
                {
                    operater_op_ID = operater.Rows[0][0].ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void operaterID2()
        {
            try
            {
                if (operaterSifra2 != "")
                {
                    DataTable operater2 = new DataTable();

                    veza.ExecuteQuery("select op_ID from operater where op_sifra = '" + operaterSifra2 + "' ", ref operater2);

                    if (operater2.Rows.Count > 0)
                    {
                        operater_op_ID2 = operater2.Rows[0][0].ToString();
                    }
                    else
                    {
                        operater_op_ID2 = "1967";
                    }
                }
                else
                {
                    operater_op_ID2 = "default";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void poslovnicaID()
        {
            try
            {
                if (poslovnicaSifra != "")
                {
                    DataTable poslovnica = new DataTable();

                    veza.ExecuteQuery("select po_ID from poslovnica where po_sifra = " + poslovnicaSifra + " ", ref poslovnica);

                    if (poslovnica.Rows.Count > 0)
                    {
                        poslovnica_po_ID = poslovnica.Rows[0][0].ToString();
                    }
                }
                else
                {
                    poslovnica_po_ID = "default";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDohvatiFakture_Click(object sender, EventArgs e)
        {
            AdsConnection conn = new AdsConnection();
            conn.ConnectionString = "data source=V:\\Centrala\\rabati-dobavljaci.add; " + "user id = adssys; password = 'movema' " + "ServerType=REMOTE; TrimTrailingSpaces = true";
            //za mene lokalno   
            //"data source=V:\\stanic\\baza\\centralna.add; " + "user id = adssys; password = '' " + "ServerType=REMOTE; TrimTrailingSpaces = true";
            //za restoran
            //"data source=\\\\192.168.3.5:6262\\podaci\\velep\\stanic\\baza\\centralna.add; " + "user id = adssys; password = '' " + "ServerType=REMOTE; TrimTrailingSpaces = true"
            conn.Open();
            using (AdsCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "Select f_brfakt, f_sifpar, f_datfakt, f_valuta, f_iznos, f_pdv, f_povnak, f_ukupno,  f_status, f_opis, f_knjig, f_datknjig, f_osn22, f_osn10, f_osn5, f_pdv22, f_pdv10, f_pdv5 from bonfakt where f_datfakt >='2013-01-01' and f_datfakt <='2013-12-31' ";
                //b_ponisten <> True and b_brfakt = '' and b_kasa <> '' and b_racun <> '' and
                using (AdsDataReader reader = cmd.ExecuteReader())
                {
                    stariBonovi.Load(reader);

                    if (stariBonovi.Rows.Count < 1)
                    {
                        return;
                    }
                    else
                    {
                        dgStariBonovi.DataSource = stariBonovi;
                    }
                }
                conn.Close();
                dgNoviBonovi.Refresh();
            }
        }

        private void btnPrenesiFakture_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgStariBon.RowCount > 0)
                {
                    lvlStatus.Text = "Kopiram fakture iz stare baze u novu! Pričekajte...";
                    lvlStatus.Refresh();
                    btnPrenesi.Enabled = false;

                    for (brojac = 0; brojac < dgStariBon.RowCount; brojac++)
                    {
                        System.Data.DataRow row = dgStariBon.GetDataRow(brojac);
                        if (row != null)
                        {
                            //zaglavlje

                            ifabID = row[0].ToString();

                            partnerSifra = row[1].ToString().Trim();

                            datumIzrade = Convert.ToDateTime(row[2]).ToString("yyyy-MM-dd"); //datfakt

                            vrijemIzrade = Convert.ToDateTime(row[3]).ToString("yyyy-MM-dd"); //valuta
                            
                            iznosBona = row[4].ToString().Replace(",", ".");

                            PDV = row[5].ToString().Replace(",", ".");

                            povratna = row[6].ToString().Replace(",", ".");

                            ukupno = row[7].ToString().Replace(",", ".");

                            if (row[8].ToString() == "")
                            {
                                status = "Z";
                            }
                            else
                            {
                                status = row[8].ToString();
                            }
                            opis = "";

                            knjizen = row[10].ToString();

                            if (row[11].ToString() != "")
                            {
                                datumknjizenja = "'" + Convert.ToDateTime(row[11]).ToString("yyyy-MM-dd") + "'";
                            }
                            else
                            {
                                datumknjizenja = "default";
                            }

                            //ifab_operater je ID admina - 1967

                            //stavke

                            pdv5 = row[17].ToString().Replace(",", ".");
                            pdv10 = row[16].ToString().Replace(",", ".");
                            pdv25 = row[15].ToString().Replace(",", ".");

                            osnovica5 = row[14].ToString().Replace(",", ".");
                            osnovica10 = row[13].ToString().Replace(",", ".");
                            osnovica25 = row[12].ToString().Replace(",", ".");                                                     
                        }

                        partnerID();

                        //zaglavlje fakture

//                        MessageBox.Show(@"insert into ifabon (ifab_ID, partner_pa_ID, ifab_datum, ifab_valuta, ifab_isporuka, ifab_iznos, ifab_porez, ifab_povratna, ifab_ukupno, ifab_status, ifab_napomena, ifab_proknjizen, ifab_datumknjizenja, ifab_operater) 
//                                                        values (" + ifabID + ", " + partner_pa_ID + ", '" + datumIzrade + "', '" + vrijemIzrade + "', '" + datumIzrade + "', " + iznosBona + ", " + PDV + ", " + povratna + ", " + ukupno + ", '" + status + "', '" + opis + "','" + knjizen + "', " + datumknjizenja + ",1967 ) ");

                        veza.ExecuteQuery(@"insert into ifabon (ifab_ID, partner_pa_ID, ifab_datum, ifab_valuta, ifab_isporuka, ifab_iznos, ifab_porez, ifab_povratna, ifab_ukupno, ifab_status, ifab_napomena, ifab_proknjizen, ifab_datumknjizenja, ifab_operater) 
                                                        values (" + ifabID + ", " + partner_pa_ID + ", '" + datumIzrade + "', '" + vrijemIzrade + "', '" + datumIzrade + "', " + iznosBona + ", " + PDV + ", " + povratna + ", " + ukupno + ", '" + status + "', '" + opis + "','" + knjizen + "', " + datumknjizenja + ", 1967) ");


                        //stavke fakture

                        if ( pdv5 != "0")
                        {
                            //MessageBox.Show("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijena = " + Convert.ToString(osnovica5).Replace(',', '.') + ", pr_iznos = " + Convert.ToString(osnovica5).Replace(',', '.') + ", pr_porezIznos = " + Convert.ToString(porez5).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto ='5' , pr_po_sifra = " + _poSIfra + "");
                            veza.ExecuteQuery("insert into ifabonstavka set ifab_ID =" + ifabID + " , pr_sifra = '1' ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1,pr_cijenabruto = " + osnovica5 + ", pr_iznosneto    = " + osnovica5 + ", pr_porezIznos = " + pdv5 + ", pr_povratna = " + povratna + ", pz_posto = 5,pr_postorabat = 0 ,pr_iznosrabat = 0, pr_netocijena = " + osnovica5 + " ");

                            povratnaUpisana = 1;
                        }

                        provjeriPovratnu();

                        if (pdv10 != "0")
                        {
                            veza.ExecuteQuery("insert into ifabonstavka set ifab_ID =" + ifabID + " , pr_sifra = '2' ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijenabruto =" + osnovica10 + ", pr_iznosneto    = " + osnovica10 + ", pr_porezIznos = " + pdv10 + ", pr_povratna = " + povratna + ", pz_posto = 10,pr_postorabat = 0 ,pr_iznosrabat = 0 , pr_netocijena = " + osnovica10 + " ");
                            povratnaUpisana = 1;
                        }

                        provjeriPovratnu();

                        if (pdv25 != "0")
                        {
                            //MessageBox.Show("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + Convert.ToString(porez25).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto = '25',pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + " , pr_po_sifra = " + _poSIfra + " ");
                            veza.ExecuteQuery("insert into ifabonstavka set ifab_ID =" + ifabID + " , pr_sifra = '3' ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijenabruto = " + osnovica25 + ", pr_iznosneto    = " + osnovica25 + ", pr_porezIznos = " + pdv25 + ", pr_povratna = " + povratna + ", pz_posto = 25,pr_postorabat = 0 ,pr_iznosrabat = 0 , pr_netocijena = " + osnovica25 + "  ");
                            povratnaUpisana = 1;
                        }

                        //MessageBox.Show("Uspješno ste dodali podatke!");
                    }
                                        

                    MessageBox.Show("Gotovo prebacivanje faktura!");
                    btnPrenesi.Enabled = false;
                    lvlStatus.Text = "";
                    lvlStatus.Refresh();

                    DataTable podaci = new DataTable();
                    veza.ExecuteQuery("select * from ifabon", ref podaci);
                    dgNoviBonovi.DataSource = podaci;
                    btnPrenesi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void provjeriPovratnu()
        {
            if (povratnaUpisana == 1)
            {
                povratna = "0";
                //Povratna = Convert.ToString(povratna).Replace(',', '.');
            }
        }

        private void txtBonKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }
    }
}
