using biegi_rejestracja.Klasy;
using biegi_rejestracja.Tabela_baza_danych;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Logika interakcji dla klasy Uczestnictwo.xaml
    /// </summary>
    public partial class Uczestnictwo : Page
    {
        public uczestnik uczestnik;
        public Uczestnictwo(uczestnik uczestnik1)
        {
            uczestnik = uczestnik1;

            Bieg bieg = new Bieg() { };

            InitializeComponent();

            List<Start> starty = new List<Start> { };

            starty = bieg.uczesntik_zawody(uczestnik);

            if (starty.Count == 0)
            {
                uczestnictwo.Text += "Nie jesteś zapisany na żaden bieg";
                CbBieg.IsEnabled = false;
            }
            else
            {
                CbBieg.IsEnabled = true;
                foreach (var a in starty)
                {
                    uczestnictwo.Text += a.Wypisz() + System.Environment.NewLine;
                }
                CbBieg.ItemsSource = starty;
            }
        }

        private void Wypisz_Click(object sender, RoutedEventArgs e)
        {
            if (CbBieg.SelectedItem != null)
            {
                Start start = CbBieg.SelectedItem as Start;
                Bieg bieg = start.ToBieg();

                var message = MessageBox.Show("Czy na pewno chcesz zrezygnować z udziału?", "Rezygnacja", MessageBoxButton.YesNo);
                if (message == MessageBoxResult.Yes)
                {
                    if (bieg.zrezygnuj(uczestnik))
                    {
                        MessageBox.Show("Zrezygnowano");
                        this.NavigationService.Navigate(new Uczestnictwo(uczestnik));
                    }
                }
            }
        }
    }
}
