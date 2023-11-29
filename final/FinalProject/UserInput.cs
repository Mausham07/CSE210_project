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