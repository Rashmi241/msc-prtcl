#include<iostream>
using namespace std;
struct node
{
   int ndata;
   struct node *left,*right;
  node(int x)
   {
           ndata = x;
            left = NULL;
            right = NULL;
   }
};
node *newnode(int ndata)
{
   node* temp=new node;    
   temp->ndata=ndata;
   temp->left=temp->right=NULL; 
   return temp;
}
void inorder(node* root)
{
  if(root!=NULL)
  {
   inorder(root->left);
   cout<<"\n"<<root->ndata;
   inorder(root->right);    
  }
 return ;
}
void preorder( node* root)
{
 if(root!=NULL)
 {
  cout<<"\n"<<root->ndata;
  preorder(root->left);
  preorder(root->right);
 }
return ;
}
void postorder(node* root) 
{
 if(root!=NULL)
 {
 postorder(root->right);
 postorder(root->left);
 cout<<"\n"<<root->ndata;
 }
return;
}
node* insertion(node* root,int x)
{
  if(root==NULL)
  {
  node *temp=new node(x);
  return temp;
  }
  if(root->ndata>x)
  { 
  root->left=insertion(root->left,x);
  }
  else
  {
  root->right==insertion(root->right,x);            
  }
  return root;
}
int main()
{
int ch,x;  
node* root;
bool found;
cout<<"1.insertion \n 2.inorder \n 3.preorder \n 4.postorder \n 5.exit"<<endl;
while(ch!=5) 
{
cout<<"enter your choice:";
cin>>ch;
switch(ch)
{
case 1:
      cout<<"enter the node to insert:"<<endl;
      cin>>x;
      root=insertion(root,x);
      break;
case 2:
      inorder(root);
      break;
case 3:
      preorder(root);  
      break;
case 4:
      postorder(root);
      break;
case 5:
      cout<<"exit"<<endl;
      exit;
default :
       cout<<"invalid choice"<<endl; 
}
}
return 0;
}
