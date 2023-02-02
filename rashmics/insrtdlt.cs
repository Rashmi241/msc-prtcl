using System;
namespace insert 
{ 
 class start
  {
 public static void Main(string[] args)
{
int i,n,pos,num; 
int[] arr=new int[5];
Console.WriteLine("enter the size of array");
n=int.Parse(Console.ReadLine());
Console.WriteLine("enter the array elements:");
for(i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("enter the insert element");
num=int.Parse(Console.ReadLine());
Console.WriteLine("enter the position");
pos=int.parse(Console.ReadLine());
if(pos>n+1||pos<=0)
{
Console.WriteLine("invalid");
}
else
{
for(i=n;i>=pos;i--)
{
a[i]=a[i-1];
}
a[pos-1]=num;
n++;
}
Console.WriteLine("array after insertion:");
for(i=0;i<n;i++)
Console.WriteLine(a[i]+"  ");
Console.WriteLine(); 
Console.Writeline("enter the position to delete");
pos=int.Parse(Console.ReadLine());
for(i=pos;i=n-1;i++)
 {
 a[i]=a[i+1];
 }
Console.WriteLine("array after deletion");
for(i=0;i<n;i++)
 {
 Console.WriteLine("a[i]+" ");
 }
}
}
}
 





