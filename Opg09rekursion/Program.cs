using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            RekursPrint(1, 10);
            Console.Read();
        }
        public static void RekursPrint(int i, int max)
        {
            if (i <= max)
            {
                Console.WriteLine(i);
                i++;
                RekursPrint(i, max);
            }
        }
    }
}
