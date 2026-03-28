
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### 基于 Zenity 的 Wine 图形界面 - 轻松运行与分享！

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='在 Flathub 上下载' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## 什么是 WineZGUI

WineZGUI（发音为 Wine-Zee-Goo-Eee）是一个用于轻松通过 wine 玩 Windows 游戏的 wine 前端。它是用于 Wine 前缀管理和 Linux 桌面集成的一组 Bash 脚本，利用 Zenity 提供更简单的 wine 游戏体验。它允许通过文件管理器（如 Nautilus）快速启动未安装的 Direct play EXE 应用或游戏，并为每个 Windows EXE 文件创建单独的 wine 前缀。

## 为什么选择 WineZGUI？

1. 可以从文件管理器运行 Windows 游戏或 exe 文件
2. 创建应用快捷方式，方便访问。
3. 专注于玩游戏而非设置前缀。
4. 支持前缀备份和恢复，方便后续使用。
5. 创建游戏包用于分享（前缀+游戏）

## 工作原理

1. 当用 WineZGUI 打开一个 Windows 二进制文件或 exe 时，
2. 它会创建一个新的前缀（复制模板）并以 EXE 文件名生成桌面快捷方式。
3. 当用户启动脚本时，exe 会被启动。
4. 如果是安装程序，它会检测已安装的 exe 并在游戏菜单类别中创建快捷方式。

## 如何在其他驱动器或目录运行游戏或程序

打开终端并输入：

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### 安装 WineZGUI

WineZGUI 在 Flathub 以 Flatpak 形式提供：

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI 只能访问 Desktop、Documents、Downloads、Music、Pictures、Videos 目录。要访问其他位置或挂载的分区或驱动器上的文件，可以将它们复制到上述目录（如 Downloads 等），或者需要读取权限，可以通过 Flatseal 应用或命令行 `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI` 授予权限。

强烈推荐使用 flatpak 版本，因为基于发行版的 wine（wine-staging）经常更新，游戏可能每几天就会出问题。使用 flathub 的 wine stable 更好，或者使用发行版包里的 wine stable 5.0 或 7.0。

#### 在[支持的 Linux 发行版](https://flatpak.org/setup/)上安装 WineZGUI flatpak

WineZGUI 由本人以 flatpak-wine 打包。[WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) 我的其他 flatpak 现在已弃用 [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### 在 Linux 系统上进行设置，请参见 [需求](https://github.com/fastrizwaan/WineZGUI#requirements)

设置非常快捷，因为它只需将几个文件复制到特定目录。

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---