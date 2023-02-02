#include<iostream>
using namespace std;
int main()
{
int i,n,arr[5],ele;
cout<<"enter the size of array:"<<endl;
cin>>n;
cout<<"enter the array element"<<endl;
for(i=0;i<n;i++)
{
cin>>arr[i];
}
cout<<"enter the search element:"<<endl;
cin>>ele;
for(i=0;i<n;i++)
{ 
  if(arr[i]==ele)
  {
   cout<<"ele found at :"<<i<<endl;
   exit(0);
  }
  }
  cout<<"not found"<<endl;
} 
