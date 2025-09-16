# **<img src="https://raw.githubusercontent.com/FozerG/WinYandexMusicRPC/main/./assets/YMRPC_ico.ico" alt="[DISCORD RPC]" width="30"/> &nbsp;WinSdk + Yandex Music Discord 富媒体状态**
[![TotalDownloads](https://img.shields.io/github/downloads/FozerG/WinYandexMusicRPC/total)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![LastRelease](https://img.shields.io/github/v/release/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![CodeOpen](https://img.shields.io/github/languages/top/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/blob/main/main.py "Show code") [![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download")

>尽管俄罗斯封锁 Discord 是不明智的决定，我仍将尽可能保持脚本的正常运行 🕊️

>[我们将使用我们喜欢的东西。](https://github.com/Flowseal/zapret-discord-youtube)

**Discord RPC 用于显示您当前电脑上正在播放的音乐。曲目和封面来自 Yandex 音乐。**

<img src="https://github.com/user-attachments/assets/99d15c70-632f-41ec-a6cd-49de8a7d2a8f" alt="discord" width="340">

存在类似的 RPC，使用 Yandex 音乐 API 显示当前曲目。但它们无法显示电台播放的内容（例如，`我的波`）。

因此我创建了一个脚本，使用 `Windows.Media.Control` 获取当前曲目信息，搜索 Yandex 音乐并在 Discord 中显示曲目。

相较其他脚本的优点：    
无需 Yandex 音乐令牌 ✅  
显示精选集、电台曲目 ✅  
不限于 Yandex 音乐，音乐可来自 VKontakte 等 ✅  
支持浏览器和应用程序 ✅   
显示暂停状态 ✅  
显示距离曲目结束时间 ✅  
状态显示“正在聆听”而非“正在玩游戏” ✅

## 要求
仅在 Windows 11 和 Windows 10 上测试通过，其他版本及平台不保证可用。**Windows Lite 和 Custom 精简版本可能无法正常工作。**

如果不使用 exe 文件，则需：
1. Python 版本 <3.14，>=3.10

## 如何下载和使用 Exe？
1. 下载[最新版本](https://github.com/FozerG/WinYandexMusicRPC/releases)
  
2. 打开 WinYandexMusicRPC

3. 脚本将在 3 秒后自动隐藏至系统托盘。请通过托盘打开控制台确认运行。

## 如何使用 main.py？

1. 打开终端，进入包含 `requirements.txt` 文件的文件夹。
2. 输入 `pip install -r requirements.txt` 来安装依赖。  
3. 在终端输入 `python main.py`  

>要使用 [Pyinstaller](https://pypi.org/project/pyinstaller/) 编译脚本，请执行以下命令：  
`pyinstaller --noconfirm main.spec`  

------------  
如果你不仅仅使用 Yandex 音乐播放音乐，建议将 `strong_find = True` 改为 `strong_find = False`，或者使用系统托盘。这样搜索结果会更好，但不总是准确。  

## Bug  
Bug 总是存在，但首先需要找到它们 🫡  
如果你发现了错误，请随时在 [Issues](https://github.com/FozerG/WinYandexMusicRPC/issues) 中反馈。  

------------  
请展示你对本项目的关注，这样我才能在可能的情况下持续更新它。  

>代码并不完美，因为 Python 不是我的主要语言，脚本是为个人使用编写的。不过它可以作为你自己脚本的基础。  

>使用了 [Yandex Music API](https://github.com/MarshalX/yandex-music-api)   


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---