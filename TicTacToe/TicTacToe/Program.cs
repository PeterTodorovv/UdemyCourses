using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("X");
            Player player2 = new Player("O");
            Board.PrintBoard();
            while (true)
            {
                
                player1.Move(Console.ReadLine());
                Board.PrintBoard();
                if (endGame(Board.board))
                {
                    Console.WriteLine($"Player X won!");
                    Console.WriteLine("Play again? y/n");
                    if(!playAgain(Console.ReadLine()))
                        break;
                    continue;
                }
                if (draw(Board.board))
                {
                    Console.WriteLine("It's a draw.");
                    Console.WriteLine("Play again? y/n");
                    if (!playAgain(Console.ReadLine())) { 
                        break;}
                    continue;
                }
                player2.Move(Console.ReadLine());
                Board.PrintBoard();
                if (endGame(Board.board))
                {
                    Console.WriteLine($"Player O won!");
                    Console.WriteLine("Play again? y/n");
                    if (!playAgain(Console.ReadLine()))
                        break;
                }
                if (draw(Board.board))
                {
                    Console.WriteLine("It's a draw.");
                    Console.WriteLine("Play again? y/n");
                    if (!playAgain(Console.ReadLine()))
                        break;
                }

            }
            
        }

        static bool endGame(string[,] board)
        {
            if((board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != " ") ||
                (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != " ") ||
                (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != " ") ||

                (board[0, 0] == board[1, 0] && board[2, 0] == board[1, 0] && board[2, 0] != " ") ||
                (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] != " ") ||
                (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != " ") ||

                (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != " ") ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] != " "))
            {
                return true;
            }
            return false;
        }

        static bool draw(string[,] board)
        {
            int whiteSpaces = 0;
            foreach(var element in board)
            {
                if (element == " ") whiteSpaces++;
            }

            if (whiteSpaces == 0) return true;
            return false;
        }

        static bool playAgain(string answer)
        {
            if(answer == "y")
            {
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        Board.board[i, j] = " ";
                    }
                }
                Board.PrintBoard();
                return true;
            }
            else if(answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }
    }
}
