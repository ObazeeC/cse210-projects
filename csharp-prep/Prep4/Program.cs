using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
       List<int> numberList = new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        number = int.Parse(userInput);
        
        //break out of the loop if the enterred number is 0, do not add 0 to the list
        // else add whatever is entered into the list
        if(number == 0)
         {
         break ;
         }
         else
         {
          numberList.Add(number);
         }
        }
        
        while(number != 0);
        float sum = numberList.Sum();
        Console.WriteLine($"The sum is : {sum} ");

          //float len = numberList.Count()-1;
          float len = numberList.Count();
         //  Console.WriteLine($"The length is : {len} ");

           float average = sum / len;
           Console.WriteLine($"The average number is : {average} ");
           
           // find the largest number in the list
           // Use the Max() function
           int largestNumber = numberList.Max();
            Console.WriteLine($"The largest number is : {largestNumber} ");

            // find the smallest positive number in the list.
            // First filter out non-positive number and then find the smallest positive number.
            int smallestPositive = numberList.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is : {smallestPositive} ");

            // sort the list

                numberList.Sort(); 
              Console.WriteLine("The sorted list is :");
              foreach (int x in numberList)
              {
                Console.WriteLine(x);
              }


    }
}