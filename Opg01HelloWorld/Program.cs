using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg01HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateTime start;
            DateTime end;
            Console.Write("Indtast navn: ");
            string navn = Console.ReadLine();
            //string dummy = "dummystring";
            //string dummy2 = "dummystring2";
            string efternavn = "Damgaard";
            navn = navn + " " + efternavn;
            navn = navn.ToUpper();
            Console.WriteLine("Velkommen {0}", navn);
            Console.WriteLine("Tryk 'Y' for at fortsætte");
            start = DateTime.Now;
            while (true)
            {
                ConsoleKeyInfo ki = Console.ReadKey(true);
                //string kistr = ki.Key.ToString;
                //if ( != ConsoleKey.Y)
                if (ki.Key != ConsoleKey.Y)
                Console.WriteLine("du trykkede på {0}", ki.Key);
                else
                    break;
            }
            end = DateTime.Now;
            Console.WriteLine("Det tog {0} at trykke rigtigt!", end-start);
            Console.ReadKey();
        }
    }
}
