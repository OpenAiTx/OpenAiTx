# twitch-downloader-gui

这是一个针对优秀项目 [TwitchDownloader](https://github.com/lay295/TwitchDownloader) CLI 版本的图形界面包装器，仅限 Linux。  
我使用了库 [libui-ng](https://github.com/libui-ng/libui-ng) 并附加了一些额外的 [补丁](https://github.com/mohad12211/libui-ng)。  
该库仍处于中期 alpha 阶段，但它是一个很有前景的项目，简单、跨平台（macos 也可以做，我只是没太关心），且非常直观。

# 预览

![preview](https://user-images.githubusercontent.com/51754973/167058990-a574493a-fd44-4f12-be59-185798fb93bf.gif)

# 安装

> [!IMPORTANT]  
> **这只是 CLI 的一个包装器，你仍然需要 `TwitchDownloaderCLI` 可执行文件。默认情况下，应用会尝试从你的 `PATH` 中查找该二进制文件，  
如果你不想把 `TwitchDownloaderCLI` 放入你的 `PATH`，可以在设置中指定二进制文件路径。确保 `TwitchDownloaderCLI` 是可执行的。**

Debian、Fedora 以及 [AUR](https://aur.archlinux.org/packages/twitch-downloader-gui) 提供了对应的软件包。

### 依赖项

- ffmpeg（渲染聊天和视频点播必需）  
- libcurl  
- TwitchDownloaderCLI（见下文）

# 编译

### 编译依赖

- make  
- libcurl（开发版）  
- gtk3（开发版，Ubuntu 上称为 libgtk-3-dev）

libui 的静态库在仓库中，但你也可以使用自己编译的版本替换，说明见 [这里](https://github.com/mohad12211/libui-ng/blob/customs/README.md#quick-building-instructions)


```
$ git clone https://github.com/mohad12211/twitch-downloader-gui.git
$ cd twitch-downloader-gui
$ make
$ make install # (if you want to install the app to your system)
$ make uninstall # (to uninstall)
```

二进制文件位于 `build/bin`

# 它包含所有功能吗？有任何错误吗？

它包含基本功能，没有任务队列。

## 错误...

- 你只能下载点播视频的最高质量（我会尽快解决）。

请报告任何错误。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---