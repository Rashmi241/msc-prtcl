using System;
using System.Threading
class mlt
{
 public void t1()
{
 for(int i=0;i<=5;i+++)
 {
 Console.WriteLine("test1:"+i);
  }
}
 public void t2()
{
 for(int i=0;i<=5;i+++)
 {
 Console.WriteLine("test2:"+i);
 Thread.sleep(5000); 
 }
}
 public void t3()
{
 for(int i=0;i<=5;i+++)
 {
 Console.WriteLine("test3:"+i);
  }
}
public static void Main()
{
mlt m1=new mlt();
Thread te1=new Thread(m1.t1);
Thread te2=new Thread(m1.t2);
Thread te2=new Thread(m1.t3);
te1.start();
te2.start();
te3.start();
}}
