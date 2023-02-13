using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public sealed class Field
    {
        private Cell[,] cells = new Cell[3, 3];
        private Field() {
            int n = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j] = new Cell();
                    cells[i, j].Text = n.ToString();
                    cells[i, j].Id = n;
                    n++;
                }
            }
        }

        private static Field? _instance;

        public static Field GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Field();
            }
            return _instance;
        }
        public void Draw()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(j==0)
                        Console.Write($" {this.cells[i,j].Text,2} ");
                    else 
                        Console.Write($" {this.cells[i, j].Text} ");

                    if (j != 2)
                        Console.Write("|");
                }
                Console.WriteLine();
                if (i != 2)
                    Console.WriteLine($"{"",1}---+---+---");
            }
            Console.WriteLine();
        }

        public void Update(int? index)
        {
            if (index != null)
            {
                for (int i = 0; i < this.cells.GetLength(0); i++)
                {
                    for (int j = 0; j < this.cells.GetLength(1); j++)
                    {
                        if (this.cells[i, j].Id == index)
                        {
                            this.cells[i, j].Text = Game.GetCurrentSign();
                            this.cells[i, j].Singed = true;

                        }
                    }

                }
                Game.ClearConsole();
            }
        }
        public Cell[,] GetCells()
        {
            return cells;
        }

        public void Reset()
        {
            _instance = new Field();
        }
        public bool IsAllCellsSigned()
        {
            for(int i =0; i < this.cells.GetLength(0); i++)
            {
                for(int j = 0; j < this.cells.GetLength(1); j++)
                {
                    if (!this.cells[i, j].Singed)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsCellSigned(int? index)
        {
            if(index!= null)
            {
                for (int i = 0; i < this.cells.GetLength(0); i++)
                {
                    for (int j = 0; j < this.cells.GetLength(1); j++)
                    {
                       if(index == 3 * i + j + 1)
                       {
                            return cells[i, j].Singed;
                       }
                    }
                }
            }
            return false;
        }
    }
}
