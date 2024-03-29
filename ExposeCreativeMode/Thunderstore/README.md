# ExposeCreativeMode Mod
This mod allows you to enable "Creative Mode" and play without limitations (Well, atleast without a few limitations)  
Enabling "Creative Mode" will disable achievements for the save, so keep a separate save to use it on.

## What's new in this update?
* Fixed compatibility issues with the combat update (0.10.28.xxxxx)
* Instant Research's Relocking and Unlock All Tech is temporarily not working till it can be fixed in a better way

## How to use this mod
* First install the mod, and reboot the game.
* Press Shift + F4 to open the creative mode settings window  
![Creative Mode Settings Window](https://github.com/Velociraptor115-DSPModding/ExposeCreativeMode/blob/main/ExposeCreativeMode/Docs/CreativeModeSettingsWindow.png?raw=true)  
![Creative Mode Settings Window Enabled](https://github.com/Velociraptor115-DSPModding/ExposeCreativeMode/blob/main/ExposeCreativeMode/Docs/CreativeModeSettingsWindow_Enabled.png?raw=true)
* You need to enable creative mode to use the rest of the functions below

## Functions

All controls are rebindable. Detailed explanation of functions are given further below.  

| Function                          | Default Keybind                      | Description |
| --------------------------------- | ------------------------------------ | ----------- |
| Infinite&nbsp;Inventory           | Ctrl&nbsp;+&nbsp;Numpad&nbsp;1       | Toggles Infinite Inventory mode |
| Infinite&nbsp;Station             | Ctrl&nbsp;+&nbsp;Numpad&nbsp;0       | Toggles Infinite Station mode |
| Infinite&nbsp;Reach               | -                                    | Auto-enabled when in creative mode |
| Infinite&nbsp;Power               | -                                    | Auto-enabled when in creative mode  |
| Instant&nbsp;Research             | Ctrl&nbsp;+&nbsp;Numpad&nbsp;6       | Toggles Instant Research mode |
| Lock&nbsp;Research                | L                                    | While Instant Research mode is active, hold this keybind to toggle locking tech |
| Instant&nbsp;Build                | Ctrl&nbsp;+&nbsp;Numpad&nbsp;2       | Toggles Instant Build mode |
| Instant&nbsp;Replicate            | -                                    | Toggles Instant Replicate mode<br><br> This is an adaptation of Instant Handcraft and Free Handcraft from [DSPCheats](https://dsp.thunderstore.io/package/Windows10CE/DSPCheats/) by [Windows10CE](https://dsp.thunderstore.io/package/Windows10CE/) |
| Unlock&nbsp;all&nbsp;tech         | Ctrl&nbsp;+&nbsp;Shift&nbsp;+&nbsp;T | Press keybind to unlock all tech<br>5 levels of each infinite tech will be unlocked |
| Flatten&nbsp;Terrain              | Numpad&nbsp;3                        | Foundations entire planet with the "no decoration" option |
| Restore&nbsp;Terrain              | -                                    | Hold a combination of the Ctrl and Shift keys while pressing the "Flatten Terrain" keybind to restore terrain<br><br>Ctrl - Restore shallow oceans<br>Shift - Restore mid-level oceans<br>Ctrl + Shift - Restore deep oceans<br><br>You will not be able to apply foundation over restored terrain using the foundation tool, unless you also install the [UncoverFoundationedOceans](https://dsp.thunderstore.io/package/Raptor/UncoverFoundationedOceans/) mod.<br> I recommend to install that mod also so that you can partially flatten an area after restoring terrain, otherwise you will have to "Flatten Terrain" again to be able to build on ocean level area |
| Bury&nbsp;/&nbsp;Raise&nbsp;Veins | Numpad&nbsp;4                        | Toggles bury/raise all veins on the planet |
| Fast Forward Orbital Mechanics    | Ctrl&nbsp;+&nbsp;Shift&nbsp;+&nbsp;> | Moves all planets forward in orbit and rotation |
| Rewind Orbital Mechanics          | Ctrl&nbsp;+&nbsp;Shift&nbsp;+&nbsp;< | Moves all planets backward in orbit and rotation |
### Infinite Inventory mode

* Makes the player inventory have all unlocked items in the game
* If "Include Locked Items" is enabled, then all the items present in the game will be available in the inventory
* All items are reset to 9999, with the stack size being 30000 every frame
* Because the stack is greater, items which go into the inventory are effectively "deleted"  

### Infinite Station mode

* This mode is primarily for testing blueprints, by making stations infinitely output to belt and consume from belt without needing any drones/vessels
* Makes all stations set to supply have items less than half of max
* Makes all stations set to demand have items more than half of max
* In the case of ILS, only remote supply/demand is checked. If remote is set to storage, then local is taken

### Infinite Reach
* You can now inspect, interact with, build and delete items across the entire planet. Inspect works even in Planet View mode

### Infinite Power
* All buildings connected to a power network will work at 100% regardless of the amount of power supply
* Buildings not connected to a power network will still **NOT** work

### Instant Research mode

* You can lock / unlock specific tech in the tech tree screen and also increase / decrease the research level of infinite research.  
* Hold the "Lock Research" keybind to lock / decrease research.  
* You can also use the Ctrl and Shift keys to modify the number of levels to increase / decrease.  
  | Modifier     | Lv.  |
  | ------------ | ---- |
  | None         |    1 |
  | Ctrl         |   10 |
  | Shift        |  100 |
  | Ctrl + Shift | 1000 |  

### Instant Replicate
* The 3 options govern how Instant Replicate works. When all of them are off, it is no different from vanilla
  * **Is Instant**: Replicates every item in a single frame
  * **Is Free**: Does not use any materials from inventory for replicating
  * **Allow All**: Allows to replicate materials marked "Cannot make in replicator"

## Contact / Feedback / Bug Reports
You can either find me on the DSP Discord's #modding channel  
Or you can create an issue on [GitHub](https://github.com/Velociraptor115-DSPModding/ExposeCreativeMode)  
\- Raptor#4825

## Changelog

### [v0.0.20](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.20/)
* Fixed compatibility issues with the combat update (0.10.28.xxxxx)
* Removed Instant Research's Relocking and Unlock All Tech temporarily till it can be fixed in a better way

### [v0.0.19](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.19/)
* Fixed Instant Research for logistic bot techs

### [v0.0.18](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.18/)
* Fixed compatiblity with the September 27, 2022 patch (Game version 0.9.27.14546)

### [v0.0.17](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.17/)
* Fixed a compatiblity issue with BulletTime mod

### [v0.0.16](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.16/)
* Fixed compatibility with the June 10, 2022 patch (Game version 0.9.26.12891)

### [v0.0.15](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.15/)
* Added Orbital Mechanics Override
* Split Instant Research and the tech relocking functionality
* Changed default keybind for Unlock All Tech to Ctrl + Shift + T
* Added button for Unlock All Tech in the creative mode settings UI
* Significantly increased Infinite Inventory stack size and replaced item count in UI with infinity symbol
* Fixed an [issue](https://github.com/Velociraptor115-DSPModding/DSPMods/issues/14) that caused rounding errors when unlocking tech with InstantResearch
* Fixed an [issue](https://github.com/Velociraptor115-DSPModding/DSPMods/issues/15) where Instant Build failed to construct buildings after running out of items in inventory during construction of big blueprints

### [v0.0.14](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.14/)
* Revamp internal working of the mod
* Removed code reverse patched from `PlayerAction_Test` in favour of custom code
* Add DSPCheat's InstantHandcraft and FreeHandcraft
* Add save support
* Add settings UI

### [v0.0.13](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.13/)
* Disable achievements for the save when enabling creative mode
* Add notes about [UncoverFoundationedOceans](https://dsp.thunderstore.io/package/Raptor/UncoverFoundationedOceans/) in the "Restore Terrain" section

### [v0.0.12](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.12/)
* Fix compatibility issue between BetterMachines and UnlockAllTech / InfiniteResearch

### [v0.0.11](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.11/)
* Fix InfinitePower for Spray Coaters, Pilers and Traffic Monitors
* Fix InfiniteResearch for the new tech from the recent update. The extra storage space for logistics stations should get properly applied now
* InfiniteInventory now gives infinite soil as well

### [v0.0.10](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.10/)

* Updated code for game version 0.9.24.11182
* Added ability to set the foundation "level" of the planet

### [v0.0.9](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.9/)

* Added support for lock / unlock of tech while "Instant Research" is active
* Handled the scenario where inventory capacity research may be completed while "Infinite Inventory" is active

### [v0.0.8](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.8/)

* Added "Infinite Power" and "Infinite Reach"
* Modified the foundation color used for "Flatten Planet"
* Added a toggle to bury/raise all veins on the planet

### [v0.0.7](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.7/)

* Fixed an [issue](https://github.com/Velociraptor115/DSPMods/issues/4) with Creative Mode not detecting inputs properly
* Fixed (hopefully) an [issue](https://github.com/Velociraptor115/DSPMods/issues/5) with Instant Build using up too much CPU after building big blueprints
* Changed "Instant Research" into a toggle

### [v0.0.6](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.6/)

* Fixed an issue with "Instant Build" throwing an exception when not on a planet

### [v0.0.5](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.5/)

* Added "Instant Build" functionality
* Auto-enable "Infinite Inventory" and "Instant Build" when enabling "Creative Mode". They can be individually toggled off later if you do not want to use them.
* Fixed various UI issues with "Infinite Inventory"
* "Infinite Inventory" is no longer saved as part of game data, so you can load the save with your previous inventory
* Fixed "Creative Mode" UI text still being visible on quitting to main menu or loading another game

### [v0.0.4](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.4/)

* Removed some of the redundant options and consolidated them
* Infinite Inventory now shows "(Infinite)" on the inventory UI Window
* Added support for rebinding controls

### [v0.0.3](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.3/)

* Added contact information

### [v0.0.2](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.2/)

* Uploaded source code to GitHub  
* Added a couple of functions for testing blueprints and mods

### [v0.0.1](https://dsp.thunderstore.io/package/Raptor/ExposeCreativeMode/0.0.1/)

* Initial version that just exposes already existing mode