using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // FIRST CUSTOMER
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Product product1 = new Product(
            "Keyboard",
            "P101",
            45.99m,
            2);

        Product product2 = new Product(
            "Mouse",
            "P102",
            20.50m,
            1);

        List<Product> products1 = new List<Product>();

        products1.Add(product1);
        products1.Add(product2);

        Order order1 = new Order(customer1, products1);


        // SECOND CUSTOMER
        Address address2 = new Address(
            "45 Queen Street",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Emily Brown",
            address2);

        Product product3 = new Product(
            "Monitor",
            "P201",
            180.00m,
            1);

        Product product4 = new Product(
            "Headset",
            "P202",
            60.00m,
            2);

        Product product5 = new Product(
            "Mouse Pad",
            "P203",
            15.00m,
            1);

        List<Product> products2 = new List<Product>();

        products2.Add(product3);
        products2.Add(product4);
        products2.Add(product5);

        Order order2 = new Order(customer2, products2);


        // DISPLAY ORDER 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine();


        // DISPLAY ORDER 2
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}