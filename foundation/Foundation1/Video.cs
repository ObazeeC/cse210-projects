using System;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
public class Video

{
    public string _title;
    public string _author;
    public int _length;



    public List<Komments> _comments = new List<Komments> ();
        
       
public Video(){

}

    public  void  DisplayTitleAuthorLength()
    {
        Console.WriteLine($"Title:{_title}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"Length:{_length}");
     foreach (Komments x in _comments)
     {
         //_title, author, length, number of comments(from the method)

        x.DisplayNameAndComment(); // this should be list of all the comments with the name of the person who made the comment
        Console.WriteLine($"{_title},{_author},{_length}");

     }
  
    }

    //public int NumberOfComments()
   // {
     //   for (Komments in _comments){

       // }
       
   // }
}