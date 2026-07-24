public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name= name;
        _address= address;
    }

    public string Getname()
    {
        return _name;
    }

    public void Setname(string name)
    {
        _name= name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address= address;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }
}