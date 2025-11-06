using HwTen.Models;
using System.IO;

namespace HwTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Customers.csv";
            var repo = new CustomerRepository(filePath);

            Console.WriteLine("All customers:");
            var all = repo.GetAllCustomers();
            foreach (var c in all)
                Console.WriteLine(c);

            Console.WriteLine("\nGet customer with ID = 3:");
            var single = repo.GetSingleCustomer(3);
            Console.WriteLine(single != null ? single.ToString() : "Customer not found");

            Console.WriteLine("\n Adding a new customer...");
            var newCustomer = new Customer
            {
                FirstName = "tika",
                LastName = "khatiashv",
                Email = "tika.khatiashv@example.com",
                Phone = "555-987-654",
                City = "Tbilisi"
            };
            int newId = repo.AddCustomer(newCustomer);
            Console.WriteLine($"New customer added with ID = {newId}");

            Console.WriteLine("\n Updating customer with ID = 1...");
            var update = repo.GetSingleCustomer(1);
            if (update != null)
            {
                update.City = "Batumi";
                repo.UpdateCustomer(update);
                Console.WriteLine("Customer updated successfully!");
            }
            else
            {
                Console.WriteLine("Customer not found for update!");
            }

            Console.WriteLine("\n Deleting customer with ID = 2...");
            int deleted = repo.DeleteCustomer(2);
            Console.WriteLine(deleted > 0 ? "Customer deleted successfully!" : "Customer not found to delete.");

            Console.WriteLine("\n All operations completed successfully!");
        }
    }
}