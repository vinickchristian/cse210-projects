using System;
using System.Collections.Generic;

public class Product
{
    // Private fields for encapsulation
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Public method to calculate the total cost of the product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Public method to return product details for packing label
    public string GetPackingLabel()
    {
        return $"{_name} ({_productId})";
    }
}