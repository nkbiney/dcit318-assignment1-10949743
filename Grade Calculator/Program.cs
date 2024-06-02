using System;

namespace GradeCalculator
{
    class GradeCal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Calculator!");
            Console.Write("Please enter your numerical grade (0-100): ");

            int grade;
            while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                Console.Write("Please enter your numerical grade (0-100): ");
            }

            string letterGrade = grade switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };

            Console.WriteLine($"Your letter grade is: {letterGrade}");
            Console.WriteLine("Thank you for using the Grade Calculator. Goodbye!");
        }
    }
}

