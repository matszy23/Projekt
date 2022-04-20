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
using System.Windows.Shapes;

namespace biegi_rejestracja.Widoki
{
    /// <summary>
    /// Logika interakcji dla klasy Zalogowanie.xaml
    /// </summary>
    public partial class Zalogowanie : Window
    {
        public uczestnik uczestnik1;
        public Zalogowanie(uczestnik uczestnik)
        {
            uczestnik1 = uczestnik;
            InitializeComponent();
            zapisywanie.IsEnabled = false;
            frame.NavigationService.Navigate(new Zapisywanie(uczestnik1));
        }

        private void wyloguj_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void uczestnik_Click(object sender, RoutedEventArgs e)
        {
            zapisywanie.IsEnabled = true;
            uczestnik.IsEnabled = false;
            frame.NavigationService.Navigate(new Uczestnictwo(uczestnik1));
        }

        private void zapisywanie_Click(object sender, RoutedEventArgs e)
        {
            zapisywanie.IsEnabled = false;
            uczestnik.IsEnabled = true;
            frame.NavigationService.Navigate(new Zapisywanie(uczestnik1));
        }
    }
}
