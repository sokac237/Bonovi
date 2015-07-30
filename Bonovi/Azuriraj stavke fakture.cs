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
    public partial class frmAzurirajStavkeFakture : Form
    {
        Upiti veza = new Upiti();
        DataTable podaci = new DataTable();
        string _svakaID;
        string _oznaka;
        string _oznakaVrsteFakture;

        decimal povratna = 0;
        string Povratna;

        decimal ukupno;
        decimal iznos;
        string Iznos;
        decimal kolicina;
        string Kolicina;
        decimal porez;
        string Porez;
        decimal rabat;
        string Rabat;

        decimal rabatUkupno;
        string RabatUkupno;

        string _poSIfra;
        string _partner;

        decimal ukupniIznos;
        string ukupniiznos;

        decimal porezukupno;
        string iznos_porez;

        decimal cijena;
        string Cijena;

        decimal brutocijena;
        string BrutoCijena;

        string _iznos;
        string _stavke;

        int povratnaUpisana = 0; //oznaka koja daje do znanja da je povratna već upisana na jednoj od stavki robe po izboru

        public frmAzurirajStavkeFakture()
        {
            InitializeComponent();
        }

        public string partnerID
        {
            get { return _partner; }
            set { _partner = value; }
        }

        public string IDstavke
        {
            get { return _svakaID; }
            set { _svakaID = value; }
        }

        public string iznosFakture
        {
            get { return _iznos; }
            set { _iznos = value; }
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string oznakaVrsteFakture
        {
            get { return _oznakaVrsteFakture; }
            set { _oznakaVrsteFakture = value; }
        }

        public string sifraPo
        {
            get { return _poSIfra; }
            set { _poSIfra = value; }
        }


        public string stavke
        {
            get { return _stavke; }
            set { _stavke = value; }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAzurirajStavkeFakture_Load(object sender, EventArgs e)
        {
            if (Global.postotakoznaka == "13")
            {
                lblPorez.Text = "Porez ( 13% ):";
            }
            else
            {
                lblPorez.Text = "Porez ( 10% ):";
            }

            if (_stavke == "1")
            {
                //onemoguci ostale txt boxove osim opisa
                txtSifra.Enabled = false;
                txtKolicina.Enabled = false;
                txtCijena.Enabled = false;
                txtPorez.Enabled = false;
                txtPovratna.Enabled = false;
                txtRabat.Enabled = false;
            }

            if (_oznaka != "A") //insert
            {
                //provjeri da li je sa stavkama ili bez stavki

                if (_oznakaVrsteFakture == "1") //1 znaci bez stavki
                {
                    //dohvati osnovicu i povratnu i napuni formu
                    txtPorez5.EditValue = Convert.ToDecimal(Podaci.osnovica5);

                    txtPorez10.EditValue =  Convert.ToDecimal(Podaci.osnovica10);

                    txtPovratna2.EditValue =  Convert.ToDecimal(Podaci.povratna);

                    panel1.Visible = false;
                    DohvatiIDSifra dohvati = new DohvatiIDSifra();
                    string partner = dohvati.DohvatiSifID("pa_naziv", "partner", "pa_ID = " + _partner + "");
                    lblPartner.Text = partner;
                    txtIznosSPorezom.EditValue = Convert.ToDecimal(_iznos);
                }
                else
                {
                    //sa stavkama PDV 25%
                    txtPorez.EditValue = 25.00;
                    panel2.Visible = false;
                }
            }
            else //ažuriraj
            {
                try
                {
                    panel2.Visible = false;
                    veza.ExecuteQuery("select  pr_sifra, pr_naziv , pr_kolicina, pr_povratna, pr_iznosneto, pz_posto, pr_postorabat, pr_porezIznos from ifabonstavka_tmp where bonSt_ID = '" + _svakaID + "' and operater_op_ID = "+Global.KorisnikID+"", ref podaci);

                    if (podaci.Rows.Count > 0)
                    {
                        txtSifra.Text = podaci.Rows[0][0].ToString().Trim();
                        txtNaziv.Text = podaci.Rows[0][1].ToString().Trim();

                        txtKolicina.EditValue = podaci.Rows[0][2];
                        txtPorez.EditValue = podaci.Rows[0][5];
                        txtPovratna.EditValue = podaci.Rows[0][3];
                        txtRabat.EditValue = podaci.Rows[0][6];

                        double rabat = (100 - Convert.ToDouble(podaci.Rows[0][6])) / 100;
                        double cijena = Convert.ToDouble(podaci.Rows[0][4]) + Convert.ToDouble(podaci.Rows[0][7]) + Convert.ToDouble(txtPovratna.EditValue);
                        double cijenaa = cijena / rabat;
                        txtCijena.EditValue = Math.Round(cijenaa,2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmAzurirajStavkeFakture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtKolicina_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 13)
                    e.Cancel = true;
        }

        private void txtCijena_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 12)
                    e.Cancel = true;
        }

        private void txtPorez_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 12)
                    e.Cancel = true;
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtCijena.Text != "" && txtKolicina.Text != "" && txtPorez.Text != "" && txtSifra.Text != "")
                {
                    obracunaj();

                    if (_oznaka == "A") //ažuriranje
                    {
                        veza.ExecuteQuery("update ifabonstavka_tmp set pr_sifra = " + txtSifra.Text.Trim() + " ,pr_naziv = '" + txtNaziv.Text.Trim() + "', pr_kolicina = " + Kolicina + ", pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + iznos_porez + ", pr_povratna = " + Povratna + ", pz_posto = " + Porez + ",pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + "  where bonSt_ID = " + _svakaID + " and operater_op_ID  ="+Global.KorisnikID+"");
                        MessageBox.Show("Uspješno ste ažurirali podatke!");
                        frmNapraviFakturu.osvjezi.PerformClick();
                        this.Close();
                    }
                    else //insert
                    {
                        //MessageBox.Show("insert into ifabonstavka_tmp set pr_sifra = " + txtSifra.Text.Trim() + " ,pr_naziv = '" + txtNaziv.Text.Trim() + "', pr_kolicina = " + Kolicina + ", pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + iznos_porez + ", pr_povratna = " + Povratna + ", pz_posto = " + Porez + ",pr_postorabat = "+Rabat+" ,pr_iznosrabat = "+RabatUkupno+", pr_netocijena = "+Cijena+" , pr_po_sifra = " + _poSIfra + " , operater_op_ID = "+Global.KorisnikID+" ");
                        veza.ExecuteQuery("insert into ifabonstavka_tmp set pr_sifra = " + txtSifra.Text.Trim() + " ,pr_naziv = '" + txtNaziv.Text.Trim() + "', pr_kolicina = " + Kolicina + ", pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + iznos_porez + ", pr_povratna = " + Povratna + ", pz_posto = " + Porez + ",pr_postorabat = "+Rabat+" ,pr_iznosrabat = "+RabatUkupno+", pr_netocijena = "+Cijena+" , pr_po_sifra = " + _poSIfra + " , operater_op_ID = "+Global.KorisnikID+" ");
                        MessageBox.Show("Uspješno ste dodali podatke!");
                        frmNapraviFakturu.osvjezi.PerformClick();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void obracunaj()
        
        {   
            if (txtCijena.Text != "" && txtKolicina.Text != "" && txtSifra.Text != "" && txtPorez.Text != "")
            {
                //ukupno = decimal.Parse(txtCijena.Text);
                //kolicina = decimal.Parse(txtKolicina.Text);
                //porez = decimal.Parse(txtPorez.Text);

                //if (txtPovratna.Text != "")
                //{
                //    povratna = decimal.Parse(txtPovratna.Text);
                //    Povratna = Convert.ToString(povratna).Replace(',', '.');
                //}
                //else
                //{
                //    povratna = 0;
                //    Povratna = Convert.ToString(povratna).Replace(',', '.');
                //}

                //rabat = decimal.Parse(txtRabat.Text);

                //ukupniIznos = Math.Round((ukupno), 2);
                //ukupniiznos = Convert.ToString(ukupniIznos).Replace(',', '.');

                //porezukupno = Math.Round((ukupniIznos - (povratna)) * (((100 * porez) / (100 + porez)) / 100), 3);
                //iznos_porez = Convert.ToString(porezukupno).Replace(',','.');

                //cijena = Math.Round((ukupniIznos - (povratna + porezukupno)) / kolicina,3);
                ////cijena = Math.Round((ukupniIznos - (kolicina * povratna)) / kolicina, 3);
                //Cijena = Convert.ToString(cijena).Replace(',', '.');

                //iznos = Math.Round(cijena * kolicina, 3);
                //Iznos = Convert.ToString(iznos).Replace(',', '.');


                ukupno = decimal.Parse(txtCijena.Text);
                
                kolicina = decimal.Parse(txtKolicina.Text);
                Kolicina = Convert.ToString(kolicina).Replace(',', '.');

                porez = decimal.Parse(txtPorez.Text);
                Porez = Convert.ToString(porez).Replace(',', '.');

                if (txtPovratna.Text != "")
                {
                    povratna = decimal.Parse(txtPovratna.Text);
                    Povratna = Convert.ToString(povratna).Replace(',', '.');
                }
                else
                {
                    povratna = 0;
                    Povratna = Convert.ToString(povratna).Replace(',', '.');
                }

                if (txtRabat.Text != "")
                {
                    rabat = decimal.Parse(txtRabat.Text);
                    Rabat = Convert.ToString(rabat).Replace(',', '.');

                }
                else 
                {
                    rabat = 0;
                    Rabat = Convert.ToString(rabat).Replace(',', '.');
                }
               
                //izbij rabat iz ukupnog iznosa
                ukupno = ukupno * ((100 - rabat) / 100);

                ukupniIznos = Math.Round((ukupno), 2);
                ukupniiznos = Convert.ToString(ukupniIznos).Replace(',', '.');

                //prvo izbijem povratnu naknadu

                ukupniIznos = ukupniIznos - povratna;

                //retroaktivno izracunam bruto cijenu
                brutocijena = Math.Round(ukupniIznos / (kolicina * (100 - rabat) / 100 * (porez/100 + 1)),3);
                BrutoCijena = Convert.ToString(brutocijena).Replace(',', '.');

                //izracunam neto cijenu
                cijena = Math.Round(brutocijena*(100-rabat)/100, 2);
                Cijena = Convert.ToString(cijena).Replace(',', '.');

                //neto iznos

                iznos = Math.Round(brutocijena * kolicina * (100 - rabat) / 100, 2);
                Iznos = Convert.ToString(iznos).Replace(',', '.');

                //iznos = Math.Round(cijena * kolicina, 2);
                //Iznos = Convert.ToString(iznos).Replace(',', '.');

                //porez i rabat
                porezukupno = Math.Round(iznos * (porez / 100), 3);
                iznos_porez = Convert.ToString(porezukupno).Replace(',', '.');

                rabatUkupno = Math.Round(brutocijena * (rabat / 100) * kolicina,3);
                RabatUkupno = Convert.ToString(rabatUkupno).Replace(',', '.');



                //decimal povratna = txtPovratna.Value;

                //decimal cijena = txtCijena.Value;
                //decimal kolicina = Convert.ToDecimal(txtKol.Value);
                //decimal postoRabat = Convert.ToDecimal(txtPostoRabat.Value);
                //// decimal iznosRabat = Math.Round(kolicina * (cijena-(cijena *(100 - postoRabat)/100)),2) ;
                //decimal iznosRabat = Math.Round((cijena * (postoRabat / 100)), 2);
                ////string iznosrabat = Convert.ToString(iznosRabat);
                //string iznosrabat = Convert.ToString(iznosRabat * kolicina);
                //decimal rabat = Convert.ToDecimal(iznosrabat);
                ////decimal netoCijena = Math.Round((cijena - (iznosRabat/kolicina)),2);
                ////decimal netoCijena = Math.Round((cijena - (iznosRabat)), 2);
                //decimal netoCijena = Math.Round((cijena - (iznosRabat)), 2);
                //string netocijena = Convert.ToString(netoCijena);
                ////decimal vrijednost = Math.Round(netoCijena * kolicina, 2);
                //decimal vrijednost = Math.Round((netoCijena * kolicina), 2);
                //string vrijednost_konacna = Convert.ToString(vrijednost);

                //string porez = PDV.Rows[cmbPDV.SelectedIndex][2].ToString();
                //decimal a = Convert.ToDecimal(porez);
                //decimal porezukupno = Math.Round(vrijednost * (a / 100), 3);
                //string iznos_porez = Convert.ToString(porezukupno);

            }
        }

        private void frmAzurirajStavkeFakture_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmNapraviFakturu.osvjezi.PerformClick();
        }

        private void btnOdustani2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void provjeriPovratnu()
        {
            if (povratnaUpisana == 1)
            {
                povratna = 0;
                Povratna = Convert.ToString(povratna).Replace(',', '.');
            }
        }
        private void btnSpremi2_Click(object sender, EventArgs e)
        {
            //obracunaj2();

            if (txtIznosSPorezom.Text != "" && txtPorez25.Text != "")
            {
                //spremi u bazu kao 3 zasebna retka

                int sifra = 1;


                provjeriPovratnu();

                //provjeri dal postoji povratna naknada, ako da dodaj je na jednu od stavki, na prvu i obriši

                if (txtPorez5.Text != "" && txtPorez5.Text != "0")
                {
                    izracunajPodatkeStavkeRobaPoIzboru5();
                    //MessageBox.Show("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijena = " + Convert.ToString(osnovica5).Replace(',', '.') + ", pr_iznos = " + Convert.ToString(osnovica5).Replace(',', '.') + ", pr_porezIznos = " + Convert.ToString(porez5).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto ='5' , pr_po_sifra = " + _poSIfra + "");
                    veza.ExecuteQuery("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1,pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + Convert.ToString(porez5).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto = 5,pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + " , pr_po_sifra = " + _poSIfra + " , operater_op_ID ="+Global.KorisnikID+"");
                    
                    //veza.ExecuteQuery("insert into ifabonstavka_tmp set pr_sifra = " + txtSifra.Text.Trim() + " ,pr_naziv = '" + txtNaziv.Text.Trim() + "', pr_kolicina = " + Kolicina + ", pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + iznos_porez + ", pr_povratna = " + Povratna + ", pz_posto = " + Porez + ",pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + " , pr_po_sifra = " + _poSIfra + " ");
                    sifra++;
                    povratnaUpisana = 1;
                }

                provjeriPovratnu();

                if (Global.postotakoznaka == "13")
                {
                    if (txtPorez10.Text != "" && txtPorez10.Text != "0")
                    {
                        izracunajPodatkeStavkeRobaPoIzboru10();
                        veza.ExecuteQuery("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + Convert.ToString(porez10).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto = 13,pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + " , pr_po_sifra = " + _poSIfra + ", operater_op_ID =" + Global.KorisnikID + " ");
                        sifra++;
                        povratnaUpisana = 1;
                    }
                }
                else if(Global.postotakoznaka == "10")
                {
                    if (txtPorez10.Text != "" && txtPorez10.Text != "0")
                    {
                        izracunajPodatkeStavkeRobaPoIzboru10();
                        veza.ExecuteQuery("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + Convert.ToString(porez10).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto = 10,pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + " , pr_po_sifra = " + _poSIfra + ", operater_op_ID =" + Global.KorisnikID + " ");
                        sifra++;
                        povratnaUpisana = 1;
                    }
                }

                provjeriPovratnu();

                if (txtPorez25.Text != "" && txtPorez25.Text != "0")
                {
                    izracunajPodatkeStavkeRobaPoIzboru25();
                    //MessageBox.Show("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + Convert.ToString(porez25).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto = '25',pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + " , pr_po_sifra = " + _poSIfra + " ");
                    veza.ExecuteQuery("insert into ifabonstavka_tmp set pr_sifra = " + sifra + " ,pr_naziv = 'ROBA PO IZBORU', pr_kolicina = 1, pr_cijenabruto = " + BrutoCijena + ", pr_iznosneto    = " + Iznos + ", pr_porezIznos = " + Convert.ToString(porez25).Replace(',', '.') + ", pr_povratna = " + Povratna + ", pz_posto = 25,pr_postorabat = " + Rabat + " ,pr_iznosrabat = " + RabatUkupno + ", pr_netocijena = " + Cijena + " , pr_po_sifra = " + _poSIfra + ", operater_op_ID =" + Global.KorisnikID + " ");
                    sifra++;
                    povratnaUpisana = 1;
                }

                MessageBox.Show("Uspješno ste dodali podatke!");
                frmNapraviFakturu.osvjezi.PerformClick();
                this.Close();
            }
        }

        decimal iznosUkupni;
        decimal porez5;
        decimal porez10;
        decimal porez25;

        decimal osnovica5;
        decimal osnovica10;
        decimal osnovica25;

        private void obracunaj2()
        {
            if (txtIznosSPorezom.Text != "" || txtPorez5.Text != "" || txtPorez10.Text != "")
            {
                iznosUkupni = decimal.Parse(txtIznosSPorezom.Text);

                if (txtPovratna2.Text != "")
                {
                    povratna = decimal.Parse(txtPovratna2.Text);
                    Povratna = Convert.ToString(povratna).Replace(',', '.');
                }
                else
                {
                    povratna = 0;
                    Povratna = Convert.ToString(povratna).Replace(',', '.');
                }

                if (txtRabat2.Text != "")
                {
                    rabat = decimal.Parse(txtRabat2.Text);
                    Rabat = Convert.ToString(rabat).Replace(',', '.');
                }
                else
                {
                    rabat = 0;
                    Rabat = Convert.ToString(rabat).Replace(',', '.');
                }

                if (txtPorez5.Text != "")
                {
                    osnovica5 = decimal.Parse(txtPorez5.Text);
                }

                porez5 = Math.Round(osnovica5 * 5 / 100,2);



                if (Global.postotakoznaka == "13")
                {
                    if (txtPorez10.Text != "")
                    {
                        osnovica10 = decimal.Parse(txtPorez10.Text);
                    }

                    porez10 = Math.Round(osnovica10 * 13 / 100, 2);



                    //izbij rabat
                    iznosUkupni = iznosUkupni * ((100 - rabat) / 100);

                    osnovica25 = ((iznosUkupni - povratna - osnovica5 - porez5 - osnovica10 - porez10) * 100) / 125;

                    porez25 = Math.Round(osnovica25 * 25 / 100, 2);
                }
                else if (Global.postotakoznaka == "10")
                {
                    if (txtPorez10.Text != "")
                    {
                        osnovica10 = decimal.Parse(txtPorez10.Text);
                    }

                    porez10 = Math.Round(osnovica10 * 10 / 100, 2);



                    //izbij rabat
                    iznosUkupni = iznosUkupni * ((100 - rabat) / 100);

                    osnovica25 = ((iznosUkupni - povratna - osnovica5 - porez5 - osnovica10 - porez10) * 100) / 125;

                    porez25 = Math.Round(osnovica25 * 25 / 100, 2);
                }

               

                ////osnovica 25 % s rabatom 
                //osnovica25 = ((iznosUkupni - povratna - osnovica5 / (1 + (rabat / 100)) - porez5 - osnovica10 / (1 + (rabat / 100)) - porez10) * 100) / 125;

                //porez25 = osnovica25 * 25 / 100;

                //umanjiti osnovice za isnos rabata

                //osnovica5 = osnovica5 * (100 - rabat) / 100;

                //osnovica10 = osnovica10 * (100 - rabat) / 100;

                //osnovica25 = osnovica25 * (100 - rabat) / 100;

                //porez5 = osnovica5 * 5 / 100;

                //porez10 = osnovica10 * 10 / 100;

                //porez25 = osnovica25 * 25 / 100;


                txtIznosPorez5.Text = Convert.ToString(porez5).Replace(".", ",");

                txtIznosPorez10.Text = Convert.ToString(porez10).Replace(".", ",");

                txtPorez25.Text = Convert.ToString(osnovica25).Replace(".", ",");

                txtIznosPorez25.Text = Convert.ToString(porez25).Replace(".", ",");





                //iznos_porez = Convert.ToString(porezukupno).Replace(',', '.');

                //cijena = Math.Round((ukupniIznos - (povratna + porezukupno)) / kolicina, 3);
                //cijena = Math.Round((ukupniIznos - (kolicina * povratna)) / kolicina, 3);
                //Cijena = Convert.ToString(cijena).Replace(',', '.');

                //iznos = Math.Round(cijena * kolicina, 3);
                //Iznos = Convert.ToString(iznos).Replace(',', '.');

                //txtPorez25.Text = Convert.ToString(iznos).Replace(',', '.');
            }
        }

        private void izracunajPodatkeStavkeRobaPoIzboru5()
        {
            //prvo izbijem povratnu naknadu

            //iznosUkupni = iznosUkupni - povratna;
            kolicina = 1;

            //retroaktivno izracunam bruto cijenu
            if (txtPorez5.Text != "" && txtPorez5.Text != "0")
            {

                //iznosUkupni = iznosUkupni - osnovica10 - osnovica25;
                //double a = Convert.ToDouble(iznosUkupni / (kolicina * ((100 - rabat) / 100)));
                //double b = (double)a / (5.00 / 100 + 1);
                //brutocijena = Convert.ToDecimal(b);
                //brutocijena = Math.Round(iznosUkupni / (kolicina * (100 - rabat) / 100 * (5 / 100 + 1)), 3);

                brutocijena = Math.Round(osnovica5 / ((100 - rabat) / 100), 3);
                BrutoCijena = Convert.ToString(brutocijena).Replace(',', '.');



                //brutocijena = Math.Round(iznosUkupni / (kolicina * (100 - rabat) / 100 * (porez / 100 + 1)), 3);
                //BrutoCijena = Convert.ToString(brutocijena).Replace(',', '.');

                //izracunam neto cijenu

                cijena = Math.Round(brutocijena * (100 - rabat) / 100, 2);
                Cijena = Convert.ToString(cijena).Replace(',', '.');

                //neto iznos
                iznos = Math.Round(brutocijena * kolicina * (100 - rabat) / 100, 2);
                Iznos = Convert.ToString(iznos).Replace(',', '.');

                //iznos = Math.Round(cijena * kolicina, 2);
                //Iznos = Convert.ToString(iznos).Replace(',', '.');

                // rabat

                rabatUkupno = Math.Round(brutocijena * (rabat / 100) * kolicina, 3);
                RabatUkupno = Convert.ToString(rabatUkupno).Replace(',', '.');
            }
        }

        private void izracunajPodatkeStavkeRobaPoIzboru10()
        {
            //prvo izbijem povratnu naknadu

            //iznosUkupni = iznosUkupni - povratna;
            kolicina = 1;

            //retroaktivno izracunam bruto cijenu

            if (txtPorez10.Text != "" && txtPorez10.Text != "0")
            {
                //iznosUkupni = iznosUkupni - osnovica5 - osnovica25;
                //double a = Convert.ToDouble(iznosUkupni / (kolicina * ((100 - rabat) / 100)));
                //double b = (double)a / (10.00 / 100 + 1);
                //brutocijena = Convert.ToDecimal(b);
                //brutocijena = Math.Round(iznosUkupni / (kolicina * (100 - rabat) / 100 * (10 / 100 + 1)), 3);

                brutocijena = Math.Round(osnovica10 / ((100 - rabat) / 100), 3);
                BrutoCijena = Convert.ToString(brutocijena).Replace(',', '.');


                //izracunam neto cijenu

                cijena = Math.Round(brutocijena * (100 - rabat) / 100, 2);
                Cijena = Convert.ToString(cijena).Replace(',', '.');

                //neto iznos
                iznos = Math.Round(brutocijena * kolicina * (100 - rabat) / 100, 2);
                Iznos = Convert.ToString(iznos).Replace(',', '.');

                //iznos = Math.Round(cijena * kolicina, 2);
                //Iznos = Convert.ToString(iznos).Replace(',', '.');

                // rabat

                rabatUkupno = Math.Round(brutocijena * (rabat / 100) * kolicina, 3);
                RabatUkupno = Convert.ToString(rabatUkupno).Replace(',', '.');
            }
        }

        private void izracunajPodatkeStavkeRobaPoIzboru13()
        {
            //prvo izbijem povratnu naknadu

            //iznosUkupni = iznosUkupni - povratna;
            kolicina = 1;

            //retroaktivno izracunam bruto cijenu

            if (txtPorez10.Text != "" && txtPorez10.Text != "0")
            {
                //iznosUkupni = iznosUkupni - osnovica5 - osnovica25;
                //double a = Convert.ToDouble(iznosUkupni / (kolicina * ((100 - rabat) / 100)));
                //double b = (double)a / (10.00 / 100 + 1);
                //brutocijena = Convert.ToDecimal(b);
                //brutocijena = Math.Round(iznosUkupni / (kolicina * (100 - rabat) / 100 * (10 / 100 + 1)), 3);

                brutocijena = Math.Round(osnovica10 / ((100 - rabat) / 100), 3);
                BrutoCijena = Convert.ToString(brutocijena).Replace(',', '.');


                //izracunam neto cijenu

                cijena = Math.Round(brutocijena * (100 - rabat) / 100, 2);
                Cijena = Convert.ToString(cijena).Replace(',', '.');

                //neto iznos
                iznos = Math.Round(brutocijena * kolicina * (100 - rabat) / 100, 2);
                Iznos = Convert.ToString(iznos).Replace(',', '.');

                //iznos = Math.Round(cijena * kolicina, 2);
                //Iznos = Convert.ToString(iznos).Replace(',', '.');

                // rabat

                rabatUkupno = Math.Round(brutocijena * (rabat / 100) * kolicina, 3);
                RabatUkupno = Convert.ToString(rabatUkupno).Replace(',', '.');
            }
        }

        private void izracunajPodatkeStavkeRobaPoIzboru25()
        {
            //prvo izbijem povratnu naknadu

            //iznosUkupni = iznosUkupni - povratna;
            kolicina = 1;

            //retroaktivno izracunam bruto cijenu

            if (txtPorez25.Text != "" && txtPorez25.Text != "0")
            {
                //iznosUkupni = iznosUkupni - osnovica5 - osnovica10;
                //double a = Convert.ToDouble(iznosUkupni / (kolicina * ((100 - rabat) / 100)));
                //double b = (double)a / (25.00 / 100 + 1);
                //brutocijena = Convert.ToDecimal(b);

                brutocijena = Math.Round(osnovica25 / ((100 - rabat) / 100), 3);
                BrutoCijena = Convert.ToString(Math.Round(brutocijena, 2)).Replace(',', '.');


                //izracunam neto cijenu

                cijena = Math.Round(brutocijena * (100 - rabat) / 100, 2);
                Cijena = Convert.ToString(cijena).Replace(',', '.');

                //neto iznos
                iznos = Math.Round(brutocijena * kolicina * (100 - rabat) / 100, 2);
                Iznos = Convert.ToString(iznos).Replace(',', '.');

                //iznos = Math.Round(cijena * kolicina, 2);
                //Iznos = Convert.ToString(iznos).Replace(',', '.');

                // rabat

                rabatUkupno = Math.Round(brutocijena * (rabat / 100) * kolicina, 3);
                RabatUkupno = Convert.ToString(rabatUkupno).Replace(',', '.');
            }
        }

        private void txtPorez10_Leave(object sender, EventArgs e)
        {
            if (txtIznosSPorezom.Text != "")
            {
                obracunaj2();
            }
        }

        private void txtSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }
    }
}
