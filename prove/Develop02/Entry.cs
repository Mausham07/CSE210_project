/* 
Name: Entry.cs
Purpose: This program gets entry like date, prompt, location and respone then
        display it whenever needed.
Author: Mausahm Bista
Date: 2023
*/

using System;

// Class to represent journal entries
public class Entry
{
    public DateTime Date { get; set; } //Property for the date
    public string Prompt { get; set; } // Property for the prompt
    public string Location { get; set; } // Property for the location
    public string Response { get; set; } // Property for the response

    // Cronstructor to initialize an entry
    public Entry(DateTime _mb_date, string _mb_prompt, string _mb_location, string _mb_response)
    {
        // set the date, prompt, location and response
        Date = _mb_date; 
        Prompt = _mb_prompt;
        Location = _mb_location;
        Response = _mb_response;
    }

    // Method to display an entry
    public void Display()
    {   
        // Display the date, propmt, location and response
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string GetResponse()
    {
        return Response;
    }
}
