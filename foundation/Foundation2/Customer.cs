
public class Customer
{
    // Private fields for encapsulation
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Public method to check if the customer is in the USA (encapsulation of the address method)
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Public method to return the customer's name and address for the shipping label
    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}