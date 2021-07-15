using System;
using System.Collections.Generic;
using System.Text;

namespace OSProject
{
    class About
    {
        public static void main()
        {
            Console.WriteLine("\nVersion 1.0.0\n");
            Console.WriteLine("Created & Copyrighted by");
            Console.WriteLine("Squirrel Computers ");
            if(Console.ReadKey().Key == ConsoleKey.Enter)
                    return;
        }
    }
}
