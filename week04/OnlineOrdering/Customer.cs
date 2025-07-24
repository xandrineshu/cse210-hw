using System;

public class Customer
{
    private string _customerName { get; set; }
    private Address _address { get; set; }

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }


    public double GetShippingCost()
    {
        double shippingCost;
        if (_address.GetCountry() == "Philippines")
        {
            shippingCost = 100;
        }
        else
        {
            shippingCost = 300;
        }
        return shippingCost;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_customerName}\r\n{_address.GetAddress()}");
    }
}