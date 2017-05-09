using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg11Terning2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ny terning med default initialisering
            Console.WriteLine("Første terning!");
            Terning2 t1 = new Terning2();
            for (int i = 0; i < 10; i++)
            {
                t1.Ryst();
                t1.Skriv();
            }

            //ny terning som snyder i initialiseringen
            Console.WriteLine("ny terning!");
            Terning2 t2 = new Terning2(true);
            for (int i = 0; i < 10; i++)
            {
                t2.Ryst();
                t2.Skriv();
            }
            
            //ny terning som randomiserer i initialiseringen
            Console.WriteLine("ny terning!");
            Terning2 t3 = new Terning2(false,true);
            for (int i = 0; i < 10; i++)
            {
                t3.Ryst();
                t3.Skriv();
            }
            Console.Read();
        }
    }
}
