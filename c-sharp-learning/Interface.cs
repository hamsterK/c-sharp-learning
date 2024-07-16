using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_learning
{
    /* An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
    It is considered good practice to start with the letter "I" at the beginning of an interface
    By default - abstract and public */
    interface IAnimal
    {
        void animalSound();
    }

    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Text 1");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Text 2");
        }
    }


    class Program
    {
        static void Main10(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();

            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
