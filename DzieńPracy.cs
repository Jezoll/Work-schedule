using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikPracy
{
    class DzieńPracy
    {
        public DateTime Data = DateTime.Today;
        public decimal Liczba_godzin;
        public decimal Zaplanowane_godziny;
        public decimal Przepracowane_godziny;
        public Pracownik pracownik;

        public static List<DzieńPracy> DniPracy = new List<DzieńPracy>();

        public DateTime data { get => Data; set => Data = value; }
        public decimal zaplanowane_godziny { get => Zaplanowane_godziny; set => Zaplanowane_godziny = value; }
        public decimal liczba_godzin { get => Liczba_godzin; set => Liczba_godzin = value; }
        public decimal przepracowane_godziny { get => Przepracowane_godziny; set => Przepracowane_godziny = value; }
        public Pracownik Pracownik { get => pracownik; set => pracownik = value; }
    }
}
    
 