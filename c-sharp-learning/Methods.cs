using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_learning
{
    class Methods
    {
        static void MyMethod(string fname, int age = 18)  // 18 - default value
        {
            Console.WriteLine("This just got executed");
            Console.WriteLine(fname + " Refsnes");
            Console.WriteLine(fname + " is " + age);
        }

        static int MySum(int x)  // returns int
        {
            return 5 + x;
        }

        static void MyChild(string child1, string child2, string child3)
        {
            Console.WriteLine("The yougest child is: " + child3);
        }

        // method overloading - define method twice with different parameters
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }


        static void Main2(string[] args)  // void - returns nothing
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Tom");
            Console.WriteLine(MySum(99));
            MyChild(child3: "John", child1: "Liam", child2: "Liam");
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int:" + myNum1);
            Console.WriteLine("Double: " + myNum2);

        }
    }
}
