using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg20ICompare
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 1, Navn = "Putte" };
            hunde[3] = new Hund() { Alder = 15, Navn = "Gråskæg" };
            Array.Sort(hunde);
            Console.WriteLine("Sortering på alder:\r\n");
            foreach (var item in hunde)
                {
                Console.WriteLine("Navn: " + item.Navn + ", Alder: " + item.Alder);
            }
            Console.ReadLine();
            Array.Sort(hunde, new HundeNavneComparer());
            Console.WriteLine("Sortering på navn:\r\n");
            foreach (var item in hunde)
            {
                Console.WriteLine("Navn: " + item.Navn + ", Alder: " + item.Alder);
            }
            Console.ReadLine();


        }

        class Hund : IComparable, IComparer //: IDbFunktioner
        {
            public string Navn { get; set; }
            public int Alder { get; set; }

            public int Compare(object x, object y)
            {
                throw new NotImplementedException();
            }

            public int CompareTo(object obj)
            {
                logger.Error("Enter");
                Hund incObj = obj as Hund;
                if (this.Alder > incObj.Alder) { return 1; }
                if (this.Alder < incObj.Alder) { return -1; }
                { return 0; }
            }

            //public void Gem()
            //{
            //    Console.WriteLine("Gemmer Hund...");
            //    //throw new NotImplementedException();
            //}
        }
        public class HundeNavneComparer : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Hund hx = x as Hund;
                Hund hy = y as Hund;
                return String.Compare(hx.Navn, hy.Navn);
            }
        }

        //class Ubåd //: IDbFunktioner
        //{
        //    public int Nummer { get; set; }
        //    public double Tubine { get; set; }

        //    public void Gem()
        //    {
        //        Console.WriteLine("Gemmer Ubåd...");
        //        //throw new NotImplementedException();
        //    }
        //}
    }
}
