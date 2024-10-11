public class Order
{
    // Private fields for encapsulation
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Public method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Public method to calculate the total cost of the order (including shipping)
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Shipping cost: $5 for USA, $35 for non-USA
        if (_customer.IsInUSA())
        {
            total += 5.0;
        }
        else
        {
            total += 35.0;
        }

        return total;
    }

    // Public method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    // Public method to generate the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}