using System;
namespace evenor 
{
  class even
   {
     static void Main()
      {
       int num;
       
       Console.WriteLine("enter a number");
       num=Convert.ToInt32(Console.ReadLine());
       int rem= num%2; 
      if(rem == 0) 
        {
        Console.WriteLine("even number");
        }
        else
        {
        Console.WriteLine("odd number");
        } 
      }
    }
}
