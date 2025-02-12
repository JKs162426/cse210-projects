using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.Clear();

        Address address1 = new Address("1540 N 150 S", "Pleasant Grove", "Utah", "USA");
        Customer customer1 = new Customer("Carlos Gonzalez", address1);
        Product prod1Customer1 = new Product("Real Madrid T-shirt", 234, 1, 80);
        Product prod2Customer1 = new Product("Venezuela Soccer Team T-shirt", 198, 2, 65);
        Product prod3Customer1 = new Product("Nike Mercurial Shoes", 157, 1, 120);

        Order order1 = new Order(customer1);
        order1.AddProduct(prod1Customer1);
        order1.AddProduct(prod2Customer1);
        order1.AddProduct(prod3Customer1);
        Console.WriteLine("--- Order Info ---");
        order1.GetShippingLabel(address1);
        order1.GetPackingLabel();
        Console.WriteLine($"\nTotal cost (shipping included): ${order1.GetTotalCost(address1)}");


        Address address2 = new Address("Zenteno 1490", "Santiago", "Región Metropolitana", "Chile");
        Customer customer2 = new Customer("Kleydimar Moreno", address2);
        Product prod1Customer2 = new Product("Socks", 10, 10, 10);
        Product prod2Customer2 = new Product("MacBook Pro", 27, 1, 1750);
        Product prod3Customer2 = new Product("Bose QuietComfort Headphones", 89, 1, 340);

        Order order2 = new Order(customer2);
        order2.AddProduct(prod1Customer2);
        order2.AddProduct(prod2Customer2);
        order2.AddProduct(prod3Customer2);
        Console.WriteLine("\n--- Order Info ---");
        order2.GetShippingLabel(address2);
        order2.GetPackingLabel();
        Console.WriteLine($"\nTotal cost (shipping included): ${order2.GetTotalCost(address2)}");


        Address address3 = new Address("Aragua street 340", "Anaco", "Anzoategui", "Venezuela");
        Customer customer3 = new Customer("Mary Rondón", address3);
        Product prod1Customer3 = new Product("Pride and Prejudice", 45, 2, 30);
        Product prod2Customer3 = new Product("Harry Potter and the Sorcerer's Stone", 198, 1, 20);
        Product prod3Customer3 = new Product("The Power of Habit", 157, 2, 15);

        Order order3 = new Order(customer3);
        order3.AddProduct(prod1Customer3);
        order3.AddProduct(prod2Customer3);
        order3.AddProduct(prod3Customer3);
        Console.WriteLine("\n--- Order Info ---");
        order3.GetShippingLabel(address3);
        order3.GetPackingLabel();
        Console.WriteLine($"\nTotal cost (shipping included): ${order3.GetTotalCost(address3)}");
    }
}