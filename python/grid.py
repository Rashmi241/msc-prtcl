import numpy as np
import matplotlib.pyplot as plt
 
x=np.array([80,85,90,95,100])
y= np.array([200,300,400,500,600])
plt.title("chart")
plt.xlabel("x axis->")
plt.ylabel("y axis->")

plt.plot(x,y)
plt.grid()
plt.show()

