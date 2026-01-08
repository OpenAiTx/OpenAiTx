<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  A collection of modifications, enhancements, and reverse engineered resources for Creation Kit by Bethesda.
</p>

# Description
**CKPE** a shared source powerful platform makes numerous fixes and improvements to the Creation Kit editor from **Bethesda**, includes editor support for games such as **Skyrim Special Edition**, **Fallout 4**, **Starfield**, is a successor to the [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) projects, also [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test) which started it all for the author of **perchik71**.  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) page  

# Dependencies
[toml11](https://github.com/ToruNiina/toml11) by `ToruNiina` and other  
[Zydis](https://github.com/zyantific/zydis.git) by `zyantifi` and other  
[zipper](https://github.com/kuba--/zip.git) by `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) by `ebiggers` and other  
[xbyak](https://github.com/herumi/xbyak.git) by `herumi` and other    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) by `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) by `perchik71` *(recursive)*

# Install
### Fresh Install
Download any [supported game](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) and install Creation Kit.  
Download [latest release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) of **CKPE** for your game.  
Extract all contents into game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.
### Update
Download [latest release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) of **CKPE** for your game.  
Extract all contents into game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.  
Agree to replace all files.
### Compilation
Regular users only need this method to access the newest features which haven't been released yet.  
Open a project in **`Visual Studio 2022`** or later. Build the project in **`Release`** mode or **`Release-NoAVX2`**.  
Then move your build output into game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.  
If you are asked to replace old files agree to replace all.
### Automate builds (Beta)
Download [latest commit build](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) of **CKPE** for your game.  
Extract all contents into game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.  
Possible errors.

# Credits
[Nukem9](https://github.com/Nukem9) (for experimental functions, hash and so on, very useful)  
[adzm](https://github.com/adzm) (I really appreciate your work, you have [done](https://github.com/adzm/win32-custom-menubar-aero-theme) what I have long wanted to do myself)  
[yak3d](https://github.com/yak3d) (For the contribution and development of workflow and support newest Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (For the design of the readme)  

# License
Starting with the v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) project is licensed by [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Early versions is licensed by [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. All rights reserved. <br />
File `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contains proprietary and not licensed files; the same applies to files in `d3dcompiler\*.*`. <br />
Dependencies are under their respective licenses. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-08

---