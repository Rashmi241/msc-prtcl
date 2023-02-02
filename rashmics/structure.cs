using System;
namespace structure
{
public struct books
{
public string author;
public int no;
public string bookname; 
}
class prgm
  {
   public static void Main(string[] args) 
   {
  books a1;
  a1.author="Narasimha";
  a1.no=2001;
  a1.bookname="journey";
books a2;
 a2.author="lakshmi";
 a2.no=332;
 a2.bookname= "2 faces of coin";
Console.WriteLine("book1" );
Console.WriteLine("book author :{0}",a1.author);
Console.WriteLine("book number:{0}",a1.no);
Console.WriteLine("book author:{0}",a1.bookname);   
Console.WriteLine("book2`" );
Console.WriteLine("book author:{0}",a2.author);
Console.WriteLine("book number:{0}",a2.no);
Console.WriteLine("book name:{0}",a2.bookname);
 }
}
} 
