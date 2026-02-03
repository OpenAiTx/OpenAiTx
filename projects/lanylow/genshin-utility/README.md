# Genshin Utility [![License](https://img.shields.io/badge/License-GPL3.0-green.svg)](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) ![OS](https://img.shields.io/badge/OS-Windows-yellow.svg) [![Discord](https://img.shields.io/badge/chat-discord-informational)](https://discord.gg/MrtJvV5tKv)

Free and open-source tool for Genshin Impact and Honkai: Start Rail that includes a few quality-of-life features. Compatible only with the OS version of the game.

## FAQ

### How to load the mod?
1. Download and extract binaries from the [latest release](https://github.com/lanylow/genshin-utility/releases).
2. Open `loader.exe` **as administrator**, a window should pop up informing you that it's waiting for the game.
3. Now with that running, open Genshin Impact or Honkai: Star Rail.
4. The game will open and the mod will be loaded.

### How do I open and close the menu?
By default the key used to toggle the menu is <kbd>INSERT</kbd>, however you can change it by modifying the configuration file.

### Where is my configuration saved?
The `genshin-utility` folder within your Documents directory contains the saved configuration file in `.ini` format. After some updates, it may be necessary to delete and recreate the configuration file.

### What do I do if the Genshin Utility menu doesn't pop up?
The most common cause of this problem are third-party overlays. Make sure programs such as MSI Afterburner (RTSS) or Discord Game Overlay are not attached to the game, because they might interfere with the menu of this tool. Another possible cause is that you are not running the game through the launcher, this program will not work if you open the game's executable directly.

## Screenshots

![image](https://github.com/lanylow/genshin-utility/assets/31806776/88492fe8-4016-447a-80ec-b8c4d9225cc9)

## Utilized third-party libraries

* [imgui](https://github.com/ocornut/imgui) - Graphical User interface for C++
* [minhook](https://github.com/TsudaKageyu/minhook) - API Hooking Library for Windows
* [mini](https://github.com/metayeti/mINI) - INI file reader and writer

## License

This project is licensed under the GPL-3.0 License - see the [LICENSE](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) file for details.
