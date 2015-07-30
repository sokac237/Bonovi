using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Bonovi
{
    class DohvatiIDSifra
    {

        Upiti veza = new Upiti();
        string SifraID;

        public string DohvatiSifID(string IDSifra, string tablica, string parametar)
        {
            DataTable podaci = new DataTable();

            veza.ExecuteQuery("select " + IDSifra + " from " + tablica + " where " + parametar + "", ref podaci);

            if (podaci.Rows.Count > 0)
            {
                SifraID = podaci.Rows[0][0].ToString();
            }

            return SifraID;
        }
    }
}
