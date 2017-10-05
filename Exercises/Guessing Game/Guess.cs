using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class HumanGuess
    {
        public static void Run()
        {
            int[] list = new int[100];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;
            }
            Random random = new Random();
            int answer = random.Next(1, list.Length);
            int input = -1;
            int start = list[0] - 1;
            int end = list.Length - 1;
            int count = 1;
            while (true)
            {
                try
                {
                    if (list[start] == list[end])
                    {
                        Console.WriteLine($"You found the anser. {answer}.");
                        break; 
                    }
                    Console.Write($"Enter a number between {list[start]} and {list[end]}: ");
                    input = int.Parse(Console.ReadLine());
                    if (input < list[start] || input > list[end])
                    {
                        Console.WriteLine("Wrong");
                    }
                    else if (input == answer)
                    {
                        Console.WriteLine($"Correct {answer}");
                        break;
                    }
                    else if (input < answer)
                    {
                        Console.WriteLine("Too low.");
                        start = Array.IndexOf(list, input) + 1;
                        count++;
                    }
                    else if (input > answer)
                    {
                        Console.WriteLine("Too high.");
                        end = Array.IndexOf(list, input) - 1;
                        count++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No letters or special characters");
                }
            }
            Console.WriteLine($"It took you {count} tries.");
        }
    }
}
