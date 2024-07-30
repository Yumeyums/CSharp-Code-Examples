using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class AreaCalc
    {
        public static string[] shapes = { "Rectangle", "Triangle", "Trapezium", "Circle", "Ellipse" };

        //Authors: Zyke Lee
        //Calculator to calculate an area for a given 2D shape.
        public static void run()
        {
            string givenChoice;
            int intChoice = 0;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine($"\nWelcome to the 2D Shape Area Calculator, which shape would you like to calculate the area of?");
                
                for (int i = 0; i < shapes.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {shapes[i]}");
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
                if (Choices.validateRange(intChoice, shapes.Length, 1))
                {
                    valid = true;
                }
                else
                {
                    continue;
                }
            }

            availableAreas(intChoice);
        }

        public static void availableAreas(int validChoice)
        {
            switch (validChoice)
            {
                case 1:
                    AreaPoly.run(validChoice);
                    break;
                case 2:
                    AreaPoly.run(validChoice);
                    break;
                case 3:
                    AreaPoly.run(validChoice);
                    break;
                case 4:
                    AreaCirc.run(validChoice);
                    break;
                case 5:
                    AreaCirc.run(validChoice);
                    break;

                default:
                    break;
            }
        }
    }
}
