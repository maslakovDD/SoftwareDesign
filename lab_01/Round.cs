using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public static class Round
    {
        public static void Start()
        {

            Field.GetInstance().Draw();
            Round.Run();

        }
        private static bool fl = true;
        public static void Run()
        {
            bool win = false;
            do
            {
                if (Field.GetInstance().IsAllCellsSigned())
                {
                    break;
                }
                Player player = Game.GetCurrentPlayer(fl);
                bool isCorrect = true;
                do
                {
                    Console.WriteLine($"{player.Name}`s turn. Select from 1 to 9 on the game board!");
                    string input = Console.ReadKey().KeyChar.ToString();
                    Game.ClearConsole();
                    int? index = Utils.GetIntValue(input);
                    if (!(index >= 1 && index <= 9) || index == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"There is no cell '{input}' on the field.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        isCorrect = false;
                    }
                    else if (Field.GetInstance().IsCellSigned(index))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"There is no cell '{input}' on the field.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Field.GetInstance().Update(index);
                        isCorrect = true;
                    }
                    if (Game.CheckRoundWin(index))
                    {
                        win = true;
                        break;
                    }
                } while (!isCorrect);
                if(!win)
                    fl = !fl;
            } while (!win);
            Finish();
        }

        public static void Finish()
        {
            if (!Field.GetInstance().IsAllCellsSigned())
            {
                Game.GetCurrentPlayer(fl).Wins += 1;
                Game.ClearConsole();
                Console.WriteLine($"{Game.GetCurrentPlayer(fl).Name} wins round!\n");
            }
            else
            {
                Game.ClearConsole();
                Console.WriteLine($"Draw!\n");
            }
            Console.Write("Do you want to play again? (y/n): ");
            string? choice = Console.ReadLine();
            if (choice != null)
            {
                if(choice == "y")
                {
                    Field.GetInstance().Reset();
                    string sign1 = Game.GetCurrentPlayer(true).Sign;
                    string sign2 = Game.GetCurrentPlayer(false).Sign;
                    Game.GetCurrentPlayer(true).Sign = sign2;
                    Game.GetCurrentPlayer(false).Sign = sign1;
                    Console.Clear();
                    Game.ShowInfo();
                    Start();
                }
                else
                {
                    //GameFinish
                }
            }

        }
    }
}
