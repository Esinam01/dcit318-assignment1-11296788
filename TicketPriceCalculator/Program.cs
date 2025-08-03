using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age;

            // Validate input
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            {
                if (age <= 12 || age >= 65)
                    Console.WriteLine("Ticket Price: GHC7");
                else
                    Console.WriteLine("Ticket Price: GHC10");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }

            // Pause the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
