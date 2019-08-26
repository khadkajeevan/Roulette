using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8ARoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" };                        
            int bet;
            int money = 1000;
            while (money != 0)
            {
                Console.WriteLine("Welcome to Roulette Game\n");
                Console.WriteLine($"Money:${money}");
                Console.WriteLine(" ");
                Console.WriteLine("Please choose an option from following menu to bet:");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("a.Even||b.Odd||c.Low(1 to 18)||d.High(19 to 36)||e.Red||f.Black||g.1st 12||h.2nd 12||i.3rd 12");
                Console.WriteLine(" ");
                Console.WriteLine("j.Columns||k.rows||l.double rows||m.contiguous numbers||n.four contiguous numbers||q.Exit");
                string input = (Console.ReadLine());
                
                //input.ToLower();
                bool choice = input == "a" || input == "b" || input == "c" || input == "d" || input == "e" || input == "f" || input == "g" || input == "h" || input == "i"||input=="j" ||
                              input == "j";
                if (choice == false)
                {
                    Console.WriteLine("You did not enter the correct input value(even/odd)");
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
                        if ((((input == "a") && (even == true))) || (((input == "b") && (even == false))) || ((input == "e") && (ranColor == "Red") || (input == "f") && (ranColor == "Black")))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);

                            switch (roll % 3)
                            {
                                case (0):
                                    Console.WriteLine($"Third column");
                                    break;
                                case (1):
                                    Console.WriteLine($"First column");
                                    break;
                                case (2):
                                    Console.WriteLine($"Second column");
                                    break;
                            }
                              
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            Console.ReadKey();


                        }
                        else if ((input == "c") && ((roll > 0) && (roll < 19)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            switch (roll % 3)
                            {
                                case (0):
                                    Console.WriteLine($"Third column");
                                    break;
                                case (1):
                                    Console.WriteLine($"First column");
                                    break;
                                case (2):
                                    Console.WriteLine($"Second column");
                                    break;
                            }
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;                       
                            
                            Console.ReadKey();
                        }
                        else if ((input == "d") && ((roll > 18) && (roll < 37)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            switch (roll % 3)
                            {
                                case (0):
                                    Console.WriteLine($"Third column");
                                    break;
                                case (1):
                                    Console.WriteLine($"First column");
                                    break;
                                case (2):
                                    Console.WriteLine($"Second column");
                                    break;
                            }
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            Console.ReadKey();

                           
                            
                        }
                        else if ((input == "g") && (roll > 0 && roll < 13) || (input == "h") && (roll > 12 && roll < 25) || (input == "i") && (roll > 24 && roll < 37))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            switch (roll % 3)
                            {
                                case (0):
                                    Console.WriteLine($"Third column");
                                    break;
                                case (1):
                                    Console.WriteLine($"First column");
                                    break;
                                case (2):
                                    Console.WriteLine($"Second column");
                                    break;
                            }
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            
                            Console.ReadKey();
                        }
                       
                        else
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            switch (roll % 3)
                            {
                                case (0):
                                    Console.WriteLine($"Third column");
                                    break;
                                case (1):
                                    Console.WriteLine($"First column");
                                    break;
                                case (2):
                                    Console.WriteLine($"Second column");
                                    break;
                            }
                            Console.WriteLine("You lost! -$" + bet + "!");
                            Console.WriteLine("<Press enter to continue>");                            
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