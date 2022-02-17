
using System;

using System.Collections.Generic;

namespace UC1_Cartesian
{
    class LineComparison
    {
        public static void Main(string[] args)
        {
            LineComparison.getCartesian();
        }
        static void getCartesian()
        {
            double x1, x2, y1, y2;
            double length = 0;
            Console.WriteLine("Enter point 1 (x1,y1): ");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter point 2 (x2,y2): ");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("The Distance between two points are:" + length);
        }
    }
}