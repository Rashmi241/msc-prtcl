#include<iostream>
using namespace std;
struct node
{
int data;
struct node *link;
};
struct node* front=NULL;
struct node* rear=NULL;
void insert()
{
node *cur;
int item;
struct node* temp=(struct node*)malloc(sizeof(struct node));
cout<<"enter the node insert;"<<endl;
cin>>item;
temp->link=NULL;
temp->data=item;
if(front==NULL)
front=temp;
else
{
cur=front;
while(cur->link!=NULL)
 {
 cur=cur->link;
 }
cur->link=temp;
}
}
void Delete()
{
node *temp;
if(front==NULL)
cout<<"queue empty:"<<endl;
else
{
temp=front;
front=front->link;
cout<<"the deleted item is "<<temp->data<<endl;
free(temp);
}
}
void display()
{
node *temp;
if(front=NULL)
cout<<"queue is empty"<<endl;
else
{
cout<<"the elements in queue are"<<endl;
temp=front;
while(temp!=NULL)
{
cout<<temp->data<<" ";
temp=temp->link;
}
}
}

int main()
{
int ch;
cout<<"1.insert"<<endl;
cout<<"2.delete"<<endl;
cout<<"3.display"<<endl;
cout<<"4.exit"<<endl;
do
{
cout<<"enter your choice"<<endl;
cin>>ch; 
switch(ch)
{
case 1:
insert();
break;
case 2:
Delete();
break;
case 3:
display();
break;
case 4:
cout<<"exit";
break;
default:
cout<<"invalid choice";
break;
}
}while(ch!=4);
return 0;
}
