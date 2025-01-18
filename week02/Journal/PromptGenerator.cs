using System;
using System.Collections.Generic;

public class PromptGenerator
{    
    private List<string> prompts = new List<string>{"What is your favorite book?", "Describe your perfect day.","What motivates you every day?", "Describe your day in three words.",
        "What are you grateful for today?"};
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}