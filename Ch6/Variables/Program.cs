using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            string favoriteNumberText = Console.ReadLine();
            int favoriteNumber = Convert.ToInt32(favoriteNumberText);
            Console.Write(favoriteNumber + " is a great number!");
        }
    }
}
