using System;

class Reference {
    private string _mb_reference;
    private string _mb_text;

    // public Reference(){
    // }

    public string getText(){
        Console.Write("Enter the text of the scripture you want to memorize: ");
        _mb_text = Console.ReadLine();
        return _mb_text;
   }
   public string getReference(){
        Console.Write("Write the reference of the scripture: ");
        _mb_reference = Console.ReadLine();
        return _mb_reference;
   }
}
