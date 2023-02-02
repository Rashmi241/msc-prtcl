using System;
namespace inheritance
{
public class masters
{
 public string name;
 public string course;
 public int regno;  
 public void data(string name,string course,int regno)
  {
  this.name=name;   
  this.course=course;
  this.regno=regno;    
  Console.WriteLine("name: " +name);
  Console.WriteLine("course:"+course);
  Console.WriteLine("register number:"+regno);   
  }
 }
class day1:masters 
 {
  public void day11()
{
 Console.WriteLine("well come to the class");
}
}
class demo
{
public static void Main(string[] args)
{
 day1 d=new day1();
 d.data("rashmi","MSCcs",123);  
}
}  
}
