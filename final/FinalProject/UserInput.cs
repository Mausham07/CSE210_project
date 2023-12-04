public class UserInput
{
    public static double GetAmount()
    {
        Console.Write("\nEnter the amount: ");
        if (double.TryParse(Console.ReadLine(), out double mo_amount))
        {
            return mo_amount;
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please enter a valid number.");
            return 0.0;
        }
        
    }
    
    

    public static Currency GetCurrency(string prompt)
    {
        Console.Write(prompt);
        string mo_code = Console.ReadLine().ToUpper();
        string mo_name = ""; 

        // Use polymorphism to create an instance of the appropriate Currency subclass
        switch (mo_code)
        {
            case "USD":
                return new USDCurrency();
            case "EUR":
                return new EuroCurrency();
            case "JPY":
                return new JPYCurrency();
            // Add other cases as needed
            default:
                return new Currency(mo_code, mo_name);
        }
    }
}