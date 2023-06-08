import numpy as np
lst1=[int(x) for x in input('Enter values:').split()]
lst2=[int(x) for x in input('Enter values:').split()]
arr1=np.array(lst1)
arr2=np.array(lst2)
print("Array is of type                          :", type(arr1))
print("No. of dimensions                         :", arr1.ndim)
print("Shape of array                            :", arr1.shape)
print("Size of array                             :", arr1.size)
print("Array stores elements of type             :", arr1.dtype)
print("Number of bytes occupied by the array     :",arr1.nbytes)
print("Array from 1 to 3rd index:",arr1[1:4])
print("Array from 0th  index:",arr1[0:])
print("Array from 0 to 4th index step by 2:",arr1[0:5:2])
print("Array from 0 to 3rd index:",arr1[:4])
print("Array element at -4 index:",arr1[-4])
print("Array from -4 to -1:",arr1[-4:-1])

arr3=np.concatenate((arr1,arr2))
print("Array after concatenation:\n",arr3)

m,n = [int(x) for x in input("Enter shape values for reshaping:").split()]
arr1=arr3.reshape(m,n)
print("Array after Reshaping: \n",arr1)
print("No. of dimensions after reshaping: ", arr1.ndim)
print("Shape of array after reshaping: ", arr1.shape)
print("Array after vertical splitting:\n ",np.vsplit(arr1,2))
print("Array after Horizontal  splitting:\n ",np.hsplit(arr1,2))

