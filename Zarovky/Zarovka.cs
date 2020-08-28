using System;
using System.Collections.Generic;
using System.Text;

namespace Zarovky
{
    //delegate void MenicStavu();

    class Zarovka
    {
        public string Nazev { get; set; }

        private bool stav;

        public void Akce(object sender, KlikEventArgs args)
        {
            Console.WriteLine(args.Data);
            if(stav)
            { 
                Console.WriteLine("Zarovka " + Nazev + " zhasla"); 
            }
            else
            {
                Console.WriteLine("Zarovka " + Nazev + " sviti");
            }
            stav = !stav;
        }
    }
}
