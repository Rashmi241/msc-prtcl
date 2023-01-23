using System;
using System.Collections; 
class indexes 
{
 private string[] Tech=new string[14];
 public string this(int indexval)   
 {
 get
 {
  if(indexval<0||indexval>=11)
  return "empty";
  else
  return Tech[indexval];
  }
  set
  {
  if(!(indexval<0 || indexval>=11))
  Tech[indexval]=value;
  }
 }
}

class Mclass
{
 public static void Main()
{
 indexes obj=new indexes(); 
  obj[0]="infosys";
  obj[3]="wipro";
  obj[5]="satyam";
  obj[6]="patnicomputer";
  obj[8]="hexaware";
  obj[12]="logic hive`";
  obj[14]="hcl";
  Console.WriteLine("this is the list of all IT companies");
  for( int i=0;i<14;i++)
  {
  Console.WriteLine("the name of companies at index {0}:{1}",i,obj[i]); 
  }
 }
}
