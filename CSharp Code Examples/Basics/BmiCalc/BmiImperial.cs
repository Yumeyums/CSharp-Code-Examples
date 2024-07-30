using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
	class BmiImperial : BmiCalc
	{
        
        //Authors: Zyke Lee
        //Calculator to calculate a BMI for a given person, using Imperial Units.
        public static void run()
        {
            double bmi;

            while (true)
            {
                double weight, height;
                try
                {
                    Console.Write("Please enter weight in pounds (lbs): ");
                    weight = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter height in inches (in): ");
                    height = Convert.ToDouble(Console.ReadLine());

                    bmi = calcBMI(weight, height);
                    break;

                }
                catch (Exception)
                {
                    Console.WriteLine($"\nCould not convert to double! Please try again.\n");
                    continue;
                    throw;
                }
            }

            //Uses method from parent class
            bmiRanges(bmi);
        }

        public static double calcBMI(double weight, double height)
        {
            double bmi = 703 * (weight / (height * height));
            return bmi;
        }
    }
}
