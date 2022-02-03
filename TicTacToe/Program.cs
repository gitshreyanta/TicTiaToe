using System;

namespace TicTacToe
{
    internal class TicTacToe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TicTacToeGame game = new TicTacToeGame();
            char[] board = game.createTicTacBoard();
            game.choosePlayerLetter();
            game.compLetter();
            game.showTicTacBoard(board);




        }
    }
}
