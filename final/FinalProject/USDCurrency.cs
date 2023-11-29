public class USDCurrency : Currency
{
    private bool _mo_IsPrimaryReserveCurrency;

    public USDCurrency() : base("USD", "US Dollar")
    {
        _mo_IsPrimaryReserveCurrency = true; 
    }

    public bool getReserve(){
        return _mo_IsPrimaryReserveCurrency;
    }
}
