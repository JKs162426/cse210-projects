using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "Los Angeles", "California", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "Ontario", "Canada");
        Address address3 = new Address("789 Oak St", "London", "England", "UK");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("James Brown", address3);

        Product product1 = new Product("Soccer Ball", 1, 2, 25);
        Product product2 = new Product("Jersey", 2, 1, 50);
        Product product3 = new Product("Shoes", 3, 1, 75);

        Product product4 = new Product("Tennis Racket", 4, 1, 120);
        Product product5 = new Product("Basketball", 5, 3, 30);
        Product product6 = new Product("Running Shoes", 6, 2, 60);

        Product product7 = new Product("Baseball Bat", 7, 2, 40);
        Product product8 = new Product("Gloves", 8, 1, 20);
        Product product9 = new Product("Cap", 9, 4, 15);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Order order3 = new Order(customer3);
        order3.AddProduct(product7);
        order3.AddProduct(product8);
        order3.AddProduct(product9);

        order1.DisplayOrderInformation();
        order2.DisplayOrderInformation();
        order3.DisplayOrderInformation();
    }
}