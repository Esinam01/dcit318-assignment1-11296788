using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            int c = int.Parse(Console.ReadLine());

            // Validate triangle
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Triangle is Equilateral.");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Triangle is Isosceles.");
                else
                    Console.WriteLine("Triangle is Scalene.");
            }
            else
            {
                Console.WriteLine("Invalid triangle: The sum of any two sides must be greater than the third side.");
            }

            // Pause the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
