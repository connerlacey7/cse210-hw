class Program
{
    static void Main()
    {
        // Create addresses
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);

        // Create products
        var product1 = new Product("Widget", "W123", 2.99, 3);
        var product2 = new Product("Gadget", "G456", 5.49, 2);
        var product3 = new Product("Thingamajig", "T789", 1.99, 5);

        // Create orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order information
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Order 1 Total Cost: ${order1.TotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Order 2 Total Cost: ${order2.TotalCost()}");
    }
}