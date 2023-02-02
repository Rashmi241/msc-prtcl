using System;
class program
{ 
 public int add(int num1,int num2)
 {
  return(num1+num2);
 }
public int add(int num1,int num2,int num3)
 {
  return(num1+num2+num3);
 }
public float add(float num1,float num2)
 {
  return(num1+num2);
 }
public string add(string s1,string s2)
 {
  return(s1+ " "+s2);
 }
 public static void Main(string[] args)
  {
   program o= new program();
   Console.WriteLine("addition of 2 integer"+o.add(3,2));
   Console.WriteLine("addition of 3 integer"+o.add(3,2,4));
   Console.WriteLine("addition of 2 float "+o.add(3f,2f));
   Console.WriteLine("addition of 2 string"+o.add("hello","world"));
  }
}
