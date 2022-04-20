using biegi_rejestracja.Klasy;
using biegi_rejestracja.Tabela_baza_danych;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace biegi_rejestracja
{
    public class uczestnik
    {
        private string imie;
        private string nazwisko;
        private SecureString haslo;
        private string email;
        private string plec;
        private string login;
        DateTime data_ur;

        public uczestnik() { }
        public uczestnik(string login, SecureString haslo)
        {
            this.login = login;
            this.haslo = haslo;
        }
        public uczestnik(string imie, string nazwisko, SecureString haslo, string email, string login, string plec, DateTime data_ur)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.haslo = haslo;
            this.email = email;
            this.plec = plec;
            this.login = login;
            this.data_ur = data_ur;

        }

        public bool Dodaj_do_bazy()
        {

            Zawodnik nowyZawodnik = new Zawodnik() { };

            nowyZawodnik.Imie = imie;
            nowyZawodnik.Nazwisko = nazwisko;
            nowyZawodnik.Płeć = plec;
            nowyZawodnik.Email = email;
            nowyZawodnik.Data_urodzenia = data_ur;
            nowyZawodnik.Haslo = szyfruj_haslo();
            nowyZawodnik.Login = login;

            if (Baza_danych.db_zawodnik.Zawodnik.FirstOrDefault(d => d.Login.Equals(login)) != null)
            {
                return false;
            }
            else
            {
                Baza_danych.db_zawodnik.Zawodnik.InsertOnSubmit(nowyZawodnik);
                Baza_danych.db_zawodnik.SubmitChanges();
            }
            return true;
        }

        public string szyfruj_haslo()
        {
            IntPtr valuePtr = IntPtr.Zero;
            string haslo1;
            string hash;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(haslo);
                haslo1 = Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }

            using(SHA256 sha256Hash = SHA256.Create())
            {
                hash = get_hash(sha256Hash, haslo1);
            }

            return hash;

        }

        private string get_hash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBulider = new StringBuilder();

            for(int i =0;i<data.Length;i++)
            {
                sBulider.Append(data[i].ToString("x2"));
            }
            return sBulider.ToString();
        }

        public bool logowanie()
        {
            Zawodnik zawodnik = new Zawodnik() { };
            Zawodnik zawodnik1 = new Zawodnik() { };

            zawodnik.Login = login;
            zawodnik.Haslo = szyfruj_haslo();

            try
            {
                zawodnik1 = Baza_danych.db_zawodnik.Zawodnik.First(d => d.Login.Equals(login));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            if (zawodnik1.Haslo == zawodnik.Haslo)
            {
                return true;
            }
            return false;

        }

        public int ID()
        {
            var z = Baza_danych.db_zawodnik.Zawodnik.First(d => d.Login.Equals(login));

            return z.Id;
        }
    }
}

