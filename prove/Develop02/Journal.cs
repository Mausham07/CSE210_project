using System;
using System.Collections.Generic;

class Journal {
    private string _mb_username;
    private List<Entry> _mb_entries;
    private string _mb_filename;

    public Journal(string _mb_username){
        this._mb_username = _mb_username;
        _mb_entries = new List<Entry>();
        _mb_filename = "journal.txt";
    }

    public void AddEntry(DateTime _mb_date, string _mb_prompt, string _mb_location, string _mb_response)
    {
        Entry entry = new Entry(_mb_date, _mb_prompt, _mb_location, _mb_response);
        _mb_entries.Add(entry);
    }

    public void Display(){
        foreach (Entry entry in _mb_entries){
            entry.Display();
        }
    }

    public void SaveToFile(){
        using (StreamWriter writer = new StreamWriter("journal.txt")){
            foreach(Entry entry in _mb_entries){
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Location: {entry.Location}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(){
        if(File.Exists(_mb_filename)){
            _mb_entries.Clear();
            using (StreamReader reader = new StreamReader(_mb_filename)){
                while (!reader.EndOfStream){
                    DateTime _mb_date = DateTime.Parse(reader.ReadLine());
                    string _mb_prompt = reader.ReadLine();
                    string _mb_location = reader.ReadLine();
                    string _mb_response = reader.ReadLine();

                    Entry entry = new Entry(_mb_date, _mb_prompt, _mb_location, _mb_response);
                    _mb_entries.Add(entry);

                    reader.ReadLine();
                }
            }
        }
    }
    public string GetUserName(){
        return _mb_username;
    }
}