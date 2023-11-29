public class Transaction
{
    private User _mo_user;
    private Currency _mo_fromCurrency;
    private Currency _mo_toCurrency;
    private double _mo_amount;
    private double _mo_result;
    private DateTime _mo_timestamp;

   
    public Transaction(User user, Currency fromCurrency, Currency toCurrency, double amount, double result)
    {
        _mo_user = user;
        _mo_fromCurrency = fromCurrency;
        _mo_toCurrency = toCurrency;
        _mo_amount = amount;
        _mo_result = result;
        _mo_timestamp = DateTime.Now;
    }

     public User getUser()
    {
        return _mo_user;
    }

    public Currency getFromCurrency()
    {
        return _mo_fromCurrency;
    }

    public Currency getToCurrency()
    {
        return _mo_toCurrency;
    }

    public double getAmount()
    {
        return _mo_amount;
    }

    public double getResult()
    {
        return _mo_result;
    }

    public DateTime getTimestamp()
    {
        return _mo_timestamp;
    }

}