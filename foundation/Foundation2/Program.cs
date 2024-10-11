using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create some addresses
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create some customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create some products
        Product product1 = new Product("Laptop", "P001", 1200.99, 1);
        Product product2 = new Product("Mouse", "P002", 25.50, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00, 1);
        Product product4 = new Product("Monitor", "P004", 300.00, 1);

        // Create two orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display packing and shipping labels, and total price for each order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");
    }
}