#include<iostream>
using namespace std;   
void insertionsort(int a[],int n)  
{
int i,j,temp,key;
for(i=0;i<n;i++)
  {
   key=a[i];
  j=i-1;
  while(j>=0 && a[j]>key)
   {
    a[j+1]=a[j];
    j=j-1;
   }
   a[j+1]=key;
  }
}
int main()
{
int a[5],n,i;
cout<<"enter the size of array"<<endl;
cin>>n;
cout<<"enter the array elements:";       
for(i=0;i<n;i++)
 {
 cin>>a[i];
 }
 insertionsort(a,n);
 cout<<"sorted array :"<<endl;
for(i=0;i<n;i++)
{
 cout<<a[i]<<endl; 
}
return 0; 
}
