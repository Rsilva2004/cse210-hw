using System;

public class Product
{
    private string _name;
    private string _Id;
    private decimal _price;
    private int _quantity;

    public Product(string name, string Id, decimal price, int quantity)
    {
        _name = name;
        _Id = Id;
        _price = price;
        _quantity = quantity;
    }

     public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _Id;
    }
}