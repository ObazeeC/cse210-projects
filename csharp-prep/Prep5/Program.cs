using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = ""; 

        DisplayWelcome();

        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        PromptUserName(name);

        Console.Write("Please enter your favorite number:");
        userInput = Console.ReadLine();
        int favoriteNumber = int.Parse(userInput);
        PromptUserNumber(favoriteNumber); 
        //Console.WriteLine($"Your favorite number is {favoriteNumber}");

       
        int square = SquareNumber (favoriteNumber);
       // Console.WriteLine(square);
        DisplayResult(name, square);
    }
     static void DisplayWelcome()
        {
             Console.WriteLine("Welcome to the program!");
        }

     static void PromptUserName(string userName)
     {
             Console.WriteLine($"Hello {userName}");
     }

     static int PromptUserNumber(int number)
     {
        return number;
     }

     static int SquareNumber (int number)
     {
        int SqNumber= number*number;
        return SqNumber;
     } 

     static void DisplayResult (string name, int squared)
     {
       
        Console.WriteLine($"{name}, the square of your number is {squared} ");
     }
}