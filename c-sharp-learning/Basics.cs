using System;
using System.Globalization;
using System.Linq;

namespace basic_learning
{
    class Basics
    {
        //static void Main(string[] args)
        static void Main1(string[] args)

        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(3 + 3);
            Console.Write("Hello again");
            Console.Write("!");

            // single-line comment

            /* multi-line
             * comment */

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


            x = 20;
            y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");

            }
            else if ( x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is not greater then y");

            }

            // Short Hand If...Else (Ternary Operator) => replaced if/else
            string result = (x > y) ? "x is greater" : "x is not greater";
            Console.WriteLine(result);

            int day = 4;
            switch (day)  // performance advantage (compiled faster) in comparison with if/else
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:  // runs if there was no a case with a match
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // do/while is always executed once even if the condition is false
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            /*statement 1: executed before code block, st2: defines condition for execution, st3: executed after code block
             * for (statement 1; statement 2; statement 3) */
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // nested loop == loop inside the loop == (inner + outer loop)
            for (i = 1; i <= 2; i++)
            {
                Console.WriteLine("Outer: " + i);
                for (j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);
                }
            }

            /* foreach loop: used exclusively to loop through elements in an array
             * foreach (type variableName in arrayName) */
        
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };  // new array
            /* string[] cars = new string[4];  // values to be added later
            * string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
            * string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" }; */

            // cars = new string[] {"Volvo", "BMW", "Ford"}; - to add values

            foreach (string car in cars)
            {
                Console.WriteLine(i);
            }

            // continue = skip 1 iteration and continue in next loop
            for (i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break; // or continue to continue with i = 5
                }
            }


            // loop through an array
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars2);  // sort alphabetically
            for (i = 0; i < cars2.Length; i++)
            {
                Console.WriteLine(cars2[i]);
            }

            // foreach (type variableName in arrayName) - more readab;e
            foreach (string i_car in cars2)
            {
                Console.WriteLine(i_car);
            }


            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());


            // multi-(two)-dimensional arrays
            int[,] numbersMult = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbersMult[0, 2]);  // outputs 2
            numbersMult[0, 0] = 5;
            Console.WriteLine(numbersMult[0, 0]);  // outputs 5 instead of 1
            foreach (int i_num in numbersMult)
            {
                Console.WriteLine(i_num);
            }
            /* another option
           for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            } */






        }
    }
}
