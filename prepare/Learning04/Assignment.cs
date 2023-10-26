using System;

class Assignment{
    private string _studentName;
    private string _topic;


    public Assignment(){
        _studentName = "";
        _topic = "";
    }

    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }

    public void GetSummary(){
        string name = _studentName;
        string topic = _topic;
        Console.WriteLine($"{name} - {topic}");
    }

}