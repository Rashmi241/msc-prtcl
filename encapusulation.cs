using System;
   class employ
   {
    private string Name;
    public string Getname()
    {
     return Name;             
    }
    public void Setempname(string n)
    {
     Name=n;
    }
   }   
class prgm
 {
  public static void Main(string[] args)
{
employ  p=new employ();
p.Setempname("rashmi");
Console.WriteLine("employee name is {0} ",p.Getname());
}
}       

 


     

