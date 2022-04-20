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
    /// Logika interakcji dla klasy Stona_1.xaml
    /// </summary>
    public partial class Stona_1 : Page
    {
        public Stona_1()
        {
            InitializeComponent();

            string connectString = ConfigurationManager.ConnectionStrings["biegi_rejestracja.Properties.Settings.Bieg_rejestracjaConnectionString"].ToString();

            using (biegiDataContext db = new biegiDataContext(connectString))
            {
                var bieg = from o in db.Biegi
                           select o;
                foreach(var a in bieg)
                {
                    wydarzenia.Text += $"{a.Nazwa} {a.Dystans} km {a.Miasto} {a.Data.ToString("dd-MM-yyyy")}" + System.Environment.NewLine;
                }
            }

        }
        private void logowanie_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Logowanie1());
        }

        private void rejestracja_Click(object sender, RoutedEventArgs e)
        {
            (new Rejestracja()).Show();
            this.NavigationService.Navigate(new Logowanie1());
        }
    }
}
