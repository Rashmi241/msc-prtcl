import numpy as np
import matplotlib.pyplot as plt
from scipy.stats import norm
x=np.arange(-3,3,0.002)
plt.plot(x,norm.pdf(x,0,1))
plt.title("normal curve")
plt.xlabel("X-axis")
plt.ylabel("Y-axis")
plt.grid()
plt.show()
