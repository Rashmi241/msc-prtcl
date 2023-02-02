#include<iostream>
using namespace std;
int main()
{
int x,n=0;
cout<<"enter a number:"<<endl;
cin>>x;
while(x!=0)
{
n=n+(x%10);
x=x/10;
cout<<"sum of degit in a number"<<x<<endl;   
}
}
