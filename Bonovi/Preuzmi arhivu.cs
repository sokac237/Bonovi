using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bonovi
{
    public partial class frmPreuzmiArhivu : Form
    {
        Upiti veza = new Upiti();
        DataTable podaciTekucaGodina = new DataTable(); 
        DataTable arhiva = new DataTable(); //podaci o serveru i katalogu baze iz arhive

        public frmPreuzmiArhivu()
        {
            InitializeComponent();
        }

        private void dtpOdKada_Enter(object sender, EventArgs e)
        {
            dtpOdKada.Format = DateTimePickerFormat.Short;
            if (dtpOdKada.Text == " ")
            {
                dtpOdKada.Value = DateTime.Now;
            }
        }

        private void dtpOdKada_ValueChanged(object sender, EventArgs e)
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

        private void dtpDoKada_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void frmPreuzmiArhivu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            //prvo iz arhive dohvati poslovnu godinu arhive

            veza.ExecuteQuery("select pg_godina, pg_server, pg_katalog from poslovnagodina where pg_godina = Year(Now()) - 1", ref arhiva);

            if (arhiva.Rows.Count == 1)
            {
                //postoji arhiva 
                //dohvati zapise iz tekuce godine i prikazi u grid

                if (dtpDoKada.Text != " " && dtpOdKada.Text != " ")
                {
                    DateTime prv = Convert.ToDateTime(dtpOdKada.Text);
                    DateTime drug = Convert.ToDateTime(dtpDoKada.Text);

                    string prvi = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                    string drugi = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");


                    veza.ExecuteQuery("select bon_ID, bon_kod, bon_datumkoristenja,bon_vrijemekoristenja, bon_kasa, bon_racunnakasi, bon_iznosracuna, operater_op_ID1, poslovnica_po_ID, bon_bosocard, ifab_ID, bon_proknjizen,bon_datumknjizenja, z_broj, bon_datumbrojanja from bonovi where (bon_datumkoristenja is null or ifab_ID is null  or bon_datumknjizenja is null or z_broj is null or  bon_datumbrojanja is null )  and bon_datumizrade between '" + prvi + "' and '" + drugi + "'", ref podaciTekucaGodina);

                    if (podaciTekucaGodina.Rows.Count > 0)
                    {
                        //bonovi koji nisu iskoristeni

                        dgBonovi.DataSource = podaciTekucaGodina;
                    }
                }
            }     
        }

        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            try
            {
                if (podaciTekucaGodina.Rows.Count > 0)
                {
                    //bonovi koji nisu iskoristeni

                    //dgBonovi.DataSource = podaciTekucaGodina;

                    // idi redom kroz bonove i za svaki u arhivi pokupi podatke

                    //za id dohvati podatke bona,  ako bon u arhivi sadrži datum korištenja pokupi podatak i update u tekućoj bazi

                    DataTable arhivaPodaci = new DataTable();

                    MySqlConnection connection = new MySqlConnection();

                    connection.ConnectionString = "Server = " + arhiva.Rows[0][1].ToString() + "; Database='" + arhiva.Rows[0][2].ToString() + "'; Uid=admin10; Pwd=movema10;";

                    connection.Open();

                    for (int i = 0; i < podaciTekucaGodina.Rows.Count; i++)
                    {
                        string ID = podaciTekucaGodina.Rows[i][0].ToString();

                        using (MySqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandText = "select bonovi.* from bonovi where bon_ID = '" + ID + "' ";

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                arhivaPodaci.Load(reader);

                                if (arhivaPodaci.Rows.Count == 1)
                                {
                                    //ako postoji u arhivi taj dokument provjeri datumkoristenja

                                    if (arhivaPodaci.Rows[0][10].ToString() != "")
                                    {
                                        //ako ima datum u arhivi update u glavnoj bazi te podatke za odgovarajuće kolone

                                        //napraviti upit 

                                        string Upit = "";
                                       
                                        Upit = "update bonovi set";
                                       
                                        if (arhivaPodaci.Rows[0][10].ToString() != "")
                                        {
                                            Upit = Upit + " bon_datumkoristenja= '" + Convert.ToDateTime(arhivaPodaci.Rows[0][10]).ToString("yyyy-MM-dd") + "'";
                                        }

                                        if (arhivaPodaci.Rows[0][11].ToString() != "")
                                        {
                                            Upit = Upit + " ,bon_vrijemekoristenja= '" + arhivaPodaci.Rows[0][11].ToString() + "'";
                                        }

                                        if (arhivaPodaci.Rows[0][12].ToString() != "")
                                        {
                                            Upit = Upit + " ,bon_kasa = '" + arhivaPodaci.Rows[0][12].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][13].ToString() != "")
                                        {
                                            Upit = Upit + " ,bon_racunnakasi= '" + arhivaPodaci.Rows[0][13].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][14].ToString() != "")
                                        {
                                            Upit = Upit + " ,bon_iznosracuna= '" + Convert.ToString(arhivaPodaci.Rows[0][14]).Replace(',', '.') + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][15].ToString() != "")
                                        {
                                            Upit = Upit + " ,operater_op_ID1= '" + arhivaPodaci.Rows[0][15].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][16].ToString() != "")
                                        {
                                            Upit = Upit + " ,poslovnica_po_ID= '" + arhivaPodaci.Rows[0][16].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][17].ToString() != "")
                                        {
                                            Upit = Upit + " ,bon_bosocard= '" + arhivaPodaci.Rows[0][17].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][18].ToString() != "")
                                        {
                                            Upit = Upit + " ,ifab_ID= '" + arhivaPodaci.Rows[0][18].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][22].ToString() != "")
                                        {

                                            string asd = arhivaPodaci.Rows[0][22].ToString();
                                            Upit = Upit + " ,bon_proknjizen= '" + arhivaPodaci.Rows[0][22].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][23].ToString() != "")
                                        {
                                            Upit = Upit + " ,bon_datumknjizenja= '" + Convert.ToDateTime(arhivaPodaci.Rows[0][23]).ToString("yyyy-MM-dd") + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][24].ToString() != "")
                                        {
                                            Upit = Upit + " ,z_broj= '" + arhivaPodaci.Rows[0][24].ToString() + "'";
                                        }
                                        if (arhivaPodaci.Rows[0][25].ToString() != "")
                                        {
                                            Upit = Upit + " ,bon_datumbrojanja= '" + Convert.ToDateTime(arhivaPodaci.Rows[0][25]).ToString("yyyy-MM-dd") + "'";
                                        }


                                        Upit = Upit + " where bon_ID = "+ID+"";
                                        //MessageBox.Show(Upit);
                                        veza.ExecuteQuery(Upit);
                                    }
                                }
                                arhivaPodaci.Clear();
                            }
                        }
                    }

                    connection.Close();

                    MessageBox.Show("Uspješno set ažurirali postojeće podatke s podacima arhive!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
