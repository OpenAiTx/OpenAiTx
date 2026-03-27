# WineZGUI

#### Zenityを使ったWineのGUI - プレイして共有しよう！

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathubからダウンロード' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## WineZGUIとは

WineZGUI（ワイン・ジー・グー・イーと発音）は、WineでWindowsゲームを簡単にプレイするためのWineフロントエンドです。Zenityを使ったWineプレフィックス管理とLinuxデスクトップ統合のためのBashスクリプト集で、より簡単にWineでのゲーム体験を提供します。Nautilusのようなファイルマネージャから直接プレイ（未インストール）できるEXEアプリケーションやゲームを素早く起動し、Windowsの各EXEバイナリごとに別々のWineプレフィックスを作成できます。

## なぜWineZGUIなのか？

1. ファイルマネージャからWindowsゲームやexeファイルを実行できる
2. アプリケーションショートカットを作成し、アクセスを簡単にする
3. プレフィックスの設定ではなく、ゲームプレイに集中できる
4. プレフィックスのバックアップと復元が可能
5. ゲームバンドル（プレフィックス＋ゲーム）を作成して共有できる

## 仕組み

1. WindowsのバイナリやexeをWineZGUIで開くと、
2. 新しいプレフィックス（テンプレートをコピー）とEXEファイル名のデスクトップショートカットを作成します。
3. ユーザーがスクリプトを起動すると、exeが起動します。
4. セットアップの場合、インストール済みexeを検出し、ゲームメニューカテゴリにショートカットを作成します。

## 別のドライブやディレクトリでゲームやプログラムを実行するには

ターミナルを開き、次を入力してください：

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### WineZGUIのインストール

WineZGUIはFlathubのFlatpakとして利用可能です：

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathubからダウンロード' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


FlathubのWineZGUIは、Desktop、Documents、Downloads、Music、Pictures、Videosディレクトリにのみアクセスできます。その他の場所やマウントされたパーティションやドライブのファイルにアクセスするには、先に挙げたディレクトリ（Downloadsなど）にコピーするか、Flatsealアプリを使うか、コマンドラインで `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI` を使用して読み取り権限を与える必要があります。

私はflatpak版の使用を強く推奨します。なぜなら、ディストリビューションベースのwine（wine-staging）は頻繁に更新され、ゲームが数日ごとに動作しなくなる可能性があるためです。Flathubのwine stableを使うか、ディストリパッケージのwine stable 5.0または7.0を使用する方が良いでしょう。

#### [サポートされているLinuxディストロ](https://flatpak.org/setup/)にWineZGUI flatpakをインストールする

WineZGUIは私自身によってflatpak-wineとしてパッケージ化されています。[WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI)は私の他のflatpakで、現在は非推奨の[flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)です。

### Linuxシステムでのセットアップ、[要件](https://github.com/fastrizwaan/WineZGUI#requirements)を参照

セットアップは特定のディレクトリにいくつかのファイルをコピーするだけで即座に完了します。

##### バージョン 0.99.13

ソースをダウンロード [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) または `git tag 0.99.13` を使用してください。

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---