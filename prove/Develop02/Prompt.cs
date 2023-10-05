/*
Name : Prompt.cs
Purpose: To generate the random prompts, it stores prompt as List and give
        random List when needed.
Author : Mausham Bista
Date: 2023
*/

using System;
using System.Collections.Generic;

// Class for generating prompts
class Prompt{
    public List<string> _mb_prompt;

    public Prompt(){
        _mb_prompt = new List<string>();
    }
    // Method to generate a random prompt
    public string GeneratePrompt(){
        if (_mb_prompt.Count == 0){
            return "No prompts available"; // Return a message if there is not any prompts
        }
        Random random = new Random(); 
        int mb_index = random.Next(_mb_prompt.Count); // Generate a random prompt
        return _mb_prompt[mb_index]; // Return a randomly selected prompt
    }


}