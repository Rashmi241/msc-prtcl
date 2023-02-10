using System;
class program
{
public static void Main()
{
int acceptorder;
Console.WriteLine("Welcome to the shopping site:");
Console.WriteLine("How many headphones do you want today (total 10 in stock) ");
acceptorder=int.Parse(Console.ReadLine());
try
{
 if(acceptorder<=10)
 Console.WriteLine("Congratulations you have bought {0} headphones",acceptorder);
else
{
 throw (new OutOfStockException("Out of stock exception is generated please enter the total number of items within stock"));
}
}
catch(OutOfStockException e)
{
 Console.WriteLine(e.Message.ToString());
Console.ReadLine();
}
}
}
public class OutOfStockException:Exception
{
public OutOfStockException(string Message)
:base(Message)
 {
 
 }

}
