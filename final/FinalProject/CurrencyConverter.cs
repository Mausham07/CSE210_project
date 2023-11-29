public class CurrencyConverter : CurrencyConverterBase
{
    private Dictionary<string, double> _mo_exchangeRates;

    public CurrencyConverter()
    {
        _mo_exchangeRates = new Dictionary<string, double>
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

    public override double Convert(double mo_amount, Currency fromCurrency, Currency toCurrency)
    {
        string key = $"{fromCurrency.getCode()}-{toCurrency.getCode()}";
        if (_mo_exchangeRates.ContainsKey(key))
        {
            double mo_rate = _mo_exchangeRates[key];
            return mo_amount * mo_rate;
        }
        else
        {
            Console.WriteLine("Exchange rate not available.");
            return 0.0;
        }
    }
}
