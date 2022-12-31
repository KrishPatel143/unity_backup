from HandTrackingModule import HandDetector
import cv2
import socket

cap = cv2.VideoCapture(0)
cap.set(3, 1280)
cap.set(4, 720)
success, img = cap.read()
h, w, _ = img.shape
detector = HandDetector(detectionCon=0.8, maxHands=2)

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
serverAddressPort = ("127.0.0.1", 5051)
serverAddressPort2 = ("127.0.0.1", 5052)

pdata = []
while True:
    success, img = cap.read()
    hands, img = detector.findHands(img)
    data = []

    if hands:
        hand = hands[0]
        lmList = hand["lmList"]
        if len(lmList) != 0:
            fingers = detector.fingersUp(hand)

            if len(hands) == 2:
                hand1 = hands[1]
                fingers1 = detector.fingersUp(hand1)
                if hand["type"] == "Right":
                    data = fingers
                    data.extend(fingers1)
                else:
                    data = fingers1
                    data.extend(fingers)
            else:
                data = fingers

        if(data != pdata):
            print(data)
            # sock.sendto(str.encode(str(data)), serverAddressPort)
            sock.sendto(str.encode(str(data)), serverAddressPort2)

            pdata = data
    cv2.imshow("Image", img)
    cv2.waitKey(1)