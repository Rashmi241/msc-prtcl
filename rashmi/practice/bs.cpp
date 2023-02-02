#include<iostream>
using namespace std;
void bubblesort(int a[],int n)
{
 int i,j,temp;
 for(i=0;i<n;i++)
 {
   for(j=0;j<n-1;j++)
    {
      if(a[j]>a[j+1])
       {
        temp=a[j];
        a[j]=a[j+1];
        a[j+1]=temp;
      }
    }
  }
}
 int main()
 {
 int i,n,a[5];
 cout<<"enter the array size"<<endl;
 cin>>n;
 cout<<"enter the array elements:"<<endl;
 for(i=0;i<n;i++)
 {
 cin>>a[i];
 }
 bubblesort(a,n);
cout<<"sorted array are:"<<endl;
for(i=0;i<n;i++)
{
 cout<<a[i];
 cout<<endl;
}
}

