<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

#### 使用 Zenity 的 Wine 圖形介面 - 遊玩與分享！

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)


## 什麼是 WineZGUI

WineZGUI（發音為 Wine-Zee-Goo-Eee）是一個用於輕鬆在 Wine 下玩 Windows 遊戲的前端。它是一組用於 Wine 前綴管理及 Linux 桌面整合的 Bash 腳本，利用 Zenity 提供更簡便的 Wine 遊戲體驗。它允許從檔案管理器（如 Nautilus）快速啟動直接執行（未安裝）的 EXE 應用或遊戲，並且可為每個 Windows EXE 檔建立獨立的 wine 前綴。

## 為什麼選擇 WineZGUI？

1. 可從檔案管理器運行 Windows 遊戲或 exe 檔案
2. 建立應用程式捷徑，方便存取。
3. 專注於遊戲體驗而非前綴設定。
4. 備份與還原前綴，以便日後使用。
5. 創建遊戲套裝方便分享（前綴+遊戲）

## 運作原理

1. 當以 WineZGUI 開啟一個 Windows 可執行檔或 exe 時，
2. 它會建立一個新的前綴（複製範本）並以 EXE 檔名建立桌面捷徑。
3. 當使用者啟動腳本時，會啟動 exe 檔。
4. 如果是安裝程式，會偵測已安裝的 exe 並在遊戲選單分類中建立捷徑。

## 如何在其他磁碟或目錄上運行遊戲或程式

打開終端機並輸入：

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### 安裝 WineZGUI

WineZGUI 可在 Flathub 以 Flatpak 形式取得：

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

Flathub 版本的 WineZGUI 只可存取桌面、文件、下載、音樂、圖片、影片等目錄。要從其他位置或掛載的分割區、磁碟讀取檔案，請將檔案複製到上述目錄（如下載等），或賦予讀取權限，可使用 Flatseal 應用或命令列 `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

我強烈建議使用 flatpak 版本，因為發行版的 wine（如 wine-staging）經常更新，遊戲可能三天兩頭就壞掉。建議使用 flathub 上的 wine stable 或發行版套件的 wine stable 5.0 或 7.0。

#### 在[支援的 Linux 發行版](https://flatpak.org/setup/)安裝 WineZGUI flatpak

WineZGUI 是由本人打包於 flatpak-wine 中。[WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI)；我另有一個現已棄用的 flatpak 專案：[flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)


### 在 Linux 系統上安裝，請參見 [需求](https://github.com/fastrizwaan/WineZGUI#requirements)

安裝極為迅速，只需將少量檔案複製到特定目錄。

##### 版本 0.99.13

下載原始碼 [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) 或使用 `git tag 0.99.13`

##### 使用 tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git 標籤 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### 開發版本

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### 卸載 WineZGUI

##### Flatpak 卸載

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### 系統解除安裝

從相同的安裝來源目錄執行 `uninstall`

```
sudo ./setup --uninstall
```

## 系統需求

`wine` - 主要程式

`winetricks` - 必需的 wine 附加腳本

`perl‑image‑exiftool` - 用於擷取應用程式/遊戲名稱

`icoutils` - 用於從 exe 檔案提取圖示

`gnome-terminal` -（可選）在 shell 中存取前置目錄

## Linux 作業系統安裝需求

### 支援 Flatpak 的發行版

取得 [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases)，其中包含所有相依套件。適用於未打包 wine 的發行版。

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## 執行時依賴項：

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

#### XBOX 相容控制器

建構並安裝適用於 xbox 360 相容控制器的核心驅動程式，來源：https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---