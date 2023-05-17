from math import *
a=[int(x) for x in input("enter the numbers:").split()]
#while True:
print("1.sum \n2.minimum\n3.maximum.\n4.round\n5.square root\n6.average\n ")
while True:
    ch=int(input("enter your choice:"))
    if ch==1:
        print("sum:",sum(a))
    elif ch==2:
        print("min:",min(a))
    elif ch==3:
        print("max:",max(a))
    elif ch==4: 
        b=float(input("enter number to find round:"))
        print("Round of a number:",round(b))
    elif ch==5:  
        c=int(input("enter number to find squareroot:"))
        print("squareroot of a number:",sqrt(c))
    elif ch==6:
        print("average of elements:",sum(a)/len(a))    
    else:
        print("exit") 
        break 
 

