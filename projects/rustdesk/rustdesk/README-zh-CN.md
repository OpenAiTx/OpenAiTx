<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - 您的远程桌面"><br>
  <a href="#raw-steps-to-build">构建</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">结构</a> •
  <a href="#snapshot">截图</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>我们需要您的帮助将此README、<a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a> 和 <a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk 文档</a>翻译为您的母语</b>
</p>

> [!Caution]
> **误用免责声明：** <br>
> RustDesk 的开发者不支持或纵容任何不道德或非法的使用本软件的行为。滥用行为，如未经授权的访问、控制或侵犯隐私，均严格违反我们的准则。作者不对任何应用程序的滥用承担责任。

与我们交流: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

又一款用 Rust 编写的远程桌面软件。开箱即用，无需配置。您可以完全控制自己的数据，无安全隐患。您可以使用我们的中继/中转服务器、[自行搭建](https://rustdesk.com/server) 或 [自定义开发中继/中转服务器](https://github.com/rustdesk/rustdesk-server-demo)。

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk 欢迎所有人贡献代码。请参阅 [CONTRIBUTING.md](docs/CONTRIBUTING.md) 以获取入门帮助。

[**常见问题 FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**二进制下载**](https://github.com/rustdesk/rustdesk/releases)

[**Nightly 构建**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## 依赖项

桌面版本使用 Flutter 或 Sciter（已弃用）作为 GUI，本教程仅针对 Sciter，因为其更易上手。Flutter 版本的构建请参考我们的 [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml)。

请自行下载 Sciter 动态库。

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## 构建原始步骤

- 准备好您的 Rust 开发环境和 C++ 构建环境

- 安装 [vcpkg](https://github.com/microsoft/vcpkg)，并正确设置 `VCPKG_ROOT` 环境变量

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- 运行 `cargo run`

## [构建文档](https://rustdesk.com/docs/en/dev/build/)

## 如何在 Linux 下构建

### Ubuntu 18 (Debian 10)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### Fedora 28 (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### Arch (Manjaro)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### 安装 vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### 修复 libvpx（Fedora专用）

```sh
cd vcpkg/buildtrees/libvpx/src
cd *
./configure
sed -i 's/CFLAGS+=-I/CFLAGS+=-fPIC -I/g' Makefile
sed -i 's/CXXFLAGS+=-I/CXXFLAGS+=-fPIC -I/g' Makefile
make
cp libvpx.a $HOME/vcpkg/installed/x64-linux/lib/
cd
```

### 构建

```sh
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
source $HOME/.cargo/env
git clone --recurse-submodules https://github.com/rustdesk/rustdesk
cd rustdesk
mkdir -p target/debug
wget https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so
mv libsciter-gtk.so target/debug
VCPKG_ROOT=$HOME/vcpkg cargo run
```

## 如何使用 Docker 构建

首先克隆仓库并构建 Docker 容器：

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

然后，每次需要构建应用程序时，运行以下命令：

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

请注意，首次构建可能会因依赖项尚未缓存而耗时较长，后续构建会更快。此外，如果需要为构建命令指定不同参数，可以在命令末尾的 `<OPTIONAL-ARGS>` 位置添加。例如，如果要构建优化过的发布版本，可以在上述命令后面加上 `--release`。生成的可执行文件将位于系统的 target 文件夹中，可以通过以下命令运行：

```sh
target/debug/rustdesk
```

或者，如果运行的是发布版可执行文件：

```sh
target/release/rustdesk
```

请确保您在 RustDesk 仓库根目录下运行这些命令，否则应用程序可能无法找到所需的资源。另外，目前不支持通过此方法使用其它 cargo 子命令如 `install` 或 `run`，因为它们会在容器内安装或运行程序，而非宿主机。

## 文件结构

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**：视频编解码、配置、tcp/udp 封装、protobuf、文件传输的文件系统功能及其他一些工具函数
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**：屏幕采集
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**：平台特定的键盘/鼠标控制
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**：Windows、Linux、macOS 下的文件复制粘贴实现
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**：已弃用的 Sciter UI
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**：音频/剪贴板/输入/视频服务及网络连接
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**：启动点对点连接
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**：与 [rustdesk-server](https://github.com/rustdesk/rustdesk-server) 通信，等待远程直连（TCP打洞）或中继连接
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**：平台特定代码
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**：桌面及移动端 Flutter 代码
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**：Flutter 网页客户端的 JavaScript

## 截图

![连接管理器](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![连接到 Windows PC](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![文件传输](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP 隧道](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---