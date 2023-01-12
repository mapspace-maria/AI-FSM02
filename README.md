# AI-FSM02

The challenge was to update the base project to add an FSM to the robot. The FSM should have 4 states: patrol, chase, attack and hide. These are the steps for the creation of the game:

1. Create a script which will control the robot using AI
2. Create the script for the NPCBaseFSM which we'll use it later in the script from the animation controller
3. Time to create the animation controller with the 4 states. Add the animations of the robots from the asset folder. Then, assign the animation controller to the robot.
4. On the animation controller, add the transition for each of the state. In order to do that, we've create 2 float parameters: life and distance, and adjust the variable as suitable for the scene
5. We add a behavior for each of the state. One script per state. 
    a. Patrol: we use waypoint to keep the robot on a specific area. Robot will move around the sphere with the tag "waypoint"
    b. Chase: when player gets closer to the robot (distance defined on the transition) the robot enter in chase state and start running (run animation) toward the player
    c. Attack: when robot is really close to the player (distance defined on the transition), it will start shooting. To action shooting we've add a bullet (sphere) and turret(starting point of the bullet).
    d. Hide: when the life is less than the defined value, state chnages to Hide. It will get out of the state once the life has been recharge
6. Once, the script has been assign to the animator controller, we add the RobotController script to the robot prefab. Then assig each of the value on the inspector panel.
7. Double check that everything has been assign and connected.
8 Test it!
9. Play and enjoy 
