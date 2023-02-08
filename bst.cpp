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
void inorder(treenode* r)
{
  if(r!=NULL)
  {
   inorder(r->left);
   cout<<"\n"<< r->data;
   inorder(r->right);    
  }
 return ;
}
void preorder( treenode* r)
{
 if(r!=NULL)
 {
  cout<<"\n"<<r->data;
  preorder(r->left);
  preorder(r->right);
 }
return ;
}
void postorder(treenode* r) 
{
 if(r!=NULL)
 {
 postorder(r->right);
 postorder(r->left);
 cout<<"\n"<<r->data;
 }
return;
}
int main()
{
int ch,x;
treenode* r=NULL;
do
{
cout<<"\n1.insrtion\n2.preorder\n3.postorder\n4.inorder\n5.exit"<<endl; 
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
preorder(r);
break;
case 3:
postorder(r);
break;
case 4:
inorder(r);
break;
case 5:
exit;
default:
cout<<"invalid choice"<<endl;

break;
}} while(ch!=5);
return 0;
}


