using System;

namespace PracticeQuestions.Modules
{
    internal class DecisionQue
    {
        internal void CheckCharacterType()
        {
            string input;

            while (true)
            {
                Console.Write("Enter your Character: ");
                input = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(input) && input.Length == 1)
                    break;

                Console.WriteLine("Please enter a single character.");
            }

            char c = input[0];

            if (char.IsLower(c))
                Console.WriteLine("Character is a lowercase alphabet.");
            else if (char.IsLetterOrDigit(c))
                Console.WriteLine("Character is not a special symbol.");
            else
                Console.WriteLine("Character is a special symbol.");
        }

        internal void CheckPalindromeNumber()
        {
            int originalNum;

            while (true)
            {
                Console.Write("Enter a five-digit number: ");
                if (int.TryParse(Console.ReadLine().Trim(), out originalNum) && originalNum >= 10000 && originalNum <= 99999)
                    break;

                Console.WriteLine("Please enter a valid five-digit number.");
            }

            int reverseNum = 0, temp = originalNum;

            while (temp != 0)
            {
                int digit = temp % 10;
                reverseNum = reverseNum * 10 + digit;
                temp /= 10;
            }

            if (originalNum == reverseNum)
                Console.WriteLine("Reverse number is equal to original. Number is Palindrome");
            else
                Console.WriteLine("Reverse number is not equal to original. Number is not Palindrome");
        }

        internal void CheckCollinearPoints()
        {
            int[,] points = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter x coordinate of point {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out points[i, 0]))
                        break;
                    Console.WriteLine("Invalid input for x coordinate.");
                }

                while (true)
                {
                    Console.Write($"Enter y coordinate of point {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out points[i, 1]))
                        break;
                    Console.WriteLine("Invalid input for y coordinate.");
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
            int hardness;
            double carbon;
            int tensile;

            while (true)
            {
                Console.Write("Enter hardness: ");
                if (int.TryParse(Console.ReadLine(), out hardness))
                    break;
                Console.WriteLine("Invalid input for hardness.");
            }

            while (true)
            {
                Console.Write("Enter carbon content: ");
                if (double.TryParse(Console.ReadLine(), out carbon))
                    break;
                Console.WriteLine("Invalid input for carbon content.");
            }

            while (true)
            {
                Console.Write("Enter tensile strength: ");
                if (int.TryParse(Console.ReadLine(), out tensile))
                    break;
                Console.WriteLine("Invalid input for tensile strength.");
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
            int num1, num2, choice;

            while (true)
            {
                Console.Write("Enter first number: ");
                if (int.TryParse(Console.ReadLine(), out num1))
                    break;
                Console.WriteLine("Invalid input for first number.");
            }

            while (true)
            {
                Console.Write("Enter second number: ");
                if (int.TryParse(Console.ReadLine(), out num2))
                    break;
                Console.WriteLine("Invalid input for second number.");
            }

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            while (true)
            {
                Console.Write("Enter your choice (1-4): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                    break;
                Console.WriteLine("Invalid menu choice. Please choose between 1 and 4.");
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
            }
        }
    }
}
