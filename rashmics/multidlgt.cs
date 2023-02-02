using System;
delegate void mdelegate();
class DM
 {
  static public void display()
   {
    Console.WriteLine("new delhi");
   }
  static public void print()
  {
  Console.WriteLine("new york");
  }
 }
class Mtest
 {
  public static void Main()
    {
     mdelegate m1=new mdelegate(DM.display);
     mdelegate m2=new mdelegate(DM.print); 
     mdelegate m3=m1+m2;
     mdelegate m4=m2+m1;
     mdelegate m5=m3-m2;
     m3();
     m4();
     m5();
    }
 } 

