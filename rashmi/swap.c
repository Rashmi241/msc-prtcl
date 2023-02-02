#include<iostream.h>
using namespace std;
int main()
{
int a,b, temp;
cout<<"enter two number";
cin>>a>>b;
cout<<"display 2 no before swap "<<a<<b<<endl;
temp=a;
a=b;
b=temp;
cout<<"display a number after swap "<<a<<b<<endl;
return 0;
} 
