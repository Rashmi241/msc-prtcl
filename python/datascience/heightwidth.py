{
 "cells": [
  {
   "cell_type": "code",
   "execution_count": 4,
   "id": "592319e5",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "width: 193\n",
      "height: 261\n"
     ]
    }
   ],
   "source": [
    "from PIL import Image\n",
    "filepath='/home/user/rashmi/images/sun.jpg'\n",
    "image=Image.open(filepath)\n",
    "width=image.width\n",
    "height=image.height\n",
    "print('width:',width)\n",
    "print('height:',height)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "id": "f96efc8d",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "Number of Channel is: 3\n"
     ]
    }
   ],
   "source": [
    "import cv2\n",
    "import numpy\n",
    "img = cv2.imread(\"/home/user/grey.png\")\n",
    "print('Number of Channel is: ' + str(img.ndim))\n",
    "cv2.imshow(\"Channel\", img)\n",
    "cv2.waitKey()\n",
    "cv2.destroyAllWindows()"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 1,
   "id": "a818d5ff",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "Number of Channel is: 3\n"
     ]
    }
   ],
   "source": [
    "import cv2\n",
    "import numpy\n",
    "img = cv2.imread(\"/home/user/grey.png\")\n",
    "print('Number of Channel is: ' + str(img.ndim))\n",
    "cv2.imshow(\"Channel\", img)\n",
    "cv2.waitKey()\n",
    "cv2.destroyAllWindows()"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "id": "ad1dd796",
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
