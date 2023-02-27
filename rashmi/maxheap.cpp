#include<iostream>
using namespace std;
void heapsub(int a[],int n,int i)
{ int largest =i;
int l=2*i+1;
int r=2*i+2;
if(r<n&&a[r]>a[largest])
largest =r;
if(l<n&&a[l]>a[largest])
largest =l;
if(largest!=i)
{
swap(a[i],a[largest]);
heapsub(a,n,largest);
}
}
void heapsort(int a[],int n)
{
for(int i=n/2-1;i>=0;i--)
heapsub(a,n,i);
for(int i=n-1;i>=0;i--)
{
swap(a[0],a[i]);
int temp=a[i];
for(int j=i;j<n;j++)
a[j]=a[j+1];
a[n-1]=temp;
heapsub(a,i,0);
}
}
void display(int a[],int n)
{
for (int i=0;i<n;++i)
cout<<a[i]<<" ";
cout<<endl;
}
int main()
{
int n,a[10];
cout<<"enter the number of element hespsub:"<<endl;
cin>>n;
cout<<"enter the  element heaspsub:"<<endl;
for(int i=0;i<n;i++)
cin>>a[i];
heapsort(a,n);
cout<<"after heapsub the sorted array is"<<endl;
display(a,n);
return 0;
}
