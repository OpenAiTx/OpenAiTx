<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - あなたのリモートデスクトップ"><br>
  <a href="#raw-steps-to-build">ビルド</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">構成</a> •
  <a href="#snapshot">スナップショット</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>このREADME、<a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a>、<a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk Doc</a>の翻訳にご協力ください。</b>
</p>

> [!Caution]
> **誤用に関する免責事項：** <br>
> RustDeskの開発者は、本ソフトウェアの非倫理的または違法な使用を容認または支持しません。不正アクセス、権限のない操作、プライバシーの侵害などの誤用は、当ガイドラインに厳しく反します。著者らはアプリケーションの誤用に対して一切責任を負いません。

チャットでご参加ください: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Rustで書かれた、もうひとつのリモートデスクトップソフトウェア。設定不要ですぐに使えます。データは完全に自分で管理でき、セキュリティについて心配する必要はありません。当社のランデブー／リレーサーバーを利用するか、[自分でサーバーをセットアップ](https://rustdesk.com/server)することも、[独自のランデブー／リレーサーバーを開発](https://github.com/rustdesk/rustdesk-server-demo)することもできます。

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDeskは誰でも貢献を歓迎します。始め方については [CONTRIBUTING.md](docs/CONTRIBUTING.md) をご覧ください。

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**バイナリダウンロード**](https://github.com/rustdesk/rustdesk/releases)

[**ナイトリービルド**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## 依存関係

デスクトップ版はGUIにFlutterまたはSciter（非推奨）を使用しています。本チュートリアルはSciter専用です。Sciterの方が導入が簡単で扱いやすいためです。Flutter版のビルド方法は[CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml)をご参照ください。

Sciterの動的ライブラリはご自身でダウンロードしてください。

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## ビルド手順（Raw steps to build）

- Rust開発環境およびC++ビルド環境を準備してください

- [vcpkg](https://github.com/microsoft/vcpkg)をインストールし、`VCPKG_ROOT`環境変数を正しく設定してください

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- `cargo run` を実行

## [ビルド](https://rustdesk.com/docs/en/dev/build/)

## Linuxでのビルド方法

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

### vcpkgのインストール

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### libvpx修正（Fedora向け）

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

### ビルド

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

## Dockerでのビルド方法

まずリポジトリをクローンし、Dockerコンテナをビルドします。

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

アプリケーションをビルドする際は、毎回以下のコマンドを実行してください。

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

初回ビルドは依存関係のキャッシュ作成のため時間がかかりますが、2回目以降は高速です。ビルドコマンドに異なる引数を指定したい場合は、コマンド末尾の`<OPTIONAL-ARGS>`に追加してください。たとえば最適化されたリリース版をビルドしたい場合は、上記コマンドの後に`--release`を付加してください。生成された実行ファイルはシステム上のtargetフォルダに格納され、以下のように実行できます。

```sh
target/debug/rustdesk
```

またはリリース実行ファイルの場合：

```sh
target/release/rustdesk
```

これらのコマンドはRustDeskリポジトリのルートで実行してください。そうしないと必要なリソースを認識できない場合があります。また、この方法では`install`や`run`等のcargoサブコマンドは現状サポートされていません。これらはホストではなくコンテナ内で実行・インストールされるためです。

## ファイル構成

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: ビデオコーデック、設定、tcp/udpラッパー、protobuf、ファイル転送用FS関数、その他ユーティリティ関数
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: 画面キャプチャ
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: プラットフォーム固有のキーボード／マウス制御
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: Windows、Linux、macOS用のファイルコピー＆ペースト実装
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: 非推奨のSciter UI
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: オーディオ／クリップボード／入力／ビデオサービス、ネットワーク接続
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: ピア接続の開始
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: [rustdesk-server](https://github.com/rustdesk/rustdesk-server)との通信、リモートダイレクト（TCPホールパンチング）またはリレー接続の待機
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: プラットフォーム固有コード
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: デスクトップ・モバイル用Flutterコード
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: Flutter Webクライアント用JavaScript

## スクリーンショット

![Connection Manager](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Connected to a Windows PC](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![File Transfer](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCPトンネリング](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---