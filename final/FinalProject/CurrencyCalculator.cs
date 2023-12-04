public class CurrencyCalculator
{
    private readonly CurrencyConverterBase _mo_currencyConverter;
    private readonly Bank _mo_bank;
    private readonly Logger _mo_logger;
    private readonly CurrencyValidator _mo_currencyValidator;
    private readonly CurrencyFormatter _mo_currencyFormatter;

    public CurrencyCalculator(CurrencyConverterBase converter, Bank bank, Logger logger, CurrencyValidator validator, CurrencyFormatter formatter)
    {
        _mo_currencyConverter = converter;
        this._mo_bank = bank;
        this._mo_logger = logger;
        _mo_currencyValidator = validator;
        _mo_currencyFormatter = formatter;
    }

    public void Run()
    {
        User mo_user = AuthenticateUser();
        if (mo_user == null)
        {
            Console.WriteLine("Authentication failed. Exiting...");
            return;
        }

        Currency fromCurrency = GetUserCurrency("Enter the source currency code: ");
        Currency toCurrency = GetUserCurrency("Enter the target currency code: ");
        double amount = UserInput.GetAmount();

        if (!_mo_currencyValidator.IsValidCurrency(fromCurrency.getCode()) || !_mo_currencyValidator.IsValidCurrency(toCurrency.getCode()))
        {
            Console.WriteLine("Invalid currency codes. Exiting...");
            return;
        }

        double result = _mo_currencyConverter.Convert(amount, fromCurrency, toCurrency);

        Console.WriteLine($"Result: {_mo_currencyFormatter.FormatCurrency(result, toCurrency)}");

        Transaction transaction = new Transaction(mo_user, fromCurrency, toCurrency, amount, result);
        _mo_bank.AddTransaction(transaction);
        _mo_logger.LogTransaction(transaction);
    }

    private User AuthenticateUser()
    {   
        // Prompt for account creation
        Console.WriteLine("Please create account to before starting !!");

        Console.Write("Enter your desired username: ");
        string newUsername = Console.ReadLine();

        Console.Write("Enter your desired password: ");
        string newPassword = Console.ReadLine();

        
        char[] spinner = { '|', '/', '-', '\\' };
            
            for (int i = 0; i < 20; i++)  // 20 iterations of spinning
            {
                Console.Write(spinner[i % 4]);
                Thread.Sleep(300);  // Pause for 800 milliseconds
                Console.Write('\b');  // Move cursor back
            }

    
        
        // Simplified authentication logic; replace with your authentication mechanism
        Console.Clear();
        Console.WriteLine("\nAccount created successfully! Please login to get started!!!!");
        Console.Write("\nEnter your username: ");
        string username = Console.ReadLine();
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        
            
        for (int i = 0; i < 20; i++)  // 20 iterations of spinning
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(300);  // Pause for 800 milliseconds
            Console.Write('\b');  // Move cursor back
        }

        // Validate username and password (replace this with actual validation logic)
        if (username == newUsername && password == newPassword)
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
        Currency mo_currency;
        do
        {
            mo_currency = UserInput.GetCurrency(prompt);
            if (!_mo_currencyValidator.IsValidCurrency(mo_currency.getCode()))
            {
                Console.WriteLine("Invalid currency code. Please enter a valid code.");
            }
        } while (!_mo_currencyValidator.IsValidCurrency(mo_currency.getCode()));

        return mo_currency;
    }
}