# Hand Tracking and Recognition Project

This project is a computer vision and machine learning application that tracks and recognizes hand movements using Flask and Unity. The application uses OpenCV for hand tracking and provides a REST API endpoint for sending hand tracking data to the Unity client. The Unity client listens to the Flask server and uses the hand tracking data to control a virtual hand in the scene.

## Introduction

Hand tracking and recognition has become an increasingly popular area of research and development, with a wide range of potential applications in fields such as robotics, virtual reality, and gaming. This project aims to demonstrate how computer vision and machine learning techniques can be used to track and recognize hand movements in real-time using Flask and Unity.

The Flask application provides an API endpoint for sending hand tracking data to the Unity client, which can be used to control a virtual hand in the Unity scene. The hand tracking data is processed in real-time using OpenCV, which provides a robust and efficient method for detecting and tracking the hand.

The Unity client listens to the Flask server and uses the hand tracking data to control the virtual hand in the scene. The client also provides a user interface for interacting with the virtual environment and visualizing the hand tracking data in real-time.

This project is intended as a proof-of-concept for the use of computer vision and machine learning in hand tracking and recognition, and can be easily extended and modified to fit different use cases and applications.


## Installation

1. Clone the repository:

git clone https://github.com/yourusername/hand-tracking-project.git

2. Install the dependencies:

cd hand-tracking-project
pip install -r requirements.txt

3. Launch the Flask application:

python app.py

4. Open the Unity project in the `UnityProject` directory and press the play button to run the application.

## Usage

1. Launch the Flask application and start the Unity project.
2. Use your hand to make different gestures, such as open and close your hand, make a fist, point, etc.
3. The virtual hand in the Unity scene should move and gesture according to your hand movements.

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

This project was inspired by the work of the OpenCV and MediaPipe communities. Thanks to their contributions, we were able to implement hand tracking and recognition functionality in this project.
