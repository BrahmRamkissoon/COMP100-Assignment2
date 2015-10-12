using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int menuSelection = 0;
            string prompt;
            double gradePointAverage = 0.0d;
            int testScore = 0;
            bool appContinue = true;


            while (menuSelection != 2)
            {
                Console.WriteLine("++++Admissions App++++");
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
                        gradePointAverage = Convert.ToDouble(prompt);
                        Console.Write("\nPlease enter your Test Score (example: 75)");
                        prompt = Console.ReadLine();
                        testScore = Convert.ToInt32(prompt);
                        admissionCheck(gradePointAverage, testScore);
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

        private static void admissionCheck ( double GPA, int testMark )
        {
            //Check admission requirements
            if ( (GPA >= 3.0 && testMark >= 60) || 
                (GPA <= 3.0 && testMark >= 80) )
            {
                Console.WriteLine("\nAccept");
            }
            else
            {
                Console.WriteLine("\nReject");
            }
        }

        private static void PressKey()
        {
            Console.WriteLine( "\n Press a Key to continue..." );
            Console.ReadKey();
        }
    }
}
