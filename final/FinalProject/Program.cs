using System;
using System.Collections.Generic;

// Entry point for the MO Currency Converter Bank program.
public class Program
{
    // Main method where the program execution starts.
    public static void Main()
    {
        // Clear the console for a clean start
        Console.Clear();  

        // Display a welcome message
        Console.WriteLine("============================================================");
        Console.WriteLine("* ------ Welcome to the MO Currency Converter Bank ------  *");
        Console.WriteLine("==========================================================\n");

        // Create instances of necessary components for the currency conversion
        CurrencyConverter mo_converter = new CurrencyConverter();
        Bank mo_bank = new Bank();
        Logger mo_logger = new Logger();
        CurrencyValidator mo_validator = new CurrencyValidator();
        CurrencyFormatter mo_formatter = new CurrencyFormatter();

        // Create an instance of CurrencyCalculator with the necessary components
        CurrencyCalculator mo_calculator = new CurrencyCalculator(mo_converter, mo_bank, mo_logger, mo_validator, mo_formatter);

        // Run the currency conversion application
        mo_calculator.Run();
    }
}
