using System;
using System.Data.Common;
public class Entry
{
    public string _date;
    public string _PromptText;
    public string _entryText;

    
        public  void Display()
        {
           // Entry ese = new Entry();
           // ese._date= "today";
           // ese._PromptText="meeeee";
           // ese._entryText= "ddueuereur";

         //Console.WriteLine($"{ese._date} {ese._PromptText}");
         //Console.WriteLine(ese._entryText);


         Console.WriteLine($"{_date} {_PromptText}");
         Console.WriteLine(_entryText);


        }
    
}