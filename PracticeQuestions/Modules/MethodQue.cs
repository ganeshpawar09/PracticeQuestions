using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions.Modules
{

    internal class MethodQue
    {
        internal void CheckLeapYear()
        {
            int year;

            while (true)
            {
                Console.Write("Enter a year: ");
                if (int.TryParse(Console.ReadLine(), out year) && year > 0)
                    break;

                Console.WriteLine("Invalid input. Please enter a positive integer for the year.");
            }

            // Leap year logic
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if (isLeap)
                Console.WriteLine($"{year} is a leap year.");
            else
                Console.WriteLine($"{year} is not a leap year.");
        }

        private class ShiftOperations
        {
            private void DoRightShift(ref int x, ref int y, ref int z)
            {
                int temp = z;
                z = y;
                y = x;
                x = temp;
            }

            internal void RightShift()
            {
                int a, b, c;

                while (true)
                {
                    Console.Write("Enter number a: ");
                    if (int.TryParse(Console.ReadLine(), out a))
                        break;
                    Console.WriteLine("Invalid input.");
                }

                while (true)
                {
                    Console.Write("Enter number b: ");
                    if (int.TryParse(Console.ReadLine(), out b))
                        break;
                    Console.WriteLine("Invalid input.");
                }

                while (true)
                {
                    Console.Write("Enter number c: ");
                    if (int.TryParse(Console.ReadLine(), out c))
                        break;
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine($"\nBefore Right Shift: a = {a}, b = {b}, c = {c}");

                DoRightShift(ref a, ref b, ref c);

                Console.WriteLine($"After Right Shift:  a = {a}, b = {b}, c = {c}");
            }
        }
        private double CalculateDistance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        internal void CalculateDistance()
        {
            (double x1, double y1) = GetCoordinate("Enter x1 y1: ");
            (double x2, double y2) = GetCoordinate("Enter x2 y2: ");

            double distance = CalculateDistance(x1, x2, y1, y2);
            Console.WriteLine($"Distance between points: {distance:F2}");
        }

        private double CalculateAreaOfTriangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            double a = CalculateDistance(x1, x2, y1, y2);
            double b = CalculateDistance(x2, x3, y2, y3);
            double c = CalculateDistance(x3, x1, y3, y1);
            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        internal void CalculateAreaOfTriangle()
        {
            (double x1, double y1) = GetCoordinate("Enter x1 y1 of point A: ");
            (double x2, double y2) = GetCoordinate("Enter x2 y2 of point B: ");
            (double x3, double y3) = GetCoordinate("Enter x3 y3 of point C: ");

            double a = CalculateDistance(x1, x2, y1, y2);
            double b = CalculateDistance(x2, x3, y2, y3);
            double c = CalculateDistance(x3, x1, y3, y1);

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"Area of triangle: {area:F2}");
        }

        internal void IsPointInsideTriangle()
        {
            (double x1, double y1) = GetCoordinate("Enter x1 y1 of point A: ");
            (double x2, double y2) = GetCoordinate("Enter x2 y2 of point B: ");
            (double x3, double y3) = GetCoordinate("Enter x3 y3 of point C: ");
            (double x, double y) = GetCoordinate("Enter x y of the point to check: ");

            double areaABC = CalculateAreaOfTriangle(x1, x2, x3, y1, y2, y3);
            double area1 = CalculateAreaOfTriangle(x, x2, x3, y, y2, y3);
            double area2 = CalculateAreaOfTriangle(x1, x, x3, y1, y, y3);
            double area3 = CalculateAreaOfTriangle(x1, x2, x, y1, y2, y);

            double totalArea = area1 + area2 + area3;

            int result = Math.Abs(areaABC - totalArea) < 0.0001 ? 1 : 0;
            Console.WriteLine(result == 1 ? "Point lies INSIDE the triangle." : "Point lies OUTSIDE the triangle.");
        }


        private (double, double) GetCoordinate(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine().Trim().Split();
                if (input.Length == 2 &&
                    double.TryParse(input[0], out double x) &&
                    double.TryParse(input[1], out double y))
                {
                    return (x, y);
                }
                Console.WriteLine("Invalid input. Please enter two numeric values.");
            }
        }
    }
}
