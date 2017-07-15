using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Oops
{
   public class Program: OverrideConcept_Csharp.CsharpConcepts
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            //p.myMethod();
            p.test();



            Console.ReadKey();
        }

        public override void myMethod()
        {
            Console.WriteLine("My method in Program Class File");
        }

        public new void test()
        {
            base.test();
            Console.WriteLine("this is test method in Programs calss");
        }
    }
}
