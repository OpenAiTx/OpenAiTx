[![tests](https://github.com/krupkat/xpano/actions/workflows/test.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/test.yml)
[![clang-format](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml)
[![clang-tidy](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml)

# xpano

Xpano 是一款专注于简洁易用的全景拼接工具，主要功能包括：

- 自动检测可拼接成全景图的图像组
- 计算全景图的预览 + 缩放 + 平移
- 裁剪模式，边界自动填充，可选择投影类型
- 投影调整：俯仰角、偏航角和滚转角
- 导出包含 exif 元数据的全分辨率全景图


## 构建技术

该应用使用优秀的 [OpenCV](https://opencv.org/) 库进行图像处理，并利用其 [拼接](https://docs.opencv.org/4.x/d1/d46/group__stitching.html) 模块计算全景图。

其他依赖包括 [imgui](https://github.com/ocornut/imgui)、[SDL](https://github.com/libsdl-org/SDL)、[spdlog](https://github.com/gabime/spdlog/)、[Catch2](https://github.com/catchorg/Catch2)、[nativefiledialog-extended](https://github.com/btzy/nativefiledialog-extended)、[alpaca](https://github.com/p-ranav/alpaca)、[thread-pool](https://github.com/bshoshany/thread-pool)、[expected](https://github.com/TartanLlama/expected)、[Exiv2](https://github.com/Exiv2/exiv2)、[multiblend](https://horman.net/multiblend/)、[SIMDe](https://github.com/simd-everywhere/simde) 及 [Google Noto](https://fonts.google.com/noto) 字体。

## 演示

请观看 [YouTube](https://youtu.be/MyiTC3i1hK0) 上的演示视频。

![Main Xpano gui](https://gist.githubusercontent.com/krupkat/55ca0f085c944fb1ea2a7dc2a779f141/raw/f90afd675b1c0430db06a46984cbe5309908ddc1/1.webp)

## 安装

可直接从 Flathub 或微软商店安装：

<a href='https://flathub.org/apps/details/cz.krupkat.Xpano'><img height='70' alt='Download from Flathub' src='https://flathub.org/assets/badges/flathub-badge-en.png'/></a>&nbsp;&nbsp;<a href='https://apps.microsoft.com/store/detail/9PGQ5X33L0SC?launch=true&mode=full'><img height='70' alt='Download from the Microsoft Store' src='https://get.microsoft.com/images/en-US%20dark.svg'/></a>

获取更多软件包：

- Windows 和 MacOS 可执行文件来自 [GitHub](https://github.com/krupkat/xpano/releases)
- Ubuntu 软件包来自我的 [Launchpad PPA](https://launchpad.net/~krupkat/+archive/ubuntu/code)
- Nix 软件包来自 [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=xpano)
- Archlinux AUR： [xpano-git](https://aur.archlinux.org/packages/xpano-git)

## 命令行

Xpano 具有基本的命令行界面支持，您可以在命令行中全自动运行它，或者使用 `--gui` 参数启动图形界面。

```
Xpano [<input files>] [--output=<path>] [--gui] [--help] [--version]
```

## 开发

该项目可以通过运行 `misc/build` 目录下的单个脚本来构建。您需要至少 CMake 3.21、git 和支持 C++20 的编译器。

### NixOS

在仓库根目录运行构建脚本：

```
nix-shell misc/build/nix/default.nix
./misc/build/build-nixos.sh
```

运行时可能出现的问题 - [故障排除](https://gist.github.com/krupkat/cd0adbd584e2bfe154accdb393076fc3)。

### MacOS

库依赖项：SDL2，spdlog，catch2

使用 brew 安装：`brew install sdl2 spdlog catch2`

使用 macports 安装：`sudo port install libsdl2 spdlog catch2`（详情见：[#96](https://github.com/krupkat/xpano/pull/96#issuecomment-1575589249)）

从仓库根目录运行构建脚本：

```
./misc/build/build-macos.sh
```

### Ubuntu 24.04

库前提条件：

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev catch2
```

从仓库根目录运行构建脚本：

```
./misc/build/build-ubuntu-24.sh
```

### Ubuntu 22.04

库先决条件：

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev
```

从仓库根目录运行构建脚本：

```
./misc/build/build-ubuntu-22.sh
```

### Windows

在 Windows 终端中打开“VS 2022 开发者 PowerShell”配置文件，并从仓库根目录运行构建脚本：

```
./misc/build/build-windows-latest.ps1
```
## 贡献

欢迎贡献，当前有几个增强功能的想法列在[未解决的问题](https://github.com/krupkat/xpano/issues)中，您可以选择其中一个开始着手——如果您开始处理其中一个，请在那里添加评论。

请查看[贡献指南](https://github.com/krupkat/xpano/blob/main/CONTRIBUTING.md)以了解有关格式和编码风格的更多细节。

## 许可

本项目采用*GPL-3.0-or-later*许可协议分发。更多信息请参阅完整的[许可文本](https://github.com/krupkat/xpano/blob/main/LICENSE)。

## 联系方式

Tomas Krupka - [krupkat.cz](https://krupkat.cz)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---