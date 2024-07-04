using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(3 + 3);
            Console.Write("Hello again");
            Console.Write("!");

            const int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;
        }
    }
}
// single-line comment

/* multi-line
 * comment */
