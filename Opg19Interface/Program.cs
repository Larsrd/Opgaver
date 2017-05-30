using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg19Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] iDbArray = new IDbFunktioner[2];
            IDbFunktioner nyHund = new Hund();
            IDbFunktioner nyUbåd = new Ubåd();
            //iDbArray.Concat(iDbArray);
            iDbArray[0] = new Hund();
            iDbArray[1] = new Ubåd();
            iDbArray.Concat(iDbArray);
            foreach (var item in iDbArray)
            {
                item.Gem();
            }
            Console.ReadLine();
        }
    }
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund...");
            //throw new NotImplementedException();
        }
    }
    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd...");
            //throw new NotImplementedException();
        }
    }


}

