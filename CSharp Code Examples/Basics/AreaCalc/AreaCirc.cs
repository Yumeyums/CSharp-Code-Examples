using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class AreaCirc
    {
        //Authors: Zyke Lee
        //Calculator to calculate an area for a given circular shape.
        public static void run(int validChoice)
        {
            double area;

            while (true)
            {
                double r, a, b;
                try
                {
                    if (validChoice == 4) //Circle
                    {
                        Console.Write("Circle Area: π * (r*r)\nr: ");
                        r = Convert.ToDouble(Console.ReadLine());

                        area = calcCircle(r);
                        break;
                    }
                    if (validChoice == 5) //Ellipse
                    {
                        Console.Write("Triangle Area: 1/2 * (b * h)\na: ");
                        a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("b: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        area = calcEllipse(a, b);
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
        public static double calcCircle(double r)
        {
            double area = Math.PI * (r * r);
            return area;
        }
        public static double calcEllipse(double a, double b)
        {
            double area = Math.PI * (a * b);
            return area;
        }
    }
}
