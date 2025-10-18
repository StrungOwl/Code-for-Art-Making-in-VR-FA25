# Code-for-Art-Making-in-VR-FA25
All the scripts in this repo are for my Art Making in VR students and anyone who watches my YouTube tutorials.

GRABBABLE EVENTS: Attach to any game object with the "Grabbable" component on it. Then, you can drag in any Game Object into any event you want to use. 

GRAB SCENE TRANSITION: Attach to any game object you want to grab trigger scene transition. Change the "Scene to load" and ensure its spelled the exact same way as your scene is (same spacing and caps too). Need to test to see if the fade works. Object needs to have a grabbable script on it. 

DOOR HANDLE: Create a Grab Interactable cube. Place it where you would want your door handle and disable (uncheck) its mesh renderer. Add this script to it. Make an empty game object and call it DoorPivot. Place it on the edge of the door, where you would want/expect it to pivot from. Make the door object and the handle object children of that DoorPivot by dragging them inside of it. You should see them nested under in the hierarchy! In the inspector, set Door To Open as your DoorPivot object.

SCENE PRELOADER: Attach to an empty game object called "ScenePreloader". Change the "scene to preload" to the name of your scene. This will preload/async load the scene 90% on Start, and will activate the scene when you call the method "Go TO Preloaded Scene".

NOTES SCRIPT: Create an empty game object called "Notes" and add this script to it. It will create a text box area for you to type things that you want to remember.

FADE AND TRANSITION: Change the name of the scene in line 20 of this script. Attach to an empty game object called "FadeAndTransition". Create a canvas, and inside that canvas create a panel that takes up the entire canvas. Drag that panel into the "Fade Image" variable in the inspector of the FadeAndTransition object. Use this script's method called StartSceneTransition.

FADE IN EFFECT: Attach to an empty game object called "FadeInEffect". Create a canvas, and inside that canvas create a panel that takes up the entire canvas. Drag that panel into the "Fade Image" variable in the inspector of the FadeInEffect object. On start, this object will automatically fade in from black. 

