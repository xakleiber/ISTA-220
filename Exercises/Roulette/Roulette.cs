using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" };
            string guess;
            int attempts = 0;
            int bet;
            int money = 1500;
            while (money != 0)
            {
                Console.WriteLine("Money:$" + money + "                  Attempts: " + attempts);
                Console.WriteLine("Type in any off the following letters below:");
                Console.WriteLine("even    odd    1-18    19-36");
                Console.WriteLine("red     black  first dozen    second dozen");
                Console.WriteLine("third dozen");
                guess = (Console.ReadLine());
                guess.ToLower();
                bool check = guess == "even" || guess == "odd" || guess == "1-18" || guess == "19-36" || guess == "red" || guess == "black" || guess == "first dozen" || guess == "second dozen" || guess == "third dozen";
                if (check == false)
                {
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    bet:
                    Console.WriteLine("Enter an amount to bet");
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > money)
                    {
                        Console.WriteLine("You dont have enough money!");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadKey();
                        goto bet;
                    }
                    else
                    {
                        money -= bet;
                        int roll = ran.Next(0, 37);
                        string ranColor = color[r.Next(color.Length)];
                        bool even = roll % 2 == 0;
                        if ((((guess == "even") && (even == true))) || (((guess == "odd") && (even == false))) || ((guess == "red") && (ranColor == "Red") || (guess == "black") && (ranColor == "Black")))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((guess == "1-18") && ((roll > 0) && (roll < 19)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((guess == "19-36") && ((roll > 18) && (roll < 37)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((guess == "first dozen") && (roll > 0 && roll < 13) || (guess == "second dozen") && (roll > 12 && roll < 25) || (guess == "third dozen") && (roll > 24 && roll < 37))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 3;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You lost! -$" + bet + "!");
                            Console.WriteLine("<Press enter to continue>");
                            attempts += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("You are out of money.");
                                Console.WriteLine("<Press enter to continue>");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                Console.Clear();
            }
        }
    }
}