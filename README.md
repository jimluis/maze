# Maze #

This was an amazing task. The main issue I faced was that the content from the video tutorials was out of date. This made more difficult the learning process and I had to spend more time
debugging and finding the latest and compatible packages.

For my future reference I am adding the main components and instructions I followed.

* Import XR packages and plugins
	* XR Interaction Tool kit
	* XR Plugin Management
		* Import sample projects
		
* Go to player settings> XR Plug-in Management
	* Check Oculus box in Windows and Android tabs

* In the project hierarchy go to Samples>XR Interaction Toolkit>2.0.1>Starter Assets
	* Select the XRI Default Left Controller (Preset) and in the inspector tab click on Add to ActionBasedController default, do the same for the right one too

* Go back to the player settings> Preset Manager
	* Type Right for the right controller and Left for the left controller
	* This will populate the controllers once we add the XR Origin>Right and left hand to the hierarchy

* Add an XR Origin (Action-based)
	* This will also add the XR Interaction Manager in the hierarchy. Under this object the camera and the right and left hand will be added
	* For the right hand, remove the XR Ray interactor component, as well as the XR Interactor Line Visual
	* Add the XR Direct Interactor component, this will allow the user to grab "Interactables"

* XR Interaction Manager 
	* Add Input Interaction Manager Component for controls, this will handle the input actions
	* In the Action Assets add The XRI Default input Actions from Samples>XR Interaction Toolkit>2.0.1>Starter Assets

* Create a gameObject (it can be named TeleportationProvided) in the hierarchy and add the Locomotion components
	* Locomotion System
	* Snap Turn Provider (Action-Based) - To allow turning around in the VR world
		* Add the left and Right hands Snap turn action from Samples>XR Interaction Toolkit>2.0.1>Starter Assets> expand the XRI Default Input Actions> XRI LeftHand Locomotion/Turn same for right
	* Teleportation Provider
  
