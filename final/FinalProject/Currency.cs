public class Currency
{
    // Private fields to store currency code and name
    private string _mo_code;
    private string _mo_name;

    // Constructor to initialize a Currency object with code and name
    public Currency(string code, string name)
    {
        _mo_code = code;
        _mo_name = name;
    }

    // Getter method to retrieve the currency code
    public string getCode()
    {
        return _mo_code;
    }

    // Getter method to retrieve the currency name
    public string Name()
    {
        return _mo_name;
    }
}
