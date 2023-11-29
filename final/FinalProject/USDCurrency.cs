public class USDCurrency : Currency
{
    public bool IsPrimaryReserveCurrency { get; set; }

    public USDCurrency() : base("USD", "US Dollar")
    {
        IsPrimaryReserveCurrency = true; // Example additional attribute
    }
}
