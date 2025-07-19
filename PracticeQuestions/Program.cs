using System;
using PracticeQuestions.Modules;

namespace PracticeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basicIO = new BasicInputOutput();
            var decision = new Decision();
            var loop = new Loop();

            while (true)
            {
                Console.WriteLine("\n======= MAIN MENU =======");
                Console.WriteLine("1. Gross Salary (Basic I/O)");
                Console.WriteLine("2. Distance Converter (Basic I/O)");
                Console.WriteLine("3. Reverse 5-digit Number (Basic I/O)");
                Console.WriteLine("4. Check Character Type (Decision)");
                Console.WriteLine("5. Check Palindrome (Decision)");
                Console.WriteLine("6. Check Collinear Points (Decision)");
                Console.WriteLine("7. Grade of Steel (Decision)");
                Console.WriteLine("8. Calculator (Decision)");
                Console.WriteLine("9. Factorial (Loops)");
                Console.WriteLine("10. Count Pos/Neg/Zero (Loops)");
                Console.WriteLine("11. Triangle Pattern (Loops)");
                Console.WriteLine("12. Intelligence Table (Loops)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        basicIO.CalculateGrossSalary();
                        break;
                    case 2:
                        basicIO.ConvertDistance();
                        break;
                    case 3:
                        basicIO.ReverseNumber();
                        break;
                    case 4:
                        decision.CheckCharacterType();
                        break;
                    case 5:
                        decision.CheckPalindromeNumber();
                        break;
                    case 6:
                        decision.CheckCollinearPoints();
                        break;
                    case 7:
                        decision.DetermineSteelGrade();
                        break;
                    case 8:
                        decision.PerformCalculator();
                        break;
                    case 9:
                        loop.CalculateFactorial();
                        break;
                    case 10:
                        loop.CountNumberTypes();
                        break;
                    case 11:
                        loop.PrintTrianglePattern();
                        break;
                    case 12:
                        loop.GenerateIntelligenceTable();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\n-------------------------------\n");
            }
        }
    }
}
