using System;
namespace bitwise
{
  class prgm
   {
   public static void Main()
   {
   int a=23;
   int b=30;
   int c=0;
   c=a&b;
   Console.WriteLine("{0} & {1} is {2}",a,b,c);
   c=a|b;
   Console.WriteLine("{0} | {1} is {2}",a,b,c);
   c=a^b;
   Console.WriteLine("{0} ^ {1} is {2}",a,b,c);
   c=~a;
   Console.WriteLine("~{0} is {1} ",a,c);
   c=a >> 2;
   Console.WriteLine("{0} >>2 is {1}",a,c);
   c=a << 2;
   Console.WriteLine("{0} << 2 is {1}",a,c);
   }
   }
 }
