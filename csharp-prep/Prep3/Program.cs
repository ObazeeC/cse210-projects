using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int guessNumber = 0;
        int magicNumber = 0;
        int guessCount = 0;
       
       // Console.Write("What is the magic number?: ");
        //  userInput = Console.ReadLine();
       //  magicNumber = int.Parse(userInput);

          Random randomNumber = new Random();
          magicNumber = randomNumber.Next(1,100);

        Console.Write("What is your guess?: ");
          userInput = Console.ReadLine();
          guessNumber = int.Parse(userInput);
        
            if (magicNumber > guessNumber)
         {
            Console.WriteLine("Guess Higher");
         }
         else if (magicNumber < guessNumber)
         {
            Console.WriteLine("Guess Lower");
         }
         else
         {
            Console.WriteLine("You guessed it!");
         }
         while (guessNumber != magicNumber){
            Console.Write("What is your guess?: ");
          userInput = Console.ReadLine();
          guessNumber = int.Parse(userInput);
        
            if (magicNumber > guessNumber)
         {
            Console.WriteLine("Guess Higher");
         }
         else if (magicNumber < guessNumber)
         {
            Console.WriteLine("Guess Lower");
         }
         else
         {
            Console.WriteLine("You guessed it!");
         }
         guessCount ++;
         }
         Console.WriteLine($"You made {guessCount} attempts");
        
        
    }
}