# NeuroSky MindWave Horror Game

**Presented at:** IEEE Brain Conference, San Diego, 2016

### Design & Development : Nirmesh Gollamandala & Srinivas Varshith Palagiri

## Overview

This pioneering project integrates Brain-Computer Interface (BCI) technology with interactive gaming to create an immersive soundscape horror experience. Using the NeuroSky MindWave™ headset, our game reads the player's mental state—specifically, their Attention and Meditation levels—via NeuroSky's proprietary eSense™ algorithms and raw brainwave data. The result is an innovative control mechanism that directly ties the player's mental state to the in-game experience.

## The Game

Developed in C# using Unity, this horror genre game was designed for both Android and iOS platforms. The core gameplay mechanic revolves around the player's ability to outrun a ghost:
- **Dynamic Movement Control:**  
  The player's speed is determined by their level of relaxation (Meditation). The more relaxed the player is, the faster they can move, adding a unique, neurofeedback-driven twist to the traditional chase scenario.

## Technical Integration

- **Brain-Computer Interface:**  
  The NeuroSky MindWave™ headset reports real-time mental state data, including attention and meditation metrics, which are then used to influence gameplay.
  
- **Unity Plugin for Mobile Platforms:**  
  A custom Unity plugin was developed to facilitate communication between the game and the NeuroSky MindWave device. Key technical components include:
  
  - **Eclipse Project:**  
    The folder `UnityThinkGear2User4Android` contains an Eclipse project that generates `UnityThinkGear.jar`, essential for Android integration.
  
  - **Cross-Platform Support:**  
    The solution is packaged as **NeuroSkyUnityThinkGear For iOS & Android Version 1.1.2**, ensuring seamless support for both mobile operating systems.

## Significance

This project represents an early exploration into the fusion of neurofeedback and gaming. By harnessing the player's mental state to influence game mechanics, it offers a glimpse into the future of interactive entertainment—one where the boundaries between mind and machine blur to create deeply personalized user experiences.

Whether you're interested in BCI, immersive game design, or the integration of cutting-edge technology into interactive media, this project serves as a compelling case study of innovation at the crossroads of neuroscience and gaming.


# NeuroSkyUnityThinkGearPlugins
A plugins for Unity to create Android and iOS app and communicate with NeuroSky MindWave Device

The folder "UnityThinkGear2User4Android" is the Eclipse project that generated "UnityThinkGear.jar".

NeuroSkyUnityThinkGear For iOS & Android Version 1.1.2


Instructions For iOS:
--------------------------------------

Run the Demo:

1.Drag the ThinkGear prefab from Project view to Hierarchy view

2.Drag the DisplayDataDemo prefab from Project view to Hierarchy view

3.Build project to Xcode project.

4.Open the Xcode project.

5.Navigate to your project settings.

6.Select Build Phases.

7.Expand Link Binary with Libraries

8.Click on + and select ExternalAccessory.framework and Accelerate.framework

9.Open Info.plist

10.Right Click and "Add Row",select "Support external accessory protocols"

11.Add "com.neurosky.thinkgear" for the value of protocol.

12.Build and Run Xcode project.


Run your own project:

1.Drag the ThinkGear prefab from Project view to Hierarchy view	

2.At the place you want to use Attention,Meditation,EEG and so on,add code like following

   void Start()
    {
		
		controller = GameObject.Find("ThinkGear").GetComponent<ThinkGearController>();
		
		controller.UpdatePoorSignalEvent += OnUpdatePoorSignal;
		controller.UpdateAttentionEvent += OnUpdateAttention;
		controller.UpdateMeditationEvent += OnUpdateMeditation;
		
		controller.UpdateDeltaEvent += OnUpdateDelta;
		
    }
    

3.Implement every function above

......

......

......

4.Build project to Xcode project.

5.Open the Xcode project.

6.Navigate to your project settings.

7.Select Build Phases.

8.Expand Link Binary with Libraries

9.Click on + and select ExternalAccessory.framework and Accelerate.framework

10.Open Info.plist

11.Right Click and "Add Row",select "Support external accessory protocols"

12.Add "com.neurosky.thinkgear" for the value of protocol.

13.Build and Run Xcode project.



Instructions For Android:
--------------------------------------


Run the Demo:

1.Drag the ThinkGear prefab from Project view to Hierarchy view

2.Drag the DisplayDataDemo prefab from Project view to Hierarchy view

3.Build project to an apk file.

4.Install apk to Android device.

5.Click "Connect1" to try to connect headset



Run your own project:

1.Drag the ThinkGear prefab from Project view to Hierarchy view	

2.At the place you want to use Attention,Meditation,EEG and so on,add following code

   void Start()
    {
		
		controller = GameObject.Find("ThinkGear").GetComponent<TGDeviceController>();
		
		controller.UpdatePoorSignal1Event += OnUpdatePoorSignal;
		controller.UpdateAttention1Event += OnUpdateAttention;
		controller.UpdateMeditation1Event += OnUpdateMeditation;
		
		controller.UpdateDelta1Event += OnUpdateDelta;
		
    }
    

3.Implement every function above

4.Call Connect() function of TGCConnectionController to connect

5.Call disconnect() function of TGCConnectionController to disconnect


Note:
--------------------------------------
Before building,you must fill Bundle Identifier in Other Settings with "com.yourcompany.yourappname",
and must modify Plugins/Android/AndroidManifest.xml,like package="com.yourcompany.yourappname".

Any question/issues,contact androidunity@gmail.com

