# DyberPet - Genshin Impact Edition

> [!IMPORTANT]
> ## ⚠️ This repository is no longer maintained, please switch to the new version DyberPet
>
> **The Genshin Impact edition of DyberPet was merged into the new [DyberPet](https://github.com/ChaozhongLiu/DyberPet) framework years ago.**
>
> This repository will no longer be updated and continued use is not recommended.  
> You only need to carry the character folder to migrate to the new DyberPet and enjoy more features.
>
> 👉 **Please visit the new repository: [ChaozhongLiu/DyberPet](https://github.com/ChaozhongLiu/DyberPet)**

----
[![License](https://img.shields.io/github/license/ChaozhongLiu/DyberPet.svg)](LICENSE)
![DyberPet Version](https://img.shields.io/badge/DyberPet-v0.2.2-green.svg)  
DyberPet (呆啵宠物) Genshin Impact Edition is a Genshin Impact desktop pet created based on the [DyberPet](https://github.com/ChaozhongLiu/DyberPet) framework, with artwork by [@栎曦_Nuo](https://space.bilibili.com/14004864).  

🆕 The **refactored UI version** is now live at the [DyberPet homepage](https://github.com/ChaozhongLiu/DyberPet)! The new version includes backup saves, adding characters, and a more user-friendly UI. Feel free to try it and provide feedback!
  
If you like this desktop pet app, please click the top right :star:**Star**, which greatly encourages us to continue development!  
Meanwhile, more characters, items, and features will be added gradually. Please follow [@栎曦_Nuo](https://space.bilibili.com/14004864) and this repository for the latest updates.  

If you encounter any issues while using, you can DM me [@哦哟喔嚯](https://space.bilibili.com/39307302) or raise an issue on the [Issues page](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/issues).

:warning:  ~~Recently I have been busy with PhD graduation and job hunting, so the framework cannot be updated promptly, apologies. Updates and fixes are expected to resume around mid-October.~~ :beers:  
A new round of UI refactoring is underway, along with adding convenient operation functions. Updates may be slow due to busy schedule, please understand!
 
  
For the **English and other language** versions of the app, please see our [Alpha version of DyberPet](https://github.com/ChaozhongLiu/DyberPet/releases/tag/v0.3.0a).  
Please :star:**Star** to get updates later!



## Quick Start
### Windows Users
  **First time use**: Download the repository [here](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/archive/refs/heads/main.zip) locally, unzip and double-click **``DyberPet-Genshin.exe``** to run  
  (The .exe program cannot leave the folder but you can create a desktop shortcut)
  
  
  **Version update**: If you are already using DyberPet desktop pet, overwrite the old version with the latest files downloaded [here](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/archive/refs/heads/main.zip)  
  (Overwrite all, the ``data`` folder will be preserved, data will not be lost)
  
  **Baidu Netdisk**: [Link](https://pan.baidu.com/s/1dLY0ZfFcTRySuU4tXv1-pA?pwd=bs1d) | Extraction code: bs1d  
  **Quark Netdisk**: [Link](https://pan.quark.cn/s/a070df462217) | Extraction code: 7RD4

### Linux / MacOS Users
  
  **Mac Beta**
  **Quark Netdisk**: [Link](https://pan.quark.cn/s/6386f4b5efc9) | Extraction code: D3VR  
  Feel free to join the group to report bugs and questions, and get the latest updates! ``233305772``  
  **Q: The program is corrupted and won't open**:   
  **A:** This is an issue with third-party app permissions, not actual corruption. Please refer to the solution here: https://macoshome.com/course/1699.html
  
  You can also achieve this via [this comment](https://www.bilibili.com/read/cv21890026) (Thanks to Bilibili user [@洛天依_Linux](https://space.bilibili.com/495653264))
  

## User Manual
Please refer to this [Simple User Manual](https://raw.githubusercontent.com/ChaozhongLiu/DyberPet_GenshinImpact/main/用户手册.pdf), or watch the [Bilibili video](https://www.bilibili.com/video/BV1fd4y1W7ht) to experience the current features.


## Changelog

<details>
  <summary>Version Update List</summary>
  
**  **
  
**v0.2.2 - 03/05/2023**
- Modified persistent action data structure, bug fixes
- Added persistent action determination for companions, settings needed when it is the main pet
  
**v0.2.2 - 03/05/2023**
- New character: Xiao
- Added mouse-following feature
- Added persistent action option in right-click menu, which changes the default idle action; when selected, other actions will not play randomly
- Inventory split into food and collectibles sections
  
**v0.2.1 - 02/23/2023**
- Optimized scaling mechanism
- Item count does not display number when quantity is 1
- Optimized the main pet list judgment and the saving method of the default pet
  
**v0.2.0 - 02/22/2023**
- Added favorability level reward compensation
- Added 4 sets of dialogues each for Wanderer and Nahida, available at favorability levels 2, 3, 4, and 5
  
**v0.2.0 - 02/19/2023**
- Reduced Nahida's model size
- Fixed bug where companion time toggled on/off when switching characters
  
**v0.2.0 - 02/18/2023**
- Added new character - Wanderer
- Increased favorability level cap to 8 (rolled up doge)
- Added option to select default character at startup in settings
  
**v0.1.19 - 02/16/2023**
- Mute option added in settings
- Added function to count companion days and display nameplates
- Dialog box automatically adds a back button (assets not yet implemented)
- Adjusted length calculation for special Chinese characters
  
**v0.1.18 - 02/11/2023**
- Added connection between affiliated pets and main pets
- Ensured collectibles do not appear repeatedly in random drops
- Organized changeable system values
  
**v0.1.18 - 02/11/2023**
- Fixed error in backpack button display when recalling Paimon via right-click menu
  
**v0.1.18 - 02/10/2023**
- Added dialogue interface and functions (assets not yet implemented)
- Added item attribute: ``pet_limit`` to designate items that appear only within certain pets (preparing for multiple upcoming characters)
  
**v0.1.17 - 02/06/2023**
- Collectible backpack slots pinned to top, background color set to light blue
- Collectibles can be recalled in the backpack (e.g., if Paimon is lost due to bug, can be recalled in backpack interface)
  
**v0.1.17 - 02/05/2023**
- Added ``sound_priority`` attribute to notification system voice
- Added random voice events on click
- Added Nahida's voice library
  
**v0.1.16 - 02/02/2023**
- Fixed the anchor point issue of companion actions
- Fully supports multiple screens (testing)
  
**v0.1.15 - 02/01/2023**
- Fixed Paimon's size change when screen scaling is enlarged
- Fixed flickering when dragging attachments
- Fixed incomplete display when summoning companions with scaling
- Fixed Paimon's position issue when scaling pets under certain conditions
  
**v0.1.15 - 01/31/2023**
- Avoided crash bug related to focus time 0 minutes 0 seconds
- Fixed the huge bug of unspeakable frenzy items
- The stop button becomes immediately invalid after being pressed to avoid multiple settlements
- Fixed flickering bug caused by slight mouse movement during rapid clicks
  
**v0.1.15 - 01/30/2023**
- Numeric bar font fixed to Times
- Added option to pin or not in settings
- Satiety decrease unit time changed to 4 minutes
- Added level 3 and 4 favorability upgrade rewards
- To simplify the update process, the ``data`` folder was deleted and will be generated automatically on first run.
  
**v0.1.14 - 01/29/2023**
- Minimum gravity acceleration changed to 0.01
- Removed screen scaling effect on pet size; users can adjust it in settings
  
**v0.1.14 - 01/28/2023**
- Fixed boundary judgment bug when scaling changes
- Improved logic for starting voice selection
  
**v0.1.14 - 01/27/2023**
- After four months of development, Daibo Pet - Genshin Impact version officially launched!


</details>

## Join Us  

If you also want to develop a new set of pet images, actions, and items, you can refer to the currently unfinished [Asset Development Document](https://github.com/ChaozhongLiu/DyberPet/blob/main/docs/art_dev.md), and you are also welcome to DM me on Bilibili [@哦哟喔嚯](https://space.bilibili.com/39307302) and [@栎曦_Nuo](https://space.bilibili.com/14004864) to join us in making things happen!

If you want to develop the DyberPet framework together, feel free to DM me on Bilibili [@哦哟喔嚯](https://space.bilibili.com/39307302), and let's bravely conquer the mountain of shit together!

## Copyright Statement
- Pet asset copyrights belong to miHoYo, please do not use commercially!
- The splitting and action design of pet assets come from Bilibili [@栎曦_Nuo](https://space.bilibili.com/14004864). Please indicate the source when reposting or using.
- DyberPet follows the GPL v3.0 license. When developing or using, please credit the author GitHub@ChaozhongLiu




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---