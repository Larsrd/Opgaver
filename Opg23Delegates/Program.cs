using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg23Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 3;
            int res = Beregner(a, b, Plus);
            Console.WriteLine(res);
            res = Beregner(a, b, Minus);
            Console.WriteLine(res);
            res = Beregner(a, b, Divider);
            Console.WriteLine(res);
            res = Beregner(a, b, Gange);
            Console.WriteLine(res);

            Console.ReadLine();
        }
        //public static int Beregner(int a, int b, Delegate)
        //{
        //    return Beregn(a, b);
        //}

        public static int Beregner(int a, int b, Beregn Metode)
        {
            return Metode(a, b);
        }
        public delegate int Beregn(int a, int b);
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a/b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
