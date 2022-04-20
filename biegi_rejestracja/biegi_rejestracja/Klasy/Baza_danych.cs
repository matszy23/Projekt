using biegi_rejestracja.Tabela_baza_danych;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biegi_rejestracja.Klasy
{
    static class Baza_danych
    {
        private static string connection_string = "biegi_rejestracja.Properties.Settings.Bieg_rejestracjaConnectionString";

       public static lista_startowaDataContext db_lista = new lista_startowaDataContext(ConfigurationManager.ConnectionStrings[connection_string].ToString()) { };

       public static biegiDataContext db_biegi = new biegiDataContext(ConfigurationManager.ConnectionStrings[connection_string].ToString()) { };

       public static zawodnikDataContext db_zawodnik = new zawodnikDataContext(ConfigurationManager.ConnectionStrings[connection_string].ToString()) { };
    }
}
