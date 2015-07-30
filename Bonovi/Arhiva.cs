using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Bonovi
{
    public partial class frmArhiva : Form
    {

        Upiti veza = new Upiti();
        string poslovnaGodina;
        string novakonekcija;

        public frmArhiva()
        {
            InitializeComponent();
        }

        private void frmArhiva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arhiva.poslovnagodina' table. You can move, or remove it, as needed.
            this.poslovnagodinaTableAdapter.Fill(this.arhiva.poslovnagodina);

            // ... 
            colpg_papiri.ColumnEdit = colpg_papiri.View.GridControl.RepositoryItems.Add("TextEdit");
            //colpg_papiri.Caption = "Transmission Kind";
            colpg_papiri.DisplayFormat.FormatType = FormatType.Custom;
            colpg_papiri.DisplayFormat.Format = new BooleanFormatter("Dozvoljena izrada", "Nije dozvoljena izrada");

        }



        class BooleanFormatter : IFormatProvider, ICustomFormatter
        {
            string trueString, falseString;
            public BooleanFormatter(string trueString, string falseString)
            {
                this.trueString = trueString;
                this.falseString = falseString;
            }
            public object GetFormat(System.Type type)
            {
                return this;
            }
            public string Format(string formatString, object arg, IFormatProvider formatProvider)
            {
                bool formatValue = Convert.ToBoolean(arg);
                if (formatValue)
                    return trueString;
                else
                    return falseString;
            }
        }

        private void dgPoslovnaGodina_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgPoslGod.RowCount > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    System.Data.DataRow row = dgPoslGod.GetDataRow(dgPoslGod.FocusedRowHandle);
                    if (row != null)
                    {
                        poslovnaGodina = row[0].ToString();
                        Global.poslGod = poslovnaGodina;
                        kreirajKonekciju();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void dgPoslovnaGodina_DoubleClick(object sender, EventArgs e)
        {
            if (dgPoslGod.RowCount > 0)
            {
                System.Data.DataRow row = dgPoslGod.GetDataRow(dgPoslGod.FocusedRowHandle);
                if (row != null)
                {
                    poslovnaGodina = row[0].ToString();
                    Global.poslGod = poslovnaGodina;
                    kreirajKonekciju();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }


        private void kreirajKonekciju()
        {
            DataTable podaci = new DataTable();
            veza.ExecuteQuery("select pg_server, pg_katalog from poslovnagodina where pg_godina = " + poslovnaGodina + "", ref podaci);

            if (podaci.Rows.Count > 0)
            {
                StringBuilder Con = new StringBuilder("server=");
                Con.Append(podaci.Rows[0][0]);
                Con.Append(";User id= admin10");
                Con.Append(";database=");
                Con.Append(podaci.Rows[0][1]);
                Con.Append(";password=");
                Con.Append("movema10");
                Con.Append(";Persist Security Info=True;");
                novakonekcija = Con.ToString();
                Global.konNova = novakonekcija;
            }

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
