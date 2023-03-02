using System;
class arrayop
{
public static void Main()
{
int[] arr=new int[8];
int i,n,ele,pos;
Console.WriteLine("enter the size of array");  
n=int.Parse(Console.ReadLine());
Console.WriteLine("enter the array elements");
for(i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("enter the element to insert:");
ele=int.Parse(Console.ReadLine());
Console.WriteLine("enter the element pos to insert");
pos=int.Parse(Console.ReadLine());
n+=1;
for(i=n;i>=pos;i--)
arr[i+1]=arr[i];
arr[pos]=ele;
Console.WriteLine("array after insertion");
for(i=0;i<n;i++)
{
Console.WriteLine(arr[i]);
}
Console.WriteLine("enter the element to delete:");
ele=int.Parse(Console.ReadLine());
//Console.WriteLine("enter the element pos to delete");
//pos=int.Parse(Console.ReadLine());
for(i=pos-1;i<n-1;i++)

//ele=arr[pos];
arr[i]=arr[i+1];
//ele=arr[pos];
n-=1;

Console.WriteLine("array after deletion");
for(i=0;i<n-1;i++)
{
Console.WriteLine(arr[i]);
}
}
}
