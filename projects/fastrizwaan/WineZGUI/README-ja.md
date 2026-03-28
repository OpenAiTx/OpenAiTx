
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

#### Zenity を使った Wine GUI - プレイ＆シェア！

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathub からダウンロード' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## WineZGUIとは

WineZGUI（ワイン・ズィー・グー・イーと発音）は、Wineを使ってWindowsゲームを簡単にプレイするためのWineフロントエンドです。これは、Wineプレフィックス管理とLinuxデスクトップ統合のためのBashスクリプト集であり、Zenityを使ってWineによるゲーム体験をより簡単にします。Nautilusなどのファイルマネージャから直接実行形式（インストールされていない）EXEアプリやゲームを素早く起動でき、各Windows EXEバイナリごとに個別のWineプレフィックスを作成できます。

## なぜWineZGUIか？

1. ファイルマネージャからWindowsゲームやEXEファイルを実行可能
2. アプリケーションショートカットを作成し、アクセスを簡単にします。
3. プレフィックスの設定ではなく、ゲームプレイに集中できます。
4. プレフィックスのバックアップや復元ができます。
5. ゲームバンドル（プレフィックス+ゲーム）を作成して共有できます

## 仕組み

1. WindowsバイナリやEXEがWineZGUIで開かれると、
2. 新しいプレフィックス（テンプレートをコピー）とEXEファイル名のデスクトップショートカットを作成します。
3. ユーザーがスクリプトを実行すると、EXEが起動します。
4. それがセットアップの場合、インストールされたEXEを検出し、ゲームメニューカテゴリにショートカットを作成します。

## 別のドライブやディレクトリでゲームやプログラムを実行する方法

ターミナルを開き、以下を入力します：

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### WineZGUIのインストール

WineZGUIはFlathubでFlatpakとして利用できます：

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

Flathub版WineZGUIは、デスクトップ、ドキュメント、ダウンロード、音楽、画像、動画ディレクトリのみにアクセスできます。他の場所やマウントされたパーティション・ドライブのファイルにアクセスするには、上記のディレクトリ（ダウンロード等）にコピーするか、Flatsealアプリやコマンドラインで `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI` として読み取り権限を与える必要があります。

私はflatpak版の使用を強く推奨します。なぜなら、ディストリビューション標準のwine（wine-staging）は頻繁に更新され、数日ごとにゲームが動かなくなることがあるからです。flathubのwine stable、またはディストリのwine stable 5.0や7.0の利用が望ましいです。

#### [対応Linuxディストリビューション](https://flatpak.org/setup/)でWineZGUI flatpakをインストール

WineZGUIは私自身によってflatpak-wineにパッケージされています。[WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) 私の他のflatpakは現在廃止済み [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)


### Linuxシステムでのセットアップについては、[Requirements](https://github.com/fastrizwaan/WineZGUI#requirements)を参照してください。

セットアップは即時に完了し、いくつかのファイルが特定のディレクトリにコピーされます。

##### バージョン 0.99.13

ソースをダウンロード [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) または `git tag 0.99.13` を使用します。

##### tar.gzを使用する場合

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
##### 開発版


```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### WineZGUIのアンインストール

##### Flatpakのアンインストール

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### システムのアンインストール

同じインストール元ディレクトリから `uninstall` を実行してください

```
sudo ./setup --uninstall
```

## 要件

`wine` - メインプログラム

`winetricks` - 必須のwineアドオンスクリプト

`perl‑image‑exiftool` - アプリケーション／ゲーム名を抽出するため

`icoutils` - exeファイルからアイコンを抽出するため

`gnome-terminal` - （オプション）プレフィックスディレクトリにシェルでアクセスするため

## Linux OS用インストール要件

### Flatpak対応ディストリビューション

すべての依存関係を含む[flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases)を入手してください。wineをパッケージ化していないディストリビューションに有用です。

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## ランタイム依存関係:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### ソルス

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### XBOX 対応コントローラー

https://github.com/paroj/xpad から xbox 360 対応コントローラー用のカーネルドライバーをビルドしてインストールする


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---