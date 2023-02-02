using System;

 class stackos
 {
   int[] stack=new int[3];
  private int top=-1;
  int item,i;
   public void push(int n)
   {
    if (top==n-1)
    {
    Console.WriteLine("stack overflow");
    }
    else
    {
    Console.WriteLine("enter element to insert");
      item=int.Parse(Console.ReadLine());
    top++;
    stack[top]=item;
   }
  } 
  public void pop() 
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
   for(i=0;i<=top;i++)
     {
     Console.WriteLine(" "+stack[i]);
     }
   }
  }
  }
  class prgm
  {
public static void Main(string[] args)
{
int ch,n=3;
 stackos s=new stackos();
 Console.WriteLine("a.push");
 Console.WriteLine("b.pop ");
 Console.WriteLine("c.display");
 Console.WriteLine("d.exit");
 do
 {
 Console.WriteLine("enter your choice:");
 ch=int.Parse(Console.ReadLine());
 switch(ch)
 {
 case 1:
      s.push(n);
      break;
 case 2:
       s.pop();
       break;
 case 3:
       s.display();
       break;
 default:
       Console.WriteLine("wrong choice");
       break;
}
}while(ch!=4);
}
}

