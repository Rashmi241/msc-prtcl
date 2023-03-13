#include<iostream>
using namespace std;
struct node 
{
int data;
struct node* next;
};  
struct node* head=NULL;

void insert(int newdata)
{
struct node *newnode=(struct node*)malloc(sizeof(struct node));
newnode->data=newdata;
newnode->next=head;
head=newnode;
}
void delete1()
{
if(head==NULL)
cout<<"list is empty"<<endl;
else
{
struct node* ptr;
ptr=head;
head=ptr->next;
free(ptr);
}
}
void display() 
{
if(head==NULL)
cout<<"list is empty"<<endl;
else
{
struct node* ptr;
ptr = head;
while (ptr != NULL) 
{
cout<< ptr->data <<" "<<endl;
ptr = ptr->next;
}
}
}
int main()
{
int newdata; 
int n,i,ch;
cout<<"1.insert\n2.delete\n3.display\n4.exit"<<endl;
while(ch!=4)
{

cout<<"enter your choice:";
cin>>ch;
switch(ch)
{
case 1:
cout<<"enter element to insert"<<endl;
cin>>newdata; 
insert(newdata);
break;
case 2:
delete1();
break;
case 3:
display();
break;

case 4:
cout<<"exit"<<endl;
exit (0);
default:
cout<<"invalid choice"<<endl;
break;
} 
}
return 0; 
}
