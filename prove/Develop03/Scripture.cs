using System;
using System.ComponentModel;
public class Scripture{
     private Reference _reference ;
     private List<Word> _words;



     //public Scripture(Reference reference, List<Word> word)
     //{
     
      //_reference = reference;
     // _words = word;
    // }
public Scripture (Reference reference, string word)
    {
    
     
       //_words = word;
    
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