public class Bank
{
    private List<Transaction> _mo_transactions;

    public Bank()
    {
        _mo_transactions = new List<Transaction>();
    }

    public void AddTransaction(Transaction transaction)
    {
        _mo_transactions.Add(transaction);
    }

    public List<Transaction> GetTransactions()
    {
        return _mo_transactions;
    }
}
