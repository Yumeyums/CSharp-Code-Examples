using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class BmiMetric : BmiCalc
    {
        //Authors: Zyke Lee
        //Calculator to calculate a BMI for a given person, using Metric units.
        public static void run()
        {
            double bmi;

            while (true)
            {
                double weight, height;
                try
                {
                    Console.Write("Please enter weight in kilograms (kg): ");
                    weight = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter height in metres (m): ");
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

            bmiRanges(bmi);
        }

        private static double calcBMI(double weight, double height)
        {
            double bmi = weight / (height * height);
            return bmi;
        }
    }
}
