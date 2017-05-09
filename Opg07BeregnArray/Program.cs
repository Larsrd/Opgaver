using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            Console.Write("usorteret: ");
            foreach (var item in test) { Console.Write(item + " "); };
            Console.WriteLine();
            var res = BeregnOgSorterArray(ref test);
            Console.Write("sorteret: ");
            foreach (var item in test) { Console.Write(item + " "); };
            Console.WriteLine();
            Console.WriteLine("sum: "+res.sum);
            Console.WriteLine("gennemsnit: "+res.gennemsnit);
            Console.Read();
        }
        public static ArrayResultat BeregnOgSorterArray(ref int[] myarr)
        {
            ArrayResultat result;
            result.sum = myarr.Sum();
            result.gennemsnit = myarr.Average();
            Array.Sort(myarr);
            return result;
        }

        public struct ArrayResultat
        {
            public int sum;
            public double gennemsnit;
        }
    }
}
