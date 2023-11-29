using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        CurrencyConverter converter = new CurrencyConverter();
        Bank bank = new Bank();
        Logger logger = new Logger();
        CurrencyValidator validator = new CurrencyValidator();
        CurrencyFormatter formatter = new CurrencyFormatter();

        CurrencyCalculator calculator = new CurrencyCalculator(converter, bank, logger, validator, formatter);

        calculator.Run();
    }
}