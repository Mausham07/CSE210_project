using System;

class Program {
    static void Main(string[] args) {
        Console.Clear();

        Reference reference = new Reference();
        string mb_text =reference.getText();
        string mb_reference =reference.getReference();


        Scripture scripture = new Scripture(mb_text, mb_reference);

        while (!scripture.AreAllWordsHidden()) {
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase)) {
                break;
            }

            scripture.HideRandomWord();
        }
    }

}
