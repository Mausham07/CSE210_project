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
        return $"{amount} {currency.getCode()}";
    }
}
