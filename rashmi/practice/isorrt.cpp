 #include<iostream>
using namespace std;
void isort(int a[] ,int n)
{
  int i,j,key;
  for(i=0;i<n;i++)
  {
  key=a[i];
  j=i-1;
  while(j>=0 && a[j]>key)
  {
   a[j+1]=a[j];
   j=j-1;
  }
  a[j+1]=key;
  }
}
int Main()
  { 
   int a[5];
   int n,i;
   cout<<"enter the size of array"<<endl;
   cin>>n;
   cout<<"enter the array element:"<<endl;
   for(i=0;i<n;i++)
   {
  cin>>a[i];
   }
   cout<<"sorted element are:"<<endl;
   isort(a,n); 
   for(i=0;i<n;i++)
{
   cout<<a[i];
}
return 0; 
}
