using System;
using PracticeQuestions.Modules;

namespace PracticeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basicIOQue = new BasicInputOutputQue();
            var decisionQue = new DecisionQue();
            var loopQue = new LoopQue();
            var arrayQue = new ArrayQue();
            var methodQue = new MethodQue();
            var coordinateGeo = new CoordinateGeometry();

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
                Console.WriteLine("13. Compound Interest (Array)");
                Console.WriteLine("14. Largest Plot Area (Array)");
                Console.WriteLine("15. Check Leap Year (Method)");
                Console.WriteLine("16. Distance Between Two Points (Method)");
                Console.WriteLine("17. Area of Triangle (Method)");
                Console.WriteLine("18. Check Point Inside Triangle (Method)");
                Console.WriteLine("19. Distance Between Two Points (CoordinateGeometry)");
                Console.WriteLine("20. Area of Triangle (CoordinateGeometry)");
                Console.WriteLine("21. Distance Between Two 3D Points (CoordinateGeometry)");
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
                        basicIOQue.CalculateGrossSalary();
                        break;
                    case 2:
                        basicIOQue.ConvertDistance();
                        break;
                    case 3:
                        basicIOQue.ReverseNumber();
                        break;
                    case 4:
                        decisionQue.CheckCharacterType();
                        break;
                    case 5:
                        decisionQue.CheckPalindromeNumber();
                        break;
                    case 6:
                        decisionQue.CheckCollinearPoints();
                        break;
                    case 7:
                        decisionQue.DetermineSteelGrade();
                        break;
                    case 8:
                        decisionQue.PerformCalculator();
                        break;
                    case 9:
                        loopQue.CalculateFactorial();
                        break;
                    case 10:
                        loopQue.CountNumberTypes();
                        break;
                    case 11:
                        loopQue.PrintTrianglePattern();
                        break;
                    case 12:
                        loopQue.GenerateIntelligenceTable();
                        break;
                    case 13:
                        arrayQue.CompoundInterest();
                        break;
                    case 14:
                        arrayQue.FindLargestPlotArea();
                        break;
                    case 15:
                        methodQue.CheckLeapYear();
                        break;
                    case 16:
                        methodQue.CalculateDistance();
                        break;
                    case 17:
                        methodQue.CalculateAreaOfTriangle();
                        break;
                    case 18:
                        methodQue.IsPointInsideTriangle();
                        break;
                    case 19:
                        coordinateGeo.CalculateDistance2D();
                        break;
                    case 20:
                        coordinateGeo.CalculateAreaOfTriangle();
                        break;
                    case 21:
                        coordinateGeo.CalculateDistanceIn3D(); 
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
