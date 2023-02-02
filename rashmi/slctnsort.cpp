#include<iostream>
using namespace std;
void sort(int a[],int n)
{
int min,ele,pos;
for(int i=0;i<n-1;i++)
 {
  min=i;
  for(int j=i+1;j<n;j++)
   {
   if(a[j]<a[min])
    min=j;
    pos=a[i];
    a[i]=a[min];
    a[min]=pos;
    }

  }
}
 int main()
 {
  int a[5],n;
   int i;
  cout<<"enter the size of array"<<endl;
  cin>>n;
  cout<<"enter array elements:"<<endl;
   for(i=0;i<n;i++)
   {
   cin>>a[i];
   }
  sort(a,n);
  cout<<"sorted array are:"<<endl;
  for(i=0;i<n;i++)
  {
  cout<<a[i]<<""<<endl;
  }
  return 0;
}

