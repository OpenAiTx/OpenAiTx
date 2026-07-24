# XGDTool
<img src="https://github.com/wiredopposite/XGDTool/blob/master/resources/Screenshot.png" alt="App" width="700"/>

XGDToolはOG XboxおよびXbox 360のディスクユーティリティで、ディスクを任意の主流フォーマット間で変換することが可能です。GUIまたはCLIアプリとして利用できます。

このプログラムはまだ初期テスト段階です。問題が発生した場合は、Issuesタブで報告してプログラムの改善にご協力ください！

## 特徴
- 以下のフォーマット間の変換をサポート：
    - ISO / XISO
    - 抽出ファイル（Xex / Xbe / HDD Ready）
    - GoD / Games on Demand
    - CCI
    - CSO
    - ZAR
- シームレスな変換。例えば、GoDイメージを直接抽出したり、ISOをZARアーカイブに変換したり、抽出ディレクトリをCCIアーカイブに変換したり、いかなる一時ファイルも書き込まずに可能です。一時ファイルが必要なのはZAR形式の入力時のみです。
- イメージスクラブ（「部分スクラブ」）、ランダムなパディングを取り除き、出力ファイルを可能な限り短くトリムします。
- イメージ再作成（「完全スクラブ」）、ディスクの構造を完全に書き換え、最小限の出力ファイルサイズを実現します。
- イメージ作成、抽出したファイルから新しいイメージを作成します。
- CCIおよびCSO形式のマルチスレッド圧縮。
- バッチ処理、異なるゲームフォーマットのフォルダを一括して単一フォーマットに変換可能。
- 入力パスに一部のみが提供された場合、自動的に分割ファイルを検出します。ファイル名は ```name.1.extension``` ```name.2.extension``` の形式であることを想定しています。
- ターゲットのアプリ/機種（Xemu、Xenia、OG Xbox、Xbox 360）を選択し、XGDToolに適切な設定を決定させるオプション。
- OG Xbox用のXBE生成を添付可能。
- 正確なファイル命名のためのオンラインデータベース検索（無効化可能）。

## CLIの使い方
```XGDTool.exe <output_format> <settings_flags> <input_path> <output_directory>```

or on Linux

```XGDTool <output_format> <settings_flags> <input_path> <output_directory>```
設定フラグと出力ディレクトリはオプションです。

### 出力形式の引数（相互排他）
- ```--extract```   すべてのファイルをディレクトリに抽出します
- ```--xiso```      Xisoイメージを作成します
- ```--god```       Games on Demandのイメージ/ディレクトリ構造を作成します
- ```--cci```       CCIアーカイブを作成します（Xboxに大きすぎる場合は自動的に分割されます）
- ```--cso```       CSOアーカイブを作成します（Xboxに大きすぎる場合は自動的に分割されます）
- ```--zar```       ZARアーカイブを作成します
- ```--xbe```       アタッチXBEファイルを生成し、入力ファイルは変換しません
- ```--ogxbox```    OG Xbox用の形式と設定を自動的に選択します
- ```--xbox360```   Xbox 360用の形式と設定を自動的に選択します
- ```--xemu```      Xemu用の形式と設定を自動的に選択します
- ```--xenia```     Xenia用の形式と設定を自動的に選択します

情報:
- ```--list```      入力ファイルの内容を一覧表示します
- ```--version```   バージョン情報を表示します
- ```--help```      使用方法を表示します

### 設定フラグ
これらの引数は積み重ね可能ですが、すべての出力形式がそれらを使用するわけではなく、その場合はオプションが無視されます。競合する設定が提供された場合（例：完全/部分スクラブ）、最後の設定が使用されます。
- ```--partial-scrub```  出力イメージをスクラブおよびトリムし、ランダムなパディングデータを削除します。
- ```--full-scrub```     出力イメージを完全に再作成し、可能な限り最小のファイルを生成します。
- ```--split```          出力されるXISOファイルがOG Xboxに対して大きすぎる場合に分割します。
- ```--rename```         出力されるXBEファイルのタイトルフィールドをデータベースにあるものにパッチします。
- ```--attach-xbe```     出力ファイルとともにアタッチXBEファイルを生成します。
- ```--am-patch```       出力されるXBEファイルの「Allowed Media」フィールドにパッチを適用します。
- ```--offline```        オンライン機能を無効にします。
- ```--debug```          デバッグログを有効にします。
- ```--quiet```          警告とエラー以外のすべてのログを無効にします。

## ビルド
デフォルトではGUIとしてコンパイルされます。CLI用にコンパイルするには、Cmakeを```-DENABLE_GUI=OFF```で設定してください。x86用にコンパイルするには、CmakeLists.txtおよびcmake/setup_vcpkg.cmakeファイルにいくつかの変更が必要です。

### Windows
CmakeとMSVCがインストールされていれば、比較的簡単です。プロジェクトはWindows用に設定されており、Cmakeで構成するとプロジェクトディレクトリ内にvcpkgを使ってすべての依存関係を自動的にダウンロードしてビルドします。これはインターネット速度やPCのスペックによって時間がかかる場合がありますが、一度だけ行えばよいです。

このリポジトリをクローンし、ビルドディレクトリを作成してください


```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
GUIとして構成する:  

```
cmake -S .. -B . -G "Visual Studio 17 2022" -A x64
``` 
またはCLIとして: 
```
cmake -S .. -B . -DENABLE_GUI=OFF -G "Visual Studio 17 2022" -A x64
```
ビルド

```
cmake --build . --config Release
```

### Linux
このアプリはまだLinuxで十分にテストされておらず、LinuxはwxWidgetsにいくつかの特異性があるため、GUIが正確に表示されないことがあります。Clangでテストされています。Clangに加えて、MakeやCmakeのほかに、いくつかの依存関係をインストールする必要があります。
```
sudo apt update
sudo apt-get install pkg-config liblz4-dev libzstd-dev libssl-dev libcurl4-openssl-dev libwxgtk3.0-gtk3-dev
```
このリポジトリをクローンし、ビルド用のディレクトリを作成してください
```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
GUIとして設定： 
```
cmake ..
``` 
またはCLIとして: 
```
cmake -DENABLE_GUI=OFF ..
```
ビルド

```
make
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---