using System;
using System.Diagnostics.Contracts;

public class Word
{
private string _text;
private Boolean _isHidden;
public Word (string scriptureText)
{
  _text = scriptureText;
  scriptureText ="For God so love the word that He gave His only begothen Son, that whosoever beliveth in Him shall not perish but have everlasting life";
}
    public void Hide()
    {}

    public void Show()
    {}
    public bool IsHidden()
    {
        return false;
    }
    public string GetDisplayText()
    {
        return "";
    }
}