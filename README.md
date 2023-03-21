# Hand Tracking and Recognition Project

This project uses computer vision and machine learning techniques to track and recognize hand movements using Flask and Unity. The Flask application implements hand tracking using OpenCV and provides a REST API endpoint for sending hand tracking data to the Unity client. The Unity client listens to the Flask server and uses the hand tracking data to control a virtual hand in the scene.

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
