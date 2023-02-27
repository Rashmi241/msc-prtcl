#include<iostream>
using namespace std;
void merge(int a[],int l,int h,int m)
{
 int i=l;
 int j=m+1;
 int k=l;
 int temp[10];
 while(i<=m && j<=h)
 {
  if(a[i]<a[j])
  {
  temp[k]=a[i];
  k++;
  i++;
  }
 else
 {
 temp[k]=a[j];
 k++;
 j++;
 }
 }
 while(i<=m)
 {
 temp[k]=a[i];
 k++;
 i++;
 }
 while(j<=h)
 {
 temp[k]=a[j];
 k++;
 j++;
 }
 
 for(int i=l;i<=h;i++)
 {
 a[i]=temp[i];
 }
}
void mergesort(int a[],int l,int h)
{
 int m;
 if(l<h)
 { 
  m=(l+h)/2;
  mergesort(a,l,m);
  mergesort(a,m+1,h);
  merge(a,l,h,m);
 }
}
int main()
{
int i,n;
 cout<<"enter the size of array"<<endl;
 cin>>n;
 int a[10];
 cout<<"enter the elelments"<<endl;
 for(int i=0;i<n;i++)
 {
 cin>>a[i];
 }
 mergesort(a,0,n-1);
 cout<<"sorted elements are:"<<endl;
 for(int i=0;i<n;i++)
 {
 cout<<a[i]<<" ";
 }
 cout<<endl;
 return 0;
}

 
 
