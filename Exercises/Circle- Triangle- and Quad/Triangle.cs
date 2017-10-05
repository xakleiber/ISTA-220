using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This finds the area of a triangle.");
            double a = GetInput("a");
            double b = GetInput("b");
            double c = GetInput("c");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (area > 0)
                Console.WriteLine($"The area of the triangle is {area:#.####}");
            else
                Console.WriteLine("A triangle like that doesn't exist.");
        }

        private static double GetInput(string s)
        {
            double value;
            do
            {
                Console.Write($"Enter side length {s}. ");
                try
                {
                    value = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Use Numbers!.");
                    value = -1;
                }
            }
            while (value <= 0);
            return value;
        }
    }
}