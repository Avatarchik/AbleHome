# About
AbleHome is a working-prototype to help improve accessibility for the elderly and individuals with disabilities. As family members and friends age, it's common for loved ones to worry about and dedicate much of their day to caring for them. AbleHome seeks to restore the independence to these individuals and their caretakers.

## Inspiration
We were inspired to improve accessibility for the elderly and disabled by our family members and friends who have had difficulty moving throughout their homes. As these members age, family worry about their wellbeings and if they are properly cared for.

## What it does
AbleHome is a framework that connects the Myo Gesture Control Armband with smart home devices. Functioning through Amazon Web Services, AbleHome can communicate to any modern API for utilizing smarttech. Our framework is displayed through Unity, which demonstrates how the Myo can be utilized to open and close doors and access various other objects in their home.

![alt text](https://github.com/hdubel94/AbleHome/blob/master/blockdiagram.png "Logo Title Text 1")


## How we built it
## Challenges we ran into
- Amazon Web Services does not natively work with Unity, and surprisingly there was almost no documentation.
- The only C# Unity AWS compatibility was for UnityMobile
- Unity 2017 has deprecated support for JavaScript/Unity Script

## Accomplishments that we're proud of
- A walking skeleton of the architecture to show the communication between the user and the product

## What's next for AbleHome
- Develop more physically accurate gestures
- Expand the framework compatibility
- Add texting support

## Built With
- Myo
- Amazon Web Services
- Unity3D
- Particle Photon
- C#
- Python
