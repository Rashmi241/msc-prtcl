using System;
namespace array
{
 class practice
  {
   public static void Main(string[] args)
{
   int i;
   int[] arr=new int[4];
  Console.WriteLine("enter the size of array:");
  int n=int.Parse(Console.ReadLine());
  Console.WriteLine("enter the  array:");
for(i=0;i<n;i++)
{
 arr[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("display the array:");
foreach(int c in arr)
{
Console.WriteLine(c); 
}
}
}
}

