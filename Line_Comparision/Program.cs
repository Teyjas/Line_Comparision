
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
            double x1, x2, y1, y2, a1, a2, b1, b2;
            double length1 = 0;
            double length2 = 0;
            Console.WriteLine("Enter point 1 (x1,y1): ");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter point 2 (x2,y2): ");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("The Distance between two points are:" + length1);
            Console.WriteLine("Enter point 1 (a1,b1): ");
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter point 2 (a2,b2): ");
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());
            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)));
            Console.WriteLine("The Distance between two points are:" + length2);
            if (length1 == length2)
            {
                Console.WriteLine("Two Lines are Equal");
            }
            else
            {
                Console.WriteLine("Two Lines are not Equal");
            }
        }
    }
}