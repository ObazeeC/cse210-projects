using System;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Foundation1 World!");

        Video v1 = new Video();
        v1._author ="Esosa Obazee";
        v1._title="How to learn coding online";
        v1._length = 50 ;
    
        
        
        Video v2 = new Video();
        v2._author ="Penpower";
        v2._title="How to browse the internet";
        v2._length = 150 ;

        Video v3 = new Video();
        v3._author ="Esosa Obazee";
        v3._title="How to learn coding online";
        v3._length = 50 ;
        

        
        Video v4 = new Video();
        v4._author ="Penpower";
        v4._title="How to browse the internet";
        v4._length = 150 ;


        Comments k1 = new Comments();
        k1._commentText="I love this video";
        k1._name ="ESES";

     //public List<Komments> _comments = new List<Komments> ();
        Video  myVideo = new Video();
        myVideo ._author  ="me";
      
        k1.DisplayNameAndComment();
     
       
        
    }
    
       
}