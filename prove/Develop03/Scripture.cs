using System;
using System.ComponentModel;
public class Scripture{
     private Reference _reference;
     private List<Word> _words;

     public Scripture(Reference reference, string text)
     {
      _reference = reference;
      _words = text;
     }
    public void  HideRandomWords ()
    {
        
    }
    public string GetDisplayText()
    {
        return "";
    }

    public bool IscompletelyHidden()
    {
        return false;
    }

}