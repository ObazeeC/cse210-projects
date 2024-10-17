using System;
public class Assignment{
    private string _studentName = "";
    private string _topic = "";

   public Assignment(string studentname, string topic){
    _studentName = studentname;
    _topic = topic;
   }
   public string SetStudentName(string studentName){
    _studentName = studentName;
    return _studentName;
   }
   public string SetTopic(string topic){
    _topic = topic;
    return _topic;
   }

   public string GetStudentName(){
    return _studentName;
  }
   public string GetTopic(){
    return _topic;
   }

    public string GetSummary(){
        return  $"{_studentName} - {_topic}";
    }

}