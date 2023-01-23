using System;
delegate int arithop(int x,int y);
class mathoperation
{
  public static int add(int a,int b)
    {
     return(a+b);
    }
  public static int sub(int a,int b)
  {
   return(a-b);
  }
class testdelegate
 {
  public static void Main() 
  {
  arithop ob1=new arithop(mathoperation.add) 
  arithop ob2=new arithop(mathoperation.sub) 
  int result1=ob1(200,100);
  int result2=ob2(200,100);
  Console.WriteLine("result "+result1);
  Console.WriteLine("result "+result2);
  }
 }
} 
  
