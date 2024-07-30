using System;

namespace CSharp_Code_Examples
{
	class BmiCalc
	{

        public static string[] typeOfMeasurement = { "Imperial", "Metric" };

        //Authors: Zyke Lee
        //Calculator to calculate a BMI for a given person.

        public static void run()
        {
            string givenChoice;
            int intChoice = 0;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine($"\nWelcome to the BMI Calculator.");

                for (int i = 0; i < typeOfMeasurement.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {typeOfMeasurement[i]}");
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
                if (Choices.validateRange(intChoice, typeOfMeasurement.Length, 1))
                {
                    valid = true;
                }
                else
                {
                    continue;
                }
            }

            availableMeasurements(intChoice);

        }

        public static void availableMeasurements(int validChoice)
        {
            switch (validChoice)
            {
                case 1:
                    BmiImperial.run();
                    break;
                case 2:
                    BmiMetric.run();
                    break;
                default:
                    break;
            }
        }

        public static void bmiRanges(double bmi)
        {     
            Console.WriteLine($"Your BMI is {Math.Round(bmi, 2)}");
            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi <= 24.9 && bmi >= 18.5)
            {
                Console.WriteLine("You are in a healthy range.");
            }
            else if (bmi <= 29.9 && bmi >= 25)
            {
                Console.WriteLine("You are overweight.");
            }
            else if (bmi <= 39.9 && bmi >= 30)
            {
                Console.WriteLine("You are obese.");
            }
            else
            {
                Console.WriteLine("You are severely obese.");
            }
        }
    }
}

