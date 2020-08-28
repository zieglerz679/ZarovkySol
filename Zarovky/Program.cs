using System;

namespace Zarovky
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zarovka kuchyn = new Zarovka() { Nazev = "kuchyn" };
            Zarovka obyvak = new Zarovka() { Nazev = "obyvak" };
            Vypinac vypinac = new Vypinac();
            vypinac.Klik += kuchyn.Akce;
            

            vypinac.Kliknuti();
            vypinac.Kliknuti();

            vypinac.Klik += obyvak.Akce;

            vypinac.Kliknuti();
            vypinac.Kliknuti();
        }
    }
}
