namespace ConsoleApp1.Services;

/// <summary>
/// Service for sending notifications about an order
/// </summary>
public class OrderNotifier
{
    public void NotifyCustomer(Order order)
    {
        Console.WriteLine($"Customer notified for order {order.Id}.");
    }
}