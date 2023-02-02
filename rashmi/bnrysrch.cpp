#include<iostream>
using namespace std;
int main()
{
  int n,beg,mid,end,pos;
  beg=0;
  int i,x,arr[5];
  cout<<"enter the no. of element in array"<<endl;
  cin>>n;
 end=n-1; 
  cout<<"enter the element:"<<endl;
  for(i=0;i<n;i++)
  {
   cin>>arr[i];
  }
  cout<<"enter the search element"<<endl;
  cin>>x; 
  while(beg<=end)
  {
  mid=(beg+end)/2;
    if(arr[mid]==x)
     {
      cout<<"serach element found at position:"<<mid<<endl;
      exit(0);
     }
       else if(arr[mid]>x)
          {
           end=mid-1;
          }
         else 
          {
          beg=mid+1;
          }
  }
  cout<<" element is not found. "<<endl;  
} 
