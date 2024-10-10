using System;
public class PromptGenerator
{
  public List<string> _prompts;

  public string GetRandomPrompt()
  {
    _prompts = ["What is your favorite moment of the day ?",
    "What made your day ?", "What almost spoilt your day?","Who was the most interesting person you meant ?",
    "Did you make a new friend? ", "Is there a place you visited that you love? ", "Do you feel that today your went a bit closer to your goal?"] ;
    Random rand = new Random();
    string randomPrompt = _prompts[rand.Next(_prompts.Count())];
    return randomPrompt;
  }  
}