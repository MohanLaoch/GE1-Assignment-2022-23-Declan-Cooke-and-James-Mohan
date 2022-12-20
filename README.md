## GE1-Assignment-2022-23-Declan-Cooke-and-James-Mohan

# Planet Music

### Names & Student Numbers:
#### Declan Cooke | C20465442
#### James Mohan | C20305011

### Video: 
(To be added)

# Description of the Project
Discover an entire planet through your fingertips! New-age technology allows us to examine infinite worlds with the press of a button. The Shrinkinator 5000 allows someone to shrink down to as small as they wish to view the world in a different perspective. What may seem like an ordinary golf ball can become an entire planet when one is shrunk down to the molecular level. In our project, you can experience this futuristic technology by shrinking down and exploring microscopic oddities not visible to the naked eye.  Once shrunk down, the environment around you will react to the music. Enjoy the vast colourful landscape of these "planets" and vibe to the cool tunes!

# Instructions for Use
Open the project build with a VR headset, or alternatively use the WASD keys to explore the environment. When you pull the trigger on the VR controller, you can pick up objects and pull them towards you. Enjoy the changing colours and fun music as you explore the world. The flowers are key.

# How it works
When you run the project, an array of random game objects such as trees, bushes and flowers will spawn at random on a larger sphere. You can walk around the sphere as if it was a planet, with fully simulated gravity. Objects around you will also adhere to the miniature planet’s gravity. Clouds and birds will orbit the planet as if they were truly flying around.

# List of Classes/Assets in the Project
| **Class/Asset** | **Source** |
|-----------|-----------|
| Audio 1, 2 & 3.cs | Modified from [reference](https://github.com/skooter500/GE1-2022-2023/blob/master/GE1%20Examples%202022/Assets/AudioAnalyzer.cs) |
| AudioManager.cs | Modified from [reference](https://github.com/skooter500/GE1-2022-2023/blob/master/GE1%20Examples%202022/Assets/AudioViz1.cs) |
| Billboard.cs | From [reference](https://youtu.be/BLfNP4Sc_iA?t=1015) |
| Bird | Self written |
| CloudMoveTest | Self written |
| ColourChange | From [reference](https://www.youtube.com/watch?v=C_f2ChrcSSM) |
| DetectVR | From [reference](https://www.youtube.com/watch?v=ImPZyIM6XNs) |
| GravityAttractor | From [reference](https://www.youtube.com/watch?v=gHeQ8Hr92P4&ab_channel=SebastianLague) |
| GravityBody | From [reference](https://www.youtube.com/watch?v=gHeQ8Hr92P4&ab_channel=SebastianLague) |
| ObjectSpawner | Self Written |
| PlayerControl | Modified from [reference](https://www.youtube.com/watch?v=1LtePgzeqjQ) |

# References
- [Music](https://www.youtube.com/watch?v=5PNbEfLIEDs)
- [Skybox](https://www.youtube.com/watch?v=yw2J9NWRdow)
- [VR Tutorial](https://www.youtube.com/watch?v=yxMzAw2Sg5w) 

# What we are most proud of in the Assignment
### Declan: 
While this project was a lot of fun to work on, especially with a partner, it did come with its challenges. One of the more difficult aspects of it was the simulated gravity around the planet and making sure the rotation of other objects in the scene matches the curvature of the globe. Since I had to disable the regular unity gravity that comes with the rigidbody component, I had to use the rigidbody.addforce function to simulate what gravity would be like on a planet. 

### James: 
Having the opportunity to work on the project with a partner enabled me work on things that I hadn’t done before. I implemented VR into the project, which was a first for me. I got it working with little to no difficulty which made my very happy. The other thing I was most proud of in the assignment was getting the ObjectSpawner script to work. At first, we had hand-placed object in the scene, but during the project we realised having random spawning would be fair more satisfying. After getting it to work I am proud of my understanding in instantiating gameobjects.


# What we Learned
(To be added)

# Proposal
- Using ProBbuilder in unity we will create colourful trees, plants and flowers.
- These gameobjects will react to  music using the transform.localScale API, creating a new Vector3 and passing through the volume variables of the music.
- We will also use perlin noise on these gameobjects to make them feel more vibrant and alive.
- transform.local scale will also be used to shrink the player down to allow them to explore the "planet".
- The player can move around the world and interact with the gameobjects using unitys new input system.
- We will implement music using unitys audio library.
- The worlds gameobjects will have a random selection of colours through the use of nested for loops to apply new materials onto them.
