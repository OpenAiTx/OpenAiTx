# **<img src="https://raw.githubusercontent.com/FozerG/WinYandexMusicRPC/main/./assets/YMRPC_ico.ico" alt="[DISCORD RPC]" width="30"/> &nbsp;WinSdk + Yandex Music Discord Rich Presence**
[![TotalDownloads](https://img.shields.io/github/downloads/FozerG/WinYandexMusicRPC/total)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![LastRelease](https://img.shields.io/github/v/release/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![CodeOpen](https://img.shields.io/github/languages/top/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/blob/main/main.py "Show code") [![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download")

>ロシア連邦でのDiscordブロックという無謀な決定にもかかわらず、可能な限りスクリプトの動作をサポートし続けます🕊️

>[私たちは好きなものを使い続けます。](https://github.com/Flowseal/zapret-discord-youtube)

**コンピューターで現在聴いている音楽を表示するためのDiscord RPC。トラックとそのカバーはYandex Musicから読み込まれます。**

<img src="https://github.com/user-attachments/assets/99d15c70-632f-41ec-a6cd-49de8a7d2a8f" alt="discord" width="340">

類似のRPCは存在し、Yandex MusicのAPIを使って現在のトラックを表示しますが、ラジオ（例えば`Моя Волна`）で再生中の情報は表示できません。

そこで、現在のトラック情報を取得するために`Windows.Media.Control`を使用し、Yandex Musicで検索してDiscordにトラックを表示するスクリプトを作成しました。

他のスクリプトと比べた利点：  
Yandex Musicのトークン不要 ✅  
プレイリストやラジオのトラックも表示可能 ✅  
Yandex Musicに限定されず、VKなど他の音楽も聴ける ✅  
ブラウザとアプリの両方で動作 ✅  
一時停止状態を表示 ✅  
トラックの終了までの時間を表示 ✅  
「ゲームをプレイ中」ではなく「聴いている」状態を表示 ✅

## 要件
動作確認はWindows 11とWindows 10のみで、他のバージョンやプラットフォームでは動作しません。**Lite版やCustom版のWindowsでは動作保証されません。**

exeファイルを使わない場合は以下が必要です：  
1. Python <3.14、>=3.10

## Exeのダウンロードと使い方
1. [最新のリリース](https://github.com/FozerG/WinYandexMusicRPC/releases)をダウンロードします

2. WinYandexMusicRPCを開きます

3. スクリプトは3秒後に自動でシステムトレイに隠れます。トレイからコンソールを開いて動作を確認してください。

## main.pyの使い方

1. ターミナルを開き、`requirements.txt`ファイルがあるフォルダーに移動します。
2. 依存関係をインストールするために `pip install -r requirements.txt` を実行します。  
3. ターミナルで `python main.py` と入力します。

>スクリプトを [Pyinstaller](https://pypi.org/project/pyinstaller/) でコンパイルするには、次のコマンドを実行してください。  
`pyinstaller --noconfirm main.spec`

------------  
もしヤンデックスミュージック以外からも音楽を聴いている場合は、`strong_find = True` の行を `strong_find = False` に変更するか、システムトレイを使用することをお勧めします。そうすると検索結果はより良くなりますが、必ずしも正確とは限りません。

## バグ  
バグは常に存在しますが、まずはそれを見つける必要があります🫡  
もしエラーを見つけたら、遠慮なく [Issues](https://github.com/FozerG/WinYandexMusicRPC/issues) に報告してください。

------------  
このプロジェクトに関心を示していただけると、可能な限り更新を続けられます。

>コードは完璧ではありません。Pythonは私のメイン言語ではなく、このスクリプトは個人使用のために作成されました。しかし、あなた自身のスクリプトの基礎になるかもしれません。

>[Yandex Music API](https://github.com/MarshalX/yandex-music-api) を使用しています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---