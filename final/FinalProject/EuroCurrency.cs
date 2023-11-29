public class EuroCurrency : Currency
{
    public string EuroZone { get; set; }

    public EuroCurrency() : base("EUR", "Euro")
    {
        EuroZone = "Eurozone"; // Example additional attribute
    }
}