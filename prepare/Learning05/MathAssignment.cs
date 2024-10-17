using System;
public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";
    
    public MathAssignment(string studentName, string topic, string textbookSection, string problem) : base (studentName , topic)
    {
     _textbookSection = textbookSection;
     _problems = problem;
    }
    public string GetTextbookSection(){
        return _textbookSection;
    }
    public string GetProblems(){
        return _problems;
    }

     public string SetTextbookSection(string textbookSection){
        _textbookSection = textbookSection;
        return _textbookSection;
    }
    public string SetProblems(string problem){
        _problems = problem;
        return _problems;
    }

   public string GetHomeWorkList(){
    return $"{_textbookSection} {_problems}";
   }
}