using System;
namespace palindrome
{
class prgm
  {
   public void static Main()
    {
     int sum=0,n,r,temp;
     Console.WriteLine("enter a number");
     n=Int.Parse(Console.ReadLine());
     temp=n;
     while(n>0)
      {
       r=n%10;
       sum=(sum*10)+r;      
       n=n/10;
       }
      if(temp==sum)
{
         
