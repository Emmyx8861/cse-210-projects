using System.Runtime.CompilerServices;

public class Address
{
    private string _StreetAddress;

    private string _City;
    private string _StateOrProvince;

    private string _Country;

    public Address(string StreetAddress, string city, string StateOrProvince, string country)
    {
        _StreetAddress = StreetAddress;
        _City = city;
        _StateOrProvince = StateOrProvince;
        _Country = country;
    }

    public string GetStreetAddress()
    {
        return _StreetAddress;
    }

    public void SetStreetAddress(string StreetAddress)
    {
        _StreetAddress = StreetAddress;
    }

    public string GetCity()
    {
        return _City;
    }

    public void SetCity(string City)
    {
        _City= City;
    }

    public string GetStateOrProvince()
    {
        return _StateOrProvince;
    }

    public void SetStateOrProvince(string StateOrProvince)
    {
        _StateOrProvince= StateOrProvince;
    }

    public string GetCountry()
    {
        return _Country;
    }

    public void SetCountry(string Country)
    {
        _Country= Country;
    }

    public bool IsInUsa()
    {
     return _Country.Equals("USA", StringComparison.OrdinalIgnoreCase) ||
           _Country.Equals("United States", StringComparison.OrdinalIgnoreCase)||
           _Country.Equals("United States Of America",StringComparison.OrdinalIgnoreCase );
    }

    public string GetFormattedAddress()
    {
        return $"{_StreetAddress}\n{_City}, {_StateOrProvince}\n{_Country}";
    }
}

