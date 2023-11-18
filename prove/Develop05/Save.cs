class Save
{
    public Save()
    {
        // Constructor (if needed)
    }

    public void SaveToFile(List<Goal> goals)
    {
        // Ask user for the filename
        Console.Write("What is the filename for the goal file? ");
        string mb_filename = Console.ReadLine();

        // Open a StreamWriter to write to the specified file
        using (StreamWriter writer = new StreamWriter(mb_filename))
        {
            // Iterate over each Goal in the list
            foreach (Goal goal in goals)
            {
                // Write the string representation of the goal to the file
                writer.WriteLine(goal.SaveFile());
            }
        }
    }
}
