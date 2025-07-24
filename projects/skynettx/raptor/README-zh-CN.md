
# 猛禽
基于 nukeykt 逆向工程的《猛禽：阴影之战》代码库

## 媒体
点击缩略图观看展示项目运行的视频  

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/Nt2HfchiudY/0.jpg)](https://www.youtube.com/channel/UCedmTTlonJK5DvkiMpA_teQ)
## 信息
原《猛禽：阴影之战》作者 Scott Host 正在开发经典游戏的现代化新版本，名为《猛禽重制》。如果你是猛禽粉丝，支持该项目的 Kickstarter 会很酷。更多信息请访问 [www.mking.com](https://www.mking.com)

## 快速开始
发布版本可用于 Windows 和 macOS。
所有发布版本仅包含共享版 1.2 的资源（GLB 文件）。
如果想玩完整版，必须自行获取完整版 1.2 的资源（GLB 文件）并复制到安装目录。
要下载适用于您平台的最新发布版本，请点击 [下载](https://github.com/skynettx/raptor/releases/latest)。
然后按照安装程序的说明在系统上安装下载的发布版本。
就这样，猛禽现在可以玩了。
想自行构建或需要更多配置信息的，请继续往下，否则您已完成。

## 安装
您需要《猛禽：阴影之战》v1.2 共享版或完整版的原始资源（GLB 文件）。
重要提示，仅支持 DOS 版本 v1.2！您必须自行获取这些文件。  
资源可以从当前工作目录（猛禽目录）或外部系统特定目录加载。
**请注意，发布版本 0.8.0 不支持外部系统特定目录，所有资源、配置和存档文件均管理于当前工作目录。**
外部系统特定目录如下：

```
 Windows: Users\Username\AppData\Roaming\Raptor\  
 Linux: ~/.local/share/Raptor/
 macOS: ~/Library/Application Support/Raptor/
```
配置文件 `SETUP.INI` 和存档文件也会在这些文件夹中加载和保存。  
在其他非官方支持的系统上，Raptor 目录用于加载和保存配置文件和存档文件。  
将构建目录中的 `raptor.exe`（Windows）或 `raptor`（Linux 或 macOS）复制到 Raptor 目录。  
为了通过 TinySoundFont 支持 MIDI，将音色库 `TimGM6mb.sf2` 从 `include\TimGM6mb\` 复制到 Raptor 目录。  
在 Windows 下，将文件 `SDL.dll` 从 `include\SDL2-devel-2.28.2-VC\SDL2-2.28.2\lib\x86\`（32 位安装）或  
`include\SDL2-devel-2.28.2-VC\SDL2-2.28.2\lib\x64\`（64 位安装）复制到 Raptor 目录。  
在 Linux 下，从相应发行版的软件包管理器安装 lib-sdl2。使用 macOS 时，从 dmg 或通过 brew 等包管理器安装 lib-sdl2。  
### 共享软件  
将以下文件复制到 Raptor 或外部系统特定目录：  
```
FILE0000.GLB  
FILE0001.GLB  
```
### 完整版本
将以下文件复制到Raptor或外部系统特定目录：
```
FILE0000.GLB  
FILE0001.GLB  
FILE0002.GLB  
FILE0003.GLB  
FILE0004.GLB  
```
### 配置
您可以构建或下载 [Raptor Setup](https://github.com/skynettx/raptorsetup.git) 来创建和编辑  
`SETUP.INI`，或者按如下方式手动编辑。  
将构建目录中的 `SETUP(ADLIB).INI` 或 `SETUP(MIDI).INI` 文件复制到外部系统特定目录（Windows、Linux 和 macOS）或 Raptor 目录（仅限非官方支持的系统），并重命名为 `SETUP.INI`。  
如果您想通过 TinySoundFont 库使用 MIDI，请将 `TimGM6mb.sf2` 重命名为 `SoundFont.sf2`，或在 `SETUP.INI` 文件中指定文件名：  
`SoundFont=SoundFont.sf2`  
您可以使用任何其他 GM 兼容的 sf2 格式 soundfont。为了更好的 MIDI 音质，我推荐 FluidR3_GM.sf2。  
该字体大小为 140 MB，因此未包含在仓库中。  
要使用以下输入设备之一，请在 `SETUP.INI` 文件的 [Setup] 部分下设置 `Control=0`：  
`Control=0` 键盘  
`Control=1` 鼠标  
`Control=2` 操纵杆（游戏控制器）  
在 `SETUP.INI` 文件的 [Setup] 部分中，Haptic（游戏控制器震动支持）可以开启或关闭：  
`Haptic=0`  
`Haptic=1`  
如果您想关闭在 `Control=2` 模式下通过操纵杆的菜单指针控制，并在所有输入模式下启用新的操纵杆菜单控制，请在 `SETUP.INI` 文件的 [Setup] 部分设置：  
`joy_ipt_MenuNew=0`  
`joy_ipt_MenuNew=1`  
系统 MIDI 支持（Windows 多媒体，Linux ALSA，macOS CoreAudio 和 macOS CoreMIDI）可以在 `SETUP.INI` 文件的 [Setup] 部分中开启或关闭：  
`sys_midi=0`  
`sys_midi=1`  
对于 Windows 多媒体，MIDI 设备在 `SETUP.INI` 文件的 [Setup] 部分下设置：  
`winmm_mpu_device=0`  
Linux 下 ALSA MIDI 的客户端和端口，在 `SETUP.INI` 文件的 [Setup] 部分设置：  
`alsa_output_client=128`  
`alsa_output_port=0`  
要使用 ALSA MIDI 的软件合成器，例如安装您的发行版软件包管理器中的 timidity 和 soundfont-fluid。  
macOS 上使用软件合成器 DLS synth 的 CoreAudio 支持可以在 `SETUP.INI` 文件的 [Setup] 部分开启或关闭：  
`core_dls_synth=0`  
`core_dls_synth=1`  
如果您想在 macOS 上使用 CoreMIDI，必须在 `SETUP.INI` 文件中关闭 `core_dls_synth=0`。  
您可以在 `SETUP.INI` 文件的 [Setup] 部分设置 CoreMIDI 端口如下：  
`core_midi_port=0`  
要在全屏模式下游戏退出后显示文本模式结束画面，请在 `SETUP.INI` 文件的 [Video] 部分设置：  
`txt_fullscreen=0`  
`txt_fullscreen=1`  

## 构建
该项目支持 msvc、gcc 和 clang 编译器。  
当您在系统上安装了 git 后，可以通过输入 `git clone https://github.com/skynettx/raptor.git` 克隆仓库。

### Windows
您可以使用位于 `msvc\` 的 Visual Studio 2022 项目文件，或位于 `gcc\` 的 CodeBlocks 项目文件。

### Linux
请记得安装所需依赖 lib-sdl2。在某些发行版中，如 Debian 或 Ubuntu，有一个额外的 libsdl2-dev 软件包。  
您可以使用位于 `gcc\` 的 CodeBlocks 项目文件。  
否则，您可以使用 cmake。要使用 cmake，请在仓库根目录输入：  

```
mkdir build  
cd build  
cmake ..  
make  
```
### macOS
安装所需的依赖项 lib-sdl2。要构建，请使用 cmake，在仓库根目录输入：

```
mkdir build  
cd build  
cmake ..  
make  
```
## 常见问题解答
1. Linux下无音频：  
请确保从您的发行版的软件包管理器安装了所有必要的ALSA和/或PulseAudio依赖项。
2. 我在哪里可以更改视频设置：  
视频设置可以在配置文件 `SETUP.INI` 中设置。要切换全屏模式，请在 [Video] 部分将 `fullscreen=0` 
编辑为 `fullscreen=1`。或关闭宽高比模式，将 `aspect_ratio_correct=1` 改为 `aspect_ratio_correct=0`。

## 致谢
特别感谢 [nukeykt](https://github.com/nukeykt) 和 [wel97459](https://github.com/wel97459) 对重构源码的卓越贡献。
非常感谢 [Scott Host](https://www.mking.com) 的大力支持。
还要感谢 [schellingb](https://github.com/schellingb) 提供的优秀 TinySoundFont 库，以及所有来自
[chocolate-doom 项目](https://github.com/chocolate-doom) 的贡献者，感谢他们出色的 libtextscreen。 此外，
非常感谢 Tim Brechbill 提供的 TimGM6mb 声音字体。










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---