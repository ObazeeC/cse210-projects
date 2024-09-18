using System;
// Write a program that determines the letter grade for a course
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        //Console.WriteLine($"Your score is { gradePercentage}");
        string letter = "";
        if (gradePercentage >= 90)
        {
           // Console.WriteLine("Your grade is 'A' ");
  
           letter = "A";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            // Console.WriteLine("Your grade is 'B' ");
             letter = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
           //  Console.WriteLine("Your grade is 'C' ");
            letter = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            // Console.WriteLine("Your grade is 'D' ");
           letter = "D";
        }
        else
        {
           // Console.WriteLine("Your grade is 'F' ");
             letter = "F";
        }
           Console.WriteLine($"Your grade is : {letter}");
          if(gradePercentage >= 70)
          {
            Console.WriteLine("Congratulations, you passed!!!");
          }
          else
          {
             Console.WriteLine("Did not meet requirements. Please try harder next time");
          }
           
    }
}