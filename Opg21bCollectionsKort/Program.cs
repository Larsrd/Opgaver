using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg21bCollectionsKort
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulær = "Spar", Værdi = 2 });
        }
        public class Kort
        {
            public string Kulør { get; set; }
            public int Værdi { get; set; }
            public override string ToString()
            {
                return this.Kulør+" "+this.Værdi;
            }
        }
        public class Bunke
        {
            private Stack<Kort> stack;

            internal void TilføjKort(Kort kort)
            {
                stack.Push(kort);
            }
        }
    }
}
