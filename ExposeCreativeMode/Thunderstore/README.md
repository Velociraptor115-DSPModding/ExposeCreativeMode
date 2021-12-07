# ExposeCreativeMode Mod
This mod allows you to enable "Creative Mode" and play without limitations (Well, atleast without a few limitations)  
Note that this most of the functionality in this mod will tip off abnormality detection in-game, so do not use it on a save which you want
to upload to the Milky Way.

## How to use this mod
* First install the mod, and reboot the game.
* Press Shift + F4 to toggle creative mode
* When in creative mode
  * Ctrl + T : Unlocks all techs
  * Numpad 3 : Covers the current planet in foundation entirely
  * Numpad 6 : Immediately researches the current queued tech
  * Ctrl + Numpad 1 : Toggles infinite inventory mode  
  (**WARNING**: Saving while in infinite inventory mode, will permanently change the player inventory for the particular save - meaning you won't be able to toggle back after relaunching DSP)
  * Ctrl + Numpad 0 : Toggles infinite station mode  
  (**WARNING**: This probably does not do what you think it does. Read the description carefully before trying it out)

All controls are rebindable. I have removed a few redundant options from the previous versions. I will be adding a few extra options as well in the future.  
In case you were using a particular option that I have removed and you would like it back, please contact me on Discord or raise an issue on GitHub. In the meantime, you can go back to version 0.0.3 which has the most options, but no rebindability. 

### Infinite Inventory mode

* Makes the player inventory have all items present in the game
* All items are reset to 9999, with the stack size being 30000 every frame
* Because the stack is greater, items which go into the inventory are effectively "deleted"

### Infinite Station mode

* This mode is primarily for testing blueprints, by making stations infinitely output to belt and consume from belt without needing any drones/vessels
* Makes all stations set to supply have items less than half of max
* Makes all stations set to demand have items more than half of max
* In the case of ILS, only remote supply/demand is checked. If remote is set to storage, then local is taken

## Contact / Feedback / Bug Reports
You can either find me on the DSP Discord's #modding channel  
Or you can create an issue on [GitHub](https://github.com/Velociraptor115/DSPMods)  
\- Raptor#4825

## Changelog

### v0.0.4

* Removed some of the redundant options and consolidated them
* Infinite Inventory now shows "(Infinite)" on the inventory UI Window
* Added support for rebinding controls

### v0.0.3

* Added contact information

### v0.0.2

* Uploaded source code to GitHub  
* Added a couple of functions for testing blueprints and mods

### v0.0.1

* Initial version that just exposes already existing mode