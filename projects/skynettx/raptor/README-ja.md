
# ラプター  
nukeyktによるRaptor Call Of The Shadowsのリバースエンジニアリングされたコードベースに基づく

## メディア  
サムネイルをクリックすると、プロジェクトの動作を示すビデオを見ることができます  

[![画像の代替テキスト](https://img.youtube.com/vi/Nt2HfchiudY/0.jpg)](https://www.youtube.com/channel/UCedmTTlonJK5DvkiMpA_teQ)  
## 情報  
オリジナルのRaptor Call Of The Shadowsの作者スコット・ホストは、Raptor Remixedというクラシックの新しい現代版に取り組んでいます。ラプターファンなら、Kickstarterでこのプロジェクトを支援すると良いでしょう。詳細は[www.mking.com](https://www.mking.com)をご覧ください。

## クイックスタート  
リリースビルドはWindowsとmacOS向けに利用可能です。  
すべてのリリースビルドにはシェアウェアバージョン1.2のアセット（GLBファイル）のみが含まれています。  
完全版をプレイしたい場合は、完全版1.2のアセット（GLBファイル）を自分で入手し、インストールディレクトリにコピーする必要があります。  
ご使用のプラットフォーム向けの最新リリースビルドをダウンロードするには、[Download](https://github.com/skynettx/raptor/releases/latest)をクリックしてください。  
その後、インストーラーの指示に従ってダウンロードしたリリースビルドをシステムにインストールします。  
これでラプターの準備は完了です。  
自分でビルドしたい方や、より詳細な設定情報が必要な方は以下を読み進めてください。そうでなければここで終了です。

## インストール  
Raptor Call Of The Shadows v1.2シェアウェアまたは完全版のオリジナルアセット（GLBファイル）が必要です。  
重要：DOSバージョンv1.2のみが互換性があります！これらのファイルは自分で管理してください。  
アセットは現在の作業ディレクトリ（Raptorディレクトリ）または外部のシステム固有ディレクトリから読み込むことができます。  
**リリースビルドバージョン0.8.0は外部のシステム固有ディレクトリをサポートしておらず、すべてのアセット、設定、セーブファイルを現在の作業ディレクトリで管理することに注意してください。**  
外部のシステム固有ディレクトリは以下の通りです：
```
 Windows: Users\Username\AppData\Roaming\Raptor\  
 Linux: ~/.local/share/Raptor/
 macOS: ~/Library/Application Support/Raptor/
```

設定ファイル `SETUP.INI` とセーブファイルもこれらのフォルダで読み込みおよび保存されます。  
公式にサポートされていない他のシステムでは、設定ファイルとセーブファイルの読み込みおよび保存にRaptorディレクトリが使用されます。  
ビルドディレクトリから `raptor.exe`（Windows）または `raptor`（LinuxまたはmacOS）をRaptorディレクトリにコピーしてください。  
TinySoundFontによるMIDIサポートのために、サウンドフォント `TimGM6mb.sf2` を `include\TimGM6mb\` からRaptorディレクトリにコピーします。  
Windowsでは、32ビットインストールの場合は `include\SDL2-devel-2.28.2-VC\SDL2-2.28.2\lib\x86\` から、64ビットインストールの場合は  
`include\SDL2-devel-2.28.2-VC\SDL2-2.28.2\lib\x64\` からファイル `SDL.dll` をRaptorディレクトリにコピーしてください。  
Linuxでは、各ディストリビューションのパッケージマネージャからlib-sdl2をインストールしてください。macOSを使用する場合は、dmgまたはbrewなどのパッケージマネージャからlib-sdl2をインストールしてください。  
### シェアウェア  
以下のファイルをRaptorまたは外部のシステム特有のディレクトリにコピーしてください：

```
FILE0000.GLB  
FILE0001.GLB  
```
### フルバージョン
以下のファイルをRaptorまたは外部システムの特定ディレクトリにコピーしてください: 
```
FILE0000.GLB  
FILE0001.GLB  
FILE0002.GLB  
FILE0003.GLB  
FILE0004.GLB  
```
### 設定
`SETUP.INI` を作成・編集するために、[Raptor Setup](https://github.com/skynettx/raptorsetup.git) をビルドまたはダウンロードするか、手動で以下のように編集してください。  
`SETUP(ADLIB).INI` または `SETUP(MIDI).INI` ファイルをビルドディレクトリから外部のシステム固有ディレクトリ（Windows、Linux、macOS）または Raptor ディレクトリ（公式にサポートされていないシステムのみ）へコピーし、`SETUP.INI` にリネームします。  
TinySoundFont ライブラリで MIDI を使用したい場合は、`TimGM6mb.sf2` を `SoundFont.sf2` にリネームするか、`SETUP.INI` ファイルにファイル名を指定してください:  
`SoundFont=SoundFont.sf2`  
sf2 形式の任意の GM 互換サウンドフォントを使用できます。より良い MIDI 音質のためには FluidR3_GM.sf2 を推奨します。  
このフォントは140MBのサイズがあり、リポジトリには含まれていません。  
以下の入力デバイスのいずれかでプレイするには、`SETUP.INI` の [Setup] セクションで `Control=0` に設定してください:  
`Control=0` キーボード  
`Control=1` マウス  
`Control=2` ジョイスティック（ゲームコントローラー）  
[Setup] セクションでハプティック（ゲームコントローラーの振動サポート）のオン・オフが可能です:  
`Haptic=0`  
`Haptic=1`  
`Control=2` モードでジョイスティックによるメニューポインター制御をオフにし、すべての入力モードで新しいジョイスティックメニュー制御を有効にしたい場合は、[Setup] セクションで以下を設定してください:  
`joy_ipt_MenuNew=0`  
`joy_ipt_MenuNew=1`  
システム MIDI サポート（Windows Multimedia、Linux ALSA、macOS CoreAudio、macOS CoreMIDI）は、[Setup] セクションでオン・オフできます:  
`sys_midi=0`  
`sys_midi=1`  
Windows の Windows Multimedia では、MIDI デバイスを [Setup] セクションで設定します:  
`winmm_mpu_device=0`  
Linux の ALSA MIDI では、クライアントとポートを [Setup] セクションで設定します:  
`alsa_output_client=128`  
`alsa_output_port=0`  
ALSA MIDI でソフトウェアシンセサイザーを使用するには、例えばディストリビューションのパッケージマネージャーから timidity と soundfont-fluid をインストールしてください。  
macOS の CoreAudio サポートとソフトウェアシンセサイザー DLS synth は、[Setup] セクションでオン・オフ可能です:  
`core_dls_synth=0`  
`core_dls_synth=1`  
macOS で CoreMIDI を使用する場合は、`core_dls_synth=0` をオフにする必要があります。  
CoreMIDI ポートは [Setup] セクションで以下のように設定できます:  
`core_midi_port=0`  
フルスクリーンモードでゲーム終了後にテキストモードの終了画面を表示するには、[Video] セクションで以下を設定してください:  
`txt_fullscreen=0`  
`txt_fullscreen=1`  

## ビルド
本プロジェクトは msvc、gcc、clang のコンパイラをサポートしています。  
システムに git がインストールされている場合は、`git clone https://github.com/skynettx/raptor.git` と入力してリポジトリをクローンできます。  

### Windows
Visual Studio 2022 用のプロジェクトファイルは `msvc\` に、CodeBlocks 用のプロジェクトファイルは `gcc\` にあります。  

### Linux
必要な依存関係 lib-sdl2 をインストールすることを忘れないでください。Debian や Ubuntu のような一部のディストリビューションでは libsdl2-dev パッケージもあります。  
CodeBlocks 用のプロジェクトファイルは `gcc\` にあります。  
または cmake を使用できます。cmake を使用するにはリポジトリのルートで以下を入力してください:  


```
mkdir build  
cd build  
cmake ..  
make  
```
### macOS
必要な依存関係であるlib-sdl2をインストールします。ビルドするにはcmakeを使用し、リポジトリのルートで次のように入力します：

```
mkdir build  
cd build  
cmake ..  
make  
```
## FAQ
1. Linuxで音声が出ない場合:  
ディストリビューションのパッケージマネージャから必要なALSAおよびPulseAudioの依存関係をすべて入手してください。 
2. ビデオ設定はどこで変更できますか:  
ビデオ設定は設定ファイル`SETUP.INI`で設定できます。[Video]セクションの`fullscreen=0`を`fullscreen=1`に変更してフルスクリーンモードを切り替えます。  
またはアスペクト比モードをオフにするには`aspect_ratio_correct=1`を`aspect_ratio_correct=0`にします。 

## 感謝
再構築されたソースコードに対する素晴らしい作業に対して[nukeykt](https://github.com/nukeykt)と[wel97459](https://github.com/wel97459)に特別な感謝を。  
また、素晴らしいサポートをしてくれた[Scott Host](https://www.mking.com)に大きな感謝を。  
さらに、優れたTinySoundFontライブラリを提供してくれた[schellingb](https://github.com/schellingb)と、素晴らしいlibtextscreenを作成した[chocolate-doom project](https://github.com/chocolate-doom)の全貢献者にも感謝します。  
さらに、TimGM6mbサウンドフォントを提供してくれたTim Brechbillにも多大な感謝を。











---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---