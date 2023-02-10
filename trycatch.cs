using System;
class program
{
public  static void Main()
{

 try
 {
Console.WriteLine("Enter the first number");
int  n1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int  n2=int.Parse(Console.ReadLine());
 int result=n1/n2;
 Console.WriteLine("{0}/{1}={2}",n1,n2,result);
 }
 catch(DivideByZeroException e)
{
 Console.WriteLine("second number should not be zero"+e.ToString());
}
catch(FormatException e)
{
 Console.WriteLine("Enter only integer numbers"+e.ToString());
}
catch (Exception e)
{
 Console.WriteLine("Other Exception raised"+e.ToString());
}
finally
{
 Console.WriteLine("Exit");
}
}
}

