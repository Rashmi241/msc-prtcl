using System;
class vector
{
 int x,y,z;
 public vector()
 {
 }
 public vector(int a,int b,int c)
 {
 x=a;
 y=b;
 z=c;
 }
 public override string ToString()
 {
 return(+x+" "+y+" "+z+" ");
 }
public static vector operator +(vector v1,vector v2)
{
vector v3=new vector();
v3.x=v1.x+v2.x;
v3.y=v1.y+v2.y;
v3.z=v1.z+v2.z;
return(v3);
}
public static vector operator -(vector v1,vector v2)
{
vector v4=new vector();
v4.x=v1.x-v2.x;
v4.y=v1.y-v2.y;
v4.z=v1.z-v2.z;
return(v4);
}
public static bool operator ==(vector v1,vector v2)
{
if(v1.x==v2.x && v1.y==v2.y && v1.z==v2.z)
{
return(true);
}
else
{
return(false);
}
}
public static bool operator !=(vector v1,vector v2)
{
 return(!(v1==v2));
}
}
class test 
{
public static void Main()
{
vector v1=new vector(1,2,3);
vector v2=new vector(4,5,6);
vector v3=v1+v2; 
vector v4=v2-v1; 
Console.WriteLine("v1="+v1);
Console.WriteLine("v2="+v2);
Console.WriteLine("v3="+v3);
Console.WriteLine("v4="+v4);
if(v1==v2)
{
Console.WriteLine("v1 equal v2");
}
else
{
Console.WriteLine("v1 is not equal v2");
}
}
}



