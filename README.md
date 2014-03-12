# Rewind - by leagueofcake
Hi. This is my SDD major project, Rewind. It's a side-scroller game built in VB.NET. 

Links! (yay)
============
* [Main Bitbucket Page](https://bitbucket.org/leagueofcake/rewind)
* [Source](https://bitbucket.org/leagueofcake/rewind/src)

TODO
====
Graphics/VFX
------------
* Make rewind effect draw an onion-skin effect
* Rewinding: Make rewind accelerate as the effect lengthens
* Design better graphics! 
	* Replace charging bar
	* Replace character
	* Replace background
	* Replace projectile
	* Make a logo! 
* Make character flash/fade out and in when using ability
	* Fade out when charging, flash back in when finished

Game System/Mechanics
---------------------
* Collision detection
* Cooldown implementation for ability
	* Countdown/white overlay filling to indicate cooldown
* Removal of projectiles once they are out of range i.e. have moved past 5 seconds' travel distance
* Main menu
* Difficulty settings
	* Harder = Faster + more projectiles, increased cooldown of ability
* Other powerups/abilities
	* Ghosting - practically invincible
	* Send own projectiles - anti-projectiles, negate incoming projectiles

Sound
-----
* Sound - use royalty free clips? 
	
Quick Fixes/Code simplification/Other
-----
* Possibly combine timerWorld and timerRewind and set options to differentiate
* Watch: [Adding/Remove Bullets at Runtime & Collision Detection (Youtube)](https://www.youtube.com/watch?v=rG0-FBfs14U)