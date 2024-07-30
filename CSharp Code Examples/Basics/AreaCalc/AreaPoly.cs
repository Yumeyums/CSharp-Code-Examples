using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class AreaPoly
    {
        //Authors: Zyke Lee
        //Calculator to calculate an area for a given polygonal shape.
        public static void run(int validChoice)
        {
            double area;

            while (true)
            {
                double b, h, a;
                try
                {
                    if (validChoice == 1) //Rectangle
                    {
                        Console.Write("Rectangle Area: b * h\nb: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("h: ");
                        h = Convert.ToDouble(Console.ReadLine());

                        area = calcRectangle(b, h);
                        break;
                    }
                    if (validChoice == 2) //Triangle
                    {
                        Console.Write("Triangle Area: 1/2 * (b * h)\nb: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("h: ");
                        h = Convert.ToDouble(Console.ReadLine());

                        area = calcTriangle(b, h);
                        break;
                    }
                    if (validChoice == 3) //Trapezium
                    {
                        Console.Write("Trapezium Area: 1/2 * (a + b) * h\na: ");
                        a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("b: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("h: ");
                        h = Convert.ToDouble(Console.ReadLine());

                        area = calcTrapezium(b, h, a);
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"\nCould not convert to double! Please try again.\n");
                    continue;
                    throw;
                }
            }

            Console.WriteLine($"Area = {Math.Round(area, 2)}");
        }

        public static double calcRectangle(double b, double h)
        {
            double area = b * h;
            return area;
        }

        public static double calcTriangle(double b, double h)
        {
            double area = (b * h)/2;
            return area;
        }

        public static double calcTrapezium(double b, double h, double a)
        {
            double area = ((a+b)/2) * h;
            return area;
        }

    }
}
