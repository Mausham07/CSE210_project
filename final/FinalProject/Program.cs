using System;
using System.Collections.Generic;

// Base class for currencies
public class Currency
{
    private string _mo_code;
    private string _mo_name;

    public string Code
    {
        get { return _mo_code; }
        set { _mo_code = value; }
    }

    public string Name
    {
        get { return _mo_name; }
        set { _mo_name = value; }
    }

    public Currency(string code, string name)
    {
        _mo_code = code;
        _mo_name = name;
    }
}


// Derived classes for specific currencies
public class USDCurrency : Currency
{
    public bool IsPrimaryReserveCurrency { get; set; }

    public USDCurrency() : base("USD", "US Dollar")
    {
        IsPrimaryReserveCurrency = true; // Example additional attribute
    }
}

public class EuroCurrency : Currency
{
    public string EuroZone { get; set; }

    public EuroCurrency() : base("EUR", "Euro")
    {
        EuroZone = "Eurozone"; // Example additional attribute
    }
}

public class JPYCurrency : Currency
{
    public string Country { get; set; }

    public JPYCurrency() : base("JPY", "Japanese Yen")
    {
        Country = "Japan"; // Example additional attribute
    }
}


// Interface for currency conversion

// Class for currency conversion rates
public abstract class CurrencyConverterBase
{
    public abstract double Convert(double amount, Currency fromCurrency, Currency toCurrency);
}

// Derived class for currency conversion rates
public class CurrencyConverter : CurrencyConverterBase
{
    private Dictionary<string, double> exchangeRates;

    public CurrencyConverter()
    {
        exchangeRates = new Dictionary<string, double>
        {
            { "USD-EUR", 0.85 },
            { "USD-JPY", 114.5 },
            { "EUR-USD", 1.18 },
            { "EUR-JPY", 134.5 },
            { "JPY-USD", 0.0087 },
            { "JPY-EUR", 0.0074 }
            // Add more exchange rates as needed
        };
    }

    public override double Convert(double amount, Currency fromCurrency, Currency toCurrency)
    {
        string key = $"{fromCurrency.Code}-{toCurrency.Code}";
        if (exchangeRates.ContainsKey(key))
        {
            double rate = exchangeRates[key];
            return amount * rate;
        }
        else
        {
            Console.WriteLine("Exchange rate not available.");
            return 0.0;
        }
    }
}


// Class for user input handling
public class UserInput
{
    public static double GetAmount()
    {
        Console.Write("Enter the amount: ");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            return amount;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return 0.0;
        }
    }

    public static Currency GetCurrency(string prompt)
    {
        Console.Write(prompt);
        string code = Console.ReadLine().ToUpper();
        string name = ""; // You may want to fetch the name from a data source

        // Use polymorphism to create an instance of the appropriate Currency subclass
        switch (code)
        {
            case "USD":
                return new USDCurrency();
            case "EUR":
                return new EuroCurrency();
            case "JPY":
                return new JPYCurrency();
            // Add other cases as needed
            default:
                return new Currency(code, name);
        }
    }
}

// Class representing a user
public class User
{
    private string username;
    private string password;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}


// Class representing a financial transaction
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


// Class representing a bank
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


// Class for logging transactions
public class Logger
{
    public void LogTransaction(Transaction transaction)
    {
        Console.WriteLine($"Transaction logged: {transaction.User.Username} converted {transaction.Amount} {transaction.FromCurrency.Code} to {transaction.Result} {transaction.ToCurrency.Code}");
    }
}


// Class for validating currencies
public class CurrencyValidator
{
    public bool IsValidCurrency(string code)
    {
        // Add validation logic here
        return !string.IsNullOrEmpty(code);
    }
}

// Class for formatting currency values
public class CurrencyFormatter
{
    public string FormatCurrency(double amount, Currency currency)
    {
        return $"{amount} {currency.Code}";
    }
}

// Class for currency calculator
public class CurrencyCalculator
{
    private readonly CurrencyConverterBase currencyConverter;
    private readonly Bank bank;
    private readonly Logger logger;
    private readonly CurrencyValidator currencyValidator;
    private readonly CurrencyFormatter currencyFormatter;

    public CurrencyCalculator(CurrencyConverterBase converter, Bank bank, Logger logger, CurrencyValidator validator, CurrencyFormatter formatter)
    {
        currencyConverter = converter;
        this.bank = bank;
        this.logger = logger;
        currencyValidator = validator;
        currencyFormatter = formatter;
    }

    public void Run()
    {
        User user = AuthenticateUser();
        if (user == null)
        {
            Console.WriteLine("Authentication failed. Exiting...");
            return;
        }

        Currency fromCurrency = GetUserCurrency("Enter the source currency code: ");
        Currency toCurrency = GetUserCurrency("Enter the target currency code: ");
        double amount = UserInput.GetAmount();

        if (!currencyValidator.IsValidCurrency(fromCurrency.Code) || !currencyValidator.IsValidCurrency(toCurrency.Code))
        {
            Console.WriteLine("Invalid currency codes. Exiting...");
            return;
        }

        double result = currencyConverter.Convert(amount, fromCurrency, toCurrency);

        Console.WriteLine($"Result: {currencyFormatter.FormatCurrency(result, toCurrency)}");

        Transaction transaction = new Transaction(user, fromCurrency, toCurrency, amount, result);
        bank.AddTransaction(transaction);
        logger.LogTransaction(transaction);
    }

    private User AuthenticateUser()
    {
        // Simplified authentication logic; replace with your authentication mechanism
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Validate username and password (replace this with actual validation logic)
        if (username == "user" && password == "password")
        {
            return new User(username, password);
        }
        else
        {
            return null;
        }
    }

    private Currency GetUserCurrency(string prompt)
    {
        Currency currency;
        do
        {
            currency = UserInput.GetCurrency(prompt);
            if (!currencyValidator.IsValidCurrency(currency.Code))
            {
                Console.WriteLine("Invalid currency code. Please enter a valid code.");
            }
        } while (!currencyValidator.IsValidCurrency(currency.Code));

        return currency;
    }
}

// Main program class
public class Program
{
    public static void Main()
    {
        CurrencyConverter converter = new CurrencyConverter();
        Bank bank = new Bank();
        Logger logger = new Logger();
        CurrencyValidator validator = new CurrencyValidator();
        CurrencyFormatter formatter = new CurrencyFormatter();

        CurrencyCalculator calculator = new CurrencyCalculator(converter, bank, logger, validator, formatter);

        calculator.Run();
    }
}