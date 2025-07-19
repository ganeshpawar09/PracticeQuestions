using System;

namespace PracticeQuestions.Modules
{
    internal class ArrayQue
    {
        internal void CompoundInterest()
        {
            double[,] entries = new double[10, 5];
            // Columns: 0=Principal, 1=Rate, 2=Years, 3=q, 4=Result

            for (int i = 0; i < 10; i++)
            {
                double principal, rate, years, q;

                // Get Principal
                while (true)
                {
                    Console.Write("Enter the Principal Amount: ");
                    if (double.TryParse(Console.ReadLine().Trim(), out principal) && principal > 0)
                        break;
                    Console.WriteLine("Invalid Principal amount.");
                }

                // Get Rate
                while (true)
                {
                    Console.Write("Enter the Rate of Interest (as decimal, e.g. 0.08 for 8%): ");
                    if (double.TryParse(Console.ReadLine().Trim(), out rate) && rate >= 0 && rate <= 1)
                        break;
                    Console.WriteLine("Invalid Rate of Interest.");
                }

                // Get Years
                while (true)
                {
                    Console.Write("Enter the number of Years: ");
                    if (double.TryParse(Console.ReadLine().Trim(), out years) && years > 0)
                        break;
                    Console.WriteLine("Invalid number of Years.");
                }

                // Get Compounding frequency (q)
                while (true)
                {
                    Console.Write("Enter the number of compounding periods per year (q): ");
                    if (double.TryParse(Console.ReadLine().Trim(), out q) && q > 0)
                        break;
                    Console.WriteLine("Invalid compounding frequency (q).");
                }

                // Save inputs
                entries[i, 0] = principal;
                entries[i, 1] = rate;
                entries[i, 2] = years;
                entries[i, 3] = q;

                // Calculate compound interest
                double amount = principal * Math.Pow((1 + (rate / q)), q * years);
                entries[i, 4] = amount;
            }

            // Display Results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Index\tPrincipal\tRate\tYears\tq\tFinal Amount");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}\t{entries[i, 0]:F2}\t\t{entries[i, 1]:P}\t{entries[i, 2]}\t{entries[i, 3]}\t{entries[i, 4]:F2}");
            }
        }

        internal void FindLargestPlotArea()
        {
            // Plot data: {a, b, angle in radians}
            double[,] plots = new double[,]
            {
                {137.4, 80.9, 0.78},
                {155.2, 92.62, 0.89},
                {149.3, 97.93, 1.35},
                {160.0, 100.25, 0.90},  
                {155.6, 68.95, 1.25},
                {149.7, 120.0, 1.75}
            };

            double maxArea = 0;
            int maxPlot = -1;

            Console.WriteLine("Plot\tArea");
            for (int i = 0; i < plots.GetLength(0); i++)
            {
                double a = plots[i, 0];
                double b = plots[i, 1];
                double angle = plots[i, 2];

                // Area formula
                double area = 0.5 * a * b * Math.Sin(angle);
                Console.WriteLine($"{i + 1}\t{area:F2}");

                // Track max
                if (area > maxArea)
                {
                    maxArea = area;
                    maxPlot = i + 1;
                }
            }

            Console.WriteLine($"\nPlot {maxPlot} has the largest area: {maxArea:F2}");
        }
    }
}
