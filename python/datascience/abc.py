import cv2  
import numpy as np;  
  
img = cv2.imread(r"/home/user/images/sun.jpg", cv2.IMREAD_GRAYSCALE)  
# Set up the detector with default parameters.  
detector = cv2.SimpleBlobDetector()  
  
# Detecting blobs.  
keypoints = detector.detect(img)  
# Draw detected blobs as red circles.  
# cv2.DRAW_MATCHES_FLAGS_DRAW_RICH_KEYPOINTS ensures the size of the circle corresponds to the size of blob  
im_with_keypoints = cv2.drawKeypoints(img, keypoints, np.array([]), (0, 0, 255),  
                                      cv2.DRAW_MATCHES_FLAGS_DRAW_RICH_KEYPOINTS)  
# Show keypoints  
cv2.imshow("Keypoints", im_with_keypoints)  
cv2.waitKey(0)  
