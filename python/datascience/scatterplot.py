import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
x=np.random.randn(50)
y1= x*6 +9 
y2= -6*x
y3=np.random.randn(50)
# Plot
plt.rcParams.update({'figure.figsize':(10,8), 'figure.dpi':100})
plt.scatter(x, y1, label=f'y1 Correlation = {np.round(np.corrcoef(x,y1)[0,1], 2)}')
plt.scatter(x, y2, label=f'y2 Correlation = {np.round(np.corrcoef(x,y2)[0,1], 2)}')
plt.scatter(x, y3, label=f'y3 Correlation = {np.round(np.corrcoef(x,y3)[0,1], 2)}')
plt.title('Scatterplot and Correlations')
plt.legend()
plt.show()

