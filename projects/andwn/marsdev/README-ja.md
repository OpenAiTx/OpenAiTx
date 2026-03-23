# Marsdev

クロスプラットフォームのセガ メガドライブ / スーパー32X / シャープ X68000 ツールチェーン。

English | [日本語](https://raw.githubusercontent.com/andwn/marsdev/master/README-ja.md)


## コンパイルとインストール

### 1.1 依存関係

使用しているOSに応じて、以下のパッケージをインストールしてください：
  * Debian: `apt install build-essential texinfo wget`
  * RedHat: `yum install gcc gcc-c++ texinfo-tex wget`
  * Arch: `pacman -S base-devel texinfo wget`
  * Gentoo: `emerge sys-apps/texinfo net-misc/wget`
  * macOS: `xcode-select --install && brew install wget`


### 2. GCC ツールチェーン

リポジトリをクローンします：
 - `git clone https://github.com/andwn/marsdev --recurse-submodules`
 - `cd marsdev`

---
**注意**

Marsdev のビルドおよびインストール先ディレクトリを制御する変数が2つあります：
 - `MARS_BUILD_DIR` = (REPOSITORY_ROOT)/mars
 - `MARS_INSTALL_DIR` = /opt/toolchains/mars

いずれかの場所を変更したい場合は、次のように export コマンドを使用してください：
 - `export MARS_INSTALL_DIR=/path/to/mars`

`--recurse-submodules` を忘れた場合は、次を実行してください：
 - `git submodule init && git submodule update`

また、CPUコア数に合わせて `-j8` のように `-j` の後の数字を指定することを**強く推奨**します。私は `-j` を使った際に説明のつかない奇妙な問題に遭遇したことがあります。

それ自体では動作しないため、数字を指定してください。

---

GCCをビルドするには2つのオプションがあります：
 - `make m68k-toolchain` - Newlibなし
 - `make m68k-toolchain-newlib` - Newlibあり

32X用には、`sh`ツールチェーンもビルドする必要があります。
コマンド内の`m68k`を`sh`に置き換えるだけで同じオプションが使えます。

異なるGCCバージョンを使いたい場合や特定の言語のみをビルドする場合は：
 - `make m68k-toolchain-newlib GCC_VER=12.4.0 LANGS=c,c++`


### 3. （オプション）SGDK

SGDKはJavaが必要なのでインストールしてください。
  * Debian: `apt install openjdk-11-jre`
  * RedHat: `yum install java-11-openjdk`
  * Arch: `pacman -S jdk11-openjdk`
  * Gentoo: `emerge dev-java/openjdk`
  * macOS: `brew install java`

---
**macOSに関する注意**

OpenJDKをPATHに追加する必要があります。
 - `~/.zshrc`（まだbashを使っている場合は`~/.bashrc`）を開き、以下の行を追加してください：
    - `export PATH="/usr/local/opt/openjdk/bin:$PATH"`
 - ターミナルを再起動するか、`source ~/.zshrc`を実行してください。

---

SGDKをビルドします：
 - `make sgdk`

特定のバージョンのSGDKは`SGDK_VER=<git tag>`で指定できますが、
デフォルト以外のバージョンが動作する保証はできません。
最新の変更を試したい冒険者は`SGDK_VER=master`も指定できます。

### 4.1 （オプション）その他のツール

以下のターゲットも利用可能です：
 - `make x68k-tools` - Sharp X68000 互換性
 - `make mdtools-sik` - mdtiler といくつかの Echo 関連ツールを含む（libpng 必須）
 - `make mdtools-flamewing` - Sonic ゲームのデータ圧縮ツール（boost 必須）

 ### 4.2 （実験的）LLVM

cmake、ninja、python3 が必要：
 - Debian: `apt install cmake ninja-build python3`
 - （TODO: 他の環境も記入予定）

M68k 用の clang を含む LLVM をビルド可能：
 - `make m68k-llvm`
 
テストはまだ行われておらず、examples/スケルトンプロジェクトもまだ作成する必要があります。


### 5. インストール

単に `sudo make install` を実行してください。環境設定スクリプトのパスを覚えておき、
~/.bashrc（または ~/.zshrc）に追加することを検討してください。


## 例

`examples` ディレクトリには、他のプロジェクトのベースとするための様々なスケルトン／サンプルプロジェクトが含まれています。
各プロジェクトの詳細は [examples/README.md](https://raw.githubusercontent.com/andwn/marsdev/master/examples/README.md) を参照してください。

いずれも `make` を実行するだけで簡単に利用できるはずです。


## よくある質問

### とにかく、Linux で SGDK を使いたいだけなんだけど

インストール：

 - `sudo apt install -y git build-essential texinfo wget openjdk-11-jre`
 - `git clone https://github.com/andwn/marsdev && cd marsdev`
 - `make sgdk -j8`
 - `sudo make install`

ビルド:

 - `examples/sgdk-skeleton` 内の Makefile を取得し、プロジェクトにコピーしてください。
 - `source /opt/toolchains/mars/mars.sh`
 - `make`

### Marsdev と Gendev のプロジェクトは相互にビルドできますか？

簡単にはできません。動作させるには Makefile を調整する必要があります。
まずは現在の Makefile とサンプルプロジェクトのものを比較してください。
[Migration](https://raw.githubusercontent.com/andwn/marsdev/master/doc/migration.md) ドキュメントが参考になるかもしれません。

### SGDK の問題が Marsdev によるものかどうかはどうやって判断しますか？

公式の SGDK リリースでそのままプロジェクトをコンパイルできるか試してください。
付属の Makefile は `make -f $GDK/makefile.gen` のラッパーに過ぎません。

問題が続く場合は SGDK の問題です。問題が解決する場合は Marsdev の問題です。

### お気に入りの IDE で使うにはどうすればいいですか？

IDE は多数あり、それぞれ設定する場所が異なります。
一般的に必要なのはヘッダーファイルのパスを指定することだけです。

 * GCC ヘッダー: `$(MARSDEV)/m68k-elf/lib/gcc/m68k-elf/$(GCC_VER)/include`
 * SGDK ヘッダー: `$(MARSDEV)/m68k-elf/include`
 * Newlib ヘッダー: `$(MARSDEV)/m68k-elf/m68k-elf/include`
 
IDE がビルド/実行ボタンの挙動を設定できる場合は、以下のようにしてください。

 * ビルド: `make MARSDEV=/path/to/mars`
 * 実行: `/path/to/an/emulator out.bin`


### Windows はどうなっていますか？

[WSL](https://learn.microsoft.com/en-us/windows/wsl/install) の使用を強くお勧めします。
Debian用の指示に従ってください。
また、Dockerfileを試すこともできますが、それは他の人が提供しており、
私自身はテストしていません。
以前は [MSYS2](https://raw.githubusercontent.com/andwn/marsdev/master/doc/install_msys_legacy.md) を使っていましたが、
その遅さと使いにくさは言葉では言い表せません。

補足として、もしSGDKを使うためだけにここに来ていてLinuxやmacOSを使っていないなら、
Marsdevはあまり役に立たないと思います。


### /opt にインストールするのは好きではありません。昔の ~/mars 方式に戻したい

それは簡単です。
1. `export MARS_BUILD_DIR=${HOME}/mars`
2. 通常通りステップ1～4を実行します
3. インストールステップはスキップし、代わりに `~/.bashrc` に以下を追加してください:
```
export MARSDEV=${HOME}/mars
export GDK=${MARSDEV}/m68k-elf
```

### コンパイルにすごく時間がかかる！

GCCは大物なので、我慢強く待つしかありません。


# やることリスト

 - [ ] libdosの重要な部分の移植を完了し、Newlibを動作させること


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---