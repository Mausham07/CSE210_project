using System;

// Create the Reference class
class Reference {
    private string _mb_reference; // Private field to store the scripture reference
    private string _mb_text;     // Private field to store the scripture text


    // Method to get the scripture text from the user
    public string getText(){
        Console.Write("Enter the text of the scripture you want to memorize: ");
        _mb_text = Console.ReadLine(); // Read and store the scripture text
        return _mb_text; // Return the stored scripture text
   }

   // Method to get the scripture reference from the user
   public string getReference(){
        Console.Write("Write the reference of the scripture: ");
        _mb_reference = Console.ReadLine(); // Read and store the scripture reference
        return _mb_reference; // Return the stored scripture reference
   }
}
