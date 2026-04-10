using System;

class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int ID, double price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price*_quantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} - {_productID}";
    }
}