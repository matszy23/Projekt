using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace biegi_rejestracja.Widoki
{
    /// <summary>
    /// Logika interakcji dla klasy Logowanie1.xaml
    /// </summary>
    public partial class Logowanie1 : Page
    {
        public Logowanie1()
        {
            InitializeComponent();
        }

        private void rejestracja_Click(object sender, RoutedEventArgs e)
        {
            (new Rejestracja()).Show();
        }

        private void powrót_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Stona_1());
        }

        private void logowanie_Click(object sender, RoutedEventArgs e)
        {
            uczestnik zawodnik = new uczestnik(login.Text, haslo.SecurePassword);
            if(zawodnik.logowanie())
            {
                new Zalogowanie(zawodnik).Show();
                MainWindow main = Application.Current.MainWindow as MainWindow;
                if(main != null)
                {
                    main.Close();
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub haslo");
            }
        }
    }
}
