# twitch-downloader-gui

This is a gui wrapper for the cli version of the great project [TwitchDownloader](https://github.com/lay295/TwitchDownloader), Linux only.  
I used the library [libui-ng](https://github.com/libui-ng/libui-ng) with a few extra [patches](https://github.com/mohad12211/libui-ng).  
The library is still in mid-alpha, but it's a promising project, simple, cross-platform (macos can be done, I just don't care much about it) and very intuitive.

# Preview

![preview](https://user-images.githubusercontent.com/51754973/167058990-a574493a-fd44-4f12-be59-185798fb93bf.gif)

# Installation

> [!IMPORTANT]  
> **This is a just wrapper for the CLI, you still need the `TwitchDownloaderCLI` binary. By default the app will try to find the binary from your `PATH`,  
if you don't want to put `TwitchDownloaderCLI` in your `PATH` you can specify the binary path from the settings. Make sure that `TwitchDownloaderCLI` is executable.**

Packages available for debian, fedora And [AUR](https://aur.archlinux.org/packages/twitch-downloader-gui).

### Dependencies

- ffmpeg (required to render chat and vods)  
- libcurl  
- TwitchDownloaderCLI (see below)

# Building

### Build Dependencies

- make  
- libcurl (devel version)  
- gtk3 (devel version, called libgtk-3-dev on ubuntu)

static library for libui is in the repo, but you can use your own compiled version and just replace it, instructions [here](https://github.com/mohad12211/libui-ng/blob/customs/README.md#quick-building-instructions)


```
$ git clone https://github.com/mohad12211/twitch-downloader-gui.git
$ cd twitch-downloader-gui
$ make
$ make install # (if you want to install the app to your system)
$ make uninstall # (to uninstall)
```

binary is inside `build/bin`

# Does it include all the features? any bugs?

it includes the basic functionalities, There's no task queue.

## Bugs...

- You can only download the highest quality for the vod (I will solve it soon).

Please report any bugs.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---