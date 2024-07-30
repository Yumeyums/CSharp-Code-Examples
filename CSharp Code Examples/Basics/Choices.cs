using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class Choices
    {
        //Authors: Zyke Lee
        //Choice class to centralise user choices to navigate to different calculator classes, including BmiCalc, AreaVolCalc, and the Maths class.

        //If more calculators were to be added, they could be added here.
        public static string[] calculators = { "Area", "BMI", "Maths (Pythagoras and Law of Cosines)" };
        public static void run()
        {
            string givenChoice;
            int intChoice = 0;
            bool valid = false;

            Console.WriteLine("Welcome to the Calculator options!");

            while (!valid)
            {
                Console.WriteLine("Which Calculator would you like to choose?:");
                for (int i = 0; i < calculators.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {calculators[i]}");
                }
                Console.Write("Please enter the associating integer value next to the given choice: ");
                givenChoice = Console.ReadLine();


                //Validate converting type to only accept an integer choice.
                try
                {
                    intChoice = Convert.ToInt32(givenChoice);

                }
                catch (Exception)
                {
                    Console.WriteLine($"\nCould not convert '{givenChoice}' to integer, please input a valid number to choose from!\n");
                    continue;
                    throw;
                }


                //Validate given range, if true, move to available choices.
                if (validateRange(intChoice, calculators.Length, 1))
                {
                    valid = true;
                }
                else
                {
                    continue;
                }

            }

            availableChoices(intChoice); //Jumps to the availableChoices method when all processes are completed.
        }

        public static bool validateRange(int integerTarget, int maxValue, int minValue)
        {
            //Checks if the integer passed  is within the range of the max and min values.
            if (integerTarget <= maxValue && integerTarget >= minValue)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"\n{integerTarget} is not within the range of the available choices\nPlease pick a number between 1 and {maxValue}.\n");
                return false;
            }
        }
        
        private static void availableChoices(int validChoice)
        {
            //Console.WriteLine($"{validChoice}"); //Testing to see if what only makes it here is an integer.

            switch (validChoice)
            {

                //Go to calculate Area
                case 1:
                    AreaCalc.run();
                    break;
                case 2:
                    BmiCalc.run();
                    break;
                case 3:
                    Maths.run();
                    break;

                default:
                    break;
            }
        }
        
    }
}
