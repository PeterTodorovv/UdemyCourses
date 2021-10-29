using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Player
    {
        public string sign;
        public Player(string Sign)
        {
            this.sign = Sign;
        }

        public void Move(string input)
        {
            while (true)
            {
                int position;
                if (!int.TryParse(input, out position))
                {
                    while (!int.TryParse(input, out position))
                    {
                        Console.WriteLine("Please enter a number");
                        input = Console.ReadLine();
                    }
                }

                position = int.Parse(input);
                int[] cordinates = new int[2] { 0, 0 };

                if (position > 9 || position < 1)
                {
                    Console.WriteLine("Number is not on the board. Try again.");
                    input = Console.ReadLine();
                    continue;
                }
                switch (position)
                {
                    case 1:
                        cordinates = new int[] { 0, 0 };
                        break;
                    case 2:
                        cordinates = new int[] { 0, 1 };
                        break;
                    case 3:
                        cordinates = new int[] { 0, 2 };
                        break;
                    case 4:
                        cordinates = new int[] { 1, 0 };
                        break;
                    case 5:
                        cordinates = new int[] { 1, 1 };
                        break;
                    case 6:
                        cordinates = new int[] { 1, 2 };
                        break;
                    case 7:
                        cordinates = new int[] { 2, 0 };
                        break;
                    case 8:
                        cordinates = new int[] { 2, 1 };
                        break;
                    case 9:
                        cordinates = new int[] { 2, 2 };
                        break;
                }

                if (Board.board[cordinates[0], cordinates[1]] == " ")
                {
                    Board.board[cordinates[0], cordinates[1]] = sign;
                    break;
                }
                Console.WriteLine("Please enter a free position.");
                input = Console.ReadLine();
            }
        }
    }
}
