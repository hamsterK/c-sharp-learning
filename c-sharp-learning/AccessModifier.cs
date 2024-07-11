using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modifiers_learning
{
    /* public - accessible for all classes
     * "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.
     * This is done by declaring fields as private.
     * By default, all members of the class are private
     * 
     * private - accessible within the same class only
     * protected - accessible within the same class ir class that is inherited from it
     * internal - accessible within its own assembly only */

    class Car
    {
        public string model = "Mustang";
    }

    class Program
    {
        static void Main5(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}
