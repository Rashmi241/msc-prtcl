using System;
namespace prgm
{ 
  class sort
  {
public static void Main(string[] args)
{ 
int[] array={2,1,4,3,7};     
Array.Sort(array);
foreach (int i in array)
{
Console.WriteLine(i);
}
}
} 
}
