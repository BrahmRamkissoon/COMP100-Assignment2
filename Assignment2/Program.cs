// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 12/10/2015
// Description: COMP100 Assignment 2 Part 1
/* Write a console-based program that accepts a user's message and determines whether it is
** short enough for a social networking service that does not accept messages of more than 140
** characters. The pgroam should provide output that tells teh user if the message is accepted or
** not. [Hint: if the user's input is assigned to the variable message then message.Length will 
** provide the number of characters in the input]
((4 Marks: Functionality)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        
        static void Main ( string [] args )
        {

            string message;
            bool appContinue = true;

            Console.WriteLine("++++MsgMe Service++++");
            Console.WriteLine("Please enter your message: ");
            message = Console.ReadLine();
            while ( appContinue )
            {
                if ( message.Length <= 140 )
                {
                    Console.WriteLine("Message accepted!");
                    appContinue = false;
                    PressKey();
                }
                else
                {
                    Console.WriteLine("Message must be less than or equal to 140 Chars in length");
                    Console.WriteLine("Please try again...");
                }
            }
        }

        private static void PressKey ()
        {
            Console.WriteLine("\n Press a Key to continue...");
            Console.Read();
        }
    }
}
