using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg22Using
{
    class Program
    {
        static void Main(string[] args)
        {

            //StreamReader stream = System.IO.File.OpenText("dyrenavne.txt");
            //while (stream.Peek() != -1)
            //{
            //    string navn = stream.ReadLine();
            //    Console.WriteLine(navn);
            //}
            //stream.Close();
            //stream = null;
            //Console.ReadLine();

            //BRUG AF USING I STEDET, sparer de to sidste kald og sikrer oprydning
            using (StreamReader stream = System.IO.File.OpenText("dyrenavne.txt")) 
            { while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
            }
            Console.ReadLine();


        }
    }
}
