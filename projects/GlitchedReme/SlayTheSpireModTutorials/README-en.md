Slay the Spire Modding Tutorial
=====================

"Slay the Spire 2" Modding Tutorial Updating: https://github.com/GlitchedReme/SlayTheSpire2ModdingTutorials

<b>This tutorial does not cover Java programming knowledge; it is recommended to have some programming basics before learning.</b>

<b>If readers find errors or unreasonable parts while reading this tutorial, you can help improve it by submitting issues.</b>

<b>If you have any questions, you can join the group chat below or raise your questions in the discussions above.</b>

<b>Click the Tutorials folder above or the [Tutorial Website](https://glitchedreme.github.io/SlayTheSpireModTutorials/) on the right to view all tutorials.</b>

Personal group chat: 542370192

# Some Useful Tools/Websites

## Contents
* [Websites](#websites)
* [Tools](#tools)
* [Mod Templates](mod样板)
* [Animations](#animations)

## Websites
* [ModTheSpire Wiki](https://github.com/kiooeht/ModTheSpire/wiki)<br>
<b>ModTheSpire</b> (abbreviated as MTS) is a tool that loads external mods for Slay the Spire without modifying the base game files, allowing mods to patch their own code into the game code.<br>
The MTS Wiki explains how to do global saves, patches, etc.

* [BaseMod Wiki](https://github.com/daviscook477/BaseMod/wiki)<br>
<b>BaseMod</b> is the base API for mods, enabling mod authors to easily add their own cards and content to the game and centrally manage these contents.<br>
The Wiki includes some very practical utilities, such as automatic registration of all cards (AutoAdd), card modifiers (CardModifier), in-game save per run (CustomSavable), etc. It also includes modding tutorials written by the BaseMod author.

## Tools
* [JD-GUI](http://java-decompiler.github.io/)<br>
A Java decompiler tool with a GUI.<br>
Allows you to view the reconstructed source code of the game or other mods for easy ~~copying~~ learning from others' code.<br>
Also can be used to find the line numbers needed for patching. (The built-in decompiler of IDEA is inaccurate)

* [Sts Image Cutter](https://github.com/JohnnyBazooka89/StSModdingToolCardImagesCreator)<br>

Crop the image into the shape and size required by Spire Card.<br>
I haven't used this, but there are other tools with the same functionality made by group members in the chat.

## mod templates
* [Warlord Emblem mod](https://github.com/Rita-Bernstein/Warlord-Emblem)<br>
~~Recommended by Rita, guaranteed quality~~<br>
A relatively standardized mod example.

## Animation
* [DragonBones](https://dragonbones.github.io/cn/index.html)<br>
Software that can export spine animations, generally this is enough, you can find a usable version yourself.

*Creating animations requires some basics, but actually most mods only need one image.*
* [Spine](http://zh.esotericsoftware.com/)<br>
2D animation software used by Spire.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---