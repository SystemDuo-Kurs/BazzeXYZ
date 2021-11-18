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

namespace BazzeXYZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kontekst _cont = new();
        public MainWindow()
        {
            InitializeComponent();
             _cont.Database.EnsureCreated();
            /*
             _cont.Add(new Osoba { Ime = "sfsegd", Prezime = "235235sd" });
             _cont.Osobas.Add(new Osoba { Ime = "dgsvvsg", Prezime = "ry5r5r5y" });
             _cont.Osobas.Add(new Osoba { Ime = "dhrvdr3", Prezime = "br332" });
             _cont.Osobas.Add(new Osoba { Ime = "bbrvverg", Prezime = "er4heyhasd" });
             _cont.Osobas.Add(new Osoba { Ime = "455berg", Prezime = "erb4566" });
             _cont.Osobas.Add(new Osoba { Ime = "dfvdfvfd43", Prezime = "345566" });
             _cont.SaveChanges();*/

            dg.ItemsSource = _cont.Osobas.Local.ToObservableCollection();

            _cont.Osobas.ToList();
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            _cont.Add(new Osoba { Ime = "Pera", Prezime = "Peric" });
            _cont.SaveChanges();
        }

        private void Obrisi(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem is not null)
            {
                _cont.Remove(dg.SelectedItem as Osoba);
                _cont.SaveChanges();
            }
        }
    }
}
