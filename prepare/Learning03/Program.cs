using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f1 = new Fraction ();
        f1.SetNumerator(3);
        f1.SetDenominator(17);
       // f1.GetNumerator(0);
       // f1.Getdenominator(3);
        Console.WriteLine(f1.Getdenominator());
        Console.WriteLine(f1.GetNumerator());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
       

       Fraction f2 = new Fraction (8);
       //f2.SetDenominator(3);
       //f2.SetNumerator(5);
       
         Console.WriteLine(f2.Getdenominator());
        Console.WriteLine(f2.GetNumerator());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
       
       Fraction f3 = new Fraction (8, 9);
        
       // Console.WriteLine(f3.Getdenominator());
       // Console.WriteLine(f3.GetNumerator());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
       
    }
}