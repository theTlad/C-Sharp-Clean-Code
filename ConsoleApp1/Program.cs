namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
    }

    class CustomerService //PascalCase
    {
        public const int MAX_CUSTOMERS = 100; // ALL_CAPS for const
        
        public int CustomerCount { get; set; } // PascalCase on public property

        private string lastCustomerName = "John"; // camelCase for private property

        public string GetCustomerName(int customerId) // PascalCase for method, camelCase for parameter
        {
            string customerName = "John Doe"; // camelCase for internal variable
            return customerName;
        }
    }
}