using System;
class complex
{
double x;
double y;
public complex()
 {
 }
public complex(double real,double img)
 {
 x=real;
 y=img;
 }
public static complex operator +(complex c1,complex c2)
 { 
  complex c3=new complex();
  c3.x=c1.x+c2.x;
  c3.y=c1.y+c2.y;
  return(c3);
 }
public void display()
 { 
 Console.Write(x);
 Console.Write("+j"+y);
 }
 }
class complexTest
{
 public static void Main()
  {
   complex a,b,c;
   a=new complex(2.5,3.5);
   b=new complex(16,2.7);
   c=a+b;
   Console.WriteLine("a=");
   a.display();
   Console.WriteLine("b=");
   b.display();
   Console.WriteLine("c=");
   c.display();
  }
} 





