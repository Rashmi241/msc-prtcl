from statistics import variance

from fractions import Fraction as fr

"""
x1=(2,12,3,5,6)
x2=(-2,-4,6,3,-1)
x3=(1.2,22.1,3.5,17.5)
"""

print("1.set of positive integer \n2.set of foalting point \n3.both +ve and -ve integers\n4.set of fraction of a number\n5.set of -ve integer") 
while True: 
  ch=int(input("enter your choice:"))
  if ch==1:
     x1=tuple(int(x) for x in input("enter +ve integer").split()) 
     print("variance of x1:",variance(x1))
  elif ch==2: 
     x2=tuple(float(x) for x in input("enter floating point").split())
     print("variance of x2:",variance(x2))
  elif ch==3: 
     x3=tuple(int(x) for x in input("enter both +ve and -ve integer ").split())
     print("variance of x3:",variance(x3))
  elif ch==4: 
     x4=tuple(fr(x) for x in input("enter fractional number").split())
     print("variance of x4:",variance(x4))
  elif ch==5:
     x5=tuple(int(x) for x in input("enter -ve integer").split()) 
     print("variance of x5:",variance(x5))
  else:
     print('exit')
     break 
 
