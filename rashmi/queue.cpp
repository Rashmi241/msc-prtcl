#include<iostream>
using namespace std;
int queue[3],n=3;
int front=-1;
int rear=-1;
void enqueue(int ele)
{
    if(rear==n-1)
    cout<<"queue overflow!"<<endl;
    else
    {
        if(front==-1)
        front=0;
        cout<<"enter the element to insert"<<endl;
        cin>>ele;
        rear=rear+1;
        queue[rear]=ele;
    }
}
void dequeue(int ele)
{
    if(front==-1)
    {
        cout<<"queue is empty.."<<endl;
    }
    else
    {
cout<<"element deleted from queue is "<<queue[front]<<endl;
if(front==rear)
front=rear=-1;
else
front=front+1;
    }
}
void Display()
{
    if(front==-1)
    {
        cout<<"queue is empty.."<<endl;
    }
    else
    {
     cout<<"elements are:"<<endl;
     for(int i=front;i<=rear;i++)
     cout<<queue[i]<<" "<<endl;
    }
}
int main()
{
    int ch,ele;
   while(ch!=4)
    {
    cout<<"1)enqueue"<<endl;
    cout<<"2)dequeue"<<endl;
    cout<<"3)display"<<endl;
    cout<<"4)exit"<<endl;
        cout<<"enter your choice"<<endl;
        cin>>ch;
        switch(ch)
        {
            case 1:enqueue(ele);
            break;
            case 2:dequeue(ele);
            break;
            case 3:Display();
            break;
            case 4:
                  exit(0);
            default:
            cout<<"invalid choice"<<endl;
            break;
        }
     }
}
