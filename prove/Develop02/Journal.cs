using System;
using System.Collections.Generic;
public class Journal 
{
public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
     Entry myEntry = new Entry();
     DateTime date = DateTime.Now;
     myEntry._date = date.ToShortDateString();

     PromptGenerator prompt = new PromptGenerator();
      myEntry._PromptText = prompt.GetRandomPrompt();
        Console.WriteLine(prompt.GetRandomPrompt());   

      myEntry._entryText = Console.ReadLine();

      _entries.Add(myEntry);
      
     // foreach (Entry p in _entries)
     //{
       Console.WriteLine(myEntry._entryText);
             Console.WriteLine(myEntry._date);
                   Console.WriteLine(myEntry._PromptText);
      //       Console.WriteLine(p._entryText);
     // }
    }

    public void DisplayAll()
    {
    foreach (Entry i in _entries)
    {
        i.Display();
    }
    }
   
    public void SaveToFile (string fileName)
    {

    }

    public void LoadFromFile(string fileName)
    {

    }
}