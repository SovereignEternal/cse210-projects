using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("John Doe",new Address("777 Monkey St","Los Angeles","California","Mexico")));
        order1.AddProduct(new Product("Acetaminophen",201,23.17,2));
        order1.AddProduct(new Product("Ibuprofen",421,10.42,3));
        order1.AddProduct(new Product("Fexofenadine HCL",691,19.78,1));

        Order order2 = new Order(new Customer("Jason Bourne",new Address("Blacksite 1","Unknown","Classified","USA")));
        order2.AddProduct(new Product("SIG-Sauer P226R",729,238.91,1));
        order2.AddProduct(new Product("Blazer Brass 9mm Handgun Ammo",832,12.99,5));


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Cost:\n${order1.GetOrderCost()}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Cost:\n${order1.GetOrderCost()}");
        Console.WriteLine();


    }
}