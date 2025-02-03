using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalOrderCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetProductCost();
        }

        double shippingCost = _customer.GetIsInUnitedStates() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    public void DisplayOrderInformation()
    {
        Console.WriteLine("\n===== ORDER INFORMATION =====");

        Console.WriteLine("\nPacking Label: ");
        foreach (var product in _products)
        {
            Console.WriteLine(product.GetProductLabel());
        }

        Console.WriteLine("\nShipping Label: ");
        _customer.DisplayShippingLabel();

        Console.WriteLine($"\nTotal Order Cost (including shipping): ${GetTotalOrderCost()}");
    }
}