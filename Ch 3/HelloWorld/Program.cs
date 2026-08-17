using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string name;

            Console.WriteLine("Bread is ready. \n Who is the bread for?");
            name = Console.ReadLine();
            Console.WriteLine("Noted: " + name + " got bread.");
        }
    }
}
