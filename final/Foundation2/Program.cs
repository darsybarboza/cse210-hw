using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Ipad Mini","IM0810", 300.99, 1);
        Product product2 = new Product("Portable Charger","BM1814", 50.99, 1);
        Product product3 = new Product("Huawei Smartwatch","SK3711",19.99, 1);
        Product product4 = new Product("Elite Omega3","MI7072",24.99, 2);
        Product product5 = new Product("Keto Gummies Apple Cider Vinegar","PI3519",32.99, 1);


        Order order1 = new Order();
        Address address1 =  new Address ("Avenida Miguel Server 33", "Irun", "Zaragoza", "SPAIN");
        Customer customer1 = new Customer ("Leticia Saenz", address1);



        order1.AddToCart(product1);
        order1.AddToCart(product2);
        order1.packingLabel();
        order1.shippingLabel(address1 , customer1);
        order1.displayTotalCost(address1);


        Console.WriteLine("");


        Order order2 = new Order();
        Address address2 =  new Address ("1233 2590 S Cir", "St George", "UT", "USA");
        Customer customer2 = new Customer ("Christen Gibson", address2);



        order2.AddToCart(product2);
        order2.AddToCart(product3);
        order2.packingLabel();
        order2.shippingLabel(address2 , customer2);
        order2.displayTotalCost(address2);


        Console.WriteLine("");




        Order order3 = new Order();
        Address address3 =  new Address ("50 Oakland Ave #45", "Orlando", "FL", "USA");
        Customer customer3 = new Customer ("Monica Geller", address3);



        order3.AddToCart(product4);
        order3.AddToCart(product5);
        order3.packingLabel();
        order3.shippingLabel(address3 , customer3);
        order3.displayTotalCost(address3);








    }
}