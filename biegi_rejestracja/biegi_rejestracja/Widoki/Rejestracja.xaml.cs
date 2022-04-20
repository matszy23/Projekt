using biegi_rejestracja.Widoki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace biegi_rejestracja
{
    /// <summary>
    /// Logika interakcji dla klasy Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        public Rejestracja()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            
        }


        private void logowanie_msb_Click(object sender, RoutedEventArgs e)
        {
            bool blad = true;
            string plec = "";
            if(M.IsChecked == true)
            {
                plec = "M";
            }else if(K.IsChecked == true)
            {
                plec = "K";
            }

            IntPtr h1 = Marshal.SecureStringToBSTR(haslo.SecurePassword);
            IntPtr h2 = Marshal.SecureStringToBSTR(haslo1.SecurePassword);
            String str1 = Marshal.PtrToStringBSTR(h1);
            String str2 = Marshal.PtrToStringBSTR(h2);


            if (!str1.Equals(str2))
            {
                MessageBox.Show("Hasła nie są identyczne", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    blad = false;
                    uczestnik zawodnik = new uczestnik(imie.Text, nazwisko.Text, haslo.SecurePassword, email.Text,login.Text, plec, data_ur.SelectedDate.Value.Date);
                    if(zawodnik.Dodaj_do_bazy() == false)
                    {
                        MessageBox.Show("Ten login jest zajęty, Proszę wybrać inny login");
                        blad = true;
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Nie Zarejestrowano, WSZYTKIE pola muszą być WYPEŁNIONE");
                   Console.WriteLine(ex.Message);
                   blad = true;
                }

                if(blad == false)
                {
                    MessageBox.Show("Zarejestrowano");
                    this.Close();
                }
            }            
        }
    }
}
