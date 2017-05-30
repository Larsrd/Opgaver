using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg17Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Der er sket en fejl - 1. tal eller 2. tal har formodentlig ikke rigtigt format: ");
                Console.WriteLine("Message: "+ex.Message);
                Console.WriteLine("InnerMessage: "+ex.InnerException);
            }
            Console.ReadLine();
        }
        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
            Console.ReadLine();

        }
    }
}
