using System;
class mltplexptn
{
 public static void Main()
{
int i;
int[] nums=new int[10]; 
int[] divisor=new int[5];
try
{
Console.WriteLine("enter number");
for(i=0;i<nums.Length;i++)
nums[i]=int.Parse(Console.ReadLine());
Console.WriteLine("enter divisor:");
for(i=0;i<divisor.Length;i++)
divisor[i]=int.Parse(Console.ReadLine());
for(i=0;i<nums.Length;i++)
Console.WriteLine(nums[i]+"/"+divisor[i]+"="+nums[i]/divisor[i]);
}
catch(DivideByZeroException)
{
Console.WriteLine("Divisor must not be zero");
}
catch(FormatException)
{
Console.WriteLine("enter only integer");
}
catch(IndexOutOfRangeException)
{
Console.WriteLine("index is out of range");
}
finally
{
Console.ReadKey();
}
}
} 
  
