using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_learning
{
    class Methods
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine("This just got executed");
            Console.WriteLine(fname + " Refsnes");
            Console.WriteLine(fname + " is " + age);
        }

        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
        }
    }
}
