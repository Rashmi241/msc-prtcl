#include<iostream>
#define n 8 
using namespace std;
void print(int board[n][n])
{

int i,j;
for(i=0;i<n;i++)
{
for(j=0;j<n;j++)
cout<<board[i][j]<<" ";
cout<<endl;
}
}
bool issafe(int board[n][n],int row,int col)
{
int i,j;
for(i=0;i<col;i++)
{
if(board[row][i])
return false;
}
for (i=row,j =col;i >= 0&&j >= 0;i--,j--)
{
if(board[i][j])
return false;
}
for(i=row,j=col;j >=0 && i <n; i++, j--)
{
if (board[i][j])
return false;
} 
return true; 
}

bool solveNQUtil(int board[n][n], int col)
{
int i,j;
if (col >=n)
return true;
for (int i = 0; i < n; i++)
{
if ( issafe(board, i, col) )
{
 board[i][col] = 1;
if (solveNQUtil(board, col + 1) == true)
return true;
board[i][col] = 0;
}
}
return false;
}
bool solveNQ()
{
int board[n][n] = {0};
 if (solveNQUtil(board, 0) == false)
 {
cout<<"Solution does not exist"<<endl;
return false;
}
print(board);
return true;
}
int main()
{
solveNQ();
return 0;
}
