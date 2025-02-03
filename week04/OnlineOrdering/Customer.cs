using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customerName}\nAddress: {_address.DisplayAddress()}";
    }

    public bool GetIsInUnitedStates()
    {
        return _address.GetIsInUnitedStates();
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(GetShippingLabel());
    }
}