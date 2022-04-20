using biegi_rejestracja.Widoki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biegi_rejestracja.Klasy
{
    class Start
    {
        public string nazwa { get; }
        public int id;
        public int dystans ;
        public string data;
        public string miasto;
        public int numer_startowy;

        public Start(string nazwa, int dystans, string data, string miasto, int numer_startowy, int id)
        {
            this.nazwa = nazwa;
            this.dystans = dystans;
            this.data = data;
            this.miasto = miasto;
            this.numer_startowy = numer_startowy;
            this.id = id;
        }

        public Bieg ToBieg()
        {
            return new Bieg(nazwa, id,0);
        }

        public string Wypisz()
        {
            return $"Nr. startowy: {numer_startowy} - {nazwa} - {miasto} - {data}";
        }
    }
}
