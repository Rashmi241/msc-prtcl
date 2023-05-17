import matplotlib.pyplot as plt
import numpy as np
x=np.array([5,7,8,7,2,17,2,9,4,11,12])
y=([99,86,87,88,111,86,103,87,94,100,102])
colors=np.array([0,10,20,30,40,50,60,70,80,45,25])
plt.scatter(x,y,c=colors,cmap='viridis')
plt.show()
