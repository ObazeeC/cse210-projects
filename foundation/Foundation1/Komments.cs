using System;
public class Komments
{
    public string _name ;
    public string _commentText;

    public void DisplayNameAndComment(){
        Console.WriteLine($"{_name}, {_commentText} ");
    }
}
