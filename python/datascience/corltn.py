import sklearn
import numpy as np
import  matplotlib.pyplot as plt
import pandas as pd
lst1=[int(x)for x in input("enter the value for x aix:").split()]
lst2=[int(x)for x in input("enter the value for x aix:").split()]
x=pd.Series(lst1)
y=pd.Series(lst2)
corelation=round(y.corr(x),2)
plt.scatter(x,y)
if corelation>0:
   plt.title("+ive corelation")
elif corelation<0 :
   plt.title("-ve corelation")
else :
   plt.title("zero corelation")
#
plt.plot(np.unique(x),np.poly1d(np.polyfit(x,y,1))(np.unique(x)),color="red")
plt.text(max(x),max(y),"corelation coefficient:"+str(corelation),horizontalalignment="right",verticalalignment="top")
plt.xlabel("x-axis")
plt.ylabel("y-axis")
plt.grid()
plt.show()   
   
