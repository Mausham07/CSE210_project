public class JPYCurrency : Currency
{
    public string _mo_Country;

    public JPYCurrency() : base("JPY", "Japanese Yen")
    {
        _mo_Country = "Japan"; 
    }
    public string getCountry(){
        return _mo_Country;
    }
}
