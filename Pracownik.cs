using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikPracy
{
    class Pracownik
    {
        
        
        string imię;
        string nazwisko;
        string urząd;
        string adres;
        string nrtel;
        DateTime urodz = DateTime.Now;
        DateTime rozp = DateTime.Now;
        decimal stawka;
        int nr;
        

        static List<Pracownik> pracownicy = new List<Pracownik>();

        public string Imię { get => imię; set => imię = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Urząd { get => urząd; set => urząd = value; }
        public string Adres { get => adres; set => adres = value; }
        public string NrTel { get => nrtel; set => nrtel = value; }
        public DateTime Urodzony { get => urodz; set => urodz = value; }
        public DateTime Rozpoczął { get => rozp; set => rozp = value; }
        public decimal Stawka { get => stawka; set => stawka = value; }
        public int Nr { get => nr; set => nr = value; }
        

        internal static List<Pracownik> Pracownicy { get => pracownicy; set => pracownicy = value; }

        public override string ToString()
        {
            return imię + " " + nazwisko;
        }
    }
}
