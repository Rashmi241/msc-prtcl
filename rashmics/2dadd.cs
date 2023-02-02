using System;
namespace twod 
{
 class prgm
  {
   public static void Main(string[] args)
   {
   int[,] arr=new int[3,3];
   int m,n,i,j;
  Console.WriteLine("enter array n value");
  n=int.Parse(Console.ReadLine());
  Console.WriteLine("enter array m  value");
  m=int.Parse(Console.ReadLine());
  Console.WriteLine("enter the matrix");  
  for(i=0;i<n;i++)
  {
  for(j=0;j<m;j++)
  {
 arr[n,m]=int.Parse(Console.ReadLine());
}
}
}
}
} 
