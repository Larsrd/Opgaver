using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg11Terning2
{
    class Terning2
    {
        public int Værdi;
        private bool snyd;

        private static Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine("["+this.Værdi+"]");
        }
        public void Ryst()
        {
            if (this.snyd == false)
                this.Værdi = rnd.Next(1, 7);
            else
                this.Værdi = 6;
        }
        public Terning2()
        {
            Værdi = 1;
            Console.Write("init. værdi: ");
            Skriv();
            snyd = false;
        }
        public Terning2(bool sn)
        {
            Værdi = 1;
            Console.Write("init. værdi: ");
            Skriv();
            snyd = sn;
        }
        public Terning2(bool sn, bool init)
        {
            Værdi = rnd.Next(1,7);
            Console.Write("init. værdi: ");
            Skriv();
            snyd = sn;
        }
    }
}
