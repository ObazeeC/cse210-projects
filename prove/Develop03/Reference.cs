using System;
using System.Collections.Concurrent;
using System.Diagnostics.Contracts;
    public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    
    public Reference (string book, int chapter, int verse)
    {
      _book = book;
      _chapter = chapter;
      _verse = verse;
      
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
     _book = book;
     _chapter = chapter;
     _verse = startVerse;
     _endverse = endVerse;
    }

    public string GetBook (string book)
    {
        book = _book;
        return book;
    }

    public int GetChapter (int chapter)
    {
        chapter = _chapter;
        return chapter;
    }

    public int GetVerse (int verse)
    {
        verse = _verse;
        return verse;
    }
    
    public int GetEndVerse (int endVerse)
    {
        endVerse = _endverse;
        return endVerse;
    }
    

    public string GetDisplayText()

    {
        return ($"{_book} {_chapter}:{_verse}-{_endverse}");
    }

    public string GetDisplayTextOneVerse()

    {
        return ($"{_book} {_chapter}:{_verse}");
    }
}