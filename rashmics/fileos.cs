using System;  
using System.IO;
using System.Text; 
class file
{
string Path=@"example.txt";
 public void fileexist()
 {
 if(File.Exists(Path))
 Console.WriteLine("file exist"); 
 else
 Console.WriteLine("file does not exist");
 }
 public void  readLines()
 {
 if(File.Exists(Path))
 { 
 string[] lines=File.ReadAllLines(Path); 
 Console.WriteLine(lines[0]);  
 Console.WriteLine(lines[1]);
 }
else
 Console.WriteLine("file does not exist");
 }
 public void readalltext()
 {
 if(File.Exists(Path))
 { 
 string lines=File.ReadAllText(Path);    
 Console.WriteLine(lines);
 }
 else
 Console.WriteLine("file does not exist");
 }
 public void copy()
 {
 string copypath=@"qwerty.txt";
 if(File.Exists(Path))
 {
 File.Copy(Path,copypath);    
 Console.WriteLine(Path+"copied to"+copypath);  
 }
 else
 Console.WriteLine("file does not exist");
 }
 public void delete()  
 {
 if(File.Exists(Path))
 {
File.Delete(Path);
Console.WriteLine(Path+"deleted");   
} 
}
public void streamread()
{
if(File.Exists(Path))
 {
 using(StreamReader sr=File.OpenText(Path));
 {
 string s=" ";
 while((s=sr.ReadLine())!=null)
 Console.WriteLine(s);
 }
 }
 else
 Console.WriteLine("file does not exist");
 }
public void streamwrite()
{
using(StreamWriter sw=File.AppendText(Path));  
{
sw.WriteLine("new Line......");
sw.WriteLine("new Line......");

sw.Close();
Console.WriteLine(File.ReadAllText(Path));
}
}
}
class filemain
{
public static void Main()
{
int ch;
file ob=new file();  
Console.WriteLine("1.checking file");
Console.WriteLine("2.readallline file"); 
Console.WriteLine("3.readalltext file");
Console.WriteLine("4.copy file");
Console.WriteLine("5.delete file");
Console.WriteLine("6.stream reader");
Console.WriteLine("7.streamwriter");
Console.WriteLine("8.exit");
while(ch<8)
{
Console.WriteLine("enter your choice"); 
ch=int.Parse(Console.ReadLine());  
switch(ch)
{
case 1:
     ob.fileexist();  
      break;
case 2:
      ob.readlines(); 
      break;
case 3:
      ob.readalltext();
      break;
case 4:
      ob.copy();
      break; 
case 5:
     ob.delete();
      break;
case 6:
     ob.streamread(); 
     break;
case 7:
    ob.streamwrite(); 
     break;
case 8:
      Console.WriteLine("exit");
      break;
default:
     Console.WriteLine("invalid choice");   
    break; 
}
}
}
}
