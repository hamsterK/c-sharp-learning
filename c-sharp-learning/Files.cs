using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace files_learning
{
    class Program
    {
        static void Main12(string[] args)
        {
            string writeText = "Hello there!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
        }
    }
}