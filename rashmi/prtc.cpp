#include<iostream>
using namespace std;
int main()
{
 int i,n,a[5],mid,x;
 int beg=0;
 int end;
 cout<<"enter size"<<endl;
 cin>>n;
 end=n-1;
 cout<<"enter elements:"<<endl;
 for(i=0;i<n;i++)
 {
  cin>>a[i];
  }
 cout<<"enter the search"<<endl;
 cin>>x;
 while(beg<=end)
 {
 mid=(beg+end)/2;
 if(a[mid]==x)
 {
 cout<<"search is found at loc"<<mid<<endl;
 exit(0);
 }
 else if(a[mid]>x)
 {
 end=mid-1;
 }
 else
 {
 beg=mid+1;
 }
 }
 cout<<"element is not found"<<endl;
 }
