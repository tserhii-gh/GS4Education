﻿using System;

namespace List3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivar;
            double dvar;

            ivar = 100;
            dvar = 100.0;

            Console.WriteLine("ivar => " + ivar);
            Console.WriteLine("dvar => " + dvar);
            Console.WriteLine();

            ivar = ivar / 3;
            dvar = dvar / 3.0;

            Console.WriteLine("ivar / 3 => " + ivar);
            Console.WriteLine("dvar / 3.0 => " + dvar);
            Console.ReadLine();
        }
    }
}
