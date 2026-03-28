using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usAddress = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address intlAddress = new Address("456 King St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Smith", usAddress);
        Customer customer2 = new Customer("Jane Doe", intlAddress);

        // Create and populate first order (USA customer)
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 29.99, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 79.99, 1));

        // Create and populate second order (International customer)
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P004", 299.99, 1));
        order2.AddProduct(new Product("USB Cable", "P005", 9.99, 3));

        Console.Clear();

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalOrderCost():F2}\n");

        // Display Order 2
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalOrderCost():F2}");
    }
}