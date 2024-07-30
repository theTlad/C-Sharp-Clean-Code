namespace ConsoleApp1.Services;

public class OrderService
{
    private List<Order> orders = new List<Order>();
    private OrderLogger orderLogger = new OrderLogger();
    private OrderNotifier orderNotifier = new OrderNotifier();

    public void AddOrder(Order order)
    {
        orders.Add(order);
        orderLogger.LogOrder(order);
        orderNotifier.NotifyCustomer(order);
    }
}