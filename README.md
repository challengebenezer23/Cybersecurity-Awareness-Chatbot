Cybersecurity Awareness Chatbot
Overview

The Cybersecurity Awareness Chatbot is a console-based application developed in C# that aims to educate users about fundamental cybersecurity practices. The application provides an interactive environment where users can learn about topics such as password security, phishing, and safe browsing.

The chatbot integrates both functional and visual features, including a voice greeting, ASCII-based interface design, and structured user interaction. The system demonstrates the application of object-oriented programming principles, input validation, and user-centered design.

Objectives

The primary objectives of this project are:

To develop a console application that accepts and processes user input
To implement string manipulation techniques for handling user queries
To apply automatic properties within a structured class design
To provide basic cybersecurity education through an interactive interface
To integrate multimedia elements such as audio playback and ASCII graphics
To maintain clean, modular, and readable code using multiple classes
Features

The application includes the following core features:

Voice Greeting

A pre-recorded audio message in WAV format is played when the application starts, providing a welcoming introduction to the user.

ASCII Interface

The chatbot displays a cybersecurity-themed ASCII header to enhance the visual presentation within the console environment.

User Interaction

The system prompts the user to enter their name and personalizes responses accordingly. It provides a structured menu system that allows users to select topics for learning.

Educational Content

The chatbot delivers detailed information on key cybersecurity topics, including:

Password Safety
Phishing Awareness
Safe Browsing Practices
Input Validation

The application validates user input to prevent errors and ensure meaningful interaction. Invalid or empty inputs are handled gracefully with appropriate feedback.

Enhanced Console Interface

The user interface is improved through the use of formatted text, color differentiation, spacing, and simulated typing effects to create a more engaging experience.

Modular Code Structure

The application is divided into multiple classes to improve readability, maintainability, and scalability.

Technologies Used
C# Programming Language
.NET Framework / .NET SDK
System.Media for audio playback
Console-based user interface
Project Structure

The project follows a modular structure:

CyberSecurityChatbot/
│
├── Program.cs
├── Chatbot.cs
├── AudioPlayer.cs
├── UIHelper.cs
├── User.cs
├── Assets/
│ └── greeting.wav

Installation and Setup

To run this project locally, follow these steps:

Clone the repository:
git clone https://github.com/challengebenezer23/Cybersecurity-Awareness-Chatbot.git
Navigate to the project directory:/challengebenezer23/Cybersecurity-Awareness-Chatbot.git
cd cybersecurity-chatbot
Open the project in Visual Studio or any compatible IDE.
Ensure that the greeting.wav file is located in the Assets folder and configured to copy to the output directory.
Build and run the application.
Usage

Upon launching the application:

A voice greeting will be played
An ASCII header will be displayed
The user will be prompted to enter their name
A menu will appear allowing the user to select cybersecurity topics
The user may also ask questions or exit the application

Continuous Integration

This project uses GitHub Actions for continuous integration. The workflow automatically builds the application and runs tests on every push and pull request to the main branch.

Future Enhancements

Potential improvements include:

Expansion of cybersecurity topics
Implementation of a quiz or assessment feature
Integration of persistent data storage
Development of a graphical user interface

Author

This project was developed as part of an academic assignment to demonstrate programming and software development competencies in C# by Ebenezer Challenge Ndlovu student number: ST10468299.

License

This project is intended for educational purposes only.