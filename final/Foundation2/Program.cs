using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== ORDER 1 =====
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Jaylynn Tautu", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "A1", 800, 1));
        order1.AddProduct(new Product("Mouse", "B2", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");


        // ===== ORDER 2 =====
        Address addr2 = new Address("456 Beach Rd", "Apia", "Upolu", "Samoa");
        Customer cust2 = new Customer("Lani Samoa", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Headphones", "C3", 50, 1));
        order2.AddProduct(new Product("Phone Case", "D4", 15, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
