using System;

class Word {
    private string _text;
    private bool _isHidden;

    public Word(string text) {
        _text = text;
        _isHidden = false;
    }

    public void Show() {
        _isHidden = false;
    }

    public void Hide() {
        _isHidden = true;
    }
    public bool getHidden(){
        return _isHidden;
    }

    public string hideOrShow() {
        if (_isHidden) {
            return "_______"; // Display underscores for hidden words.
        }
        return _text;
    }
}
