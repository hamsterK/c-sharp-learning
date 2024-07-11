using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_objects
{
    class Car
    {
        //public string color = "red";  // public - access modifier - accessible for other classes
        
        // class members
        string color = "red";  // field, also can be without value
        int maxSpeed = 200;  // field
        /* static method can be accessed without creating an object of the class,
         * while public methods can only be accessed by objects. */
        public void fullThrottle()  // method
        {
            Console.WriteLine("This car is fast!");
        }
        static void Main3(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            myObj2.color = "pink";
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj1.maxSpeed);
            myObj1.fullThrottle();

        }
    }
}
