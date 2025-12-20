# twitch-downloader-gui

これは素晴らしいプロジェクト[TwitchDownloader](https://github.com/lay295/TwitchDownloader)のCLI版のGUIラッパーで、Linux専用です。  
私はライブラリ[libui-ng](https://github.com/libui-ng/libui-ng)を使い、いくつかの追加[パッチ](https://github.com/mohad12211/libui-ng)を適用しました。  
このライブラリはまだミッドアルファ段階ですが、有望なプロジェクトで、シンプルでクロスプラットフォーム（macosも対応可能ですが、あまり気にしていません）で非常に直感的です。

# プレビュー

![preview](https://user-images.githubusercontent.com/51754973/167058990-a574493a-fd44-4f12-be59-185798fb93bf.gif)

# インストール

> [!IMPORTANT]
> **これはCLIのラッパーに過ぎません。`TwitchDownloaderCLI`バイナリが必要です。デフォルトではアプリはあなたの`PATH`からバイナリを探します。**  
もし`TwitchDownloaderCLI`を`PATH`に置きたくない場合は、設定からバイナリのパスを指定できます。`TwitchDownloaderCLI`が実行可能であることを確認してください。**

Debian、Fedora、そして[AUR](https://aur.archlinux.org/packages/twitch-downloader-gui)向けにパッケージがあります。

### 依存関係

- ffmpeg（チャットやVODのレンダリングに必要）
- libcurl
- TwitchDownloaderCLI（下記参照）

# ビルド

### ビルド依存関係

- make
- libcurl（開発版）
- gtk3（開発版、Ubuntuではlibgtk-3-devと呼ばれる）

libuiの静的ライブラリはリポジトリにありますが、自分でコンパイルしたバージョンを使い置き換えることもできます。手順は[こちら](https://github.com/mohad12211/libui-ng/blob/customs/README.md#quick-building-instructions)にあります。


```
$ git clone https://github.com/mohad12211/twitch-downloader-gui.git
$ cd twitch-downloader-gui
$ make
$ make install # (if you want to install the app to your system)
$ make uninstall # (to uninstall)
```

バイナリは `build/bin` 内にあります

# 全ての機能が含まれていますか？バグはありますか？

基本的な機能は含まれていますが、タスクキューはありません。

## バグについて...

- VODの最高画質のみダウンロード可能です（近日中に解決予定）。

バグがあればご報告ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---