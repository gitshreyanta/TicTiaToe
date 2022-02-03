using System;

namespace TicTacToe
{
    class TicTacToe1
    {
        public Char[] createTicTacBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;


        }

    }
}
