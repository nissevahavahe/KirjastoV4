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

namespace KirjastoB
{
    /// <summary>
    /// Interaction logic for TeoksenTiedotWindow.xaml
    /// </summary>
    public partial class TeoksenTiedotWindow : Window
    {
        private Teos näytettäväTeos;

        public Teos Teos
        {
            get { return näytettäväTeos; }
        }

        public TeoksenTiedotWindow()
        {
            InitializeComponent();
        }

        public void NäytäTeos(Teos t)
        {
            // Tallennetaan näytettävän teoksen tiedot apumuuttujaan
            näytettäväTeos = t;
            // Asetetaan nimi-labelin sisältö
            teoksenNimiLabel.Content = "Teoksen nimi: " + näytettäväTeos.Nimi;
            teoksenIdlabel.Content = "ID-numero: " + näytettäväTeos.Id;
        }
    }
}
