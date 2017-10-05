using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter # of test scores. ");
            int v = int.Parse(Console.ReadLine());
            if (v >= 0)
            {
                float score, sum = 0, avg = 0; int g;
                for (g = 1; g <= v; g++)
                {
                    Console.WriteLine("Enter #{0} Test Score:  ", g);
                    score = float.Parse(Console.ReadLine());
                    sum = sum + score;
                }

                avg = sum / (g - 1);
                Console.WriteLine("Average of Test Scores: " + avg);
                if (avg >= 90)
                    Console.WriteLine("Grade: A");
                else if (avg >= 80 && avg <= 89)
                    Console.WriteLine("Grade: B");
                else if (avg >= 70 && avg <= 79)
                    Console.WriteLine("Grade: C");
                else if (avg >= 60 && avg <= 69)
                    Console.WriteLine("Grade: D");
                else
                    Console.WriteLine("Grade: F");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not a valid input");
            }

        }
    }
}
