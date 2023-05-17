print("enter the string")
s=input("string")
def reverse(s):
	str = ""
	for i in s:
		str = i + str
	return str



print("The original string is : ", end="")
print(s)

print("The reversed string is : ", reverse(s))
#print(reverse(s))

