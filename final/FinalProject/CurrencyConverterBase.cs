
// Abstract base class for currency converters, providing a common interface for currency conversion.
public abstract class CurrencyConverterBase
{
    public abstract double Convert(double amount, Currency fromCurrency, Currency toCurrency);
}