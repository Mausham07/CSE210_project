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
