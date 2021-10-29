using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public static class Board
    {
        public static string[,] board =
        {
            {" ", " ", " " },
            {" ", " ", " " },
            {" ", " ", " " }
        };

        public static void PrintBoard()
        {

            for (int row = 0; row < 3; row++)
            {
                int element = 0;
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {board[row, element]}  |  {board[row, element + 1]}  |  {board[row, element + 2]}  ");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("-----|-----|-----");
            }
        }
    }
}
