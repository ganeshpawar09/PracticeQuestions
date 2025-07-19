using System;

namespace PracticeQuestions.Modules
{
    internal class Decision
    {
        internal void CheckCharacterType()
        {
            Console.Write("Enter your Character: ");
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input) || input.Length != 1)
            {
                Console.WriteLine("Please enter a single character.");
                return;
            }

            char c = input[0];

            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("Character is a lowercase alphabet.");
            }
            else if ((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
            {
                Console.WriteLine("Character is not a special symbol.");
            }
            else
            {
                Console.WriteLine("Character is a special symbol.");
            }


        }
        internal void CheckPalindromeNumber()
        {
            Console.Write("Enter a five-digit number: ");

            if (!int.TryParse(Console.ReadLine().Trim(), out int originalNum) || originalNum < 10000 || originalNum > 99999)
            {
                Console.WriteLine("Please enter a valid five-digit number.");
                return;
            }

            int reverseNum = 0, temp = originalNum;

            while (temp != 0)
            {
                int digit = temp % 10;
                reverseNum = reverseNum * 10 + digit;
                temp /= 10;
            }

            if (originalNum == reverseNum)
            {
                Console.WriteLine("Reverse numbers is equal to original. Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Reverse number is not equal to original. Number is not Palindrome");
            }
        }
        internal void CheckCollinearPoints()
        {
            int[,] points = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter x coordinate of point {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out points[i, 0]))
                {
                    Console.WriteLine("Invalid input for x coordinate.");
                    return;
                }

                Console.Write($"Enter y coordinate of point {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out points[i, 1]))
                {
                    Console.WriteLine("Invalid input for y coordinate.");
                    return;
                }
            }

            int x1 = points[0, 0], y1 = points[0, 1];
            int x2 = points[1, 0], y2 = points[1, 1];
            int x3 = points[2, 0], y3 = points[2, 1];

            int area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            if (area == 0)
                Console.WriteLine("Points lie on the same line.");
            else
                Console.WriteLine("Points do not lie on the same line.");
        }

        internal void DetermineSteelGrade()
        {
            Console.Write("Enter hardness: ");
            if (!int.TryParse(Console.ReadLine(), out int hardness))
            {
                Console.WriteLine("Invalid input for hardness.");
                return;
            }

            Console.Write("Enter carbon content: ");
            if (!double.TryParse(Console.ReadLine(), out double carbon))
            {
                Console.WriteLine("Invalid input for carbon content.");
                return;
            }

            Console.Write("Enter tensile strength: ");
            if (!int.TryParse(Console.ReadLine(), out int tensile))
            {
                Console.WriteLine("Invalid input for tensile strength.");
                return;
            }

            bool condition1 = hardness > 50;
            bool condition2 = carbon < 0.7;
            bool condition3 = tensile > 5600;

            int grade = 5;

            if (condition1 && condition2 && condition3)
                grade = 10;
            else if (condition1 && condition2)
                grade = 9;
            else if (condition2 && condition3)
                grade = 8;
            else if (condition1 && condition3)
                grade = 7;
            else if (condition1 || condition2 || condition3)
                grade = 6;

            Console.WriteLine($"Grade of steel: {grade}");
        }

        internal void PerformCalculator()
        {
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input for first number.");
                return;
            }

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input for second number.");
                return;
            }

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1-4): ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid menu choice.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition = " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction = " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Division = " + (num1 / (double)num2));
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
