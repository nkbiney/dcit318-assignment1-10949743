using System;

namespace MovieTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Parse the input to an integer
            int age;
            bool isValid = int.TryParse(input, out age);

            // Check if the input is a valid integer
            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                return;
            }

            // Determine the ticket price based on the age
            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7; // Discounted price for children and senior citizens
            }
            else
            {
                ticketPrice = 10; // Regular price
            }

            // Display the ticket price
            Console.WriteLine("The ticket price is GHC" + ticketPrice);
        }
    }
}
