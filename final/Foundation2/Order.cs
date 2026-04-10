using System;

class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetOrderCost()
    {
        double orderTotal = 0;
        foreach (Product product in _products)
        {
            orderTotal += product.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            orderTotal += 5;
        }
        else
        {
            orderTotal += 35;
        }

        return orderTotal;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetProductInfo()}\n";
        }
        
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}