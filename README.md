# AR_game_project
unity based simple augmented reality game built using  language c#.

# Trident Try (Game Name)

The GHOST N’ GUN is an AR game developed in Unity for Android. It uses AR
Core and XR plugin. It offers an immersive experience. It is a game inspired
from the movie “pixels”. It is a brand new way of experiencing an AR game.

# Story

An Alien Spaceship has attacked your planet and is trying to kill you by
launching multiple ghost ships. Destroy as many ships as you can and score
the most points. It is an endless game with time limit set on it. You can get
extra time by Destroying ghost ships.
Destroying ghost ships provide you extra points and time. After
eventually running out of time, its GAME OVER. It will display the score
achieved by you and you can replay the level again. As the game progresses
the enemies get tougher and takes longer time to kill. Assets such as ghost
ships,spaceship were made in blender and all the other particleFX where
obtained from Unity Asset Store.

## IMPLMENTATION DETAILS

To implement the GHOST N’ GUN. We had to first spawn a spawn ship, we
borrowed this asset from unity store. To spawn a particular ship we first made
sure we could detect a plane. Once the plane was detected using Unity Core,
we spawn a marker on the plane so the player understands he can spawn a
ship.
To spawn ship, player has to tap on the screen. The Space Ship will be spawned
on the location of indicator. To spawn the Spaceship we used Instantiate in
unity which will create an Game Object in the game world. Once the spawn
ship was spawned.
We set timer in the Spawn ship, so it could spawn Ghost ship at regular
interval of time. The Spawn ship spawns at regular time. Each ghost has a total
health of 100 and gets higher health as the level progresses. At first each ghost
can be destroyed with a single bullet. Destroying a ghost gives you extra point
and time. If the time runs out, the game is over.
The ghost ship had a rigid body component and where tagged as “Alien”.
Whenever the bullet came in contact with a collision body tagged ‘Alien’. It
decrement’s the health of the ghost. Health was a private variable in Ghost
which was used for tracking health of each instance of Ghost.
Launching the bullet was done using a sphere rigid body. The rigid body helps
in adding physics forces to the object. Whenever player tapped on his mobile.
We made sure that a rigid body is spawned from the center of the screen with
a force on z axis. The rigid body also had gravity so it could have a bullet falloff.
We had two functionality for tap. Spawning the spaceship and also the bullet.
Which at initial stage causes a problem if both spawn at a same time. So we
went around this problem by disabling the shoot script as soon as the game
begins and activate it only once the ghost ships are spawned.
Later we polished the game by adding time and score. Every time you kill a
ship the score component gets added and the time component also. So
eventually when the time runout they call the endgame and stop all other
functionality of other C# classes.

**Environment :**

![image](https://user-images.githubusercontent.com/89335295/210380340-0b2e21b2-aa38-41fb-922c-dc05a61ab9d4.png)

**Marker on plane :**

![image](https://user-images.githubusercontent.com/89335295/210380483-35d5f721-b1b2-4f09-8db6-be36854d431b.png)

**Spawning of Spaceship:**

![image](https://user-images.githubusercontent.com/89335295/210380526-d1c00713-8718-4219-8a70-aabfb494a7d7.png)

**Spawning of GhostShip: GhostShip:**

![image](https://user-images.githubusercontent.com/89335295/210380638-50266a4e-e1a8-4e29-83eb-1a4669b17f20.png)

**Shooting :**

![image](https://user-images.githubusercontent.com/89335295/210380697-098e2ec6-81a1-461a-8684-984a94932257.png)

**killing the GhostShip :**

![image](https://user-images.githubusercontent.com/89335295/210380790-43f5507f-354f-4d53-bff1-e341e2fe5194.png)
![image](https://user-images.githubusercontent.com/89335295/210380804-ac742e7d-d493-4341-a9db-eeb30c1d3fda.png)




****
