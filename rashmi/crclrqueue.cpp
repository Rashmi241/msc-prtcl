#include<iostream>
using namespace std;
int front=-1;  
int rear=-1;
int i,q[3],n=3;
void enqueue(int ele)
  {
  if((rear+1)%n==front)  
   {
    cout<<"queue is overflow "<<endl;   
   }
   else
   {
  if(front==-1)   
   front=0;
   rear=(rear+1)%n;
   q[rear]=ele;
   }
  }
void dqueue(int ele)
{
  if(front==-1)
   {
    cout<<"queue is empty."<<endl;
   }
    else
   {
   cout<<q[front]<<" is deleted"<<endl;
    if(front==rear)
    front=rear=-1;
     else
    front=(front+1)%n;
   }
}

 void display()
  {
   if(front==-1)
    {
     cout<<"queue is empty"<<endl;
    }
     else
     {
     cout<<"elements of queue are:"<<endl;
     if(front<=rear)
     {
     for(i=front;i<=rear;i++)
      cout<<q[i]<<" "; 
     }
     else
     {
     for(i=front;i<n;i++)
     cout<<q[i]<<" ";
     for(i=0;i<=rear;i++)
     cout<<q[i]<<" ";
     }
    }
   }
int main() 
{
 int ele,ch=0;
 while(ch<=3)
 {
 cout<<"1.enqueue"<<endl;
 cout<<"2.dequeue"<<endl;
 cout<<"3.display"<<endl;
 cout<<"enter your choice:";
 cin>>ch;
 switch(ch)
  {
   case 1:
         cout<<"enter the element to insert:"<<endl;
         cin>>ele;
         enqueue(ele);
         break;
   case 2:
         dqueue(ele);
         break;
   case 3:
         display();
         break;
   default:
         cout<<"invalid choice!"<<endl;
 }
}
return 0;
} 



