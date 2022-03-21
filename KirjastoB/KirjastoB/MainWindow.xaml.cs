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

namespace KirjastoB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Määritellään kirjasto, jossa asioidaan
        private Kirjasto valittuKirjasto;

        // Lista, jolla tarkistetaan onko ikkuna jo avattu
        private List<TeoksenTiedotWindow> teoksenTiedotIkkunat = new List<TeoksenTiedotWindow>();

        public MainWindow()
        {
            // Alustetaan kirjasto kun sovellus käynnistyy
            valittuKirjasto = new Kirjasto("Palosaaren kirjasto",
                "Pikitehtaankatu 19-23, 65200 Vaasa");

            // Luodaan mock teoksia
            valittuKirjasto.LuoMockDataa(20);

            InitializeComponent();


            // ListView.ItemsSource kertoo, mistä listassa näytettävät
            // itemit tulevat
            hakuTuloksetLista.ItemsSource = valittuKirjasto.Teokset;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 1. otetaan vastaan käyttäjän syöttämät hakuehdot
            string nimiHakutermi = teoksenNimiKenttä.Text.Trim();

            // Tarkistetaan että joku merkki on syötetty
            if(String.IsNullOrWhiteSpace(nimiHakutermi) == true)
            {
                // Jos tyhjä hakutermi -> näytä kaikki teokset
                hakuTuloksetLista.ItemsSource = valittuKirjasto.Teokset;
            }
            else
            {
                // 2. Suoritetaan haku
                List<Teos> osumat = valittuKirjasto.Teokset.FindAll(
                    x => x.Nimi.Contains(nimiHakutermi) == true
                    );

                // 3. näytetään tulokset
                hakuTuloksetLista.ItemsSource = osumat;
            }
            
        }

        private void hakuTuloksetLista_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Tarkistetaan ensin, että jokin rivi on tuplaklikattu
            if(hakuTuloksetLista.SelectedItem != null)
            {
                // Joudumme tekemään tyyppimuunnoksen (type casting)
                Teos klikattuTeos = (Teos)hakuTuloksetLista.SelectedItem;

                // Tarkistetaan, onko jo ikkuna avattu tälle teokselle
                TeoksenTiedotWindow aukiJo = teoksenTiedotIkkunat.Find(
                    x => x.Teos == klikattuTeos
                    );

                if(aukiJo == null)
                {
                    TeoksenTiedotWindow ikkuna = new TeoksenTiedotWindow();
                    ikkuna.NäytäTeos(klikattuTeos);
                    ikkuna.Show();

                    teoksenTiedotIkkunat.Add(ikkuna);
                }

                
            }
        }

        // To do ikkuna.asiakaat 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            henkKirjaudu ikkuna = new henkKirjaudu();
            ikkuna.Show();
            ikkuna.asiakkaat = valittuKirjasto.Asiakas;
            
        }
    }
}
