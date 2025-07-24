using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("");

        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address address1 = new Address("Golden Hills Subdivision", "Marilao", "Bulacan", "Philippines");
        Customer customer1 = new Customer("Ms. Alexandrine", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Pink Notebook", "2310", 86, 2);
        Product order1Product2 = new Product("Mechanical Pen", "3201", 35, 3);
        Product order1Product3 = new Product("Eraser", "3204", 20, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        order1.AddProduct(order1Product3);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        //display order 1
        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal, order1ShippingCost, order1Total);


        Console.WriteLine("---------------------------------------------");


        //order 2
        Address address2 = new Address("Montée des Géraniums", "Beausoleil", "Alpes-Maritimes", "France");
        Customer customer2 = new Customer("Ms. Concha", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Macarons", "3870", 300, 6);
        Product order2Product2 = new Product("Soap", "4005", 199, 3);
        Product order2Product3 = new Product("Chanel Perfume", "4123", 2600.5, 1);
        Product order2Product4 = new Product("Camembert Cheese", "3953", 169.9, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        order2.AddProduct(order2Product4);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        //display order 2
        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");

    }
}