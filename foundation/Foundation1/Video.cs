using System;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
public class Video

{
    public string _title; // title of video
    public string _author; // author of video
    public int _length; // length of video
   //public List <Comments> _comments  = new List<Comments>();
   public List <Comments> _comments ;
        
       
public Video(){

}

    public  void  DisplayTitleAuthorLength()
    {
        Console.WriteLine($"Title:{_title}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"Length:{_length}");
        
     //foreach (Comments x in _comments)
     //{
         //_title, author, length, number of comments(from the method)

     //   x.DisplayNameAndComment(); // this should be list of all the comments with the name of the person who made the comment
      //  Console.WriteLine($"{_title},{_author},{_length}");

    // }
    }
    public int GetNumberOfComments(){
        
        int numberOfComments = 0;
        foreach (Comments x in _comments){
             //x = _comments[1];
        //numberOfComments = x[1];
        }
        return numberOfComments;
    }

    
}