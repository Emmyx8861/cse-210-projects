using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Xavi", new Address("12 Main", "Rexburg", "Idaho", "USA"));
        Customer customer2 = new Customer("Ray", new Address("32 First Ave", "Tampa", "Florida","Canada"));

        Product product1 = new Product("Macademian Nuts","202624071826",28.00,2);
        Product product2= new Product("Microsoft HP Laptop","202624071826",1000.00,1);
        Product product3 = new Product("Harry Potter: Full Series","202624071826",45.00,7);
        Product product4 = new Product("Percy Jackson: Full Series","202624071826",38.00,7);

        Order order1= new Order(customer1);
        Order order2= new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List <Order> orders= new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach(Order order in orders)
        {
           Console.WriteLine($"Shipping Label");
           Console.WriteLine(order.GetShippingLabel());

           Console.WriteLine ($"Packing Label");
           Console.WriteLine(order.GetPackingLabel());

           Console.WriteLine($"Total Cost: ${order.GetTotalPrice()}");

           Console.WriteLine();
        }


    }

}