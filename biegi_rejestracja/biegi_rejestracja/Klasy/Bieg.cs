using biegi_rejestracja.Klasy;
using biegi_rejestracja.Tabela_baza_danych;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biegi_rejestracja.Widoki
{
    class Bieg
    {
        public string Nazwa { get; }
        private int Id { get; }
        public int Cena {get;}
        public Bieg(string nazwa, int id, int cena)
        {
            Nazwa = nazwa;
            Id = id;
            Cena = cena;
        }

        public Bieg() { }

        public bool Sprawdź(uczestnik uczestnik)
        {
            var lista = from o in Baza_danych.db_lista.Lista_stratowa
                        where o.ID_uczestnika == uczestnik.ID() && o.ID_biegu == Id
                        select o;

            if (lista.Count() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Zapisz(uczestnik uczestnik)
        {
            var rand = new Random();

            Lista_stratowa start = new Lista_stratowa();

            start.ID_biegu = Id;
            start.ID_uczestnika = uczestnik.ID();
            start.Numer_startowy = rand.Next(1, 100);

            Baza_danych.db_lista.Lista_stratowa.InsertOnSubmit(start);
            Baza_danych.db_lista.SubmitChanges();

            return true;
        }

        public List<Start> uczesntik_zawody(uczestnik uczestnik)
        {
            List<Start> starty = new List<Start> { };
            var lista = from start in Baza_danych.db_lista.Lista_stratowa
                       where start.ID_uczestnika == uczestnik.ID()
                       select start;
            lista.ToList();


            if (lista == null)
            {
                return null;
            }
            else
            {

                var bieg = from o in Baza_danych.db_biegi.Biegi
                           select o;
                bieg.ToList();

                foreach (var a in lista)
                {
                    var b = bieg.FirstOrDefault(c => c.Id == a.ID_biegu);
                    starty.Add(new Start(b.Nazwa, b.Dystans, b.Data.ToString("yyyy-MM-dd"),b.Miasto,a.Numer_startowy,b.Id));
                }
                return starty;
            }

        }

        public int numer_start(uczestnik uczestnik)
        {
            var lista = from start in Baza_danych.db_lista.Lista_stratowa
                        where start.ID_uczestnika == uczestnik.ID()
                        select start;
            lista.ToList();

            var b = lista.FirstOrDefault(c => c.ID_biegu == Id);

            return b.Numer_startowy;
        }
        public bool zrezygnuj(uczestnik uczestnik)
        {
            if(Sprawdź(uczestnik))
            {
                var row = Baza_danych.db_lista.Lista_stratowa.SingleOrDefault(x =>
                x.ID_biegu == Id &&
                x.ID_uczestnika == uczestnik.ID() &&
                x.Numer_startowy == numer_start(uczestnik));

                Baza_danych.db_lista.Lista_stratowa.DeleteOnSubmit(row);
                Baza_danych.db_lista.SubmitChanges();
                return true;
            }else
            {
                return false;
            }
        }
    }
}
