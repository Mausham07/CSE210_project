using System;
using System.Collections.Generic;

class Prompt{
    public List<string> _mb_prompt;

    public Prompt(){
        _mb_prompt = new List<string>();
    }

    public string GeneratePrompt(){
        if (_mb_prompt.Count == 0){
            return "No prompts available";
        }
        Random random = new Random();
        int mb_index = random.Next(_mb_prompt.Count);
        return _mb_prompt[mb_index];
    }


}