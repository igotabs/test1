using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class A
    {
      public  A(int i)
        {
            r = new Random(i).Next();
        }
        public int r;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var d = new A(i);
            var d1 = new A(i);
            var dd = new List<A>();
            dd.Add(d);
            dd.Add(d);
            dd.Add(d1);
            dd.Add(d1);
        }
    }
}
