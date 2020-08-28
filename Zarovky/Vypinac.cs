using System;
using System.Collections.Generic;
using System.Text;

namespace Zarovky
{
    class Vypinac
    {
        public event EventHandler<KlikEventArgs> Klik;


        public void Kliknuti()
        {
            Klik?.Invoke(this, new KlikEventArgs() { Data = "123456"});
        }

        //public void NastavMenic(Action menic)
        //{
        //    this.menic += menic;
        //}
    }
}
