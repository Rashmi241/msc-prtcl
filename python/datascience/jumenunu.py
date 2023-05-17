{
 "cells": [
  {
   "cell_type": "code",
   "execution_count": 1,
   "id": "7d62b735",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "enter the numbers:2 4 5 6 12\n",
      "1.mean\n",
      "2.median\n",
      "3.mode\n",
      "4.standard deviation\n",
      "5.variance\n",
      "\n",
      "enter your choice1\n",
      "mean= 5.8\n",
      "enter your choice2\n",
      "median= 5\n",
      "enter your choice3\n",
      "mode= 2\n",
      "enter your choice4\n",
      "standard deviation= 3.7682887362833544\n",
      "enter your choice5\n",
      "variance= 11.360000000000001\n",
      "enter your choice6\n",
      "exit\n"
     ]
    }
   ],
   "source": [
    "import statistics\n",
    "a=[int(x) for x in input(\"enter the numbers:\").split()]\n",
    "print(\"1.mean\\n2.median\\n3.mode\\n4.standard deviation\\n5.variance\\n\")\n",
    "while True:\n",
    "   ch=int(input(\"enter your choice\"))  \n",
    "   if ch==1:\n",
    "     print(\"mean=\",statistics.mean(a))\n",
    "   elif ch==2:  \n",
    "     print(\"median=\",statistics.median(a))\n",
    "   elif ch==3:\n",
    "     print(\"mode=\",statistics.mode(a))\n",
    "   elif ch==4:\n",
    "     print(\"standard deviation=\",statistics.stdev(a))\n",
    "   elif ch==5:  \n",
    "     import numpy as np\n",
    "     print(\"variance=\",np.var(a))\n",
    "   else:\n",
    "     print(\"exit\")\n",
    "     break\n"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "id": "865ac461",
   "metadata": {},
   "outputs": [],
   "source": []
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "id": "c3defde8",
   "metadata": {},
   "outputs": [],
   "source": []
  }
 ],
 "metadata": {
  "kernelspec": {
   "display_name": "Python 3 (ipykernel)",
   "language": "python",
   "name": "python3"
  },
  "language_info": {
   "codemirror_mode": {
    "name": "ipython",
    "version": 3
   },
   "file_extension": ".py",
   "mimetype": "text/x-python",
   "name": "python",
   "nbconvert_exporter": "python",
   "pygments_lexer": "ipython3",
   "version": "3.8.10"
  }
 },
 "nbformat": 4,
 "nbformat_minor": 5
}
