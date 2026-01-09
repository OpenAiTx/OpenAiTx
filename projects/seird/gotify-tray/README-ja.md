# Gotify Tray


[Gotifyサーバー](https://github.com/gotify/server)からのメッセージを受信するためのトレイ通知アプリケーションです。


## はじめに


- [最新リリースをダウンロードしてください。](https://github.com/seird/gotify-tray/releases/latest)

- または、pipでインストールしてください：
    ```shell
    $ pip install gotify-tray
    ```
- または、ソースから実行：

    ```shell
    $ pip install -r requirements.txt
    $ python -m gotify_tray
    ```
## 特徴

- ネイティブの通知領域でgotifyメッセージを受信します。
- スリープからの復帰やネットワーク接続の喪失後に再接続します。
- 低優先度メッセージの通知バナーを無効にします。
- 受信したメッセージを手動で削除します。
- 以前に受信したすべてのメッセージの履歴を閲覧します。
- ネットワーク接続を失った後に見逃したメッセージを受信します。


## 画像


### メインウィンドウ

デフォルト                                         |  ダーク                                                      
:-------------------------------------------------:|:---------------------------------------------------------:
![main window default](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/main_default.png)            |  ![main window dark](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/main_dark.png)


### 通知バナー

Windows 10                                         |  KDE                                                      |  MacOS 12
:-------------------------------------------------:|:---------------------------------------------------------:|:---------------------------------------------------------:
![notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/notification.png)            |  ![kde_notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/kde_notification.png)      |  ![macos_notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/macos_notification.png)
![notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/notification_centre.png)     |  ![kde_notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/kde_notification_centre.png) |  


## ビルド手順

[BUILDING](https://raw.githubusercontent.com/seird/gotify-tray/develop/BUILDING.md) を参照してください。


## 要件

- python >=3.10




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---