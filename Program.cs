using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Type your email and press enter
            Console.WriteLine("Enter email:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string email = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            // Print the value of the variable (email), which will display the input value
            Console.WriteLine("Email is: " + email);
        }
    }
}
