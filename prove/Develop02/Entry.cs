using System;
using System.Security.Cryptography;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText ;
   

    public void Display()
    {
        
        //_date = dateText;

        

     Console.WriteLine($"{_date} ,{_promptText} ");
     Console.WriteLine(_entryText);
    }
}