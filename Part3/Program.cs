// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 12/10/2015
// Description: Assignment 2 Part 3
/* Write a console-based program that prompts the user for an hourly pay rate and hours wroked.
** Compute gross pay ( hours times pay rate), withholding tax, and net pay ( gross pay minus
** withholding tax). Withholding tax is computed as a percentage of gross pay based on the following
**              Gross Pay                       Withholding Percentage
**              Up to and including 300.00      10%
**              More than 300.00                12%
** (7 Marks: Functionality)
*/
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


            // Give menu selection and user enters hourly pay rate and hours worked
            while ( menuSelection != 2 )
            {
                Console.WriteLine("++++Withholding Tax App++++");
                Console.WriteLine("1. Compute Withholding Tax");
                Console.WriteLine("2. Exit");
                Console.Write("Please select an option: ");

                prompt = Console.ReadLine();
                menuSelection = Convert.ToInt32(prompt);

                
                switch ( menuSelection )
                {
                    case 1:
                        Console.Write("\nPlease enter an hourly pay rate (example: 15.25): ");
                        prompt = Console.ReadLine();
                        hourlyPayRate = Convert.ToDouble(prompt);
                        Console.Write("\nPlease enter number of hours worked (example: 35.5)");
                        prompt = Console.ReadLine();
                        hoursWorked = Convert.ToInt32(prompt);

                        CalcWithholdingTax(hourlyPayRate, hoursWorked);
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
        public static void CalcWithholdingTax ( double hourlyRate, double clockedHours )
        {
            double grossPay;
            double netPay;
            double percentWithholdingTax = .01;
            double withHoldingTax;

            grossPay = hourlyRate * clockedHours;

            if (grossPay <= 300.0)
            {
                percentWithholdingTax *= 10;
                withHoldingTax = grossPay * percentWithholdingTax;
                netPay = grossPay - withHoldingTax;
                Console.WriteLine( netPay );
                
            }
            else
            {
                percentWithholdingTax *= 12;
                withHoldingTax = grossPay * percentWithholdingTax;
                netPay = grossPay - withHoldingTax;
                Console.WriteLine( netPay );
                ;
            }
        }

        public static void PressKey()
        {
            Console.WriteLine("\n Press a Key to continue...");
            Console.ReadKey();
        }

    }
    
}

