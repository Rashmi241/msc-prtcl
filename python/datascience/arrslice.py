import numpy as np
rows = int(input("Enter the number of rows: "))
cols = int(input("Enter the number of columns: "))
arr = np.empty((rows, cols))
for i in range(rows):
    for j in range(cols):
        arr[i][j] = int(input("Enter value for arr["+str(i)+"]["+str(j)+"]: "))
srow = int(input("Enter the starting row index for slicing: "))
erow = int(input("Enter the ending row index for slicing: "))
scol = int(input("Enter the starting column index for slicing: "))
ecol = int(input("Enter the ending column index for slicing: "))
sliced_arr = arr[srow:erow, scol:ecol]
print("Original Array:\n",arr)
print("\nSliced Array:\n",sliced_arr)
ns=int(input("Enter number of parts the array to be split:"))
if arr.shape[0]%ns==0:
 print("Array after vertical splitting:\n",np.vsplit(arr,ns))
else:
 print("Cannot equally divide the array vertically")
if arr.shape[1]%ns==0:
 print("Array after Horizontal  splitting:\n",np.hsplit(arr,ns))
else:
 print("Cannot equally divide the array horizontally")
 
 """
Enter the number of rows: 2
Enter the number of columns: 4
Enter value for arr[0][0]: 7
Enter value for arr[0][1]: 8
Enter value for arr[0][2]: 9
Enter value for arr[0][3]: 4
Enter value for arr[1][0]: 1
Enter value for arr[1][1]: 2
Enter value for arr[1][2]: 3
Enter value for arr[1][3]: 4
Enter the starting row index for slicing: 0
Enter the ending row index for slicing: 1
Enter the starting column index for slicing: 1
Enter the ending column index for slicing: 3
Original Array:
 [[7. 8. 9. 4.]
 [1. 2. 3. 4.]]

Sliced Array:
 [[8. 9.]]
Enter number of parts the array to be split:2
Array after vertical splitting:
 [array([[7., 8., 9., 4.]]), array([[1., 2., 3., 4.]])]
Array after Horizontal  splitting:
 [array([[7., 8.],
       [1., 2.]]), array([[9., 4.],
       [3., 4.]])]
"""
