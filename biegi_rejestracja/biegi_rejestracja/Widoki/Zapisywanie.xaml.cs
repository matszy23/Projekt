using biegi_rejestracja.Tabela_baza_danych;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
    /// Logika interakcji dla klasy Zapisywanie.xaml
    /// </summary>
    public partial class Zapisywanie : Page
    {
        public uczestnik uczesntik;
        public Zapisywanie(uczestnik uczestnik1)
        {
            uczesntik = uczestnik1;
 
            InitializeComponent();

            List<Bieg> LBieg = new List<Bieg> { };

            string connectString = ConfigurationManager.ConnectionStrings["biegi_rejestracja.Properties.Settings.Bieg_rejestracjaConnectionString"].ToString();

            using (biegiDataContext db = new biegiDataContext(connectString))
            {
                var bieg = from o in db.Biegi
                           select o;
                foreach (var a in bieg)
                {
                    wydarzenia.Text += $"{a.Nazwa.ToString()} {a.Dystans.ToString()} km {a.Data.ToString("dd'-'MM'-'yyyy")}" + System.Environment.NewLine;
                    LBieg.Add(new Bieg(a.Nazwa, a.Id,a.Oplata_start));
                }
            }
            CbBieg.ItemsSource = LBieg;
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Bieg bieg  = CbBieg.SelectedItem as Bieg;
            
            if(bieg.Sprawdź(uczesntik) == true)
            {
                MessageBox.Show("Jesteś już zapisany na ten bieg!");
            }
            else
            {
                if(MessageBox.Show($"Czy chcesz zapłacić za start:{bieg.Cena}", "Zapłata",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    bieg.Zapisz(uczesntik);
                    MessageBox.Show("Pomyślnie zapisano");
                }
                else
                {
                    MessageBox.Show("Należy zapłacić opłatę startową");
                }         
            }
            bieg = null;
        }
    }
}
