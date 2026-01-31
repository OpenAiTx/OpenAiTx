# ポリリズムマニア
リズム天国（リズムてんごく）の*ポリリズム*ミニゲームを忠実に再現したゲームで、  
内蔵レベルエディターとサイドモードを搭載。

![Polyrhythm Mania thumbnail](https://user-images.githubusercontent.com/6299069/144956042-654ff2b3-aeba-4486-810e-f26aa1b33bff.png)
![Polyrhythm: Assemble side mode thumbnail](https://user-images.githubusercontent.com/6299069/140859874-0552bb9a-c6dc-460b-a4a2-e35f99648ea9.png)

[![Downloads](https://img.shields.io/github/downloads/chrislo27/PolyrhythmMania/total.svg)](https://github.com/chrislo27/PolyrhythmMania/releases/latest)
[![GitHub license](https://img.shields.io/github/license/chrislo27/PolyrhythmMania.svg)](https://github.com/chrislo27/PolyrhythmMania/blob/dev/LICENSE.txt)
[![Donate to the project maintainer](https://img.shields.io/badge/Donate-PayPal-blue.svg?logo=paypal)](https://www.paypal.com/donate?hosted_button_id=9JLGHKZNWLLQ8)

[GENERICによるYouTubeのオリジナルサウンドトラック](https://www.youtube.com/playlist?list=PLt_3dgnFrUPwcA6SdTfi0RapEBdQV64v_)

## 特徴
* リズム天国のポリリズムミニゲームの完全再現、*さらにそれ以上！*
* 40以上のレベルを収録したフルの*ストーリーモード*
* ライブラリ機能でカスタムレベルの整理と管理が可能
* 内蔵の直感的なレベルエディターでカスタムレベルを作成
* カラーパレット変更、テキストボックス追加、スキルスター配置などのレベル効果
* クラシックなGBA、モダンなHD、アーケードテクスチャへの切り替えや独自のテクスチャパック追加
* オリジナルGBAゲームのレベルでポリリズムスキルを磨ける練習モード
* 終わりなき手強い無限モードは手を抜けない手続き生成パターン
* 日替わりチャレンジモードは通常の無限モードでは出ないパターンを収録、オンラインリーダーボード対応
* _Polyrhythm: Dunk_、_Polyrhythm: Assemble_、_Built to Scale: Solitaire_ などの追加サイドモードでポリリズムをさらに楽しめる

[v1.2アップデートトレーラーをYouTubeでチェック！](https://www.youtube.com/watch?v=I4BXu7sNj-M)  
[発表トレーラーをYouTubeでチェック！](https://www.youtube.com/watch?v=A3ZUBIy_MAQ)  
[2021年8月の特徴トレーラーをチェック！](https://www.youtube.com/watch?v=k9PtPI1-tDo)  


## プレイに必要なシステム要件
**公式サポートOS：** Windows 10以降、Linux（x86-64およびARM）。  

> macOSは公式サポート外（macOSからのバグ報告は受け付けていません）が、[issue #29](https://github.com/chrislo27/PolyrhythmMania/issues/29)に従って起動を試みることは可能です。

**システム仕様：** [*Minecraft: Java Edition*と同等の要件](https://help.minecraft.net/hc/en-us/articles/4409225939853-Minecraft-Java-Edition-Installation-Issues-FAQ#h_01FFJMSQWJH31CH16H63GX4YKE)  
が必要です。同じ基盤のグラフィックライブラリ（GLFWとOpenGL 4.4）を使用しています。

### 最低要件
* CPU: Intel Core i3-3210 3.2 GHz / AMD A8-7600 APU 3.1 GHz または同等品
* RAM: 4GB  
* GPU（統合型）: Intel HD Graphics 4000（Ivy Bridge）または AMD Radeon R5 シリーズ（Kaveri ライン）で OpenGL 4.4 対応  
* GPU（専用）: NVIDIA GeForce 400 シリーズまたは AMD Radeon HD 7000 シリーズで OpenGL 4.4 対応  
* HDD: ゲームおよびレベル用に少なくとも1GB  
* OS: Windows 10 以降、2018年以降の Linux 64ビットディストリビューション  
* ディスプレイ: 1280x720 解像度  

### 推奨要件  
* CPU: Intel Core i5-4690 3.5GHz / AMD A10-7800 APU 3.5 GHz もしくは同等品  
* RAM: 8GB  
* GPU: NVIDIA GeForce 700 シリーズまたは AMD Radeon Rx 200 シリーズ（統合型チップセットを除く）で OpenGL 4.5 対応  
* HDD: 2GB（SSD 推奨）  
* OS: Windows 10 以降（64ビット）、2020年以降の Linux 64ビットディストリビューション（例: Ubuntu 20.04）  
* ディスプレイ: 1920x1080 解像度  

## インストール手順  
これらの手順は初めてゲームをダウンロードする場合も、新しいバージョンにアップグレードする場合も同じです。  
上記のシステム要件を満たしていることを確認してください。  

__Windows（64ビットのみ、Javaインストール不要）：__  
1. 新しいタブまたはウィンドウで[最新リリースはこちら](https://github.com/chrislo27/PolyrhythmMania/releases/latest)に移動します。  
2. Assets セクションから `PolyrhythmMania_VERSION_win64.zip` という名前の正しいバージョンのゲームをダウンロードします。VERSION はリリースバージョン名です。**ファイル名にある「win64」を必ず確認してください。** 「ソースコード」はダウンロードしないでください。  
3. ファイルエクスプローラーでダウンロードした zip ファイルを見つけます。zip ファイルを右クリックし、「すべて展開...」をクリックして内容をフォルダーに展開します。  
4. 新しく展開したフォルダーを開き、`PolyrhythmMania_win64` フォルダーに入ります。  
5. `LaunchPolyrhythmMania.exe` 実行ファイルをダブルクリックしてゲームを起動します！（Javaランタイム環境は不要です。ゲームに同梱されています。）  
6. Windows Defender で「Windows Defender SmartScreen が未認識のアプリの起動を防止しました」と表示された場合は、「詳細情報」をクリックし、「実行」して問題ありません。  

__その他のプラットフォーム（またはすでにJavaをインストール済みの上級ユーザー向け）__  
1. **（前提条件）** すでに Java ランタイム環境（JRE 17 推奨、JRE 11 最低限）がインストールされており、`java` コマンドでパスが通っていることを確認してください。  
2. 新しいタブまたはウィンドウで[最新リリースはこちら](https://github.com/chrislo27/PolyrhythmMania/releases/latest)に移動します。  
3. Assets セクションから `PolyrhythmMania_VERSION.zip` という名前の正しいバージョンのゲームをダウンロードします。VERSION はリリースバージョン名です。 「ソースコード」はダウンロードしないでください。  
4. zip ファイルを既知の場所に展開します。  
5. 新しく展開したディレクトリを開き、`PolyrhythmMania_platform_agnostic` ディレクトリに入ります。  
6. 適切な起動スクリプトを実行します：Windows では `play_windows.bat` をダブルクリック、Linux では `play_linux.sh` を実行します（最初に `chmod +x play_linux.sh` が必要な場合があります）。  
7. 起動スクリプトを使いたくない場合は、`java -jar bin/PolyrhythmMania.jar` を好みの設定で実行できます。  

## コンパイル手順  
これらの手順はゲームのソースコードを編集したい方向けです。  

1. JDK 17 以上がインストールされていることを確認してください。
2. `chmod +x gradlew`
3. `./gradlew :desktop:run`

## その他の情報
リズム天国は任天堂の知的財産です。  
このプログラムは任天堂によって**承認も支援もされていません**。  
本ソフトウェアで使用されている任天堂のすべての権利（名前、音声、グラフィックなど）は、商標権を悪意を持って侵害する意図はありません。  
その他のすべての商標および資産は、それぞれの所有者に帰属します。  
これはコミュニティプロジェクトであり、[GPL-3.0ライセンス](LICENSE)に従って、無償で他の人が使用できるように提供されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-31

---