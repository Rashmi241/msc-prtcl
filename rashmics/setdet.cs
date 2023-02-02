using System;
 class dept
 {
  private int empid;
  public int Empid 
  {
  get
  {
  return empid; 
 } 
  set
  {
empid=value;
  }
  }
  }
 class prgm
{
 public static void Main()
 {
dept d=new dept();
d.Empid=123;
Console.WriteLine("employee ID {0}",d.Empid);  
}
}
