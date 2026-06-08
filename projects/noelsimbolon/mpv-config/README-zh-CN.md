# mpv 配置

![mpv logo](https://raw.githubusercontent.com/mpv-player/mpv.io/master/source/images/mpv-logo-128.png)

## 概述

**mpv** 是一款自由（既指自由又指免费）、开源且跨平台的媒体播放器。它支持
多种媒体文件格式、音频和视频编码器以及字幕类型。

本仓库包含我个人使用的 mpv 配置和脚本，显著优于默认的 mpv、VLC 和 MPC。安装前，请花时间仔细阅读整份 README，因为常见问题仅需仔细阅读即可轻松解决。

## 预览

[![preview.png](https://i.postimg.cc/8zNHHPHy/preview.png)](https://postimg.cc/VdZnsw2M)

## 安装

### Windows

以下是在 Windows 上安装 mpv 并使用我的配置文件的步骤：
* 从 [mpv.io/installation](https://mpv.io/installation/) 或直接从 [这里](https://sourceforge.net/projects/mpv-player-windows/files/) 下载 shinchiro 提供的最新 64 位 mpv Windows 版本，并解压到你喜欢的目录。这就是你的 mpv 文件夹
* 以管理员权限运行位于 `installer` 文件夹中的 `mpv-install.bat`，方法是右键点击选择“以管理员身份运行”
* 下载本仓库的 ZIP 文件（或者你可以用 git 克隆它）
* 在 `mpv.exe` 所在目录下创建一个名为 `portable_config` 的文件夹（**这很重要**）
* 将你下载的仓库内容解压或复制到 `portable_config` 文件夹中
* 为使某些脚本工作，你需要稍微修改发布版本的脚本：
  * 为使 `mpv-gif.lua` 脚本工作，它需要启用 libass 的 [FFmpeg](https://ffmpeg.org/) 并且能通过终端访问。详情请参阅该脚本源仓库的[安装说明](https://github.com/Scheliux/mpv-gif-generator#installation)。
  * **（可选）** 默认情况下，`mpv-gif.lua` 脚本将 GIF 保存到 `C:/Program Files/mpv/gifs`。要修改此路径，请用文本编辑器打开位于 `portable_config/script-opts` 文件夹中的 `gif.conf`，并按需指定 `dir`（GIF 输出目录）。例如 `dir="C:/Users/USERNAME/Pictures/mpv-gifs"`。
* **（可选）** 制作你自己的 mpv 配置。你可以通过修改我的配置文件和/或从头制作自己的配置，或修改其他人的配置。查看[有用链接](#useful-links)部分了解 mpv 配置指南。
* 一切就绪。

### Linux

以下是在 Linux 上安装 mpv 并使用我的配置文件的步骤：

* 使用你 Linux 发行版自带的软件包管理器安装 mpv 和 xclip（剪贴板命令行接口）。xclip 是 [copy-time.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/copy-time.lua) 和 [seek-to.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/seek-to.lua) 脚本正常工作的必要依赖。mpv 和 xclip 的软件包名称可能因发行版不同而异。这里以使用 `pacman` 作为包管理器的 Arch Linux 为例。


  ```
  sudo pacman -S mpv xclip
  ```
  如果您使用的是 Fedora Linux，它自带 `dnf` 作为包管理器，您可以使用以下命令来安装 mpv 和 xclip。

  ```
  sudo dnf install mpv xclip
  ```
如果您使用其他 Linux 发行版，请参考您所用发行版的软件包管理器的文档，了解如何安装软件包。

* 将此仓库下载为 ZIP 文件（或使用 git 克隆），并解压/复制到您的标准 mpv 配置目录，即 `~/.config/mpv`
* 需要注意的几点：
  * 为使 `mpv-gif.lua` 脚本工作，需安装启用了 libass 的 [FFmpeg](https://ffmpeg.org/)，且可通过终端访问。详情请参见脚本源仓库中的[安装说明](https://github.com/Scheliux/mpv-gif-generator#installation)。
  * **（可选）** 默认情况下，`mpv-gif.lua` 脚本将 GIF 保存到 `~/Videos/mpv-gifs`。如需修改，请用文本编辑器打开位于 `portable_config/script-opts` 文件夹中的 `gif.conf`，并按需指定 `dir`（GIF 的输出目录）。例如：`dir="~/Videos"`。
* **（可选）** 创建您自己的 mpv 配置。您可以通过修改我的配置文件和/或从头开始制作自己的配置，或修改他人配置来实现。请查看 [有用链接](#useful-links) 部分的 mpv 配置指南。
* 一切就绪。

## 脚本

来自外部来源的脚本：

* audio-visualizer.lua ([源代码](https://github.com/mfcc64/mpv-scripts#visualizerlua))\
  各种音频可视化。仅在打开音频文件时工作。
  
* autoload.lua ([源代码](https://github.com/mpv-player/mpv/blob/master/TOOLS/lua/autoload.lua))\
  自动加载当前播放文件前后的播放列表条目，通过扫描目录实现。

* copy-timestamp.lua ([源代码](https://github.com/linguisticmind/mpv-scripts/tree/master/copy-timestamp))\
  将当前时间码（格式为 HH:MM:SS.MS）复制到剪贴板。跨平台支持（Mac、Windows、Linux）。

* cycle-commands.lua ([源代码](https://github.com/CogentRedTester/mpv-scripts#cycle-commands))\
  按键切换一系列命令。循环中的每次迭代可以包含任意数量的命令。语法细节见文件顶部。

* cycle-profile.lua ([源代码](https://github.com/CogentRedTester/mpv-scripts#cycle-profile))\
  循环切换通过脚本消息传递的配置文件列表，并将配置描述打印到 OSD。更多详情见文件顶部。

* modernz.lua ([源代码](https://github.com/Samillion/ModernZ))\
  MPV 的现代 OSC UI 替代，保留了默认 OSC 的功能。

* mpv-gif.lua ([源代码](https://github.com/Scheliux/mpv-gif-generator))\
  用于从视频播放生成 GIF 的脚本。需要启用了 libass 的 FFmpeg。目前带字幕导出 GIF 功能尚不完善。

* playlistmanager.lua ([源代码](https://github.com/jonniek/mpv-playlistmanager))\
  以直观方式查看和操作播放列表。

* seek-to.lua ([源代码](https://github.com/dexeonify/mpv-config/blob/main/scripts/seek-to.lua))\
  通过键盘输入或从剪贴板粘贴，跳转到指定的绝对时间戳。


* sponsorblock-minimal.lua ([源代码](https://codeberg.org/jouni/mpv_sponsorblock_minimal))\
  跳过YouTube视频中的赞助片段。

* thumbfast.lua ([源代码](https://github.com/po5/thumbfast))\
  mpv的高性能实时缩略图生成器。**该脚本本身不显示缩略图**，它旨在与调用thumbfast的UI脚本一起使用。

这些脚本的配置文件可以在`script-opts`文件夹中找到。我还修改了部分脚本的默认快捷键。要查看我的修改，请在`input.conf`中查找脚本快捷键绑定。

## 着色器

`shaders`文件夹中包含的着色器：

* ArtCNN_C4F32 ([源代码](https://github.com/Artoriuz/ArtCNN/blob/main/GLSL/ArtCNN_C4F32.glsl))\
  用于亮度分量放大。

* nnedi3-nns128-win8x4 ([源代码](https://github.com/bjin/mpv-prescalers/tree/master))\
  用于亮度分量放大。

请根据您的偏好和系统性能选择着色器。有关着色器的更多信息，请参阅[实用链接](#useful-links)部分的资源。

## 实用链接

* The Wiki 的 [mpv 教程](https://thewiki.moe/tutorials/mpv/)
* iamscum 的 [mpv.conf 指南](https://iamscum.wordpress.com/guides/videoplayback-guide/mpv-conf/)
* Kokomins 的 [mpv 视频观看配置指南](https://kokomins.wordpress.com/2019/10/14/mpv-config-guide/)
* João Vitor Chrisóstomo 的 [mpv 重采样](https://artoriuz.github.io/blog/mpv_upscaling.html)

## 官方链接

* [mpv 主页](https://mpv.io/)  
* [mpv 维基](https://github.com/mpv-player/mpv/wiki)
* [mpv 常见问题](https://github.com/mpv-player/mpv/wiki/FAQ)
* [mpv 手册](https://mpv.io/manual/stable/)
* [mpv 用户脚本](https://github.com/mpv-player/mpv/wiki/User-Scripts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---