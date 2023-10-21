using System;
using System.Collections.Generic;
using System.Linq;

class Scripture {
    private string _mb_text;
    private List<Word> _mb_words;
    private string _mb_reference;

    // Default constructor that initializes the class fields to default values.
    public Scripture(){
        _mb_text = "";
        _mb_words = new List<Word>();
        _mb_reference = "";
    }

    // Constructor that takes scripture text and reference and initializes the class fields.
    public Scripture(string text, string reference) {
        _mb_text = text;
        _mb_reference = reference;
        _mb_words = new List<Word>();

        // Split the text into words and create Word objects for each word.
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray) {
            _mb_words.Add(new Word(word));
        }
    }

    // ToString method to display the scripture with hidden words.
    public string ToString() {
        List<string> mb_displayWords = new List<string>();
        foreach (Word word in _mb_words) {
            mb_displayWords.Add(word.hideOrShow());
        }
        return $"{_mb_reference}: {string.Join(" ", mb_displayWords)}";
    }

    // Check if all words in the scripture are hidden.
    public bool AreAllWordsHidden() {
        return _mb_words.All(word => word.getHidden());
    }

    // Hide a random word in the scripture.
    public void HideRandomWord() {
        Random random = new Random();
        int index;
        do {
            index = random.Next(_mb_words.Count);
        } while (_mb_words[index].getHidden());

        _mb_words[index].Hide();
    }
}
