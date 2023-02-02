using System;
namespace array
{
 class practice
  {
   public static void Main(string[] args)
{ 
   int i;
   int[] arr=new int[5];
  Console.WriteLine("enter the size of array:");
  int n=int.Parse(Console.ReadLine());
  Console.WriteLine("enter the  array:");
for(i=0;i<n;i++)
{
 arr[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("display the array:");
for(i=0;i<n;i++) 
{
Console.WriteLine(arr[i]);
}
}
} 
}
 
