using System;

// MY collection of classes for this project.
namespace HelloWorld_Landon_Simmons
{
    // Main method is executed when application starts
    class Program
    {
        // The Main method is excuted when application starts
        static void Main(string[] args)
        {
            // Asks the user for first name
            Console.WriteLine("What is your first name?");
            // Assigns user input to firstName variable
            string firstName = Console.ReadLine();
            // Asks the user for last name
            Console.WriteLine("What is your last name?");
            // Assigns the user input to lastName variable
            string lastName = Console.ReadLine();
            
            // Prints a welcome message with firstName and lastName
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
        }
    }
}