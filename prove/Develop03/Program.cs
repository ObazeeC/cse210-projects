using System;

class Program
{
    static void Main(string[] args)
    {

        

        Console.WriteLine("Scripture Memorizer");
        string bible ="";
        int chp = 0;
        int vex = 0;
        int endVex =0;
     
        Reference r = new Reference(bible, chp, vex);{
          
         // r.GetBook(bible);
         // r.GetVerse(vex);
          //r.GetChapter(chp);

       Console.WriteLine(r.GetDisplayTextOneVerse());
        }

        Reference r1 = new Reference(bible, chp, vex, endVex);
        {
            Console.WriteLine(r1.GetDisplayText());
        }
        
    }
}