using System;

namespace PracticeQuestions.Modules
{
    internal class BasicInputOutputQue
    {
        internal void CalculateGrossSalary()
        {
            decimal baseSalary;

            while (true)
            {
                Console.Write("Enter your base salary: ");
                if (decimal.TryParse(Console.ReadLine(), out baseSalary) && baseSalary >= 0)
                    break;

                Console.WriteLine("Invalid input. Base salary must be a non-negative number.");
            }

            decimal dearnessAllowance = baseSalary * 0.40m;
            decimal houseRentAllowance = baseSalary * 0.20m;
            decimal grossSalary = baseSalary + dearnessAllowance + houseRentAllowance;

            Console.WriteLine($"Your Gross Salary is: {grossSalary:F2}");
        }

        internal void ConvertDistance()
        {
            double distanceKm;

            while (true)
            {
                Console.Write("Enter distance in kilometers: ");
                if (double.TryParse(Console.ReadLine(), out distanceKm) && distanceKm >= 0)
                    break;

                Console.WriteLine("Invalid input. Distance must be a non-negative number.");
            }

            Console.WriteLine($"Meters: {distanceKm * 1000:F2}");
            Console.WriteLine($"Feet: {distanceKm * 3280.84:F2}");
            Console.WriteLine($"Inches: {distanceKm * 39370.1:F2}");
            Console.WriteLine($"Centimeters: {distanceKm * 100000:F2}");
        }

        internal void ReverseNumber()
        {
            int number;

            while (true)
            {
                Console.Write("Enter a five-digit number: ");
                if (int.TryParse(Console.ReadLine(), out number) && number >= 10000 && number <= 99999)
                    break;

                Console.WriteLine("Invalid input. Please enter a valid five-digit number.");
            }

            int reversed = 0, temp = number;
            while (temp != 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"Original Number: {number}, Reversed Number: {reversed}");
        }
    }
}
