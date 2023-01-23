using System;
public class ReadDepartment
{
 private string departname;  
 public  ReadDepartment(string value)  
  {
   departname=value;
  } 
 public string DepartName
 {
  get
  {
   return departname;
  }
 }
} 
 public class ReadDeptMain
 {
 public static void Main() 
  {
   ReadDepartment d=new ReadDepartment("computer science");
   Console.WriteLine("the department is {0}",d.DepartName);
  }
 }   
