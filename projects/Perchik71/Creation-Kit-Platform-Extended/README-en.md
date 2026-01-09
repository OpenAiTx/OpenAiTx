
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  A collection of modifications, enhancements, and reverse engineered resources for Creation Kit by Bethesda.
</p>

# Description
**CKPE** is a powerful shared-source platform that brings numerous fixes and improvements to Bethesda’s Creation Kit editor, offering editor support for games such as **Skyrim Special Edition**, **Fallout 4**, and **Starfield**. It is the successor to the [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), and [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) projects, as well as the [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test) that started everything for the author, **perchik71**.

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) page

# Dependencies
[toml11](https://github.com/ToruNiina/toml11) by `ToruNiina` and others  
[Zydis](https://github.com/zyantific/zydis.git) by `zyantifi` and others  
[zipper](https://github.com/kuba--/zip.git) by `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) by `ebiggers` and others  
[xbyak](https://github.com/herumi/xbyak.git) by `herumi` and others  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) by `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) by `perchik71` *(recursive)*

# Install
### Fresh Install
Download any [supported game](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) and install the Creation Kit.  
Download the [latest release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) of **CKPE** for your game.  
Extract all contents into the game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.
### Update
Download the [latest release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) of **CKPE** for your game.  
Extract all contents into the game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.  
Agree to replace all files.
### Compilation
Regular users only need this method to access the newest features that have not yet been released.  
Open the project in **`Visual Studio 2022`** or later. Build the project in **`Release`** mode or **`Release-NoAVX2`**.  
Then move your build output to the game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.  
If prompted to replace old files, agree to replace all.
### Automate builds (Beta)
Download the [latest commit build](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) of **CKPE** for your game.  
Extract all contents into the game directory, so that **ckpe_loader.exe** is in the same folder as **CreationKit.exe**.  
Possible errors.

# Credits
[Nukem9](https://github.com/Nukem9) (for experimental functions, hash, and more—very useful)  
[adzm](https://github.com/adzm) (I really appreciate your work; you have [done](https://github.com/adzm/win32-custom-menubar-aero-theme) what I have long wanted to do myself)  
[yak3d](https://github.com/yak3d) (For contributing to workflow development and supporting the newest Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (For designing the readme)

# License
Starting with v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)), the project is licensed under [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Early versions are licensed under [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. All rights reserved. <br />
The file `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contains proprietary and unlicensed files; the same applies to files in `d3dcompiler\*.*`. <br />
Dependencies are under their respective licenses. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---