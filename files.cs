using System;
using System.IO;
using System.Text;
class file
{
 string path=@"sample.cs";

public void fexistence()
{
 if(File.Exists(path))
Console.WriteLine("File Exists");
else
Console.WriteLine("File does not exists");
}

public void readlines()
{
if(File.Exists(path))
{
 string[]Lines=File.ReadAllLines(path);
Console.WriteLine(Lines[0]);
Console.WriteLine(Lines[1]);
}
else
Console.WriteLine("File does not exists");
}

public void readalltext()
{
 if(File.Exists(path))
{
 string lines=File.ReadAllText(path);
Console.WriteLine(lines);
}
else
Console.WriteLine("File does not exist");
}

public void fcopy()
{
 if(File.Exists(path))
{
 string copypath=@"sample1.cs";
 if(!(File.Exists(copypath)))
{
 File.Copy(path,copypath);
 Console.WriteLine(path+"Copied to"+copypath);
}
else
Console.WriteLine("Target file already exists");
}
else
Console.WriteLine("Source File does not exist");
}

public void fdel()
{
 if(File.Exists(path))
{
 File.Delete(path);
Console.WriteLine(path+"Deleted");
}
else
Console.WriteLine("File does not exist");
}

public void streamread()
{
if(File.Exists(path))
{
 using(StreamReader sr=File.OpenText(path))
{
 string s=" ";
while((s=sr.ReadLine())!=null)
Console.WriteLine(s);
}
}
else
Console.WriteLine("File does not exist");
}

public void streamwrite()
{
if(File.Exists(path))
{
 using(StreamWriter sw=File.AppendText(path))
{
Console.WriteLine("NewLine..............");
Console.WriteLine("NewLine..............");
sw.Close();
Console.WriteLine(File.ReadAllText(path));
}
}
else
Console.WriteLine("File does not exists");
}
}


class filemain
{
 public static void Main()
{
 file f=new file();
int ch;
Console.WriteLine();
Console.WriteLine("1.Check for existence of file  ");
Console.WriteLine("2.Read some lines from file ");
Console.WriteLine("3.Read all lines from file");
Console.WriteLine("4.Copy file  ");
Console.WriteLine("5.Delete file  ");
Console.WriteLine("6.Stream reader  ");
Console.WriteLine("7.stream writer  ");
Console.WriteLine("8.Exit  ");
do
{

Console.WriteLine("Enter your choice:  ");
ch= int.Parse(Console.ReadLine());
switch(ch)
{
 case 1:
f.fexistence();
break;
case 2:
f.readlines();
break;
case 3:
f.readalltext();
break;
case 4:
f.fcopy();
break;
case 5:
f.fdel();
break;
case 6:
f.streamread();
break;
case 7:
f.streamwrite();
break;
case 8:
Console.WriteLine("Exit");
break;
default:
Console.WriteLine("Invalid choice");
break;
}
}
while(ch!=8);
}
}























