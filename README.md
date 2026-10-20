# in-class-activities
## devlog
Michael Cornett


### W1
1. The player's camera doesn't follow the cat. This happens because the camera is no longer parented to the cat object and doesn't inherit it's movement.
2. [Game Link](https://mikebop.itch.io/in-class-assignment1)

### W2
1. The r, g, and b variables are floats instead of ints, bools, or strings because rgb values can go from 0 to 1.0 and float is meant for numbers utilizing decimals.
2. The _bounce variable is an int type because it's only counting the raw number of bounces. 
3. If I remember correctly the line didn't end with a semicolon which is required when ending statements in c#. (But I lowkey already forgot what happened during that step)

### w3
## Activity 1
1. The input for friendship level would be best represented by an integer and the input for the flag status would be a boolean. This method would return a string(the response) back to the player.
2. The input for "SetLightDimness" could be represented well as a float for percise sanity calculation. There is no return type/value.
3. The input for the method "DidPlayerHitBeat" would be a float vale representing the time pressed. It will then return a boolean value true/false after comparing the time pressed with the goaltime.

## Activity 2
1. A metaphor for classes and componenets could be preparing food. The class would be the recipe, with it's member variables being the ingredients and methods being quite literaly the methods used to prepare the ingredients. Components would be the final finished dish utilizing the class(recipe).

## Activity 3
1. I think the balls get extremely bright due to the color changing with its speed when it eventually goes "super sayian" after bouncing enough times.

## Activity 4
1. I added a rigid body to both the cat and ball. I also enabled trigger on the goal because the goal needed to detect when the ball object passed through so it could score the goal.
2. My _goalVfx.Play(); wasn't working but then I realized I needed to put it in the MadeGoal() Method.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 