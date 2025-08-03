using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade (0-100): ");
            int grade;

            // Validate input
            if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
            {
                if (grade >= 90)
                    Console.WriteLine("Grade: A");
                else if (grade >= 80)
                    Console.WriteLine("Grade: B");
                else if (grade >= 70)
                    Console.WriteLine("Grade: C");
                else if (grade >= 60)
                    Console.WriteLine("Grade: D");
                else
                    Console.WriteLine("Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

            // Pause the program so the console doesn't close immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
