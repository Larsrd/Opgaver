using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg08overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 4, 5));
            Console.Read();
        }
        public static int Beregn(int a, int b)
        {
            return a + b;
        }
        public static int Beregn(int a, int b, int c)
        {
            //return a + b + c;
            return Beregn(a, b) + c;
        }
        public static int Beregn(int a, int b, int c, int d)
        {
            //return a + b + c + d;
            return Beregn(a, b, c) + d;
            
        }
    }
}
