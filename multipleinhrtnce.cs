using System;
interface call1
{
int add(int a,int b);
}
interface call2
{
int sub(int a,int b);
}
interface call3
{
int mul(int a,int b);
}
interface call4
{
int div(int a,int b);
}
class calculation:call1,call2,call3,call4
{
public int r1,r2,r3,r4;
public int add(int a,int b)
{
return r1=a+b;
}
public int sub(int a,int b)
{
return r2=a-b;
}
public int mul(int a,int b)
{
return r3=a*b;
}
public int div(int a,int b)
{
return r4=a/b;
}
}
class program
{
public static void Main()
{
calculation s =new calculation();
s.add(8,2);
s.sub(5,2);
s.mul(4,4);
s.div(10,5);
Console.WriteLine("addition:"+s.r1);
Console.WriteLine("substraction:"+s.r2);
Console.WriteLine("multiplication:"+s.r3);
Console.WriteLine("division:"+s.r4);
}
}
