class Save{

public Save(){


}

public void SaveToFile(List<Goal>goals){
    Console.Write("What is the filename for the goal file? ");
    string mb_filename = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(mb_filename)){
            foreach(Goal goal in goals){
                
                writer.WriteLine(goal.SaveFile());
            }
        }

}

}

