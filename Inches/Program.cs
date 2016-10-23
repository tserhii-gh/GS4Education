using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches
{
    class Program
    {
        static void Main(string[] args)
        {
            long inches;
            long miles;

            miles = 93000000;
            inches = miles * 5280 * 12;
            Console.WriteLine("Distance to the sun => " + inches + " inches");
        }
    }
}
