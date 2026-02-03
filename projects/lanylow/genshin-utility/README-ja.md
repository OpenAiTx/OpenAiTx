# 原神ユーティリティ [![License](https://img.shields.io/badge/License-GPL3.0-green.svg)](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) ![OS](https://img.shields.io/badge/OS-Windows-yellow.svg) [![Discord](https://img.shields.io/badge/chat-discord-informational)](https://discord.gg/MrtJvV5tKv)

原神と崩壊：スターレイル向けの無料かつオープンソースのツールで、いくつかの利便性向上機能を含みます。ゲームのOS版のみ対応しています。

## FAQ

### モッドの読み込み方法は？
1. [最新リリース](https://github.com/lanylow/genshin-utility/releases)からバイナリをダウンロードして解凍します。
2. `loader.exe`を**管理者として実行**してください。ゲームを待機している旨のウィンドウが表示されます。
3. その状態で、原神または崩壊：スターレイルを起動します。
4. ゲームが起動し、モッドが読み込まれます。

### メニューの開閉はどうやって行いますか？
デフォルトではメニューの切り替えキーは<kbd>INSERT</kbd>ですが、設定ファイルを編集することで変更可能です。

### 設定ファイルはどこに保存されますか？
`genshin-utility`フォルダはドキュメントディレクトリ内にあり、`.ini`形式の設定ファイルが保存されています。アップデート後は設定ファイルの削除および再作成が必要な場合があります。

### 原神ユーティリティのメニューが表示されない場合は？
この問題の最も一般的な原因はサードパーティ製のオーバーレイです。MSI Afterburner（RTSS）やDiscordのゲームオーバーレイなどのプログラムがゲームに付加されていないか確認してください。これらは本ツールのメニューに干渉する可能性があります。もう一つの原因は、ゲームをランチャー経由で起動していないことです。ゲームの実行ファイルを直接起動すると、このプログラムは動作しません。

## スクリーンショット

![image](https://github.com/lanylow/genshin-utility/assets/31806776/88492fe8-4016-447a-80ec-b8c4d9225cc9)

## 利用しているサードパーティライブラリ

* [imgui](https://github.com/ocornut/imgui) - C++用グラフィカルユーザーインターフェース
* [minhook](https://github.com/TsudaKageyu/minhook) - Windows用APIフックライブラリ
* [mini](https://github.com/metayeti/mINI) - INIファイルの読み書きライブラリ

## ライセンス

本プロジェクトはGPL-3.0ライセンスの下で公開されています。詳細は[LICENSE](https://github.com/lanylow/genshin-utility/blob/main/LICENSE)ファイルをご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-03

---