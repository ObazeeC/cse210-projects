using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Boolean ans = false;
       String choice = "";

      
        
        // string name = Console.ReadLine();
         //int userInput = int.Parse(name);
          
         
        //REMEMBER TO REMOVE THESE LINES OF CODE BEFORE YOU PUSH
        
        Console.WriteLine("Welcome to the Journal Program");
        
       do{

   
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do ?");
        choice = Console.ReadLine();


     
       
        switch (choice){
            case "1":
            Journal j2 = new Journal ();
     Entry myEntry = new Entry();
     DateTime date = DateTime.Now;
     myEntry._date = date.ToShortDateString();

     PromptGenerator prompt = new PromptGenerator();
      myEntry._PromptText = prompt.GetRandomPrompt();
        Console.WriteLine(prompt.GetRandomPrompt());   

      myEntry._entryText = Console.ReadLine();

      //_entries.Add(myEntry);
     j2._entries.Add(myEntry);
    //Journal add = new Journal();
      //add.AddEntry();
         
        // jo.AddEntry(_entries);
          
    
   //Console.ReadLine();
            
  //  PromptGenerator prompt = new PromptGenerator();
   // Console.WriteLine(prompt.GetRandomPrompt());   
      

     //Entry items = new Entry();
      //items._entryText = Console.ReadLine();
   

            break;
             case "2":
             Journal d = new Journal ();
            d.DisplayAll();
             
            break;
        
             case "3":
 //Load
 Console.WriteLine("three ");
            break;

             case "4":
 //Save
 Console.WriteLine("four ");
            break;

            case "5":
 //quite
            Console.WriteLine("Goodnight !!! ");
            ans = true;
            break;
            

           // default 

        }
         }while(!ans);
         
        
    }
}