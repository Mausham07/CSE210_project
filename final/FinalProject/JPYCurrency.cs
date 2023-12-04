// Class representing the Japanese Yen currency, extending the base Currency class.
public class JPYCurrency : Currency
{
    // Additional property to store the country information associated with Japanese Yen.
    public string _mo_Country;

    // Constructor initializes the JPYCurrency with the currency code and name,
    // and sets the associated country information.
    public JPYCurrency() : base("JPY", "Japanese Yen")
    {
        _mo_Country = "Japan";
    }

    
    //   A string representing the country information.
    public string getCountry()
    {
        return _mo_Country;
    }
}
