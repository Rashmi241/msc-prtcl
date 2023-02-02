using System;
namespace nstd
{
  public struct employ
   {
   public string name;
   public string deptid;
   public double number;
   public string empid;  
   }
  struct salary
   {
  public int da;
  public int totalsal;
  public employ a;
  }
 class prgm
 {
 public static void Main(string[] args)
{
  salary b;
  b.da=2000;
  b.totalsal=15000;   
  b.a.empid="cs01"; 
  b.a.name="shreya";
  b.a.deptid="a101";
  b.a.number=9876543210;
  Console.WriteLine("employ detail");
  Console.WriteLine("employ name:{0}",b.a.name);
  Console.WriteLine("employ dept ID:{0} ",b.a.deptid);
  Console.WriteLine("employ  ID:{0} ",b.a.empid);
  Console.WriteLine("employ phone number:{0} ",b.a.number);
  Console.WriteLine("employ da:{0} ",b.da);
  Console.WriteLine("employ total salary:{0} ",+b.totalsal);
  }
  }
 }




  
  














  
