using System;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char playerLetter, computerLetter;
        public Char[] createTicTacBoard()
        {
            //Creating an array Length 10
            char[] board = new char[10];
            //Adding emtpy element 
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;


        }

        

        public char choosePlayerLetter()
        {
            Console.WriteLine("Choose X or O ");
            playerLetter = char.ToUpper(Console.ReadLine()[0]); 
            if (playerLetter.Equals('X') || playerLetter.Equals('O'))
            {
                Console.WriteLine("You have choose : " + playerLetter);
            }
            else
            {
                Console.WriteLine("Please choose either X or O");
                choosePlayerLetter();
            }
            return playerLetter;
            
        }
        public char compLetter()
        {
            if (playerLetter.Equals('X'))
            {
                computerLetter = 'O';
            }    
            else
            {
                computerLetter = 'X';
            }

            return computerLetter;
            
        }
        //TicTacToe 3X3 board
        public void  showTicTacBoard(char[] board)
        {

            Console.WriteLine(  board[1] + " | " + board[2] + " | " + board[3] );
            Console.WriteLine("---------");
            Console.WriteLine(  board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("---------");
            Console.WriteLine(  board[7] + " | " + board[8] + " | " + board[9]);

        }
    }
}
