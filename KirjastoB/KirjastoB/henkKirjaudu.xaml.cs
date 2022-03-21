using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
    /// Interaction logic for henkKirjaudu.xaml
    /// </summary>
    public partial class henkKirjaudu : Window
    {

        public List<Asiakas> asiakkaat;
        

        public henkKirjaudu()
        {
            InitializeComponent();
            string tietokantaPolku = "U:KirjastoB/kirjasto1.accdb";

            OleDbConnection myConn = new OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=" + tietokantaPolku + ";"
                );

            try
            {
                myConn.Open();

                OleDbCommand myQuery = new OleDbCommand("SELECT * FROM Käyttäjätunnus", myConn);

                OleDbDataReader myReader = myQuery.ExecuteReader();

                if(myReader.HasRows)
                {

                    while(myReader.Read() == true)
                    {
                        string userName = myReader.GetString(1);
                        string passWord = myReader.GetString(2);
                        int henkilöID = myReader.GetInt32(0);
                       



                    }

                }
            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            asiakasTiedot ikkuna = new asiakasTiedot();
            ikkuna.Show();
            ikkuna.Asiakastieto(asiakkaat); 
            
        }

        private void Tunnus_TextChanged(object sender, TextChangedEventArgs e)
        {
            // kesken kannan liittäminen kantaan
            OleDbCommand tunnusTarkistus = new OleDbCommand("SELECT * FROM Käyttäjätunnus WHERE userName = 'käyttis'");
        }
    }
}
