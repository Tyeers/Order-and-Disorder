using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_and_Disorder
{
    internal class Preparation : Order_and_Disorder
    {
        public void R()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("     Ready?");
            Console.WriteLine();
            Console.Write(" 3");
            Thread.Sleep(1000);
            Console.Write(" 2");
            Thread.Sleep(1000);
            Console.WriteLine(" 1");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
        }
    }
}
