using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_learning
{
    abstract class Animal  // must be inherited by derived class to be used
    {
        // abstract method (does not have a body - it is provided by derived class)
        public abstract void animalSound();
        // regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // derived class
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main9(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();   
            myPig.sleep();
        }
    }
}
