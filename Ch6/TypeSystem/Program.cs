using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TypeSystem
{
    internal class Program
    {
        static void Main()
        {
            byte myByte = 255;
            short myShort = 32_767;
            int myInt = 2_147_483_647;
            long myLong = 9_223_372_036_854_775_807;
            sbyte mySByte = 127;
            ushort myUShort = 127;
            uint myUint = 4_294_967_295;
            ulong myULong = 18_446_744_073_709_551_615;

            Console.WriteLine("The values below represent the positive maximums of the 8 types.");
            Console.WriteLine("myByte = " + myByte + "\n" + "myShort = " + myShort + "\n");
            Console.WriteLine("myInt = " + myInt + "\n" + "myLong = " + myLong + "\n");
            Console.WriteLine("mySByte = " + mySByte + "\n" + "myShort = " + myUShort + "\n");
            Console.WriteLine("myUint = " + myUint + "\n" + "myULong= " + myULong + "\n\n");

            int thirteenInputAsBinary = 0b00001101;
            int theColorMagenta = 0xFF00FF;

            Console.WriteLine("0b00001101 is equal to int " + thirteenInputAsBinary + "\n");
            Console.WriteLine("0xFF00FF is hexidecimal representation of magenta and is the int " + theColorMagenta + "\n");

            char myLetter = 'a'; // "\u0061" in hexadecimal
            string myString = "Hello, World.";
            Console.WriteLine("My char is \'" + myLetter + "\' and my string is " + myString + "\n");

            // floats have about 7 digits of precision, so may not distinguish 100_000 from 100_000.0001
            // doubles have 15-16 digits of precision
            // unlike floats and doubles, decimal types are not intrinsic to the hardware design and therefore slower. However, 
            // they are more precise when dealiing with very small or very large numbers (think system of equations in biology or chemistry)

            double myDouble = 3.5623123456789;
            float myFloat = 3.5623123456789f;
            decimal myDecimal = 3.5623123456789m; // the 'm' is for 'monetary'
            double avogadro = 2.022e23;

            Console.WriteLine("myDdouble = " + myDouble);
            Console.WriteLine("myFloat = " + myFloat); // will show 7 decimal places
            Console.WriteLine("myDecimal = " + myDecimal);
            Console.WriteLine("avogadro = " + avogadro);

            bool myBool = true;
            Console.WriteLine("myBool + 1 = " + myBool + 1 + " which is just concatenation.");
            Console.WriteLine("Numeric value of true is " + myBool);
        }
    }
}


