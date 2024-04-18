# A simple sixteen-segment console simulation

## **Summmary**
This was one of the projects for my .NET Programming classes. It's a simple console app that renders a user's text into a sixteen-segment format. I wrote this program in a single file, as it was before I had learned proper OOP or even multi-dimensional arrays. I know there could be made improvements, but I prefer to keep it this way as sort of a time capsule of the time. The only changes I did was moving the Character class's properties above all methods, and making the app run again after the message has been displayed.

## **Overview**
1. The app prompts the user to enter a message and shows all allowed characteds (```a-z, 0-9, ( ), +, /, -, _, .```);
2. The user then can input their message, and press enter for it to be rendered;
3. If the message's length is more than the console window's width, a buffer of several underscored is put in front of the message as it starts moving to the left, one letter at a time each 150ms. This is done so the first letters don't disappear immediately;
4. After the message is rendered, the user can press any key to start inputtin a new message.

# **Screenshots**

- The initial prompt for input:

![image](https://github.com/4veti/Sixteen_Segment_Display/assets/37193765/16bc5fab-966d-499e-852b-b592c5398915)

- Rendered the message *Hello*:

![image](https://github.com/4veti/Sixteen_Segment_Display/assets/37193765/6e0b7c7f-b0cb-44a1-ac67-9f7ce0629dd0)

- You can see the underscore buffer for the message *Hello World* as it's being rendered letter by letter to the left:

![image](https://github.com/4veti/Sixteen_Segment_Display/assets/37193765/4b330ea4-4f97-4506-9f8b-508f140ca30f)


## **Video sample**
