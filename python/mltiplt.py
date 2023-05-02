import matplotlib.pyplot as plt
import numpy as np
x=np.array([1,2,3,4,5])
y=np.array([2,4,6,8,9])

plt.subplot(1,2,1)
plt.plot(x,y)
plt.title("income")

x=np.array([10,20,30,40,50])
y=np.array([2,4,6,8,9])

plt.subplot(1,2,2)
plt.plot(x,y)
plt.title("sales")
 
plt.show()
