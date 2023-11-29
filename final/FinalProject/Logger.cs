public class Logger
{
    public void LogTransaction(Transaction transaction)
    {
        Console.WriteLine($"Transaction logged: {transaction.User.Username} converted {transaction.Amount} {transaction.FromCurrency.Code} to {transaction.Result} {transaction.ToCurrency.Code}");
    }
}
