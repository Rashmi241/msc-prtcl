using System;
using System.Threading;
class single
{
public void test()
{ 
for(int i=0;i<=5;i++)
{
 Console.WriteLine("test1:"+i);
 }
 Console.WriteLine("thread ended");
}

public void test2()
{
for(int i=0;i<=5;i++)
{
Console.WriteLine("test2:"+i);
Thread.Sleep(5000);
}
Console.WriteLine("thread ended");
}
public  void test3()
{
for(int i=0;i<=5;i++)
{
Console.WriteLine("test3:"+i);
}
Console.WriteLine("thread ended");
}
public static void Main()
{
 Console.WriteLine("main thread");
 single s =new single();
 s.test();
 s.test2();
 s.test3();
 Console.WriteLine("main thread ended");
 }
 }
