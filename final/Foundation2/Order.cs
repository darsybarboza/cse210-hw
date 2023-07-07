public class Order
{

    private List <Product> _products = new List<Product> ();


    public void AddToCart (Product product)
    {
        _products.Add(product);
    }

    private double calculateCost()
    {
        double cost = 0;
        foreach (Product p in _products)
        {
            cost += (p.getPrice() * p.getQuantity());
        }

        return cost;
    }

    private double calculateShippingCost (Address address)
    {
        double shippingCost;
          if (address.GetCountry() == "USA")
          {
            shippingCost = 5;
          }

          else
          {
            shippingCost = 35;
          }

          return shippingCost;
        
    }

    private double totalCost (Address address)
    {
        double cost = calculateCost();
        double shippingCost = calculateShippingCost(address);
        double total = cost + shippingCost;
        return total;
    }

    public void packingLabel()
    {
        foreach (Product product in _products)
        {
        Console.WriteLine($"{product.getProductName()} -{product.getProductID()}");
        }
    }

    public void shippingLabel(Address address ,Customer customer)
    {
        Console.WriteLine (address.GetShippingLabel(customer));
    }

    public void displayTotalCost (Address address)
    {
        Console.WriteLine ($"Total: $ {totalCost(address)}\n");
    }

}