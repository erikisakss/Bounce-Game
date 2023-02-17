### Bounce!

In order to practice concept of inheritance, interfaces and abstract classes, we are going to create a simple graphical application that only consists of circles, lines and boxes. The idea is to have several moving balls (drawn as simple circles) and several stationary boxes that can affect the moving balls.

This repository contains a small skeleton C# solution as a starting point. The solution is only guaranteed to work under Windows, since the status of WinForms on the other platforms is unclear as of now.

![Bounce screenshot](https://github.com/dva222-mdu-vt23/bounce-template/blob/f1056c6a237eb11d9cf909b279059294d139852c/Bounce.png)

The above image shows different obstacles. Your program must include all kinds of obstacles, but it is ok to randomize or otherwise change the layout. The important thing is that the balls interact with all kinds of obstacles when the program is run.  

The different obstacles shown in the should interact with the balls as follows:

- Vertical lines (yellow) should reflect the ball back by changing their X-speed.
- Horizontal lines (green) should reflect the ball by changing the Y-speed.
- Red boxes are SpeedUp Boxes. They allow the balls to pass through them but meanwhile increase their speed. The direction of the ball does not change while moving through them.
- Blue boxes are SpeedDown Boxes. They allow the balls to pass through them but meanwhile decrease their speed. The direction of the ball does not change while moving through them.

### Steps
To complete this assignment follow the steps below.

1. Try to run the skeleton C# solution. It should draw some moving balls. It is perfectly allowed to change the skeleton code as long as the assignment remains essentially the same and you can argue for why the changes are good!
2. Read the code. Analyze the design and implementation.
3. Design a class diagram detailing the different classes and their connections.
4. Implement the assignment based on the design. Revise the design if needed - iteration may be necessary. Make sure to use Git appropriately and commit changes continuosly.
5. Hand in your solution using a pull request.


### Requirements
This lab is intended to be a an exercise in inheritance, interfaces and abstract classes. The demands are:

- All obstacles (squares and lines) should be treated the same w.r.t. the engine; perhaps by using an interface. Do not use fully abstract classes!
- All obstacles should share as much code as possible, but only code that makes sense to share; use abstract classes if necessary to avoid inheriting methods that do not make sense or empty methods.

### Git and handing in

Ensure that you follow the steps below to avoid issues.

1. push frequent small, well documented updates
2. create a *feedback* branch to work in 
3. always push into the *feeback* branch
4. never push into the *main* branch as this prevents you from handing in properly
5. always include your names and student ids in the README.md file - otherwise we might not be able to attribute your assignment to you
6. when done create a pull request from the *feedback* branch into the *main* branch
7. tag both graders as reviewers

### Resources
You might find the following resources helpful.

See the [Graphics Class](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics?redirectedfrom=MSDN&view=dotnet-plat-ext-7.0) for more information on the drawing primitives.
For information on collision detection you can have a look at [Circle/Rectangle intersection](https://stackoverflow.com/questions/401847/circle-rectangle-collision-detection-intersection) and [Circle/Line intersection](https://stackoverflow.com/questions/1073336/circle-line-segment-collision-detection-algorithm).
