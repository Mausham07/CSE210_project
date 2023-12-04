using System;

// Class representing a financial transaction in the MO Currency Converter Bank.
public class Transaction
{
    // Private fields to store transaction details
    private User _mo_user;
    private Currency _mo_fromCurrency;
    private Currency _mo_toCurrency;
    private double _mo_amount;
    private double _mo_result;
    private DateTime _mo_timestamp;

    // Constructor to initialize a new transaction with the provided details.
    public Transaction(User user, Currency fromCurrency, Currency toCurrency, double amount, double result)
    {
        _mo_user = user;
        _mo_fromCurrency = fromCurrency;
        _mo_toCurrency = toCurrency;
        _mo_amount = amount;
        _mo_result = result;
        _mo_timestamp = DateTime.Now;
    }

    // Method to get the user associated with the transaction.
    public User getUser()
    {
        return _mo_user;
    }

    // Method to get the source currency of the transaction.
    public Currency getFromCurrency()
    {
        return _mo_fromCurrency;
    }

    // Method to get the target currency of the transaction.
    public Currency getToCurrency()
    {
        return _mo_toCurrency;
    }

    // Method to get the amount involved in the transaction.
    public double getAmount()
    {
        return _mo_amount;
    }

    // Method to get the result of the transaction.
    public double getResult()
    {
        return _mo_result;
    }

    // Method to get the timestamp of the transaction.
    public DateTime getTimestamp()
    {
        return _mo_timestamp;
    }
}
