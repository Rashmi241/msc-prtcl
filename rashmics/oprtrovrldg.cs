using System;
class space
{
  int x,y,z;
  public space(int a,int b,int c)
  {
    x=a;
    y=b;
    z=c;
  }
  public void display()
  {
   Console.WriteLine(" "+x);
   Console.WriteLine(" "+y);
   Console.WriteLine(" "+z);
   }
   public static space operator -(space s)
   {
    s.x=-s.x;
    s.y=-s.y;
    s.z=-s.z;
return s;   }
  } 
 class spacetest
  {
  public static void Main()
{
   space s=new space(10,-20,30);
   Console.WriteLine("s");
   s.display();
  s=-s;
   Console.WriteLine("-s");
   s.display();
   }
  }
