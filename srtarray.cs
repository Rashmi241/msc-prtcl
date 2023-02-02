
using System;
namespace sortarray         
{
  class program
{
public static void Main(string[] args)
  {
   int i,n;
  Console.Writeline("enter the size of array");
  int[] arr=int.Parse(Console.ReadLine());
  Console.WriteLine("enter array element");
  for(int i=0;i<n;i++)
   {
   arr[i]=int.Parse(Console.ReadLine());
   }
   Array.Sort(arr);
   foreach (int i in arr)
   {
    Console.WriteLine(i+ " ");
   }
  }
}
}
    
