# Week 4 - Behaviors

## Relevant Slides

https://myuva-my.sharepoint.com/:p:/g/personal/jcb2h_virginia_edu/EViQb-8UzU1FmtdTYQx9ilYBmaCBujOghZlzcoLw74YMTA?e=fA0Jx7

## Relevant Manual Pages

https://docs.unity3d.com/Manual/CreatingAndUsingScripts.html
https://docs.unity3d.com/Manual/CollidersOverview.html (Triggers section)

## Skills

* The anatomy of a Custom Component / Script
	* Class
	* Fields
	* Serialization
	* References
	* Methods
		* Start()
		* Update()
		* Custom Methods
	* NameSpaces
* Triggers
	* OnTriggerEnter()
	* OnTriggerExit()
	* OnTriggerStay()


## Level

1. Using MoveObject and triggers, build a realistic representation of motion-sensing doors like you'd find at a grocery store: two doors that open in opposite directions as you approach
2. Have the doors close behind you once you've walked through (but not close ON you when you're in the middle of them)
3. Make a new script that does the same thing MoveObject does, except this one will rotate an object instead. HINT: `gameObject.transform.Rotate()` works the same for rotation as `gameObject.transform.Translate()` does for movement. 
4. Make a single object rotate or move depending on whether you're standing on a certain spot.

## Bosses

### Bowser

Solve this puzzle: 
* You enter a room
* There is a spot on the floor indicating where to stand
* By walking over to stand on that spot, you cause the following to happen: a cube moves up a bit, then stops and rotates a bit, then goes back down the same amount, then rotates back the same amount, and does this cycle 3 times. 

It is never moving and rotating at the same time. You do not need to write any new scripts to accomplish this (other than those that already exist or you made in **The Level**).

BONUS: the cube is red while moving, blue while rotating

### Hornet

Devise a puzzle whereby you need to navigate a cube through a 3D maze, and the only way to move the cube is by positioning your "body" in a room. If the cube touches the walls of the puzzle, you lose and have to start over. The cube should move naturally, as if pushed by invisible forces, and have momentum.

Methods you might need: `AddForce(), AddTorque(), AddRelativeForce(), AddRelativeTorque(), OnCollisionEnter(), OnCollisionExit()`

### Demon of Hatred

Create a pathway between floating rooms that consists of a hundred (or more) steps moving in cycling sinusoidal motion along two axes. The path must be walkable, with a bit of skill. 

BONUS: Introduce an extra challenge whereby the steps are fewer and wider, but far apart enough to require jumping. It is easy to jump to a near step, and harder to jump two steps as once. Every time a player touches a step, the system becomes more dynamic in the sinusoidal way, requiring as few jumps as possible to get across. 
