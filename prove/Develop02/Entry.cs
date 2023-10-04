using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Location { get; set; }
    public string Response { get; set; }

    public Entry(DateTime _mb_date, string _mb_prompt, string _mb_location, string _mb_response)
    {
        Date = _mb_date;
        Prompt = _mb_prompt;
        Location = _mb_location;
        Response = _mb_response;
    }

    public void Display()
    {
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
