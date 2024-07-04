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

            int i = 5;
            int j = 6;
            Console.WriteLine(i + j);

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;

            int myInt = 10;
            Console.WriteLine(Convert.ToString(myInt));

            double myDouble = 9.78;
            int myIntNine = (int)myDouble;  // Manual (explicit) casting
            Console.WriteLine(myIntNine);  // Outputs 9

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            // int age = Console.ReadLine(); => will cause error => Cannot implicitly convert type 'string' to 'int'
            Console.WriteLine("Your age is: " + age);

        }   
    }
}
// single-line comment

/* multi-line
 * comment */
