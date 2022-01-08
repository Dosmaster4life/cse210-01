using System;

namespace ConsoleApp1
{
    //Assignment 1 Tic-Tac-Toe 
    //Author Jeffery Hatch
    class Program
    {
        static char[] ticTacToeList = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char playerTurn = 'X';
        static int counter = 0;

        static void Main(string[] args)
        {
            bool gameisRunning = true;
            while (gameisRunning)
            {

                Console.Clear();
                DrawBoard();
                checkWin();
                askInput();

            }

        }
        public static void resetGame()
        {
            counter = 0;
            ticTacToeList[0] = '1';
            ticTacToeList[1] = '2';
            ticTacToeList[2] = '3';
            ticTacToeList[3] = '4';
            ticTacToeList[4] = '5';
            ticTacToeList[5] = '6';
            ticTacToeList[6] = '7';
            ticTacToeList[7] = '8';
            ticTacToeList[8] = '9';
            Console.Clear();
            DrawBoard();


        }
        public static void checkWin()
        {
            if (counter == 9)
            {
                Console.WriteLine("\nIt's a Tie! push enter to play again.");
                String playAgain = Console.ReadLine();
                resetGame();
            }
            for (int i = 0; i < 3; i++)
            {
                if (ticTacToeList[i] == 'X')
                {
                    if (ticTacToeList[i + 3] == 'X' & ticTacToeList[i + 6] == 'X')
                    {
                        Console.WriteLine("\nX Wins! push enter to play again.");
                        String playAgain = Console.ReadLine();
                        resetGame();
                    }
                }
                if (ticTacToeList[i] == 'O')
                {
                    if (ticTacToeList[i + 3] == 'O' & ticTacToeList[i + 6] == 'O')
                    {
                        Console.WriteLine("\nO Wins! push enter to play again.");
                        String playAgain = Console.ReadLine();
                        resetGame();
                    }
                }
            }
            for (int i = 0; i < 7; i += 3)
            {
                if (ticTacToeList[i] == 'X')
                {
                    if (ticTacToeList[i + 1] == 'X' & ticTacToeList[i + 2] == 'X')
                    {
                        Console.WriteLine("\nX Wins! push enter to play again.");
                        String playAgain = Console.ReadLine();
                        resetGame();
                    }
                }
                if (ticTacToeList[i] == 'O')
                {
                    if (ticTacToeList[i + 1] == 'O' & ticTacToeList[i + 2] == 'O')
                    {
                        Console.WriteLine("\nO Wins! push enter to play again.");
                        String playAgain = Console.ReadLine();
                        resetGame();
                    }
                }


            }
            if (ticTacToeList[0] == 'X' & ticTacToeList[4] == 'X' & ticTacToeList[8] == 'X')
            {

                Console.WriteLine("\nX Wins! push enter to play again.");
                String playAgain = Console.ReadLine();
                resetGame();
            }
            if (ticTacToeList[2] == 'X' & ticTacToeList[4] == 'X' & ticTacToeList[6] == 'X')
            {

                Console.WriteLine("\nX Wins! push enter to play again.");
                String playAgain = Console.ReadLine();
                resetGame();
            }
            if (ticTacToeList[0] == 'O' & ticTacToeList[4] == 'O' & ticTacToeList[8] == 'O')
            {

                Console.WriteLine("\nO Wins! push enter to play again.");
                String playAgain = Console.ReadLine();
                resetGame();
            }
            if (ticTacToeList[2] == 'O' & ticTacToeList[4] == 'O' & ticTacToeList[6] == 'O')
            {

                Console.WriteLine("\nO Wins! push enter to play again.");
                String playAgain = Console.ReadLine();
                resetGame();
            }

        }
        public static void askInput()
        {

            bool isvalid = false;
            while (isvalid == false)
            {
                Console.WriteLine("\nPlayer " + playerTurn + " choose a square number.");

                string userInput = Console.ReadLine();



                foreach (char c in userInput)
                {

                    if (c < '1' || c > '9' | userInput.Length > 1)
                    {
                        isvalid = false;
                        Console.Clear();
                        DrawBoard();
                    }
                    else if (ticTacToeList[int.Parse(userInput) - 1] == 'X' | ticTacToeList[int.Parse(userInput) - 1] == 'O')
                    {
                        Console.Clear();
                        DrawBoard();
                    }
                    else
                    {

                        ticTacToeList[int.Parse(userInput) - 1] = playerTurn;
                        isvalid = true;


                        if (playerTurn == 'X')
                        {
                            playerTurn = 'O';
                        }
                        else if (playerTurn == 'O')
                        {
                            playerTurn = 'X';
                        }
                        counter += 1;

                    }
                }
            }
            return;
        }
        public static void DrawBoard()
        {
            for (int i = 0; i < ticTacToeList.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("\n------");
                }
                Console.Write(ticTacToeList[i]);
                Console.Write("|");

            }
        }
    }
}
