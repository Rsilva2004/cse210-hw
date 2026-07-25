using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;    
    private Customer _customer;

    public Order(Customer customer, List<Product>products)
    {
        _customer = customer;
        _products = products;
    }


    private string _packingLabel;

    private string _shippingLabel; 

    private decimal _shippingCost;
    public decimal GetTotalPrice()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();

        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetId()}\n";
        } 
        return label;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetFullAddress()}";
    }
}