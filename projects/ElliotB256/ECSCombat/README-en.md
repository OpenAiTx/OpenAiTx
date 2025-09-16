# ECSCombat

A sci-fi battle simulation, using Unity's ECS framework.

[![A preview image](https://img.youtube.com/vi/S2RJfbJly_A/0.jpg)](https://www.youtube.com/watch?v=S2RJfbJly_A)

A video of an infinite battle can be seen [here](https://www.youtube.com/watch?v=S2RJfbJly_A).

## Suggestions of what to look at:

* Different AI behaviours can be found in `Battle/AI`.
* Combat systems are found in `Battle/Combat`. This includes different types of weapon (projectile/instant), weapon effectiveness based on range, intercepting attacks with shields.
* Equipment and gear are found in `Battle/Equipment`. Ships can have different equipment attached, and these can have effects like changing the speed or turn rate of ships. Equipment can be damaged and disabled when a ship is attacked, eg damaged engines result in ships being crippled.

## Technical details:

* Unity 2020.1.0b7
* Universal Render Pipeline (ship shaders in shader graph)

## A word of caution!

This project was originally started as a way for me to practice programming in the ECS (Entity-Component-System) style, back when the Unity Entities package was still very young.
Since it began, there have been substantial changes to both the Unity Entities API and what is considered best practice.
I've made an effort to keep things updated when I can, but given my finite amount of free time there will invariably be some places which are in need of work.
So, by all means take inspiration from it, but bear in mind there may be a better way to do some things!

## Final Acknowledgements

Some of the sprites are made by me, but the good looking ones were taken from [here](https://opengameart.org/content/spaceships-1) where they are accredited to [Wuhu](https://opengameart.org/users/wuhu).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---