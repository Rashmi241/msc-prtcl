using System;
namespace stackoprtn 
{
 class stackos
 {
   int[] stack;
   int top=-1,n=3,i;
   public void push(int item)
   {
    if (top=n-1)
    {
    Console.WriteLine("stack overflow");
    }
    else
    {
    top++;
    stack[top]=item;
   }
  } 
  public void pop(int item) 
  {
   if (top==-1)
   {
   Console.WriteLine("stack is empty");
   }
   else
   {
   item=stack[top];
   top--;
   }
  } 
  public void display()
  {
  if (top==-1)
  {
   Console.WriteLine("stack is empty");
   }
   else
   {
   Console.WriteLine("stack elements are..");
   for(i=0;i<top;i++)
     {
     Console.WriteLine(" "+stack[i]);
     }
   }
}
public static void Main(string[] args)
{
 int i,n,item,ch;
 stackos s=new stackos();
 while(ch<=3)
 {
 Console.WriteLine("a.push");
 Console.WriteLine("b.push ");
 Console.WriteLine("c.display");
 Console.WriteLine("d.exit");
 Console.WriteLine("enter your choice:");
 ch=int.Parse(Console.ReadLine());
 switch(ch)
 {
 case 1:
      Console.WriteLine("enter element to insert");
      item=int.Parse(Console.ReadLine());
      s.push(item);
      break;
 case 2:
       s.pop(item);
       break;
 case 3:
       s.display();
       break;
 default:
       Console.WriteLine("wrong choice");
       break;
}
}
}
}
}
