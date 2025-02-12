using System;
using Microsoft.VisualBasic;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;

    private string _country;

    public Address()
    {

    }

    public Address(string streetAddress, string city,string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }


    public bool GetIsInUnitedStates()
    {
        return _country == "USA";
    }

    public string DisplayAddress()
    {   
        string customerAddress = $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}.";
        return customerAddress;
    }
}