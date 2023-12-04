// Class for logging transactions.
public class Logger
{
    //   - transaction: The transaction to be logged.
    public void LogTransaction(Transaction transaction)

    {
        DateTime mo_currentTime = DateTime.Now;
        // Output a log message with details about the transaction.
        Console.WriteLine($"\nTransaction logged: {transaction.getUser().getUsername()} converted {transaction.getAmount()} {transaction.getFromCurrency().getCode()} to {transaction.getResult()} {transaction.getToCurrency().getCode()} at {mo_currentTime}.");
    }
}
