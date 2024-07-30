using ConsoleApp1.Models;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ErrorHandling errorHandling = new ErrorHandling();
        errorHandling.ReadFile("a/b.txt");

        CustomerService customerService = new CustomerService("John Doe");
        Console.WriteLine(customerService.GetCustomerName());

        customerService.GetCustomerById(1);

        Product product = new Product();
    }

    class CustomerService //PascalCase
    {
        /// <summary>
        /// Provides functinalities for handling customers
        /// </summary>
        /// <param name="customerName"></param>
        public CustomerService(string customerName)
        {
            _customerName = customerName;
            // Alternative: Use this.nnn if private property name not starting with underscore.
            // this.customerName = customerName;
        }

        public const int MAX_CUSTOMERS = 100; // ALL_CAPS for const

        public int CustomerCount { get; set; } // PascalCase on public property

        private string lastCustomerName = "John"; // camelCase for private property

        private string _customerName = "";

        /// <summary>
        /// Gets the customer by id
        /// </summary>
        /// <param name="customerId">The id for the customer to retrieve</param>
        /// <returns>Return the customer found by the id</returns>
        public Customer GetCustomerById(int customerId)
        {
            return new Customer { Name = "John Doe" };
        }

        public string GetCustomerName() // PascalCase for method, camelCase for parameter
        {
            return _customerName;
        }

        // Meaningful namings: Is, Get, Set, Has, Can
        public void SetCustomerName()
        {
        }

        public bool HasErrors()
        {
            return false;
        }

        public bool CanReceiveEmails()
        {
            return false;
        }

        //TODO: Implement the binary search algorithm
        public int BinarySearch()
        {
            return -1;
        }
    }

    class OrderProcessor // nouns for class names
    {
        // Use "has" or "is" for boolean values
        private bool hasErrors = false;
        private bool isValid = true;

        // Use PascalCase for methods
        public bool IsValid()
        {
            return true;
        }

        // Use PascalCase for properties
        public bool HasErrors { get; set; }

        public void ProcessOrder(Order order) // verb for methods
        {
            if (IsValid(order))
            {
                SaveOrder(order);
                NotifyCustomer(order);
            }
        }

        private bool IsValid(Order order)
        {
            //TODO: Validate order logic
            return false;
        }

        private void SaveOrder(Order order)
        {
            //TODO: Save order login
        }

        private void NotifyCustomer(Order order)
        {
            //TODO: Notify customer logic
        }


        public void PrintOrder()
        {
        }

        public void DeleteOrder()
        {
        }
    }

    /// <summary>
    /// Use summary to describe the class as good as possible. E.g.:
    /// Represents a customer with Id and Name
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// A summary can also be used for properties. E.g.:
        /// Gets the Id of the customer
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets or sets the name of the customer
        /// </summary>
        public string Name { get; set; }
    }
}