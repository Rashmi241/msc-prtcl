#include<iostream>
using namespace std;
int main()
{
 int arr[5],size,ele,i;
 cout<<"size of array"<<endl;
 cin>>size; 
 cout<<"enter the array element:"<<endl;
 for(i=0;i<size;i++)
  {
   cin>>arr[i]; 
  } 
  cout<<"enter search element"<<endl;
  cin>>ele;
  for(i=0;i<size;i++)
   {
    if(ele==arr[i])
    {
    cout<<"element found at location:"<<i<<endl;
    exit(0);            
    }
    }
cout<<"search element is not found in location";    
 }
