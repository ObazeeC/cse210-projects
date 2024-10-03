using System;
using System.Xml;
public class PromptGenerator
{
//public List<string>_prompts = new List<string>() 
public List<string> _prompts;


public string GetRandomPrompt(){
_prompts = ["What is your favorite moment of the day","What is your favorite activity today" ,"What made your day", "What was the strongest emotion you felt today?",
"If you had one thing you could do again today, what would it be?","Who was the most interesting person you interacted with today?", "What gave you the worse feeling today",
"If you have the power to change one thing, what would that be", "Did you make a new friend today",
"Do you feel that today you went a bit closer to your goal?", "Is there a place you visited that you love?"];
//_prompts.Add("What is your favorite moment of the day");
//_prompts.Add("What is your favorite activity today");
//_prompts.Add( "What made your day");
//_prompts.Add("What was the strongest emotion I felt today?");
//_prompts.Add("If I had one thing I could do over today, what would it be?");
//_prompts.Add("Who was the most interesting person I interacted with today?");
    Random rand = new Random();
    //int index = rand.Next(_prompts.Count);
    //string randomString = _prompts[index];
    //return randomString;
    //return Rand_item;
    string randSentence = _prompts[rand.Next(_prompts.Count())];
    return randSentence;
}
}

