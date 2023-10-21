using System;

class Word {
    private string _text;     // Private field to store the word's text.
    private bool _isHidden;  // Private field to track whether the word is hidden or not.

    // Constructor that initializes a Word object with its text and sets it as not hidden.
    public Word(string text) {
        _text = text;
        _isHidden = false;
    }

    // Method to hide the word.
    public void Hide() {
        _isHidden = true;
    }

    // Method to check if the word is hidden.
    public bool getHidden(){
        return _isHidden;
    }

    // Method to display the word text or underscores for hidden words.
    public string hideOrShow() {
        if (_isHidden) {
            return "_______"; // Display underscores for hidden words.
        }
        return _text; // Display the actual word text if it's not hidden.
    }
}
