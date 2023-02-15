#include<iostream>
using namespace std;
struct node 
{
 int data;
 struct node *link;
};
struct node* top=NULL; 
void push()
{
int ele;
cout<<"enter element to insert"<<endl;
cin>>ele;
struct node *temp=(struct node*)malloc(sizeof(struct node)); 
temp->data=ele;
temp->link=top;  
top=temp;
}

void pop()
{
node *temp;
if(top==NULL)
cout<<"stack is empty"<<endl;
else
{
temp=top;
top=top->link;
cout<<" popped element is "<<temp->data<<endl;
free(temp);
}
}
void display()
{
struct node* temp;

if(top==NULL)
{
cout<<"list is empty"<<endl;
}
else
{
cout<<"the content of list\n";
temp=top;
while(temp!=NULL) 
{
cout<<temp->data<<endl;
temp=temp->link;
}
}
cout<<endl;
}
int main()
{
int item,ch;
cout<<"1.push"<<endl;
cout<<"2.pop"<<endl;
cout<<"3.display"<<endl;
cout<<"4.exit"<<endl;
do{
cout<<"enter your choice"<<endl;
cin>>ch;
switch(ch)
{
case 1:
push();
break;
case 2:
pop();
break;
case 3:
display();
break;
case 4:
cout<<"exit"<<endl;
exit(0);

default:
cout<<"invalid choice"<<endl;
break;
}
}
while(ch!=4);
return 0;
}

