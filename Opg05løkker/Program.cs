using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg05løkker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool indryk = false;
            bool writeAsInt = true;
            int tabelLength = 10;
            int product;
            string productString;
            if (writeAsInt)
                indryk = true;
            Console.WriteLine();
            for (int i = 1; i <= tabelLength; i++)
            {
                if (indryk==true)
                    Console.Write("\t");
                for (int j = 1; j <= tabelLength; j++)
                {
                    product = i * j;
                    productString = product.ToString();
                    if (product > 50)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    //skriv ud som tal
                    if (writeAsInt)
                        Console.Write("{0}\t", product);

                    //skriv ud som string
                    if (!writeAsInt)
                        Console.Write(productString.PadLeft(4));
                    if (j==10)
                        Console.WriteLine("\r\n");
                    {

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
