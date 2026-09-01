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




        }
    }
}


