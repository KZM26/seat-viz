# seat-viz
Software to visualise pressure from bicycle seat model

## Introduction

The software visualises pressure derived from a bicycle seat model that has pressure sensors

### System 

The software implements the display unit component of the overall system
![image](https://user-images.githubusercontent.com/23017771/134786162-1b123157-407c-4b7f-b23e-290eb1d75cb7.png)

The images below show the rendering, implementation and use of the system

![image](https://user-images.githubusercontent.com/23017771/134786138-c5e386ad-446d-41f6-9e76-6f35ffd0080b.png)

![image](https://user-images.githubusercontent.com/23017771/134786147-f2919b4e-f0ae-467a-9c50-8b3ea1c48dca.png)

![image](https://user-images.githubusercontent.com/23017771/134786154-66aa9e14-b403-428c-bede-58e66c61b889.png)

### Screens

The screen below is the main screen of the system and is used to display readings.

![image](https://user-images.githubusercontent.com/23017771/134786189-beb84767-53c9-415e-bbb9-2609fece1eec.png)

1	Return	Switches the program to the start screen
2	Connect	Connects the computer to the microcontroller
3	Freeze	Freezes the current map being displayed. Only enabled after Connect clicked
4	Save	Save the current map being displayed. Only enabled after Freeze clicked
5	Calibrate	Performs the calibration sequence
6	Status bar	Displays the status of the program indicating what is happening or what should happen.
7	Pressure map	Map corresponding to the device sensors. Each square corresponds to a sensor and changes colour based on the sensor reading
8	Vertical Displacement	Displays the vertical displacement of a selected row of sensors
9	Colour vs Pressure Threshold	Shows the correspondence between a colour and the pressure threshold passed
10	Information table	Displays the indicating information for the pressure map
11	Threshold Slider	Adjust the thresholds globally

Example screen showing the pressure colour map and a drawn triangle indicating the ideal bicycle seat based on high pressure zones
![image](https://user-images.githubusercontent.com/23017771/134786216-56c6a781-aaaf-4e2e-9576-dd72cafbee9e.png)


