using System;
namespace arrayfinding
{
 class prgm
  {
   public static void Main(string[] args)
   {
int n,x;
int  flag=0;
int[] arr=new int[5];
Console.WriteLine("enter the size of array");
n=int.Parse(Console.ReadLine());
for(int i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}
  Console.WriteLine("enter search element");
  x=int.Parse(Console.ReadLine());
  for(int i=0;i<n;i++)
   {
    if(arr[i]==x)
   { flag=1;
   break;} 
   }
    if(flag==1)
      {
       Console.WriteLine("element found",x);
       } 
      else
      {
       Console.WriteLine("element not found",x);
      }
    }
   }
  }  
     
