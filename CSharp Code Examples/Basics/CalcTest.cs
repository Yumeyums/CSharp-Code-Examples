using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class CalcTest
    {
        //Authors: Zyke Lee
        //Testing class for the different calculators I have implemented.
        public static void run()
        {
            //BMI tests
            bmiImperialTest();
            bmiMetricTest();

            //Area tests
            areaTest();
        }


        private static void bmiImperialTest()
        {
            Console.WriteLine($"BMI = {BmiImperial.calcBMI(132, 66)}"); //Weight in pounds and height in inches respectively.
        }
        private static void bmiMetricTest()
        {
            Console.WriteLine($"BMI = {BmiMetric.calcBMI(60, 1.68)}"); //Weight in kilograms and height in metres respectively.
        }

        private static void areaTest()
        {
            //Changeable values to test individual areas.
            double b = 5;
            double h = 4;
            double a = 3;

            Console.WriteLine($"Rectangle Area:{AreaPoly.calcRectangle(b, h)}"); //Base and height
            Console.WriteLine($"Triangle Area:{AreaPoly.calcTriangle(b, h)}");
            Console.WriteLine($"Trapezium Area:{AreaPoly.calcTrapezium(b, h, a)}"); //b, height and a

            Console.WriteLine($"Circle Area:{AreaCirc.calcCircle(b)}");
            Console.WriteLine($"Ellipse Area:{AreaCirc.calcEllipse(a, b)}");
        }
    }
}
