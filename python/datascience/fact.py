num=6
fact=1
if num<0:
 print("factorial does not exist for -ve number")
elif num==0:
  print("the facytorial of 0 is 1") 
else:
 for i in range(1,num+1):
  fact=fact*i
print("factorial of",num,"is",fact)
  
  
  
  
