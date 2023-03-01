#include<iostream>
using namespace std;
int partition(int a[],int l,int h)
{
int i,j,pivot,temp;
pivot=a[l];
i=l+1;
j=l;
while(1)
{
while(i<h && a[i]<=pivot)
i++;
while(a[j]>pivot)
j--;
if(i<j)
{
temp=a[i];
a[i]=a[j];
a[j]=temp;
}
else
{
temp=a[l];
a[l]=a[j];
a[j]=temp;
return j;
}
}
}
void qsort(int a[],int l,int h)
{
int j;
if(l<h)
{
j=partition(a,l,h);
qsort(a,l,j-1);
qsort(a,j+1,h);
}
}
void printArray(int arr[],int n)
{
for(int i=0;i<n;i++)
cout<<arr[i]<<" ";
}
int main()
{
int n,i,a[20];
cout<<"enter the number of elements in the array:"<<endl;
cin>>n;
cout<<"enter the array elements;"<<endl;
for(i=0;i<n;i++)
{
cin>>a[i];
}

//cout<<"array before sorting"<<endl;
//printArray(a,n);
cout<<"array after sorting:"<<endl;
qsort(a,0,n-1);
printArray(a,n);
return 0;
}
