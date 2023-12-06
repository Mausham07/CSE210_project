public class CurrencyCalculator
{
    // CurrencyConverter instance for currency conversion
    private readonly CurrencyConverterBase _mo_currencyConverter;

    // Bank instance for managing transactions
    private readonly Bank _mo_bank;

    // Logger instance for logging transactions
    private readonly Logger _mo_logger;

    // CurrencyValidator instance for validating currency codes
    private readonly CurrencyValidator _mo_currencyValidator;

    // CurrencyFormatter instance for formatting currency values
    private readonly CurrencyFormatter _mo_currencyFormatter;

    // Spinner instance for displaying loading/spinning animation
    private readonly Spinner _mo_spinner;

    // Constructor for initializing dependencies
    public CurrencyCalculator(CurrencyConverterBase converter, Bank bank, Logger logger, CurrencyValidator validator, CurrencyFormatter formatter)
    {
        _mo_currencyConverter = converter;
        this._mo_bank = bank;
        this._mo_logger = logger;
        _mo_currencyValidator = validator;
        _mo_currencyFormatter = formatter;
        _mo_spinner = new Spinner(new char[] { '|', '/', '-', '\\' }, 20, 300);
    }

    // Main method to run the currency conversion application
    public void Run()
    {
        // Authenticate the user before proceeding
        User mo_user = AuthenticateUser();
        if (mo_user == null)
        {
            Console.WriteLine("Authentication failed. Exiting...");
            return;
        }

        // Display application header
        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("----                                          WE CONVERT                                     ----");
        Console.WriteLine("-----|US Dollar (USD)|EURO (EUR)|JAPANESE YEN (JPY)|Nepalese Rupee (NPR)|Kuwait Dinar (DNR)|-----");
        Console.WriteLine("-------------------------------------------------------------------------------------------------\n");

        // Get source and target currencies, and amount from the user
        Currency fromCurrency = GetUserCurrency("\nEnter the source currency code: ");
        Currency toCurrency = GetUserCurrency("Enter the target currency code: ");
        double amount = UserInput.GetAmount();

        // Validate the entered currency codes
        if (!_mo_currencyValidator.IsValidCurrency(fromCurrency.getCode()) || !_mo_currencyValidator.IsValidCurrency(toCurrency.getCode()))
        {
            Console.WriteLine("\nInvalid currency codes. Exiting...");
            return;
        }

        // Perform currency conversion
        double result = _mo_currencyConverter.Convert(amount, fromCurrency, toCurrency);
        _mo_spinner.Spin();

        // Display the converted result
        Console.WriteLine($"\nResult: {_mo_currencyFormatter.FormatCurrency(result, toCurrency)}");

        _mo_spinner.Spin();

        // Record the transaction in the bank and log it
        Transaction transaction = new Transaction(mo_user, fromCurrency, toCurrency, amount, result);
        _mo_bank.AddTransaction(transaction);
        _mo_logger.LogTransaction(transaction);
    }

    // Method to authenticate the user
    private User AuthenticateUser()
    {
        // Prompt for account creation
        Console.WriteLine("Please create an account before starting!!");

        Console.Write("Enter your desired username: ");
        string newUsername = Console.ReadLine();

        Console.Write("Enter your desired password: ");
        string newPassword = Console.ReadLine();

        _mo_spinner.Spin();

        // Simplified authentication logic; replace with your authentication mechanism
        Console.Clear();
        Console.WriteLine("\nAccount created successfully! Please login to get started!!!!");
        Console.Write("\nEnter your username: ");
        string username = Console.ReadLine();
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        _mo_spinner.Spin();

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

    // Method to get a valid user-entered currency
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
