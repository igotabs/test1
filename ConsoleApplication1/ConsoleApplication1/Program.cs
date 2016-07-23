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

        //d_igotab
        static void Main(string[] args)
        {
            var i = 1;
            var d = new A(i);
            var d1 = new A(i);
            var dd = new List<A>();
            dd.Add(d);
            dd.Add(d1);
            foreach (var item in dd)
            {
                //commit igotab
                //com,it igotab
                Console.WriteLine(item.r);
                
                Console.WriteLine("com conf com!"+ confCommonAndPerson.master);
                Console.WriteLine("com conf pers!"+confCommonAndPerson.personal);
                Console.WriteLine("pers conf!"+ PersConf.personal);
                break;
            }
            Console.ReadKey();
        }
    }
}
