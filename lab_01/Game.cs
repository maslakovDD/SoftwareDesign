using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public static class Game
    {

        private static string _currentSign;
        private static Player _player1;
        private static Player _player2;
        public static void Initialize()
        {
            Console.WriteLine("Let`s play Tic Tac Toe!\n");
            Console.Write("Player 1: ");
            _player1 = new Player("Player 1", Console.ReadLine());
            _currentSign = _player1.Sign;
            Console.Write("Player 2: ");
            _player2 = new Player("Player 2", Console.ReadLine());
            Console.Clear();
        }
        
        public static void Run()
        {
            ShowInfo();
            Round.Start();
        }

        public static void Finish()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGame over!");
            Console.ForegroundColor = ConsoleColor.Green;
            if (_player1.Wins > _player2.Wins)
            {
                Console.WriteLine("Player 1 wins game!");
            }
            else if(_player1.Wins > _player2.Wins)
            {
                Console.WriteLine("Player 2 wins game!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string GetCurrentSign()
        {
            return _currentSign;
        }

        public static void ShowInfo()
        {
            Console.WriteLine($" {"Player 1",2}({_player1.Sign})  {"Player 2",2}({_player2.Sign})");
            Console.WriteLine($" {_player1.Wins,6}  {_player2.Wins,11}");

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ClearConsole()
        {
            Console.Clear();
            Game.ShowInfo();
            Field.GetInstance().Draw();
        }
        public static Player GetCurrentPlayer(bool? fl)
        {
            if (fl == true)
            {
                _currentSign = _player1.Sign;
                return _player1;
            }
            else if(fl == false)
            {
                _currentSign = _player2.Sign;
                return _player2;
            }
            else
            {
                _currentSign = _player1.Sign;
                return _player1;
            }
        }
        public static bool CheckRoundWin(int? index)
        {
            if (index != null)
            {
                Cell[,] cells = Field.GetInstance().GetCells();
                int count = 0;
                for(int i =0; i<cells.GetLength(0); i++)
                {
                    for(int j =0; j<cells.GetLength(1); j++)
                    {
                        if (cells[i,j].Text == Game.GetCurrentSign())
                        {
                            count++;
                        }
                    }
                    if (count == 3)
                    {
                        return true;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                count = 0;
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    for (int j = 0; j < cells.GetLength(1); j++)
                    {
                        if (cells[j, i].Text == Game.GetCurrentSign())
                        {
                            count++;
                        }
                    }
                    if (count == 3)
                    {
                        return true;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                count = 0;
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    for (int j = 0; j < cells.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            if (cells[j, i].Text == Game.GetCurrentSign())
                            {
                                count++;
                            }
                        }
                    }  
                }
                if (count == 3)
                {
                    return true;
                }
                count = 0;
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    for (int j = 0; j < cells.GetLength(1); j++)
                    {
                        if (i + j == 2)
                        {
                            if (cells[j, i].Text == Game.GetCurrentSign())
                            {
                                count++;
                            }
                        }
                    }
                  
                }
                if (count == 3)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
