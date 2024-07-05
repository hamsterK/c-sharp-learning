using System;
using System.Globalization;

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

            Console.WriteLine(x < 5 && z < 10);  // Logical and
            Console.WriteLine(x < 5 || x < 4);  // Logical or
            Console.WriteLine(!(x < 5));  // Logical not

            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));  // square root of x
            Console.WriteLine(Math.Abs(-4.7));  // obsolete (positive) value
            Console.WriteLine(Math.Round(9.99));

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            string name2 = string.Concat(firstName, lastName);  // second option
            Console.WriteLine(name[0]);
            int charPos = name.IndexOf("D");

            string lastNameSubstring = name.Substring(charPos);

            string txtEscape = "We are the so-called \"Vikings\" from the north.";  // backlash escape character




        }
    }
}
// single-line comment

/* multi-line
 * comment */
