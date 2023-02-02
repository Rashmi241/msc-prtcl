#include<iostream.h>
int top=-1,n=3,i,ele;
int s[3];
void insert()
{
if(top==n-1)
  {
   cout<<"stack is empty";
  }
  else
  s[top]=ele;
 top++
 }
void disp:wq
k
int main()
{
int i,ele,ch;
cout<<1.push\n 2.pop \n3.display \n 4.exit"<<endl
cout<<"enter your choice"<<endl;
cin>>ch;
while(ch!=4)
{
switch(ch)
{
case 1:
      cout<<"enter ele to push"<<endl;
      cin>>ele;
      insert();
      break;
case 4:
      exit(0);
case 2:
display();
break;
}
}
return 0;
} 



 
