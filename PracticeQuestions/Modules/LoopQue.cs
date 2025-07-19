using System;

namespace PracticeQuestions.Modules
{
    internal class LoopQue
    {
        internal void CalculateFactorial()
        {
            int num;

            while (true)
            {
                Console.Write("Enter a number to find factorial: ");
                if (int.TryParse(Console.ReadLine().Trim(), out num) && num >= 0)
                    break;

                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }

            long factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {num} is {factorial}");
        }

        internal void CountNumberTypes()
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            while (true)
            {
                Console.Write("Enter a number (or type 'q' to quit): ");
                string input = Console.ReadLine().Trim();

                if (input.ToLower() == "q")
                    break;

                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or 'q' to quit.");
                    continue;
                }

                if (number > 0)
                    positiveCount++;
                else if (number < 0)
                    negativeCount++;
                else
                    zeroCount++;
            }

            Console.WriteLine("\n--- Summary ---");
            Console.WriteLine("Positive numbers: " + positiveCount);
            Console.WriteLine("Negative numbers: " + negativeCount);
            Console.WriteLine("Zeros: " + zeroCount);
        }

        internal void PrintTrianglePattern()
        {
            int num;

            while (true)
            {
                Console.Write("Enter number of rows for the triangle pattern: ");
                if (int.TryParse(Console.ReadLine().Trim(), out num) && num > 0)
                    break;

                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            int currentNum = 1;
            for (int row = 1; row <= num; row++)
            {
                int col = 1;

                for (; col <= num - row; col++)
                {
                    Console.Write(" ");
                }

                for (; col <= num; col++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;
                }

                Console.WriteLine();
            }
        }

        internal void GenerateIntelligenceTable()
        {
            Console.WriteLine($"{"i",6} {"y",4} {"x",5}");
            Console.WriteLine(new string('-', 20));

            for (int y = 1; y <= 6; y++)
            {
                for (double x = 5.5; x <= 12.5; x += 0.5)
                {
                    double i = 2 + (y + 0.5 * x);
                    Console.WriteLine($"{i,6:F2} {y,4} {x,5:F1}");
                }
            }
        }
    }
}
