using System;
using System.Data;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job ();
        job1 ._company = "Hemmersbach";
        job1._jobTitle = "Technical Support";
        job1._startYear = 2023;
        job1._endYear = 2024;
      
      //Console.WriteLine(job1._company);
      //job1.DisplayJobDetails();

      Job job2 = new Job ();
      job2._company = "Esselunga";
      job2._jobTitle = "Network Engineer";
      job2._startYear = 2000;
      job2._endYear = 2022;

      //Console.WriteLine(job2._company);
     // job2.DisplayJobDetails();

        Resume myResume = new Resume();
         
        myResume._name ="Esosa C. Obazee";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        //Console.WriteLine (myResume._jobs[0]._jobTitle);
        myResume.Display();
    }
    
}