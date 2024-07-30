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