// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 12/10/2015
// Description:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main ( string [] args )
        {
            int menuSelection = 0;
            string prompt;
            double hourlyPayRate;
            double hoursWorked;
            double grossPay;
            int withHoldingTax;
            double netPay;

            int testScore = 0;



            while ( menuSelection != 2 )
            {
                Console.WriteLine("++++Withholding Tax App++++");
                Console.WriteLine("1. Enter GPA & Test Score");
                Console.WriteLine("2. Exit");
                Console.Write("Please select an option: ");

                prompt = Console.ReadLine();
                menuSelection = Convert.ToInt32(prompt);

                // Give menu selection and user enters GPA, Test score
                switch ( menuSelection )
                {
                    case 1:
                        Console.Write("\nPlease enter your GPA (example: 3.5): ");
                        prompt = Console.ReadLine();
                        hourlyPayRate = Convert.ToDouble(prompt);
                        Console.Write("\nPlease enter your Test Score (example: 75)");
                        prompt = Console.ReadLine();
                        testScore = Convert.ToInt32(prompt);
                        admissionCheck(hourlyPayRate, testScore);
                        PressKey();
                        break;
                    case 2:
                        Console.WriteLine("\nGoodBye!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nPlease select 1 or 2\n");
                        break;
                }
            }
        }
    }
    }
}
