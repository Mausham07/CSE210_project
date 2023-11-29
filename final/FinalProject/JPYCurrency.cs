public class JPYCurrency : Currency
{
    public string Country { get; set; }

    public JPYCurrency() : base("JPY", "Japanese Yen")
    {
        Country = "Japan"; // Example additional attribute
    }
}
