# 5pm-pet-life

## Project summary
This project was developed with Unity and is about taking care of a virtual pet. This game was developed for the PC platform. 

### One-sentence description of the project
It’s a game that will let the users keep a digital pet for fun.


### Additional information about the project
Users will have their own accounts, choose for their ideal pets, feed and play with it.


## Installation

### Prerequisites

* Unity Version 2018.3.2f1

* OS: Windows 7 SP1+, 8, 10, 64-bit versions only; Mac OS X 10.9+.
* GPU: Graphics card with DX9 (shader model 2.0) capabilities. Anything made since 2004 should work.


### Libraries


### Installation Steps

* Install Unity version 2018.3.2.f1 from here: https://unity3d.com/get-unity/download
* Clone our repo with HTTPS or SSH


## Functionality

First, the game will prompt you to make an account. Afterwards, you can choose a pet to take care of. When taking care of your pet, you have to feed it, play with it, keep it clean, and other various activities. You monitor a "happiness" bar to keep track of how well you're doing in game.


## Known Problems

Provide steps to reproduce the problem and/or name a file or a function where the problem lives.
TO BE UPDATED AS PROGRESS CONTINUES
 
We are aware that after a collision the dog sometimes falls over and cannot get up and sort of uselessly spins around. This is a result of using 3d physics on 2d assets in a 3d environment and we are looking into how to better integrate 2d into 3d (maybe with a constantly updating script) or finding a 3d model.

Animations plays on a slight delay. 

All physics goes out the window once the dog leaves the house. Take the stairs at your own risk.

Camera is not very smooth, sometimes gets blocked by walls of the house. Maybe update SmoothFollow.cs so that it turns whenever it hits a wall.

## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## License
See `LICENSE.txt`

