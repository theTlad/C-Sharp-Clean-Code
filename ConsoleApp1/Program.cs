namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        CustomerService customerService = new CustomerService("John Doe");
        Console.WriteLine(customerService.GetCustomerName());
    }

    class CustomerService //PascalCase
    {
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

        public string GetCustomerName() // PascalCase for method, camelCase for parameter
        {
            return _customerName;
        }
    }

    class OrderProcessor // nouns for class names
    {
        public void ProcessOrder() // verb for methods
        {
        }

        public void PrintOrder()
        {
        }

        public void DeleteOrder()
        {
        }
    }
}