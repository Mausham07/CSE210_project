/*
Name: Journal.cs
Purpose: This manages the journal, it display, save and load the journal saved
        in file.
Author: Mausham Bista
Date: 2023
*/

using System;
using System.Collections.Generic;
using System.IO;

// Class to manage the journal
class Journal {
    // attributes of this class
    private string _mb_username; 
    private List<Entry> _mb_entries;
    private string _mb_filename;

    // Constructor to initialize a journal with a username
    public Journal(string _mb_username){
        this._mb_username = _mb_username;
        _mb_entries = new List<Entry>();
        _mb_filename = "journal.txt";

        // Check if the journal.txt file exists, if not create one
        if(!File.Exists(_mb_filename)){
            File.Create(_mb_filename).Close();
        }
    }

    // Method to add a new entry to the journal
    public void AddEntry(DateTime _mb_date, string _mb_prompt, string _mb_location, string _mb_response)
    {
        Entry entry = new Entry(_mb_date, _mb_prompt, _mb_location, _mb_response);
        _mb_entries.Add(entry); // Add the entry to the list of _mb_entries
    }

    //Method to display all journal entries
    public void Display(){
        foreach (Entry entry in _mb_entries){
            entry.Display(); // Display each entries
        }
    }

    // Method to save journal entries to file
    public void SaveToFile(){
        using (StreamWriter writer = new StreamWriter("journal.txt")){
            foreach(Entry entry in _mb_entries){
                // Write each entry's details to the file
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Location: {entry.Location}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine();
            }
        }
    }

    // Method to load journal entries from a file
    public void LoadFromFile(){
        if(File.Exists(_mb_filename)){
            _mb_entries.Clear(); // Clear existing entries
            using (StreamReader reader = new StreamReader(_mb_filename)){
                while (!reader.EndOfStream){
                    DateTime _mb_date = DateTime.Parse(reader.ReadLine().Substring(6));
                    string _mb_prompt = reader.ReadLine();
                    string _mb_location = reader.ReadLine();
                    string _mb_response = reader.ReadLine();

                    Entry entry = new Entry(_mb_date, _mb_prompt, _mb_location, _mb_response);
                    _mb_entries.Add(entry); // Add the entry to the list of _mb_entries

                    reader.ReadLine(); // Consume the empty line
                }
            }
        }
    }
    public string GetUserName(){
        return _mb_username; // return the username
    }
}