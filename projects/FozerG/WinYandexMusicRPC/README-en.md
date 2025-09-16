# **<img src="https://raw.githubusercontent.com/FozerG/WinYandexMusicRPC/main/./assets/YMRPC_ico.ico" alt="[DISCORD RPC]" width="30"/> &nbsp;WinSdk + Yandex Music Discord Rich Presence**
[![TotalDownloads](https://img.shields.io/github/downloads/FozerG/WinYandexMusicRPC/total)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![LastRelease](https://img.shields.io/github/v/release/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![CodeOpen](https://img.shields.io/github/languages/top/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/blob/main/main.py "Show code") [![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download")

>Despite the unreasonable decision to block Discord in Russia, I will continue to keep the script working as much as possible 🕊️

>[We will use what we like.](https://github.com/Flowseal/zapret-discord-youtube)

**Discord RPC to show the music you are currently listening to on your computer. Tracks and their covers are loaded from Yandex Music.**

<img src="https://github.com/user-attachments/assets/99d15c70-632f-41ec-a6cd-49de8a7d2a8f" alt="discord" width="340">

There are similar RPCs that show the current track using the Yandex Music API. However, they cannot display information about what is playing from the radio (for example, `My Wave`).

Therefore, I created a script that uses `Windows.Media.Control` to get information about the current track, searches Yandex Music, and displays the track in Discord.

Advantages compared to other scripts:    
No Yandex Music token required ✅  
Shows tracks from playlists, radio ✅  
Not limited to using Yandex Music, you can listen to music even from VKontakte ✅  
Works with both browsers and applications ✅   
Shows pause status ✅  
Shows how much time is left until the track ends ✅  
Status "Listening" instead of "Playing a game" ✅

## Requirements
Tested only on Windows 11 and Windows 10, it will not work on other versions and platforms. **Work is not guaranteed on Lite and Custom trimmed versions of Windows.**

If you do not use the exe file then:  
1. Python <3.14, >=3.10

## How to download and use the Exe?
1. Download the [latest available release](https://github.com/FozerG/WinYandexMusicRPC/releases)
  
2. Open WinYandexMusicRPC

3. The script will automatically hide to the system tray after 3 seconds. Open the console through the tray to make sure it is working.

## How to use main.py?

1. Open the terminal and go to the folder where the `requirements.txt` file is located.
2. Write `pip install -r requirements.txt` to install the dependencies.  
3. In the terminal, write `python main.py`

>To compile the script using [Pyinstaller](https://pypi.org/project/pyinstaller/), run the following command:  
`pyinstaller --noconfirm main.spec`

------------  
If you listen to music not only from Yandex Music, I recommend replacing the line `strong_find = True` with `strong_find = False`, or use the system tray. This will show better search results, but not always accurate.

## Bugs  
Bugs always exist, but first you need to find them 🫡  
If you find a bug, do not hesitate to report it in [Issues](https://github.com/FozerG/WinYandexMusicRPC/issues)  
   
------------  
Please show your interest in this project so I can update it as much as possible.

>The code is not perfect, as Python is not my main language, and the script was written for personal use. However, it can serve as a basis for your own scripts.

>Uses [Yandex Music API](https://github.com/MarshalX/yandex-music-api)  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---