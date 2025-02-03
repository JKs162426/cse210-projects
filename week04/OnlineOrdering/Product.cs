using System;

public class Product
{
    private string _productName;
    private int _productId;
    private int _quantity;

    private int _price;

    public Product(string productName, int productId, int quantity, int price)
    {
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }
    public double GetProductCost()
    {
        return _quantity * _price;
    }

    public string GetProductLabel()
    {
        return $"Product: {_productName} (ID: {_productId})";
    }
}