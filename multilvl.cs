using System;
namespace mlinhrtace
{
  public class abc
   {
    private string dept;
    public abc(string value)
     {   
      dept=value;
     }
    public string deptname
    {
    get
    {
     return dept;
    }
   }
  }
  public class abcd
  {
   public static void Main(string[] args)
   {
    abc a=new abc("maths");
    Console.WriteLine("the deptment is :"+a.deptname);
   }
   }
  }  
