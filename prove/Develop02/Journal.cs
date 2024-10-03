using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
public class Journal
{
   //  public List<Entry> _entries = new List<Entry>();
  public List<Entry> _entries = new List <Entry>();
   public void AddEntry()

   {

       Entry items = new Entry();
       DateTime thecurrentTime = DateTime.Now;
      items._date  = thecurrentTime.ToShortDateString();
   

        PromptGenerator prompt = new PromptGenerator();
         items._promptText = prompt.GetRandomPrompt();
         Console.WriteLine(items._promptText);
        //Console.WriteLine(prompt.GetRandomPrompt());
  

         items._entryText = Console.ReadLine();
        _entries.Add(items);
     // Console.WriteLine(_entries);

     
   }
   public void DisplayAll()
   {
    foreach (Entry x in _entries)
    {
        x.Display();
        Console.WriteLine(x);
    }
   
      
   }
   
   public void SaveToFile (string fileName)
   {
string nameOfFile = "journal.txt";
 using (StreamWriter outputFile = new StreamWriter(nameOfFile)){

    outputFile.WriteLine(Console.ReadLine());
 }
   }

   public void LoadFromFile(string fileName)
   {

   }
}