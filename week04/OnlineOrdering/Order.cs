using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    List<Product> products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost(Address IsInUSA)
    {   
        double totalProductCost = 0;

        foreach (var p in products)
        {
            totalProductCost += p.GetProductCost(IsInUSA);
        }
        
        if (IsInUSA.GetIsInUnitedStates())
        {
            totalProductCost += 5;
        }
        else
        {
            totalProductCost += 35;
        }

        return totalProductCost;
    }

    public void GetPackingLabel()
    {   
        foreach(var p in products)
        {   
            string nameOfProd = p.GetProductName();
            int idOfProd = p.GetProductId();
            Console.WriteLine($"\nName of the product: {nameOfProd}");
            Console.WriteLine($"Product Id: {idOfProd}");
        }
    }

    public void GetShippingLabel(Address customerAddress)
    {   
        string shippingInfo = $"Name: {_customer.GetCustomerName()}. Address: {customerAddress.DisplayAddress()}";
        Console.WriteLine(shippingInfo);
    }
}