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