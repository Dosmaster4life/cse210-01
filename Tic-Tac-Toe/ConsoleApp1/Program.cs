using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    //Assignment 1 Tic-Tac-Toe 
    //Author Jeffery Hatch
    class Program
    {
        static char[] ticTacToeList = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char playerTurn = 'X';

        static void Main(string[] args)
        {
            bool gameisRunning = true;
            while (gameisRunning)
            {
                Console.Clear();
                DrawBoard();
                askInput();
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
