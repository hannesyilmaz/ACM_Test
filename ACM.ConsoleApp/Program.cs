using System;
using ACM.BL;

namespace ACM.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your email address:");
            string emailAddress = Console.ReadLine();

            int customerId = 1; // You can replace this with your desired customerId value or prompt the user to enter it as well.
            Customer customer = new Customer(customerId, firstName, lastName, emailAddress);

            Console.WriteLine($"Customer's Full Name: {customer.FullName}");
            Console.WriteLine($"Email Address: {customer.EmailAddress}");

            string validationStatus = customer.Validate() ? "Valid" : "Invalid";
            Console.WriteLine($"Customer's Validation Status: {validationStatus}");

            if (customer.Validate())
            {
                bool saveStatus = customer.Save();
                Console.WriteLine($"Customer's Save Status: {(saveStatus ? "Saved" : "Not Saved")}");
            }

            Console.ReadLine();
        }
    }
}
