using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14bProperties4
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning(3);
            Console.WriteLine("Efter init: ");
            t1.Skriv();
            Console.WriteLine("Der rystes: ");
            for (int i = 0; i < 10; i++)
            {
                t1.Ryst();
                t1.Skriv();
            }
            Console.ReadLine();
        }
    }
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get { Console.WriteLine("værdi aflæses: " + værdi); return værdi; }
            set { if (værdi < 1 || værdi > 6) value = 1; værdi = value; Console.WriteLine("værdi sættes til " + value); }
        }
        public Terning(int v)
        {
            Værdi = v;
        }
        private static Random rnd = new Random();
        public void Ryst()
        {
            Værdi = rnd.Next(1, 6);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + Værdi + "]");
        }

    }
}
