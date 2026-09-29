using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original master branch code
            Console.WriteLine("Hello World!");

            // New feature developed on the branch
            Console.Write("Enter your name to test the new build: ");
            string name = Console.ReadLine();

            GreetUser(userName: name);
        }

        // New helper method added during branch development
        static void GreetUser(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Welcome to the new branch, mysterious stranger!");
            }
            else
            {
                Console.WriteLine($"Welcome to the new branch, {userName}! Your feature is working.");
            }
        }
    }
}