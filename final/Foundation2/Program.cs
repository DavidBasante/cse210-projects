using System;
namespace Foundation2;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address internationalAddress = new Address("456 Rue de la Rue", "Paris", "Paris", "France");

        // Create customers
        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Jane Smith", internationalAddress);

        // Create products
        Product product1 = new Product("Product 1", "P1", 10.99, 2);
        Product product2 = new Product("Product 2", "P2", 5.99, 3);
        Product product3 = new Product("Product 3", "P3", 15.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 Total Price: $" + order2.GetTotalPrice());
        Console.WriteLine();
    }
}