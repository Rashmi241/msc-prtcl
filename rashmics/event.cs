using System;
public delegate void DelEventHandler();
class program
{
 public static event DelEventHandler add;
  static void Main()
  {
  add+=new DelEventHandler(usa);
  add+=new DelEventHandler(India); 
  add+=new DelEventHandler(England);
  add.Invoke();
  }
static void usa()
{
 Console.WriteLine("USA");
}
static void India()
{
 Console.WriteLine("India");
}
static void England()
{
 Console.WriteLine("england");
 }
}
