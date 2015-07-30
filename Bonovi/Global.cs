using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonovi
{
    class Global
    {

        private static string ImePrezime = "";
        public static string Korisnik
        {
            get { return ImePrezime; }
            set { ImePrezime = value; }
        }

        private static string IDkoirsnika = "";
        public static string KorisnikID
        {
            get { return IDkoirsnika; }
            set { IDkoirsnika = value; }
        }


        private static string oznakaPostotka = "";
        public static string postotakoznaka
        {
            get { return oznakaPostotka; }
            set { oznakaPostotka = value; }
        }


        private static string poslovnaGodina = "";
        public static string poslGod
        {
            get { return poslovnaGodina; }
            set { poslovnaGodina = value; }
        }


        private static string novaKonekcija = "";
        public static string konNova
        {
            get { return novaKonekcija; }
            set { novaKonekcija = value; }
        }
    }
}
