In the game where the enemies advance to the castle by using a map and necessary
mechanics on Unity, the player is deemed to have lost the game when a certain
number of enemies cross the castle border. Enemies are advancing on the shortest
path to the castle by using A* algorithm. By observing this movement of the
enemies, player is defending the castle by making it difficult for the enemies to
advance with defensive tools and obstacles.

<img src="https://i.imgur.com/0kSyUjF.png" width="600" height="500">

Player can put obstacles in the way. After that enemies calculate a new path and use it.
A* algorith is coded, not used from plugin.

<img src="https://i.imgur.com/JMVaqm5.png" width="600" height="420">

Algorithm creates a grid and with using the grid checks the roads are moveable or not.
Then for every enemy, calculates the shortest path to the waypoint in real time. 

<img src="https://i.imgur.com/M7ofIVv.png" width="600" height="550">

Even in large maps, it works.

<img src="https://i.imgur.com/sccfB1y.png" width="800" height="350">
