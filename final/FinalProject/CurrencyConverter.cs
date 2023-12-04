// CurrencyConverter class extends CurrencyConverterBase and implements currency conversion logic
public class CurrencyConverter : CurrencyConverterBase
{
    // Dictionary to store exchange rates between currency pairs
    private Dictionary<string, double> _mo_exchangeRates;

    // Constructor initializes exchange rates for common currency pairs
    public CurrencyConverter()
    {
        _mo_exchangeRates = new Dictionary<string, double>
        {
            { "USD-EUR", 0.85 },   // Exchange rate from US Dollar to Euro
            { "USD-JPY", 114.5 },  // Exchange rate from US Dollar to Japanese Yen
            { "EUR-USD", 1.18 },   // Exchange rate from Euro to US Dollar
            { "EUR-JPY", 134.5 },  // Exchange rate from Euro to Japanese Yen
            { "JPY-USD", 0.0087 }, // Exchange rate from Japanese Yen to US Dollar
            { "JPY-EUR", 0.0074 }  // Exchange rate from Japanese Yen to Euro
            // Add more exchange rates as needed
        };
    }

    // Override method to perform currency conversion
    public override double Convert(double mo_amount, Currency fromCurrency, Currency toCurrency)
    {
        // Generate a key based on the source and target currency codes
        string key = $"{fromCurrency.getCode()}-{toCurrency.getCode()}";

        // Check if the exchange rate for the specified currency pair exists
        if (_mo_exchangeRates.ContainsKey(key))
        {
            // Retrieve the exchange rate and calculate the converted amount
            double mo_rate = _mo_exchangeRates[key];
            return mo_amount * mo_rate;
        }
        else
        {
            // Display a message when the exchange rate is not available
            Console.WriteLine("Exchange rate not available.");
            return 0.0;
        }
    }
}
