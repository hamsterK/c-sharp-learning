using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_learning
{
    class Car
    {
        public string model;  // create a field
        public string color;
        public int year;
        // create class constructor for Car class
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main4(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);  // create object of Car class
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }

    }
}
