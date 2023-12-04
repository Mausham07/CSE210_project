using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()

    { 
        Console.Clear();  
        Console.WriteLine("************************************************************");
        Console.WriteLine("*        Welcome to the MO Currency Converter Bank         *");
        Console.WriteLine("************************************************************\n");

        

        
        
        CurrencyConverter mo_converter = new CurrencyConverter();
        Bank mo_bank = new Bank();
        Logger mo_logger = new Logger();
        CurrencyValidator mo_validator = new CurrencyValidator();
        CurrencyFormatter mo_formatter = new CurrencyFormatter();

        CurrencyCalculator mo_calculator = new CurrencyCalculator(mo_converter, mo_bank, mo_logger, mo_validator, mo_formatter);

        mo_calculator.Run();
    }
}