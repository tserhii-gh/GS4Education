using System;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 2;
            b = 3;

            if (a < b) Console.WriteLine("a less than b");
            if (a == b)
            {
                Console.WriteLine("U will never see this");
            }
            Console.WriteLine();
            c = a - b;
            Console.WriteLine("c => -1");
            if (c >= 0) Console.WriteLine("c is not negative");
            if (c < 0) Console.WriteLine("c is negative");

            Console.WriteLine();

            c = b - a;
            Console.WriteLine("c => 1");
            if (c >= 0) Console.WriteLine("c is not negative");
            if (c < 0) Console.WriteLine("c is negative");
        }
    }
}
