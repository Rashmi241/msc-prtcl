using System;
class baseclass
{
 public virtual int add(int num1,int num2)
  {
  return(num1+num2);
  }
class childclass:baseclass
 {
  public override int add(int num1,int num2)
  {
   if(num1<=0||num2<=0)
   {
   Console.WriteLine("enter the 1st value:");
   num1=int.Parse(Console.ReadLine());
   Console.WriteLine("enter the 2nd value:");
   num2=int.Parse(Console.ReadLine()); 
   }
   return(num1+num2);
   }
  
   class program
   {
   public static void Main(string[] args)
   {
   baseclass o=new baseclass();
   Console.WriteLine("base class method:"+o.add(4,7));
   o=new childclass();
    Console.WriteLine("child class method:"+o.add(2,2));
  }
  }
  }
}
