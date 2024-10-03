using System;
using System.ComponentModel.DataAnnotations;

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
    Journal addone = new Journal ();
          addone.AddEntry();
          
          
    
   //Console.ReadLine();
            
    //PromptGenerator prompt = new PromptGenerator();
    //Console.WriteLine(prompt.GetRandomPrompt());   
      

     //Entry items = new Entry();
      //items._entryText = Console.ReadLine();
   

            break;
             case "2":
             Journal dAll = new Journal ();

             dAll.DisplayAll();
             
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