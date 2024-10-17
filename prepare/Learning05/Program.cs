using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        // THESE TWO INSTANCES A1, AND A2 RAN PERFECTLY  
        // WITHOUT THE USE OF CONTRUCTORS
       // Assignment a1 = new Assignment();
       // a1.SetStudentName("Micheal");
        //a1.SetTopic("Mathematics");
       // Console.WriteLine (a1.GetSummary());

// Nothing will display here because assignments variables in Assignment
// in Assignment class is set to empty string
        //Assignment a2 = new Assignment();
       // a2.GetStudentName ();
        //a2.GetTopic();
       // Console.WriteLine(a2.GetSummary());

      Assignment a3 = new Assignment("Esosa Obazee", "Physics");
      Console.WriteLine (a3.GetSummary());
      
      MathAssignment a4 = new MathAssignment("Eseiwi Obazee", "English", "Section 6.5", "Problems 7 - 12");
      Console.WriteLine (a4.GetSummary());
      Console.WriteLine(a4.GetHomeWorkList());

      WritingAssignment a5 = new WritingAssignment("Mrs. Obazee","Enropean History", "The Causes of World War II " );
      Console.WriteLine (a5.GetSummary());
      Console.WriteLine(a5.GetWritingInformation());

    }
}