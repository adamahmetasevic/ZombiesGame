**Zombie Survival Game**

Welcome to my Zombie Survival Game! This is a Unity 3D project where players must survive against waves of zombies that spawn randomly across the map. 
Future plans include implementing smart AI using Unity's ML-Agents toolkit to make zombies adapt and learn from the player's actions.


Enemy AI: Zombies actively seek out the player and deal damage upon contact.
Continuous Spawning: Initial batch of zombies spawns at the start of the game, with additional zombies spawning periodically.
Player Health System: Players have a health system that tracks damage and triggers a game over scene when health reaches zero.
Game Over Scene: Transition to a game over scene upon player's death.


**Setup**
Clone the Repository:

bash
Copy code
git clone https://github.com/yourusername/zombie-survival-game.git

**Open the Project:**
Open Unity Hub.
Click on Add and select the cloned project folder.
Add Scenes to Build Settings:

Ensure all necessary scenes (e.g., main gameplay scene, game over scene) are added to the build settings.
Go to File -> Build Settings and add the open scenes.
Usage
**Play the Game:**
Press the Play button in the Unity editor to start the game.
The player must survive against the zombies that spawn randomly on the map.

**Controls**

Use the standard Unity character controller inputs (WASD for movement, mouse for looking around).

**Future Plans**

Smart AI with Unity's ML-Agents

Adaptive AI: Implement smart AI using Unity's ML-Agents to allow zombies to learn and adapt based on player behavior.

Dynamic Equipment: Zombies can pick up and use equipment like helmets if they get shot in the head.

Enhanced Behaviors: Develop more complex behaviors such as coordinated attacks, retreating, and seeking cover.
