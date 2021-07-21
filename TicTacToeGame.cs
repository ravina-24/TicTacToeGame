using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {

        public static void CreateBoard()
        {
            
            char[] Board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        }
        public static void AllowThePlayer()
        {
            //Allowing the user to enter the input in the form X or O
            Console.WriteLine("Enter the input  x or o ");
            char Input = char.Parse(Console.ReadLine());

            if (Input == 'x')
            {
                Console.WriteLine("Assign x to the Player " +Input  );
            }
            else
            {
                Console.WriteLine("Assign o to the computer  " + Input);
            }
            Console.ReadLine();


        }




    }
}
