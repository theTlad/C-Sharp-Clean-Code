namespace ConsoleApp1.Services;

/// <summary>
/// Service for logging information about an order
/// </summary>
public class OrderLogger
{
    public void LogOrder(Order order)
    {
        Console.WriteLine($"Order {order.Id} logged.");
    }
}