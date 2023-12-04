public class Bank
{
    // List to store transactions
    private List<Transaction> _mo_transactions;

    // Constructor to initialize the list
    public Bank()
    {
        _mo_transactions = new List<Transaction>();
    }

    // Method to add a transaction to the list
    public void AddTransaction(Transaction transaction)
    {
        _mo_transactions.Add(transaction);
    }

    // Method to get the list of transactions
    public List<Transaction> GetTransactions()
    {
        return _mo_transactions;
    }
}
