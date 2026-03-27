# WineZGUI

#### 使用 Zenity 的 Wine 图形界面 - 玩游戏并分享！

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='在 Flathub 下载' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## 什么是 WineZGUI

WineZGUI（发音为 Wine-Zee-Goo-Eee）是一个用于轻松使用 Wine 玩 Windows 游戏的 Wine 前端。它是一个用于 Wine 前缀管理和 Linux 桌面集成的 Bash 脚本集合，通过 Zenity 提供更便捷的 Wine 游戏体验。它允许从文件管理器（如 Nautilus）快速启动直接运行（无需安装）的 EXE 应用程序或游戏，并允许为每个 Windows EXE 二进制文件创建独立的 Wine 前缀。

## 为什么选择 WineZGUI？

1. 从文件管理器运行 Windows 游戏或 EXE 文件  
2. 创建应用程序快捷方式，方便访问。  
3. 专注于玩游戏，而不是设置前缀。  
4. 备份和恢复前缀以便以后使用。  
5. 创建游戏包以便分享（前缀+游戏）

## 它是如何工作的

1. 当用 WineZGUI 打开一个 Windows 二进制文件或 EXE 时，  
2. 它会创建一个新的前缀（复制模板）和一个以 EXE 文件名命名的桌面快捷方式。  
3. 当用户启动脚本时，EXE 会被运行。  
4. 如果是安装程序，它会检测已安装的 EXE 并在游戏菜单类别中创建快捷方式。

## 如何在另一驱动器或目录运行游戏或程序

打开终端并输入：

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### 安装 WineZGUI

WineZGUI 可作为 Flathub 上的 Flatpak 应用使用：

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='在 Flathub 下载' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI 只能访问桌面、文档、下载、音乐、图片、视频目录。要访问其他位置或其他挂载的分区或驱动器中的文件，要么将它们复制到上述目录（如下载等），要么需要读取权限，可以使用 Flatseal 应用程序授予，或使用命令行 `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

我强烈建议使用 flatpak 版本，因为基于发行版的 wine（wine-staging）会不断更新，游戏可能每隔几天就会崩溃。使用来自 flathub 的 wine 稳定版更好，或者使用发行版包中的 wine 稳定版 5.0 或 7.0。

#### 在[支持的 Linux 发行版](https://flatpak.org/setup/)上安装 WineZGUI flatpak

WineZGUI 由本人打包在 flatpak-wine 中。[WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) 是我现在弃用的另一个 flatpak 项目 [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### 在 Linux 系统上的设置，详见[需求](https://github.com/fastrizwaan/WineZGUI#requirements)

设置非常快速，只需将几个文件复制到特定目录。

##### 版本 0.99.13

下载源码 [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) 或使用 `git tag 0.99.13`

##### 使用 tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```
##### git tag 0.99.13


```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```
##### 开发版本


```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### 卸载 WineZGUI

##### Flatpak 卸载

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### 系统卸载

从相同的安装源目录运行 `uninstall`

```
sudo ./setup --uninstall
```

## 需求

`wine` - 主程序

`winetricks` - 必须的 wine 附加脚本

`perl‑image‑exiftool` - 用于提取应用程序/游戏名称

`icoutils` - 用于从 exe 文件中提取图标

`gnome-terminal` - （可选）用于在 shell 中访问前缀目录

## Linux 操作系统安装需求

### 支持 Flatpak 的发行版

获取包含所有依赖项的 [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases)。适用于不打包 wine 的发行版。

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## 运行时依赖：

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### 兼容XBOX的手柄

构建并安装来自 https://github.com/paroj/xpad 的Xbox 360兼容手柄内核驱动程序


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---