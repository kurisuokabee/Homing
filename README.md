# Homing Missile Demo Video 
[Demo Video](https://drive.google.com/file/d/1YuSiG2EEX2Ul6drPOSE8ISMI2tYza9ef/view?usp=sharing)

## Project Description
- The player moves forward constantly and can turn slightly left or right.
- Homing missiles use **Quaternion.LookRotation** and **Quaternion.Slerp** to smoothly rotate toward the player.
- Missiles spawn outside the camera view and disappear after 5 seconds or when they hit the player.
- Every 10 seconds, more missiles spawn to increase difficulty.
- Getting hit 5 times restarts the game.
