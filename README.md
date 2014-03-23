# Rewind - by leagueofcake
Hi. This is my SDD major project, Rewind. It's a sidescroller game built in VB.NET. 

Links! (yay)
============
* [Main Bitbucket Page](https://bitbucket.org/leagueofcake/rewind)
* [Source](https://bitbucket.org/leagueofcake/rewind/src)

Constant Values
===============
* Health Bar: 500
* Charge Limit (and timerCharge/chargeBar): 300
* picPlayer: 50 x 50 px
* Projectile shooting: -2
* Projectile rewind: +4

TODO
====
Graphics/VFX
------------
* Font: Bitsumishi
* Make rewind effect draw an onion-skin effect
* Rewinding: Make rewind accelerate as the effect lengthens
* Design better graphics! 
	* Replace charging bar
	* Replace character
	* Replace background
	* Replace projectile
	* Make a logo! 
* Black/White color scheme? 
* Some visual effect when charging/using abilities e.g. screen flash/tint
* Make character flash/fade out and in when using ability
	* Fade out when charging, flash back in when finished

Game System/Mechanics
---------------------
* Moving to the right makes time go faster, moving to the left makes time go slower
* Fluctuating shield system - colliding with projectiles with shield on increases available length of Rewind/some bonus
* Collision detection
* Cooldown implementation for ability
	* Countdown/white overlay filling to indicate cooldown
* Removal of projectiles once they are out of range i.e. have moved past 5 seconds' travel distance
* Main menu
*Achievements
	* Survived for X time
	* Played X times
	* Charged X times
	* Play at 12:34:56
	* Absorbed X projectiles
* Progress bar for achievements
* Stats screen
* Challenge mode
* Difficulty settings
	* Harder = Faster + more projectiles, increased cooldown of ability
* Other powerups/abilities
	* Ghosting - practically invincible
	* Send own projectiles - anti-projectiles, negate incoming projectiles
* Difficulty shifting
	* Projectiles split into separate particles
	* Projectiles move at an angle
	* Increased frequency of projectiles
	* Change in colour scheme (Visual)

Sound
-----
* Sound - use royalty free clips? 
	
Quick Fixes/Code simplification/Other
-----
* Possibly combine timerWorld and timerRewind and set options to differentiate
* Watch: [Adding/Remove Bullets at Runtime & Collision Detection (Youtube)](https://www.youtube.com/watch?v=rG0-FBfs14U)