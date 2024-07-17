using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_learning
{ 

    class Program
{
    // An enum is a special "class" that represents a group of constants (unchangeable/read-only variables)
    enum Level
    {
        Low,
        Medium,
        High
    }

    static void Main11(string[] args)
    {
        Level myVar = Level.Medium;
        switch (myVar)
        {
            case Level.Low:
                Console.WriteLine("Low level");
                break;
            case Level.Medium:
                Console.WriteLine("Medium level");
                break;
            case Level.High:
                Console.WriteLine("High level");
                break;
        }
    }
}
}