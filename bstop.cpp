#include<iostream>
using namespace std;
struct treenode
{
int data;
struct treenode *left,*right;
};
treenode* insert(treenode* r,int key)
{
if(r==NULL)
{
r=new treenode;
r->data=key;
r->left=r->right=NULL;
}
else if(key< r->data)
r->left=insert(r->left,key);
else if(key> r->data)
r->right=insert(r->right,key);
else
cout<<"duplicate node\n";
return r;
}
treenode* successor(treenode* r)
{
treenode* cur=r;
while(cur && cur->left!=NULL)  
cur=cur->left;
return cur;
}
treenode* deletenode(treenode* r,int key)
{
if(r==NULL)
return r;
else if(key<r->data)
r->left=deletenode(r->right,key);
else if(key>r->data)
r->right=deletenode(r->right,key);
else
{
if(r->left==NULL && r->right==NULL)
return NULL;
else if(r->left==NULL)
{
treenode* temp=r->right;
free(r);
return temp; 
}
else if(r->right==NULL)
{
treenode* temp=r->left;
free(r);
return temp; 
}
treenode* temp=successor(r->right);
r->data=temp->data;
r->right=deletenode(r->right,temp->data);   
}
return r;
}
bool search(treenode* r,int key)
{
if(r==NULL)
return false;
if(r->data==key)
return true;
else if(key<r->data)
return search(r->left,key); 
else
return search(r->right,key);
}
void display(treenode* r)
{
if(r!=NULL)
{
display(r->left);
cout<<" "<<r->data<<" ";
display(r->right);
}
} 
int main()
{
int ch,key,x;
bool found;
treenode* r=NULL;
do
{
cout<<"\n1 insert \n2.search \n3.delete \n4.display\n5.exit"<<endl; 
cout<<"enter choice:"<<endl;
cin>>ch;
switch(ch)
{
case 1:
cout<<"enter the node to insert:"<<endl;
cin>>x;
r=insert(r,x);
break;
case 2:
cout<<"enter the key item"<<endl;
cin>>key;
found=search(r,key); 
if(found)
cout<<"item found \n";
else
cout<<"not found \n";
break;
case 3:
cout<<"enter the node to delete";
cin>>key; 
r=deletenode(r,key);
break;
case 4:
cout<<"tree nodes are"<<endl;   
display(r);
break;
case 5:
exit;
default:
cout<<"invalid choice"<<endl;

break;
}} while(ch!=6);
return 0;
}




