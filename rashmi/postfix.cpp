#include<iostream>
using namespace std;
int stack[30];
char postfix[30];
int top=-1;
void push(int);
char pop();
int evalpost();
void push(int symbol)
{
stack[++top]=symbol;
}
char pop()
{
int symbol;
symbol=stack[top--];
return symbol;
}
int evalpost()
{
int symbol;
int i=0,op1,op2;
while((symbol=postfix[i++])!='\0')
{
if(isalnum(symbol))
push(symbol-'0');
else
{
op2=pop();
op1=pop();
switch(symbol)
{
case '+':push(op1+op2);
break;
case '-':push(op1-op2);
break;
case '*':push(op1*op2);
break;
case '/':if(op2!=0)
{
push(op1/op2);
break;
}
else
{
cout<<"out loop";
return 0;
}
}
}
}
return(pop());
}
int main()
{
int val;
cout<<"enter postfix expression\n";
cin>>postfix;
val=evalpost();
cout<<"evaluated expression:\n"<<val;
}