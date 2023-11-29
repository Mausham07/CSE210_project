public class Logger
{
    public void LogTransaction(Transaction transaction)
    {
        Console.WriteLine($"Transaction logged: {transaction.getUser().getUsername()} converted {transaction.getAmount()} {transaction.getFromCurrency().getCode()} to {transaction.getResult()} {transaction.getToCurrency().getCode()}");
    }
}
