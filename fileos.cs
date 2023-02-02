using System;  
class file
{
 public void fileexist()
 {
 string path=@"example.txt";
 if(File.Exists(path))
 {
 Console.WriteLine("file exist"); 
 }
Console.Readkey();
 }
 public void  read()
 {
 string path=@"example.txt";
 string[] lines; 
 lines=File.ReadAllLines(path); 
 Console.WriteLine(lines[0]);  
 Console.WriteLine(lines[1]);
 }
 public void copy()
 {
 string path=@"example.txt";
 string copypath=@"qwerty.txt";
 File.Copy(path,copypath);
 }
 public void delete()  
 {
string path=@"example.txt";
File.Delete(path);
} 
public static void Main()
{
int ch;
file ob=new file();  
Console.WriteLine("1.checking file");
Console.WriteLine("2.read file"); 
Console.WriteLine("3.copy file");
Console.WriteLine("4.delete file");
while(ch!=5)
{
Console.WriteLine("enter your choice"); 
ch=int.Parse(Console.ReadLine());  
switch(ch)
{
case 1:
     ob.fileexist();  
      break;
case 2:
      ob.read(); 
      break;
case 3:
      ob.copy();
      break;
case 4:
      ob.delete();
      break; 
default:
     Console.WriteLine("invalid choice");   
    break; 
}
}
}
}
