# Free Oberon プログラミング環境

» [free.oberon.org](https://free.oberon.org/en)

Oberonは汎用プログラミング言語であり、PascalとModula-2の直接の子孫です。PascalやModulaよりもシンプルでありながら、はるかに強力です。

Free Oberonは、Oberonプログラミング言語のためのクロスプラットフォーム統合開発環境であり、クラシックな疑似グラフィックスタイル―Pascalの有名な青い画面―で設計されています。Windows、macOS、Linuxで利用可能です。

Fobは便利なコンソールベースのOberonコンパイラです。

![Free Oberon screenshot](http://free.oberon.org/images/screenshot.png)

![Game of Life animation in Oberon](http://free.oberon.org/images/life.gif)

*以下の英語テキストを参照してください。*

# Среда программирования Free Oberon

Оберон — язык программирования общего назначения, прямой наследник Паскаля и Модулы-2. Он одновременно и проще, и намного мощнее, чем Паскаль и Модула.

Free Oberon представляет собой кроссплатформенную интегрированную среду разработки на языке программирования Оберон, выполненную в классическом псевдографическом стиле — знаменитого синего экрана Паскаля. Поставляется для Виндоуса, Мак-ОС и Линукса.

Fob — это консольный компилятор языка Оберон.

* Версия 1.1.0-alpha.7
* Рига, 11 января 2023 г.
* Сайт: [free.oberon.org](https://free.oberon.org)

# Установка

## Установка на Линукс

1. Зависимости:

   Allegro (пакеты разработки), Git, GCC

   На ОС Дебиан / Убунту / Линукс Минт и т. п.:
   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   или:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   Fedora OSで:


   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel
   ```

   Arch Linuxで:
   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```
   OpenSUSEで:

   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. tar.gz形式のFree Oberonアーカイブを
   [free.oberon.org](https://free.oberon.org/download)のサイトから
   ダウンロードし、ホームディレクトリ（または任意の場所）に展開します。

   バージョン（最新ビルド）：

   https://github.com/kekcleader/FreeOberon.git のサイトで
   緑色の「Code」ボタンをクリックし「Download ZIP」を選択、
   ホームディレクトリにアーカイブを展開します。
   ディレクトリ名 `FreeOberon-main` を `FreeOberon` に変更してください。

3. 展開したディレクトリ内で `install.sh` を実行します。

  ```
  ./install.sh
  ```
4. （任意）ファイル `~/.bashrc` の末尾に次の行を追加してください：

  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  これにより、`fo` コマンドで Free Oberon を起動できます。

  Free Oberon を特定の言語で起動するには、言語を指定してください（en または ru）：
  ```
  ./FreeOberon --lang ru
  ```
  или
  ```
  fo --lang ru
  ```

## Windowsへのインストール

[free.oberon.org](https://free.oberon.org)のサイトからアーカイブをダウンロードし、非ラテン文字を含まないパスに展開し、`FreeOberon.exe`を起動してください。

注意：Windows用のFree Oberonをソースコードから自分でビルドしたい場合は、[free.oberon.orgのFree Oberonドキュメント付録A](http://free.oberon.org/files/FreeOberon_v1.1.0.pdf)を参照してください。


# 使用方法

Free Oberonを起動し、オベロン言語でプログラムモジュールのテキストを入力するか、例えば`Life.Mod`のようなプログラム例ファイルを開きます。`F9`キーを押すとプログラムがコンパイルされ実行されます。
プログラムのソースコードファイルは`Programs`サブディレクトリに保存され、コンパイル済みの実行ファイルは`bin`サブディレクトリに保存されます。コンパイルの過程でLinux（Windows）ではスクリプト`Data/bin/compile.sh`（`Data\bin\compile.bat`）が使用されます。これらのスクリプトは編集可能です。

複数のモジュールからなるプログラムを書くことができます。メインモジュールを開いて`F9`を押すと、Free Oberonが自動的に正しい順序でコンパイルとリンクを行います。

メインモジュールのファイルが`Programs`サブディレクトリに直接存在しない場合、コンパイル済みの実行ファイルはその近くに生成され、`_Build`サブディレクトリには入りません。

プログラムのモジュールのいずれかにエラーが見つかった場合、該当ファイルが開き、エラーの場所と内容が示されます。再コンパイルするには、再度メインモジュールのウィンドウに移動して`F9`を押してください。

[バージョン履歴](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)

______


*ENGLISH*

* Version 1.1.0-alpha.7
* Riga, January 11, 2023
* Website: [free.oberon.org](https://free.oberon.org/en)

# Install

## Install on Linux

1. 依存関係:

   Allegro（開発パッケージ）、Git、GCC

   Debian / Ubuntu / Linux Mint等のOSで:

   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   or:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```

   OS Fedoraの場合：

   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel argro5-addon-dialog-devel
   ```

   Arch Linuxの場合：
   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```

   openSUSEでは:
   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```

2. tar.gz形式のFree Oberonを
   [free.oberon.org](https://free.oberon.org/en/download)
   からダウンロードし、
   ホームディレクトリ内（または任意の場所）で解凍します。

   オプション（エッジビルド）：

   https://github.com/kekcleader/FreeOberon.git にアクセスし、
   緑色の「Code」ボタンをクリックして「Download ZIP」を選択し、
   アーカイブをホームディレクトリ内で解凍します。
   ディレクトリ名 `FreeOberon-main` を `FreeOberon` に変更します。

3. 解凍したディレクトリ内で `install.sh` を実行します。
  ```
  ./install.sh
  ```

4. （オプション）ファイル `~/.bashrc` の末尾に次の行を追加してください：
  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  これにより、`fo` コマンドを使用して Free Oberon を起動できるようになります。

  Free Oberon を特定の言語で実行するには、その言語を指定してください（en または ru）：
  ```
  ./FreeOberon --lang ru
  ```
  or
  ```
  fo --lang ru
  ```

## Windowsへのインストール

[free.oberon.org](https://free.oberon.org/en) からZIPアーカイブでFree Oberonをダウンロードし、非ラテン文字を含まないパスに展開して、`FreeOberon.exe` を起動します。

注意：Windows上でソースコードからFree Oberonを再コンパイルしたい場合は、[free.oberon.orgのFree Oberonドキュメント付録A](https://free.oberon.org/files/FreeOberon_v1.1.0_en.pdf)を参照してください。


# 使用方法

Free Oberonを起動してOberonモジュールのテキストを入力するか、`Life.Mod`のようなサンプルプログラムを開いて、`F9`を押してプログラムをコンパイルおよび実行します。  
プログラムのソースコードファイルは`Programs`サブディレクトリに保存され、コンパイル済み実行ファイルは`bin`サブディレクトリに保存されます。コンパイルにはLinuxでは`Data/bin/compile.sh`、Windowsでは`Data\bin\compile.bat`スクリプトが使用されます。これらのスクリプトは編集可能です。

複数のモジュールからなるプログラムを書くことができます。メインモジュールを開いて`F9`を押すと、Free Oberonはそれらを正しい順序で自動的にコンパイルおよびリンクします。

メインモジュールのファイルが`Programs`サブディレクトリに直接ない場合、そのプログラムをコンパイルすると、コンパイル済み実行ファイルは`_Build`サブディレクトリではなくその隣に配置されます。

モジュールのコンパイル中にエラーが発生した場合、該当ファイルが開かれ、エラー位置とメッセージが表示されます。再コンパイルするには再度メインモジュールのウィンドウに戻り、`F9`を押してください。

[バージョン履歴](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---