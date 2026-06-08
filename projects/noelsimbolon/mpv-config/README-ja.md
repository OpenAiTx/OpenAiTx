# mpv 設定

![mpv ロゴ](https://raw.githubusercontent.com/mpv-player/mpv.io/master/source/images/mpv-logo-128.png)

## 概要

**mpv** は自由（自由と無料の両方の意味で）でオープンソース、クロスプラットフォームのメディアプレーヤーです。  
さまざまなメディアファイル形式、音声および映像コーデック、字幕形式をサポートしています。

このリポジトリには、私が使用している個人的な mpv の設定とスクリプトが含まれており、デフォルトの mpv、VLC、MPC よりも大幅に優れています。インストール前に、この README を最後までよく読んでください。よくある問題は注意深く読むだけで簡単に解決できます。


## プレビュー

[![preview.png](https://i.postimg.cc/8zNHHPHy/preview.png)](https://postimg.cc/VdZnsw2M)

## インストール

### Windows

Windows で mpv をインストールし、私の設定ファイルを使用する手順は以下の通りです：  
* shinchiro による最新の 64bit mpv Windows ビルドを [mpv.io/installation](https://mpv.io/installation/) から、または直接 [こちら](https://sourceforge.net/projects/mpv-player-windows/files/) からダウンロードし、お好きな場所に解凍します。これがあなたの mpv フォルダになります  
* `installer` フォルダ内にある `mpv-install.bat` を管理者権限で右クリックから「管理者として実行」で実行します  
* このリポジトリを ZIP ファイルとしてダウンロードするか（または git を使ってクローンします）  
* `mpv.exe` と同じディレクトリに `portable_config` という名前のフォルダを作成します（**これは重要です**）  
* ダウンロードしたリポジトリの内容を `portable_config` フォルダに展開またはコピーします  
* いくつかのスクリプトを動作させるには、リリース版から少し修正が必要です：  
  * `mpv-gif.lua` スクリプトを動作させるには、libass が有効化されておりターミナルからアクセス可能な [FFmpeg](https://ffmpeg.org/) が必要です。詳細はスクリプトのソースリポジトリの [インストール手順](https://github.com/Scheliux/mpv-gif-generator#installation) を参照してください。  
  * **（任意）** デフォルトでは `mpv-gif.lua` スクリプトは GIF を `C:/Program Files/mpv/gifs` に保存します。これを変更するには、`portable_config/script-opts` フォルダにある `gif.conf` をテキストエディタで開き、GIF の出力ディレクトリである `dir` をお好きな場所に設定します。例：`dir="C:/Users/USERNAME/Pictures/mpv-gifs"`  
* **（任意）** ご自身の mpv 設定を作成することも可能です。私の設定ファイルを修正したり、自分で一から作成したり、他人の設定を改変したりしてください。mpv 設定ガイドについては [便利なリンク](#useful-links) セクションを参照してください。  
* 以上で準備完了です。

### Linux

Linux で mpv をインストールし、私の設定ファイルを使用する手順は以下の通りです：

* Linux ディストリビューションに付属のパッケージマネージャを使って mpv と xclip（クリップボード CLI インターフェース）をインストールします。xclip は [copy-time.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/copy-time.lua) と [seek-to.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/seek-to.lua) スクリプトの正常動作に必要です。mpv と xclip のパッケージ名はディストリビューションによって異なる場合があります。ここでは例として、パッケージマネージャに `pacman` を使う Arch Linux を挙げます。

  ```
  sudo pacman -S mpv xclip
  ```
  例えば、Fedora Linuxを使用していて、そのパッケージマネージャーとして`dnf`が付属している場合は、代わりに以下のコマンドでmpvとxclipをインストールできます。

  ```
  sudo dnf install mpv xclip
  ```
  他のLinuxディストリビューションを使用している場合は、パッケージのインストール方法についてはお使いのLinuxディストリビューションのパッケージマネージャのドキュメントを参照してください。

* このリポジトリをZIPファイルとしてダウンロードする（またはgitでクローン）し、標準のmpv設定ディレクトリである `~/.config/mpv` に解凍/コピーします。
* ハイライトすべき点：
  * `mpv-gif.lua`スクリプトが動作するには、libassが有効になっており、ターミナルからアクセス可能な[FFmpeg](https://ffmpeg.org/)が必要です。スクリプトのソースリポジトリの[インストール手順](https://github.com/Scheliux/mpv-gif-generator#installation)を参照してください。
  * **（オプション）** デフォルトでは、`mpv-gif.lua`スクリプトはGIFを `~/Videos/mpv-gifs` に保存します。これを変更するには、`portable_config/script-opts`フォルダ内にある`gif.conf`をテキストエディタで開き、GIFの出力ディレクトリである`dir`を希望の場所に指定します。例：`dir="~/Videos"`。
* **（オプション）** 独自のmpv設定を作成できます。私の設定ファイルを修正したり、ゼロから作成したり、他の設定を修正したりしても構いません。mpv設定ガイドについては[役立つリンク](#useful-links)セクションを参照してください。
* これで準備完了です。

## スクリプト

外部ソースのスクリプト：

* audio-visualizer.lua ([ソース](https://github.com/mfcc64/mpv-scripts#visualizerlua))\
  さまざまなオーディオビジュアライゼーション。オーディオファイルを開いたときのみ動作します。
  
* autoload.lua ([ソース](https://github.com/mpv-player/mpv/blob/master/TOOLS/lua/autoload.lua))\
  現在再生中のファイルの前後のプレイリストエントリを自動的に読み込み、ディレクトリをスキャンします。

* copy-timestamp.lua ([ソース](https://github.com/linguisticmind/mpv-scripts/tree/master/copy-timestamp))\
  現在のタイムコードをHH:MM:SS.MS形式でクリップボードにコピーします。クロスプラットフォーム（Mac、Windows、Linux）対応。

* cycle-commands.lua ([ソース](https://github.com/CogentRedTester/mpv-scripts#cycle-commands))\
  キープレスで一連のコマンドを順に切り替えます。サイクルの各イテレーションには任意の数のコマンドを含めることが可能です。構文の詳細はファイルの先頭にあります。

* cycle-profile.lua ([ソース](https://github.com/CogentRedTester/mpv-scripts#cycle-profile))\
  スクリプトメッセージで送信されたプロファイルリストを順に切り替え、プロファイルの説明をOSDに表示します。詳細はファイルの先頭にあります。

* modernz.lua ([ソース](https://github.com/Samillion/ModernZ))\
  MPVのモダンなOSC UI置換で、デフォルトのOSCの機能を保持しています。

* mpv-gif.lua ([ソース](https://github.com/Scheliux/mpv-gif-generator))\
  動画再生からGIFを生成するスクリプト。libassが有効なFFmpegが必要です。字幕付きのGIFエクスポートは現在正常に動作しません。

* playlistmanager.lua ([ソース](https://github.com/jonniek/mpv-playlistmanager))\
  プレイリストを直感的に閲覧・操作できるようにします。

* seek-to.lua ([ソース](https://github.com/dexeonify/mpv-config/blob/main/scripts/seek-to.lua))\
  キーボード入力またはクリップボードから貼り付けた絶対タイムスタンプへシークします。

* sponsorblock-minimal.lua ([ソース](https://codeberg.org/jouni/mpv_sponsorblock_minimal))\
  YouTube動画のスポンサーセグメントをスキップします。

* thumbfast.lua ([ソース](https://github.com/po5/thumbfast))\
  mpv用の高性能オンザフライサムネイル生成スクリプト。**スクリプト自体はサムネイルを表示しません**。thumbfastを呼び出すUIスクリプトと併用することを想定しています。

これらのスクリプトの設定ファイルは`script-opts`フォルダにあります。また、いくつかのスクリプトのデフォルトキー割り当ても変更しています。変更内容は`input.conf`内のスクリプトキー割り当てを参照してください。

## シェーダー

`shaders`フォルダに含まれるシェーダー:

* ArtCNN_C4F32 ([ソース](https://github.com/Artoriuz/ArtCNN/blob/main/GLSL/ArtCNN_C4F32.glsl))\
  輝度のアップスケーリングに使用。

* nnedi3-nns128-win8x4 ([ソース](https://github.com/bjin/mpv-prescalers/tree/master))\
  輝度のアップスケーリングに使用。

シェーダーはお好みやシステム性能に応じて選択してください。シェーダーの詳細は[便利なリンク](#useful-links)のセクションの資料を参照してください。

## 便利なリンク

* [mpv チュートリアル](https://thewiki.moe/tutorials/mpv/) - The Wiki
* [mpv.conf ガイド](https://iamscum.wordpress.com/guides/videoplayback-guide/mpv-conf/) - iamscum
* [動画視聴用 mpv 設定ガイド](https://kokomins.wordpress.com/2019/10/14/mpv-config-guide/) - Kokomins
* [mpv リサンプリング](https://artoriuz.github.io/blog/mpv_upscaling.html) - João Vitor Chrisóstomo

## 公式リンク

* [mpv ホームページ](https://mpv.io/)  
* [mpv ウィキ](https://github.com/mpv-player/mpv/wiki)
* [mpv FAQ](https://github.com/mpv-player/mpv/wiki/FAQ)
* [mpv マニュアル](https://mpv.io/manual/stable/)
* [mpv ユーザースクリプト](https://github.com/mpv-player/mpv/wiki/User-Scripts)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---