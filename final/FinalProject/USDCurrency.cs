// Class representing the US Dollar currency, extending the base Currency class.
public class USDCurrency : Currency
{
    // Additional property to indicate whether the US Dollar is a primary reserve currency.
    private bool _mo_IsPrimaryReserveCurrency;

    // Constructor initializes the USDCurrency with the currency code and name,
    // and sets the IsPrimaryReserveCurrency property to true by default.
    public USDCurrency() : base("USD", "US Dollar")
    {
        _mo_IsPrimaryReserveCurrency = true;
    }

    // Method to check whether the US Dollar is a primary reserve currency.
    // Returns:
    //   True if the US Dollar is a primary reserve currency; otherwise, false.
    public bool getReserve()
    {
        return _mo_IsPrimaryReserveCurrency;
    }
}
