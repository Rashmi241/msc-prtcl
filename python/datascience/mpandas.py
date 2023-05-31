import numpy as np
import pandas as pd
df=pd.read_csv("new.csv")
print("salary data set\n",df)
print("missing data\n",df.isna())
print("filter bsed on coloumn\n",df[df.isnull().any(axis=1)])
print("sum up the missing value\n",df.isnull().sum())
"""
output:
salary data set
    ID  Gender   Salary country  company
0   1    male  15000.0   india   google
1   2  female  45000.0   india      NaN
2   3     NaN  12000.0  london   google
3   4  female      NaN   india   google
4   5  female  78000.0   nepal    cisco
5   6     NaN  11000.0   india  alibaba
6   7    male  15000.0   india      NaN
7   8  female      NaN   india      NaN
missing data
       ID  Gender  Salary  country  company
0  False   False   False    False    False
1  False   False   False    False     True
2  False    True   False    False    False
3  False   False    True    False    False
4  False   False   False    False    False
5  False    True   False    False    False
6  False   False   False    False     True
7  False   False    True    False     True
filter bsed on coloumn
    ID  Gender   Salary country  company
1   2  female  45000.0   india      NaN
2   3     NaN  12000.0  london   google
3   4  female      NaN   india   google
5   6     NaN  11000.0   india  alibaba
6   7    male  15000.0   india      NaN
7   8  female      NaN   india      NaN
sum up the missing value
 ID         0
Gender     2
Salary     2
country    0
company    3
dtype: int64
"""
df.dropna(inplace=True)
print(df)
"""
   ID  Gender   Salary country company
0   1    male  15000.0   india  google
1   2  female  45000.0   india    tata
4   5  female  78000.0   nepal  google
"""
df["Salary"].fillna(20000,inplace=True)
print(df)
"""
   ID  Gender   Salary country  company
0   1    male  15000.0   india   google
1   2  female  45000.0   india      NaN
2   3     NaN  12000.0  london   google
3   4  female  20000.0   india   google
4   5  female  78000.0   nepal    cisco
5   6     NaN  11000.0   india  alibaba
6   7    male  15000.0   india      NaN
7   8  female  20000.0   india      NaN
"""
df=pd.read_csv("new.csv")
print('missing data\n',df.isnull())
"""
missing data
       ID  Gender  Salary  country  company
0  False   False   False    False    False
1  False   False   False    False     True
2  False    True   False    False    False
3  False   False    True    False    False
4  False   False   False    False    False
5  False    True   False    False    False
6  False   False   False    False     True
7  False   False    True    False     True
"""
gender=pd.isnull(df["Gender"])
print(gender)
"""
0    False
1    False
2     True
3    False
4    False
5     True
6    False
7    False
Name: Gender, dtype: bool
"""
print("non missing data\n",df.notnull())
"""
non missing data
      ID  Gender  Salary  country  company
0  True    True    True     True     True
1  True    True    True     True    False
2  True   False    True     True     True
3  True    True   False     True     True
4  True    True    True     True     True
5  True   False    True     True     True
6  True    True    True     True    False
7  True    True   False     True    False
"""
print("drop missing data\n",df.company.dropna())
df.dropna()
"""
drop missing data
 0     google
2     google
3     google
4      cisco
5    alibaba
Name: company, dtype: object
ID	Gender	Salary	country	company
0	1	male	15000.0	india	google
4	5	female	78000.0	nepal	cisco
"""
df.dropna(axis=1)
print(df)
"""
   ID  Gender   Salary country  company
0   1    male  15000.0   india   google
1   2  female  45000.0   india      NaN
2   3     NaN  12000.0  london   google
3   4  female      NaN   india   google
4   5  female  78000.0   nepal    cisco
5   6     NaN  11000.0   india  alibaba
6   7    male  15000.0   india      NaN
7   8  female      NaN   india      NaN
"""
new_df=df.dropna(axis=0,how="any")
print(new_df)
"""
   ID  Gender   Salary country company
0   1    male  15000.0   india  google
4   5  female  78000.0   nepal   cisco
"""
df=pd.read_csv("new.csv")
print("fill missing data",df.fillna(0))
"""
fill missing data    ID  Gender   Salary country company
0   1    male  15000.0   india  google
1   2  female  45000.0   india       0
2   3       0  12000.0  london  google
3   4  female      0.0   india  google
4   5  female  78000.0   nepal   cisco
"""
print("missing data\n",df.fillna(method='pad'))
"""
missing data
    ID  Gender   Salary country company
0   1    male  15000.0   india  google
1   2  female  45000.0   india  google
2   3  female  12000.0  london  google
3   4  female  12000.0   india  google
4   5  female  78000.0   nepal   cisco
"""
print("fill missing data\n",df.fillna(method="bfill"))
"""
fill missing data
    ID  Gender   Salary country company
0   1    male  15000.0   india  google
1   2  female  45000.0   india  google
2   3  female  12000.0  london  google
3   4  female  78000.0   india  google
4   5  female  78000.0   nepal   cisco
"""
 print("fill missing data\n",df["Gender"].fillna("nogender",inplace=True))
 """
fill missing data
 None
 """
print(df.replace(to_replace='google',value='tata'))
"""
   ID    Gender   Salary country company
0   1      male  15000.0   india    tata
1   2    female  45000.0   india     NaN
2   3  nogender  12000.0  london    tata
3   4    female      NaN   india    tata
4   5    female  78000.0   nepal   cisco
"""
print(df.interpolate(method="linear",limit_direction='forward'))
"""
   ID    Gender   Salary country company
0   1      male  15000.0   india  google
1   2    female  45000.0   india     NaN
2   3  nogender  12000.0  london  google
3   4    female  45000.0   india  google
4   5    female  78000.0   nepal   cisco
​"""

