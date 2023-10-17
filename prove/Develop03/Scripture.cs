using System;
using System.Collections.Generic;
using System.Linq;

class Scripture {
    private string _text;
    private List<Word> _words;
    private string _reference;

    public Scripture(){
        _text = "";
        _words = new List<Word>();
        _reference = "";
    }
    public Scripture(string text, string reference) {
        _text = text;
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects for each word.
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray) {
            _words.Add(new Word(word));
        }
    }

    public string ToString() {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words) {
            displayWords.Add(word.hideOrShow());
        }
        return $"{_reference}: {string.Join(" ", displayWords)}";
    }

    public bool AreAllWordsHidden() {
        return _words.All(word => word.getHidden());
    }

    public void HideRandomWord() {
        Random random = new Random();
        int index;
        do {
            index = random.Next(_words.Count);
        } while (_words[index].getHidden());

        _words[index].Hide();
    }
}
