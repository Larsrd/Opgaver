using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            Console.WriteLine("t1 =" +t1.Værdi);
            Terning t2 = new Terning();
            Console.WriteLine("t2 =" + t2.Værdi);

            Console.WriteLine("t2 sættes lig t1");
            t2 = t1;
            Console.WriteLine("t1 =" + t1.Værdi);
            Console.WriteLine("t2 =" + t2.Værdi);

            Console.WriteLine("t1 sættes til 5");
            t1 = new Terning(5);
            Console.WriteLine("t1 =" + t1.Værdi);
            Console.WriteLine("t2 =" + t2.Værdi);

            Console.WriteLine("t2 sættes til 6");
            t2 = new Terning(6);
            Console.WriteLine("t1 =" + t1.Værdi);
            Console.WriteLine("t2 =" + t2.Værdi);

            Console.Read();
        }
    }
}
