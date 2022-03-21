using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKnjizara
{
    public class Program
    {
        string ime, prezime;

        public void Unos()
        {
            Console.WriteLine("Unesi ime: ");
            ime = Console.ReadLine();

            Console.WriteLine("\nUnesi prezime: ");
            prezime = Console.ReadLine();
        }

        public void Ucitaj()
        {
            Console.Write("\nIme: " + ime);
            Console.Write("\nPrezime: " + prezime);
        }

        public static void Main(string[] args)
        {
            Iban1 iban = new Iban2();
            iban.brojIbana();

            Knjizar knjizar = new Knjizar();
            knjizar.Ime = "Darko";
            knjizar.Prezime = "Ivanović";
            knjizar.Oib = "12345678910";
            knjizar.Iban = "HR3123600005242846417";

            Console.WriteLine("Podaci o knjizaru: " + knjizar.Ime + " " + knjizar.Prezime + " " + knjizar.Oib + " " + knjizar.Iban);
            Program p = new Program();
            p.Unos();
            p.Ucitaj();
            Console.ReadLine();


            Kupac kupac = new Kupac();
            kupac.ImeKupca = "Ana";
            kupac.PrezimeKupca = "Milanić";
            kupac.BrojKarticeKupca = "12345";
            Console.WriteLine("Podaci o kupcu: " + kupac.ImeKupca + " " + kupac.PrezimeKupca + " " + kupac.BrojKarticeKupca);

            List<Knjiga> listaknjiga = new List<Knjiga>();

            for (int i = 0; i < 5; i++)
            {
                Knjiga knjiga = new Knjiga();
                Console.WriteLine("Upiši ime knjige:");
                knjiga.Naziv = Console.ReadLine();

                Console.WriteLine("Upiši tip knjige:");
                knjiga.TipKnjige = Console.ReadLine();

                listaknjiga.Add(knjiga);
            }

            foreach (var knjiga in listaknjiga)
            {
                Console.WriteLine("Naziv: " + knjiga.Naziv + "\nTip knjige: " + knjiga.TipKnjige + "\n");
            }


        }


    }
}
