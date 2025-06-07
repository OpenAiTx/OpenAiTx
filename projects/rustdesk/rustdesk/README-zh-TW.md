<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - 您的遠端桌面"><br>
  <a href="#raw-steps-to-build">編譯</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">結構</a> •
  <a href="#snapshot">快照</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>我們需要您的協助，將本 README、<a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a> 及 <a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk 文件</a> 翻譯成您的母語</b>
</p>

> [!Caution]
> **濫用免責聲明：** <br>
> RustDesk 的開發者不支持或縱容任何非道德或非法用途。濫用本軟體（如未經授權的存取、控制或侵犯隱私）嚴格違反我們的準則。作者對於本應用程式之任何濫用行為不承擔任何責任。

與我們聊天：[Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

另一套用 Rust 撰寫的遠端桌面軟體。開箱即用，無需任何設定。您可完全掌控您的資料，無需擔心安全問題。您可以使用我們的 rendezvous/relay 伺服器、[自行架設](https://rustdesk.com/server)或[自行開發 rendezvous/relay 伺服器](https://github.com/rustdesk/rustdesk-server-demo)。

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk 歡迎所有人參與貢獻。請參閱 [CONTRIBUTING.md](docs/CONTRIBUTING.md) 以瞭解如何開始。

[**常見問題 FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**二進位檔下載**](https://github.com/rustdesk/rustdesk/releases)

[**夜間構建版**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## 相依套件

桌面版本使用 Flutter 或 Sciter（已棄用）作為圖形介面，本教學僅針對 Sciter，因為它較容易且友善入門。欲編譯 Flutter 版本請參考我們的 [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml)。

請自行下載 Sciter 動態函式庫。

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## 原始編譯步驟

- 準備好您的 Rust 開發環境及 C++ 編譯環境

- 安裝 [vcpkg](https://github.com/microsoft/vcpkg)，並正確設定 `VCPKG_ROOT` 環境變數

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- 執行 `cargo run`

## [編譯教學](https://rustdesk.com/docs/en/dev/build/)

## 如何在 Linux 上編譯

### Ubuntu 18（Debian 10）

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### Fedora 28（CentOS 8）

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### Arch（Manjaro）

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### 安裝 vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### 修復 libvpx（Fedora 適用）

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

### 編譯

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

## 如何使用 Docker 編譯

首先克隆專案並建立 Docker 容器：

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

每次需要編譯應用程式時，請執行以下指令：

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

請注意，第一次編譯時由於需要快取相依套件會較久，之後會快得多。如果您需要對編譯指令傳遞不同參數，可在 `<OPTIONAL-ARGS>` 位置於指令末尾補上。例如：若要編譯最佳化的 release 版本，請在上述指令後加上 `--release`。最終可執行檔會出現在系統的 target 資料夾中，可用下列指令執行：

```sh
target/debug/rustdesk
```

若為 release 執行檔，請用：

```sh
target/release/rustdesk
```

請確認您於 RustDesk 專案根目錄執行這些指令，否則應用程式可能找不到所需資源。另請注意，目前不支援其他 cargo 子指令（如 `install` 或 `run`），因為這些操作會在容器內而非主機端執行或安裝程式。

## 檔案結構

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**：視訊編解碼器、設定、tcp/udp 包裝器、protobuf、檔案傳輸 fs 函式及其他工具函式
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**：螢幕截圖
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**：平台專屬鍵盤/滑鼠控制
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**：Windows、Linux、macOS 的檔案複製貼上實作
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**：已棄用的 Sciter UI
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**：音訊/剪貼簿/輸入/視訊服務及網路連線
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**：啟動對等連線
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**：與 [rustdesk-server](https://github.com/rustdesk/rustdesk-server) 通訊，等待遠端直連（TCP 穿孔）或中繼連線
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**：平台專屬程式碼
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**：桌面與行動裝置的 Flutter 程式碼
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**：Flutter Web 用 JavaScript

## 截圖

![連線管理器](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![連線至 Windows PC](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![檔案傳輸](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP 隧道](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---