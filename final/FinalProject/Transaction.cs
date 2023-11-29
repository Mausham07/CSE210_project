public class Transaction
{
    private User user;
    private Currency fromCurrency;
    private Currency toCurrency;
    private double amount;
    private double result;
    private DateTime timestamp;

    public User User
    {
        get { return user; }
        set { user = value; }
    }

    public Currency FromCurrency
    {
        get { return fromCurrency; }
        set { fromCurrency = value; }
    }

    public Currency ToCurrency
    {
        get { return toCurrency; }
        set { toCurrency = value; }
    }

    public double Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public double Result
    {
        get { return result; }
        set { result = value; }
    }

    public DateTime Timestamp
    {
        get { return timestamp; }
        set { timestamp = value; }
    }

    public Transaction(User user, Currency fromCurrency, Currency toCurrency, double amount, double result)
    {
        User = user;
        FromCurrency = fromCurrency;
        ToCurrency = toCurrency;
        Amount = amount;
        Result = result;
        Timestamp = DateTime.Now;
    }
}