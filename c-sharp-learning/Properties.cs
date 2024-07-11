using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_learning_encapsulation
{
    class Person
    {
        private string name;  // field
        public string Name // property to allow access to other methods
        {
            get { return name; } // public get method
            set { name = value; }  // public set method
        }
    }

    // Automatic properties (short hand) - same as above
    class PersonShort
    {
        public string Name  // property
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            // short-hand version
            PersonShort myObj2 = new PersonShort();
            myObj2.Name = "Tom";
            Console.WriteLine(myObj2.Name);
        }
    }
}


