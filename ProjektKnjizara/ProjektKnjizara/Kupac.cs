using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKnjizara
{
    public class Kupac
    {
        private String Ime;

        private String Prezime;

        private String BrojKartice;

        public String ImeKupca
        {
            get
            {
                return Ime;
            }
            set
            {
                Ime = value;
            }
        }

        public String PrezimeKupca
        {
            get
            {
                return Prezime;
            }
            set
            {
                Prezime = value;
            }
        }
        public string BrojKarticeKupca
        {
            get
            {
                return BrojKartice;
            }
            set
            {
                BrojKartice = value;
            }
        }





    }
}
