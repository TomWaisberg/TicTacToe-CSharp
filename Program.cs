using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int stp = 0;
            var numToSymbol = new Dictionary<int, string>()
            {
                {1, "x"},
                {-1, "o"},
                {0, " "}
            };

            int[] board =
            {
                0, 0, 0,
                0, 0, 0,
                0, 0, 0
            };
            Console.WriteLine("Would you like to play against a bot?");
            string answer = Console.ReadLine();
            int choice = 0;
            Console.WriteLine($"0|1|2\n-----");
            Console.WriteLine($"3|4|5\n-----");
            Console.WriteLine($"6|7|8");
            Console.WriteLine("");

            bool secretBotMode = false;
            bool ye = false;
            if (answer == "yes")
            {
                ye = true;
            }
            if (answer == "ye")
            {
                secretBotMode = true;
            }

            while (stp < 8)
            {
                bool stpIsEven = stp % 2 == 0;
                int lKey;
                //Bot
                if ((ye && stpIsEven) || secretBotMode)
                {

                    System.Threading.Thread.Sleep(500);

                    choice = rnd.Next(0, 8);
                    while (board[choice] != 0)
                    {
                        choice = rnd.Next(0, 8);
                    }
                    lKey = choice;
                }
                //Input
                else
                {
                    lKey = int.Parse(Console.ReadLine());
                }

                if (board[lKey] == 0)
                {

                    if (stpIsEven)
                    {
                        board[lKey] = 1;
                    }
                    else
                    {
                        board[lKey] = -1;
                    }
                }
                else
                {
                    Console.WriteLine("The spot is already taken! try again");
                    continue;
                }

                //Print board
                Console.WriteLine("");
                Console.WriteLine($"{numToSymbol[board[0]]}|{numToSymbol[board[1]]}|{numToSymbol[board[2]]}\n-----");
                Console.WriteLine($"{numToSymbol[board[3]]}|{numToSymbol[board[4]]}|{numToSymbol[board[5]]}\n-----");
                Console.WriteLine($"{numToSymbol[board[6]]}|{numToSymbol[board[7]]}|{numToSymbol[board[8]]}");
                Console.WriteLine("");

                //Logic
                if (board[0] + board[1] + board[2] == 3 || board[0] + board[1] + board[2] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                else if (board[3] + board[4] + board[5] == 3 || board[3] + board[4] + board[5] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                else if (board[6] + board[7] + board[8] == 3 || board[6] + board[7] + board[8] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                else if (board[0] + board[3] + board[6] == 3 || board[0] + board[3] + board[6] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                else if (board[1] + board[4] + board[7] == 3 || board[1] + board[4] + board[7] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                else if (board[2] + board[5] + board[8] == 3 || board[2] + board[5] + board[8] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                else if (board[0] + board[4] + board[8] == 3 || board[0] + board[4] + board[8] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                else if (board[2] + board[4] + board[6] == 3 || board[2] + board[4] + board[6] == -3)
                {
                    if (stpIsEven)
                    {
                        Console.WriteLine("Game ended, x has won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Game ended, o has won!");
                        break;
                    }
                }
                stp++;
            }
            if (stp == 8)
            {
                Console.WriteLine("Tie");
            }

            Console.ReadLine();
        }

    }
}
