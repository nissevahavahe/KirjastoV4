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
    /// Interaction logic for asiakasTiedot.xaml
    /// </summary>


    public partial class asiakasTiedot : Window

        

    {

        public List<Asiakas> tiedotAsiakas;

        

        public List<Asiakas> Asiakas
        {
            get { return tiedotAsiakas; }
        }

        
          
       public asiakasTiedot()
        {

            InitializeComponent();
           

        }

        public void Asiakastieto (List<Asiakas> lista)
        {
            tiedotAsiakas = lista;
            asiakasTiedotLista.ItemsSource = tiedotAsiakas;
        }
    }
}
