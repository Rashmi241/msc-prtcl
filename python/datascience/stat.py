import statistics
a=[int(x) for x in input("enter the numbers:").split()]
print("1.mean\n2.median\n3.mode\n4.standard deviation\n5.variance\n")
while True:
   ch=int(input("enter your choice"))  
   if ch==1:
     print("mean=",statistics.mean(a))
   elif ch==2:  
     print("median=",statistics.median(a))
   elif ch==3:
     print("mode=",statistics.mode(a))
   elif ch==4:
     print("standard deviation=",statistics.stdev(a))
   elif ch==5:  
     import numpy as np
     print("variance=",np.var(a))
   else:
     print("exit")
     break


