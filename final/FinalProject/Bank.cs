public class Bank
{
    private List<Transaction> transactions;

    public Bank()
    {
        transactions = new List<Transaction>();
    }

    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    public List<Transaction> GetTransactions()
    {
        return transactions;
    }
}
