using System;
public class WriteDepartment
 {
  private string departname;
  public string Departname 
  {
  set
   {
    departname=value;
    Console.WriteLine("the department name is {0}",departname);
   }
  }
}
public class WriteDeptmain
{
public static void Main( )
{
 WriteDepartment d=new WriteDepartment();
 d.departname="computerscience";
}
}

