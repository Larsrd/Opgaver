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
            Console.Write("Indtast navn: ");
            string navn = Console.ReadLine();
            string dummy = "dummystring";
            string dummy2 = "dummystring2";
            string efternavn = "Damgaard";
            navn = navn + " " + efternavn;
            navn = navn.ToUpper();
            Console.WriteLine("Velkommen {0}", navn);
            Console.WriteLine("Tryk 'Y' for at fortsætte");
            while (true)
            {
                ConsoleKeyInfo ki = Console.ReadKey(true);
                if (ki.Key != ConsoleKey.Y)
                    Console.WriteLine("du trykkede på {0}", ki.Key);
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}
