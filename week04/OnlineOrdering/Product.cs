using System;
using System.Numerics;

public class Product
{
    private string _productName;
    private int _productId;
    private int _quantity;

    private int _price;

    public Product()
    {

    }
    public Product(string productName, int productId, int quantity, int price)
    {
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public void SetProductID(int productId)
    {
        _productId = productId;
    }

    public double GetProductCost(Address IsInUSA)
    {   
        double productCost = _price * _quantity;
        if (IsInUSA.GetIsInUnitedStates())
        {
            productCost += 3;
        }
        else 
        {
            productCost += 5;
        }
        return productCost;
    }
}