using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg04strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string fuldtNavn = $"{fornavn} {efternavn}";
            Console.WriteLine("Fuldt navn: {0}", fuldtNavn);
            Console.WriteLine("Uppercase: {0}", fuldtNavn.ToUpper());
            Console.WriteLine("Lowercase: {0}", fuldtNavn.ToLower());
            string delnavn = efternavn.Substring(0, 4);
            Console.WriteLine("kort efternavn: {0}", delnavn.ToLower());
            string[] forOgEfterArray = fuldtNavn.Split(' ');

            //for
            Console.WriteLine("\r\nFor-løkke:");
            for (int i = 0; i < forOgEfterArray.Length; i++)
            {
                Console.WriteLine("forOgEfterArray-element {0}:{1}",i, forOgEfterArray[i]);
            }
            int tæller = 0;
            
            //foreach
            Console.WriteLine("\r\nForeach-løkke:");
            foreach (string x in forOgEfterArray)
            {
                Console.WriteLine("forOgEfterArray-element {0}: {1}", tæller, x);
                //Console.WriteLine("forOgEfterArray-element {0}: {1}", x.IndexOf, x);
                tæller++;
            }
            
            //Clone
            tæller = 0;
            string[] klon= (string[])forOgEfterArray.Clone();
            foreach (string x in klon)
            {
                Console.WriteLine("klon-element {0}: {1}", tæller, x);
                //Console.WriteLine("forOgEfterArray-element {0}: {1}", x.IndexOf, x);
                tæller++;
            }

            Console.ReadLine();
        }
    }
}
