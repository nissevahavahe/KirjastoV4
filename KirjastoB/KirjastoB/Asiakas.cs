using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirjastoB
{
    public class Asiakas
    {
        public string _Nimi = "";

        public string Nimi
        {
            get { return _Nimi; }
        }

        public string _Osoite = "";

        public string Osoite
        {
            get { return _Osoite; }
        }

        public string _Puhelin = "";

        public string Puhelin
        {
            get { return _Puhelin; }
        }

        public string _Email = "";

        public string Email
        {
            get { return _Email; }
        }

        public Asiakas(string asiakkaanOsoite, string asiakkaanNimi, string asiakkaanPuhelin, string asiakkaanEmail)
        {
            _Osoite = asiakkaanOsoite;
            _Nimi = asiakkaanNimi;
            _Puhelin = asiakkaanPuhelin;
            _Email = asiakkaanEmail;
        }


    }

}
