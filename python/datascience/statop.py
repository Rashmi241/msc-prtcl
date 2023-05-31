import pandas as pd
import matplotlib.pyplot as plt
import statistics as st
# Sample data
lst1=[int(x)for x in input("enter value of year ").split()]
lst2=[int(x) for x in input(" enter the sales ").split()]
x=pd.Series(lst1)
y=pd.Series(lst2)

#Calculate mean, median, and mode
mean = st.mean(y)
median = st.median(y)
mode = st.mode(y)
# Print the results
print("Mean:", mean)
print("Median:", median)
print("Mode:", mode)
# Plotting the data
plt.bar(x,y,edgecolor='black')
plt.axhline(mean, color='red', linestyle='--', label='Mean')
plt.axhline(median, color='green', linestyle='--', label='Median')
plt.axhline(mode, color='blue', linestyle='--', label='Mode')
plt.xlabel('Year')
plt.ylabel('Sales')
plt.title('Distribution with Mean, Median, and Mode')
plt.legend()
# Display the plot
plt.show()

